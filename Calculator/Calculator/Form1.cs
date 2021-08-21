using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form{
        public Form1()        {
            InitializeComponent();
        }

        string userInput = string.Empty, operation = string.Empty;
        double result = 0.0, num2 = 0.0;

        private void btn0_Click(object sender, EventArgs e)        {
            if (!userInput.Equals("0")) {
                userInput += "0";
                textBoxInput.Text += "0";
            }
        }

        private void btn1_Click(object sender, EventArgs e)        {
            if (!userInput.Equals("0")) {
                userInput += "1";
                textBoxInput.Text += "1";
            } else {
                userInput = "1";
                textBoxInput.Text = "1";
            }
        }

        private void btn2_Click(object sender, EventArgs e)        {
            if (!userInput.Equals("0")) {
                userInput += "2";
                textBoxInput.Text += "2";
            } else {
                userInput = "2";
                textBoxInput.Text = "2";
            }
        }

        private void btn3_Click(object sender, EventArgs e)        {
            if (!userInput.Equals("0")) {
                userInput += "3";
                textBoxInput.Text += "3";
            } else {
                userInput = "3";
                textBoxInput.Text = "3";
            }
        }

        private void btn4_Click(object sender, EventArgs e)        {
            if (!userInput.Equals("0")) {
                userInput += "4";
                textBoxInput.Text += "4";
            } else {
                userInput = "4";
                textBoxInput.Text = "4";
            }
        }

        private void btn5_Click(object sender, EventArgs e)        {
            if (!userInput.Equals("0")) {
                userInput += "5";
                textBoxInput.Text += "5";
            } else {
                userInput = "5";
                textBoxInput.Text = "5";
            }
        }

        private void btn6_Click(object sender, EventArgs e)        {
            if (!userInput.Equals("0")) {
                userInput += "6";
                textBoxInput.Text += "6";
            } else {
                userInput = "6";
                textBoxInput.Text = "6";
            }
        }

        private void btn7_Click(object sender, EventArgs e)        {
            if (!userInput.Equals("0")) {
                userInput += "7";
                textBoxInput.Text += "7";
            } else {
                userInput = "7";
                textBoxInput.Text = "7";
            }
        }

        private void btn8_Click(object sender, EventArgs e)        {
            if (!userInput.Equals("0")) {
                userInput += "8";
                textBoxInput.Text += "8";
            } else {
                userInput = "8";
                textBoxInput.Text = "8";
            }
        }

        private void btn9_Click(object sender, EventArgs e)        {
            if (!userInput.Equals("0")) {
                userInput += "9";
                textBoxInput.Text += "9";
            } else {
                userInput = "9";
                textBoxInput.Text = "9";
            }
        }

        private void btnPlus_Click(object sender, EventArgs e)        {

            try {

                if(!textBoxInput.Text.Equals("")){
                    userInput = textBoxInput.Text;

                    result += double.Parse(userInput);

                    operation = "sum";
                    cleanData(); //set userInput = 0 and clear the textBoxInput
                } else {
                    throw new Exception("There is no number to calculate!");
                }

            } catch (Exception errorMessage) {

                MessageBox.Show(errorMessage.Message);
            }
        }

        private void btnMinus_Click(object sender, EventArgs e)        {
            try {

                if(!textBoxInput.Text.Equals("")){
                    userInput = textBoxInput.Text;
                    result -= double.Parse(userInput);
                    operation = "minus";
                    cleanData(); //set userInput = 0 and clear the textBoxInput
                } else {
                    throw new Exception("There is no number to calculate!");
                }

            } catch (Exception errorMessage) {

                MessageBox.Show(errorMessage.Message);
            }
        }

        private void btnMultiply_Click(object sender, EventArgs e)        {
            try { 

                if(!textBoxInput.Text.Equals("")){
                    userInput = textBoxInput.Text;
                    result = double.Parse(userInput);
                    operation = "multiply";
                    cleanData(); //set userInput = 0 and clear the textBoxInput
                } else {
                    throw new Exception("There is no number to calculate!");
                }

            } catch (Exception errorMessage) {
                MessageBox.Show(errorMessage.Message);
            }
        }

        private void btnDivide_Click(object sender, EventArgs e)        {
            try {

                if (!textBoxInput.Text.Equals("")) {
                    userInput = textBoxInput.Text;
                    if (double.Parse(userInput) != 0) {
                        result = double.Parse(userInput);
                        operation = "divide";
                        cleanData(); //set userInput = 0 and clear the textBoxInput
                    } else {
                        textBoxInput.Clear();
                        throw new Exception("Cannot divide 0!");
                    }
                    
                } else {
                    throw new Exception("There is no number to calculate!");
                }

            } catch (Exception errorMessage) {
                MessageBox.Show(errorMessage.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)        {
            try {

                if (!textBoxInput.Text.Equals("")) {
                    userInput = textBoxInput.Text;
                    if (double.Parse(userInput) > -1) {
                        result = double.Parse(userInput);
                        result = Math.Sqrt(result);
                        textBoxInput.Text = result.ToString();
                    } else {
                        throw new Exception("There is no square root from a negative number!");
                    }

                } else {
                    throw new Exception("There is no number to calculate!");
                }

            } catch (Exception errorMessage) {

                MessageBox.Show(errorMessage.Message);
            }
        }

        private void btnFraction_Click(object sender, EventArgs e)        {
            try {

                if (!textBoxInput.Text.Equals("")) {
                    userInput = textBoxInput.Text;
                    if (double.Parse(userInput) != 0) {
                        result = double.Parse(userInput);
                        result = 1 / result;
                        textBoxInput.Text = result.ToString();
                        
                    } else {
                        textBoxInput.Clear();
                        throw new Exception("Cannot divide 0!");
                    }
                    
                } else {
                    throw new Exception("There is no number to calculate!");
                }

            } catch (Exception errorMessage) {

                MessageBox.Show(errorMessage.Message);
            }
        }

        
        private void btnNegative_Click(object sender, EventArgs e)        {

            try {

                if (!textBoxInput.Text.Equals("")) {
                    if (!textBoxInput.Text.Equals("0")) {
                        textBoxInput.Text = "-" + textBoxInput.Text;
                        userInput = textBoxInput.Text;
                    }

                } else {
                    throw new Exception("There is no number to calculate!");
                }

            } catch (Exception errorMessage) {
                MessageBox.Show(errorMessage.Message);
            }
        }

        private void btnEqual_Click(object sender, EventArgs e)        {


            try {

                if (userInput.Equals("")) {
                    throw new Exception("There is no number to calculate!");
                } else {

                    num2 = double.Parse(userInput);

                    switch (operation) {
                        case "sum":
                            result += num2;
                            textBoxInput.Text = Convert.ToDecimal(result).ToString();
                            break;

                        case "minus":
                            result -= num2;
                            textBoxInput.Text = Convert.ToDecimal(result).ToString();
                            break;

                        case "multiply":
                            result *= num2;
                            textBoxInput.Text = Convert.ToDecimal(result).ToString();
                            break;

                        case "divide":
                            if (num2 == 0) {
                                textBoxInput.Clear();
                                throw new Exception("Cannot divide by 0!");
                            } else {
                                result /= num2;
                                textBoxInput.Text = Convert.ToDecimal(result).ToString();
                            }
                            break;
                        default:
                            break;
                    }
                }
            } catch (Exception errorMessage) {
                MessageBox.Show(errorMessage.Message);
            }

            
        }

        private void btnPoint_Click(object sender, EventArgs e)        {

            try {
                if (!userInput.Equals("")) {
                    int textLenght = textBoxInput.Text.Length;
                    bool exist = false;
                    string text = textBoxInput.Text;

                    for (int i = 0; i < textLenght; i++) {
                        if (text[i].ToString() == ".") {
                            exist = true;
                            break;
                        } else {
                            exist = false;
                        }
                    }

                    if (!exist) {
                        userInput += ".";
                        textBoxInput.Text = userInput;
                    }

                } else {
                    throw new Exception("There is no number to calculate!");
                }
                
            } catch (Exception errorMessage) {
                MessageBox.Show(errorMessage.Message);
            }
            
        }


        private void btnBack_Click(object sender, EventArgs e)      {
            try { 

                if (!userInput.Equals("")) {
                    userInput = userInput.Remove(userInput.Length - 1, 1);
                    textBoxInput.Text = userInput;
                } else {
                    throw new Exception("This is not a valid number!");
                }

            } catch (Exception errorMessage) {
                MessageBox.Show(errorMessage.Message);
            }
            
            
        }


        private void btnClear_Click(object sender, EventArgs e){

            userInput = string.Empty;
            operation = string.Empty;
            num2 = 0.0;
            result = 0.0;
            textBoxInput.Clear();
        }

        private void cleanData() {
            userInput = "0";
            textBoxInput.Clear();
        }
    }
}
