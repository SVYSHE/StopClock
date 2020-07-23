
using System.Windows.Forms;
using System;
using System.IO;

namespace Stoppuhr
{
    public static class DataHandler
    {
        public static string GetOverviewFolderPathFromUserSettings()
        {
            return Properties.Settings.Default.Speicherpfad;
        }

        public static void SetOverViewFolderPath(string path)
        {
            Properties.Settings.Default.Speicherpfad = path;
            Properties.Settings.Default.Save();
        }

        public static void HandleDataset(DataSet dataset)
        {
            if (!OverviewFolderExists())
            {
                CreateOverviewFolder();
            }

            if (TodaysOverviewExists())
            {
                WriteDataSetToCsvFile(dataset);
            }
            else
            {
                CreateTodaysOverview();
                WriteDataSetToCsvFile(dataset);
            }
        }


        private static string GetTodaysOverviewPathAsString()
        {
            return $@"{GetOverviewFolderPathFromUserSettings()}/Overview{DateTime.Now.Day}-{DateTime.Now.Month}-{DateTime.Now.Year}.txt";
        }

        private static bool TodaysOverviewExists()
        {
            if (File.Exists(GetTodaysOverviewPathAsString()))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static bool OverviewFolderExists()
        {
            if (Directory.Exists(GetOverviewFolderPathFromUserSettings()))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static void CreateOverviewFolder()
        {
            try
            {
                Directory.CreateDirectory(GetOverviewFolderPathFromUserSettings());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
        }

        

        private static void CreateTodaysOverview()
        {
            File.Create(GetTodaysOverviewPathAsString()).Close();
        }

        private static void WriteDataSetToCsvFile(DataSet dataset)
        {
            try
            {
                File.AppendAllText(GetTodaysOverviewPathAsString(), $"{dataset.WorkType};{dataset.Duration};{dataset.Customer};{dataset.Description}\n");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw new IOException();
            }         
        }
    }
}
