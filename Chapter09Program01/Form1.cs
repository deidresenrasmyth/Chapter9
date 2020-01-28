using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter09Program01
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void BtnCalc_Click(object sender, EventArgs e)
        {
            bool flag;
            int year;
            int leap;
            clsDates myDate = new clsDates();
            flag = int.TryParse(txtYear.Text, out year);
            if(flag == false)
            {
                MessageBox.Show("Digit charecters only in YYYY format.","Input Error");
                txtYear.Focus();
                return;
            }
            leap = myDate.getLeapYear(year);
            lblEasterResult.Text = year.ToString() + " is " + ((leap == 1) ? "" : "not ") + "a leap year";
            lblLeapYearResult.Text = myDate.getEaster(year);
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
