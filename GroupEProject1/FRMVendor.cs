using InventoryMaintenance;
using ISYS250HW;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

//AUTHOR: Shriya Poluru, Elvin Vanegas, Andy Zhu, Esther Chiu
//COURSE: ISTM 250.501
//FORM:FRMVendor
//PURPOSE: Allow for user to edit,save, and see vendor information
//INPUT: Vendor name, street address, city, state, zip code,
//phone number,YTD, sales rep name, comments, and default discount
//PROCESS: Uses Vendor.cs and Vendor.DB and an xml file to have long term storage of
//of the data. Uses multiple methods and validation to help user cycle through and 
//update vendor data.
//OUTPUT: Vendor data is successfully updated and displayed to the user
//even after the program closes and is opened up at a later date and time
//HONOR CODE: “On my honor, as an Aggie, I have neither given
// nor received unauthorized aid on this academic
// work.”

namespace GroupEProject1
{
    public partial class FRMVendor : Form
    {
        //creating a list to store vendor information
        private List<Vendor> lstVendors = null;
        private int intCurrentIndex;//going to store whatever index we are on
        public FRMVendor()
        {
            InitializeComponent();
            this.ControlBox = false;//getting ride of control box on the top right of the form
        }

        /// <summary>
        /// populates the vendor form with accurate information
        /// </summary>
        /// <param name="index"></param>
        private void PopulateForm(int index)
        {
            //gets the vendor at the specified index
            Vendor vendor = lstVendors[index];
            // Populates form fields with vendor information
            TXTVendorName.Text = vendor.Name;
            TXTVendorStreetAddress.Text = vendor.Address;
            TXTVendorCity.Text = vendor.City;
            TXTVendorState.Text = vendor.State;
            TXTVendorZipCode.Text = vendor.Zip;
            TXTVendorPhoneNumber.Text = vendor.Phone;
            TXTVendorSalesYearToDate.Text = vendor.YTD.ToString();
            TXTVendorComments.Text = vendor.Comment;
            TXTVendorSalesRepresentativeName.Text = vendor.Contact;
            CBXVendorDefaultDiscount.Items.Clear();
            CBXVendorDefaultDiscount.Items.Add("10 days");
            CBXVendorDefaultDiscount.Items.Add("15 days");
            CBXVendorDefaultDiscount.Items.Add("20 days");
            CBXVendorDefaultDiscount.SelectedIndex = 0;

            // Calculate the combo box index based on DefaultDiscount using a switch statement
            int intDefaultDiscountIndex = 0;
            switch (vendor.DefaultDiscount)
            {
                case 10:
                    intDefaultDiscountIndex = 0; // For 10 days since that is where the current index would be
                    break;
                case 15:
                    intDefaultDiscountIndex = 1; // For 15 days
                    break;
                case 20:
                    intDefaultDiscountIndex = 2; // For 20 days
                    break;
                default:
                    intDefaultDiscountIndex = 0; // Default to 10 days if unknown value
                    break;
            }

            // Set the selected index of the combo box
            CBXVendorDefaultDiscount.SelectedIndex = intDefaultDiscountIndex;
        }

        /// <summary>
        /// What happens when the vendor form is loaded
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FRMVendor_Load(object sender, EventArgs e)
        {
            //clearing the combobox
            CBXVendorDefaultDiscount.Items.Clear();
            // Loading vendor data from XML file
            lstVendors = VendorDB.GetVendors();

            // updating the current index
            intCurrentIndex = 0;
            // Populating the form with the first vendor's information
            PopulateForm(intCurrentIndex);


            //FillVendorForm();
            //VendorDB.SaveVendors();

            //foreach (Vendor p in lstVendors)
            //{
            //    TXTVendorName.Text = p.Name;
            //}
        }


        //private void FillVendorForm()
        //{
        //    TXTVendorName

        //    LBXProducts.Items.Clear();
        //    foreach (Product p in lstProducts)
        //    {
        //        LBXProducts.Items.Add(p.GetDisplayText("\t"));//with tab key
        //    }
        //}

            //// Check for unsaved changes
            //if (CheckForUnsavedChanges())
            //{
            //    // Prompt the user to save changes
            //    DialogResult result = MessageBox.Show(
            //    "There are unsaved changes. Would you like to save them?",
            //    "Save Changes",
            //    MessageBoxButtons.YesNoCancel,
            //    MessageBoxIcon.Warning
            //    );

            //    if (result == DialogResult.Yes)
            //    {
            //        // Save the current vendor data
            //        SaveCurrentVendorData();
            //    }
            //    else if (result == DialogResult.Cancel)
            //    {
            //        // User canceled the navigation
            //        return;
            //    }
            //    // If the user chose "No", we can proceed without saving
            //}

