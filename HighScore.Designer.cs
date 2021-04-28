namespace CatsLoveMathsAWD
{
    partial class HighScore
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HighScore));
            this.easy_lbl = new System.Windows.Forms.Label();
            this.back_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.hard_pic = new System.Windows.Forms.PictureBox();
            this.medium_pic = new System.Windows.Forms.PictureBox();
            this.easy_pic = new System.Windows.Forms.PictureBox();
            this.medium_lbl = new System.Windows.Forms.Label();
            this.hard_lbl = new System.Windows.Forms.Label();
            this.return_btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.attempt_panel = new System.Windows.Forms.Panel();
            this.hard_attempt = new System.Windows.Forms.Label();
            this.medium_attempt = new System.Windows.Forms.Label();
            this.hard_attempt_lbl = new System.Windows.Forms.Label();
            this.medium_attempt_lbl = new System.Windows.Forms.Label();
            this.easy_attempt = new System.Windows.Forms.Label();
            this.easy_attempt_lbl = new System.Windows.Forms.Label();
            this.score_6 = new System.Windows.Forms.Label();
            this.score_5 = new System.Windows.Forms.Label();
            this.score_4 = new System.Windows.Forms.Label();
            this.score_3 = new System.Windows.Forms.Label();
            this.score_2 = new System.Windows.Forms.Label();
            this.score_1 = new System.Windows.Forms.Label();
            this.categorylbl_6 = new System.Windows.Forms.Label();
            this.categorylbl_5 = new System.Windows.Forms.Label();
            this.categorylbl_4 = new System.Windows.Forms.Label();
            this.categorylbl_3 = new System.Windows.Forms.Label();
            this.categorylbl_2 = new System.Windows.Forms.Label();
            this.categorylbl_1 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.highscore_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label15 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.difficultyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoriesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scoreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gameScoreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cLMDBDataSet = new CatsLoveMathsAWD.CLMDBDataSet();
            this.gameScoreTableAdapter = new CatsLoveMathsAWD.CLMDBDataSetTableAdapters.GameScoreTableAdapter();
            this.last_seen = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hard_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medium_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.easy_pic)).BeginInit();
            this.panel1.SuspendLayout();
            this.attempt_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.highscore_chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameScoreBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLMDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // easy_lbl
            // 
            this.easy_lbl.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.easy_lbl.Font = new System.Drawing.Font("Hobo Std", 20F);
            this.easy_lbl.ForeColor = System.Drawing.Color.White;
            this.easy_lbl.Location = new System.Drawing.Point(16, 12);
            this.easy_lbl.Name = "easy_lbl";
            this.easy_lbl.Size = new System.Drawing.Size(183, 68);
            this.easy_lbl.TabIndex = 60;
            this.easy_lbl.Text = "Easy";
            this.easy_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.easy_lbl.Click += new System.EventHandler(this.easy_lbl_Click);
            // 
            // back_btn
            // 
            this.back_btn.BackColor = System.Drawing.Color.SlateBlue;
            this.back_btn.FlatAppearance.BorderSize = 0;
            this.back_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back_btn.Font = new System.Drawing.Font("Hobo Std", 17F);
            this.back_btn.ForeColor = System.Drawing.Color.White;
            this.back_btn.Location = new System.Drawing.Point(47, 571);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(155, 44);
            this.back_btn.TabIndex = 58;
            this.back_btn.Text = "Back";
            this.back_btn.UseVisualStyleBackColor = false;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Hobo Std", 30F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(37, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(277, 57);
            this.label2.TabIndex = 62;
            this.label2.Text = "My Highscore";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // hard_pic
            // 
            this.hard_pic.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.hard_pic.Image = global::CatsLoveMathsAWD.Properties.Resources.Hard1;
            this.hard_pic.Location = new System.Drawing.Point(19, 195);
            this.hard_pic.Name = "hard_pic";
            this.hard_pic.Size = new System.Drawing.Size(59, 42);
            this.hard_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.hard_pic.TabIndex = 74;
            this.hard_pic.TabStop = false;
            // 
            // medium_pic
            // 
            this.medium_pic.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.medium_pic.Image = global::CatsLoveMathsAWD.Properties.Resources.Medium1;
            this.medium_pic.Location = new System.Drawing.Point(19, 112);
            this.medium_pic.Name = "medium_pic";
            this.medium_pic.Size = new System.Drawing.Size(59, 42);
            this.medium_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.medium_pic.TabIndex = 73;
            this.medium_pic.TabStop = false;
            // 
            // easy_pic
            // 
            this.easy_pic.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.easy_pic.Image = global::CatsLoveMathsAWD.Properties.Resources.Easy1;
            this.easy_pic.Location = new System.Drawing.Point(18, 20);
            this.easy_pic.Name = "easy_pic";
            this.easy_pic.Size = new System.Drawing.Size(59, 52);
            this.easy_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.easy_pic.TabIndex = 72;
            this.easy_pic.TabStop = false;
            // 
            // medium_lbl
            // 
            this.medium_lbl.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.medium_lbl.Font = new System.Drawing.Font("Hobo Std", 20F);
            this.medium_lbl.ForeColor = System.Drawing.Color.White;
            this.medium_lbl.Location = new System.Drawing.Point(12, 99);
            this.medium_lbl.Name = "medium_lbl";
            this.medium_lbl.Size = new System.Drawing.Size(183, 68);
            this.medium_lbl.TabIndex = 75;
            this.medium_lbl.Text = "Medium";
            this.medium_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.medium_lbl.Click += new System.EventHandler(this.medium_lbl_Click);
            // 
            // hard_lbl
            // 
            this.hard_lbl.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.hard_lbl.Font = new System.Drawing.Font("Hobo Std", 20F);
            this.hard_lbl.ForeColor = System.Drawing.Color.White;
            this.hard_lbl.Location = new System.Drawing.Point(12, 183);
            this.hard_lbl.Name = "hard_lbl";
            this.hard_lbl.Size = new System.Drawing.Size(183, 68);
            this.hard_lbl.TabIndex = 77;
            this.hard_lbl.Text = "Hard";
            this.hard_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.hard_lbl.Click += new System.EventHandler(this.hard_lbl_Click);
            // 
            // return_btn
            // 
            this.return_btn.BackColor = System.Drawing.Color.SlateBlue;
            this.return_btn.FlatAppearance.BorderSize = 0;
            this.return_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.return_btn.Font = new System.Drawing.Font("Hobo Std", 17F);
            this.return_btn.ForeColor = System.Drawing.Color.White;
            this.return_btn.Location = new System.Drawing.Point(407, 39);
            this.return_btn.Name = "return_btn";
            this.return_btn.Size = new System.Drawing.Size(142, 45);
            this.return_btn.TabIndex = 78;
            this.return_btn.Text = "Return";
            this.return_btn.UseVisualStyleBackColor = false;
            this.return_btn.Visible = false;
            this.return_btn.Click += new System.EventHandler(this.return_btn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateBlue;
            this.panel1.Controls.Add(this.attempt_panel);
            this.panel1.Controls.Add(this.score_6);
            this.panel1.Controls.Add(this.score_5);
            this.panel1.Controls.Add(this.score_4);
            this.panel1.Controls.Add(this.score_3);
            this.panel1.Controls.Add(this.score_2);
            this.panel1.Controls.Add(this.score_1);
            this.panel1.Controls.Add(this.categorylbl_6);
            this.panel1.Controls.Add(this.categorylbl_5);
            this.panel1.Controls.Add(this.categorylbl_4);
            this.panel1.Controls.Add(this.categorylbl_3);
            this.panel1.Controls.Add(this.categorylbl_2);
            this.panel1.Controls.Add(this.categorylbl_1);
            this.panel1.Controls.Add(this.hard_pic);
            this.panel1.Controls.Add(this.medium_pic);
            this.panel1.Controls.Add(this.hard_lbl);
            this.panel1.Controls.Add(this.easy_pic);
            this.panel1.Controls.Add(this.medium_lbl);
            this.panel1.Controls.Add(this.easy_lbl);
            this.panel1.Location = new System.Drawing.Point(47, 90);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(502, 267);
            this.panel1.TabIndex = 79;
            // 
            // attempt_panel
            // 
            this.attempt_panel.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.attempt_panel.Controls.Add(this.hard_attempt);
            this.attempt_panel.Controls.Add(this.medium_attempt);
            this.attempt_panel.Controls.Add(this.hard_attempt_lbl);
            this.attempt_panel.Controls.Add(this.medium_attempt_lbl);
            this.attempt_panel.Controls.Add(this.easy_attempt);
            this.attempt_panel.Controls.Add(this.easy_attempt_lbl);
            this.attempt_panel.Location = new System.Drawing.Point(218, 12);
            this.attempt_panel.Name = "attempt_panel";
            this.attempt_panel.Size = new System.Drawing.Size(260, 239);
            this.attempt_panel.TabIndex = 92;
            // 
            // hard_attempt
            // 
            this.hard_attempt.BackColor = System.Drawing.Color.Transparent;
            this.hard_attempt.Font = new System.Drawing.Font("Hobo Std", 18F);
            this.hard_attempt.ForeColor = System.Drawing.Color.White;
            this.hard_attempt.Location = new System.Drawing.Point(176, 185);
            this.hard_attempt.Name = "hard_attempt";
            this.hard_attempt.Size = new System.Drawing.Size(64, 34);
            this.hard_attempt.TabIndex = 92;
            this.hard_attempt.Text = "0";
            this.hard_attempt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // medium_attempt
            // 
            this.medium_attempt.BackColor = System.Drawing.Color.Transparent;
            this.medium_attempt.Font = new System.Drawing.Font("Hobo Std", 18F);
            this.medium_attempt.ForeColor = System.Drawing.Color.White;
            this.medium_attempt.Location = new System.Drawing.Point(176, 100);
            this.medium_attempt.Name = "medium_attempt";
            this.medium_attempt.Size = new System.Drawing.Size(64, 34);
            this.medium_attempt.TabIndex = 91;
            this.medium_attempt.Text = "0";
            this.medium_attempt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // hard_attempt_lbl
            // 
            this.hard_attempt_lbl.BackColor = System.Drawing.Color.Transparent;
            this.hard_attempt_lbl.Font = new System.Drawing.Font("Hobo Std", 18F);
            this.hard_attempt_lbl.ForeColor = System.Drawing.Color.White;
            this.hard_attempt_lbl.Location = new System.Drawing.Point(24, 185);
            this.hard_attempt_lbl.Name = "hard_attempt_lbl";
            this.hard_attempt_lbl.Size = new System.Drawing.Size(118, 34);
            this.hard_attempt_lbl.TabIndex = 90;
            this.hard_attempt_lbl.Text = "Attempts";
            this.hard_attempt_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // medium_attempt_lbl
            // 
            this.medium_attempt_lbl.BackColor = System.Drawing.Color.Transparent;
            this.medium_attempt_lbl.Font = new System.Drawing.Font("Hobo Std", 18F);
            this.medium_attempt_lbl.ForeColor = System.Drawing.Color.White;
            this.medium_attempt_lbl.Location = new System.Drawing.Point(24, 100);
            this.medium_attempt_lbl.Name = "medium_attempt_lbl";
            this.medium_attempt_lbl.Size = new System.Drawing.Size(118, 34);
            this.medium_attempt_lbl.TabIndex = 89;
            this.medium_attempt_lbl.Text = "Attempts";
            this.medium_attempt_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // easy_attempt
            // 
            this.easy_attempt.BackColor = System.Drawing.Color.Transparent;
            this.easy_attempt.Font = new System.Drawing.Font("Hobo Std", 18F);
            this.easy_attempt.ForeColor = System.Drawing.Color.White;
            this.easy_attempt.Location = new System.Drawing.Point(176, 18);
            this.easy_attempt.Name = "easy_attempt";
            this.easy_attempt.Size = new System.Drawing.Size(64, 34);
            this.easy_attempt.TabIndex = 88;
            this.easy_attempt.Text = "0";
            this.easy_attempt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // easy_attempt_lbl
            // 
            this.easy_attempt_lbl.BackColor = System.Drawing.Color.Transparent;
            this.easy_attempt_lbl.Font = new System.Drawing.Font("Hobo Std", 18F);
            this.easy_attempt_lbl.ForeColor = System.Drawing.Color.White;
            this.easy_attempt_lbl.Location = new System.Drawing.Point(24, 18);
            this.easy_attempt_lbl.Name = "easy_attempt_lbl";
            this.easy_attempt_lbl.Size = new System.Drawing.Size(118, 34);
            this.easy_attempt_lbl.TabIndex = 87;
            this.easy_attempt_lbl.Text = "Attempts";
            this.easy_attempt_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // score_6
            // 
            this.score_6.BackColor = System.Drawing.Color.Transparent;
            this.score_6.Font = new System.Drawing.Font("Hobo Std", 18F);
            this.score_6.ForeColor = System.Drawing.Color.White;
            this.score_6.Location = new System.Drawing.Point(400, 201);
            this.score_6.Name = "score_6";
            this.score_6.Size = new System.Drawing.Size(99, 34);
            this.score_6.TabIndex = 91;
            this.score_6.Text = "100";
            this.score_6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.score_6.Visible = false;
            // 
            // score_5
            // 
            this.score_5.BackColor = System.Drawing.Color.Transparent;
            this.score_5.Font = new System.Drawing.Font("Hobo Std", 18F);
            this.score_5.ForeColor = System.Drawing.Color.White;
            this.score_5.Location = new System.Drawing.Point(400, 163);
            this.score_5.Name = "score_5";
            this.score_5.Size = new System.Drawing.Size(99, 34);
            this.score_5.TabIndex = 90;
            this.score_5.Text = "100";
            this.score_5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.score_5.Visible = false;
            // 
            // score_4
            // 
            this.score_4.BackColor = System.Drawing.Color.Transparent;
            this.score_4.Font = new System.Drawing.Font("Hobo Std", 18F);
            this.score_4.ForeColor = System.Drawing.Color.White;
            this.score_4.Location = new System.Drawing.Point(400, 129);
            this.score_4.Name = "score_4";
            this.score_4.Size = new System.Drawing.Size(99, 34);
            this.score_4.TabIndex = 89;
            this.score_4.Text = "100";
            this.score_4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.score_4.Visible = false;
            // 
            // score_3
            // 
            this.score_3.BackColor = System.Drawing.Color.Transparent;
            this.score_3.Font = new System.Drawing.Font("Hobo Std", 18F);
            this.score_3.ForeColor = System.Drawing.Color.White;
            this.score_3.Location = new System.Drawing.Point(400, 95);
            this.score_3.Name = "score_3";
            this.score_3.Size = new System.Drawing.Size(99, 34);
            this.score_3.TabIndex = 88;
            this.score_3.Text = "100";
            this.score_3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.score_3.Visible = false;
            // 
            // score_2
            // 
            this.score_2.BackColor = System.Drawing.Color.Transparent;
            this.score_2.Font = new System.Drawing.Font("Hobo Std", 18F);
            this.score_2.ForeColor = System.Drawing.Color.White;
            this.score_2.Location = new System.Drawing.Point(400, 61);
            this.score_2.Name = "score_2";
            this.score_2.Size = new System.Drawing.Size(99, 34);
            this.score_2.TabIndex = 87;
            this.score_2.Text = "100";
            this.score_2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.score_2.Visible = false;
            // 
            // score_1
            // 
            this.score_1.BackColor = System.Drawing.Color.Transparent;
            this.score_1.Font = new System.Drawing.Font("Hobo Std", 18F);
            this.score_1.ForeColor = System.Drawing.Color.White;
            this.score_1.Location = new System.Drawing.Point(400, 30);
            this.score_1.Name = "score_1";
            this.score_1.Size = new System.Drawing.Size(99, 34);
            this.score_1.TabIndex = 86;
            this.score_1.Text = "100";
            this.score_1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.score_1.Visible = false;
            // 
            // categorylbl_6
            // 
            this.categorylbl_6.BackColor = System.Drawing.Color.Transparent;
            this.categorylbl_6.Font = new System.Drawing.Font("Hobo Std", 18F);
            this.categorylbl_6.ForeColor = System.Drawing.Color.White;
            this.categorylbl_6.Location = new System.Drawing.Point(214, 201);
            this.categorylbl_6.Name = "categorylbl_6";
            this.categorylbl_6.Size = new System.Drawing.Size(179, 34);
            this.categorylbl_6.TabIndex = 85;
            this.categorylbl_6.Text = "Category 6";
            this.categorylbl_6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.categorylbl_6.Visible = false;
            // 
            // categorylbl_5
            // 
            this.categorylbl_5.BackColor = System.Drawing.Color.Transparent;
            this.categorylbl_5.Font = new System.Drawing.Font("Hobo Std", 18F);
            this.categorylbl_5.ForeColor = System.Drawing.Color.White;
            this.categorylbl_5.Location = new System.Drawing.Point(214, 163);
            this.categorylbl_5.Name = "categorylbl_5";
            this.categorylbl_5.Size = new System.Drawing.Size(179, 34);
            this.categorylbl_5.TabIndex = 84;
            this.categorylbl_5.Text = "Category 5";
            this.categorylbl_5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.categorylbl_5.Visible = false;
            // 
            // categorylbl_4
            // 
            this.categorylbl_4.BackColor = System.Drawing.Color.Transparent;
            this.categorylbl_4.Font = new System.Drawing.Font("Hobo Std", 18F);
            this.categorylbl_4.ForeColor = System.Drawing.Color.White;
            this.categorylbl_4.Location = new System.Drawing.Point(214, 129);
            this.categorylbl_4.Name = "categorylbl_4";
            this.categorylbl_4.Size = new System.Drawing.Size(179, 34);
            this.categorylbl_4.TabIndex = 83;
            this.categorylbl_4.Text = "Category 4";
            this.categorylbl_4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.categorylbl_4.Visible = false;
            // 
            // categorylbl_3
            // 
            this.categorylbl_3.BackColor = System.Drawing.Color.Transparent;
            this.categorylbl_3.Font = new System.Drawing.Font("Hobo Std", 18F);
            this.categorylbl_3.ForeColor = System.Drawing.Color.White;
            this.categorylbl_3.Location = new System.Drawing.Point(214, 95);
            this.categorylbl_3.Name = "categorylbl_3";
            this.categorylbl_3.Size = new System.Drawing.Size(179, 34);
            this.categorylbl_3.TabIndex = 82;
            this.categorylbl_3.Text = "Category 3";
            this.categorylbl_3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.categorylbl_3.Visible = false;
            // 
            // categorylbl_2
            // 
            this.categorylbl_2.BackColor = System.Drawing.Color.Transparent;
            this.categorylbl_2.Font = new System.Drawing.Font("Hobo Std", 18F);
            this.categorylbl_2.ForeColor = System.Drawing.Color.White;
            this.categorylbl_2.Location = new System.Drawing.Point(214, 61);
            this.categorylbl_2.Name = "categorylbl_2";
            this.categorylbl_2.Size = new System.Drawing.Size(179, 34);
            this.categorylbl_2.TabIndex = 81;
            this.categorylbl_2.Text = "Category 2";
            this.categorylbl_2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.categorylbl_2.Visible = false;
            // 
            // categorylbl_1
            // 
            this.categorylbl_1.BackColor = System.Drawing.Color.Transparent;
            this.categorylbl_1.Font = new System.Drawing.Font("Hobo Std", 18F);
            this.categorylbl_1.ForeColor = System.Drawing.Color.White;
            this.categorylbl_1.Location = new System.Drawing.Point(214, 27);
            this.categorylbl_1.Name = "categorylbl_1";
            this.categorylbl_1.Size = new System.Drawing.Size(179, 34);
            this.categorylbl_1.TabIndex = 80;
            this.categorylbl_1.Text = "Category 1";
            this.categorylbl_1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.categorylbl_1.Visible = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Hobo Std", 30F);
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(37, 358);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(161, 57);
            this.label14.TabIndex = 81;
            this.label14.Text = "History";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // highscore_chart
            // 
            chartArea1.Name = "ChartArea1";
            this.highscore_chart.ChartAreas.Add(chartArea1);
            this.highscore_chart.Location = new System.Drawing.Point(579, 90);
            this.highscore_chart.Name = "highscore_chart";
            series1.ChartArea = "ChartArea1";
            series1.Name = "Series1";
            this.highscore_chart.Series.Add(series1);
            this.highscore_chart.Size = new System.Drawing.Size(396, 457);
            this.highscore_chart.TabIndex = 83;
            this.highscore_chart.Text = "chart1";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Hobo Std", 30F);
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(586, 30);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(127, 57);
            this.label15.TabIndex = 84;
            this.label15.Text = "Chart";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gIDDataGridViewTextBoxColumn,
            this.difficultyDataGridViewTextBoxColumn,
            this.categoriesDataGridViewTextBoxColumn,
            this.scoreDataGridViewTextBoxColumn,
            this.uIDDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.gameScoreBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(51, 415);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(497, 131);
            this.dataGridView1.TabIndex = 86;
            // 
            // gIDDataGridViewTextBoxColumn
            // 
            this.gIDDataGridViewTextBoxColumn.DataPropertyName = "GID";
            this.gIDDataGridViewTextBoxColumn.HeaderText = "GID";
            this.gIDDataGridViewTextBoxColumn.Name = "gIDDataGridViewTextBoxColumn";
            this.gIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // difficultyDataGridViewTextBoxColumn
            // 
            this.difficultyDataGridViewTextBoxColumn.DataPropertyName = "Difficulty";
            this.difficultyDataGridViewTextBoxColumn.HeaderText = "Difficulty";
            this.difficultyDataGridViewTextBoxColumn.Name = "difficultyDataGridViewTextBoxColumn";
            this.difficultyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // categoriesDataGridViewTextBoxColumn
            // 
            this.categoriesDataGridViewTextBoxColumn.DataPropertyName = "Categories";
            this.categoriesDataGridViewTextBoxColumn.HeaderText = "Categories";
            this.categoriesDataGridViewTextBoxColumn.Name = "categoriesDataGridViewTextBoxColumn";
            this.categoriesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // scoreDataGridViewTextBoxColumn
            // 
            this.scoreDataGridViewTextBoxColumn.DataPropertyName = "Score";
            this.scoreDataGridViewTextBoxColumn.HeaderText = "Score";
            this.scoreDataGridViewTextBoxColumn.Name = "scoreDataGridViewTextBoxColumn";
            this.scoreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // uIDDataGridViewTextBoxColumn
            // 
            this.uIDDataGridViewTextBoxColumn.DataPropertyName = "UID";
            this.uIDDataGridViewTextBoxColumn.HeaderText = "UID";
            this.uIDDataGridViewTextBoxColumn.Name = "uIDDataGridViewTextBoxColumn";
            this.uIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gameScoreBindingSource
            // 
            this.gameScoreBindingSource.DataMember = "GameScore";
            this.gameScoreBindingSource.DataSource = this.cLMDBDataSet;
            // 
            // cLMDBDataSet
            // 
            this.cLMDBDataSet.DataSetName = "CLMDBDataSet";
            this.cLMDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gameScoreTableAdapter
            // 
            this.gameScoreTableAdapter.ClearBeforeFill = true;
            // 
            // last_seen
            // 
            this.last_seen.BackColor = System.Drawing.Color.Transparent;
            this.last_seen.Font = new System.Drawing.Font("Tahoma", 14F);
            this.last_seen.ForeColor = System.Drawing.Color.White;
            this.last_seen.Location = new System.Drawing.Point(217, 383);
            this.last_seen.Name = "last_seen";
            this.last_seen.Size = new System.Drawing.Size(329, 23);
            this.last_seen.TabIndex = 85;
            this.last_seen.Text = "No Records";
            this.last_seen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // HighScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1024, 640);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.last_seen);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.return_btn);
            this.Controls.Add(this.highscore_chart);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HighScore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HighScore";
            this.Load += new System.EventHandler(this.HighScore_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hard_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medium_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.easy_pic)).EndInit();
            this.panel1.ResumeLayout(false);
            this.attempt_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.highscore_chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameScoreBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLMDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label easy_lbl;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox hard_pic;
        private System.Windows.Forms.PictureBox medium_pic;
        private System.Windows.Forms.PictureBox easy_pic;
        private System.Windows.Forms.Label medium_lbl;
        private System.Windows.Forms.Label hard_lbl;
        private System.Windows.Forms.Button return_btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label categorylbl_6;
        private System.Windows.Forms.Label categorylbl_5;
        private System.Windows.Forms.Label categorylbl_4;
        private System.Windows.Forms.Label categorylbl_3;
        private System.Windows.Forms.Label categorylbl_2;
        private System.Windows.Forms.Label categorylbl_1;
        private System.Windows.Forms.Label score_6;
        private System.Windows.Forms.Label score_5;
        private System.Windows.Forms.Label score_4;
        private System.Windows.Forms.Label score_3;
        private System.Windows.Forms.Label score_2;
        private System.Windows.Forms.Label score_1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataVisualization.Charting.Chart highscore_chart;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel attempt_panel;
        private System.Windows.Forms.Label hard_attempt;
        private System.Windows.Forms.Label medium_attempt;
        private System.Windows.Forms.Label hard_attempt_lbl;
        private System.Windows.Forms.Label medium_attempt_lbl;
        private System.Windows.Forms.Label easy_attempt;
        private System.Windows.Forms.Label easy_attempt_lbl;
        private System.Windows.Forms.DataGridView dataGridView1;
        private CLMDBDataSet cLMDBDataSet;
        private System.Windows.Forms.BindingSource gameScoreBindingSource;
        private CLMDBDataSetTableAdapters.GameScoreTableAdapter gameScoreTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn gIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn difficultyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoriesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn scoreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label last_seen;
    }
}