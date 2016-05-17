using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplicationBettingCalculator
{
    public partial class Form1 : Form
    {
        //private object newReturn;
        public double temp = 0;
        

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            // Everytime i is smaller than 20 it loops through but once it reaches 20 it will stop.
            // After each interaction it increments by 2 until it meets i < 20.
            for (int i = 1; i < 20; i += 2)
            {
                if (Controls.Find("textBox" + i, true)[0].Text != "" &&
                    Controls.Find("textBox" + (i + 1), true)[0].Text != "" && textStake.Text != "")
                {
                    temp += (i == 1) ? Convert.ToDouble(this.Controls.Find("textBox" + i, true)[0].Text) *
                        Convert.ToDouble(textStake.Text) / Convert.ToDouble(this.Controls.Find("textBox" +
                        (i + 1), true)[0].Text) + Convert.ToDouble(textStake.Text) :
                        Convert.ToDouble(this.Controls.Find("textBox" + i, true)
                        [0].Text) * temp / Convert.ToDouble(this.Controls.Find("textBox" + (i + 1), true)[0].Text);
                }
            }

            //double one = double.Parse(textBox1.Text);
            //double two = double.Parse(textBox2.Text);

            //double myStake = double.Parse(textStake.Text);

            //double divide = one / two;  
            //double returns = divide * myStake;
            //Returning the output of userinput
            //double newReturn = returns + double.Parse(textStake.Text);
            txtBoxReturn.Text = temp.ToString();
            temp = 0;
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            //Resetting the text boxes
            foreach (var c in this.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Text = String.Empty;
                    //reseting the textDecimal boxes to invisible once the reset button is activated
                    if(((TextBox)c).Name.Contains("txtDec")) { ((TextBox)c).Visible = false;  }
                }
                label28.Visible = false;
                rbButton1.Checked = false;
            }
        }
       
        private void rButton_CheckedChanged(object sender, EventArgs e)
        {
                   
            for (int i = 1; i < 20; i += 2)
            {
                //set visible as true
                label28.Visible = true;

                if (Controls.Find("textBox" + i, true)[0].Text != "" && Controls.Find("textBox" + (i + 1), true)[0].Text != "")
                {
                    Controls.Find("txtDec" + Math.Round(Convert.ToDouble(i / 2) + 1), true)[0].Text = Convert.ToString(Convert.ToDouble(this.Controls.Find("textBox" + i, true)[0].Text) / Convert.ToDouble(this.Controls.Find("textBox" + (i + 1), true)[0].Text));
                    Controls.Find("txtDec" + Math.Round(Convert.ToDouble(i / 2) + 1), true)[0].Visible = true;

                }

                //double total = 0;

                //double no1 = Convert.ToInt32(textBox1.Text);
                //double no2 = Convert.ToInt32(textBox2.Text);
                //if (rbButton1.Checked)
                //{
                //    total = no1 / no2;
                //}
                //else if (rbButton1.Checked)
                //{
                //    total = no1 * no2;
                //}
                //txtDec1.Text = total.ToString();

                //foreach (var control in this.Controls)
                //{
                //    var txtDec = control as TextBox;
                //    if (txtDec != null) txtDec.Visible = true;
                //}

                //method to set fraction into decimals & set text box to visible



            }

        }
    }
}           
    


