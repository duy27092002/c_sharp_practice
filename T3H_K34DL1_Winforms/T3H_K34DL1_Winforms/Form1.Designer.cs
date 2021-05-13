
namespace T3H_K34DL1_Winforms
{
    partial class frmStudent
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn1 = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btn2 = new System.Windows.Forms.Button();
            this.lbShowName = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.SlateBlue;
            this.btn1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn1.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn1.Location = new System.Drawing.Point(43, 127);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(116, 40);
            this.btn1.TabIndex = 4;
            this.btn1.Text = "button1";
            this.btn1.UseVisualStyleBackColor = false;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtName.Location = new System.Drawing.Point(43, 60);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(218, 34);
            this.txtName.TabIndex = 1;
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.SlateBlue;
            this.btn2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn2.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn2.Location = new System.Drawing.Point(221, 127);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(130, 40);
            this.btn2.TabIndex = 3;
            this.btn2.Text = "button2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // lbShowName
            // 
            this.lbShowName.AutoSize = true;
            this.lbShowName.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbShowName.Location = new System.Drawing.Point(43, 205);
            this.lbShowName.Name = "lbShowName";
            this.lbShowName.Size = new System.Drawing.Size(0, 23);
            this.lbShowName.TabIndex = 6;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbName.Location = new System.Drawing.Point(43, 21);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(75, 28);
            this.lbName.TabIndex = 7;
            this.lbName.Text = "Name:";
            // 
            // frmStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 321);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.lbShowName);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btn1);
            this.Name = "frmStudent";
            this.Text = "Quan Ly Sinh Vien";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Label lbShowName;
        private System.Windows.Forms.Label lbName;
    }
}

