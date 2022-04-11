/* ----------------------------------
 * Author:  Hongju(Eugene) Shin
 * Date:    Feb 07, 2022
 * Description:
 *      A sample application that takes numeric grades and convert these value to letter grade.
 *      also calculate the total average and corresponding final letter grade
 * Revision History:
 *      1.0 Feb 07, 2022
 * ----------------------------------
 */

#region Using Statement
using System;
using System.Windows.Forms;
#endregion

namespace LAB2_Grade
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        #region Global Variable Decalrations
        const int MinGrade = 0;
        const int MaxGrade = 100;

        TextBox[] inputTextboxs;
        TextBox[] outputTextboxs;

        #endregion

        #region Event Handlers
        private void FormMain_Load(object sender, EventArgs e)
        {
            inputTextboxs = new TextBox[] { txtGradeInput1, txtGradeInput2, txtGradeInput3, txtGradeInput4, txtGradeInput5, txtGradeInput6, txtGradeInput7 };
            outputTextboxs = new TextBox[] { txtLetterGrade1, txtLetterGrade2, txtLetterGrade3, txtLetterGrade4, txtLetterGrade5, txtLetterGrade6, txtLetterGrade7 };

        }

        #region Grade Conversion and Validation
        /// <summary>
        /// from each input textbox, call the validaiton and converting Method.
        /// leave event used for this method. (Leave: when you move control from the textbox, it evokes)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtGradeInput1_Leave(object sender, EventArgs e)
        {inputValAndConvertGrade(txtGradeInput1, txtLetterGrade1,1);}
        private void txtGradeInput2_Leave(object sender, EventArgs e)
        {inputValAndConvertGrade(txtGradeInput2, txtLetterGrade2,2);}
        private void txtGradeInput3_Leave(object sender, EventArgs e)
        {inputValAndConvertGrade(txtGradeInput3, txtLetterGrade3,3);}
        private void txtGradeInput4_Leave(object sender, EventArgs e)
        {inputValAndConvertGrade(txtGradeInput4, txtLetterGrade4,4);}
        private void txtGradeInput5_Leave(object sender, EventArgs e)
        {inputValAndConvertGrade(txtGradeInput5, txtLetterGrade5,5);}
        private void txtGradeInput6_Leave(object sender, EventArgs e)
        {inputValAndConvertGrade(txtGradeInput6, txtLetterGrade6,6);}
        private void txtGradeInput7_Leave(object sender, EventArgs e)
        {inputValAndConvertGrade(txtGradeInput7, txtLetterGrade7,7);}
        #endregion

        /// <summary>
        /// calculations
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double gradeSum = 0;
            int numOfCoure = 0;
            bool isValid = true;
            for (int item =0; item <7; item++)
            {
                if(inputTextboxs[item].Text.Trim() == "") { break; }      //when the textbox is empty, skip
                double inputGrade;                  // the grade on this input textbox
                if (double.TryParse(inputTextboxs[item].Text.Trim(), out inputGrade))
                {  // if the grade is numeric
                    if (inputGrade >= 0 && inputGrade <= 100)   // and if the grade is within the range
                    {  // add this grade to sum
                        gradeSum += double.Parse(inputTextboxs[item].Text.Trim());
                        numOfCoure++;
                    }
                    else // in case of out of range 
                    {
                        lblTextOutput.Text = "The input grade in \"Course " + (item + 1) + " is NOT a valid range, please input between " + MinGrade + " and " + MaxGrade;
                        inputTextboxs[item].Select();
                        isValid = false;
                    }
                }
                else  // in case not numeric
                {
                    lblTextOutput.Text = "The input grade in \"Course " + (item + 1) + " is not numeric, Please input a numeric grade";
                    inputTextboxs[item].Select();
                    isValid = false;
                }

            }

            if (numOfCoure > 0 && isValid == true)  // we don't need to calculate average when NO input at all
            {
                double average = Math.Round(gradeSum / numOfCoure, 2);   // round 2 digits
                txtGradeAverage.Text = average.ToString();
                txtLetterGradeTotal.Text = CalculateGrage(average).ToString();  //calculate averate letter grade
                stopInputAnymore();                 // calculate button and input textbox to enactive
            }
        }

        /// <summary>
        /// Reset all 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReset_Click(object sender, EventArgs e)
        {
            SetDefaults();
        }

        /// <summary>
        /// close the app
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
        /// input validation and convert grade form the user's input textbox
        /// </summary>
        /// <param name="tbox"></param>
        /// <param name="outTbox"></param>
        private void inputValAndConvertGrade(TextBox tbox, TextBox outTbox, int tboxNumber)
        {
            // validate if it is numeric and in the valid range
            // try validation funciton IsNumeric, return value: 0:between range / 1(not numeric), 2(out of range numeric)
            // int validation = IsNumeric(txtGradeInput1.Text.Trim(), MinGrade, MaxGrade);
            int validation = IsNumeric(tbox.Text.Trim(), MinGrade, MaxGrade);
            if (validation == -1) { }// we don't need any action when the input textbox is empty

            else if (validation == 1)
            { 
                lblTextOutput.Text = "The input grade in \"Course " + tboxNumber + " is not numeric, Please input a numeric grade";
                tbox.Select();                  // when the input is not valid, the focus is keep stay at the textbox
                outTbox.Text = string.Empty;    // if there is a grade from the last input and input again with a invalid number, clear the letter grade output
            }
            else if (validation == 2)
            { 
                lblTextOutput.Text = "The input grade in \"Course " + tboxNumber + " is NOT a valid range, please input between " + MinGrade + " and " + MaxGrade;
                tbox.Select();                   // when the input is not valid, the focus is keep stay at the textbox
                outTbox.Text = string.Empty;     // if there is a grade from the last input and input again with a invalid number, clear the letter grade output
            }
            else
            {
                outTbox.Text = CalculateGrage(double.Parse(tbox.Text.Trim()));
                lblTextOutput.Text = string.Empty; // if there is an error messgae from the previous input
            }

        }

        /// <summary>
        /// Calculating the grade from the method "inputValAndConvertGrade"
        /// </summary>
        /// <param name="grade"></param>
        /// <returns></returns>
        private string CalculateGrage(double grade)
        {
            string letterGrade = "";
            if (grade >= 90) { letterGrade = "A+"; }
            else if (grade>= 82) { letterGrade = "A"; }
            else if (grade >= 80) { letterGrade = "A-"; }
            else if (grade >= 78) { letterGrade = "B+"; }
            else if (grade >= 72) { letterGrade = "B"; }
            else if (grade >= 70) { letterGrade = "B-"; }
            else if (grade >= 68) { letterGrade = "C+"; }
            else if (grade >= 62) { letterGrade = "C"; }
            else if (grade >= 60) { letterGrade = "C-"; }
            else if (grade >= 58) { letterGrade = "D+"; }
            else if (grade >= 52) { letterGrade = "D"; }
            else if (grade >= 50) { letterGrade = "D-"; }
            else { letterGrade = "F"; }

            return letterGrade;
        }

        /// <summary>
        /// Calculate button and input textbox to inactive
        /// </summary>
        private void stopInputAnymore()
        {
            btnCalculate.Enabled = false;       // button enactive
            txtGradeInput1.ReadOnly = true;     // input textbox to readonly
            txtGradeInput2.ReadOnly = true;
            txtGradeInput3.ReadOnly = true;
            txtGradeInput4.ReadOnly = true;
            txtGradeInput5.ReadOnly = true;
            txtGradeInput6.ReadOnly = true;
            txtGradeInput7.ReadOnly = true;
        }

        /// <summary>
        /// Calculate button and input textbox to active
        /// </summary>
        private void resetToActive()
        {
            btnCalculate.Enabled = true;         // button active
            txtGradeInput1.ReadOnly = false;     // input textbox to active
            txtGradeInput2.ReadOnly = false;
            txtGradeInput3.ReadOnly = false;
            txtGradeInput4.ReadOnly = false;
            txtGradeInput5.ReadOnly = false;
            txtGradeInput6.ReadOnly = false;
            txtGradeInput7.ReadOnly = false;
        }

        #endregion


        #region Validations

        /// <summary>
        /// validation if the input is numeric and within the range, return the result with int
        /// </summary>
        /// <param name="inputValue"></param>
        /// <param name="minValue"></param>
        /// <param name="maxValue"></param>
        /// <returns></returns>
        private int IsNumeric(string inputValue, int minValue, int maxValue)
        {     // is it within the number?
            int retVal = 0;       // 0: numeric between minValue to maxValue
            if (inputValue == "") { retVal = -1; } // when input textbox is empty, return -1
            else
            {    //when we don't have any input in the textbox input, we don't need to validate it
                double temp;
                if (double.TryParse(inputValue, out temp))
                {
                    if (!(IsInRange(temp, minValue, maxValue)))
                    { retVal = 2; }   // 2: numeric, but out of range
                }
                else
                {
                    retVal = 1;       // 1: not a numeric
                }
            }
            return retVal;
        }

        private bool IsInRange(double inputValue, int minValue, int maxValue)
        {
            return (inputValue >= minValue && inputValue <= maxValue);
        }
        #endregion

        #region General Methods
        /// <summary>
        /// default method: all the entries to empty and enable the textbox and button
        /// </summary>
        private void SetDefaults()
        {
            resetToActive();
            foreach (TextBox tbox in inputTextboxs) { tbox.Clear(); }  // clear input textbox
            foreach (TextBox tbox in outputTextboxs) { tbox.Clear(); } // clear output textbox
            txtGradeAverage.Text = string.Empty;
            txtLetterGradeTotal.Text = string.Empty;
            lblTextOutput.Text = string.Empty;
            txtGradeInput1.Select();                    // cursor to the fist input location
        }
        #endregion


    }
}
