using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatsLoveMathsAWD
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }
        bool SoundOn = true;
        bool MusicOn = true;
            

        //Enable and disable sounds
        private void sound_btn_CheckedChanged(object sender, EventArgs e)
        {
            if (sound_btn.Checked)
            {
                SoundOn = true;
            }
            else
            {
                SoundOn = false;

            }

            if (SoundOn == true)
            {
                sound_slider.Visible = true;
                sound_percent.Visible = true;
            }
            if (SoundOn == false)
            {
                sound_slider.Visible = false;
                sound_percent.Visible = false;

            }

        }

        //Enable and disable music
        private void music_btn_CheckedChanged(object sender, EventArgs e)
        {
            if (music_btn.Checked)
            {
                MusicOn = true;

            }
            else
            {
                MusicOn = false;

                
            }

            if(MusicOn == true)
            {
                music_slider.Visible = true;
                music_percent.Visible = true;
            }
            if(MusicOn == false)
            {
                music_slider.Visible = false;
                music_percent.Visible = false;

            }
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            music_btn.Checked = true;
            sound_btn.Checked = true;
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dlt_btn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete your account?", "Account Deletion", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show("Account successfully deleted.");
            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }

        private void sound_slider_Scroll(object sender, EventArgs e)
        {
            sound_percent.Text = sound_slider.Value.ToString() + "%";
        }

        private void music_slider_Scroll(object sender, EventArgs e)
        {
            music_percent.Text = music_slider.Value.ToString() + "%";
        }
    }
}
