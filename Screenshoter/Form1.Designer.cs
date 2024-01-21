namespace ScreenshoterForm
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            takeSingleScreenshot = new Button();
            startScreenshoting = new Button();
            qualityTextbox = new TextBox();
            delayBetweenThePhotos = new TextBox();
            label1 = new Label();
            label2 = new Label();
            descriptionL = new Label();
            button1 = new Button();
            checkBox1 = new CheckBox();
            moreInfoBtn = new Button();
            minimizebtn = new Button();
            panel1 = new Panel();
            textBox1 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // takeSingleScreenshot
            // 
            takeSingleScreenshot.Location = new Point(639, 56);
            takeSingleScreenshot.Name = "takeSingleScreenshot";
            takeSingleScreenshot.Size = new Size(164, 78);
            takeSingleScreenshot.TabIndex = 0;
            takeSingleScreenshot.Text = "Take single screenshot";
            takeSingleScreenshot.UseVisualStyleBackColor = true;
            takeSingleScreenshot.Click += button1_Click;
            // 
            // startScreenshoting
            // 
            startScreenshoting.Location = new Point(628, 323);
            startScreenshoting.Name = "startScreenshoting";
            startScreenshoting.Size = new Size(175, 99);
            startScreenshoting.TabIndex = 1;
            startScreenshoting.Text = "Automatic Mode ";
            startScreenshoting.UseVisualStyleBackColor = true;
            startScreenshoting.Click += button2_Click;
            // 
            // qualityTextbox
            // 
            qualityTextbox.Location = new Point(385, 262);
            qualityTextbox.Name = "qualityTextbox";
            qualityTextbox.Size = new Size(65, 31);
            qualityTextbox.TabIndex = 2;
            // 
            // delayBetweenThePhotos
            // 
            delayBetweenThePhotos.Location = new Point(384, 187);
            delayBetweenThePhotos.Name = "delayBetweenThePhotos";
            delayBetweenThePhotos.Size = new Size(66, 31);
            delayBetweenThePhotos.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(239, 187);
            label1.Name = "label1";
            label1.Size = new Size(102, 25);
            label1.TabIndex = 4;
            label1.Text = "delay in ms";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(239, 262);
            label2.Name = "label2";
            label2.Size = new Size(65, 25);
            label2.TabIndex = 5;
            label2.Text = "quality";
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
            // button1
            // 
            button1.Location = new Point(639, 187);
            button1.Name = "button1";
            button1.Size = new Size(192, 90);
            button1.TabIndex = 8;
            button1.Text = "Manual Series Mode";
            button1.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(239, 323);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(248, 29);
            checkBox1.TabIndex = 9;
            checkBox1.Text = "auto removing old photos";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // moreInfoBtn
            // 
            moreInfoBtn.Location = new Point(66, 243);
            moreInfoBtn.Name = "moreInfoBtn";
            moreInfoBtn.Size = new Size(112, 34);
            moreInfoBtn.TabIndex = 10;
            moreInfoBtn.Text = "More info";
            moreInfoBtn.UseVisualStyleBackColor = true;
            moreInfoBtn.Click += moreInfoBtn_Click;
            // 
            // minimizebtn
            // 
            minimizebtn.Location = new Point(50, 357);
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
            panel1.Controls.Add(textBox1);
            panel1.Location = new Point(239, 395);
            panel1.Name = "panel1";
            panel1.Size = new Size(362, 46);
            panel1.TabIndex = 12;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(220, 9);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(41, 31);
            textBox1.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 12);
            label3.Name = "label3";
            label3.Size = new Size(208, 25);
            label3.TabIndex = 14;
            label3.Text = "delete photos older than";
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(889, 489);
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
            Name = "Form1";
            Text = "Form1";
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
        private Button button1;
        private CheckBox checkBox1;
        private Button moreInfoBtn;
        private Button minimizebtn;
        private Panel panel1;
        private Label label4;
        private Label label3;
        private TextBox textBox1;
    }
}