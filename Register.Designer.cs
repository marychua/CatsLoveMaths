namespace CatsLoveMathsAWD
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.reg_un = new System.Windows.Forms.TextBox();
            this.reg_em = new System.Windows.Forms.TextBox();
            this.reg_pw = new System.Windows.Forms.TextBox();
            this.reg_btn = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.reg_pw1 = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.un_err = new System.Windows.Forms.Label();
            this.em_err = new System.Windows.Forms.Label();
            this.pw_err = new System.Windows.Forms.Label();
            this.pw1_err = new System.Windows.Forms.Label();
            this.medium_lbl = new System.Windows.Forms.Label();
            this.back_btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.reg_id = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // reg_un
            // 
            this.reg_un.Font = new System.Drawing.Font("Hobo Std", 17F);
            this.reg_un.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.reg_un.Location = new System.Drawing.Point(435, 159);
            this.reg_un.Name = "reg_un";
            this.reg_un.Size = new System.Drawing.Size(289, 35);
            this.reg_un.TabIndex = 1;
            this.reg_un.TextChanged += new System.EventHandler(this.reg_un_TextChanged);
            // 
            // reg_em
            // 
            this.reg_em.Font = new System.Drawing.Font("Hobo Std", 17F);
            this.reg_em.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.reg_em.Location = new System.Drawing.Point(435, 223);
            this.reg_em.Name = "reg_em";
            this.reg_em.Size = new System.Drawing.Size(289, 35);
            this.reg_em.TabIndex = 2;
            this.reg_em.TextChanged += new System.EventHandler(this.reg_em_TextChanged);
            this.reg_em.Validating += new System.ComponentModel.CancelEventHandler(this.reg_em_Validating);
            // 
            // reg_pw
            // 
            this.reg_pw.Font = new System.Drawing.Font("Hobo Std", 17F);
            this.reg_pw.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.reg_pw.Location = new System.Drawing.Point(435, 287);
            this.reg_pw.Name = "reg_pw";
            this.reg_pw.Size = new System.Drawing.Size(268, 35);
            this.reg_pw.TabIndex = 3;
            this.reg_pw.TextChanged += new System.EventHandler(this.reg_pw_TextChanged);
            this.reg_pw.Validating += new System.ComponentModel.CancelEventHandler(this.reg_pw_Validating);
            // 
            // reg_btn
            // 
            this.reg_btn.BackColor = System.Drawing.Color.SlateBlue;
            this.reg_btn.FlatAppearance.BorderSize = 0;
            this.reg_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reg_btn.Font = new System.Drawing.Font("Hobo Std", 17F);
            this.reg_btn.ForeColor = System.Drawing.Color.White;
            this.reg_btn.Location = new System.Drawing.Point(295, 487);
            this.reg_btn.Name = "reg_btn";
            this.reg_btn.Size = new System.Drawing.Size(326, 44);
            this.reg_btn.TabIndex = 6;
            this.reg_btn.Text = "Register";
            this.reg_btn.UseVisualStyleBackColor = false;
            this.reg_btn.Click += new System.EventHandler(this.reg_btn_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Hobo Std", 17F);
            this.checkBox1.ForeColor = System.Drawing.Color.White;
            this.checkBox1.Location = new System.Drawing.Point(190, 429);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(580, 37);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "I accept the Terms and Condition and Privacy Policy.";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // reg_pw1
            // 
            this.reg_pw1.Font = new System.Drawing.Font("Hobo Std", 17F);
            this.reg_pw1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.reg_pw1.Location = new System.Drawing.Point(435, 353);
            this.reg_pw1.Name = "reg_pw1";
            this.reg_pw1.Size = new System.Drawing.Size(268, 35);
            this.reg_pw1.TabIndex = 4;
            this.reg_pw1.TextChanged += new System.EventHandler(this.reg_pw1_TextChanged);
            // 
            // un_err
            // 
            this.un_err.AutoSize = true;
            this.un_err.Font = new System.Drawing.Font("Hobo Std", 10F);
            this.un_err.ForeColor = System.Drawing.Color.Gold;
            this.un_err.Location = new System.Drawing.Point(431, 197);
            this.un_err.Name = "un_err";
            this.un_err.Size = new System.Drawing.Size(119, 20);
            this.un_err.TabIndex = 15;
            this.un_err.Text = "Invalid Username";
            this.un_err.Visible = false;
            // 
            // em_err
            // 
            this.em_err.AutoSize = true;
            this.em_err.Font = new System.Drawing.Font("Hobo Std", 10F);
            this.em_err.ForeColor = System.Drawing.Color.Gold;
            this.em_err.Location = new System.Drawing.Point(431, 261);
            this.em_err.Name = "em_err";
            this.em_err.Size = new System.Drawing.Size(91, 20);
            this.em_err.TabIndex = 16;
            this.em_err.Text = "Invalid Email";
            this.em_err.Visible = false;
            // 
            // pw_err
            // 
            this.pw_err.AutoSize = true;
            this.pw_err.Font = new System.Drawing.Font("Hobo Std", 10F);
            this.pw_err.ForeColor = System.Drawing.Color.Gold;
            this.pw_err.Location = new System.Drawing.Point(431, 325);
            this.pw_err.Name = "pw_err";
            this.pw_err.Size = new System.Drawing.Size(118, 20);
            this.pw_err.TabIndex = 17;
            this.pw_err.Text = "Invalid Password";
            this.pw_err.Visible = false;
            // 
            // pw1_err
            // 
            this.pw1_err.AutoSize = true;
            this.pw1_err.Font = new System.Drawing.Font("Hobo Std", 10F);
            this.pw1_err.ForeColor = System.Drawing.Color.Gold;
            this.pw1_err.Location = new System.Drawing.Point(431, 391);
            this.pw1_err.Name = "pw1_err";
            this.pw1_err.Size = new System.Drawing.Size(173, 20);
            this.pw1_err.TabIndex = 18;
            this.pw1_err.Text = "Invalid Confirm Password";
            this.pw1_err.Visible = false;
            // 
            // medium_lbl
            // 
            this.medium_lbl.AutoSize = true;
            this.medium_lbl.BackColor = System.Drawing.Color.Transparent;
            this.medium_lbl.Font = new System.Drawing.Font("Hobo Std", 30F);
            this.medium_lbl.ForeColor = System.Drawing.Color.White;
            this.medium_lbl.Location = new System.Drawing.Point(306, 22);
            this.medium_lbl.Name = "medium_lbl";
            this.medium_lbl.Size = new System.Drawing.Size(332, 57);
            this.medium_lbl.TabIndex = 60;
            this.medium_lbl.Text = "Cats Love Maths";
            // 
            // back_btn
            // 
            this.back_btn.BackColor = System.Drawing.Color.SlateBlue;
            this.back_btn.FlatAppearance.BorderSize = 0;
            this.back_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back_btn.Font = new System.Drawing.Font("Hobo Std", 17F);
            this.back_btn.ForeColor = System.Drawing.Color.White;
            this.back_btn.Location = new System.Drawing.Point(295, 549);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(326, 44);
            this.back_btn.TabIndex = 7;
            this.back_btn.Text = "Back";
            this.back_btn.UseVisualStyleBackColor = false;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CatsLoveMathsAWD.Properties.Resources.cat_front;
            this.pictureBox1.Location = new System.Drawing.Point(157, 230);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(97, 139);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 62;
            this.pictureBox1.TabStop = false;
            // 
            // reg_id
            // 
            this.reg_id.Enabled = false;
            this.reg_id.Font = new System.Drawing.Font("Hobo Std", 17F);
            this.reg_id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.reg_id.Location = new System.Drawing.Point(435, 97);
            this.reg_id.Name = "reg_id";
            this.reg_id.Size = new System.Drawing.Size(289, 35);
            this.reg_id.TabIndex = 64;
            this.reg_id.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(38, 128);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(233, 181);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 65;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Hobo Std", 15F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(757, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 151);
            this.label1.TabIndex = 66;
            this.label1.Text = "Join Mr.Cat and explore a whole new world of mathematics!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Hobo Std", 15F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(324, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 28);
            this.label2.TabIndex = 70;
            this.label2.Text = "Username";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Hobo Std", 15F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(391, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 28);
            this.label3.TabIndex = 71;
            this.label3.Text = "ID";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Hobo Std", 15F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(362, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 28);
            this.label4.TabIndex = 72;
            this.label4.Text = "Email";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Hobo Std", 15F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(324, 294);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 28);
            this.label5.TabIndex = 73;
            this.label5.Text = "Password";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Hobo Std", 15F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(317, 334);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 66);
            this.label6.TabIndex = 74;
            this.label6.Text = "Confirm Password";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.checkBox2.Location = new System.Drawing.Point(709, 300);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(15, 14);
            this.checkBox2.TabIndex = 75;
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.checkBox3.Location = new System.Drawing.Point(709, 365);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(15, 14);
            this.checkBox3.TabIndex = 76;
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(951, 640);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reg_id);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.medium_lbl);
            this.Controls.Add(this.reg_pw1);
            this.Controls.Add(this.pw1_err);
            this.Controls.Add(this.pw_err);
            this.Controls.Add(this.em_err);
            this.Controls.Add(this.un_err);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.reg_btn);
            this.Controls.Add(this.reg_pw);
            this.Controls.Add(this.reg_em);
            this.Controls.Add(this.reg_un);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Register_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox reg_un;
        private System.Windows.Forms.TextBox reg_em;
        private System.Windows.Forms.TextBox reg_pw;
        private System.Windows.Forms.Button reg_btn;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox reg_pw1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label un_err;
        private System.Windows.Forms.Label em_err;
        private System.Windows.Forms.Label pw_err;
        private System.Windows.Forms.Label pw1_err;
        private System.Windows.Forms.Label medium_lbl;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox reg_id;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
    }
}