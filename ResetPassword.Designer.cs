namespace CatsLoveMathsAWD
{
    partial class ResetPassword
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
            this.panel_out = new System.Windows.Forms.Panel();
            this.recover_btn = new System.Windows.Forms.Button();
            this.em = new System.Windows.Forms.TextBox();
            this.emlbl = new System.Windows.Forms.Label();
            this.return_btn = new System.Windows.Forms.Button();
            this.panel_out.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_out
            // 
            this.panel_out.BackColor = System.Drawing.Color.Transparent;
            this.panel_out.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_out.Controls.Add(this.recover_btn);
            this.panel_out.Controls.Add(this.em);
            this.panel_out.Controls.Add(this.emlbl);
            this.panel_out.Location = new System.Drawing.Point(30, 73);
            this.panel_out.Name = "panel_out";
            this.panel_out.Size = new System.Drawing.Size(480, 213);
            this.panel_out.TabIndex = 6;
            // 
            // recover_btn
            // 
            this.recover_btn.BackColor = System.Drawing.Color.SlateBlue;
            this.recover_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.recover_btn.FlatAppearance.BorderSize = 0;
            this.recover_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Plum;
            this.recover_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Thistle;
            this.recover_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.recover_btn.Font = new System.Drawing.Font("Hobo Std", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recover_btn.ForeColor = System.Drawing.Color.White;
            this.recover_btn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.recover_btn.Location = new System.Drawing.Point(207, 127);
            this.recover_btn.Name = "recover_btn";
            this.recover_btn.Size = new System.Drawing.Size(232, 43);
            this.recover_btn.TabIndex = 3;
            this.recover_btn.Text = "RECOVER PASWORD";
            this.recover_btn.UseVisualStyleBackColor = false;
            this.recover_btn.Click += new System.EventHandler(this.Recover_btn_Click);
            // 
            // em
            // 
            this.em.BackColor = System.Drawing.Color.White;
            this.em.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.em.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.em.Location = new System.Drawing.Point(145, 74);
            this.em.Multiline = true;
            this.em.Name = "em";
            this.em.Size = new System.Drawing.Size(294, 27);
            this.em.TabIndex = 1;
            // 
            // emlbl
            // 
            this.emlbl.AutoSize = true;
            this.emlbl.Font = new System.Drawing.Font("Hobo Std", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emlbl.ForeColor = System.Drawing.Color.White;
            this.emlbl.Location = new System.Drawing.Point(37, 74);
            this.emlbl.Name = "emlbl";
            this.emlbl.Size = new System.Drawing.Size(62, 27);
            this.emlbl.TabIndex = 5;
            this.emlbl.Text = "Email";
            // 
            // return_btn
            // 
            this.return_btn.BackColor = System.Drawing.Color.SlateBlue;
            this.return_btn.FlatAppearance.BorderSize = 0;
            this.return_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.return_btn.Font = new System.Drawing.Font("Hobo Std", 17F);
            this.return_btn.ForeColor = System.Drawing.Color.White;
            this.return_btn.Location = new System.Drawing.Point(30, 22);
            this.return_btn.Name = "return_btn";
            this.return_btn.Size = new System.Drawing.Size(142, 45);
            this.return_btn.TabIndex = 79;
            this.return_btn.Text = "Return";
            this.return_btn.UseVisualStyleBackColor = false;
            this.return_btn.Click += new System.EventHandler(this.Return_btn_Click);
            // 
            // ResetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CatsLoveMathsAWD.Properties.Resources.difficulty;
            this.ClientSize = new System.Drawing.Size(552, 316);
            this.Controls.Add(this.return_btn);
            this.Controls.Add(this.panel_out);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ResetPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel_out.ResumeLayout(false);
            this.panel_out.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_out;
        private System.Windows.Forms.Button recover_btn;
        private System.Windows.Forms.TextBox em;
        private System.Windows.Forms.Label emlbl;
        private System.Windows.Forms.Button return_btn;
    }
}