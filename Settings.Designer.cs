namespace CatsLoveMathsAWD
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.button2 = new System.Windows.Forms.Button();
            this.music_slider = new System.Windows.Forms.TrackBar();
            this.music_btn = new System.Windows.Forms.CheckBox();
            this.sound_btn = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.back_btn = new System.Windows.Forms.Button();
            this.sound_slider = new System.Windows.Forms.TrackBar();
            this.sound_percent = new System.Windows.Forms.Label();
            this.music_percent = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.music_slider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sound_slider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.button2.Location = new System.Drawing.Point(-134, -40);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 52);
            this.button2.TabIndex = 45;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // music_slider
            // 
            this.music_slider.AutoSize = false;
            this.music_slider.Location = new System.Drawing.Point(162, 210);
            this.music_slider.Maximum = 100;
            this.music_slider.Name = "music_slider";
            this.music_slider.Size = new System.Drawing.Size(144, 31);
            this.music_slider.TabIndex = 44;
            this.music_slider.TickStyle = System.Windows.Forms.TickStyle.None;
            this.music_slider.Value = 50;
            this.music_slider.Visible = false;
            this.music_slider.Scroll += new System.EventHandler(this.music_slider_Scroll);
            // 
            // music_btn
            // 
            this.music_btn.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.music_btn.Font = new System.Drawing.Font("Hobo Std", 17F);
            this.music_btn.ForeColor = System.Drawing.Color.White;
            this.music_btn.Location = new System.Drawing.Point(45, 210);
            this.music_btn.Name = "music_btn";
            this.music_btn.Size = new System.Drawing.Size(102, 31);
            this.music_btn.TabIndex = 43;
            this.music_btn.Text = "Music";
            this.music_btn.UseVisualStyleBackColor = true;
            this.music_btn.CheckedChanged += new System.EventHandler(this.music_btn_CheckedChanged);
            // 
            // sound_btn
            // 
            this.sound_btn.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.sound_btn.Font = new System.Drawing.Font("Hobo Std", 17F);
            this.sound_btn.ForeColor = System.Drawing.Color.White;
            this.sound_btn.Location = new System.Drawing.Point(43, 138);
            this.sound_btn.Name = "sound_btn";
            this.sound_btn.Size = new System.Drawing.Size(104, 31);
            this.sound_btn.TabIndex = 41;
            this.sound_btn.Text = "Sound";
            this.sound_btn.UseVisualStyleBackColor = true;
            this.sound_btn.CheckedChanged += new System.EventHandler(this.sound_btn_CheckedChanged);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Hobo Std", 30F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(126, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 55);
            this.label2.TabIndex = 39;
            this.label2.Text = "Settings";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // back_btn
            // 
            this.back_btn.BackColor = System.Drawing.Color.SlateBlue;
            this.back_btn.FlatAppearance.BorderSize = 0;
            this.back_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back_btn.Font = new System.Drawing.Font("Hobo Std", 17F);
            this.back_btn.ForeColor = System.Drawing.Color.White;
            this.back_btn.Location = new System.Drawing.Point(45, 288);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(326, 44);
            this.back_btn.TabIndex = 49;
            this.back_btn.Text = "Back";
            this.back_btn.UseVisualStyleBackColor = false;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // sound_slider
            // 
            this.sound_slider.AutoSize = false;
            this.sound_slider.Location = new System.Drawing.Point(162, 142);
            this.sound_slider.Maximum = 100;
            this.sound_slider.Name = "sound_slider";
            this.sound_slider.Size = new System.Drawing.Size(144, 27);
            this.sound_slider.TabIndex = 50;
            this.sound_slider.TickStyle = System.Windows.Forms.TickStyle.None;
            this.sound_slider.Value = 50;
            this.sound_slider.Visible = false;
            this.sound_slider.Scroll += new System.EventHandler(this.sound_slider_Scroll);
            // 
            // sound_percent
            // 
            this.sound_percent.AutoSize = true;
            this.sound_percent.Font = new System.Drawing.Font("Hobo Std", 17F);
            this.sound_percent.ForeColor = System.Drawing.Color.White;
            this.sound_percent.Location = new System.Drawing.Point(312, 136);
            this.sound_percent.Name = "sound_percent";
            this.sound_percent.Size = new System.Drawing.Size(59, 33);
            this.sound_percent.TabIndex = 51;
            this.sound_percent.Text = "50%";
            // 
            // music_percent
            // 
            this.music_percent.AutoSize = true;
            this.music_percent.Font = new System.Drawing.Font("Hobo Std", 17F);
            this.music_percent.ForeColor = System.Drawing.Color.White;
            this.music_percent.Location = new System.Drawing.Point(312, 210);
            this.music_percent.Name = "music_percent";
            this.music_percent.Size = new System.Drawing.Size(59, 33);
            this.music_percent.TabIndex = 52;
            this.music_percent.Text = "50%";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CatsLoveMathsAWD.Properties.Resources.settinglogo1;
            this.pictureBox1.Location = new System.Drawing.Point(93, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 53;
            this.pictureBox1.TabStop = false;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(425, 395);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.music_percent);
            this.Controls.Add(this.sound_percent);
            this.Controls.Add(this.sound_slider);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.music_slider);
            this.Controls.Add(this.music_btn);
            this.Controls.Add(this.sound_btn);
            this.Controls.Add(this.label2);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.music_slider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sound_slider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TrackBar music_slider;
        private System.Windows.Forms.CheckBox music_btn;
        private System.Windows.Forms.CheckBox sound_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.TrackBar sound_slider;
        private System.Windows.Forms.Label sound_percent;
        private System.Windows.Forms.Label music_percent;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}