            //this.Close();

            //if (CheckForUnsavedChanges())
            //{
            //    this.Close();
            //}
            //else
            //{
            //    this.Close();
            //}
            //if (CheckForUnsavedChanges())
            //{
            //    DialogResult result = MessageBox.Show(
            //        "There are unsaved changes. Would you like to save them?",
            //        "Save Changes",
            //        MessageBoxButtons.YesNoCancel,
            //        MessageBoxIcon.Warning);

            //    if (result == DialogResult.Yes)
            //    {
            //        if (CheckForUnsavedChanges())
            //        {
            //            // Save the current vendor data
            //            SaveCurrentVendorData();
            //        }
            //    }
            //    else if (result == DialogResult.Cancel)
            //    {
            //        // User canceled the navigation
            //        e.Cancel = true;
            //    }
            //    // If the user chose "No", we can proceed with navigation without saving
            //}
            //else
            //{
            //    this.Close();
            //}
            //bool boolValidData = true;
            //// Check for unsaved changes
            //if (CheckForUnsavedChanges())
            //{
            //    // Prompt the user to save changes
            //    DialogResult result = MessageBox.Show(
            //    "There are unsaved changes. Would you like to save them?",
            //    "Save Changes",
            //    MessageBoxButtons.YesNoCancel,
            //    MessageBoxIcon.Warning
            //    );

            //    if (result == DialogResult.Yes)
            //    {
            //        // Save the current vendor data
            //        if (IsValidDataVendors())
            //        {
            //            SaveCurrentVendorData();
            //            this.Close();
            //        }
            //    }
            //    else if (result == DialogResult.Cancel)
            //    {
            //        // User canceled the navigation
            //        return;
            //    }
            //    //else if (result == DialogResult.No)
            //    //{
            //    //    this.Close();
            //    //}
            //    //// If the user chose "No", we can proceed with navigation without saving
            //}
            ////else
            ////{
            ////    this.Close();
            ////}

        /// <summary>
        /// what happens when the Next record button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BTNNextRecord_Click(object sender, EventArgs e)
        {
            bool boolValidData = true;
            // Check for unsaved changes
            if (CheckForUnsavedChanges())
            {
                // Prompts the user to save changes
                DialogResult result = MessageBox.Show( "There are unsaved changes. Would you like to save them?","Save Changes", 
                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning );

                if (result == DialogResult.Yes)//if they click yes
                {
                    if (IsValidDataVendors())//if the data passes validation
                    {
                        // Save the current vendor data
                        SaveCurrentVendorData();
                        //intCurrentIndex++;
                        if (intCurrentIndex >= lstVendors.Count)
                        {
                            intCurrentIndex = 0; // Loops back to the beginning
                        }

                        // Populate the form with the next record's data
                        PopulateForm(intCurrentIndex);
                    }
                    else//if the data is not valid then the bool is changed to false and the data is not saved
                    {
                        boolValidData = false;
                    }
                }
                else if (result == DialogResult.Cancel)//keep the form open
                {
                    // User canceled the navigation
                    return;
                }
                // If the user choses "No", we proceed by not saving the form and closing it
            }
            if (boolValidData == true)//only occurs if successfully validated and saved
            {
                // Navigates to the next record
                intCurrentIndex++;
                if (intCurrentIndex >= lstVendors.Count)
                {
                    intCurrentIndex = 0; // Loops back to the beginning
                }

                // Populate the form with the next record's data
                PopulateForm(intCurrentIndex);
            }
        }

        /// <summary>
        /// what happens when the user clicks the Previous record button.
        /// very similar to next record button function
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BTNPreviousRecord_Click(object sender, EventArgs e)
        {
            bool boolValidData = true;
            // Checks for unsaved changes
            if (CheckForUnsavedChanges())
            {
                // Prompts the user to save changes
                DialogResult result = MessageBox.Show("There are unsaved changes. Would you like to save them?", "Save Changes",
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    // Save the current vendor data
                    if (IsValidDataVendors())//if passes validation
                    {
                        SaveCurrentVendorData();
                        //intCurrentIndex--;
                        if (intCurrentIndex < 0)
                        {
                            intCurrentIndex = lstVendors.Count - 1; // Loop back to the end
                        }
                        PopulateForm(intCurrentIndex);
                    }
                    else//if validation fails this bool is changed to false 
                    {
                        boolValidData = false;
                    }
                }
                else if (result == DialogResult.Cancel)
                {
                    // User canceled the navigation
                    return;
                }
                // If the user chose "No", we can proceed with navigation without saving
            }
            if (boolValidData == true)//only if validated and saved
            {
                intCurrentIndex--;
                if (intCurrentIndex < 0)
                {
                    intCurrentIndex = lstVendors.Count - 1; // Loops back to the end
                }
                PopulateForm(intCurrentIndex);
            }
        }

