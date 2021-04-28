using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Media;

namespace CatsLoveMathsAWD
{
    public partial class Map : Form
    {
        List<Point> pointsOfList = new List<Point>()
        {
            new Point(19, 164),
            new Point(1005, 164),
            new Point(19, 570),
            new Point(847, 567)
        };

        List<string> combination = new List<string>()
        {
        "1230", "1203", "1320", "1302", 
        "1023", "1032", "2130", "2103", 
        "2310", "2301", "2013", "2031", 
        "3120", "3102", "3210", "3201", 
        "3012", "3021", "0123", "0132", 
        "0213", "0231", "0312", "0321"
        };

        bool goup, godown, goleft, goright;
        int move;
        int timeLeft = 180;
        int timeStart = 5;
        int speed = 5;
        int score = 0;
        int tempscore = 10;
        int lives = 3;
        int milisec = 1;
        int round = 1;
        int QID = 1;
        string Question, ans1, ans2, ans3, ans4,GID,playedtime,gamestat;
        string localdifficulty = Difficulty.difficulty;
        string localtype = Difficulty.type;
        string localUID = Startscreen.UID;
        string locallabel = Difficulty.titlelabel;

        Point Max = new Point();
        Point NewPoint1 = new Point();
        Point NewPoint2 = new Point();
        Point NewPoint3 = new Point();
        Point NewPoint4 = new Point();
        Random Rnd = new Random();
      
        //string submittedanswer;
        public Map()
        {
            InitializeComponent();
            Max = new Point(this.ClientSize - label1.Size);
            timer1.Interval = 10;
            this.Resize += new EventHandler(Form1_Resize);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            Max = new Point(this.ClientSize - label1.Size);
        }

