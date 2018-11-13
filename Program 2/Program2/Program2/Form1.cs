/* Grading ID: A7872
 * Program 2
 * 10/16/2016
 * CIS 199-01
 * Shows a message that will tell the uesr when their registration date and time is. */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program2
{
    public partial class Form1 : Form
    {
        string day; //registration day
        string day1 = "Friday, November 4th ", day2 = "Monday, November 7th ", day3 = "Wednesday, November 9th ", day4 = "Thursday, November 10", day5 = "Friday, November 11th ", day6 = "Monday, November 14th "; //possible registration days
        string time; //registration time
        string time1 = "8:30", time2 = "10:00", time3 = "11:30", time4 = "2:00", time5 = "4:00"; //registration times
        public Form1()
        {
            InitializeComponent();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            string lastName = lastNameTxtBox.Text; //retrieves entered last name
            char letter = lastName[0]; //retrieves 1st letter of last name
            if (seniorRadioButton.Checked || juniorRadioButton.Checked)
            {
                if (seniorRadioButton.Checked)
                {
                    day = day1;
                }
                else
                {
                    day = day2;
                }
                    if ((letter == 'a') || (letter == 'b') || (letter == 'c') || (letter == 'd'))
                    {
                        time = time4;
                    }
                    else if ((letter == 'e') || (letter == 'f') || (letter == 'g') || (letter == 'h') || (letter == 'i'))
                    {
                        time = time5;
                    }
                    else if ((letter == 'j') || (letter == 'k') || (letter == 'l') || (letter == 'm') || (letter == 'n') || (letter == 'o'))
                    {
                        time = time1;
                    }
                    else if ((letter == 'p') || (letter == 'q') || (letter == 'r') || (letter == 's'))
                    {
                        time = time2;
                    }
                    else
                    {
                        time = time3;
                    }
            }
            if (sophRadioButton.Checked || freshmanRadioButton.Checked)
            {
                if (sophRadioButton.Checked)
                {
                    if (letter >= 'j' || letter <= 'v')
                    {
                        day = day3;
                    }
                    else
                    {
                        day = day4;
                    }
                }
                else
                {
                    if (letter >= 'j' || letter <= 'v')
                    {
                        day = day5;
                    }
                    else
                    {
                        day = day6;
                    }
                }
                if ((letter == 'j') || (letter == 'k') || (letter == 'l') || (letter == 'w') || (letter == 'x') || (letter == 'y') || (letter == 'z'))
                {
                    time = time1;
                }
                else if ((letter == 'a') || (letter == 'b') || (letter == 'm') || (letter == 'n') || (letter == 'o'))
                {
                    time = time2;
                }
                else if ((letter == 'c') || (letter == 'd') || (letter == 'p') || (letter == 'q'))
                {
                    time = time3;
                }
                else if ((letter == 'e') || (letter == 'f') || (letter == 'r') || (letter == 's'))
                {
                    time = time4;
                }
                else
                {
                    time = time5;
                }                
            }
            MessageBox.Show("Your registration day is: " + day + "at " + time + ".");
        }
    }
}
