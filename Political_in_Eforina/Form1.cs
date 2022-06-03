using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Political_in_Eforina
{
    public partial class FAvtorizac : Form
    {
        public FAvtorizac()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            if (rbSoc.Checked)
            {
                f2.NameYourPart.Text = rbSoc.Text;
                f2.NameYourPart.ForeColor = rbSoc.ForeColor;
                f2.tag = 1;
            }
            else
            {
                if (rbLib.Checked)
                {
                    f2.NameYourPart.Text = rbLib.Text;
                    f2.NameYourPart.ForeColor = rbLib.ForeColor;
                    f2.tag = 2;
                }
                else
                {
                    if (rbMon.Checked)
                    {
                        f2.NameYourPart.Text = rbMon.Text;
                        f2.NameYourPart.ForeColor = rbMon.ForeColor;
                        f2.tag = 3;
                    }
                    else
                    {
                        if (rbFas.Checked)
                        {
                            f2.NameYourPart.Text = rbFas.Text;
                            f2.NameYourPart.ForeColor = rbFas.ForeColor;
                            f2.tag = 4;
                        }
                    }
                }
            }
            f2.Show();
            this.Visible = false;
        }
    }
}
