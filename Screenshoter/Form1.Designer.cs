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
            takeSingleScreenshot = new Button();
            startScreenshoting = new Button();
            qualityTextbox = new TextBox();
            delayBetweenThePhotos = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            takeSingleScreenshot.Location = new Point(365, 108);
            takeSingleScreenshot.Name = "take 1 screenshot";
            takeSingleScreenshot.Size = new Size(90, 48);
            takeSingleScreenshot.TabIndex = 0;
            takeSingleScreenshot.Text = "button1";
            takeSingleScreenshot.UseVisualStyleBackColor = true;
            takeSingleScreenshot.Click += button1_Click;
            // 
            // button2
            // 
            startScreenshoting.Location = new Point(638, 320);
            startScreenshoting.Name = "start screenshoting";
            startScreenshoting.Size = new Size(85, 37);
            startScreenshoting.TabIndex = 1;
            startScreenshoting.Text = "start capture";
            startScreenshoting.UseVisualStyleBackColor = true;
            startScreenshoting.Click += button2_Click;
            // 
            // textBox1
            // 
            qualityTextbox.Location = new Point(454, 327);
            qualityTextbox.Name = "textBox1";
            qualityTextbox.Size = new Size(59, 30);
            qualityTextbox.TabIndex = 2;
            // 
            // textBox2
            // 
            delayBetweenThePhotos.Location = new Point(454, 381);
            delayBetweenThePhotos.Name = "textBox2";
            delayBetweenThePhotos.Size = new Size(60, 30);
            delayBetweenThePhotos.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(338, 381);
            label1.Name = "label1";
            label1.Size = new Size(96, 23);
            label1.TabIndex = 4;
            label1.Text = "delay in ms";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(338, 330);
            label2.Name = "label2";
            label2.Size = new Size(61, 23);
            label2.TabIndex = 5;
            label2.Text = "quality";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(delayBetweenThePhotos);
            Controls.Add(qualityTextbox);
            Controls.Add(startScreenshoting);
            Controls.Add(takeSingleScreenshot);
            Name = "Form1";
            Text = "Form1";
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
    }
}