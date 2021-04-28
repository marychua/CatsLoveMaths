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
    public partial class Medium : Form
    {
    

        public Medium()
        {
            InitializeComponent();
        }

        bool additionSelected = false;
        bool subtractionSelected = false;
        bool multiplicationSelected = false;
        bool divisionSelected = false;
        bool fractionSelected = false;


        private void Medium_Load(object sender, EventArgs e)
        {

        }
        private void addition_btn_Click(object sender, EventArgs e)
        {
            additionSelected = true;
            subtractionSelected = false;
            multiplicationSelected = false;
            divisionSelected = false;
            fractionSelected = false;

            addition_btn.Image = Properties.Resources.pluto2;
            subtraction_btn.Image = Properties.Resources.neptune1;
            mulitplication_btn.Image = Properties.Resources.uranus1;
            division_btn.Image = Properties.Resources.saturn1;
            fraction_btn.Image = Properties.Resources.jupiter1;
        }

        private void subtraction_btn_Click(object sender, EventArgs e)
        {
            additionSelected = false;
            subtractionSelected = true;
            multiplicationSelected = false;
            divisionSelected = false;
            fractionSelected = false;

            addition_btn.Image = Properties.Resources.pluto1;
            subtraction_btn.Image = Properties.Resources.neptune2;
            mulitplication_btn.Image = Properties.Resources.uranus1;
            division_btn.Image = Properties.Resources.saturn1;
            fraction_btn.Image = Properties.Resources.jupiter1;
        }

        private void mulitplication_btn_Click(object sender, EventArgs e)
        {
            additionSelected = false;
            subtractionSelected = false;
            multiplicationSelected = true;
            divisionSelected = false;
            fractionSelected = false;

            addition_btn.Image = Properties.Resources.pluto1;
            subtraction_btn.Image = Properties.Resources.neptune1;
            mulitplication_btn.Image = Properties.Resources.uranus2;
            division_btn.Image = Properties.Resources.saturn1;
            fraction_btn.Image = Properties.Resources.jupiter1;
        }

        private void division_btn_Click(object sender, EventArgs e)
        {
            additionSelected = false;
            subtractionSelected = false;
            multiplicationSelected = false;
            divisionSelected = true;
            fractionSelected = false;

            addition_btn.Image = Properties.Resources.pluto1;
            subtraction_btn.Image = Properties.Resources.neptune1;
            mulitplication_btn.Image = Properties.Resources.uranus1;
            division_btn.Image = Properties.Resources.saturn2;
            fraction_btn.Image = Properties.Resources.jupiter1;
        }
        private void fraction_btn_Click(object sender, EventArgs e)
        {
            additionSelected = false;
            subtractionSelected = false;
            multiplicationSelected = false;
            divisionSelected = false;
            fractionSelected = true;

            addition_btn.Image = Properties.Resources.pluto1;
            subtraction_btn.Image = Properties.Resources.neptune1;
            mulitplication_btn.Image = Properties.Resources.uranus1;
            division_btn.Image = Properties.Resources.saturn1;
            fraction_btn.Image = Properties.Resources.jupiter2;
        }

        private void back_btn_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void confirm_btn_Click(object sender, EventArgs e)
        {
            if (additionSelected == true)
            {

                Difficulty.type="addition2";
                Difficulty.titlelabel = addition_btn.Text;
                Map map = new Map();
                map.Show();
            }
            if (subtractionSelected == true)
            {
                Difficulty.type = "subtraction2";
                Difficulty.titlelabel = subtraction_btn.Text;
                Map map = new Map();
                map.Show();
            }
            if (multiplicationSelected == true)
            {
                Difficulty.type = "multiplication2";
                Difficulty.titlelabel = mulitplication_btn.Text;
                Map map = new Map();
                map.Show();
            }
            if (divisionSelected == true)
            {
                Difficulty.type = "division2";
                Difficulty.titlelabel = division_btn.Text;
                Map map = new Map();
                map.Show();
            }

            if (fractionSelected == true)
            {
                Difficulty.type = "fraction";
                Difficulty.titlelabel = fraction_btn.Text;
                Map map = new Map();
                map.Show();
            }

        }
    }
}
