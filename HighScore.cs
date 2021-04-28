using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Windows.Forms.DataVisualization.Charting;

namespace CatsLoveMathsAWD
{
    public partial class HighScore : Form
    {
        DBConnection gc = new DBConnection();
        string localuid = Startscreen.UID;
        DataSet ds = new DataSet();
        public HighScore()
        {
            InitializeComponent();
        }



        private void back_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void easy_lbl_Click(object sender, EventArgs e)
        {

            attempt_panel.Hide();

            easy_pic.Size = new Size(59, 52);
            easy_pic.Location = new Point(23, 100);
            easy_pic.BackColor = Color.Transparent;
            easy_lbl.Location = new Point(-23, 100);
            easy_lbl.BackColor = Color.Transparent;

            return_btn.Show();
            medium_lbl.Hide();
            medium_pic.Hide();
            hard_lbl.Hide();
            hard_pic.Hide();

            categorylbl_1.Show();
            categorylbl_2.Show();
            categorylbl_3.Show();
            categorylbl_4.Show();

            score_1.Show();
            score_2.Show();
            score_3.Show();
            score_4.Show();

            categorylbl_1.Text = "Addition";
            categorylbl_2.Text = "Subtraction";
            categorylbl_3.Text = "Multiplication";
            categorylbl_4.Text = "Division";
            int i = 0;
            gc.getscore(localuid, i);
            score_1.Text = Convert.ToString(gc.score1);
            score_2.Text = Convert.ToString(gc.score2);
            score_3.Text = Convert.ToString(gc.score3);
            score_4.Text = Convert.ToString(gc.score4);

            //array for chart x and y axis
            string[] x = { categorylbl_1.Text, categorylbl_2.Text, categorylbl_3.Text, categorylbl_4.Text };
            int[] y = { gc.score1, gc.score2, gc.score3, gc.score4 };
            genchart(x,y);

        }

        private void medium_lbl_Click(object sender, EventArgs e)
        {
            attempt_panel.Hide();

            medium_pic.Size = new Size(59, 42);
            medium_pic.Location = new Point(23, 100);
            medium_pic.BackColor = Color.Transparent;
            medium_lbl.Location = new Point(10, 100);
            medium_lbl.BackColor = Color.Transparent;

            return_btn.Show();
            easy_lbl.Hide();
            easy_pic.Hide();
            hard_lbl.Hide();
            hard_pic.Hide();

            categorylbl_1.Show();
            categorylbl_2.Show();
            categorylbl_3.Show();
            categorylbl_4.Show();
            categorylbl_5.Show();
            score_1.Show();
            score_2.Show();
            score_3.Show();
            score_4.Show();
            score_5.Show();

            categorylbl_1.Text = "Addition";
            categorylbl_2.Text = "Subtraction";
            categorylbl_3.Text = "Multiplication";
            categorylbl_4.Text = "Division";
            categorylbl_5.Text = "Fraction";

            float i = 0;
            gc.getscore(localuid, i);
            score_1.Text = Convert.ToString(gc.score1);
            score_2.Text = Convert.ToString(gc.score2);
            score_3.Text = Convert.ToString(gc.score3);
            score_4.Text = Convert.ToString(gc.score4);
            score_5.Text = Convert.ToString(gc.score5);
            string[] x = { categorylbl_1.Text, categorylbl_2.Text, categorylbl_3.Text, categorylbl_4.Text, categorylbl_5.Text };
            int[] y = { gc.score1, gc.score2, gc.score3, gc.score4, gc.score5 };
            genchart(x, y);

        }


        private void hard_lbl_Click(object sender, EventArgs e)
        {
            attempt_panel.Hide();

            hard_pic.Size = new Size(59, 42);
            hard_pic.Location = new Point(23, 100);
            hard_pic.BackColor = Color.Transparent;
            hard_lbl.Location = new Point(-23, 100);
            hard_lbl.BackColor = Color.Transparent;

            return_btn.Show();
            medium_lbl.Hide();
            medium_pic.Hide();
            easy_lbl.Hide();
            easy_pic.Hide();

            categorylbl_1.Show();
            categorylbl_2.Show();
            categorylbl_3.Show();
            categorylbl_4.Show();
            categorylbl_5.Show();
            categorylbl_6.Show();

            score_1.Show();
            score_2.Show();
            score_3.Show();
            score_4.Show();
            score_5.Show();
            score_6.Show();

            categorylbl_1.Text = "Rational Numbers";
            categorylbl_2.Text = "Square, Cube, Roots";
            categorylbl_3.Text = "Algebraic Expression";
            categorylbl_4.Text = "Pythagoras Theorem";
            categorylbl_5.Text = "Probability";
            categorylbl_6.Text = "Statistics";

            string i = "";
            gc.getscore(localuid, i);
            score_1.Text = Convert.ToString(gc.score1);
            score_2.Text = Convert.ToString(gc.score2);
            score_3.Text = Convert.ToString(gc.score3);
            score_4.Text = Convert.ToString(gc.score4);
            score_5.Text = Convert.ToString(gc.score5);
            score_6.Text = Convert.ToString(gc.score6);

            string[] x = { categorylbl_1.Text, categorylbl_2.Text, categorylbl_3.Text, categorylbl_4.Text, categorylbl_5.Text, categorylbl_6.Text };
            int[] y = { gc.score1, gc.score2, gc.score3, gc.score4, gc.score5, gc.score6 };
            genchart(x, y);

        }

