namespace ScreenshoterForm
{
    partial class ScreenshoterMainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
                _shortcutManager.Dispose();
            }
            base.Dispose(disposing);

        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScreenshoterMainForm));
            takeSingleScreenshot = new Button();
            startScreenshoting = new Button();
            qualityTextbox = new TextBox();
            delayBetweenThePhotos = new TextBox();
            label1 = new Label();
            label2 = new Label();
            descriptionL = new Label();
            removeoldPhotosCb = new CheckBox();
            moreInfoBtn = new Button();
            minimizebtn = new Button();
            deleteOldFilesPanel = new Panel();
            label4 = new Label();
            label3 = new Label();
            deleteOldFilesIfOlderThan = new TextBox();
            CountOfImagesTb = new TextBox();
            label5 = new Label();
            manualSeriesScreenshotBtn = new Button();
            saveCfg = new Button();
            deleteOldFilesPanel.SuspendLayout();
            SuspendLayout();
            // 
            // takeSingleScreenshot
            // 
            takeSingleScreenshot.Location = new Point(590, 98);
            takeSingleScreenshot.Name = "takeSingleScreenshot";
            takeSingleScreenshot.Size = new Size(144, 71);
            takeSingleScreenshot.TabIndex = 0;
            takeSingleScreenshot.Text = "Take single screenshot";
            takeSingleScreenshot.UseVisualStyleBackColor = true;
            takeSingleScreenshot.Click += takeSingleScreenshot_Click;
            // 
            // startScreenshoting
            // 
            startScreenshoting.Location = new Point(590, 296);
            startScreenshoting.Name = "startScreenshoting";
            startScreenshoting.Size = new Size(149, 60);
            startScreenshoting.TabIndex = 1;
            startScreenshoting.Text = "Start Automatic Mode ";
            startScreenshoting.UseVisualStyleBackColor = true;
            startScreenshoting.Click += startScreenshoting_Click;
            // 
            // qualityTextbox
            // 
            qualityTextbox.Location = new Point(391, 213);
            qualityTextbox.Name = "qualityTextbox";
            qualityTextbox.Size = new Size(59, 30);
            qualityTextbox.TabIndex = 2;
            // 
            // delayBetweenThePhotos
            // 
            delayBetweenThePhotos.Location = new Point(391, 172);
            delayBetweenThePhotos.Name = "delayBetweenThePhotos";
            delayBetweenThePhotos.Size = new Size(60, 30);
            delayBetweenThePhotos.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(317, 178);
            label1.Name = "label1";
            label1.Size = new Size(56, 23);
            label1.TabIndex = 4;
            label1.Text = "Delay:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(254, 216);
            label2.Name = "label2";
            label2.Size = new Size(123, 23);
            label2.TabIndex = 5;
            label2.Text = "Photos quality:";
            // 
            // descriptionL
            // 
            descriptionL.AutoSize = true;
            descriptionL.Location = new Point(28, 38);
            descriptionL.Name = "descriptionL";
            descriptionL.Size = new Size(512, 92);
            descriptionL.TabIndex = 6;
            descriptionL.Text = resources.GetString("descriptionL.Text");
            // 
            // checkBox1
            // 
            removeoldPhotosCb.AutoSize = true;
            removeoldPhotosCb.Location = new Point(196, 362);
            removeoldPhotosCb.Name = "checkBox1";
            removeoldPhotosCb.Size = new Size(230, 27);
            removeoldPhotosCb.TabIndex = 9;
            removeoldPhotosCb.Text = "Auto removing old photos";
            removeoldPhotosCb.UseVisualStyleBackColor = true;
            removeoldPhotosCb.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // moreInfoBtn
            // 
            moreInfoBtn.Location = new Point(439, 23);
            moreInfoBtn.Name = "moreInfoBtn";
            moreInfoBtn.Size = new Size(101, 31);
            moreInfoBtn.TabIndex = 10;
            moreInfoBtn.Text = "More info";
            moreInfoBtn.UseVisualStyleBackColor = true;
            moreInfoBtn.Click += moreInfoBtn_Click;
            // 
            // minimizebtn
            // 
            minimizebtn.Location = new Point(11, 379);
            minimizebtn.Name = "minimizebtn";
            minimizebtn.Size = new Size(96, 60);
            minimizebtn.TabIndex = 11;
            minimizebtn.Text = "minimize";
            minimizebtn.UseVisualStyleBackColor = true;
            minimizebtn.Click += minimizebtn_Click;
            // 
            // panel1
            // 
            deleteOldFilesPanel.Controls.Add(label4);
            deleteOldFilesPanel.Controls.Add(label3);
            deleteOldFilesPanel.Controls.Add(deleteOldFilesIfOlderThan);
            deleteOldFilesPanel.Location = new Point(196, 397);
            deleteOldFilesPanel.Name = "DeleteOldFilesPanel";
            deleteOldFilesPanel.Size = new Size(326, 42);
            deleteOldFilesPanel.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(255, 11);
            label4.Name = "label4";
            label4.Size = new Size(44, 23);
            label4.TabIndex = 15;
            label4.Text = "days";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(5, 11);
            label3.Name = "label3";
            label3.Size = new Size(201, 23);
            label3.TabIndex = 14;
            label3.Text = "Delete photos older than";
            // 
            // DeleteOldFilesIfOlderThan
            // 
            deleteOldFilesIfOlderThan.Location = new Point(212, 8);
            deleteOldFilesIfOlderThan.Name = "DeleteOldFilesIfOlderThan";
            deleteOldFilesIfOlderThan.Size = new Size(37, 30);
            deleteOldFilesIfOlderThan.TabIndex = 13;
            // 
            // CountOfImagesTb
            // 
            CountOfImagesTb.Location = new Point(391, 266);
            CountOfImagesTb.Name = "CountOfImagesTb";
            CountOfImagesTb.Size = new Size(60, 30);
            CountOfImagesTb.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(40, 266);
            label5.Name = "label5";
            label5.Size = new Size(352, 23);
            label5.TabIndex = 14;
            label5.Text = "Count of screenshots in manual series mode:";
            // 
            // button1
            // 
            manualSeriesScreenshotBtn.Location = new Point(589, 192);
            manualSeriesScreenshotBtn.Name = "button1";
            manualSeriesScreenshotBtn.Size = new Size(145, 70);
            manualSeriesScreenshotBtn.TabIndex = 8;
            manualSeriesScreenshotBtn.Text = "Manual Series Mode";
            manualSeriesScreenshotBtn.UseVisualStyleBackColor = true;
            manualSeriesScreenshotBtn.Click += manualSeriesScreenshotBtn_Click;
            // 
            // saveCfg
            // 
            saveCfg.Location = new Point(660, 408);
            saveCfg.Name = "saveCfg";
            saveCfg.Size = new Size(128, 32);
            saveCfg.TabIndex = 15;
            saveCfg.Text = "Save Config";
            saveCfg.UseVisualStyleBackColor = true;
            saveCfg.Click += saveCfg_Click;
            // 
            // ScreenshoterMainForm
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(saveCfg);
            Controls.Add(label5);
            Controls.Add(CountOfImagesTb);
            Controls.Add(deleteOldFilesPanel);
            Controls.Add(minimizebtn);
            Controls.Add(moreInfoBtn);
            Controls.Add(removeoldPhotosCb);
            Controls.Add(manualSeriesScreenshotBtn);
            Controls.Add(label2);
            Controls.Add(qualityTextbox);
            Controls.Add(descriptionL);
            Controls.Add(delayBetweenThePhotos);
            Controls.Add(label1);
            Controls.Add(startScreenshoting);
            Controls.Add(takeSingleScreenshot);
            Name = "ScreenshoterMainForm";
            Text = "Screenshoter";
            deleteOldFilesPanel.ResumeLayout(false);
            deleteOldFilesPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button takeSingleScreenshot;
        private Button startScreenshoting;
        private TextBox qualityTextbox;
        private TextBox delayBetweenThePhotos;
        private Label label1;
        private Label label2;
        private Label descriptionL;
        private CheckBox removeoldPhotosCb;
        private Button moreInfoBtn;
        private Button minimizebtn;
        private Panel deleteOldFilesPanel;
        private Label label4;
        private Label label3;
        private TextBox deleteOldFilesIfOlderThan;
        private TextBox CountOfImagesTb;
        private Label label5;
        private Button manualSeriesScreenshotBtn;
        private Button saveCfg;
    }
}