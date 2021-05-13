using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T3H_K34DL1_Winforms
{
    public partial class frmStudent : System.Windows.Forms.Form
    {
        public frmStudent()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            string getName = txtName.Text;

            lbShowName.Text = "Welcome, " + getName + " !";
        }
    }
}
