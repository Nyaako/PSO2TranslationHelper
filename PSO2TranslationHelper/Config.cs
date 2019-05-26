namespace PSO2TranslationHelper
{

    public class Config
    {


        public static string DatabaseFileName
        {
            get => (string)Properties.Settings.Default["DatabaseFileName"];
            set => Properties.Settings.Default["DatabaseFileName"] = value;
        }

        public static string LocalGithubFolderPath
        {
            get => (string)Properties.Settings.Default["LocalGithubFolderPath"];
            set => Properties.Settings.Default["LocalGithubFolderPath"] = value;
        }
        public static string EditorPath
        {
            get => (string)Properties.Settings.Default["EditorPath"];
            set => Properties.Settings.Default["EditorPath"] = value;
        }

        public static string EditorArgs
        {
            get => (string)Properties.Settings.Default["EditorArgs"];
            set => Properties.Settings.Default["EditorArgs"] = value;
        }

        public static bool isConfigValid => !(LocalGithubFolderPath == "" || EditorPath == "");
        public static void checkConfigForErrors()
        {
            if (isConfigValid == true) { return; }

            OptionsForm optionsForm = new OptionsForm();
            optionsForm.FormClosing += OptionsForm_FormClosing;
            optionsForm.ShowDialog();
        }

        private static void OptionsForm_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            e.Cancel = !isConfigValid;
        }

    }
}
