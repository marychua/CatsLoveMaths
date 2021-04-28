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
    public partial class Easy : Form
    {
        public string categories;


        bool additionSelected = false;
        bool subtractionSelected = false;
        bool multiplicationSelected = false;
        bool divisionSelected = false;

        public Easy()
        {
            InitializeComponent();
        }

        private void Easy_Load(object sender, EventArgs e)
        {
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void confirm_btn_Click(object sender, EventArgs e)
        {

            if (additionSelected == true)
            {
                Difficulty.type = "addition";
                Difficulty.titlelabel = addition_btn.Text;
                Map map = new Map();
                map.Show();
            }
            if (subtractionSelected == true)
            {
                Difficulty.type = "subtraction";
                Difficulty.titlelabel = subtraction_btn.Text;
                Map map = new Map();
                map.Show();
            }
            if (multiplicationSelected == true)
            {
                Difficulty.type = "multiplication";
                Difficulty.titlelabel = mulitplication_btn.Text;
                Map map = new Map();
                map.Show();
            }
            if (divisionSelected == true)
            {
                Difficulty.type = "division";
                Difficulty.titlelabel = division_btn.Text;
                Map map = new Map();
                map.Show();
            }

        }

        private void addition_btn_Click(object sender, EventArgs e)
        {
            additionSelected = true;
            subtractionSelected = false;
            multiplicationSelected = false;
            divisionSelected = false;
            addition_btn.Image = Properties.Resources.pluto2;
            subtraction_btn.Image = Properties.Resources.neptune1;
            mulitplication_btn.Image = Properties.Resources.uranus1;
            division_btn.Image = Properties.Resources.saturn1;
        }

        private void subtraction_btn_Click(object sender, EventArgs e)
        {
            additionSelected = false;
            subtractionSelected = true;
            multiplicationSelected = false;
            divisionSelected = false;
            addition_btn.Image = Properties.Resources.pluto1;
            subtraction_btn.Image = Properties.Resources.neptune2;
            mulitplication_btn.Image = Properties.Resources.uranus1;
            division_btn.Image = Properties.Resources.saturn1;
        }

        private void mulitplication_btn_Click(object sender, EventArgs e)
        {
            additionSelected = false;
            subtractionSelected = false;
            multiplicationSelected = true;
            divisionSelected = false;
            addition_btn.Image = Properties.Resources.pluto1;
            subtraction_btn.Image = Properties.Resources.neptune1;
            mulitplication_btn.Image = Properties.Resources.uranus2;
            division_btn.Image = Properties.Resources.saturn1;
        }

        private void division_btn_Click(object sender, EventArgs e)
        {
            additionSelected = false;
            subtractionSelected = false;
            multiplicationSelected = false;
            divisionSelected = true;
            addition_btn.Image = Properties.Resources.pluto1;
            subtraction_btn.Image = Properties.Resources.neptune1;
            mulitplication_btn.Image = Properties.Resources.uranus1;
            division_btn.Image = Properties.Resources.saturn2;
        }
    }
}
