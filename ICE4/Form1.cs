

/* author : Hongju Shin
 * ID:  100844220
 * Date: 12 Mar 2022
 * Subject: ICE4
 * Purpose: App that selecting the cars to show
 */


#region Using statement
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
#endregion

namespace ICE4
{
    public partial class ShowCars : Form
    {
        #region Initiallizing
        public ShowCars()
        {
            InitializeComponent();
        }
        #endregion

        #region Global Variables
        List<String> Brands = new List<String>();   // list of the brands
        List<Car> CarsList = new List<Car>();       // list of the cars to show
        #endregion


        #region Event handler

        /// <summary>
        /// Initillize the app
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ShowCars_Load(object sender, EventArgs e)
        {
            PopulateBrands();
            cboBrand.DataSource = Brands;
            CarsList = Car.sampleCarLists();
            PopulateCarGrid();
        }


        /// <summary>
        /// save the selection and refelct to the gridview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Car newCar = new Car();  // new instance of the car

                //validation
                if (InputValidation())     // if the input is right
                {
                    newCar.Serial = Decimal.ToInt32(this.nudSerial.Value); // convert a Decimal value to a 32-bit integer
                    newCar.Brand = this.cboBrand.SelectedValue.ToString();
                    newCar.Model = this.txtModel.Text.Trim();
                    newCar.ManufactureDate = this.dtpManufactured.Value;
                    newCar.Color = this.lblColor.BackColor;

                    if (Car.CheckIfTheSameCarExist(CarsList, newCar.Serial))    // Check if the same serial number already exists
                    {
                        CarsList.Remove(Car.FindTheCar(CarsList, newCar.Serial));
                        CarsList.Add(newCar);
                    }
                    else
                    {
                        CarsList.Add(newCar);
                    }

                    PopulateCarGrid();
                    SetDefault();
                }
            }
            catch   // error handling
            {
                MessageBox.Show("An error occured saving the Car!",
                  "Input Error", MessageBoxButtons.OK);
            }
        }





        /// <summary>
        /// Select a color
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnColor_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            lblColor.BackColor = colorDialog1.Color;
        }


        /// <summary>
        /// Reset the entries
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReset_Click(object sender, EventArgs e)
        {
            SetDefault();
        }


        /// <summary>
        /// when user select one car from the gridview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvShowCar_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvShowCar.SelectedRows.Count > 0)   // if any of the rows is selected
            {
                int theCarSerial = Convert.ToInt32(dgvShowCar.SelectedRows[0].Cells[0].Value);
                // get me the first cell(column) in the first row
                // the fist cell(Designation) is int, but the default value is an object, se we need to convert to int

                Car newCar = Car.FindTheCar(CarsList, theCarSerial);
                PopulateEntries(newCar);
            }
            else
            { SetDefault(); }     // if nothing selected, set default (go empty)
        }



        #endregion

        #region Custom methods
        /// <summary>
        /// the List of the auto brand, only few brands in here for exercise 
        /// </summary>
        private void PopulateBrands()
        {
            Brands.Add("Ford");
            Brands.Add("Toyota");
            Brands.Add("Honda");
            Brands.Add("Nissan");
            Brands.Add("Mazda");
            Brands.Add("Chevrolet");
            Brands.Add("Jeep");
            Brands.Add("Subaru");
            Brands.Add("Volkswagen");
            Brands.Add("Lexus");
            Brands.Add("Ferrari");
            Brands.Add("Volvo");
            Brands.Add("Jaguar");
            Brands.Add("GMC");
            Brands.Add("Buick");
            Brands.Add("Acura");
            Brands.Add("Dodge");
            Brands.Add("Hyundai");
        }

        /// <summary>
        /// Set to Default all the entries
        /// </summary>
        private void SetDefault()
        {
            nudSerial.Value = 0;
            cboBrand.SelectedIndex = 0;
            txtModel.Clear();
            dtpManufactured.Value = DateTime.Now;
            lblColor.BackColor = Color.Red;
        }




        /// <summary>
        /// Repopulate the gridview 
        /// </summary>
        private void PopulateCarGrid()
        {
            dgvShowCar.DataSource = null;
            dgvShowCar.DataSource = CarsList;
            dgvShowCar.ClearSelection();
        }

        /// <summary>
        /// Populate the entries by selected item in the gridview
        /// </summary>
        /// <param name="car"></param>
        private void PopulateEntries(Car car)
        {
            this.nudSerial.Value = car.Serial;
            this.cboBrand.SelectedItem = car.Brand;
            this.txtModel.Text = car.Model;
            this.dtpManufactured.Value = car.ManufactureDate;
            this.lblColor.BackColor = car.Color;
        }


        /// <summary>
        /// input validation method
        /// </summary>
        /// <returns></returns>
        private bool InputValidation()
        {
            bool retVal = false;
            if (Decimal.ToInt32(this.nudSerial.Value) == 0)
            {
                MessageBox.Show("Please input Serial number!",
                "Input Error", MessageBoxButtons.OK);
            }
            else if (this.txtModel.Text.Trim() == "")
            {
                MessageBox.Show("Please input Model!",
                    "Input Error", MessageBoxButtons.OK);
            }
            else { retVal = true; }

            return retVal;
        }



        #endregion


    }
}
