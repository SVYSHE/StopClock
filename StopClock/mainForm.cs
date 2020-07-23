using System;
using System.Drawing;
using System.Windows.Forms;

namespace Stoppuhr
{
    public partial class MainForm : Form
    {

        // private members
        private Point offset;
        private Size normalWindowSize;
        private Point normalWindowLocation = Point.Empty;
        private bool isWindowMaximized;

        // properties
        public bool IsTopPanelDragged { get; set; }

        public Point Offset { get; set; }


        // functionality
        public MainForm()
        {
            InitializeComponent();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            // Nothing to do here.
        }

        private void topPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                IsTopPanelDragged = true;

                Point pointStartPosition = this.PointToScreen(new Point(e.X, e.Y));

                offset = new Point();
                offset.X = this.Location.X - pointStartPosition.X;
                offset.Y = this.Location.Y - pointStartPosition.Y;
            }
            else
            {
                IsTopPanelDragged = false;
            }
        }

        private void topPanel_MouseUp(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                IsTopPanelDragged = false;
            }
            
        }

        private void topPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (IsTopPanelDragged)
            {
                Point newPoint = topPanel.PointToScreen(new Point(e.X, e.Y));
                newPoint.Offset(offset);
                this.Location = newPoint;
            }
        }

        private void minButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void maxButton_Click(object sender, EventArgs e)
        {
            if (isWindowMaximized)
            {
                MinimizeWindow();
            }
            else
            {
                MaximizeWindow();
            }
        }

        private void MaximizeWindow()
        {
            normalWindowSize = Size;
            normalWindowLocation = Location;

            Rectangle rectangle = Screen.PrimaryScreen.WorkingArea;
            Location = new Point(0, 0);
            Size = new Size(rectangle.Width, rectangle.Height);
            maxButton.formState = MaximizeButton.CustomFormState.Maximized;
            isWindowMaximized = true;
        }

        private void MinimizeWindow()
        {
            Location = normalWindowLocation;
            Size = normalWindowSize;
            maxButton.formState = MaximizeButton.CustomFormState.Normal;
            isWindowMaximized = false;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            TimeSpan ts = timeButton.stopw.Elapsed;
            timeButton.Text = String.Format("{0:00}:{1:00}:{2:00}", ts.Hours, ts.Minutes, ts.Seconds);
        }

        private void roundButton1_Click(object sender, EventArgs e)
        {
            if (!timeButton.stopw.IsRunning)
            {
                StartTimer();
            }
            else
            {
                DataHandler.HandleDataset(CreateDataSetFromControlValues());
                StopAndResetTimer();
            }
        }

        private DataSet CreateDataSetFromControlValues()
        {
            DataSet dataset = new DataSet();
            TimeSpan ts = timeButton.stopw.Elapsed;
            dataset.Duration = String.Format("{0:00}:{1:00}:{2:00}", ts.Hours, ts.Minutes, ts.Seconds);
            dataset.WorkType = txtWorkType.Text;
            dataset.Description = txtDescription.Text;
            dataset.Customer = txtCustomer.Text;

            return dataset;
        }

        private void StopAndResetTimer()
        {
            timeButton.stopw.Stop();
            timer.Enabled = false;
            timeButton.stopw.Reset();
        }

        private void StartTimer()
        {
            timeButton.stopw.Start();
            timer.Enabled = true;
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm();
            settingsForm.Show();
        }
    }
}
