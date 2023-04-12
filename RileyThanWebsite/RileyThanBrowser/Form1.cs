using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RileyThanBrowser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GoButton_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(textBox1.Text);
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void ForwardButton_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            webBrowser1.GoHome();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            try //basic exception handling.
            {
                if((!String.IsNullOrWhiteSpace(textBox2.Text)) && (!String.IsNullOrWhiteSpace(textBox3.Text)))
                { //This is just to check if the text box is empty. 
                    double number1 = Convert.ToDouble(textBox2.Text); //These are doubles to handle decimals.
                    double number2 = Convert.ToDouble(textBox3.Text); //convert the text to doubles.
                    double result = number1 + number2; //add the numbers
                    resultDisplay.Text = result.ToString();
                }
                else
                {
                    resultDisplay.Text = "Entries cannot be blank"; //error message for blank text
                }
            }
            catch(Exception ex)
            {
                resultDisplay.Text = ex.Message.ToString(); //exception handling
            }
        }

        private void MinusButton_Click(object sender, EventArgs e)
        {
            try
            {
                if ((!String.IsNullOrWhiteSpace(textBox2.Text)) && (!String.IsNullOrWhiteSpace(textBox3.Text)))
                {
                    double number1 = Convert.ToDouble(textBox2.Text); //converts strings to numbers.
                    double number2 = Convert.ToDouble(textBox3.Text);
                    double result = number1 - number2; //Subtract the numbers
                    resultDisplay.Text = result.ToString(); //display results
                }
                else
                {
                    resultDisplay.Text = "Entries cannot be blank"; //error message for blank text.
                }
            }
            catch (Exception ex)
            {
                resultDisplay.Text = ex.Message.ToString();
            }
        }

        private void TimesButton_Click(object sender, EventArgs e)
        {
            try
            {
                if ((!String.IsNullOrWhiteSpace(textBox2.Text)) && (!String.IsNullOrWhiteSpace(textBox3.Text)))
                {
                    double number1 = Convert.ToDouble(textBox2.Text); //...you get the point.
                    double number2 = Convert.ToDouble(textBox3.Text);
                    double result = number1 * number2;
                    resultDisplay.Text = result.ToString();
                }
                else
                {
                    resultDisplay.Text = "Entries cannot be blank";
                }
            }
            catch (Exception ex)
            {
                resultDisplay.Text = ex.Message.ToString();
            }

        }

        private void DivideButton_Click(object sender, EventArgs e)
        {
            try
            {
                if ((!String.IsNullOrWhiteSpace(textBox2.Text)) && (!String.IsNullOrWhiteSpace(textBox3.Text))) 
                {   //where doubles REALLY shine. I couldn't get a good way to do floats so doubles are the next best thing.
                    //even if they took up more memory...sigh.
                    double number1 = Convert.ToDouble(textBox2.Text);
                    double number2 = Convert.ToDouble(textBox3.Text); //...ditto.
                    double result = (number1 / number2);
                    resultDisplay.Text = result.ToString();
                }
                else
                {
                    resultDisplay.Text = "Entries cannot be blank";
                }
            }
            catch (Exception ex)
            {
                resultDisplay.Text = ex.Message.ToString();
            }
        }

        private void EncryptButton_Click(object sender, EventArgs e)
        {
            EncryptReference.ServiceClient encryptClient = new EncryptReference.ServiceClient(); //Set things up for namesake stuff
            try
            {
                if(!String.IsNullOrWhiteSpace(textBox4.Text))
                {
                    EncryptDisplay.Text = encryptClient.Encrypt(textBox4.Text); //calls the function and puts the label on output.
                }
                else
                {
                    EncryptDisplay.Text = "Entry cannot be blank";
                }
            }
            catch (Exception ex) //basic exception handler.
            {
                EncryptDisplay.Text = ex.Message.ToString();
            }
        }
    }
}
