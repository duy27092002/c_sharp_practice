using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace day1
{
    public partial class FormTest : Form
    {
        public FormTest()
        {
            InitializeComponent();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            int getNumberA = Convert.ToInt32(txtNumberA.Text);
            int getNumberB = Convert.ToInt32(txtNumberB.Text);

            int result = (getNumberA + getNumberB);
            lbResult.Text = result.ToString();
        }
    }
}
