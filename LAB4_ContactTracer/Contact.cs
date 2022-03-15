
/* author : Hongju Shin
 * ID:  100844220
 * Date: 20 Mar 2022
 * Subject: Lab4
 * Purpose: Management Contact List app creation
 */


#region Using statemen
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#endregion'

namespace LAB4_ContactTracer
{
    class Contact
    {
        #region Properties
        // const string temp = "a value"; if I have a constant here, it must be assigned in here and cannot be changed anymore.

        // Readonly : whose value we can change during runtime or we can assign it at run time but only through the non-static constructor  (https://www.c-sharpcorner.com/UploadFile/c210df/difference-between-const-readonly-and-static-readonly-in-C-Sharp/#:~:text=A%20Static%20Readonly%20type%20variable's,change%20only%20once%20at%20runtime.)
        // 즉, readonly variable 은 static constructor 또는 method 에 의해 값을 바꿀 수 없다(말 그대로 읽기전용)
        // 그러나 default constructor(or Parametrized constructor)를 사용하면 readonly 라도 그 값을 바꿀 수 있다.

        // default constructor : Public ClassName(){ VariableName = value }

        // Static ReadOnly : static constructor 에 의해서만 값이 정해질 수 있는변수, 한 번 값이 정해지면 바뀔 수 없다.
        // Static constructor 어떻게 쓰는지는 아래 참조 (그냥 classname 앞에 static 키워드)

        public static int Count = 0;
        public int Id { get; set; }
        public Boolean ContactStatus { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }


        #endregion


        // Static variable is look like as below, and it is initaillize at the time of declaration
        // private static int id = 10;
        // private static string name = "jack";
        // "static constructor": this constructor is used for initiallize static members(variable) and it looks like as below
        //  static ClassName() {
        //      if(condition) { staticVairable1 = value1 }
        //      else { staticVariable1 = value2 } }
        // 위와같이 조건에 따라 initiallization value 가 달라지는 경우 등, static variable 에 바로 값을 줄 수 없을때 이와같이 static constructor 를 사용한다.
        // 참조  https://www.c-sharpcorner.com/article/static-constructor-in-C-Sharp-and-their-usages/

        #region Constructors

        /// <summary>
        /// Static constructor
        /// </summary>
        /// Static constructor is used to initialize static data members as soon as the class is referenced the first time
        /// whereas an instance constructor is used to create an instance of that class with the <new> keyword.
        /// A static constructor does not take access modifiers or have parameters and can't access any non-static data member of a class
        // static Contact() 
        // {
        //      // increment the contact count
        // }


        public Contact() 
        {}

        /// <summary>
        /// Parametrized constructor ( Instance constructor.)
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="email"></param>
        /// <param name="phoneNUmber"></param>
        /// <param name="isContacted"></param>
        public Contact(String firstName, String lastName, String email, String phoneNUmber, Boolean isContacted)
        {
            FirstName = firstName;
            LastName = lastName;
            EmailAddress = email;
            PhoneNumber = phoneNUmber;
            ContactStatus = isContacted;
        }

        #endregion

        #region Object Methods
        #endregion

        #region Static Methods // satic method: only work with classname.methodname(), not working in an object
        // static members: Static members (which can mean variables, properties or functions) have one copy that can be used by all objects of the class
        // These are generally used for totals and counts


        public static List<Contact> CreateSampleList()
        {
            List<Contact> returnList = new List<Contact>();

            returnList.Add(new Contact("Jean","Mauser","jean@gmail.com","124-253-6654",false));
            returnList.Add(new Contact("Henry", "Wang", "henly@gmail.com", "545-225-9875", true));
            returnList.Add(new Contact("Nathan", "Martin", "nate2@gmail.com", "124-325-8896", false));
            returnList.Add(new Contact("Jim", "Kelvin", "jiji123@gmail.com", "112-354-8875", true));
            returnList.Add(new Contact("Timothy", "Owser", "timbitslove@gmail.com", "075-856-3214", false));

            return returnList;
        }

        public static Contact FindTheContact(List<Contact> ContactList, int id)
        {
            Contact retVal = new Contact();
            foreach (Contact contact in ContactList)
                if (id == contact.Id)
                { retVal = contact; }
            return retVal;
        }


        public static bool CheckIftheSameIdExit(List<Contact> ContactList, int id)
        {
            bool retVal = false;
            foreach (Contact contact in ContactList)
            {
                if (id == contact.Id)
                { retVal = true; }
            }

            return retVal;
        }



        #endregion

    }
}
