using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Data.SqlClient;
using System.Media;



namespace CatsLoveMathsAWD
{
    public partial class Startscreen : Form
    {
        public static string UID;
        public Startscreen()
        {

            InitializeComponent();
        }
    
        private void Startscreen_Load(object sender, EventArgs e)
        {
            playThemeSong();
            profile_panel.Hide();
            panel_in.Visible = false;
            highscore_btn.Hide();
            timer1.Enabled = true;
            
            
        }

        private void exit_btn_Click_1(object sender, EventArgs e)
        {
            this.Close();


        }

        private void playClick()
        {
            SoundPlayer playClick = new SoundPlayer(Properties.Resources.Click);
            playClick.Play();



        }
        private void playThemeSong()
        {
            SoundPlayer playThemeSong = new SoundPlayer(Properties.Resources.CLMS_ThemeSong);
            playThemeSong.PlayLooping();

        }
        
        private void start_btn_Click(object sender, EventArgs e)
        {
            
            Difficulty diff = new Difficulty();
            diff.BringToFront();
            diff.Show();
            progressBar1.Hide();
            progress.Hide();
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Exit the game?", "Exit", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
            else if (dialogResult == DialogResult.No)
            {

            }
            
        }


        


        //This connects to database in Microsoft SQL Server 
        string con = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=CLMDB;Integrated Security=True";

        private void login_btn_Click_1(object sender, EventArgs e)
        {
            //Selects fields in database table
            string Query = "select * From CLMTable where Username= '" + un.Text + "' and Password= '" + pw.Text + "';";
            SqlConnection conDatabase = new SqlConnection(con);
            SqlCommand cmdDatabase = new SqlCommand(Query, conDatabase);
            SqlDataReader myReader;
            try
            {
                conDatabase.Open();
                myReader = cmdDatabase.ExecuteReader();

                //reads and displays id
                if(myReader.Read())
                {
                   
                    MessageBox.Show("Welcome, " + un.Text + "!");
                    id.Text = myReader["ID"].ToString();
                    //un.Text = myReader["Username"].ToString();
                    //pw.Text = myReader["Password"].ToString();

                    UID = id.Text;
                    panel_out.Visible = false;
                    backgroundWorker1.RunWorkerAsync();
                    progressBar1.Show();
                    progress.Show();
                    panel_in.Visible = true;
                }
                else
                {
                    //Error messages that displays when there are invalid fields
                    if (un.Text == "" && pw.Text == "")
                    {
                        MessageBox.Show("Please key in username and password");
                    }

                    else if (un.Text == "")
                    {
                        MessageBox.Show("Invalid Username");
                    }

                    else if (pw.Text == "")
                    {
                        MessageBox.Show("Invalid Password");
                    }
                    else
                    {
                        MessageBox.Show("User does not exist.");
                        ClearFields();

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ClearFields()
        {
            un.Clear();
            pw.Clear();
        }



        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            
            for (int i = 1; i <= 100; i++)
            {
                Thread.Sleep(30);
                backgroundWorker1.WorkerReportsProgress = true;
                backgroundWorker1.ReportProgress(i);
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
            progress.Text = e.ProgressPercentage.ToString() + "%";
            
            if (progress.Text == "100%")
            {

                start_btn.Visible = true;
                profile_panel.Show();
                highscore_btn.Show();
                user.Text = un.Text;
                progressBar1.Hide();
                progress.Hide();
            }
            
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to logout?", "Log Out", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                
                panel_out.Show();
                panel_in.Hide();
                profile_panel.Hide();
                highscore_btn.Hide();
                un.Clear();
                pw.Clear();
                MessageBox.Show("Successfully logged out.");

            }
            else if (dialogResult == DialogResult.No)
            {

            }

        }

        private void logout_btn_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.logout_btn, "Logout");
        }


        private void reg_btn_Click(object sender, EventArgs e)
        {
            //Disable "REGISTER" button when register form is open

           
            Register reg = new Register();
            reg.FormClosed += Register_FormClosed;  
            reg.Show();
            reg_btn.Enabled = false;
        }
        private void Register_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Re-enable "REGISTER" button when register form is closed
            reg_btn.Enabled = true;
        }

        private void profilepic_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                profilepic.ImageLocation = ofd.FileName;
                profilepic.SizeMode = PictureBoxSizeMode.Zoom; 
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time_lbl.Text = DateTime.Now.ToLongTimeString();
            
        }

        private void Startscreen_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void un_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                pw.Focus();
            }
        }

        private void pw_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                login_btn.PerformClick();
            }
        }

        private void setting_btn_Click(object sender, EventArgs e)
        {
            
            Settings sett = new Settings();
            sett.Show();
        }


        private void setting_btn_MouseEnter(object sender, EventArgs e)
        {
            setting_btn.Image = Properties.Resources.settinglogo2;
            
        }

        private void setting_btn_MouseLeave(object sender, EventArgs e)
        {
            setting_btn.Image = Properties.Resources.settinglogo1;
        }

        private void start_btn_MouseEnter(object sender, EventArgs e)
        {
            start_btn.ForeColor = Color.Thistle;
        }

        private void start_btn_MouseLeave(object sender, EventArgs e)
        {
            start_btn.ForeColor = Color.White;
        }

        private void highscore_btn_Click(object sender, EventArgs e)
        {
            HighScore highscore = new HighScore();
            highscore.Show();
        }

        private void highscore_btn_MouseEnter(object sender, EventArgs e)
        {
            highscore_btn.Image = Properties.Resources.highscorelogo2;
        }

        private void highscore_btn_MouseLeave(object sender, EventArgs e)
        {
            highscore_btn.Image = Properties.Resources.highscorelogo1;

        }

        private void exit_btn_MouseEnter(object sender, EventArgs e)
        {
            exit_btn.Image = Properties.Resources.exitlogo2;
        }

        private void exit_btn_MouseLeave(object sender, EventArgs e)
        {
            exit_btn.Image = Properties.Resources.exitlogo1;
        }

        private void logout_btn_MouseEnter(object sender, EventArgs e)
        {
            logout_btn.Image = Properties.Resources.logout2;
        }

        private void logout_btn_MouseLeave(object sender, EventArgs e)
        {
            logout_btn.Image = Properties.Resources.logout1;
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            DialogResult dialogResult = MessageBox.Show("Do you want to recover you password", "Warning", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                ResetPassword reset = new ResetPassword();
                reset.Show();
            }
            else if (dialogResult == DialogResult.No)
            {
            }
        }
    }
}





