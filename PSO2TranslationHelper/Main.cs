using System;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.Windows.Forms;

namespace PSO2TranslationHelper
{
    public partial class Main : Form
    {

        DataTable dt = new DataTable();

        System.Windows.Forms.Timer typeTimer;

        public void PopulateView()
        {
            using (var dbConnection = new SQLiteConnection($"Data Source={Config.DatabaseFileName};"))
            {
                dbConnection.Open();
                //SQLiteDataAdapter dataApp = new SQLiteDataAdapter("select * from texts", dbConnection);
                //DataSet ds = new DataSet();
                translationGridView.RowHeadersVisible = false;
                // dataApp.Fill(ds);

                //translationGridView.DataSource = ds.Tables[0];

                //dt = ds.Tables[0];

                translationGridView.DataSource = dt;
                translationGridView.RowHeadersVisible = true;


            }
        }

        public Main()
        {
            InitializeComponent();

            Config.checkConfigForErrors();

            DatabaseHandler dbHandler = new DatabaseHandler();
            dbHandler.setupDatabaseFirstTime();


            PopulateView();

        }

        private void TranslationSearchBox_TextChanged(object sender, EventArgs e)
        {


            if (typeTimer == null)
            {
                typeTimer = new Timer();
                typeTimer.Interval = 300;
                typeTimer.Tick += new EventHandler(TranslationSearchBox_TypeTimeout);
            }

            typeTimer.Stop();
            typeTimer.Start();

        }
        private void TranslationSearchBox_TypeTimeout(object sender, EventArgs e)
        {
            var timer = sender as Timer;

            if (timer == null)
            {
                return;
            }

            if (translationSearchBox.Text.Length >= 3)
            {
                using (var dbConnection = new SQLiteConnection($"Data Source={Config.DatabaseFileName};"))
                {

                    using (var command = new SQLiteCommand(dbConnection))
                    {

                        SQLiteParameter filenameParameter = new SQLiteParameter("@Filepath");
                        SQLiteParameter identifierParameter = new SQLiteParameter("@Identifier");
                        SQLiteParameter contentsParameter = new SQLiteParameter("@Content");
                        command.Parameters.Add(filenameParameter);
                        command.Parameters.Add(identifierParameter);
                        command.Parameters.Add(contentsParameter);
                        command.CommandText = "SELECT * FROM texts WHERE Filepath LIKE @Filepath OR Identifier LIKE @Identifier OR Content LIKE @Content";


                        filenameParameter.Value = $"%{translationSearchBox.Text}%";
                        identifierParameter.Value = $"%{translationSearchBox.Text}%";
                        contentsParameter.Value = $"%{translationSearchBox.Text}%";
                        SQLiteDataAdapter dataApp = new SQLiteDataAdapter(command);
                        DataSet ds = new DataSet();

                        dataApp.Fill(ds);

                        dt = ds.Tables[0];
                        translationGridView.DataSource = dt;
                    }
                }
            }
            else
            {
                dt.Clear();
            }

            timer.Stop();

            //dt.DefaultView.RowFilter = $"Filepath LIKE '%{translationSearchBox.Text}%' OR Identifier LIKE '%{translationSearchBox.Text}%' OR Content LIKE '%{translationSearchBox.Text}%'";
        }

        private void TranslationGridView_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
        {

            if (e.RowIndex >= dt.Rows.Count || e.ColumnIndex >= dt.Columns.Count)
            {
                return;
            }

            e.Value = dt.Rows[e.RowIndex][e.ColumnIndex];
        }

        private void TranslationGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView searchResults = sender as DataGridView;
            if (searchResults == null)
            {
                return;
            }

            if (searchResults.CurrentRow.Selected)
            {

                string filename = Config.LocalGithubFolderPath + searchResults.CurrentRow.Cells[0].Value.ToString();

                Debug.Print(filename);
                Debug.Print(Config.EditorArgs);
                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    FileName = Config.EditorPath,
                    Arguments = Config.EditorArgs.Replace("{f}", filename)
                };
                Process.Start(startInfo);

                Debug.Print(searchResults.CurrentRow.Cells[0].Value.ToString());
            }
        }

        private void OptionOpenButton_Click(object sender, EventArgs e)
        {
            OptionsForm optionForm = new OptionsForm();
            optionForm.Show();
        }
    }
}
