using System;
using System.Windows.Forms;

namespace StopClock
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void settingsForm_Load(object sender, EventArgs e)
        {
            LoadSavePathFromSettingsIntoLabel();
        }

        private void LoadSavePathFromSettingsIntoLabel()
        {
            lblSavePath.Text = DataHandler.GetOverviewFolderPathFromUserSettings();
        }

        private void btnSaveSettings_Click(object sender, EventArgs e)
        {
            DataHandler.SetOverViewFolderPath(lblSavePath.Text);
            Close();
        }

        private void btnCancelSettings_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnChoosePath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
            folderBrowser.ShowNewFolderButton = true;
            folderBrowser.Description = "Speicherordner auswählen";
            DialogResult result = folderBrowser.ShowDialog();

            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowser.SelectedPath))
            {
                DataHandler.SetOverViewFolderPath(folderBrowser.SelectedPath);
                lblSavePath.Text = DataHandler.GetOverviewFolderPathFromUserSettings();
            }
        }
    }
}