        private void Map_Load(object sender, EventArgs e)
        {
            switch(localtype)
            {
                case "addition":
                    foreach (Control wall in this.Controls)
                    {
                        if (wall is PictureBox && wall.Tag == "Wall")
                        {
                            wall.BackColor = Color.FromArgb(148, 109, 70);
                        }
                    }
                    this.BackColor = Color.FromArgb(199, 149, 90);
                    break;

                case "subtraction":
                    foreach (Control wall in this.Controls)
                    {
                        if (wall is PictureBox && wall.Tag == "Wall")
                        {
                            wall.BackColor = Color.FromArgb(15, 114, 188);
                        }
                    }
                    this.BackColor = Color.FromArgb(65, 191 ,226);
                    break;

                case "multiplication":
                    foreach (Control wall in this.Controls)
                    {
                        if (wall is PictureBox && wall.Tag == "Wall")
                        {
                            wall.BackColor = Color.FromArgb(34, 159, 145);
                        }
                    }
                    this.BackColor = Color.FromArgb(112, 201, 187);
                    break;

                case "division":
                    foreach (Control wall in this.Controls)
                    {
                        if (wall is PictureBox && wall.Tag == "Wall")
                        {
                            wall.BackColor = Color.FromArgb(138, 103, 158);
                        }
                    }
                    this.BackColor = Color.FromArgb(206,153 ,206);
                    break;

                case "addition2":
                    foreach (Control wall in this.Controls)
                    {
                        if (wall is PictureBox && wall.Tag == "Wall")
                        {
                            wall.BackColor = Color.FromArgb(148, 109, 70);
                        }
                    }
                    this.BackColor = Color.FromArgb(199, 149, 90);
                    break;

                case "subtraction2":
                    foreach (Control wall in this.Controls)
                    {
                        if (wall is PictureBox && wall.Tag == "Wall")
                        {
                            wall.BackColor = Color.FromArgb(15, 114, 188);
                        }
                    }
                    this.BackColor = Color.FromArgb(65, 191, 226);
                    break;

                case "multiplication2":
                    foreach (Control wall in this.Controls)
                    {
                        if (wall is PictureBox && wall.Tag == "Wall")
                        {
                            wall.BackColor = Color.FromArgb(34, 159, 145);
                        }
                    }
                    this.BackColor = Color.FromArgb(112, 201, 187);
                    break;

                case "division2":
                    foreach (Control wall in this.Controls)
                    {
                        if (wall is PictureBox && wall.Tag == "Wall")
                        {
                            wall.BackColor = Color.FromArgb(138, 103, 158);
                        }
                    }
                    this.BackColor = Color.FromArgb(206, 153, 206);
                    break;

                case "fraction":
                    foreach (Control wall in this.Controls)
                    {
                        if (wall is PictureBox && wall.Tag == "Wall")
                        {
                            wall.BackColor = Color.FromArgb(191,223 ,227);
                        }
                    }
                    this.BackColor = Color.FromArgb(243 ,237, 198);
                    break;

                case "rn":
                    foreach (Control wall in this.Controls)
                    {
                        if (wall is PictureBox && wall.Tag == "Wall")
                        {
                            wall.BackColor = Color.FromArgb(130,21 ,24);
                        }
                    }
                    this.BackColor = Color.FromArgb(232, 66, 25);
                    break;

                case "scr":
                    foreach (Control wall in this.Controls)
                    {
                        if (wall is PictureBox && wall.Tag == "Wall")
                        {
                            wall.BackColor = Color.FromArgb(63, 93, 94);
                        }
                    }
                    this.BackColor = Color.FromArgb(101, 147, 153);
                    break;

                case "ae":
                    foreach (Control wall in this.Controls)
                    {
                        if (wall is PictureBox && wall.Tag == "Wall")
                        {
                            wall.BackColor = Color.FromArgb(57,85, 90);
                        }
                    }
                    this.BackColor = Color.FromArgb(152, 190, 51);
                    break;

                case "pt":
                    foreach (Control wall in this.Controls)
                    {
                        if (wall is PictureBox && wall.Tag == "Wall")
                        {
                            wall.BackColor = Color.FromArgb(184, 117, 46);
                        }
                    }
                    this.BackColor = Color.FromArgb(250 ,235, 181);
                    break;

                case "probability":
                    foreach (Control wall in this.Controls)
                    {
                        if (wall is PictureBox && wall.Tag == "Wall")
                        {
                            wall.BackColor = Color.FromArgb(147, 96 ,39);
                        }
                    }
                    this.BackColor = Color.FromArgb(213, 175, 66);
                    break;

                case "statistics":
                    foreach (Control wall in this.Controls)
                    {
                        if (wall is PictureBox && wall.Tag == "Wall")
                        {
                            wall.BackColor = Color.FromArgb(184, 117, 46);
                        }
                    }
                    this.BackColor = Color.FromArgb(250, 235, 181);
                    break;
            }
            
            label5.Text = localdifficulty + " - " + locallabel;
            Refresh();
            timer5.Start();
            GenerateNewQuestion();
        }
        private Point SetPoint()
        {
            int num = Rnd.Next(0,23);
            string pass = combination[num];
            StringSeperator s = new StringSeperator(pass);
            s.getVolume(pass);
            
            int first  = Convert.ToInt32(s.a);
            int second = Convert.ToInt32(s.b);
            int third = Convert.ToInt32(s.c);
            int fourth = Convert.ToInt32(s.d);
            NewPoint1 = pointsOfList[first];
            NewPoint2 = pointsOfList[second];
            NewPoint3 = pointsOfList[third];
            NewPoint4 = pointsOfList[fourth];
            label1.Location = NewPoint1;
            label2.Location = NewPoint2;
            label3.Location = NewPoint3;
            label4.Location = NewPoint4;
            return NewPoint1;
        }
        
        private void keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                WalkSound();
                goleft = true;
            }

            if (e.KeyCode == Keys.Right)
            {
                WalkSound();
                goright = true;
            }
            if (e.KeyCode == Keys.Up)
            {
                goup = true;
            }

