using System;
using System.Windows.Forms;

namespace PSO2TranslationHelper
{
    public partial class OptionsForm : Form
    {
        public OptionsForm()
        {
            InitializeComponent();
            optionsEditorPathTextbox.DataBindings.Add("Text", Config.EditorPath, "", true, DataSourceUpdateMode.OnPropertyChanged);
            optionsGithubFolderSelectorTextbox.DataBindings.Add("Text", Config.LocalGithubFolderPath, "", true, DataSourceUpdateMode.OnPropertyChanged);
            optionsEditorArgsTextbox.DataBindings.Add("Text", Config.EditorArgs, "", true, DataSourceUpdateMode.OnPropertyChanged);
        }


        private void OptionsGithubFolderSelectorButton_Click(object sender, EventArgs e)
        {

            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Config.LocalGithubFolderPath = dialog.SelectedPath;
                optionsGithubFolderSelectorTextbox.Text = dialog.SelectedPath;
            }
        }

        private void OptionsSelectEditorButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Executables (*.exe)|*.exe";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Config.EditorPath = dialog.FileName;
                optionsEditorPathTextbox.Text = dialog.FileName;
            }
        }

        private void OptionsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default["EditorArgs"] = optionsEditorArgsTextbox.Text;
            Properties.Settings.Default.Save();
        }

        private void OptionsConfirmButton_Click(object sender, EventArgs e)
        {
            //Properties.Settings.Default.Save();
            Close();
        }
    }
}
