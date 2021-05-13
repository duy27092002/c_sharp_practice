
namespace T3H_K34DL1_Winforms
{
    partial class sigupForm
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
            this.lbSigupTitle = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.rdMaile = new System.Windows.Forms.RadioButton();
            this.rdFemale = new System.Windows.Forms.RadioButton();
            this.rdOther = new System.Windows.Forms.RadioButton();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbSigupTitle
            // 
            this.lbSigupTitle.AutoSize = true;
            this.lbSigupTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbSigupTitle.Location = new System.Drawing.Point(332, 9);
            this.lbSigupTitle.Name = "lbSigupTitle";
            this.lbSigupTitle.Size = new System.Drawing.Size(130, 54);
            this.lbSigupTitle.TabIndex = 0;
            this.lbSigupTitle.Text = "Sigup";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(81, 84);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.PlaceholderText = "Enter your first name...";
            this.txtFirstName.Size = new System.Drawing.Size(272, 27);
            this.txtFirstName.TabIndex = 1;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(427, 84);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.PlaceholderText = "Enter your last name...";
            this.txtLastName.Size = new System.Drawing.Size(282, 27);
            this.txtLastName.TabIndex = 2;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(81, 144);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PlaceholderText = "Email...(ex: abc@gmail.com)";
            this.txtEmail.Size = new System.Drawing.Size(628, 27);
            this.txtEmail.TabIndex = 3;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(81, 243);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.PlaceholderText = "Phone number...";
            this.txtPhoneNumber.Size = new System.Drawing.Size(628, 27);
            this.txtPhoneNumber.TabIndex = 4;
            // 
            // rdMaile
            // 
            this.rdMaile.AutoSize = true;
            this.rdMaile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdMaile.Location = new System.Drawing.Point(81, 197);
            this.rdMaile.Name = "rdMaile";
            this.rdMaile.Size = new System.Drawing.Size(63, 24);
            this.rdMaile.TabIndex = 5;
            this.rdMaile.TabStop = true;
            this.rdMaile.Text = "Male";
            this.rdMaile.UseVisualStyleBackColor = true;
            // 
            // rdFemale
            // 
            this.rdFemale.AutoSize = true;
            this.rdFemale.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdFemale.Location = new System.Drawing.Point(185, 197);
            this.rdFemale.Name = "rdFemale";
            this.rdFemale.Size = new System.Drawing.Size(78, 24);
            this.rdFemale.TabIndex = 6;
            this.rdFemale.TabStop = true;
            this.rdFemale.Text = "Female";
            this.rdFemale.UseVisualStyleBackColor = true;
            // 
            // rdOther
            // 
            this.rdOther.AutoSize = true;
            this.rdOther.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdOther.Location = new System.Drawing.Point(311, 197);
            this.rdOther.Name = "rdOther";
            this.rdOther.Size = new System.Drawing.Size(67, 24);
            this.rdOther.TabIndex = 7;
            this.rdOther.TabStop = true;
            this.rdOther.Text = "Other";
            this.rdOther.UseVisualStyleBackColor = true;
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(81, 301);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.PlaceholderText = "Country...";
            this.txtCountry.Size = new System.Drawing.Size(272, 27);
            this.txtCountry.TabIndex = 8;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(427, 301);
            this.txtCity.Name = "txtCity";
            this.txtCity.PlaceholderText = "City...";
            this.txtCity.Size = new System.Drawing.Size(282, 27);
            this.txtCity.TabIndex = 9;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(81, 355);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.PlaceholderText = "Address...";
            this.txtAddress.Size = new System.Drawing.Size(628, 27);
            this.txtAddress.TabIndex = 10;
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.ForestGreen;
            this.btnCreate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreate.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCreate.ForeColor = System.Drawing.Color.White;
            this.btnCreate.Location = new System.Drawing.Point(343, 401);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(94, 53);
            this.btnCreate.TabIndex = 11;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = false;
            // 
            // sigupForm
            // 
            this.AcceptButton = this.btnCreate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 466);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.rdOther);
            this.Controls.Add(this.rdFemale);
            this.Controls.Add(this.rdMaile);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lbSigupTitle);
            this.Name = "sigupForm";
            this.Text = "Sigup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbSigupTitle;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.RadioButton rdMaile;
        private System.Windows.Forms.RadioButton rdFemale;
        private System.Windows.Forms.RadioButton rdOther;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Button btnCreate;
    }
}