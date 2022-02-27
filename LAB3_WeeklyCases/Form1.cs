
/* author : Hongju Shin
 * ID:  100844220
 * Date: 24 Feb 2022
 * Purpose: App that calculate weekly cases by regions
 */


#region Using statements
using System;
using System.Windows.Forms;
using System.Drawing;
# endregion

namespace LAB3_WeeklyCases
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        #region Global Variables Decalrations
        int[,] cases = new int[3, 7];
        const int MIN_CASE = 0;
        const int MAX_CASE = 999999;

        #endregion

        #region Event Handlers
        /// <summary>
        /// Initializing on loading the app
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormMain_Load(object sender, EventArgs e)
        {
            InitializeArray();
        }

        /// <summary>
        /// when Enter is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEnter_Click(object sender, EventArgs e)
        {
            // values assign to the array
            double[] eachAverages = new double[3];  // store averages to this array: I need to save the average data to compare to Total Average(for colouring the output lable)

            for (int region = 0; region < 3; region++)
            {
                int dayCounter = 0;                         // count if all seven days are filled, 
                for (int daily = 0; daily < 7; daily++)
                {
                    dayCounter++;
                    if (cases[region, daily] == -999)       // if the element is the same as the initial value (it means it is the place the new value has to in)
                    {
                        // input validation and assign the value to the array emement
                        if (inputValidation(txtInput.Text.Trim(), MIN_CASE, MAX_CASE))             // if the validation is returned with true
                        { cases[region, daily] = int.Parse(txtInput.Text.Trim()); }  // assign the array element from input textbox

                        break;                              // when a new value assigned to the array, no more iteration need
                    }
                }
                if (dayCounter < 7) { break; }              // until all 7 days are filled, no need iteration
                else                                        // when all the 7days inputs are filled
                {
                    if (region == 0)                        // Parameter "region": to decide which of the array members to calculate
                    { 
                        eachAverages[0] = CalculateAverage(region);
                        lblOut1.Text = "Average: " + eachAverages[0].ToString();
                    }  
                    else if (region == 1)
                    {
                        eachAverages[1] = CalculateAverage(region); 
                        lblOut2.Text = "Average: " + eachAverages[1].ToString();
                    }
                    else
                    {
                        eachAverages[2] = CalculateAverage(region); 
                        lblOut3.Text = "Average: " + eachAverages[2].ToString(); // when all the 3 regions are filled 
                        double averageTotal = CalculateAverage(3);
                        lblOutTotal.Text = "Average this week: " + averageTotal.ToString();  // total average also to be calculated

                        //  change the background of that region’s average output control
                        Label[] averageLable = {lblOut1,lblOut2,lblOut3};    // label array
                        int regionNumber = 0;
                        foreach (Label outLable in averageLable)
                        {
                            if (eachAverages[regionNumber] > averageTotal) { outLable.BackColor = System.Drawing.Color.Red;}
                            else if(eachAverages[regionNumber] < averageTotal) { outLable.BackColor = System.Drawing.Color.Green; }
                            regionNumber++;
                        }
 
                        DisableInput();                          // no more input, disable Enter button

                    }

                }
            }
            // show the daily cases in the textboxs
            displayCases();
            txtInput.Text = string.Empty;        // input textbox to empty
            txtInput.Select();                   // cursor to input textbox



            //------------------------test display to lblOutTotal to see if the array is workng well ---------
            // string arrayContents = "Array= ";
            /*
            var builder = new StringBuilder();
            for (int region = 0; region < 3; region++)
            {
                for (int daily = 0; daily < 7; daily++)
                {
                    builder.Append(cases[region, daily]).ToString();
                }
            }
            lblOutTotal.Text = builder.ToString();
            */
        }

        /// <summary>
        /// Reset key event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnReset_Click(object sender, EventArgs e)
        {
            SetDefaults();
        }

        /// <summary>
        /// Exit key event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        #endregion

        #region Custom Methods and Functions

        /// <summary>
        /// initializing the array
        /// </summary>
        private void InitializeArray()
        {
            for (int reg = 0; reg < 3; reg++)
            {
                for (int day = 0; day < 7; day++)
                {
                    cases[reg, day] = -999;
                }
            }
        }

        /// <summary>
        /// Average calculation function
        /// </summary>
        /// <param name="averageOfWhich"></param>
        /// <returns></returns>
        private double CalculateAverage(int averageOfWhich)
        {
            double average;
            double sum = 0;

            if (averageOfWhich == 3)                   // total average calculation
            {
                for (int region = 0; region < 3; region++)
                {
                    for (int daily = 0; daily < 7; daily++)
                    { sum += cases[region, daily]; }
                }
                average = Math.Round(sum / 21, 2);
            }
            else
            {
                for (int item = 0; item < 7; item++)     // regions average calculation
                { sum += cases[averageOfWhich, item]; }
                average = Math.Round(sum / 7, 2);
            }

            return average;
        }


        /// <summary>
        /// show the daily cases in the textboxs
        /// </summary>
        private void displayCases()
        {
            int regionBox = 1;                      // Region textbox 1
            txtRegion1.Text = string.Empty;         // clear previous value, if not= array [0] + [0][1] = [0][0][1] 
            for (int daily = 0; daily < 7; daily++) // iteration for a week
            {
                if (cases[regionBox - 1, daily] == -999) break;   // if the element is the default value, no more iteration
                txtRegion1.AppendText(cases[regionBox - 1, daily] + "\r\n");  // text build up to the Region1 textbox
            }

            regionBox = 2;                      // Region textbox 2
            txtRegion2.Text = string.Empty;
            for (int daily = 0; daily < 7; daily++)
            {
                if (cases[regionBox - 1, daily] == -999) break;
                txtRegion2.AppendText(cases[regionBox - 1, daily] + "\r\n");
            }

            regionBox = 3;                      // Region textbox 3
            txtRegion3.Text = string.Empty;
            for (int daily = 0; daily < 7; daily++)
            {
                if (cases[regionBox - 1, daily] == -999) break;
                txtRegion3.AppendText(cases[regionBox - 1, daily] + "\r\n");
            }
        }

        #endregion

        #region Validations

        /// <summary>
        /// Input Validation ( Whole number with zero or more than zero)
        /// </summary>
        /// <param name="inputValue"></param>
        /// <param name="MIN_CASE"></param>
        /// <returns></returns>
        private bool inputValidation(string inputValue, int MIN_CASE, int MAX_CASE)
        {
            bool isValid = false;
            int testValue;

            if (int.TryParse(inputValue, out testValue))
            {
                if (testValue < MIN_CASE)
                {
                    MessageBox.Show("The daily case cannot be lower than " + MIN_CASE + ", Please input again");
                }
                else if (testValue > MAX_CASE)
                {
                    MessageBox.Show("The daily case is too much, something is wrong, Please input lower than " + MAX_CASE);
                }
                else { isValid = true; }
            }
            else
            {
                MessageBox.Show("Invalid input, Please input numeric number");
            }
            return isValid;
        }



        #endregion

        #region General Methods
        /// <summary>
        /// Set to Default: clear all
        /// </summary>
        private void SetDefaults()
        {
            txtInput.Text = string.Empty;
            txtRegion1.Text = string.Empty;
            txtRegion2.Text = string.Empty;
            txtRegion3.Text = string.Empty;
            lblOut1.Text = string.Empty;
            lblOut2.Text = string.Empty;
            lblOut3.Text = string.Empty;
            lblOutTotal.Text = string.Empty;
            InitializeArray();
            btnEnter.Enabled = true;                // no more input allowed
            txtInput.ReadOnly = false;              // input textbox to read only
            txtInput.Select();                      // cursor to the input textbox
            lblOut1.BackColor = SystemColors.Control;    // restore the background colour of output lables
            lblOut2.BackColor = SystemColors.Control;
            lblOut3.BackColor = SystemColors.Control;
        }

       /// <summary>
       /// when input is done, No more input is needed until reset
       /// </summary>
       private void DisableInput()
        {
            btnEnter.Enabled = false;                // no more input allowed
            txtInput.ReadOnly = true;                // input textbox to read only
        }

        #endregion

        
    }
}
