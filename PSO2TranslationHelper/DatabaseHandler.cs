using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Diagnostics;
using System.IO;
using System.Threading;

namespace PSO2TranslationHelper
{
    public class TupleList<T1, T2, T3> : List<Tuple<T1, T2, T3>>
    {
        public void Add(T1 item, T2 item2, T3 item3)
        {
            Add(new Tuple<T1, T2, T3>(item, item2, item3));
        }
    }

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

                IEnumerable<string> files = Directory.EnumerateFiles($@"{Config.LocalGithubFolderPath}", "*.csv", SearchOption.AllDirectories);

                command.CommandText = "INSERT INTO texts VALUES (@Filename, @Identifier, @Content)";
                SQLiteParameter filenameParameter = new SQLiteParameter("@Filename");
                SQLiteParameter identifierParameter = new SQLiteParameter("@Identifier");
                SQLiteParameter contentsParameter = new SQLiteParameter("@Content");

                command.Parameters.Add(filenameParameter);
                command.Parameters.Add(identifierParameter);
                command.Parameters.Add(contentsParameter);

                var cmdparas = new TupleList<string, string, string> { };

                foreach (string fname in files)
                {
                    try
                    {
                        IEnumerable<string> lines = File.ReadLines(fname);
                        string fpath = $"{Path.GetDirectoryName(fname).Replace(Config.LocalGithubFolderPath, "")}\\{Path.GetFileName(fname)}";
                        foreach (string line in lines)
                        {
                            string[] arr = line.Split(splitchar, 2);
                            arr[1] = arr[1].Trim(" \"\"\" ".ToCharArray());
                            cmdparas.Add(fpath, arr[0], arr[1]);
                        }
                        count++;
                    }
                    catch (Exception ex)
                    {
                        Debug.Print(ex.Message);
                    }
                }

                using (var transaction = dbConnection.BeginTransaction())
                {
                    foreach (Tuple<string, string, string> args in cmdparas)
                    {
                        filenameParameter.Value = args.Item1;
                        identifierParameter.Value = args.Item2;
                        contentsParameter.Value = args.Item3;
                        command.ExecuteNonQuery();
                    }

                    transaction.Commit();
                }
                dbConnection.Close();
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
