namespace LoginWithMSSQL
{
    partial class Form1
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
            this.btn_close = new System.Windows.Forms.Button();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.link_forgetPass = new System.Windows.Forms.LinkLabel();
            this.link_signUp = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // btn_close
            // 
            this.btn_close.BackgroundImage = global::LoginWithMSSQL.Properties.Resources.close_icon;
            this.btn_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_close.ForeColor = System.Drawing.Color.Transparent;
            this.btn_close.Location = new System.Drawing.Point(277, 12);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(32, 31);
            this.btn_close.TabIndex = 0;
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // txt_username
            // 
            this.txt_username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.txt_username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_username.ForeColor = System.Drawing.Color.Silver;
            this.txt_username.Location = new System.Drawing.Point(44, 189);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(183, 24);
            this.txt_username.TabIndex = 1;
            this.txt_username.Text = "Username";
            this.txt_username.Enter += new System.EventHandler(this.txt_username_Enter);
            this.txt_username.Leave += new System.EventHandler(this.txt_username_Leave);
            // 
            // txt_password
            // 
            this.txt_password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.txt_password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_password.ForeColor = System.Drawing.Color.Silver;
            this.txt_password.Location = new System.Drawing.Point(44, 244);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(183, 24);
            this.txt_password.TabIndex = 2;
            this.txt_password.Text = "Password";
            this.txt_password.Enter += new System.EventHandler(this.txt_password_Enter);
            this.txt_password.Leave += new System.EventHandler(this.txt_password_Leave);
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(118)))), ((int)(((byte)(68)))));
            this.btn_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_login.ForeColor = System.Drawing.Color.White;
            this.btn_login.Location = new System.Drawing.Point(211, 297);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(75, 27);
            this.btn_login.TabIndex = 3;
            this.btn_login.Text = "LOGIN";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // link_forgetPass
            // 
            this.link_forgetPass.ActiveLinkColor = System.Drawing.Color.Silver;
            this.link_forgetPass.AutoSize = true;
            this.link_forgetPass.BackColor = System.Drawing.Color.Transparent;
            this.link_forgetPass.LinkColor = System.Drawing.Color.Green;
            this.link_forgetPass.Location = new System.Drawing.Point(41, 305);
            this.link_forgetPass.Name = "link_forgetPass";
            this.link_forgetPass.Size = new System.Drawing.Size(101, 13);
            this.link_forgetPass.TabIndex = 4;
            this.link_forgetPass.TabStop = true;
            this.link_forgetPass.Text = "Forget my password";
            // 
            // link_signUp
            // 
            this.link_signUp.ActiveLinkColor = System.Drawing.Color.Silver;
            this.link_signUp.AutoSize = true;
            this.link_signUp.BackColor = System.Drawing.Color.Transparent;
            this.link_signUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.link_signUp.LinkColor = System.Drawing.Color.Green;
            this.link_signUp.Location = new System.Drawing.Point(41, 351);
            this.link_signUp.Name = "link_signUp";
            this.link_signUp.Size = new System.Drawing.Size(69, 18);
            this.link_signUp.TabIndex = 4;
            this.link_signUp.TabStop = true;
            this.link_signUp.Text = "SIGN UP";
            this.link_signUp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_signUp_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.BackgroundImage = global::LoginWithMSSQL.Properties.Resources.form;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(321, 403);
            this.Controls.Add(this.link_signUp);
            this.Controls.Add(this.link_forgetPass);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.btn_close);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.LinkLabel link_forgetPass;
        private System.Windows.Forms.LinkLabel link_signUp;
    }
}