        private void return_btn_Click(object sender, EventArgs e)
        {
            attempt_panel.Show();
            return_btn.Hide();

            easy_lbl.Show();
            medium_lbl.Show();
            hard_lbl.Show();
            easy_pic.Show();
            medium_pic.Show();
            hard_pic.Show();

            categorylbl_1.Hide();
            categorylbl_2.Hide();
            categorylbl_3.Hide();
            categorylbl_4.Hide();
            categorylbl_5.Hide();
            categorylbl_6.Hide();

            score_1.Hide();
            score_2.Hide();
            score_3.Hide();
            score_4.Hide();
            score_5.Hide();
            score_6.Hide();

            easy_pic.Size = new Size(59, 52);
            easy_pic.Location = new Point(18, 24);
            easy_pic.BackColor = Color.DarkSlateBlue;
            easy_lbl.Location = new Point(12, 16);
            easy_lbl.BackColor = Color.DarkSlateBlue;

            medium_pic.Size = new Size(59, 42);
            medium_pic.Location = new Point(19, 112);
            medium_pic.BackColor = Color.DarkSlateBlue;
            medium_lbl.Location = new Point(12, 99);
            medium_lbl.BackColor = Color.DarkSlateBlue;

            hard_pic.Size = new Size(59, 42);
            hard_pic.Location = new Point(19, 195);
            hard_pic.BackColor = Color.DarkSlateBlue;
            hard_lbl.Location = new Point(12, 183);
            hard_lbl.BackColor = Color.DarkSlateBlue;

            string[] x = { easy_lbl.Text, medium_lbl.Text, hard_lbl.Text };
            int[] y = { gc.easycount, gc.mediumcount, gc.hardcount };
            genchart(x, y);


        }

        private void HighScore_Load(object sender, EventArgs e)
        {

            SqlConnection newConnection = DBConnection.dbconnect();
            string sql = "SELECT * FROM GameScore where UID = '" + localuid + "'";
            string latest = "SELECT TOP 1 * FROM GameScore where UID = '" + localuid + "' ORDER BY GID DESC ";
            SqlCommand sqlcmd = new SqlCommand(sql, newConnection);
            SqlCommand sqllatest = new SqlCommand(latest, newConnection);
            newConnection.Open();
            try
            {
                SqlDataReader myReader;
                myReader = sqllatest.ExecuteReader();
                myReader.Read();
                last_seen.Text = "Last played: " + myReader["Time"].ToString();
                SqlDataAdapter gameScoreTableAdapter = new SqlDataAdapter(sql, newConnection);
                newConnection.Close();
                newConnection.Open();
                gameScoreTableAdapter.Fill(ds, "GameScore");
                newConnection.Close();
                dataGridView1.DataSource = ds.Tables[0];

                attempt_panel.Show();
                gc.getattempts(localuid);
                easy_attempt.Text = Convert.ToString(gc.easycount);
                medium_attempt.Text = Convert.ToString(gc.mediumcount);
                hard_attempt.Text = Convert.ToString(gc.hardcount);

                string[] x = { easy_lbl.Text, medium_lbl.Text, hard_lbl.Text };
                int[] y = { gc.easycount, gc.mediumcount, gc.hardcount };
                genchart(x, y);
            }
            catch(Exception)
            {

            }

        }
        private void genchart(string[] x, int[] y)
        {
           
            highscore_chart.Series[0].ChartType = SeriesChartType.Column;
            highscore_chart.Series[0].IsValueShownAsLabel = true;
            highscore_chart.Series[0].Points.DataBindXY(x, y);
        }
    }
}
