
namespace day1
{
    partial class FormTest
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
            this.txtNumberA = new System.Windows.Forms.TextBox();
            this.lbA = new System.Windows.Forms.Label();
            this.lbB = new System.Windows.Forms.Label();
            this.txtNumberB = new System.Windows.Forms.TextBox();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnMul = new System.Windows.Forms.Button();
            this.btnDev = new System.Windows.Forms.Button();
            this.lbTitile = new System.Windows.Forms.Label();
            this.lbResultTitle = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.Label();
            this.lbResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNumberA
            // 
            this.txtNumberA.Location = new System.Drawing.Point(78, 61);
            this.txtNumberA.Name = "txtNumberA";
            this.txtNumberA.Size = new System.Drawing.Size(100, 22);
            this.txtNumberA.TabIndex = 0;
            // 
            // lbA
            // 
            this.lbA.AutoSize = true;
            this.lbA.Location = new System.Drawing.Point(26, 65);
            this.lbA.Name = "lbA";
            this.lbA.Size = new System.Drawing.Size(21, 17);
            this.lbA.TabIndex = 1;
            this.lbA.Text = "A:";
            // 
            // lbB
            // 
            this.lbB.AutoSize = true;
            this.lbB.Location = new System.Drawing.Point(29, 108);
            this.lbB.Name = "lbB";
            this.lbB.Size = new System.Drawing.Size(21, 17);
            this.lbB.TabIndex = 2;
            this.lbB.Text = "B:";
            // 
            // txtNumberB
            // 
            this.txtNumberB.Location = new System.Drawing.Point(78, 102);
            this.txtNumberB.Name = "txtNumberB";
            this.txtNumberB.Size = new System.Drawing.Size(100, 22);
            this.txtNumberB.TabIndex = 3;
            // 
            // btnPlus
            // 
            this.btnPlus.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlus.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnPlus.Location = new System.Drawing.Point(78, 210);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(47, 37);
            this.btnPlus.TabIndex = 4;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = false;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.BackColor = System.Drawing.Color.MediumOrchid;
            this.btnMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinus.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnMinus.Location = new System.Drawing.Point(145, 210);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(49, 37);
            this.btnMinus.TabIndex = 5;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = false;
            // 
            // btnMul
            // 
            this.btnMul.BackColor = System.Drawing.Color.LawnGreen;
            this.btnMul.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMul.ForeColor = System.Drawing.Color.Red;
            this.btnMul.Location = new System.Drawing.Point(217, 210);
            this.btnMul.Name = "btnMul";
            this.btnMul.Size = new System.Drawing.Size(49, 37);
            this.btnMul.TabIndex = 6;
            this.btnMul.Text = "x";
            this.btnMul.UseVisualStyleBackColor = false;
            // 
            // btnDev
            // 
            this.btnDev.BackColor = System.Drawing.Color.Gold;
            this.btnDev.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDev.ForeColor = System.Drawing.Color.Maroon;
            this.btnDev.Location = new System.Drawing.Point(290, 210);
            this.btnDev.Name = "btnDev";
            this.btnDev.Size = new System.Drawing.Size(50, 36);
            this.btnDev.TabIndex = 7;
            this.btnDev.Text = "/";
            this.btnDev.UseVisualStyleBackColor = false;
            // 
            // lbTitile
            // 
            this.lbTitile.AutoSize = true;
            this.lbTitile.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitile.Location = new System.Drawing.Point(78, 13);
            this.lbTitile.Name = "lbTitile";
            this.lbTitile.Size = new System.Drawing.Size(151, 36);
            this.lbTitile.TabIndex = 8;
            this.lbTitile.Text = "Caculator";
            // 
            // lbResultTitle
            // 
            this.lbResultTitle.AutoSize = true;
            this.lbResultTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResultTitle.ForeColor = System.Drawing.Color.Red;
            this.lbResultTitle.Location = new System.Drawing.Point(77, 153);
            this.lbResultTitle.Name = "lbResultTitle";
            this.lbResultTitle.Size = new System.Drawing.Size(101, 29);
            this.lbResultTitle.TabIndex = 9;
            this.lbResultTitle.Text = "Result: ";
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Location = new System.Drawing.Point(184, 163);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(0, 17);
            this.result.TabIndex = 10;
            // 
            // lbResult
            // 
            this.lbResult.AutoSize = true;
            this.lbResult.Location = new System.Drawing.Point(217, 162);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(0, 17);
            this.lbResult.TabIndex = 11;
            // 
            // FormTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.result);
            this.Controls.Add(this.lbResultTitle);
            this.Controls.Add(this.lbTitile);
            this.Controls.Add(this.btnDev);
            this.Controls.Add(this.btnMul);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.txtNumberB);
            this.Controls.Add(this.lbB);
            this.Controls.Add(this.lbA);
            this.Controls.Add(this.txtNumberA);
            this.Name = "FormTest";
            this.Text = "FormTest";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumberA;
        private System.Windows.Forms.Label lbA;
        private System.Windows.Forms.Label lbB;
        private System.Windows.Forms.TextBox txtNumberB;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnMul;
        private System.Windows.Forms.Button btnDev;
        private System.Windows.Forms.Label lbTitile;
        private System.Windows.Forms.Label lbResultTitle;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Label lbResult;
    }
}