        /// <summary>
        /// will check to see if the user made any changes to the data
        /// </summary>
        /// <returns></returns>
        private bool CheckForUnsavedChanges()
        {
            try
            {
                //establishes the current vendor that we are working with
                Vendor currentVendor = lstVendors[intCurrentIndex];
                // Compares each form field with the current vendor object properties
                bool boolHasChanges = false;

                // Checks vendor name
                if (TXTVendorName.Text != currentVendor.Name)
                {
                    boolHasChanges = true;
                }

                // Checks address
                if (TXTVendorStreetAddress.Text != currentVendor.Address)
                {
                    boolHasChanges = true;
                }

                // Checks city
                if (TXTVendorCity.Text != currentVendor.City)
                {
                    boolHasChanges = true;
                }

                // Checks state
                if (TXTVendorState.Text != currentVendor.State)
                {
                    boolHasChanges = true;
                }

                // Checks zip code
                if (TXTVendorZipCode.Text != currentVendor.Zip)
                {
                    boolHasChanges = true;
                }

                // Checks phone number
                if (TXTVendorPhoneNumber.Text != currentVendor.Phone)
                {
                    boolHasChanges = true;
                }

                // Checks year-to-date sales
                if (TXTVendorSalesYearToDate.Text != currentVendor.YTD.ToString())
                {
                    boolHasChanges = true;
                }

                // Checks comments
                if (TXTVendorComments.Text != currentVendor.Comment)
                {
                    boolHasChanges = true;
                }

                // Checks contact name
                if (TXTVendorSalesRepresentativeName.Text != currentVendor.Contact)
                {
                    boolHasChanges = true;
                }

                // Checks default discount
                // Converts the current vendor's discount to a string format to match the combobox options
                string strCurrentDiscountString = currentVendor.DefaultDiscount.ToString() + " days";
                if (CBXVendorDefaultDiscount.SelectedItem.ToString() != strCurrentDiscountString)
                {
                    boolHasChanges = true;
                }

                // Return true if any of the form fields have unsaved changes, otherwise false
                return boolHasChanges;
            }
            
            catch (OverflowException)
            {
                MessageBox.Show("One or more of your inputs is too large. \n Please try again.");
            }
            catch
            {
                MessageBox.Show("An unexpected error occurred. \n Please try again.");
            }

            return false;
        }

        /// <summary>
        /// when user clicks the save button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BTNSave_Click(object sender, EventArgs e)
        {
            //if the data is valid then the updated data is saved 
            if (IsValidDataVendors()) { 
            SaveCurrentVendorData();
            }
        }

