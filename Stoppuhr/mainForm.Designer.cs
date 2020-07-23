namespace Stoppuhr
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.topPanel = new System.Windows.Forms.Panel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.txtWorkType = new System.Windows.Forms.TextBox();
            this.txtCustomer = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblType = new System.Windows.Forms.Label();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblSeperator1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.timeButton = new Stoppuhr.RoundButton();
            this.closeButton = new Stoppuhr.CloseButton();
            this.maxButton = new Stoppuhr.MaximizeButton();
            this.minButton = new Stoppuhr.MinimizeButton();
            this.topPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.Black;
            this.topPanel.Controls.Add(this.closeButton);
            this.topPanel.Controls.Add(this.maxButton);
            this.topPanel.Controls.Add(this.minButton);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(304, 28);
            this.topPanel.TabIndex = 0;
            this.topPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseDown);
            this.topPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseMove);
            this.topPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseUp);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // txtWorkType
            // 
            this.txtWorkType.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.txtWorkType.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtWorkType.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWorkType.Location = new System.Drawing.Point(139, 336);
            this.txtWorkType.Name = "txtWorkType";
            this.txtWorkType.Size = new System.Drawing.Size(130, 19);
            this.txtWorkType.TabIndex = 2;
            // 
            // txtCustomer
            // 
            this.txtCustomer.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.txtCustomer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCustomer.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.txtCustomer.Location = new System.Drawing.Point(139, 373);
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.Size = new System.Drawing.Size(130, 19);
            this.txtCustomer.TabIndex = 3;
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescription.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.txtDescription.Location = new System.Drawing.Point(139, 410);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(130, 101);
            this.txtDescription.TabIndex = 4;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.ForeColor = System.Drawing.Color.Black;
            this.lblType.Location = new System.Drawing.Point(29, 336);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(104, 18);
            this.lblType.TabIndex = 5;
            this.lblType.Text = "Art des Eintrags";
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.lblCustomer.ForeColor = System.Drawing.Color.Black;
            this.lblCustomer.Location = new System.Drawing.Point(29, 373);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(48, 18);
            this.lblCustomer.TabIndex = 6;
            this.lblCustomer.Text = "Kunde";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.lblDescription.ForeColor = System.Drawing.Color.Black;
            this.lblDescription.Location = new System.Drawing.Point(29, 410);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(92, 18);
            this.lblDescription.TabIndex = 7;
            this.lblDescription.Text = "Beschreibung";
            // 
            // lblSeperator1
            // 
            this.lblSeperator1.AutoSize = true;
            this.lblSeperator1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSeperator1.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeperator1.Location = new System.Drawing.Point(34, 362);
            this.lblSeperator1.Name = "lblSeperator1";
            this.lblSeperator1.Size = new System.Drawing.Size(235, 2);
            this.lblSeperator1.TabIndex = 8;
            this.lblSeperator1.Text = resources.GetString("lblSeperator1.Text");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 1.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 400);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 2);
            this.label1.TabIndex = 9;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // buttonSettings
            // 
            this.buttonSettings.BackColor = System.Drawing.Color.Transparent;
            this.buttonSettings.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonSettings.BackgroundImage")));
            this.buttonSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSettings.FlatAppearance.BorderSize = 0;
            this.buttonSettings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSettings.ForeColor = System.Drawing.Color.Transparent;
            this.buttonSettings.Location = new System.Drawing.Point(12, 38);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(42, 42);
            this.buttonSettings.TabIndex = 10;
            this.buttonSettings.UseVisualStyleBackColor = false;
            this.buttonSettings.Click += new System.EventHandler(this.buttonSettings_Click);
            // 
            // timeButton
            // 
            this.timeButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.timeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.timeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.timeButton.FlatAppearance.BorderSize = 0;
            this.timeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.timeButton.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeButton.ForeColor = System.Drawing.Color.White;
            this.timeButton.Location = new System.Drawing.Point(43, 67);
            this.timeButton.Name = "timeButton";
            this.timeButton.Size = new System.Drawing.Size(226, 226);
            this.timeButton.TabIndex = 1;
            this.timeButton.Text = "00:00:00";
            this.timeButton.UseVisualStyleBackColor = false;
            this.timeButton.Click += new System.EventHandler(this.roundButton1_Click);
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.ClickColor = System.Drawing.Color.Black;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.ForeColor = System.Drawing.Color.White;
            this.closeButton.HoverColor = System.Drawing.Color.LightGray;
            this.closeButton.Location = new System.Drawing.Point(275, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(29, 28);
            this.closeButton.TabIndex = 3;
            this.closeButton.TextLocationX = 3;
            this.closeButton.TextLocationY = -3;
            this.closeButton.TmpColor = System.Drawing.Color.Empty;
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // maxButton
            // 
            this.maxButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maxButton.ClickColor = System.Drawing.Color.Black;
            this.maxButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.maxButton.ForeColor = System.Drawing.Color.White;
            this.maxButton.formState = Stoppuhr.MaximizeButton.CustomFormState.Normal;
            this.maxButton.HoverColor = System.Drawing.Color.LightGray;
            this.maxButton.Location = new System.Drawing.Point(240, 0);
            this.maxButton.Name = "maxButton";
            this.maxButton.Size = new System.Drawing.Size(29, 28);
            this.maxButton.TabIndex = 1;
            this.maxButton.TextLocationX = 7;
            this.maxButton.TextLocationY = 10;
            this.maxButton.TmpColor = System.Drawing.Color.Empty;
            this.maxButton.UseVisualStyleBackColor = true;
            this.maxButton.Click += new System.EventHandler(this.maxButton_Click);
            // 
            // minButton
            // 
            this.minButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minButton.ClickColor = System.Drawing.Color.Black;
            this.minButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minButton.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minButton.ForeColor = System.Drawing.Color.White;
            this.minButton.HoverColor = System.Drawing.Color.LightGray;
            this.minButton.Location = new System.Drawing.Point(205, 0);
            this.minButton.Name = "minButton";
            this.minButton.Size = new System.Drawing.Size(29, 28);
            this.minButton.TabIndex = 2;
            this.minButton.TextLocationX = 3;
            this.minButton.TextLocationY = -8;
            this.minButton.TmpColor = System.Drawing.Color.Empty;
            this.minButton.UseVisualStyleBackColor = true;
            this.minButton.Click += new System.EventHandler(this.minButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 539);
            this.ControlBox = false;
            this.Controls.Add(this.buttonSettings);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSeperator1);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblCustomer);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtCustomer);
            this.Controls.Add(this.txtWorkType);
            this.Controls.Add(this.timeButton);
            this.Controls.Add(this.topPanel);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.topPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private MinimizeButton minButton;
        private MaximizeButton maxButton;
        private RoundButton timeButton;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.TextBox txtWorkType;
        private System.Windows.Forms.TextBox txtCustomer;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblSeperator1;
        private System.Windows.Forms.Label label1;
        private CloseButton closeButton;
        private System.Windows.Forms.Button buttonSettings;
    }
}

