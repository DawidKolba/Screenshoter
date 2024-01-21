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
            checkBox1 = new CheckBox();
            moreInfoBtn = new Button();
            minimizebtn = new Button();
            panel1 = new Panel();
            label4 = new Label();
            label3 = new Label();
            DeleteOldFilesIfOlderThan = new TextBox();
            CountOfImagesTb = new TextBox();
            label5 = new Label();
            button1 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // takeSingleScreenshot
            // 
            takeSingleScreenshot.Location = new Point(657, 63);
            takeSingleScreenshot.Name = "takeSingleScreenshot";
            takeSingleScreenshot.Size = new Size(164, 78);
            takeSingleScreenshot.TabIndex = 0;
            takeSingleScreenshot.Text = "Take single screenshot";
            takeSingleScreenshot.UseVisualStyleBackColor = true;
            takeSingleScreenshot.Click += button1_Click;
            // 
            // startScreenshoting
            // 
            startScreenshoting.Location = new Point(646, 357);
            startScreenshoting.Name = "startScreenshoting";
            startScreenshoting.Size = new Size(175, 99);
            startScreenshoting.TabIndex = 1;
            startScreenshoting.Text = "Start Automatic Mode ";
            startScreenshoting.UseVisualStyleBackColor = true;
            startScreenshoting.Click += button2_Click;
            // 
            // qualityTextbox
            // 
            qualityTextbox.Location = new Point(434, 232);
            qualityTextbox.Name = "qualityTextbox";
            qualityTextbox.Size = new Size(65, 31);
            qualityTextbox.TabIndex = 2;
            // 
            // delayBetweenThePhotos
            // 
            delayBetweenThePhotos.Location = new Point(434, 187);
            delayBetweenThePhotos.Name = "delayBetweenThePhotos";
            delayBetweenThePhotos.Size = new Size(66, 31);
            delayBetweenThePhotos.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(352, 193);
            label1.Name = "label1";
            label1.Size = new Size(60, 25);
            label1.TabIndex = 4;
            label1.Text = "Delay:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(282, 235);
            label2.Name = "label2";
            label2.Size = new Size(130, 25);
            label2.TabIndex = 5;
            label2.Text = "Photos quality:";
            // 
            // descriptionL
            // 
            descriptionL.AutoSize = true;
            descriptionL.Location = new Point(31, 41);
            descriptionL.Name = "descriptionL";
            descriptionL.Size = new Size(536, 100);
            descriptionL.TabIndex = 6;
            descriptionL.Text = resources.GetString("descriptionL.Text");
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(218, 393);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(251, 29);
            checkBox1.TabIndex = 9;
            checkBox1.Text = "Auto removing old photos";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // moreInfoBtn
            // 
            moreInfoBtn.Location = new Point(468, 25);
            moreInfoBtn.Name = "moreInfoBtn";
            moreInfoBtn.Size = new Size(112, 34);
            moreInfoBtn.TabIndex = 10;
            moreInfoBtn.Text = "More info";
            moreInfoBtn.UseVisualStyleBackColor = true;
            moreInfoBtn.Click += moreInfoBtn_Click;
            // 
            // minimizebtn
            // 
            minimizebtn.Location = new Point(12, 412);
            minimizebtn.Name = "minimizebtn";
            minimizebtn.Size = new Size(107, 65);
            minimizebtn.TabIndex = 11;
            minimizebtn.Text = "minimize";
            minimizebtn.UseVisualStyleBackColor = true;
            minimizebtn.Click += minimizebtn_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(DeleteOldFilesIfOlderThan);
            panel1.Location = new Point(218, 431);
            panel1.Name = "panel1";
            panel1.Size = new Size(362, 46);
            panel1.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(267, 12);
            label4.Name = "label4";
            label4.Size = new Size(49, 25);
            label4.TabIndex = 15;
            label4.Text = "days";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 12);
            label3.Name = "label3";
            label3.Size = new Size(210, 25);
            label3.TabIndex = 14;
            label3.Text = "Delete photos older than";
            // 
            // DeleteOldFilesIfOlderThan
            // 
            DeleteOldFilesIfOlderThan.Location = new Point(220, 9);
            DeleteOldFilesIfOlderThan.Name = "DeleteOldFilesIfOlderThan";
            DeleteOldFilesIfOlderThan.Size = new Size(41, 31);
            DeleteOldFilesIfOlderThan.TabIndex = 13;
            // 
            // CountOfImagesTb
            // 
            CountOfImagesTb.Location = new Point(434, 289);
            CountOfImagesTb.Name = "CountOfImagesTb";
            CountOfImagesTb.Size = new Size(66, 31);
            CountOfImagesTb.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(45, 289);
            label5.Name = "label5";
            label5.Size = new Size(367, 25);
            label5.TabIndex = 14;
            label5.Text = "Count of screenshots in manual series mode:";
            // 
            // button1
            // 
            button1.Location = new Point(639, 170);
            button1.Name = "button1";
            button1.Size = new Size(192, 90);
            button1.TabIndex = 8;
            button1.Text = "Manual Series Mode";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // ScreenshoterMainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(889, 489);
            Controls.Add(label5);
            Controls.Add(CountOfImagesTb);
            Controls.Add(panel1);
            Controls.Add(minimizebtn);
            Controls.Add(moreInfoBtn);
            Controls.Add(checkBox1);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(qualityTextbox);
            Controls.Add(descriptionL);
            Controls.Add(delayBetweenThePhotos);
            Controls.Add(label1);
            Controls.Add(startScreenshoting);
            Controls.Add(takeSingleScreenshot);
            Name = "ScreenshoterMainForm";
            Text = "Screenshoter";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private CheckBox checkBox1;
        private Button moreInfoBtn;
        private Button minimizebtn;
        private Panel panel1;
        private Label label4;
        private Label label3;
        private TextBox DeleteOldFilesIfOlderThan;
        private TextBox CountOfImagesTb;
        private Label label5;
        private Button button1;
    }
}