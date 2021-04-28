namespace CatsLoveMathsAWD
{
    partial class Startscreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Startscreen));
            this.user = new System.Windows.Forms.Label();
            this.profilepic = new System.Windows.Forms.PictureBox();
            this.exit_btn = new System.Windows.Forms.Button();
            this.panel_out = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.reg_btn = new System.Windows.Forms.Button();
            this.login_btn = new System.Windows.Forms.Button();
            this.pw = new System.Windows.Forms.TextBox();
            this.un = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.highscore_btn = new System.Windows.Forms.Button();
            this.setting_btn = new System.Windows.Forms.Button();
            this.panel_in = new System.Windows.Forms.Panel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.progress = new System.Windows.Forms.Label();
            this.start_btn = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.id = new System.Windows.Forms.Label();
            this.logout_btn = new System.Windows.Forms.Button();
            this.profile_panel = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.time_lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.profilepic)).BeginInit();
            this.panel_out.SuspendLayout();
            this.panel_in.SuspendLayout();
            this.profile_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // user
            // 
            this.user.Font = new System.Drawing.Font("Tahoma", 16F);
            this.user.ForeColor = System.Drawing.Color.White;
            this.user.Image = ((System.Drawing.Image)(resources.GetObject("user.Image")));
            this.user.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.user.Location = new System.Drawing.Point(109, 19);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(201, 46);
            this.user.TabIndex = 0;
            this.user.Text = "user";
            this.user.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // profilepic
            // 
            this.profilepic.Image = ((System.Drawing.Image)(resources.GetObject("profilepic.Image")));
            this.profilepic.Location = new System.Drawing.Point(14, 7);
            this.profilepic.Name = "profilepic";
            this.profilepic.Size = new System.Drawing.Size(92, 89);
            this.profilepic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profilepic.TabIndex = 9;
            this.profilepic.TabStop = false;
            this.profilepic.Click += new System.EventHandler(this.profilepic_Click);
            // 
            // exit_btn
            // 
            this.exit_btn.BackColor = System.Drawing.Color.Transparent;
            this.exit_btn.BackgroundImage = global::CatsLoveMathsAWD.Properties.Resources.exitlogo1;
            this.exit_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.exit_btn.FlatAppearance.BorderSize = 0;
            this.exit_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.exit_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.exit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_btn.Location = new System.Drawing.Point(930, 75);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(65, 53);
            this.exit_btn.TabIndex = 8;
            this.exit_btn.UseVisualStyleBackColor = false;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            this.exit_btn.MouseEnter += new System.EventHandler(this.exit_btn_MouseEnter);
            this.exit_btn.MouseLeave += new System.EventHandler(this.exit_btn_MouseLeave);
            // 
            // panel_out
            // 
            this.panel_out.BackColor = System.Drawing.Color.Transparent;
            this.panel_out.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_out.Controls.Add(this.linkLabel1);
            this.panel_out.Controls.Add(this.reg_btn);
            this.panel_out.Controls.Add(this.login_btn);
            this.panel_out.Controls.Add(this.pw);
            this.panel_out.Controls.Add(this.un);
            this.panel_out.Controls.Add(this.label2);
            this.panel_out.Controls.Add(this.label1);
            this.panel_out.Location = new System.Drawing.Point(37, 412);
            this.panel_out.Name = "panel_out";
            this.panel_out.Size = new System.Drawing.Size(480, 213);
            this.panel_out.TabIndex = 5;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(169, 180);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(137, 20);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Forgot password?";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.Maroon;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1_LinkClicked);
            // 
            // reg_btn
            // 
            this.reg_btn.BackColor = System.Drawing.Color.SlateBlue;
            this.reg_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.reg_btn.FlatAppearance.BorderSize = 0;
            this.reg_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Plum;
            this.reg_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Thistle;
            this.reg_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reg_btn.Font = new System.Drawing.Font("Hobo Std", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reg_btn.ForeColor = System.Drawing.Color.White;
            this.reg_btn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.reg_btn.Location = new System.Drawing.Point(275, 122);
            this.reg_btn.Name = "reg_btn";
            this.reg_btn.Size = new System.Drawing.Size(164, 43);
            this.reg_btn.TabIndex = 4;
            this.reg_btn.Text = "REGISTER";
            this.reg_btn.UseVisualStyleBackColor = false;
            this.reg_btn.Click += new System.EventHandler(this.reg_btn_Click);
            // 
            // login_btn
            // 
            this.login_btn.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.login_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.login_btn.FlatAppearance.BorderSize = 0;
            this.login_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Plum;
            this.login_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Thistle;
            this.login_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_btn.Font = new System.Drawing.Font("Hobo Std", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_btn.ForeColor = System.Drawing.Color.White;
            this.login_btn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.login_btn.Location = new System.Drawing.Point(42, 122);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(172, 43);
            this.login_btn.TabIndex = 3;
            this.login_btn.Text = "LOGIN";
            this.login_btn.UseVisualStyleBackColor = false;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click_1);
            // 
            // pw
            // 
            this.pw.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pw.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pw.Location = new System.Drawing.Point(145, 73);
            this.pw.Multiline = true;
            this.pw.Name = "pw";
            this.pw.PasswordChar = '●';
            this.pw.Size = new System.Drawing.Size(294, 27);
            this.pw.TabIndex = 2;
            this.pw.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pw_KeyDown);
            // 
            // un
            // 
            this.un.BackColor = System.Drawing.Color.White;
            this.un.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.un.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.un.Location = new System.Drawing.Point(145, 34);
            this.un.Multiline = true;
            this.un.Name = "un";
            this.un.Size = new System.Drawing.Size(294, 27);
            this.un.TabIndex = 1;
            this.un.KeyDown += new System.Windows.Forms.KeyEventHandler(this.un_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Hobo Std", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(40, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 27);
            this.label2.TabIndex = 6;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Hobo Std", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(37, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 27);
            this.label1.TabIndex = 5;
            this.label1.Text = "Username";
            // 
            // highscore_btn
            // 
            this.highscore_btn.BackColor = System.Drawing.Color.Transparent;
            this.highscore_btn.BackgroundImage = global::CatsLoveMathsAWD.Properties.Resources.highscorelogo1;
            this.highscore_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.highscore_btn.FlatAppearance.BorderSize = 0;
            this.highscore_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.highscore_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.highscore_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.highscore_btn.Location = new System.Drawing.Point(925, 230);
            this.highscore_btn.Name = "highscore_btn";
            this.highscore_btn.Size = new System.Drawing.Size(80, 67);
            this.highscore_btn.TabIndex = 1;
            this.highscore_btn.UseVisualStyleBackColor = false;
            this.highscore_btn.Click += new System.EventHandler(this.highscore_btn_Click);
            this.highscore_btn.MouseEnter += new System.EventHandler(this.highscore_btn_MouseEnter);
            this.highscore_btn.MouseLeave += new System.EventHandler(this.highscore_btn_MouseLeave);
            // 
            // setting_btn
            // 
            this.setting_btn.BackColor = System.Drawing.Color.Transparent;
            this.setting_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.setting_btn.FlatAppearance.BorderSize = 0;
            this.setting_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.setting_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.setting_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.setting_btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.setting_btn.Image = ((System.Drawing.Image)(resources.GetObject("setting_btn.Image")));
            this.setting_btn.Location = new System.Drawing.Point(925, 152);
            this.setting_btn.Name = "setting_btn";
            this.setting_btn.Size = new System.Drawing.Size(80, 60);
            this.setting_btn.TabIndex = 0;
            this.setting_btn.UseVisualStyleBackColor = false;
            this.setting_btn.Click += new System.EventHandler(this.setting_btn_Click);
            this.setting_btn.MouseEnter += new System.EventHandler(this.setting_btn_MouseEnter);
            this.setting_btn.MouseLeave += new System.EventHandler(this.setting_btn_MouseLeave);
            // 
            // panel_in
            // 
            this.panel_in.BackColor = System.Drawing.Color.Transparent;
            this.panel_in.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_in.Controls.Add(this.progressBar1);
            this.panel_in.Controls.Add(this.progress);
            this.panel_in.Controls.Add(this.start_btn);
            this.panel_in.Location = new System.Drawing.Point(69, 412);
            this.panel_in.Name = "panel_in";
            this.panel_in.Size = new System.Drawing.Size(435, 179);
            this.panel_in.TabIndex = 7;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(18, 86);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(394, 25);
            this.progressBar1.TabIndex = 4;
            // 
            // progress
            // 
            this.progress.AutoSize = true;
            this.progress.Font = new System.Drawing.Font("Hobo Std", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progress.ForeColor = System.Drawing.Color.White;
            this.progress.Location = new System.Drawing.Point(203, 126);
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(35, 34);
            this.progress.TabIndex = 5;
            this.progress.Text = "%";
            // 
            // start_btn
            // 
            this.start_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.start_btn.FlatAppearance.BorderSize = 0;
            this.start_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.start_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.start_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.start_btn.Font = new System.Drawing.Font("Hobo Std", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_btn.ForeColor = System.Drawing.Color.White;
            this.start_btn.Location = new System.Drawing.Point(79, 38);
            this.start_btn.Name = "start_btn";
            this.start_btn.Size = new System.Drawing.Size(263, 85);
            this.start_btn.TabIndex = 3;
            this.start_btn.Text = "START";
            this.start_btn.UseVisualStyleBackColor = true;
            this.start_btn.Visible = false;
            this.start_btn.Click += new System.EventHandler(this.start_btn_Click);
            this.start_btn.MouseEnter += new System.EventHandler(this.start_btn_MouseEnter);
            this.start_btn.MouseLeave += new System.EventHandler(this.start_btn_MouseLeave);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Enabled = false;
            this.id.Font = new System.Drawing.Font("Tahoma", 12F);
            this.id.ForeColor = System.Drawing.Color.White;
            this.id.Location = new System.Drawing.Point(112, 75);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(22, 19);
            this.id.TabIndex = 10;
            this.id.Text = "id";
            // 
            // logout_btn
            // 
            this.logout_btn.BackgroundImage = global::CatsLoveMathsAWD.Properties.Resources.logout1;
            this.logout_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.logout_btn.FlatAppearance.BorderSize = 0;
            this.logout_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.logout_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.logout_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout_btn.Location = new System.Drawing.Point(320, 12);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(46, 60);
            this.logout_btn.TabIndex = 11;
            this.logout_btn.UseVisualStyleBackColor = true;
            this.logout_btn.Click += new System.EventHandler(this.logout_btn_Click);
            this.logout_btn.MouseEnter += new System.EventHandler(this.logout_btn_MouseEnter);
            this.logout_btn.MouseLeave += new System.EventHandler(this.logout_btn_MouseLeave);
            this.logout_btn.MouseHover += new System.EventHandler(this.logout_btn_MouseHover);
            // 
            // profile_panel
            // 
            this.profile_panel.BackColor = System.Drawing.Color.Transparent;
            this.profile_panel.Controls.Add(this.profilepic);
            this.profile_panel.Controls.Add(this.id);
            this.profile_panel.Controls.Add(this.logout_btn);
            this.profile_panel.Controls.Add(this.user);
            this.profile_panel.Location = new System.Drawing.Point(12, 0);
            this.profile_panel.Name = "profile_panel";
            this.profile_panel.Size = new System.Drawing.Size(410, 99);
            this.profile_panel.TabIndex = 12;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // time_lbl
            // 
            this.time_lbl.AutoSize = true;
            this.time_lbl.BackColor = System.Drawing.Color.Transparent;
            this.time_lbl.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time_lbl.ForeColor = System.Drawing.Color.White;
            this.time_lbl.Location = new System.Drawing.Point(902, 31);
            this.time_lbl.Name = "time_lbl";
            this.time_lbl.Size = new System.Drawing.Size(51, 23);
            this.time_lbl.TabIndex = 13;
            this.time_lbl.Text = "Time";
            // 
            // Startscreen
            // 
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1024, 640);
            this.Controls.Add(this.time_lbl);
            this.Controls.Add(this.profile_panel);
            this.Controls.Add(this.panel_out);
            this.Controls.Add(this.panel_in);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.highscore_btn);
            this.Controls.Add(this.setting_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Startscreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Startscreen_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Startscreen_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.profilepic)).EndInit();
            this.panel_out.ResumeLayout(false);
            this.panel_out.PerformLayout();
            this.panel_in.ResumeLayout(false);
            this.panel_in.PerformLayout();
            this.profile_panel.ResumeLayout(false);
            this.profile_panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button start_btn;
        private System.Windows.Forms.Button highscore_btn;
        private System.Windows.Forms.Button setting_btn;
        private System.Windows.Forms.Panel panel_out;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel_in;
        private System.Windows.Forms.TextBox pw;
        private System.Windows.Forms.TextBox un;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button exit_btn;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label progress;
        private System.Windows.Forms.Label user;
        private System.Windows.Forms.PictureBox profilepic;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.Button logout_btn;
        private System.Windows.Forms.Panel profile_panel;
        private System.Windows.Forms.Button reg_btn;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label time_lbl;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

