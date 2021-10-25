using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Shopping_Management_System
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            if (textBox_email.TextLength == 0)
            {
                textBox_email.Text = "Email";
      
            }
            if (textBox_username.Text == "Username")
            {
                textBox_username.Clear();
            }
            if (textBox_pass.TextLength == 0)
            {
                textBox_pass.Text = "Password";
                textBox_pass.PasswordChar = '\0';
            }
            if (textBox_re_pass.TextLength == 0)
            {
                textBox_re_pass.Text = "Re-Enter Passsword";
                textBox_re_pass.PasswordChar = '\0';
            }
            if (textBox_address.TextLength == 0)
            {
                textBox_address.Text = "Address";
            }

            pic_user.Image = Properties.Resources.username_logo2;
            panel1.BackColor = Color.FromArgb(255, 255, 255);
            textBox_username.ForeColor = Color.FromArgb(255, 255, 255);

            pic_email.Image = Properties.Resources.email_icon2;
            panel2.BackColor = Color.FromArgb(245, 173, 91);
            textBox_email.ForeColor = Color.FromArgb(245, 173, 91);

            pic_pas.Image = Properties.Resources.pass_icon;
            panel3.BackColor = Color.FromArgb(245, 173, 91);
            textBox_pass.ForeColor = Color.FromArgb(245, 173, 91);

            pic_pas2.Image = Properties.Resources.pass_icon;
            panel4.BackColor = Color.FromArgb(245, 173, 91);
            textBox_re_pass.ForeColor = Color.FromArgb(245, 173, 91);


            pic_address.Image = Properties.Resources.address_icon2;
            panel5.BackColor = Color.FromArgb(245, 173, 91);
            textBox_address.ForeColor = Color.FromArgb(245, 173, 91);
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            if (textBox_username.TextLength == 0)
            {
                textBox_username.Text = "Username";

            }
            if (textBox_email.Text == "Email")
            {
                textBox_email.Clear();
            }
            if (textBox_pass.TextLength == 0)
            {
                textBox_pass.Text = "Password";
                textBox_pass.PasswordChar = '\0';
            }
            if (textBox_re_pass.TextLength == 0)
            {
                textBox_re_pass.Text = "Re-Enter Passsword";
                textBox_re_pass.PasswordChar = '\0';
            }
            if (textBox_address.TextLength == 0)
            {
                textBox_address.Text = "Address";
            }

            pic_user.Image = Properties.Resources.username_logo;
            panel1.BackColor = Color.FromArgb(245, 173, 91);
            textBox_username.ForeColor = Color.FromArgb(245, 173, 91);

            pic_email.Image = Properties.Resources.email_icon;
            panel2.BackColor = Color.FromArgb(255, 255, 255);
            textBox_email.ForeColor = Color.FromArgb(255, 255, 255);

            pic_pas.Image = Properties.Resources.pass_icon;
            panel3.BackColor = Color.FromArgb(245, 173, 91);
            textBox_pass.ForeColor = Color.FromArgb(245, 173, 91);

            pic_pas2.Image = Properties.Resources.pass_icon;
            panel4.BackColor = Color.FromArgb(245, 173, 91);
            textBox_re_pass.ForeColor = Color.FromArgb(245, 173, 91);


            pic_address.Image = Properties.Resources.address_icon2;
            panel5.BackColor = Color.FromArgb(245, 173, 91);
            textBox_address.ForeColor = Color.FromArgb(245, 173, 91);
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            if (textBox_username.TextLength == 0)
            {
                textBox_username.Text = "Username";
            }
            if(textBox_email.TextLength == 0)
            {
                textBox_email.Text = "Email";
            }
            if (textBox_pass.Text == "Password")
            {
                textBox_pass.Clear();
                textBox_pass.PasswordChar = '*';
            }
            if (textBox_re_pass.TextLength == 0)
            {
                textBox_re_pass.Text = "Re-Enter Passsword";
                textBox_re_pass.PasswordChar = '\0';
            }
            if (textBox_address.TextLength == 0)
            {
                textBox_address.Text = "Address";
            }
            pic_user.Image = Properties.Resources.username_logo;
            panel1.BackColor = Color.FromArgb(245, 173, 91);
            textBox_username.ForeColor = Color.FromArgb(245, 173, 91);

            pic_email.Image = Properties.Resources.email_icon2;
            panel2.BackColor = Color.FromArgb(245, 173, 91);
            textBox_email.ForeColor = Color.FromArgb(245, 173, 91);

            pic_pas.Image = Properties.Resources.pass_icon2;
            panel3.BackColor = Color.FromArgb(255, 255, 255);
            textBox_pass.ForeColor = Color.FromArgb(255, 255, 255);

            pic_pas2.Image = Properties.Resources.pass_icon;
            panel4.BackColor = Color.FromArgb(245, 173, 91);
            textBox_re_pass.ForeColor = Color.FromArgb(245, 173, 91);


            pic_address.Image = Properties.Resources.address_icon2;
            panel5.BackColor = Color.FromArgb(245, 173, 91);
            textBox_address.ForeColor = Color.FromArgb(245, 173, 91);
        }

        private void textBox4_Click(object sender, EventArgs e)
        {
            if (textBox_username.TextLength == 0)
            {
                textBox_username.Text = "Username";
            }
            if (textBox_email.TextLength == 0)
            {
                textBox_email.Text = "Email";
            }
            if(textBox_pass.TextLength == 0)
            {
                textBox_pass.Text = "Password";
                textBox_pass.PasswordChar = '\0';
            }
            if (textBox_re_pass.Text == "Re-Enter Passsword")
            {
                textBox_re_pass.Clear();
                textBox_re_pass.PasswordChar = '*';
            }
            if (textBox_address.TextLength == 0)
            {
                textBox_address.Text = "Address";
            }
            pic_user.Image = Properties.Resources.username_logo;
            panel1.BackColor = Color.FromArgb(245, 173, 91);
            textBox_username.ForeColor = Color.FromArgb(245, 173, 91);

            pic_email.Image = Properties.Resources.email_icon2;
            panel2.BackColor = Color.FromArgb(245, 173, 91);
            textBox_email.ForeColor = Color.FromArgb(245, 173, 91);

            pic_pas.Image = Properties.Resources.pass_icon;
            panel3.BackColor = Color.FromArgb(245, 173, 91);
            textBox_pass.ForeColor = Color.FromArgb(245, 173, 91);

            pic_pas2.Image = Properties.Resources.pass_icon2;
            panel4.BackColor = Color.FromArgb(255, 255, 255);
            textBox_re_pass.ForeColor = Color.FromArgb(255, 255, 255);


            pic_address.Image = Properties.Resources.address_icon2;
            panel5.BackColor = Color.FromArgb(245, 173, 91);
            textBox_address.ForeColor = Color.FromArgb(245, 173, 91);
        }

        private void textBox5_Click(object sender, EventArgs e)
        {
            if (textBox_username.TextLength == 0)
            {
                textBox_username.Text = "Username";

            }
            if (textBox_address.Text == "Address")
            {
                textBox_address.Clear();
            }
            if (textBox_pass.TextLength == 0)
            {
                textBox_pass.Text = "Password";
                textBox_pass.PasswordChar = '\0';
            }
            if (textBox_re_pass.TextLength == 0)
            {
                textBox_re_pass.Text = "Re-Enter Passsword";
                textBox_re_pass.PasswordChar = '\0';
            }
            if (textBox_email.TextLength == 0)
            {
                textBox_email.Text = "Email";
            }

            pic_user.Image = Properties.Resources.username_logo;
            panel1.BackColor = Color.FromArgb(245, 173, 91);
            textBox_username.ForeColor = Color.FromArgb(245, 173, 91);

            pic_email.Image = Properties.Resources.email_icon2;
            panel2.BackColor = Color.FromArgb(245, 173, 91);
            textBox_email.ForeColor = Color.FromArgb(245, 173, 91);

            pic_pas.Image = Properties.Resources.pass_icon;
            panel3.BackColor = Color.FromArgb(245, 173, 91);
            textBox_pass.ForeColor = Color.FromArgb(245, 173, 91);

            pic_pas2.Image = Properties.Resources.pass_icon;
            panel4.BackColor = Color.FromArgb(245, 173, 91);
            textBox_re_pass.ForeColor = Color.FromArgb(245, 173, 91);


            pic_address.Image = Properties.Resources.address_icon;
            panel5.BackColor = Color.FromArgb(255, 255, 255);
            textBox_address.ForeColor = Color.FromArgb(255, 255, 255);
        }

        string image_location;
        
        private void button1_Click(object sender, EventArgs e)
        {
            
            if (textBox_pass.Text == textBox_re_pass.Text)
            {   
                SqlConnection con = new SqlConnection(@"Data Source=MANOR\MANARSQL;Initial Catalog=""Shopping System"";Integrated Security=True");
                con.Open();                 // open connection 
                SqlCommand cmd = new SqlCommand("select count(*) from User_Info where Name='" + textBox_username.Text + "'", con);
                int result = Convert.ToInt32(cmd.ExecuteScalar());
                if (result ==0)
                {
                    bool rbdtext_gender = false;
                    if (radioButton_male.Checked == true) // male 
                    {
                        rbdtext_gender = false;
                    }
                    else if (radioButton_female.Checked) // female 
                    {
                        rbdtext_gender = true;
                    }

                    /////////// type 
                    bool rbdtext_type = false;
                    if (radioButton_admin.Checked) // admin
                    {
                        rbdtext_type = true;
                    }
                    else if (radioButton_user.Checked) /// user
                    {
                        rbdtext_type = false;
                    }

                    
                    if (pictureBox_upload.Image != Properties.Resources.username_logo)
                    {
                        
                        string query = "INSERT INTO  User_Info( Picture,Name,Email, Address, Password,Gender ,User_Type,Pocket_Money) values ('"+image_location+"','" + textBox_username.Text + "','" + textBox_email.Text + "','" + textBox_address.Text + "','" + textBox_pass.Text + "','" + rbdtext_gender + "','" + rbdtext_type + "','0' );";
                        cmd = new SqlCommand(query, con);
                    
                        cmd.ExecuteNonQuery();
                        con.Close();
                        hello_window hello_Window = new hello_window();
                        hello_Window.Show();
                        this.Hide();

                    }
                    else
                    {
                        string query = "INSERT INTO  User_Info(Picture,Name,Email, Address, Password,Gender ,User_Type,Pocket_Money) values ('NULL','" + textBox_username.Text + "','" + textBox_email.Text + "','" + textBox_address.Text + "','" + textBox_pass.Text + "','" + rbdtext_gender + "','" + rbdtext_type + "', '0');";
                        cmd = new SqlCommand(query, con);

                        cmd.ExecuteNonQuery();
                        con.Close();
                        hello_window hello_Window = new hello_window();
                        hello_Window.Show();
                        this.Hide();
                    }
                    
                    
                }
                else
                {
                    MessageBox.Show("Username Is Exist ,Please Enter Another Username");
                }


                
            }
            else
            {
                MessageBox.Show("please Enter Password Correctly"); 
            }
               
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            pictureBox_upload.Image = Properties.Resources.username_logo;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Images Files|*.JpG;*.JPEG;*.PNG";
            openFileDialog.Multiselect = false;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox_upload.Image = Image.FromFile(openFileDialog.FileName);
                image_location = openFileDialog.FileName.ToString();
              
            }
        }

        private void Register_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
    
    
}
