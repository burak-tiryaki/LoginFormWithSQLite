using LoginWithMSSQL.Repositorys;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginWithMSSQL
{
    public partial class Form1 : Form
    {
        Repository repository = new Repository();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        #region Form Moving and Close
        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        bool mouseMove;
        int mouse_x, mouse_y;
        
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseMove = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseMove = false;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseMove)
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
        }
        #endregion

        #region TextBoxs PlaceHolder
        private void txt_username_Enter(object sender, EventArgs e)
        {
            if (txt_username.Text == "Username")
            {
                txt_username.Text = "";
                txt_username.ForeColor = Color.White;
            }
        }

       
        private void txt_username_Leave(object sender, EventArgs e)
        {
            if (txt_username.Text == "")
            {
                txt_username.Text = "Username";
                txt_username.ForeColor = Color.Silver;
            }
            
        }

        private void txt_password_Enter(object sender, EventArgs e)
        {
            if (txt_password.Text == "Password")
            {
                txt_password.Text = "";
                txt_password.ForeColor = Color.White;
                txt_password.PasswordChar = '*';
            }
        }

        private void txt_password_Leave(object sender, EventArgs e)
        {
            if (txt_password.Text == "")
            {
                txt_password.Text = "Password";
                txt_password.ForeColor = Color.Silver;
                txt_password.PasswordChar = '\0';
            }
        }

        #endregion
        private void link_signUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUp signUp = new SignUp();

            this.Hide();

            signUp.Show();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string username = txt_username.Text;
            string pass = txt_password.Text;

            bool status = repository.GetUser(username,pass);

            if (status)
                MessageBox.Show("Başarılı Giriş.");
            else
                MessageBox.Show("Başarısız Giriş!");
        }


    }
}
