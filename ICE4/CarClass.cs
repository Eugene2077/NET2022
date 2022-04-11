
/* author : Hongju Shin
 * ID:  100844220
 * Date: 12 Mar 2022
 * Subject: ICE4
 * Purpose: App that selecting the cars to show
 */

#region Using
using System;
using System.Collections.Generic;
using System.Drawing;
#endregion


namespace ICE4
{
   #region Car
    class Car
    {

        #region Properties
        public int Serial { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public DateTime ManufactureDate { get; set; }
        public Color Color { get; set; }
        #endregion

        #region Constructor
        /// <summary>
        /// Default constructor
        /// </summary>
        public Car(){}

   
        /// <summary>
        /// Parametrized constructor
        /// </summary>
        /// <param name="serial"></param>
        /// <param name="brand"></param>
        /// <param name="model"></param>
        /// <param name="manufactureDate"></param>
        /// <param name="color"></param>
        public Car(int serial, string brand, string model, DateTime manufactureDate, Color color)
        {
            Serial = serial;
            Brand = brand;
            Model = model;
            ManufactureDate = manufactureDate;
            Color = color;
        }
        #endregion


        #region static Methods
        /// <summary>
        /// make a sample list of the show car
        /// </summary>
        /// <returns></returns>
        public static List<Car> sampleCarLists()
        {
            List<Car> returnList = new List<Car>();
            returnList.Add(new Car(1001, "Ford", "Mustang", new DateTime(2022, 01, 20),Color.Red));
            returnList.Add(new Car(1002, "Dodge", "Challenger", new DateTime(2022, 02, 12), Color.Green));
            returnList.Add(new Car(1003, "Nissan", "GTR", new DateTime(2021, 12, 10), Color.Black));
            returnList.Add(new Car(1004, "Hyundai", "Azera", new DateTime(2022, 01, 02), Color.Yellow));

            return returnList;
        }

        /// <summary>
        /// Method to check the same car is already in the show car list
        /// </summary>
        /// <returns></returns>
        public static bool CheckIfTheSameCarExist(List<Car> carList, int serial)
        {
            bool retVal = false;
            foreach (Car car in carList)
            {
                if (serial == car.Serial)
                { retVal = true; }
            }

            return retVal;
        }

        /// <summary>
        /// find the selected car in the list
        /// </summary>
        /// <param name="carList"></param>
        /// <param name="serial"></param>
        /// <returns></returns>
        public static Car FindTheCar(List<Car> carList, int serial)
        {
            Car retVal = new Car();
            foreach (Car car in carList)
                if (serial == car.Serial)
                { retVal = car; }
            return retVal;

            // return carList.Find(car => car.Serial == serial);  // or Using Find() function
        }


        #endregion

    }

    #endregion
}
