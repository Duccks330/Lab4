// Name: Adam Lamoureu
// Date: 11/25/2023
// Description: A program that logs contant information and the state of if someone has been contacted yet

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Drawing.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        // Verifies user inputs and returns validation code (0 = invalid, 1 = email valid, 2 = phone valid, 3 = both valid
        private static int CheckUserInputs(String RawEmail, String RawPhone)
        {
            int ValidationCode = 0;
            //check if either the email or phone number is inputted
            if (RawEmail != null || RawPhone != null)
            {
                if (RawEmail != null)
                {

                    //https://www.tutorialsteacher.com/articles/validate-email-in-csharp
                    string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

                    // Uses Regex to verify email and returns true if email is valid
                    Regex regex = new Regex(emailPattern);
                    if (regex.IsMatch(RawEmail) == true)
                    {
                        // sets validation code to 1 for valid email
                        ValidationCode = 1;
                    }

                    // If phone isn't null verify phone
                }
                if (RawPhone != null)
                {
                    string PhonePattern = @"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$";

                    // Uses Regex to verify phone and returns true if email is valid
                    Regex regex = new Regex(PhonePattern);
                    if (regex.IsMatch(RawPhone) == true)
                    {
                        // Continues processing if the email has already been validated
                        if (ValidationCode == 1)
                        {
                            ValidationCode = 3;
                        }
                        else if (ValidationCode == 0)
                        {
                            // sets validation code to 2 for valid phone number
                            ValidationCode = 2;
                        }
                    }
                    // returns false if both the emailand phone number are empty
                    else
                    {
                        if (ValidationCode == 0)
                        {
                            //Only updates the validation code if the email verification hasn't been updated
                            ValidationCode = 0;
                        }
                    }
                }
            }

            // return the final validation code
            // 0 - invalid - no input, invalid email, invalid phone
            // 1 - valid email only
            // 2 - valid phone only
            // 3 - valid email and phone
            return ValidationCode;

        }

            public Form1()
        {
            InitializeComponent();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            // Generates the variables that will be used to process the inputted information

            string FirstName = textBoxFirstName.Text.Trim();
            string LastName = textBoxLastName.Text.Trim();
            string Email = textBoxEmail.Text.Trim();
            string Phone = textBoxPhone.Text.Trim();
            bool Contacted = checkBoxContacted.Checked;
            // Bool used to keep track of added profiles
            bool AllAdded = false;
            // int used to get verification code for email and phone num
            int VerificationCode;

            // Verify Email and phone number
            VerificationCode = CheckUserInputs(Email, Phone);

            if (VerificationCode == 0)
            {
                // IF NO VALID EMAIL OR PHONE
                listBoxResult.Items.Add("You have not entered either a valid email or phone number ");

            }else if (VerificationCode == 1)
            {
                // CREATE EMAIL ONLY SAVE

                // creates new customer object
                Customer customer = new Customer(FirstName, LastName, Email, Phone, Contacted);

                // makes sure the list view has checkboxes
                listViewOutput.CheckBoxes = true;

                //creates new customer output with object
                ListViewItem output = new ListViewItem(new[] { "", FirstName, LastName, Email, " ", customer.Date.ToString() }) ;

                // if the person has already contacted will check the value
                if (Contacted) { output.Checked = true; }
                else { output.Checked = false; }

                // final add item
                listViewOutput.Items.Add(output);
            }
            else if (VerificationCode == 2)
            {
                // CREATE PHONE ONLY SAVE

                // creates new customer object
                Customer customer = new Customer(FirstName, LastName, Email, Phone, Contacted);

                // makes sure the list view has checkboxes
                listViewOutput.CheckBoxes = true;

                //creates new customer output with object
                ListViewItem output = new ListViewItem(new[] { "", FirstName, LastName, " ", Phone, customer.Date.ToString() });

                // if the person has already contacted will check the value
                if (Contacted) { output.Checked = true; }
                else { output.Checked = false; }

                // final add item
                listViewOutput.Items.Add(output);

            }
            else if(VerificationCode == 3)
            {
                //CREATE EMAIL AND PHONE SAVE

                // creates new customer object
                Customer customer = new Customer(FirstName, LastName, Email, Phone, Contacted);

                // makes sure the list view has checkboxes
                listViewOutput.CheckBoxes = true;

                //creates new customer output with object
                ListViewItem output = new ListViewItem(new[] { "", FirstName, LastName, Email, Phone, customer.Date.ToString() });

                // if the person has already contacted will check the value
                if (Contacted) { output.Checked = true; }
                else { output.Checked = false; }

                // final add item
                listViewOutput.Items.Add(output);
            }
            








            while(AllAdded) 
            {

            }

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void listViewOutput_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {

        }

        private void labelContacted_Click(object sender, EventArgs e)
        {

        }

        private void textBoxLastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelPhoneNumber_Click(object sender, EventArgs e)
        {

        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelEmailAddress_Click(object sender, EventArgs e)
        {

        }

        private void labelLastName_Click(object sender, EventArgs e)
        {

        }

        private void labelFirstName_Click(object sender, EventArgs e)
        {

        }
    }
}
