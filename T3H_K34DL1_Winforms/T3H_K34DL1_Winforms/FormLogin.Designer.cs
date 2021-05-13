
namespace T3H_K34DL1_Winforms
{
    partial class loginForm
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
            this.lbTitleForm = new System.Windows.Forms.Label();
            this.lbUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lbPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lbFlagUsername = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lbForgotPass = new System.Windows.Forms.Label();
            this.lbSuggestSigup = new System.Windows.Forms.Label();
            this.cbRemember = new System.Windows.Forms.CheckBox();
            this.lbMess = new System.Windows.Forms.Label();
            this.lbFlagPass = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbTitleForm
            // 
            this.lbTitleForm.AutoSize = true;
            this.lbTitleForm.Font = new System.Drawing.Font("Segoe UI Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbTitleForm.Location = new System.Drawing.Point(318, 9);
            this.lbTitleForm.Name = "lbTitleForm";
            this.lbTitleForm.Size = new System.Drawing.Size(133, 54);
            this.lbTitleForm.TabIndex = 0;
            this.lbTitleForm.Text = "Login";
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbUsername.Location = new System.Drawing.Point(185, 76);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(118, 31);
            this.lbUsername.TabIndex = 1;
            this.lbUsername.Text = "Username";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(185, 124);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(394, 27);
            this.txtUsername.TabIndex = 2;
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbPassword.Location = new System.Drawing.Point(185, 173);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(112, 31);
            this.lbPassword.TabIndex = 3;
            this.lbPassword.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(185, 218);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(394, 27);
            this.txtPassword.TabIndex = 4;
            // 
            // lbFlagUsername
            // 
            this.lbFlagUsername.AutoSize = true;
            this.lbFlagUsername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbFlagUsername.ForeColor = System.Drawing.Color.Red;
            this.lbFlagUsername.Location = new System.Drawing.Point(304, 76);
            this.lbFlagUsername.Name = "lbFlagUsername";
            this.lbFlagUsername.Size = new System.Drawing.Size(35, 28);
            this.lbFlagUsername.TabIndex = 5;
            this.lbFlagUsername.Text = "(*)";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(285, 310);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(181, 51);
            this.btnLogin.TabIndex = 7;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lbForgotPass
            // 
            this.lbForgotPass.AutoSize = true;
            this.lbForgotPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbForgotPass.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbForgotPass.ForeColor = System.Drawing.Color.Red;
            this.lbForgotPass.Location = new System.Drawing.Point(421, 267);
            this.lbForgotPass.Name = "lbForgotPass";
            this.lbForgotPass.Size = new System.Drawing.Size(158, 20);
            this.lbForgotPass.TabIndex = 8;
            this.lbForgotPass.Text = "Forgot Your Password?";
            // 
            // lbSuggestSigup
            // 
            this.lbSuggestSigup.AutoSize = true;
            this.lbSuggestSigup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbSuggestSigup.Location = new System.Drawing.Point(304, 373);
            this.lbSuggestSigup.Name = "lbSuggestSigup";
            this.lbSuggestSigup.Size = new System.Drawing.Size(138, 20);
            this.lbSuggestSigup.TabIndex = 9;
            this.lbSuggestSigup.Text = "Click Here To Sigup";
            this.lbSuggestSigup.Click += new System.EventHandler(this.lbSuggestSigup_Click);
            // 
            // cbRemember
            // 
            this.cbRemember.AutoSize = true;
            this.cbRemember.Location = new System.Drawing.Point(185, 267);
            this.cbRemember.Name = "cbRemember";
            this.cbRemember.Size = new System.Drawing.Size(129, 24);
            this.cbRemember.TabIndex = 10;
            this.cbRemember.Text = "Remember me";
            this.cbRemember.UseVisualStyleBackColor = true;
            // 
            // lbMess
            // 
            this.lbMess.AutoSize = true;
            this.lbMess.Font = new System.Drawing.Font("Segoe UI", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbMess.Location = new System.Drawing.Point(358, 445);
            this.lbMess.Name = "lbMess";
            this.lbMess.Size = new System.Drawing.Size(0, 31);
            this.lbMess.TabIndex = 11;
            // 
            // lbFlagPass
            // 
            this.lbFlagPass.AutoSize = true;
            this.lbFlagPass.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbFlagPass.ForeColor = System.Drawing.Color.Red;
            this.lbFlagPass.Location = new System.Drawing.Point(303, 173);
            this.lbFlagPass.Name = "lbFlagPass";
            this.lbFlagPass.Size = new System.Drawing.Size(35, 28);
            this.lbFlagPass.TabIndex = 12;
            this.lbFlagPass.Text = "(*)";
            // 
            // loginForm
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(775, 492);
            this.Controls.Add(this.lbFlagPass);
            this.Controls.Add(this.lbMess);
            this.Controls.Add(this.cbRemember);
            this.Controls.Add(this.lbSuggestSigup);
            this.Controls.Add(this.lbForgotPass);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lbFlagUsername);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lbUsername);
            this.Controls.Add(this.lbTitleForm);
            this.Name = "loginForm";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitleForm;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lbFlagUsername;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lbForgotPass;
        private System.Windows.Forms.Label lbSuggestSigup;
        private System.Windows.Forms.CheckBox cbRemember;
        private System.Windows.Forms.Label lbMess;
        private System.Windows.Forms.Label lbFlagPass;
    }
}