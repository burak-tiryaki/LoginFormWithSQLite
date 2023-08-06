namespace LoginWithMSSQL
{
    partial class SignUp
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
			this.txt_username = new System.Windows.Forms.TextBox();
			this.txt_pass = new System.Windows.Forms.TextBox();
			this.txt_rePass = new System.Windows.Forms.TextBox();
			this.txt_email = new System.Windows.Forms.TextBox();
			this.btn_signUp = new System.Windows.Forms.Button();
			this.btn_close = new System.Windows.Forms.Button();
			this.mask_phone = new System.Windows.Forms.MaskedTextBox();
			this.btn_verify = new System.Windows.Forms.Button();
			this.txt_code = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// txt_username
			// 
			this.txt_username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
			this.txt_username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txt_username.ForeColor = System.Drawing.Color.Silver;
			this.txt_username.Location = new System.Drawing.Point(76, 134);
			this.txt_username.Name = "txt_username";
			this.txt_username.Size = new System.Drawing.Size(171, 24);
			this.txt_username.TabIndex = 0;
			this.txt_username.Text = "Username";
			this.txt_username.Enter += new System.EventHandler(this.txt_username_Enter);
			this.txt_username.Leave += new System.EventHandler(this.txt_username_Leave);
			// 
			// txt_pass
			// 
			this.txt_pass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
			this.txt_pass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txt_pass.ForeColor = System.Drawing.Color.Silver;
			this.txt_pass.Location = new System.Drawing.Point(76, 175);
			this.txt_pass.Name = "txt_pass";
			this.txt_pass.Size = new System.Drawing.Size(171, 24);
			this.txt_pass.TabIndex = 1;
			this.txt_pass.Text = "Password";
			this.txt_pass.Enter += new System.EventHandler(this.txt_pass_Enter);
			this.txt_pass.Leave += new System.EventHandler(this.txt_pass_Leave);
			// 
			// txt_rePass
			// 
			this.txt_rePass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
			this.txt_rePass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_rePass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txt_rePass.ForeColor = System.Drawing.Color.Silver;
			this.txt_rePass.Location = new System.Drawing.Point(76, 217);
			this.txt_rePass.Name = "txt_rePass";
			this.txt_rePass.Size = new System.Drawing.Size(171, 24);
			this.txt_rePass.TabIndex = 2;
			this.txt_rePass.Text = "Re-Password";
			this.txt_rePass.Enter += new System.EventHandler(this.txt_rePass_Enter);
			this.txt_rePass.Leave += new System.EventHandler(this.txt_rePass_Leave);
			// 
			// txt_email
			// 
			this.txt_email.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
			this.txt_email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txt_email.ForeColor = System.Drawing.Color.Silver;
			this.txt_email.Location = new System.Drawing.Point(76, 297);
			this.txt_email.Name = "txt_email";
			this.txt_email.Size = new System.Drawing.Size(171, 24);
			this.txt_email.TabIndex = 4;
			this.txt_email.Text = "Email";
			this.txt_email.Enter += new System.EventHandler(this.txt_email_Enter);
			this.txt_email.Leave += new System.EventHandler(this.txt_email_Leave);
			// 
			// btn_signUp
			// 
			this.btn_signUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(118)))), ((int)(((byte)(68)))));
			this.btn_signUp.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btn_signUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btn_signUp.ForeColor = System.Drawing.Color.White;
			this.btn_signUp.Location = new System.Drawing.Point(108, 371);
			this.btn_signUp.Name = "btn_signUp";
			this.btn_signUp.Size = new System.Drawing.Size(86, 27);
			this.btn_signUp.TabIndex = 7;
			this.btn_signUp.Text = "SIGN UP";
			this.btn_signUp.UseVisualStyleBackColor = false;
			this.btn_signUp.Click += new System.EventHandler(this.btn_signUp_Click);
			// 
			// btn_close
			// 
			this.btn_close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_close.BackgroundImage")));
			this.btn_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btn_close.ForeColor = System.Drawing.Color.Transparent;
			this.btn_close.Location = new System.Drawing.Point(282, 12);
			this.btn_close.Name = "btn_close";
			this.btn_close.Size = new System.Drawing.Size(27, 26);
			this.btn_close.TabIndex = 8;
			this.btn_close.UseVisualStyleBackColor = true;
			this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
			// 
			// mask_phone
			// 
			this.mask_phone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
			this.mask_phone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.mask_phone.ForeColor = System.Drawing.Color.Silver;
			this.mask_phone.Location = new System.Drawing.Point(76, 261);
			this.mask_phone.Mask = "(999) 000-0000";
			this.mask_phone.Name = "mask_phone";
			this.mask_phone.Size = new System.Drawing.Size(171, 20);
			this.mask_phone.TabIndex = 3;
			// 
			// btn_verify
			// 
			this.btn_verify.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(118)))), ((int)(((byte)(68)))));
			this.btn_verify.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btn_verify.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btn_verify.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btn_verify.ForeColor = System.Drawing.Color.White;
			this.btn_verify.Location = new System.Drawing.Point(253, 296);
			this.btn_verify.Name = "btn_verify";
			this.btn_verify.Size = new System.Drawing.Size(56, 24);
			this.btn_verify.TabIndex = 5;
			this.btn_verify.Text = "Verify";
			this.btn_verify.UseVisualStyleBackColor = false;
			this.btn_verify.Click += new System.EventHandler(this.btn_verify_Click);
			// 
			// txt_code
			// 
			this.txt_code.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
			this.txt_code.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_code.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txt_code.ForeColor = System.Drawing.Color.Silver;
			this.txt_code.Location = new System.Drawing.Point(76, 327);
			this.txt_code.Name = "txt_code";
			this.txt_code.Size = new System.Drawing.Size(171, 24);
			this.txt_code.TabIndex = 6;
			this.txt_code.Visible = false;
			// 
			// SignUp
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(321, 410);
			this.Controls.Add(this.mask_phone);
			this.Controls.Add(this.btn_close);
			this.Controls.Add(this.btn_verify);
			this.Controls.Add(this.btn_signUp);
			this.Controls.Add(this.txt_email);
			this.Controls.Add(this.txt_rePass);
			this.Controls.Add(this.txt_pass);
			this.Controls.Add(this.txt_code);
			this.Controls.Add(this.txt_username);
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "SignUp";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "SignUp";
			this.Load += new System.EventHandler(this.SignUp_Load);
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SignUp_MouseDown);
			this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SignUp_MouseMove);
			this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.SignUp_MouseUp);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.TextBox txt_rePass;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Button btn_signUp;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.MaskedTextBox mask_phone;
		private System.Windows.Forms.Button btn_verify;
		private System.Windows.Forms.TextBox txt_code;
	}
}