        /// <summary>
        /// this is what is actually saving the data.
        /// there is a try catch block and validation
        /// </summary>
        private void SaveCurrentVendorData()
        {
            try//try catch block
            {


                if (IsValidDataVendors())//if the data is valid
                {
                    // Extracts the numerical part of the default discount
                    string strSelectedDiscount = CBXVendorDefaultDiscount.SelectedItem.ToString();
                    int intDefaultDiscountValue = int.Parse(strSelectedDiscount.Split(' ')[0]); // Splits the string and parses the first part
                                                                                             // Retrieves the current vendor data from the form
                                //updating all the data for the vendor 
                    lstVendors[intCurrentIndex].Name = TXTVendorName.Text;
                    lstVendors[intCurrentIndex].Address = TXTVendorStreetAddress.Text;
                    lstVendors[intCurrentIndex].City = TXTVendorCity.Text;
                    lstVendors[intCurrentIndex].State = TXTVendorState.Text;
                    lstVendors[intCurrentIndex].Zip = TXTVendorZipCode.Text;
                    lstVendors[intCurrentIndex].Phone = TXTVendorPhoneNumber.Text;
                    lstVendors[intCurrentIndex].YTD = Convert.ToInt64(TXTVendorSalesYearToDate.Text);
                    lstVendors[intCurrentIndex].Comment = TXTVendorComments.Text;
                    lstVendors[intCurrentIndex].Contact = TXTVendorSalesRepresentativeName.Text;
                    lstVendors[intCurrentIndex].DefaultDiscount = intDefaultDiscountValue;//(int)(Convert.ToDecimal(CBXVendorDefaultDiscount.SelectedItem.ToString()));

                    // Saves the updated vendors list to the XML file using the VendorDb.cs
                    VendorDB.SaveVendors(lstVendors);

                    // Notifys the user that the save was successful
                    MessageBox.Show("Vendor information saved successfully.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (OverflowException)
            {
                MessageBox.Show("One or more of your inputs is too large. \n Please try again.");
            }
            catch
            {
                MessageBox.Show("An unexpected error occurred. \n Please try again.");
            }

        }


        /// <summary>
        /// checks if the data is valid using validator.cs
        /// </summary>
        /// <returns></returns>
        private bool IsValidDataVendors()
        {
               string strErrorMessage = "";

               //using Validator.cs
               strErrorMessage += Validator.IsPresent(TXTVendorName.Text, TXTVendorName.Tag.ToString());
               strErrorMessage += Validator.IsPresent(TXTVendorStreetAddress.Text, TXTVendorStreetAddress.Tag.ToString());
               strErrorMessage += Validator.IsPresent(TXTVendorCity.Text, TXTVendorCity.Tag.ToString());
               strErrorMessage += Validator.IsPresent(TXTVendorState.Text, TXTVendorState.Tag.ToString());
               strErrorMessage += Validator.IsPresent(TXTVendorZipCode.Text, TXTVendorZipCode.Tag.ToString());//in original xml file there were spaces and letters in a zip code
               strErrorMessage += Validator.IsCorrectPhoneNumberVendor(TXTVendorPhoneNumber.Text, TXTVendorPhoneNumber.Tag.ToString());//in original xml file phone numbers were 9 or 10 digits
               strErrorMessage += Validator.IsInteger(TXTVendorSalesYearToDate.Text, TXTVendorSalesYearToDate.Tag.ToString());
               //strErrorMessage += Validator.IsPresent(TXTVendorComments.Text, TXTVendorComments.Tag.ToString()); //in original xml file some vednors didn't have comments, so comments don't need to be present
               strErrorMessage += Validator.IsPresent(TXTVendorSalesRepresentativeName.Text, TXTVendorSalesRepresentativeName.Tag.ToString());


               //displays error message if error message isnt empty
               if (strErrorMessage != "")
               {
                    MessageBox.Show(strErrorMessage, "Input Error(s). Please enter valid information.");
                    return false;//we do NOT validate
               }
               return true;
         }

        /// <summary>
        /// what happens when the close button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BTNClose_Click(object sender, EventArgs e)
        {
            //if (CheckForUnsavedChanges())
            //{
            //    this.Close();
            //}
            //else
            //{
            //    this.Close();
            //}
            if (CheckForUnsavedChanges())//if there are unsaved changes
            {
                DialogResult result = MessageBox.Show(
                    "There are unsaved changes. Would you like to save them?",
                    "Save Changes",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)//if they want to save data
                {
                    //if (CheckForUnsavedChanges())
                    //{
                    // Save the current vendor data
                    if (IsValidDataVendors())//if data passes validation
                    {
                        SaveCurrentVendorData();//data saved 
                        this.Close();//form closed
                    }
                }
                else if(result == DialogResult.No)//if they don't want to save the form is clsoed without saving
                {

                    this.Close();
                }
                //else if (result == DialogResult.Cancel)
                //{
                //    // User canceled the navigation
                //    e.Cancel = true;
                //}
                // If the user chose "No", we can proceed with navigation without saving
            }
            else//if the user didn't make any changes then the form is closed without any prompts/messages
            {
                this.Close();
            }
        }

        //private void FRMVendor_FormClosing(object sender, FormClosingEventArgs e)
        //{
        //    //if (CheckForUnsavedChanges())
        //    //{
        //    //    DialogResult result = MessageBox.Show(
        //    //        "There are unsaved changes. Would you like to save them?",
        //    //        "Save Changes",
        //    //        MessageBoxButtons.YesNoCancel,
        //    //        MessageBoxIcon.Warning);

        //    //    if (result == DialogResult.Yes)
        //    //    {
        //    //        if (CheckForUnsavedChanges())
        //    //        {
        //    //            // Save the current vendor data
        //    //            SaveCurrentVendorData();
        //    //        }
        //    //    }
        //    //    else if (result == DialogResult.Cancel)
        //    //    {
        //    //        // User canceled the navigation
        //    //        e.Cancel = true;
        //    //    }
        //    //    // If the user chose "No", we can proceed with navigation without saving
        //    //}
        //    //else
        //    //{
        //    //    this.Close();
        //    //}
        //}
    }
}
