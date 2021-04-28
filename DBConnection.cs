using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CatsLoveMathsAWD
{
    class DBConnection
    {
        public int easycount, mediumcount, hardcount, score1, score2, score3, score4, score5, score6;

        public static SqlConnection dbconnect()
        {
            string conString;
            conString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=CLMDB;Integrated Security=True";
            return new SqlConnection(conString);
        }

        public void getattempts(string UID)
        {
            easycount = 0;
            mediumcount = 0;
            hardcount = 0;
            SqlConnection newConnection = dbconnect();
            string counteasy = "Select COUNT(*) from GameScore  where UID = '" + UID + "' and Difficulty = 'Easy'";
            string countmedium = "Select COUNT(*) from GameScore  where UID = '" + UID + "' and Difficulty = 'Medium'";
            string counthard = "Select COUNT(*) from GameScore  where UID = '" + UID + "' and Difficulty = 'Hard'";
            SqlCommand Commandeasy = new SqlCommand(counteasy, newConnection);
            SqlCommand Commandmedium = new SqlCommand(countmedium, newConnection);
            SqlCommand Commandhard = new SqlCommand(counthard, newConnection);


            try
            {
                newConnection.Open();
                easycount = (int)Commandeasy.ExecuteScalar();
                mediumcount = (int)Commandmedium.ExecuteScalar();
                hardcount = (int)Commandhard.ExecuteScalar();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                newConnection.Close();
            }
            return;
        }
        public void getscore(string UID, int i)
        {
            score1 = 0;
            score2 = 0;
            score3 = 0;
            score4 = 0;
            SqlConnection newConnection = dbconnect();
            string max1 = "SELECT MAX(Score) FROM GameScore where UID = '"+UID+"' and Difficulty = 'Easy' and Categories = 'addition'";
            string max2 = "SELECT MAX(Score) FROM GameScore where UID = '" + UID + "'and Difficulty = 'Easy' and Categories = 'subtraction'";
            string max3 = "SELECT MAX(Score) FROM GameScore where UID = '" + UID + "' and Difficulty = 'Easy' and Categories = 'multiplication'";
            string max4 = "SELECT MAX(Score) FROM GameScore where UID = '" + UID + "' and Difficulty = 'Easy' and Categories = 'division'";

            SqlCommand Command1 = new SqlCommand(max1, newConnection);
            SqlCommand Command2 = new SqlCommand(max2, newConnection);
            SqlCommand Command3 = new SqlCommand(max3, newConnection);
            SqlCommand Command4 = new SqlCommand(max4, newConnection);

            try
            {
                newConnection.Open();
                score1 = (int)Command1.ExecuteScalar();
                score2 = (int)Command2.ExecuteScalar();
                score3 = (int)Command3.ExecuteScalar();
                score4 = (int)Command4.ExecuteScalar();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                newConnection.Close();
            }
            return;
        }
        public void getscore(string UID, float i)
        {
            score1 = 0;
            score2 = 0;
            score3 = 0;
            score4 = 0;
            score5 = 0;
            SqlConnection newConnection = dbconnect();
            string max1 = "SELECT MAX(Score) FROM GameScore where UID = '" + UID + "' and Difficulty = 'Medium' and Categories = 'addition2'";
            string max2 = "SELECT MAX(Score) FROM GameScore where UID = '" + UID + "'and Difficulty = 'Medium' and Categories = 'subtraction2'";
            string max3 = "SELECT MAX(Score) FROM GameScore where UID = '" + UID + "' and Difficulty = 'Medium' and Categories = 'multiplication2'";
            string max4 = "SELECT MAX(Score) FROM GameScore where UID = '" + UID + "' and Difficulty = 'Medium' and Categories = 'division2'";
            string max5 = "SELECT MAX(Score) FROM GameScore where UID = '" + UID + "' and Difficulty = 'Medium' and Categories = 'fraction'";

            SqlCommand Command1 = new SqlCommand(max1, newConnection);
            SqlCommand Command2 = new SqlCommand(max2, newConnection);
            SqlCommand Command3 = new SqlCommand(max3, newConnection);
            SqlCommand Command4 = new SqlCommand(max4, newConnection);
            SqlCommand Command5 = new SqlCommand(max5, newConnection);

            try
            {
                newConnection.Open();
                score1 = (int)Command1.ExecuteScalar();
                score2 = (int)Command2.ExecuteScalar();
                score3 = (int)Command3.ExecuteScalar();
                score4 = (int)Command4.ExecuteScalar();
                score5 = (int)Command5.ExecuteScalar();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                newConnection.Close();
            }
            return;
        }
        public void getscore(string UID, string i)
        {
            score1 = 0;
            score2 = 0;
            score3 = 0;
            score4 = 0;
            score5 = 0;
            score6 = 0;
            SqlConnection newConnection = dbconnect();
            string max1 = "SELECT MAX(Score) FROM GameScore where UID = '" + UID + "' and Difficulty = 'Hard' and Categories = 'rn'";
            string max2 = "SELECT MAX(Score) FROM GameScore where UID = '" + UID + "' and Difficulty = 'Hard' and Categories = 'scr'";
            string max3 = "SELECT MAX(Score) FROM GameScore where UID = '" + UID + "' and Difficulty = 'Hard' and Categories = 'ae'";
            string max4 = "SELECT MAX(Score) FROM GameScore where UID = '" + UID + "' and Difficulty = 'Hard' and Categories = 'pt'";
            string max5 = "SELECT MAX(Score) FROM GameScore where UID = '" + UID + "' and Difficulty = 'Hard' and Categories = 'probability'";
            string max6 = "SELECT MAX(Score) FROM GameScore where UID = '" + UID + "' and Difficulty = 'Hard' and Categories = 'statistics'";

            SqlCommand Command1 = new SqlCommand(max1, newConnection);
            SqlCommand Command2 = new SqlCommand(max2, newConnection);
            SqlCommand Command3 = new SqlCommand(max3, newConnection);
            SqlCommand Command4 = new SqlCommand(max4, newConnection);
            SqlCommand Command5 = new SqlCommand(max5, newConnection);
            SqlCommand Command6 = new SqlCommand(max6, newConnection);

            try
            {
                newConnection.Open();
                score1 = (int)Command1.ExecuteScalar();
                score2 = (int)Command2.ExecuteScalar();
                score3 = (int)Command3.ExecuteScalar();
                score4 = (int)Command4.ExecuteScalar();
                score5 = (int)Command5.ExecuteScalar();
                score6 = (int)Command6.ExecuteScalar();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                newConnection.Close();
            }
            return;
        }
        public static void filltable(string UID)
        {



        }
    }

    
}
