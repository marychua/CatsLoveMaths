using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Net;
using System.Net.Mail;

namespace CatsLoveMathsAWD
{
    public partial class ResetPassword : Form
    {
        public ResetPassword()
        {
            InitializeComponent();
        }

        private void Recover_btn_Click(object sender, EventArgs e)
        {
            string con = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=CLMDB;Integrated Security=True";
            string Query = "select Password From CLMTable where Email= '" + em.Text + "'";
            SqlConnection conDatabase = new SqlConnection(con);
            SqlCommand cmdDatabase = new SqlCommand(Query, conDatabase);
            SqlDataReader myReader;
            try
            {
                conDatabase.Open();
                myReader = cmdDatabase.ExecuteReader();
                myReader.Read();
                string pass = myReader["Password"].ToString();
  
                SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                client.EnableSsl = true;
                client.Timeout = 10000;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = false;
                client.Credentials = new NetworkCredential("catslovemath.awd@gmail.com", "catslovemaths123");
                MailMessage msg = new MailMessage();
                msg.From = new MailAddress("catslovemath.awd@gmail.com");
                string mailbox = em.Text.Trim();
                msg.To.Add(mailbox);
                msg.Body = " Hi " + Environment.NewLine + Environment.NewLine + "You have requested to recover your password, Please refer below for you password" + Environment.NewLine + pass + 
                    Environment.NewLine + Environment.NewLine + " © 2019 CatLoveMath All rights reserved " + Environment.NewLine + " Contact us: catslovemaths.awd@gmail.com ";
                msg.Subject = "Password Recovery";
                client.Send(msg);
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid Email");
            }

        }
            
           

        private void Return_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
