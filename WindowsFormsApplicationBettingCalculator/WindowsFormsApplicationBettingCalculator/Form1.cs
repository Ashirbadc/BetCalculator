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
        private object newReturn;
        public double temp = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        { 
           // Everytime i is smaller than 20 it will do loop through but once it reaches 20 it will stop.
           // After each interaction it increments by 2 when it meets i < 20.
           for (int i = 1; i < 20; i += 2)
            {
                if(Controls.Find("textBox" + i, true)[0].Text != "" && 
                    Controls.Find("textBox" + (i+1), true)[0].Text != "" && textStake.Text != "")
                {
                    temp += (i == 1) ? Convert.ToDouble(this.Controls.Find("textBox" + i, true)[0].Text)* 
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

        private void button2_Click(object sender, EventArgs e)
        {
            //Resetting the text boxes
            foreach (var c in this.Controls)
            {                
                if (c is TextBox)
                {
                    ((TextBox)c).Text = String.Empty;
                }
            }
        }



        private void textBox5_TextChanged(object sender, EventArgs e)
        {     
          
        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
