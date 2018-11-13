/* A7872
 * CIS199-01
 * 11/20/2016
 * Program 3
 * This application allows users to input their credit hours and class standing to be told what day they register. It utilizes arrays and range matching. */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Prog2
{
    public partial class RegForm : Form
    {
        public RegForm()
        {
            InitializeComponent();
        }


        //Last Name passed through the 
        public string GetUnderClassman (string lastName)
        {
            //Declare parallel arrays
            char[] firstLetter = new char[] { 'A', 'C', 'E', 'G', 'J', 'M', 'P', 'R', 'T', 'W'};
            string[] time = new string[] { "10:00 AM", "11:30 AM", "2:00 PM", "4:00 PM", "8:30 AM", "10:00 AM", "11:30 AM", "2:00 PM", "4:00 PM", "8:30 AM" };
           

            //Declare local variables
            bool found = false;
            int index = firstLetter.Length - 1;
            string regTime = "0";
            char lastNameLetter;

            lastName = lastNameTxt.Text;
            lastNameLetter = lastName[0];
            lastNameLetter = char.ToUpper(lastNameLetter);


            while (index >= 0 && !found)
            {
                if (lastNameLetter >= lastName[index])
                {
                    found = true;
                }
                else
                {
                    --index;
                }
            }
            if (found)
            {
                regTime = time[index];
            }
            return regTime;
        }

        //Last name is converted from the input and passed through the method to provide the registration time
        public string GetUpperClassman(string lastName)
        {
            //Declare parallel arrays
            char[] firstLetter = new char[] { 'A', 'E', 'J', 'P', 'T' };
            string[] time = new string[] { "2:00 PM", "4:00 PM", "8:30 AM", "10:00 AM", "11:30 AM" };

            //Declare local variables
            bool found = false;
            int index = firstLetter.Length - 1;
            string regTime = "0";
            char lastNameLetter;
            
            lastName = lastNameTxt.Text;
            lastNameLetter = lastName[0];
            lastNameLetter = char.ToUpper(lastNameLetter);


            while (index >= 0 && !found)
            {
                if (lastNameLetter >= lastName[index])
                {
                    found = true;
                    
                }
                else
                {
                    --index;
                }
            }
            if (found)
            {
                regTime = time[index];
            }
            return regTime;
            //Return a registration time based on the first name input

          

        }


        private void findRegTimeBtn_Click(object sender, EventArgs e)
        {
            const float SENIOR_HOURS = 90;    // Min hours for Senior
            const float JUNIOR_HOURS = 60;    // Min hours for Junior
            const float SOPHOMORE_HOURS = 30; // Min hours for Soph.

            const string DAY1 = "November 4";  // 1st day of registration
            const string DAY2 = "November 7";  // 2nd day of registration
            const string DAY3 = "November 9";  // 3rd day of registration
            const string DAY4 = "November 10"; // 4th day of registration
            const string DAY5 = "November 11"; // 5th day of registration
            const string DAY6 = "November 14"; // 6th day of registration

            string lastNameStr;       // Entered last name
            char lastNameLetterCh;    // First letter of last name, as char
            string dateStr = "Error"; // Holds date of registration
            string timeStr = "Error"; // Holds time of registration
            float creditHours;        // Entered credit hours

            if (float.TryParse(creditHrTxt.Text, out creditHours) && creditHours >= 0) // Valid hours
            {
                lastNameStr = lastNameTxt.Text;
                if (lastNameStr.Length > 0) // Empty string?
                {
                    lastNameLetterCh = lastNameStr[0];   // First char of last name
                    lastNameLetterCh = char.ToUpper(lastNameLetterCh); // Ensure upper case

                    if (char.IsLetter(lastNameLetterCh)) // Is it a letter?
                    {
                        // Juniors and Seniors share same schedule but different days
                        if (creditHours >= JUNIOR_HOURS)
                        {
                            if (creditHours >= SENIOR_HOURS)
                                dateStr = DAY1;
                            else // Must be juniors
                                dateStr = DAY2;

                            timeStr = GetUpperClassman(lastNameStr);
                            
                        }
                        // Sophomores and Freshmen
                        else // Must be soph/fresh
                        {
                            if (creditHours >= SOPHOMORE_HOURS)
                            {
                                // J-V on one day
                                if ((lastNameLetterCh >= 'J') && // >= J and
                                    (lastNameLetterCh <= 'V'))   // <= V
                                    dateStr = DAY3;
                                else // All other letters on next day
                                    dateStr = DAY4;
                            }
                            else // must be freshman
                            {
                                // J-V on one day
                                if ((lastNameLetterCh >= 'J') && // >= J and
                                    (lastNameLetterCh <= 'V'))   // <= V
                                    dateStr = DAY5;
                                else // All other letters on next day
                                    dateStr = DAY6;
                            }

                            timeStr = GetUnderClassman(lastNameStr);
                        }

                        // Output results
                        dateTimeLbl.Text = dateStr + " at " + timeStr;
                    }
                    else // First char not a letter
                        MessageBox.Show("Enter valid last name!");
                }
                else // Empty textbox
                    MessageBox.Show("Enter a last name!");
            }
            else // Can't parse credit hours
                MessageBox.Show("Please enter valid credit hours earned!");
        }
    }
}
