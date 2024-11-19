using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TempratureConverter.cs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            double c,f;
            if(rbtnC2F.Checked == true )
            {
                c= Double.Parse(txtValue.Text);
                f = (c * 9 / 5) + 32;
                txtResult.Text=Convert.ToString(f);
            }
            if(rbtnF2C.Checked == true )
            {
                f = Double.Parse(txtValue.Text);
                c = (f - 32) * 5 / 9; 
                txtResult.Text = Convert.ToString(c);

            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtResult.Text = "";
            txtValue.Text = "";

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
