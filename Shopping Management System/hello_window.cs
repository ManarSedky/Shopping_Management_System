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

namespace Shopping_Management_System
{
   
    public partial class hello_window : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=MANOR\MANARSQL;Initial Catalog=""Shopping System"";Integrated Security=True");
        public hello_window()
        {
            InitializeComponent();
        }

        private void textBox_username_Click(object sender, EventArgs e)
        {
            if (textBox_pass.TextLength == 0)
            {
                textBox_pass.Text = "Password";
                textBox_pass.PasswordChar = '\0';
            }
            if (textBox_username.Text == "Username")
            {
                textBox_username.Clear();
            }
            
            pic_user.Image = Properties.Resources.username_logo2;
            panel1.BackColor = Color.FromArgb(255, 255, 255);
            textBox_username.ForeColor = Color.FromArgb(255, 255, 255);

            pic_pas.Image = Properties.Resources.pass_icon;
            panel2.BackColor = Color.FromArgb(245, 173, 91);
            textBox_pass.ForeColor = Color.FromArgb(245, 173, 91);

        }

        private void textBox_pass_Click(object sender, EventArgs e)
        {
            if (textBox_username.TextLength == 0)
            {
                textBox_username.Text = "Username";
            }
            if (textBox_pass.Text == "Password")
            {
                 textBox_pass.Clear();
                textBox_pass.PasswordChar = '*';
            }

           
            
            pic_pas.Image = Properties.Resources.pass_icon2;
            panel2.BackColor = Color.FromArgb(255, 255, 255);
            textBox_pass.ForeColor = Color.FromArgb(255, 255, 255);

            pic_user.Image = Properties.Resources.username_logo;
            panel1.BackColor = Color.FromArgb(245, 173, 91);
            textBox_username.ForeColor = Color.FromArgb(245, 173, 91);
        }
       
        private void button_sign_in_Click(object sender, EventArgs e)
        {
            con.Open();

            string query = "select count(*) from User_Info where Name='" + textBox_username.Text + "'and Password ='" + textBox_pass.Text + "'";
            SqlCommand com = new SqlCommand(query, con);
            int result = Convert.ToInt32(com.ExecuteScalar());

            if (result == 1) 
            {
                var.current_username = textBox_username.Text;
                var.current_pass = Convert.ToInt32(textBox_pass.Text);
              
                Cart cart = new Cart();
                cart.Show();
                this.Hide(); 
                MessageBox.Show("Welcome ^^ "+ var.current_username +" At Our Online Shopping ^^");
          }
            else
            {
                MessageBox.Show("please check your email and password");

                textBox_username.Text = "Username";
                textBox_pass.Text = "Password";
                textBox_pass.PasswordChar = '\0';

                pic_pas.Image = Properties.Resources.pass_icon;
                panel2.BackColor = Color.FromArgb(245, 173, 91);
                textBox_pass.ForeColor = Color.FromArgb(245, 173, 91);

                pic_user.Image = Properties.Resources.username_logo;
                panel1.BackColor = Color.FromArgb(245, 173, 91);
                textBox_username.ForeColor = Color.FromArgb(245, 173, 91);
            }

            con.Close();
     
     
        }

        private void button_register_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
            this.Hide();
        }

        private void hello_window_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
