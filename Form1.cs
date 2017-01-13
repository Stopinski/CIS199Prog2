//Nathan Stopinski
//MAR 6 2015
//CIS 199 01
//This program explores the use of decsion making logic and creation of a GUI application

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog2
{
    public partial class Prog2 : Form
    {
        public Prog2()
        {
            InitializeComponent();
        }
        //Declare date constants
        const string SENIORDAY = "Wednesday, April 1, 2015";
        const string JUNIORDAY = "Thursday, April 2, 2015";
        const string SOPHOMOREDAYONE = "Friday, April 3, 2015";
        const string SOPHOMOREDAYTWO = "Monday, April 6, 2015";
        const string FRESHMANDAYONE = "Tuesday, April 7, 2015";
        const string FRESHMANDAYTWO = "Wednesday, April 8, 2015";

        //Declare registration time constants
        const string TIMEONE = " at 8:30a";
        const string TIMETWO = " at 10:00a";
        const string TIMETHREE = " at 11:30a";
        const string TIMEFOUR = " at 2:00p";
        const string TIMEFIVE = " at 4:00p";

        private void registrationButton_Click(object sender, EventArgs e)
        {
            string lastName = lastNameTextBox.Text;  //declare user input as string

            //declare a string and a char and eliminate case sensitivity of text box user input.

            char letter = char.ToUpper(lastName[0]);

            if (char.IsLetter(letter))  //determine that user input is an alphabetical letter before continuing to ensure accuracy
            {
                string date = "";  //Place holders for registration day and time.
                string time = "";

                if (seniorRadioButton.Checked || juniorRadioButton.Checked)
                {
                    //Determine registration date for SR or JR
                    if (seniorRadioButton.Checked)
                        date = SENIORDAY;
                    else
                        date = JUNIORDAY;

                    //Determine registration time based on user input.
                    if (letter <= 'D')
                        time = TIMETWO;
                    else if (letter <= 'I')
                        time = TIMETHREE;
                    else if (letter <= 'O')
                        time = TIMEFOUR;
                    else if (letter <= 'S')
                        time = TIMEFIVE;
                    else
                        time = TIMEONE;

                    //Display output result
                    MessageBox.Show("You can register on " + date.ToString() + time.ToString());
                }
                else if (sophomoreRadioButton.Checked || freshmanRadioButton.Checked) //must be sophomore or freshman
                {
                    //Declare registration date for SOPH or FR
                    if (sophomoreRadioButton.Checked)
                    {
                        if (letter >= 'G' && letter <= 'S')
                            date = SOPHOMOREDAYTWO;
                        else
                            date = SOPHOMOREDAYONE;
                    }
                    else
                    {
                        if (letter >= 'G' && letter <= 'S')
                            date = FRESHMANDAYTWO;
                        else
                            date = FRESHMANDAYONE;
                    }

                    //Determine registration time based on user input
                    if (letter <= 'B')
                        time = TIMETHREE;
                    else if (letter <= 'D')
                        time = TIMEFOUR;
                    else if (letter <= 'F')
                        time = TIMEFIVE;
                    else if (letter <= 'I')
                        time = TIMEONE;
                    else if (letter <= 'L')
                        time = TIMETWO;
                    else if (letter <= 'O')
                        time = TIMETHREE;
                    else if (letter <= 'Q')
                        time = TIMEFOUR;
                    else if (letter <= 'S')
                        time = TIMEFIVE;
                    else if (letter <= 'V')
                        time = TIMEONE;
                    else
                        time = TIMETWO;

                    //Display output result.
                    MessageBox.Show("You can register on " + date.ToString() + time.ToString());
                }
            }
            else
                MessageBox.Show("Invalid input. Please enter your last name and try again.");
        }
    }
}
                         
    

                                            
                                            
               
                       