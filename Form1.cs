using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Basic_Controls
{
    public partial class frmMain : Form
    {
        string OperationFlag = "";
        public bool enter_value = false;
        public double result = 0;
        public double a = 0;
        public double result2 = 0;
        public int count = 0;
        public string operation = "";
        public frmMain()
        {
            InitializeComponent();
        }
        private void Num1_Click(object sender, EventArgs e)
        {
            BtnNumCode(Num1.Text);
        }
        private void Num2_Click(object sender, EventArgs e)
        {
            BtnNumCode(Num2.Text);
        }
        private void Num3_Click(object sender, EventArgs e)
        {
            BtnNumCode(Num3.Text);
        }
        private void Num4_Click(object sender, EventArgs e)
        {
            BtnNumCode(Num4.Text);
        }
        private void Num5_Click(object sender, EventArgs e)
        {
            BtnNumCode(Num5.Text);
        }

        private void Num6_Click(object sender, EventArgs e)
        {
            BtnNumCode(Num6.Text);
        }
        private void Num7_Click(object sender, EventArgs e)
        {
            BtnNumCode(Num7.Text);
        }
        private void Num8_Click(object sender, EventArgs e)
        {
            BtnNumCode(Num8.Text);
        }
        private void Num9_Click(object sender, EventArgs e)
        {
            BtnNumCode(Num9.Text);
        }
        private void Num0_Click(object sender, EventArgs e)
        {
            BtnNumCode(Num0.Text);
        }
        private void Dot_Click(object sender, EventArgs e)
        {
            if (Screen.Text.Length == 0)
            {
                lblHistory.Text = "0.";
            }
            BtnNumCode(Dot.Text);

        }
        private void Clear_Click(object sender, EventArgs e)
        {
            Screen.Text = "0";
            count = 0;
            lblHistory.Text = "";
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Screen.Text = (Screen.Text.Length > 0) ? Screen.Text.Substring(0, Screen.Text.Length - 1) : "0";
        }

        private void Screen_TextChanged(object sender, EventArgs e)
        {
            if (Screen.Text.Length > 12)
            {
                Screen.Text = Screen.Text.Substring(0, 12);
                MessageBox.Show("You have reached to maximum number length");
            }
        }
        private void Operator(string button_name)
        {

            operation = button_name;
            count = 0;
            if (Screen.Text.Length == 0)
            {
                lblHistory.Text = "0 " + button_name;
            }

            if (result != 0)
            {
                Equal.PerformClick();
                enter_value = true;
                OperationFlag = button_name;
                lblHistory.Text = result + " " + button_name;
            }
            else
            {
                OperationFlag = button_name;
                result = Double.Parse(Screen.Text);
                enter_value = true;
                lblHistory.Text = result + " " + button_name;
            }
        }

        private void Mult_Click(object sender, EventArgs e)
        {
            Operator(Mult.Text);
        }
        private void Add_Click(object sender, EventArgs e)
        {
            Operator(Add.Text);
        }
        private void Sub_Click(object sender, EventArgs e)
        {
            Operator(Sub.Text);
        }
        private void Div_Click(object sender, EventArgs e)
        {
            Operator(Div.Text);
        }
        private void Pow_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            operation = "^";
            count = 0;
            if (Screen.Text.Length == 0)
            {
                lblHistory.Text = "0^";
            }

            if (result != 0)
            {
                Equal.PerformClick();
                enter_value = true;
                OperationFlag = "P";
                lblHistory.Text = result + "^";
            }
            else
            {
                OperationFlag = "P";
                result = Double.Parse(Screen.Text);
                enter_value = true;
                lblHistory.Text = result + "^";
            }

        }
        private void Sqrt_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            operation = "√";
            count = 0;
            if (Screen.Text.Length == 0)
            {
                lblHistory.Text = "√0";
            }

            if (result != 0)
            {
                Equal.PerformClick();
                enter_value = true;
                OperationFlag = "R";
                lblHistory.Text = "√" + result;
            }
            else
            {
                OperationFlag = "R";
                result = Double.Parse(Screen.Text);
                enter_value = true;
                lblHistory.Text = "√" + result;
            }


        }

        private void Equal_Click(object sender, EventArgs e)
        {
            //lblHistory.Text = "";
            if (OperationFlag != "")
            {
                count = 0;
            }
            count++;
            if (count > 1 && operation == "*")
            {
                lblHistory.Text = a + "*" + result2;
                result2 = a * result2;
                Screen.Text = (result2).ToString();
                result = result2;
            }
            if (count > 1 && operation == "+")
            {
                lblHistory.Text = a + "+" + result2;
                result2 = a + result2;
                Screen.Text = (result2).ToString();
                result = result2;
            }
            if (count > 1 && operation == "-")
            {
                lblHistory.Text = result2 + "-" + a;
                result2 = result2 - a;
                Screen.Text = (result2).ToString();
                result = result2;
            }
            if (count > 1 && operation == "/")
            {
                lblHistory.Text = result + "/" + a;
                result2 = result2 / a;
                Screen.Text = (result2).ToString();
                result = result2;
            }
            if (count > 1 && operation == "^")
            {
                lblHistory.Text = result2 + "^" + a;
                result2 = System.Math.Pow(result2, a);
                Screen.Text = (result2).ToString();
                result = result2;
            }
            if (count > 1 && operation == "√")
            {
                lblHistory.Text = "√" + result2;
                result2 = System.Math.Sqrt(result2);
                Screen.Text = (result2).ToString();
                result = result2;
            }


            switch (OperationFlag)
            {
                case "*":
                    //lblHistory.Text += Screen.Text;
                    //Screen.Text = (result * Double.Parse(Screen.Text)).ToString();
                    if (count <= 1)
                    {
                        lblHistory.Text += Screen.Text;
                        a = Double.Parse(Screen.Text);
                        Screen.Text = (result * Double.Parse(Screen.Text)).ToString();
                        result2 = Double.Parse(Screen.Text);
                        result = result2;

                    }

                    break;

                case "+":
                    if (count <= 1)
                    {
                        lblHistory.Text += Screen.Text;
                        a = Double.Parse(Screen.Text);
                        Screen.Text = (result + Double.Parse(Screen.Text)).ToString();
                        result2 = Double.Parse(Screen.Text);
                        result = result2;
                    }
                    break;

                case "-":
                    if (count <= 1)
                    {
                        lblHistory.Text += Screen.Text;
                        a = Double.Parse(Screen.Text);
                        Screen.Text = (result - Double.Parse(Screen.Text)).ToString();
                        result2 = Double.Parse(Screen.Text);
                        result = result2;
                    }
                    break;

                case "/":
                    if (count <= 1)
                    {
                        lblHistory.Text += Screen.Text;
                        a = Double.Parse(Screen.Text);
                        if (a == 0)
                        {
                            Screen.Text = "Divide by 0";
                            MessageBox.Show("You cannot divide by zero...");
                            Clear.PerformClick();

                        }
                        else
                        {
                            Screen.Text = (result / Double.Parse(Screen.Text)).ToString();
                            result2 = Double.Parse(Screen.Text);
                            result = result2;
                        }
                    }
                    break;

                case "P":
                    if (count <= 1)
                    {
                        lblHistory.Text += Screen.Text;
                        a = Double.Parse(Screen.Text);
                        Screen.Text = System.Math.Pow(result, Double.Parse(Screen.Text)).ToString();
                        result2 = Double.Parse(Screen.Text);
                        result = result2;
                    }
                    break;

                case "R":
                    if (count <= 1)
                    {
                        lblHistory.Text = "√" + Screen.Text;
                        a = Double.Parse(Screen.Text);
                        Screen.Text = System.Math.Sqrt(result).ToString();
                        result2 = Double.Parse(Screen.Text);
                        result = result2;
                    }

                    break;

                default:
                    break;
            }
            result = Double.Parse(Screen.Text);
            OperationFlag = "";

        }

        private void BtnNumCode(string btnname)

        {

            if ((Screen.Text == "0") || (enter_value))
                Screen.Text = "";
            enter_value = false;

            if (btnname == ".")
            {
                if (Screen.Text.Length == 0)
                {
                    Screen.Text += "0.";
                }
                if (!Screen.Text.Contains("."))
                    Screen.Text += btnname;
            }
            else
            {
                Screen.Text += btnname;
            }
        }
    }
}

