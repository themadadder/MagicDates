using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Magic_Dates
{
    public partial class magicDates : Form
    {
        public magicDates()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            // Confirming user input
            dateFormatLabel.Text = dayTextBox.Text + "/" + monthTextBox.Text + "/" + yearTextBox.Text;
            
            // Declaring variables to use for logical check
            int dayDate = Convert.ToInt32(dayTextBox.Text);
            int monthDate = Convert.ToInt32(monthTextBox.Text);
            int yearDate = Convert.ToInt32(yearTextBox.Text);

            // Counting digits to make sure user input the year properly
            int digitCount = Regex.Matches(yearTextBox.Text, @"\d").Count;

            // Performing the check to see if day and month equal year input
            if (digitCount >= 4)
            {
                MessageBox.Show("Error, please input the year's last two digits");
            }
            else
            {
                if (dayDate * monthDate == yearDate)
                {
                    outputLabel.Text = "Date is magical!";
                }
                else
                {
                    outputLabel.Text = "Date is not magical";
                }
            }

        }

        private void yearLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