            if (e.KeyCode == Keys.Down)
            {
                WalkSound();
                godown = true;
            }
        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                cat.Image = Properties.Resources.cat_left;
                goleft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                cat.Image = Properties.Resources.cat_right;
                goright = false;
            }
            if (e.KeyCode == Keys.Up)
            {
                cat.Image = Properties.Resources.cat_back;
                goup = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                cat.Image = Properties.Resources.cat_front;
                godown = false;
            }
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            lives_lbl.Text = lives.ToString();
            round_lbl.Text = "Round " + round.ToString();
            if (goleft)
            {
                if (move == 0)
                {
                    cat.Image = Properties.Resources.cat_left1;
                    cat.Left -= speed;
                }

                else
                {
                    cat.Image = Properties.Resources.cat_left2;
                    cat.Left -= speed;
                }
            }

            if (goright)
            {
                if (move == 0)
                {
                    cat.Image = Properties.Resources.cat_right1;
                    cat.Left += speed;
                }

                else
                {
                    cat.Image = Properties.Resources.cat_right2;
                    cat.Left += speed;
                }

            }

            if (goup)
            {
                if (move == 0)
                {
                    cat.Image = Properties.Resources.cat_back1;
                    cat.Top -= speed;
                }

                else
                {
                    cat.Image = Properties.Resources.cat_back2;
                    cat.Top -= speed;
                }
            }

            if (godown)
            {
                if (move == 0)
                {
                    cat.Image = Properties.Resources.cat_front1;
                    cat.Top += speed;
                }

                else
                {
                    cat.Image = Properties.Resources.cat_front2;
                    cat.Top += speed;
                }
            }

            score_lbl.Text = "Score: " + score;
            foreach (Control wall in this.Controls)
            {
                if (wall is PictureBox && wall.Tag == "Wall")
                {
                    if (goleft)
                    {
                        if (cat.Bounds.IntersectsWith(wall.Bounds))
                        {
                            cat.Left += 5;
                        }
                    }

                    if (goright)
                    {
                        if (cat.Bounds.IntersectsWith(wall.Bounds))
                        {
                            cat.Left -= 5;
                        }
                    }

                    if (goup)
                    {
                        if (cat.Bounds.IntersectsWith(wall.Bounds))
                        {
                            cat.Top += 5;
                        }
                    }

                    if (godown)
                    {
                        if (cat.Bounds.IntersectsWith(wall.Bounds))
                        {
                            cat.Top -= 5;
                        }
                    }
                }
            }

            if (cat.Left < 1 || cat.Left + cat.Width > ClientSize.Width - 2)
            {
                if (goleft)
                {
                    cat.Left += 15;
                }
                if (goright)
                {
                    cat.Left -= 15;
                }
            }

            if (cat.Top < 1 || cat.Top + cat.Height > ClientSize.Height - 2)
            {
                if (goup)
                {
                    cat.Top += 15;
                }
                if (godown)
                {
                    cat.Top -= 15;
                }
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (cat.Bounds.IntersectsWith(label4.Bounds))
            {
                tempscore -= 2;
                StopMovement();
                timer1.Stop();
                WrongAns();
                label4.Top = 0;
                label4.Left = 0;
                label4.Visible = false;
                lives--;
                MessageBox.Show("You're Wrong!");
            }

            if (cat.Bounds.IntersectsWith(label3.Bounds))
            {
                tempscore -= 2;
                StopMovement();
                timer1.Stop();
                WrongAns();
                label3.Top = 0;
                label3.Left = 0;
                label3.Visible = false;
                lives--;
                MessageBox.Show("You're Wrong!");
            }

            if (cat.Bounds.IntersectsWith(label2.Bounds))
            {
                tempscore -= 2;
                StopMovement();
                timer1.Stop();
                WrongAns();
                label2.Top = 0;
                label2.Left = 0;
                label2.Visible = false;
                lives--;
                MessageBox.Show("You're Wrong!");
            }

            if (cat.Bounds.IntersectsWith(label1.Bounds))
            {
                if (round < 10)
                {
                    StopMovement();
                    timer1.Stop();
                    RightAns();
                    game_timer.Text = "";
                    label1.Top = 0;
                    label1.Left = 0;
                    label1.Visible = false;
                    score += tempscore;
                    score_lbl.Text = score.ToString();
                    MessageBox.Show("You're Right!");
                    Refresh();
                    GenerateNewQuestion();
                    round++;
                    //timer3.Stop();
                    if (round == 7 && score == 60 )
                    {
                        MessageBox.Show("6 in a row! Extra life!");
                        lives++;
                    }
                }
                else
                {
                    score = score + tempscore +(lives*10)+(timeLeft*5);
                    StopMovement();
                    timer1.Stop();
                    timer3.Stop();
                    label1.Visible = false;
                    label1.Top = 0;
                    label1.Left = 0;
                    MessageBox.Show("You've Won!!! Your Score is " + score);
                    gamestat = "Won";
                    GameID();
                    SubmitScore();
                }
            }

           timer1.Start();

        }
        private void timer3_Tick(object sender, EventArgs e)
        {

            if (timeLeft > 0)
            {
                var timespan = TimeSpan.FromSeconds(timeLeft);
                game_timer.ForeColor = Color.White;
                game_timer.Text = timespan.ToString(@"mm\:ss");
                timeLeft--;
            }

            if (timeLeft == 0 || lives == 0)
            {
                timer3.Stop();
                score += tempscore;
                gamestat = "Lost";
                GameID();
                SubmitScore();
                DialogResult dialogResult = MessageBox.Show("Game Over, want to try again?", "Game Over", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    int timeStart = 3;
                    lives = 3;
                    QID = 1;
                    timeStart = 5;
                    timeLeft = 180;
                    GenerateNewQuestion();
                    Refresh();
                    timer3.Stop();
                    timer3.Start();
                }

                else if (dialogResult == DialogResult.No)
                {
                    this.Close();
                }
                //MessageBox.Show("Game Over, Please try again");
            }
        }   
        private void Timer5_Tick(object sender, EventArgs e)
        {
            if (timeStart > 0)
            {
                var timespan = TimeSpan.FromSeconds(timeStart);
                game_timer.ForeColor = Color.Red;
                game_timer.Text = timespan.ToString(@"mm\:ss");
                timeStart--;
                timer1.Stop();
                timer2.Stop();
                timer3.Stop();
                timer4.Stop();
                timer5.Start();
            }
            else
            {
                timer1.Start();
                timer2.Start();
                timer3.Start();
                timer3.Start();
                timer4.Start();
                timer5.Stop();
            }
        }

        private void Timer4_Tick(object sender, EventArgs e)
        {
            move = milisec % 2;
            milisec++;
        }

        private void StopMovement()
        {
            goup = false;
            godown = false;
            goleft = false;
            goright = false;
        }

        private void GameID()
        {
            DateTime dt = DateTime.Now;
            GID = dt.ToString("GID" + "yyyyMMddHHmmss");
            playedtime = dt.ToString("HH:mm:ss dd/MM/yyyy");
        }
        private void GenerateNewQuestion()
        {
            Random rand = new Random();
            GenQuest();
            Question_lbl.Text = Question;
            label1.Text = ans1;
            label2.Text = ans2;
            label3.Text = ans3;
            label4.Text = ans4;
            QID++;
        }

        private void Refresh()
        {

            cat.Location = new Point(510, 337);
            label1.Show();
            label2.Show();
            label3.Show();
            label4.Show();
            SetPoint();
            tempscore = 10;
        }

        private void cat_Click(object sender, EventArgs e)
        {
            playMeow();
        }



        private void playClick()
        {
            SoundPlayer playClick = new SoundPlayer(Properties.Resources.Click);
            playClick.Play();
        }

        private void WalkSound()
        {
            SoundPlayer playWalk = new SoundPlayer(Properties.Resources.walk);
            playWalk.Play();
        }

        private void RightAns()
        {
            SoundPlayer rightAns = new SoundPlayer(Properties.Resources.Right_Answer);
            rightAns.Play();
        }


        private void WrongAns()
        {
            SoundPlayer wrongAns = new SoundPlayer(Properties.Resources.Wrong_Answer);
            wrongAns.Play();
        }



        private void playMeow()
        {
            SoundPlayer playMeow = new SoundPlayer(Properties.Resources.Meow);
            playMeow.Play();

        }

        SqlConnection con = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=CLMDB;Integrated Security=True");

        private void SubmitScore()
        {
            SqlCommand ScoreDB = new SqlCommand("INSERT INTO GameScore (GID,Difficulty,Categories,Score,UID,Status,Time) VALUES(@GID,@Difficulty,@Categories,@Score,@UID,@Status,@Time)", con);
            ScoreDB.Parameters.AddWithValue("@GID", GID);
            ScoreDB.Parameters.AddWithValue("@Difficulty", localdifficulty);
            ScoreDB.Parameters.AddWithValue("@Categories", localtype);
            ScoreDB.Parameters.AddWithValue("@Score", score);
            ScoreDB.Parameters.AddWithValue("@UID", localUID );
            ScoreDB.Parameters.AddWithValue("@Status", gamestat);
            ScoreDB.Parameters.AddWithValue("@Time", playedtime);
            con.Open();
            ScoreDB.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Score Submitted!");
        }

        private void GenQuest()
        {
            if (localdifficulty == "Medium" || localdifficulty == "Hard")
            {
                for (int i = 1; i <= 60; i++)
                {

                    try
                    {
                        SqlCommand cmd3 = new SqlCommand("SELECT * FROM " + localdifficulty + " where QID = @QID and MathType = '" + localtype + "'", con);
                        cmd3.Parameters.AddWithValue("@QID", QID);
                        SqlDataReader myReader;
                        con.Open();
                        myReader = cmd3.ExecuteReader();
                        myReader.Read();
                        Question = myReader["Question"].ToString();
                        ans1 = myReader["Answer1"].ToString();
                        ans2 = myReader["Answer2"].ToString();
                        ans3 = myReader["Answer3"].ToString();
                        ans4 = myReader["Answer4"].ToString();
                        con.Close();
                        break;

                    }

                    catch (Exception ex)
                    {
                        con.Close();
                        QID++;
                    }
                }
            }

            else
            {
                float a = Rnd.Next(0, 9);
                float b = Rnd.Next(0, 9);
                float c = 0;
                switch (localtype)
                {
                    
                    case "addition":
                        c = a + b;
                        Question = a.ToString() + " + " + b.ToString();
                        break;
                    case "subtraction":
                        c = a - b;
                        Question = a.ToString() + " - " + b.ToString();
                        break;
                    case "multiplication":
                        c = a * b;
                        Question = a.ToString() + " x " + b.ToString();
                        break;
                    case "division":
                        a = Rnd.Next(5, 9);
                        b = Rnd.Next(1, 5);
                        c = a / b;
                        Question = a.ToString() + " ÷ " + b.ToString();
                        break;


         
                }
                ans1 = c.ToString();
                ans2 = (c - 1).ToString();
                ans3 = (c - 2).ToString();
                ans4 = (c + 1).ToString();

            }
        }

        private void quit_Click(object sender, EventArgs e)
        {
            playClick();
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to quit?", "Quit", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
                QID = 1;
            }

            else if (dialogResult == DialogResult.No)
            {

            }
        }

        private void quit_MouseEnter(object sender, EventArgs e)
        {
            quit.BackColor = Color.FromArgb(192, 255, 192);
        }

        private void quit_MouseLeave(object sender, EventArgs e)
        {
            quit.BackColor = Color.FromArgb(255, 192, 192);
        }
    }
}



