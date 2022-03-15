
/* author : Hongju Shin
 * ID:  100844220
 * Date: 20 Mar 2022
 * Subject: Lab4
 * Purpose: Management Contact List app creation
 */


#region Using statement
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
#endregion

namespace LAB4_ContactTracer
{
    public partial class Main : Form
    {
        #region Initiallizing
        public Main()
        {
            InitializeComponent();
        }
        #endregion

        #region Global variables
        List<Contact> ContactList = new List<Contact>();
        bool EditMode;
        #endregion

        #region event handlers
        private void Main_Load(object sender, EventArgs e)
        {
            EditMode = false;
          // ContactList = Contact.CreateSampleList();
          // populateContactList();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            Contact newContact = new Contact();

            newContact.FirstName = this.txtFirstName.Text.Trim();
            newContact.LastName = this.txtLastName.Text.Trim();
            newContact.EmailAddress = this.txtEmail.Text.Trim();
            newContact.PhoneNumber = this.txtPhone.Text.Trim();
            newContact.ContactStatus = this.chkContacted.Checked;


            // input validation

            if (InputValidaiton(newContact.FirstName, newContact.LastName, newContact.EmailAddress, newContact.PhoneNumber))  // if the inputs are valid

            {
                // Check if now is the new input situation or editing situation.
                if (EditMode == false) // New contact input Mode
                {
                    Contact.Count += 1;
                    newContact.Id = Contact.Count;
                }
                else // when select a contact from Data grid view and editing, get the id from the selection
                {
                    int id = Convert.ToInt32(dgvContacts.SelectedRows[0].Cells[0].Value);
                    newContact.Id = id;
                }

                // check if the same listing(the same id) exist and replace it if there is
                if (Contact.CheckIftheSameIdExit(ContactList, newContact.Id))
                {
                    ContactList.Remove(Contact.FindTheContact(ContactList, newContact.Id));
                    ContactList.Add(newContact);
                }
                else
                {
                    ContactList.Add(newContact);
                }

                populateContactList();
                SetDefault();
            }
            else  // if the inputs are not valid
            { 
            
            }

        }

        /// <summary>
        /// click to exit the app
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        /// <summary>
        /// reset the entries
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReset_Click(object sender, EventArgs e)
        {
            SetDefault();
        }


        /// <summary>
        /// when selected, populate the entries
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvContacts_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvContacts.SelectedRows.Count > 0)  // if any of the rows is selected
            {
                int id = Convert.ToInt32(dgvContacts.SelectedRows[0].Cells[0].Value);
                // get me the first cell(id) in the  row

                Contact selectedContact = Contact.FindTheContact(ContactList, id);
                PopulateEntries(selectedContact);

                EditMode = true;
            }
            else
            { SetDefault(); }     // if nothing selected, set default (go empty)
        }

        #endregion

        #region custom methods

        /// <summary>
        /// populate the contact list in the datagrid view
        /// </summary>
        private void populateContactList()
        {
            dgvContacts.DataSource = null;
            dgvContacts.DataSource = ContactList;
            dgvContacts.ClearSelection();
        }


        /// <summary>
        /// se to default
        /// </summary>
        private void SetDefault()
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
            chkContacted.Checked = false;
            EditMode = false;
        }


        /// <summary>
        /// Populate the entries when selected
        /// </summary>
        /// <param name="selected"></param>
        private void PopulateEntries(Contact selected)
        {
            
            this.txtFirstName.Text = selected.FirstName;
            this.txtLastName.Text = selected.LastName;
            this.txtEmail.Text = selected.EmailAddress;
            this.txtPhone.Text = selected.PhoneNumber;
            this.chkContacted.Checked = selected.ContactStatus;
        }


        private bool InputValidaiton(string fName, string lName, string email, string phone)
        { 
            string outText = "";    // a string for output label
            bool retVal = true;     // return true if all the input is right
            List<TextBox> invalidBox = new List<TextBox>();     // to know which input is invalid

            if (fName == "")
            {
                outText += "You must enter a First Name\r\n";
                retVal = false;
                invalidBox.Add(txtFirstName);
            }
            if (lName == "")
            {
                outText += "You must enter a Last Name\r\n";
                retVal = false;
                invalidBox.Add(txtLastName);
            }
            if (emailValidate(email) == false || phoneValidation(phone) == false)
            {
                if (emailValidate(email) == false)
                {
                    outText += "Your e-mail address must be entered in a valid format\r\n";
                    invalidBox.Add(txtEmail);
                }
                if (phoneValidation(phone) == false)
                {
                    outText += "Your phone number must be entered in a valid format";
                    invalidBox.Add(txtPhone);
                }
                retVal = false;
            }

            if (retVal == false)          // Mouse cursor to the first invalid input text box
            {
                invalidBox.Reverse();     // the invalid input textbox to reverse order
                foreach (TextBox textBox in invalidBox)
                {
                    textBox.Select();     // mouse cursor to the first invalid text box
                }
            
 
            }

            lblOutput.Text = outText;    // display the error message in the output lable
            return retVal;
        }



        /// <summary>
        /// Regular expression used to validate a email address
        /// </summary>
        /// <param name="emailAddress"></param>
        /// <returns></returns>
        private bool emailValidate(string emailAddress)
        {
            var regex = @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z";
            bool isValid = Regex.IsMatch(emailAddress, regex, RegexOptions.IgnoreCase);
            return isValid;
        }

        /// <summary>
        /// Regular expression used to validate a phone number.
        /// </summary>
        private bool phoneValidation(string number)
        { 
            string motif = @"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$";
            if (number != null) return Regex.IsMatch(number, motif);
            else return false;
        }



        #endregion




    }
}
