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
    
    public partial class Difficulty : Form
    {
        public static string difficulty;
        public static string type;
        public static string titlelabel;
        public Difficulty()
        {
            InitializeComponent();
        }

        bool easySelected = false;
        bool mediumSelected = false;
        bool hardSelected = false;

        private void back_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DisableButtons()
        {
            easy_btn.Enabled = false;
            medium_btn.Enabled = false;
            hard_btn.Enabled = false;
        }

        private void EnableButtons()
        {
            easy_btn.Enabled = true;
            medium_btn.Enabled = true;
            hard_btn.Enabled = true;
        }

        private void easy_btn_Click(object sender, EventArgs e)
        {
            easySelected = true;
            mediumSelected = false;
            hardSelected = false;
            easy_btn.Image = Properties.Resources.Easy2;
            medium_btn.Image = Properties.Resources.Medium1;
            hard_btn.Image = Properties.Resources.Hard1;
            selection_lbl.Text = "You pick:  " + easy_btn.Text;
        }

       

        private void medium_btn_Click(object sender, EventArgs e)
        {
           
            easySelected = false;
            mediumSelected = true;
            hardSelected = false;
            easy_btn.Image = Properties.Resources.Easy1;
            medium_btn.Image = Properties.Resources.Medium2;
            hard_btn.Image = Properties.Resources.Hard1;
            selection_lbl.Text = "You pick:  " + medium_btn.Text;
        }

        private void hard_btn_Click(object sender, EventArgs e)
        {
            easySelected = false;
            mediumSelected = false;
            hardSelected = true;
            easy_btn.Image = Properties.Resources.Easy1;
            medium_btn.Image = Properties.Resources.Medium1;
            hard_btn.Image = Properties.Resources.Hard2;
            selection_lbl.Text = "You pick:  " + hard_btn.Text;

        }
        private void Easy_FormClosed(object sender, FormClosedEventArgs e)
        {
            EnableButtons();
        }

        private void Medium_FormClosed(object sender, FormClosedEventArgs e)
        {
            EnableButtons();
        }

        private void Hard_FormClosed(object sender, FormClosedEventArgs e)
        {
            EnableButtons();
        }
        private void Difficulty_FormClosed(object sender, FormClosedEventArgs e)
        {

        }



        private void confirm_btn_Click(object sender, EventArgs e)
        {
            if (easySelected == true)
            {
                difficulty = "Easy";
                Easy easylvl = new Easy();
                easylvl.FormClosed += Easy_FormClosed;
                easylvl.Show();
                DisableButtons();
            }
            if (mediumSelected == true)
            {
                difficulty = "Medium";
                Medium mediumlvl = new Medium();
                mediumlvl.FormClosed += Medium_FormClosed;
                mediumlvl.Show();
                DisableButtons();
            }
            if (hardSelected == true )
            {
                difficulty = "Hard";
                Hard hardlvl = new Hard();
                hardlvl.FormClosed += Hard_FormClosed;
                hardlvl.Show();
                DisableButtons();
            }
        }
    }
}
