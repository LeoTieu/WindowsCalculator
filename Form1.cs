using System;
using System.Windows.Forms;

namespace WindowsCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string calcTotal, option;
        double num1 = 0;
        double num2;
       


        private void ButtonNum1_MouseClick(object sender, MouseEventArgs e)
        {
            textDisplay.Text = textDisplay.Text + ButtonNum1.Text;
        }

        private void ButtonNum2_Click(object sender, EventArgs e)
        {
            textDisplay.Text = textDisplay.Text + ButtonNum2.Text;
        }

        private void ButtonNum3_Click(object sender, EventArgs e)
        {
            textDisplay.Text = textDisplay.Text + ButtonNum3.Text;
        }

        private void ButtonNum4_Click(object sender, EventArgs e)
        {
            textDisplay.Text = textDisplay.Text + ButtonNum4.Text;
        }

        private void ButtonNum5_Click(object sender, EventArgs e)
        {
            textDisplay.Text = textDisplay.Text + ButtonNum5.Text;
        }

        private void ButtonNum6_Click(object sender, EventArgs e)
        {
            textDisplay.Text = textDisplay.Text + ButtonNum6.Text;
        }

        private void ButtonNum7_Click(object sender, EventArgs e)
        {
            textDisplay.Text = textDisplay.Text + ButtonNum7.Text;
        }

        private void ButtonNum8_Click(object sender, EventArgs e)
        {
            textDisplay.Text = textDisplay.Text + ButtonNum8.Text;
        }

        private void ButtonNum9_Click(object sender, EventArgs e)
        {
            textDisplay.Text = textDisplay.Text + ButtonNum9.Text;
        }

        private void ButtonSignEqual_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textDisplay.Text);
            switch (option)
            {
                case "x":
                    calcTotal = Convert.ToString(num1 * num2);
                    textDisplay.Text = calcTotal;
                    break;
                case "-":
                    calcTotal = Convert.ToString(num1 - num2);
                    textDisplay.Text = calcTotal;
                    break;
                case "+":
                    calcTotal = Convert.ToString(num1 + num2);
                    textDisplay.Text = calcTotal;
                    break;
                case "÷":
                    if (num1 == 0)
                    {
                        textDisplay.Text = "Error";
                        break;
                    }
                    calcTotal = Convert.ToString(num1 / num2);
                    textDisplay.Text = calcTotal;
                    break;
            }
        }

        private void opMethod(object sender, EventArgs e)
        {
            option = ((Button)sender).Text;
            num2 = Convert.ToDouble(textDisplay.Text);
            textDisplay.Text = "";
        }

        private void ButtonSignClear_Click(object sender, EventArgs e)
        {
            num1 = 0;
            num2 = 0;
            textDisplay.Text = "";
        }

        private void ButtonSignComma_Click(object sender, EventArgs e)
        {
            if (textDisplay.Text.Contains(","))
            {
            }
            else
            {
                textDisplay.Text = textDisplay.Text + ",";
            }
        }

        private void ButtonNum0_Click(object sender, EventArgs e)
        {
            textDisplay.Text = textDisplay.Text + ButtonNum0.Text;
        }


    }
}
