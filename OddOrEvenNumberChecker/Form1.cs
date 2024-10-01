using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OddOrEvenNumberChecker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            string userInput;
            int number;

            userInput = txtNumber.Text;
            number = int.Parse(userInput);

            if (number % 2 == 0)
            {
                lblOutput.Text = "Even";
            }
            else
            {
                lblOutput.Text = "Odd";
            }
        }
    }
}
