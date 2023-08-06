using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LoginWithMSSQL.Repositorys;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Security.AccessControl;

namespace LoginWithMSSQL
{
    public partial class SignUp : Form
    {
        Repository repository = new Repository();
        public SignUp()
        {
            InitializeComponent();
        }

        private void SignUp_Load(object sender, EventArgs e)
        {
            
        }

        #region Form Moving and Close

        bool mouseMove;
        int mouse_x, mouse_y;
        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SignUp_MouseDown(object sender, MouseEventArgs e)
        {
            mouseMove = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }

        private void SignUp_MouseUp(object sender, MouseEventArgs e)
        {
            mouseMove = false;
        }


        private void SignUp_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseMove)
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
        }
        #endregion

        #region Txt PlaceHolders

        /// <summary>
        /// For Enter method enterOrLeave == 1, for Leave == 0
        /// </summary>
        void TxtPlaceholder(TextBox txt, string placeHolder, byte enterOrLeave, bool isPassword = false)
        {
            switch (enterOrLeave)
            {
                case 1:
                if (txt.Text == placeHolder)
                {
                    txt.Text = "";
                    txt.ForeColor = Color.White;
                        if(isPassword)
                            txt.PasswordChar = '*';
                }
                    break;

                case 0:
                if (txt.Text == "")
                {
                    txt.Text = placeHolder;
                    txt.ForeColor = Color.Silver;
                        if (isPassword)
                            txt.PasswordChar = '\0';
                    }
                    break;
            }
        }

        private void txt_username_Enter(object sender, EventArgs e)
        {
            TxtPlaceholder(txt_username, "Username",1);
        }

        private void txt_username_Leave(object sender, EventArgs e)
        {
            TxtPlaceholder(txt_username, "Username",0);
                }

        private void txt_pass_Enter(object sender, EventArgs e)
        {
            TxtPlaceholder(txt_pass, "Password",1, true);
            }

        private void txt_pass_Leave(object sender, EventArgs e)
        {
            TxtPlaceholder(txt_pass, "Password", 0, true);
        }
      
        private void txt_rePass_Enter(object sender, EventArgs e)
        {
            TxtPlaceholder(txt_rePass,"Re-Password",1,true);
        }
        private void txt_rePass_Leave(object sender, EventArgs e)
        {
            TxtPlaceholder(txt_rePass, "Re-Password", 0, true);
        }

        private void txt_email_Enter(object sender, EventArgs e)
        {
            TxtPlaceholder(txt_email, "Email", 1);
        }


        private void txt_email_Leave(object sender, EventArgs e)
        {
            TxtPlaceholder(txt_email, "Email", 0);
        }

        #endregion



        int code;
        private void btn_verify_Click(object sender, EventArgs e)
        {
            this.code = new Random().Next(10000, 99999);

            string senderMail = "mail@outlook.com";
            string senderMailPassword = "password";
            string senderDisplayName = "name";

			MailAddress mailReceiver = new MailAddress(txt_email.Text, txt_username.Text);

            MailAddress mailSender = new MailAddress(senderMail, senderDisplayName);

            MailMessage msg = new MailMessage();

            msg.To.Add(mailReceiver);
            msg.From = mailSender;

            msg.Subject = "Verif Email";
            msg.Body = "Code: " + code;

            SmtpClient smtp = new SmtpClient("smtp-mail.outlook.com", 587);
            smtp.Credentials = new NetworkCredential(senderMail, senderMailPassword);
            smtp.EnableSsl = true;
            smtp.Send(msg);

            MessageBox.Show("Verification code sent", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txt_code.Visible = true;


        }

        public void SignUpButton(bool status)
        {
            btn_signUp.Enabled = status;
            
        }
		private void btn_signUp_Click(object sender, EventArgs e)
        {
            if (txt_code.Text ==this.code.ToString())
            {
                string phone = "";

                foreach (var item in mask_phone.Text.ToCharArray())
                {
                    if (char.IsNumber(item))
                    {
                        phone += item;
                    }
                }

                if (txt_pass.Text == txt_rePass.Text)
                {
                    byte status = repository.AddUser(txt_username.Text, txt_pass.Text, txt_email.Text, phone);

                    if (status == 1)
                    {
                        MessageBox.Show("Registration Successful.");
                        this.Hide();
                        Form1 form1 = new Form1();
                        form1.Show();
                    }
                    else if (status == 0)
                        MessageBox.Show("Registration Failed!");
                }
                else
                    MessageBox.Show("Passwords do NOT match!");
            }
            else
            {
                MessageBox.Show("Verify code is incorrect!");
            }

        }
    }
}
