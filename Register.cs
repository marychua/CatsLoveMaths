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
using System.Text.RegularExpressions;
using System.Net;
using System.Net.Mail;


namespace CatsLoveMathsAWD
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
            
 
        }
            bool EmailValid = false;
            bool PasswordValid = false;

        public string conString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=CLMDB;Integrated Security=True";

        private void reg_btn_Click(object sender, EventArgs e)
        {
            if (reg_un.Text == "" && reg_em.Text == "" && reg_pw.Text == "" && reg_pw1.Text == "")
            {
                MessageBox.Show("Invalid Fields");
            }
            else
            {
                SqlConnection con = new SqlConnection(conString);
                con.Open();


                if (con.State == System.Data.ConnectionState.Open && checkBox1.Checked && reg_pw.Text == reg_pw1.Text && !string.IsNullOrEmpty(reg_un.Text))
                {
                    //Check and compare if username already exist in database
                    string rn = "select * from CLMTable where Username=@Username";
                    SqlCommand cmd = new SqlCommand(rn, con);
                    cmd.Parameters.AddWithValue("@Username", reg_un.Text);
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        un_err.Show();
                        un_err.Text = "Username Already Taken";
                        reg_un.Focus();

                    }


                    //Check if email and password is valid before successful registration
                    else if (EmailValid == true && PasswordValid == true)
                    {
                        con.Close();
                        con.Open();
                        GenerateEmail();
                        string rn1 = "INSERT into CLMTable(ID,Username,Password,Email)values('" + reg_id.Text.ToString() + "','" + reg_un.Text.ToString() + "','" + reg_pw.Text.ToString() + "','" + reg_em.Text.ToString() + "')";
                        SqlCommand sc = new SqlCommand(rn1, con);
                        sc.ExecuteNonQuery();
                        MessageBox.Show("Registered Successfully!");
                        con.Close();
                        ClearError();
                        ClearFields();
                    }
                    else
                    {
                        MessageBox.Show("Register Failed!");
                    }
                }


                

                else if (!checkBox1.Checked)
                {
                    MessageBox.Show("You have to agree with Terms and Conditions!");
                }

                else if (reg_pw.Text != reg_pw1.Text)
                {
                    pw1_err.Text = "Password does not match. Try Again" ;
                    reg_pw.Clear();
                    reg_pw1.Clear();
                }
            }
        
    }
        
        //Validates email based on specific characters
        private void reg_em_Validating(object sender, CancelEventArgs e)
        {
            Regex validemail = new Regex(@"^[a-zA-Z][\w\.-]{2,28}[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");
            if (reg_em.Text.Length > 0)
            {
                if (!validemail.IsMatch(reg_em.Text))
                {
                    em_err.Show();
                    em_err.Text = "Please complete your email address";


                }
                else
                {
                    em_err.Hide();
                    EmailValid = true;
                }
            }

        }

        private void reg_pw_Validating(object sender, CancelEventArgs e)
        {
            
            if (reg_pw.Text.Length < 8)
                {
                    pw_err.Show();
                    pw_err.Text = "Must contain at least 8 characters";
                    PasswordValid = false;

            }
            
            if (reg_pw.Text.Length >= 8)
            {
                //^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,15}$    --- /w special char

                Regex validpassword = new Regex(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{8,15}$");
                if (!validpassword.IsMatch(reg_pw.Text))
                {
                    pw_err.Show();
                    pw_err.Text = "Must contain at least a number and one upper case letter";
                    reg_pw.SelectAll();
                    e.Cancel = true;
                }
                else
                {
                    pw_err.Hide();
                    PasswordValid = true;
                }
            }
        }

        

        //enables error messages when field is empty, when there is text, error message will disappear.
        private void reg_un_TextChanged(object sender, EventArgs e)
        {
            if (reg_un.Text == "")
            {
                un_err.Visible = true;
                un_err.Text = "Invalid Username";
            }

            else 
            {
                un_err.Visible = false;
            }
        }

        private void reg_em_TextChanged(object sender, EventArgs e)
        {
            if (reg_em.Text == "")
            {
                em_err.Visible = true;
            }

            else
            {
                em_err.Visible = false;
            }
        }

        private void reg_pw_TextChanged(object sender, EventArgs e)
        {
            if (reg_pw.Text == "")
            {
                pw_err.Visible = true;
                pw_err.Text = "Invalid Password";
            }

            else
            {
                pw_err.Visible = false;
            }
        }

        private void reg_pw1_TextChanged(object sender, EventArgs e)
        {
             if (reg_pw1.Text == "")
             {
                pw1_err.Visible = true;
             }

            else
            {
                pw1_err.Visible = false;
            }
        }


        //Clears all fields
        private void ClearFields()
        {
            reg_un.Clear();
            reg_em.Clear();
            reg_pw.Clear();
            reg_pw1.Clear();
            checkBox1.Checked = false;
            GenerateAutoID();


        }

        private void ClearError()
        {
            un_err.Text = "";
            em_err.Text = "";
            pw_err.Text = "";
            pw1_err.Text = "";

        }

        //Generates a new ID when form is loaded
        private void Register_Load(object sender, EventArgs e)
        {
            GenerateAutoID();
            reg_pw.UseSystemPasswordChar = true;
            reg_pw1.UseSystemPasswordChar = true;
        }

        //Generates ID based on CustomID(), catches error when fail to generate
        private void GenerateAutoID()
        {
            try
            {
                CustomID();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Genrate ID Error: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }

        //Generated is ID based on year,month,day,hour,minute
        private void CustomID()
        {
            string customID = string.Empty;
            DateTime dt = DateTime.Now;
            customID = dt.ToString("ID" + "yyyyMMddHHmmss");
            reg_id.Text = customID;
            
        }
        private void GenerateEmail()
        {
            SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
            client.EnableSsl = true;
            client.Timeout = 10000;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.UseDefaultCredentials = false;
            client.Credentials = new NetworkCredential("catslovemath.awd@gmail.com", "catslovemaths123");
            MailMessage msg = new MailMessage();
            msg.From = new MailAddress("catslovemath.awd@gmail.com"); 
            string mailbox = reg_em.Text.Trim();
            msg.To.Add(mailbox);
            msg.Body = " Welcome " + Environment.NewLine + Environment.NewLine + reg_un.Text + "! Thank you for registering Cats Love Maths! Your password is " + reg_pw.Text +
                Environment.NewLine + Environment.NewLine + " © 2019 CatsLoveMath All rights reserved " + Environment.NewLine
                + " Contact us: catslovemath.awd@gmail.com ";
            msg.Subject = "Registration Successful!";
            client.Send(msg);

        }
        //Closes Program and returns to startscreen
        private void back_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      


        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                reg_pw.UseSystemPasswordChar = false;
            }
            else
            {
                reg_pw.UseSystemPasswordChar = true;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                reg_pw1.UseSystemPasswordChar = false;
            }
            else
            {
                reg_pw1.UseSystemPasswordChar = true;
            }
        }

    }

}