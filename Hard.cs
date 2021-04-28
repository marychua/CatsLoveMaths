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
    public partial class Hard : Form
    {
     
        public Hard()
        {
            InitializeComponent();
        }

        private void Hard_Load(object sender, EventArgs e)
        {

        }


        bool rnSelected = false;
        bool scrSelected = false;
        bool aeSelected = false;
        bool ptSelected = false;
        bool probabilitySelected = false;
        bool statisticsSelected = false;



        private void back_btn_Click_1(object sender, EventArgs e)
        {
            this.Close();
        } 
        
        private void confirm_btn_Click(object sender, EventArgs e)
        {
            if (rnSelected == true)
            {
                Difficulty.type= "rn";
                Difficulty.titlelabel = rn_btn.Text;
                Map map = new Map();
                map.Show();
            }
            if (scrSelected == true)
            {
                Difficulty.type = "scr";
                Difficulty.titlelabel = scr_btn.Text;
                Map map = new Map();
                map.Show();
            }
            if (aeSelected == true)
            {
                Difficulty.type = "ae";
                Difficulty.titlelabel = ae_btn.Text;
                Map map = new Map();
                map.Show();
            }
            if (ptSelected == true)
            {
                Difficulty.type = "pt";
                Difficulty.titlelabel = pt_btn.Text;
                Map map = new Map();
                map.Show();
            }

            if (probabilitySelected == true)
            {
                Difficulty.type = "probability";
                Difficulty.titlelabel = probability_btn.Text;
                Map map = new Map();
                map.Show();
            }

            if (statisticsSelected == true)
            {
                Difficulty.type = "statistics";
                Difficulty.titlelabel = statistics_btn.Text;
                Map map = new Map();
                map.Show();
            }

        }
        private void rn_btn_Click(object sender, EventArgs e)
        {
            rnSelected = true;
            scrSelected = false;
            aeSelected = false;
            ptSelected = false;
            probabilitySelected = false;
            statisticsSelected = false;

            rn_btn.Image = Properties.Resources.mars2;
            scr_btn.Image = Properties.Resources.moon1;
            ae_btn.Image = Properties.Resources.earth1;
            pt_btn.Image = Properties.Resources.venus1;
            probability_btn.Image = Properties.Resources.mercury1;
            statistics_btn.Image = Properties.Resources.venus1;
        }

        private void scr_btn_Click(object sender, EventArgs e)
        {
            rnSelected = false;
            scrSelected = true;
            aeSelected = false;
            ptSelected = false;
            probabilitySelected = false;
            statisticsSelected = false;

            rn_btn.Image = Properties.Resources.mars1;
            scr_btn.Image = Properties.Resources.moon2;
            ae_btn.Image = Properties.Resources.earth1;
            pt_btn.Image = Properties.Resources.venus1;
            probability_btn.Image = Properties.Resources.mercury1;
            statistics_btn.Image = Properties.Resources.venus1;
        }

        private void ae_btn_Click(object sender, EventArgs e)
        {
            rnSelected = false;
            scrSelected = false;
            aeSelected = true;
            ptSelected = false;
            probabilitySelected = false;
            statisticsSelected = false;

            rn_btn.Image = Properties.Resources.mars1;
            scr_btn.Image = Properties.Resources.moon1;
            ae_btn.Image = Properties.Resources.earth2;
            pt_btn.Image = Properties.Resources.venus1;
            probability_btn.Image = Properties.Resources.mercury1;
            statistics_btn.Image = Properties.Resources.venus1;
        }

        private void pt_btn_Click(object sender, EventArgs e)
        {
            rnSelected = false;
            scrSelected = false;
            aeSelected = false;
            ptSelected = true;
            probabilitySelected = false;
            statisticsSelected = false;

            rn_btn.Image = Properties.Resources.mars1;
            scr_btn.Image = Properties.Resources.moon1;
            ae_btn.Image = Properties.Resources.earth1;
            pt_btn.Image = Properties.Resources.venus2;
            probability_btn.Image = Properties.Resources.mercury1;
            statistics_btn.Image = Properties.Resources.venus1;
        }

        private void probability_btn_Click(object sender, EventArgs e)
        {
            rnSelected = false;
            scrSelected = false;
            aeSelected = false;
            ptSelected = false;
            probabilitySelected = true;
            statisticsSelected = false;

            rn_btn.Image = Properties.Resources.mars1;
            scr_btn.Image = Properties.Resources.moon1;
            ae_btn.Image = Properties.Resources.earth1;
            pt_btn.Image = Properties.Resources.venus1;
            probability_btn.Image = Properties.Resources.mercury2;
            statistics_btn.Image = Properties.Resources.venus1;
        }

        private void statistics_btn_Click(object sender, EventArgs e)
        {
            rnSelected = false;
            scrSelected = false;
            aeSelected = false;
            ptSelected = false;
            probabilitySelected = false;
            statisticsSelected = true;

            rn_btn.Image = Properties.Resources.mars1;
            scr_btn.Image = Properties.Resources.moon1;
            ae_btn.Image = Properties.Resources.earth1;
            pt_btn.Image = Properties.Resources.venus1;
            probability_btn.Image = Properties.Resources.mercury1;
            statistics_btn.Image = Properties.Resources.venus2;
        }
    }
}
