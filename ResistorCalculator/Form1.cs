using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResistorCalculator
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void label36_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (lblFirst.Text == "")
            {
                lblFirst.Text = "0";
                lblLine1.BackColor = Color.Black;
                lblSelector.Text = "Select Second Colour";
            }
            else
            {
                checkBox1.Text = "0";
                lblLine1.BackColor = Color.Black;
                lblSelector.Text = "Select Multiplier";
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (lblFirst.Text == "")
            {
                lblFirst.Text = "1";
                lblLine1.BackColor = Color.Brown;
                lblSelector.Text = "Select Second Colour";
            }
            else
            {
                checkBox2.Text = "1";
                lblLine1.BackColor = Color.Brown;
                lblSelector.Text = "Select Multiplier";
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (lblFirst.Text == "")
            {
                lblFirst.Text = "2";
                lblLine1.BackColor = Color.Red;
                lblSelector.Text = "Select Second Colour";
            }
            else
            {
                checkBox3.Text = "2";
                lblLine1.BackColor = Color.Red;
                lblSelector.Text = "Select Multiplier";
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (lblFirst.Text == "")
            {
                lblFirst.Text = "3";
                lblLine1.BackColor = Color.Orange;
                lblSelector.Text = "Select Second Colour";
            }
            else
            {
                checkBox4.Text = "3";
                lblLine1.BackColor = Color.Orange;
                lblSelector.Text = "Select Multiplier";
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (lblFirst.Text == "")
            {
                lblFirst.Text = "4";
                lblLine1.BackColor = Color.Yellow;
                lblSelector.Text = "Select Second Colour";
            }
            else
            {
                checkBox5.Text = "4";
                lblLine1.BackColor = Color.Yellow;
                lblSelector.Text = "Select Multiplier";
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (lblFirst.Text == "")
            {
                lblFirst.Text = "5";
                lblLine1.BackColor = Color.Green;
                lblSelector.Text = "Select Second Colour";
            }
            else
            {
                checkBox6.Text = "5";
                lblLine1.BackColor = Color.Green;
                lblSelector.Text = "Select Multiplier";
            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (lblFirst.Text == "")
            {
                lblFirst.Text = "6";
                lblLine1.BackColor = Color.Blue;
                lblSelector.Text = "Select Second Colour";
            }
            else
            {
                checkBox7.Text = "6";
                lblLine1.BackColor = Color.Blue;
                lblSelector.Text = "Select Multiplier";
            }
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (lblFirst.Text == "")
            {
                lblFirst.Text = "7";
                lblLine1.BackColor = Color.Violet;
                lblSelector.Text = "Select Second Colour";
            }
            else
            {
                checkBox8.Text = "7";
                lblLine1.BackColor = Color.Violet;
                lblSelector.Text = "Select Multiplier";
            }
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            if (lblFirst.Text == "")
            {
                lblFirst.Text = "8";
                lblLine1.BackColor = Color.Gray;
                lblSelector.Text = "Select Second Colour";
            }
            else
            {
                checkBox9.Text = "8";
                lblLine1.BackColor = Color.Gray;
                lblSelector.Text = "Select Multiplier";
            }
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            if (lblFirst.Text == "")
            {
                lblFirst.Text = "9";
                lblLine1.BackColor = Color.White;
                lblSelector.Text = "Select Second Colour";
            }
            else
            {
                checkBox10.Text = "9";
                lblLine1.BackColor = Color.White;
                lblSelector.Text = "Select Multiplier";
            }
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            lblThird.Text = "1";
            lblLine3.BackColor = Color.Black;
            lblSelector.Text = "Select Tolerance";
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            lblThird.Text = "10";
            lblLine3.BackColor = Color.Brown;
            lblSelector.Text = "Select Tolerance";
        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            lblThird.Text = "100";
            lblLine3.BackColor = Color.Red;
            lblSelector.Text = "Select Tolerance";
        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
            lblThird.Text = "1000";
            lblLine3.BackColor = Color.Orange;
            lblSelector.Text = "Select Tolerance";
        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
            lblThird.Text = "10000";
            lblLine3.BackColor = Color.Yellow;
            lblSelector.Text = "Select Tolerance";
        }

        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {
            lblThird.Text = "100000";
            lblLine3.BackColor = Color.Green;
            lblSelector.Text = "Select Tolerance";
        }

        private void checkBox17_CheckedChanged(object sender, EventArgs e)
        {
            lblThird.Text = "1000000";
            lblLine3.BackColor = Color.Blue;
            lblSelector.Text = "Select Tolerance";
        }

        private void checkBox18_CheckedChanged(object sender, EventArgs e)
        {
            lblThird.Text = "10000000";
            lblLine3.BackColor = Color.Violet;
            lblSelector.Text = "Select Tolerance";
        }

        private void checkBox19_CheckedChanged(object sender, EventArgs e)
        {
            lblThird.Text = "100000000";
            lblLine3.BackColor = Color.Gray;
            lblSelector.Text = "Select Tolerance";
        }

        private void checkBox20_CheckedChanged(object sender, EventArgs e)
        {
            lblThird.Text = "1000000000";
            lblLine3.BackColor = Color.White;
            lblSelector.Text = "Select Tolerance";
        }

        private void checkBox24_CheckedChanged(object sender, EventArgs e)
        {
            checkBox25.Checked = false;
            checkBox26.Checked = false;
            checkBox21.Enabled = true;
            lblLine4.BackColor = Color.Gold;
            lblSelector.Text = "Click on Calculate";

        }

        private void checkBox25_CheckedChanged(object sender, EventArgs e)
        {
            checkBox24.Checked = false;
            checkBox26.Checked = false;
            checkBox21.Enabled = true;
            lblLine4.BackColor = Color.Silver;
            lblSelector.Text = "Click on Calculate";
        }

        private void checkBox26_CheckedChanged(object sender, EventArgs e)
        {
            checkBox25.Checked = false;
            checkBox24.Checked = false;
            checkBox21.Enabled = true;
            lblLine4.BackColor = Color.White;
            lblSelector.Text = "Click on Calculate";
        }

        private void label26_Click(object sender, EventArgs e)
        {
            checkBox24.Checked = true;
            checkBox21.Enabled = true;
            lblLine4.BackColor = Color.Gold;
            lblSelector.Text = "Click on Calculate";
        }

        private void label27_Click(object sender, EventArgs e)
        {
            checkBox25.Checked = true;
            checkBox21.Enabled = true;
            lblLine4.BackColor = Color.Silver;
            lblSelector.Text = "Click on Calculate";
        }

        private void label28_Click(object sender, EventArgs e)
        {
            checkBox26.Checked = true;
            checkBox21.Enabled = true;
            lblLine4.BackColor = Color.White;
            lblSelector.Text = "Click on Calculate";
        }

        private void checkBox21_Click(object sender, EventArgs e)
        {
            double[] q = new double[7];
            String f = Convert.ToString(lblFirst.Text);
            String s = Convert.ToString(lblSecond.Text);
            double T = Convert.ToDouble(lblThird.Text);

            string fs = f + s;
            q[1] = Convert.ToDouble(fs);
            q[2] = q[1];

                if (checkBox24.Checked == true)
            {
                checkBox25.Checked = false;
                checkBox26.Checked = false;
                q[3] = (((q[2] * T) / 1000) * (0.05));
                lblDivideBy1000.Text = Convert.ToString((q[3]) + ("k ohm"));
                lblResistorValue.Text = Convert.ToString((q[2]) + ("K ohm 5%"));

                q[4] = (q[2]) - (q[3]);
                lblMinRange.Text = Convert.ToString((q[4]) + ("k ohm "));
                q[5] = (q[2]) + (q[3]);
                lblMaxRange.Text = Convert.ToString((q[5]) + ("k ohm"));
            }

        }



    }
}