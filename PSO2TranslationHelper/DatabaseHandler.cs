using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace PSO2TranslationHelper
{
    class DatabaseHandler
    {
        public void populateDatabase()
        {
            using (var dbConnection = new SQLiteConnection($"Data Source={Config.DatabaseFileName};"))
            {
                int count = 0;
                char[] splitchar = { ',' };

                var stopwatch = new Stopwatch();
                stopwatch.Start();

                dbConnection.Open();
                SQLiteCommand command = new SQLiteCommand(dbConnection);
                command.CommandText = "CREATE TABLE IF NOT EXISTS texts (Filepath STRING, Identifier STRING, Content STRING)";
                command.ExecuteNonQuery();
                command.Dispose();

                IEnumerable<string> files = Directory.EnumerateFiles($@"{Config.LocalGithubFolderPath}", "*.csv", SearchOption.AllDirectories);

                var cmdparas = new ConcurrentBag<Tuple<string, string, string>> { };

                var stopwatch2 = new Stopwatch();
                stopwatch2.Start();

                Parallel.ForEach(files, fname =>
                {
                    try
                    {
                        IEnumerable<string> lines = File.ReadLines(fname);
                        string fpath = $"{Path.GetDirectoryName(fname).Replace(Config.LocalGithubFolderPath, "")}\\{Path.GetFileName(fname)}";
                        foreach (string line in lines)
                        {
                            string[] arr = line.Split(splitchar, 2);
                            arr[1] = arr[1].Trim(" \"\"\" ".ToCharArray());
                            cmdparas.Add(Tuple.Create(fpath,arr[0],arr[1]));
                        }
                        count++;
                    }
                    catch (Exception ex)
                    {
                        Debug.Print(ex.Message);
                    }
                });

                stopwatch2.Stop();

                Debug.Print($"Stopwatch on File Parse: {stopwatch2.ElapsedMilliseconds}ms");

                using (var transaction = dbConnection.BeginTransaction())
                {
                    using (command = new SQLiteCommand("INSERT INTO texts VALUES (@Filename, @Identifier, @Content)", dbConnection, transaction))
                    {
                        
                        SQLiteParameter filenameParameter = new SQLiteParameter("@Filename");
                        SQLiteParameter identifierParameter = new SQLiteParameter("@Identifier");
                        SQLiteParameter contentsParameter = new SQLiteParameter("@Content");

                        command.Parameters.Add(filenameParameter);
                        command.Parameters.Add(identifierParameter);
                        command.Parameters.Add(contentsParameter);

                        while (!cmdparas.IsEmpty)
                        {
                            cmdparas.TryTake(out Tuple<string, string, string> test);
                            filenameParameter.Value = test.Item1;
                            identifierParameter.Value = test.Item2;
                            contentsParameter.Value = test.Item3;
                            command.ExecuteNonQuery();
                        }

                        transaction.Commit();
                        command.Dispose();
                    }
                }

                dbConnection.Close();
                GC.Collect();
                Debug.Print($"Processed {count} files.");
                Debug.Print($"Time taken to generate DB: {stopwatch.ElapsedMilliseconds}ms");
            }
        }
        public void setupDatabaseFirstTime()
        {
            if (File.Exists(Config.DatabaseFileName))
            {
                return;
            }

            SQLiteConnection.CreateFile(Config.DatabaseFileName);
            Thread test = new Thread(populateDatabase);
            test.Start();
        }
    }
}
