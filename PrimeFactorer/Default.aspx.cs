using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PrimeFactorer
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void goButton_Click(object sender, EventArgs e)
        {
            resultLabel.Text = "Your number's prime factors are:";
            var input = 0;
            bool isPrime = true;
            List<int> primeFactors = new List<int>();
            if (int.TryParse(inputTextBox.Text, out input))
            {
                if (input >= 2)
                {
                    for (int i = 2; i <= input; i++)
                    {
                        if (input % i == 0)
                        {
                            isPrime = true;
                            for (int j = 2; j <= i/2; j++)
                            {
                                if ((i % j == 0))
                                {
                                    isPrime = false;
                                }
                            }
                            if (isPrime == true)
                            {
                                primeFactors.Add(i);
                            }
                        }
                    }
                    foreach (var primeFactor in primeFactors)
                    {
                        resultLabel.Text += " " + primeFactor.ToString() + ",";
                    }
                    resultLabel.Text = resultLabel.Text.TrimEnd(',');
                }
                else
                {
                    resultLabel.Text = "Please enter a positive integer greater than 1";
                }
            }
            else
            {
                resultLabel.Text = "Please enter a valid positive integer";
            }
        }
    }
}