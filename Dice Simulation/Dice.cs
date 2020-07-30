/*~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
' Name: Dice Simulation
' Created by: Melanie Lamp
' Date: 11/20/2018
'~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
' Description: This application simulates roll of two six-sided dice. 
' The program displays the frequencies and percents of each die after each roll. 
' A separate Die class is used to simulate random roll of the dice and the 
' corresponding images of the dice rolled are shown.
'
' Input - Number of times to roll the two dice.
' Output - Frequencies and percents of each face rolled.
'~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dice_Simulation
{
    public partial class Dice : Form
    {
        const int MAX_ROLLS = int.MaxValue;
        Bitmap memoryImage;
        string errorMessage = "Type Error: Enter a positive integer.";
        int total = 0, freq1 = 0, freq2 = 0, freq3 = 0, freq4 = 0, freq5 = 0, freq6 = 0;
        double perc1 = 0, perc2 = 0, perc3 = 0, perc4 = 0, perc5 = 0, perc6 = 0;
        Die die1 = new Die(Die.Roll());
        Die die2 = new Die(Die.Roll());

        //Default constructor
        public Dice()
        {
            InitializeComponent();
        }
        /* ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
	    * Function: btnRoll_Click()
	    * Type: Private
	    * Description: Retrieves the roll amount from the user and
        * calculates it's probability percentages based on the results.
        *    
	    * Output: Lists the frequencies and percents of each die after 
        * each dice roll. Displays corresponding die face for that roll. -
        * 
	    * Exception: Throws error when input is not read correctly or
        * out of bounds. 
	    * ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
        private void btnRoll_Click(object sender, EventArgs e)
        {
            lstDisplay.Items.Clear();
            try
            {
                int numberOfRolls = getCount(); 

                if (numberOfRolls != 0)
                {
                    errorMessage = "Range Error: Enter a positive integer > 1 and <= " + MAX_ROLLS + ".";
                    if (numberOfRolls < 1 || numberOfRolls > MAX_ROLLS)
                        throw new FormatException();

                    for (int i = 0; i < numberOfRolls; i++)
                    {
                        total += 2;

                        die1.SetSide(Die.Roll());
                        die2.SetSide(Die.Roll());

                        setFrequency(die1.GetSide());
                        setFrequency(die2.GetSide());
                    }

                    //Connects images to labels
                    SetPictureBox(picDie1, "Images/", die1.GetSide());
                    SetPictureBox(picDie2, "Images/", die2.GetSide());

                    //Calculates the percentages
                    perc1 = (double)freq1 / total;
                    perc2 = (double)freq2 / total;
                    perc3 = (double)freq3 / total;
                    perc4 = (double)freq4 / total;
                    perc5 = (double)freq5 / total;
                    perc6 = (double)freq6 / total;

                    //Displays results
                    displayResults();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show(errorMessage, "Input Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtOther.Focus();
                txtOther.SelectAll();
            }
        }
        /* ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        * Function: SetPictureBox()
        * Description: Connects the PictureBox object to the 
        *   image path folder.
        * ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
        private void SetPictureBox(PictureBox picBox, string path, int num)
        {
            String fileName = path + "die" + num + ".png";
            picBox.Image = Image.FromFile(fileName);
        }
        /* ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
         * Function: setFrequency()
         * Type: Private
         * Description: changes the current value into the passed one, and
         *			   returns the just replaced value
         * Input: Integer - number used to determine frequency
         * ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
        private void setFrequency(int num)
        {
            switch(num)
            {
                case 1:
                    freq1++;
                    break;
                case 2:
                    freq2++;
                    break;
                case 3:
                    freq3++;
                    break;
                case 4:
                    freq4++;
                    break;
                case 5:
                    freq5++;
                    break;
                default:
                    freq6++;
                    break;
            }
        }
        /* ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        * Function: mnuHelpAbout_Click()
        * Description: Displays the About form with descriptions 
        * of this program.  
        * Output: Displays page with application information.
        * ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
        private void mnuHelpAbout_Click(object sender, EventArgs e)
        {
            AboutForm myAboutForm = new AboutForm();
            myAboutForm.ShowDialog();
        }
        /* ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        * Function: mnuFilePrint_Click_1()
        * Description: Preforms the print screen procedure for 
        * capturing and printing the program window.
        * 
        * Output: Provides a print page window displaying program. 
        * ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
        private void mnuFilePrint_Click_1(object sender, EventArgs e)
        {
           btnPrint.PerformClick();
        }
       /* ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
	    * Function: getCount()
	    * Type: Private
	    * Description: Returns the value the user chose the dice to roll.
        * 
	    * Output: The number of rolls to be calculated. 
	    * Exception: throws when input is read incorrectly.
	    * ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
        private int getCount()
        {
            int count = 1;

            if (radFive.Checked)
                return 5;
            else if (radTen.Checked)
                return 10;
            else if (radHundred.Checked)
                return 100;
            else if (radOther.Checked)
            {
                if (int.TryParse(txtOther.Text, out count))
                    return count;
                else 
                {
                    MessageBox.Show(errorMessage, "Input Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                    txtOther.Focus();
                    txtOther.SelectAll();
                    return 0;
                }
            }
            else
                return 1;
        }
        /* ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
	    * Function: radOther_CheckedChanged()
	    * Type: Private
	    * Description: Checks radio buttons to determine whether or not
        * re-calculations are required.
	    * Output: The number of rolls to be calculated. 
	    * ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
        private void radOther_CheckedChanged(object sender, EventArgs e)
        {
            if (radOther.Checked)
            {                
                txtOther.ReadOnly = false;
                txtOther.Focus();
            }
            else
            {
                txtOther.Text = "";
                txtOther.ReadOnly = true;                
            }
        }
        /* ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
	    * Function: displayResults()
	    * Type: Private
	    * Description: Returns probability results including frequency 
        * and percentage after roll number is submitted. 
        * 
	    * Output: Formats and displays calculated output.
	    * ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
        private void displayResults()
        {
            string formatter = "{0,3}{1,12}{2,12:P}";
            lstDisplay.Items.Clear();
            lstDisplay.Items.Add("Face   Frequency    Percent");
            lstDisplay.Items.Add(String.Format(formatter, "1", freq1, perc1));
            lstDisplay.Items.Add(String.Format(formatter, "2", freq2, perc2));
            lstDisplay.Items.Add(String.Format(formatter, "3", freq3, perc3));
            lstDisplay.Items.Add(String.Format(formatter, "4", freq4, perc4));
            lstDisplay.Items.Add(String.Format(formatter, "5", freq5, perc5));
            lstDisplay.Items.Add(String.Format(formatter, "6", freq6, perc6));
        }
        /* ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
	    * Function: btnClear_Click()
	    * Type: Private
	    * Description: Clears the list box and returns radio buttons
        * back to their default setting.
	    * ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
        private void btnClear_Click(object sender, EventArgs e)
        {
            lstDisplay.Items.Clear();
            radOne.Checked = true;
            freq1 = freq2 = freq3 = freq4 = freq5 = freq6 = 0;
            perc1 = perc2 = perc3 = perc4 = perc5 = perc6 = 0;

            SetPictureBox(picDie1, "Images/", 1);
            SetPictureBox(picDie2, "Images/", 3);
        }
        /* ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
	    * Function: CaptureScreen()
	    * Type: Private
	    * Description: Creates graphics object using a bitmap to
        * capture the current window and is used for printing.
	    * ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
        private void CaptureScreen()
        {
            Graphics myGraphics = this.CreateGraphics();
            Size s = this.Size;
            memoryImage = new Bitmap(s.Width, s.Height, myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            memoryGraphics.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, s);
        }
        /* ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
	    * Function: btnPrint_Click()
	    * Type: Private
	    * Description: Uses the capture screen function to display a 
        * print preview box of the program.
        * 
        * Output: Provides a print page window displaying program.
	    * ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
        private void btnPrint_Click(object sender, EventArgs e)
        {
            CaptureScreen();
            ppdDice.Size = new System.Drawing.Size(540, 500);
            ppdDice.PrintPreviewControl.Zoom = 90 / 100f;
            ppdDice.ShowDialog();
        }
        /* ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
	    * Function: btnQuit_Click()
	    * Type: Private
	    * Description: Button used to exit the main application.
	    * ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /* ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
	    * Function: mnuFileClear_Click()
	    * Type: Private
	    * Description: Uses the menu to clear the list box and return 
        * radio buttons back to their default setting.
	    * ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
        private void mnuFileClear_Click(object sender, EventArgs e)
        {
            btnClear_Click(sender, e);
        }
        /* ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
	    * Function: mnuFilePrint_Click()
	    * Type: Private
	    * Description: A menu button that uses the capture screen 
        * function from Print_Click1() to display a print preview 
        * box of the program.
        * 
	    * Output: Provides a print page window displaying program.
	    * ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
        private void mnuFilePrint_Click(object sender, EventArgs e)
        {
            btnPrint.PerformClick();
        }
        /* ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
	    * Function: mnuFileQuit_Click()
	    * Type: Private
	    * Description: Menu button used to exit the main application.
	    * ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
        private void mnuFileQuit_Click(object sender, EventArgs e)
        {
            btnQuit_Click(sender, e);
        }
        /* ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
	    * Function: pdDice_PrintPage()
	    * Type: Private
	    * Description: Function used to draw captured image onto bitmap.
	    * ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~*/
        private void pdDice_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(memoryImage, 0, 0);
        }
    }
}
