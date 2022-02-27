/* author : Hongju Shin
 * ID:  100844220
 * Date: 04 Feb 2022
 * Purpose: App display each weekdays and calculate the cases
 */


#region Using Stastement
using System;
using System.Windows.Forms;
#endregion

namespace ICE2_DiseaseCases
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region Global variables
   
        Label[] weekDays;
        TextBox[] infections;

        #endregion


        #region App initialize
        /// <summary>
        /// initialize the arrays and populate them, populate lables
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            // initialize the weekdays label array and populate with the appropriate labels
            weekDays = new Label[] { lblDay1, lblDay2, lblDay3, lblDay4, lblDay5, lblDay6, lblDay7 };
            // initialize the infections textbox array and populate with the appropriate textboxes
            infections = new TextBox[] { txtDay1, txtDay2, txtDay3, txtDay4, txtDay5, txtDay6, txtDay7 };
            // populate the week day name labels with the actual names.
            SetDayNames();
            SetDefaults();
        }
        #endregion

        #region Custom Methods
        
        /// <summary>
        /// set default value for textbox infections input, reset the date to today
        /// </summary>
        private void SetDefaults()
        {
            dtpStartingDate.Value = DateTime.Now;
            for (int item = 0; item < 7; item++)
            {
                infections[item].Text = string.Empty;
            }
            lblDailyAverage.Text = string.Empty;
        }
        /// <summary>
        /// weekday lables to the proper name starting from the selected date
        /// </summary>
        private void SetDayNames()
        {
            for (int day = 1; day <= 7; day++)
            {
                weekDays[day - 1].Text = (dtpStartingDate.Value.AddDays(day - 1)).DayOfWeek.ToString();
            }
        }
        #endregion

        #region Event Handler

        /// <summary>
        /// the DateTimePicker control such that the weekday names are updated to match the chosen date. Note: the custom method to enter the names is already created, just call it.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtpStartingDate_ValueChanged(object sender, EventArgs e)
        {
            SetDayNames();
        }

        /// <summary>
        /// Call validation method and calculate the average if the inputs are valid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (ValidateInfections())
            {
                int totalInfection = 0;
                for (int i = 0; i < 7; i++)
                {
                    totalInfection += int.Parse(infections[i].Text);
                }
                double average =  Math.Round(Convert.ToDouble(totalInfection) / 7.0, 2);
                lblDailyAverage.Text = average.ToString();
            }
            else
            {
                MessageBox.Show("Calculations can not be performed as one or more validations have failed");
            }
            
        }

        /// <summary>
        /// Exit the app
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Reset to default values
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReset_Click(object sender, EventArgs e)
        {
            SetDefaults();
        }
        #endregion

        #region Validation
        /// <summary>
        /// validation process if the input is a whole number
        /// </summary>
        /// <returns></returns>
        private bool ValidateInfections()
        {
            bool retVal = true;
            for (int i = 0; i < 7; i++)
            {
                int temp;
                if (int.TryParse(infections[i].Text, out temp)) 
                {
                    if (int.Parse(infections[i].Text) < 0)
                    { MessageBox.Show("The number in " + weekDays[i].Text.ToString() + " is a negative value, Are you sure?"); }
                }
                else
                {
                    MessageBox.Show("The Infection number of "+ weekDays[i].Text.ToString()+" is not valid");
                    retVal = false;
                    break;
                }
            }
            return retVal;
        }
        #endregion


    }
}
