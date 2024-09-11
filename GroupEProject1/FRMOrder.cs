using InventoryMaintenance;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

//AUTHOR: Shriya Poluru, Elvin Vanegas, Andy Zhu, Esther Chiu
//COURSE: ISTM 250.501
//FORM:FRMOrder
//PURPOSE: Allow for user to input  personal and delivery information
//then place customizable sandwich and pizza orders based on various quantities
//and calculate the order total.
//INPUT: Customer name, street address, city, state, zip code, subdivision
//phone number, food item, bread/crust options, quantity
//PROCESS: Arrays are utilized to store food, bread, and crust options.
//The form is dynamically updated based on user selections by showing and
//hiding images and enabling/disabling address fields.
//When user adds an item to the order, it is updated to the food list 
//then displayed in list box, user can copy the customer address to the 
//delivery address or edit it separately, validation is used to ensure
//that user enters correct inputs in appropriate fields.
//Also updates the inventory data.
//OUTPUT: Bread/crust type, food type, quantity, price and total in appropriate format. 
//If completed successfully an order will be placed.
//HONOR CODE: “On my honor, as an Aggie, I have neither given
// nor received unauthorized aid on this academic
// work.”


namespace GroupEProject1
{
    public partial class FRMOrder : Form
    {
        public FRMOrder()
        {
            InitializeComponent();
        }

        //creating two lists for the options of food
        //List<string> strFoodItems = new List<string>();
        //List<string> strBreadCrustOptions = new List<string>();

        //strFoodItems.Add("Ham & Swiss");

        //declare array to store food items
        string[] strFoodItems = { "Ham & Swiss Sandwich", "Turkey & Provolone Sandwich", "BLT Sandwich", "Med. Cheese Pizza", "Med. Pepperoni Pizza", "Med. Supreme Pizza" };
        //declare array to store bread options
        string[] strBreadOptions = { "White", "Pumpernickel", "Rye", "Sourdough", "Multigrain"};
        //declare array to store crust options
        string[] strCrustOptions = { "Original", "Pan", "Thin", "Wheat"};

        //declare and instantiate  food list from food class
        private List<Food> lstFoods = new List<Food>();

        //sandwich cost is a global variable
        decimal decSandwichCost = 5m;
        //pizza cost is a global variable
        decimal decPizzaCost = 9.5m;
        //tax rate is a global variable
        decimal decTaxRate = 0.0825m;


        #region FRMInventory Data

        //default information in 2 one dimensional arrays that hold the ingredients and ingredient inventory
        string[] strIngredients = {        "flour", "yeast", "sugar", "oil", "ham", "turkey", "scheese", "lettuce", "tomato", "bacon", "pickles", "mayo", "mustard", "pepprni", "sauce", "gcheese", "salt", "pepper" };
        decimal[] decIngredientInventory = {200m,     50m,     30m,    25m,   10m,    10m,      20m,        14m,      14m,      10m,      20m,      15m,     12m,       20m,      60m,      25m,     10m,     10m};


        //two dimensional array that holds how much of ingredient is used to make one sandwhich/pizza of a specific type
                                           //H&S,  T&P,   BLT,    Ch,    Pep,   Sup, 
        decimal[,] decIngredientsPerItem ={{ 1.00m, 1.00m, 1.00m, 3.00m, 3.00m, 3.00m },//flour
                                           { 0.50m, 0.500m,0.50m, 2.00m, 2.00m, 2.00m },//yeast
                                           { 0.03m, 0.03m, 0.03m, 0.5m,  0.5m,  0.5m  },//sugar
                                           { 0.05m, 0.05m, 0.05m, 0.10m, 0.10m, 0.10m },//oil
                                           { 0.10m, 0.00m, 0.00m, 0.00m, 0.00m, 0.10m },//ham
                                           { 0.00m, 0.10m, 0.00m, 0.00m, 0.00m, 0.10m },//turkey
                                           { 0.10m, 0.10m, 0.00m, 0.00m, 0.00m, 0.00m }, //scheese
                                           { 0.25m, 0.25m, 0.30m, 0.00m, 0.00m, 0.00m }, //lettuce
                                           { 0.25m, 0.25m, 0.30m, 0.00m, 0.00m, 0.30m }, //tomato
                                           { 0.00m, 0.00m, 0.10m, 0.00m, 0.00m, 0.10m }, //bacon
                                           { 0.02m, 0.02m, 0.00m, 0.00m, 0.00m, 0.00m }, //pickles
                                           { 0.02m, 0.02m, 0.02m, 0.00m, 0.00m, 0.00m }, //mayo
                                           { 0.02m, 0.02m, 0.02m, 0m,    0m,    0m,   },//mustard
                                           { 0.00m, 0.00m, 0.00m, 0.00m, 0.30m, 0.30m }, //pepprni
                                           { 0m,    0m,    0m,    1m,    1m,    1m    },//sauce
                                           { 0.00m, 0.00m, 0.00m, 0.30m, 0.20m, 0.20m },//gcheese
                                           { 0.01m, 0.01m, 0.01m, 0.02m, 0.02m, 0.02m },//salt
                                           { 0.01m, 0.01m, 0.01m, 0.02m, 0.02m, 0.02m }//pepper
        
        };



        /// <summary>
        /// fills in default information for the customer information 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BTNDefaultInfo_Click(object sender, EventArgs e)
        {
            TXTCustomerName.Text = "Ted Boone";
            TXTStreetAddress.Text = "4113 TAMU";
            TXTCity.Text = "College Station";
            TXTState.Text = "TX";
            TXTZipCode.Text = "77845";
            TXTSubdivision.Text = "Texas A&M Campus";
            TXTPhoneNumber.Text = "9798462322";

            RDOCarryout.Checked = true;
            TXTQuantity.Text = "1";
            
        }

        /// <summary>
        /// when clicked allows the user to see the most recent invenotry list
        /// Note: inventory is only updated when there is a successful complete order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BTNCheckInventory_Click(object sender, EventArgs e)
        {
            //creating and showing a new inventory form
            FRMInventory inventoryForm = new FRMInventory(strIngredients, decIngredientInventory);
            inventoryForm.Show();

            //cycles tthrough whatever food items are already ordered
            //for (int k = 0; k < lstFoods.Count; k++)
            //{
            //    //temporary variables that store the quanity and type of pizza/sandwhich
            //    int intTempQuantity = lstFoods[k].Quantity;
            //    string strTempName = lstFoods[k].FoodType;

            //    //
            //    for (int i = 0; i < decIngredientsPerItem.GetLength(0); i++)
            //    {
            //        for (int j = 0; j < decIngredientsPerItem.GetLength(1); j++)
            //        {

            //            for (int z = 0; z < CBXFoodItem.Items.Count; z++)
            //            {



            //            }

            //            //inventoryForm.LBXInventory.Items.Add(strIngredients[j] + ": " + decIngredientsPerItem[i, j]);


            //        }
            //    }

            //}

            // Display the updated inventory
            inventoryForm.DisplayUpdatedInventory();
        }



            #endregion









            #region Our Methods
            //Our Methods:

            /// <summary>
            /// fill the order item list box according to what the customer orders- the type of food, crust, price, and quantity
            /// </summary>
            /// </summary>
            private void FillOrderListBox() 
            {
                //first clear items in order items list box
                LBXOrderItems.Items.Clear();
                //add the items gathered through get display text method in food class 
                //this returns bread crust type, food type, quantity, price, and total
                foreach (Food food in lstFoods)
                {
                    LBXOrderItems.Items.Add(food.GetDisplayText());
                }
            }



        /// <summary>
        /// Makes everything in the delivery address group box read only.
        /// </summary>
        private void TurnReadOnly()
        {
            TXTDeliveryStreet.ReadOnly = true;
            TXTDeliveryCity.ReadOnly = true;
            TXTDeliveryZipCode.ReadOnly = true;
            TXTDeliveryState.ReadOnly = true;
            TXTDeliverySubDivision.ReadOnly = true;
            TXTDeliveryName.ReadOnly = true;
            TXTDeliveryPhoneNumber.ReadOnly = true;
        }

        /// <summary>
        /// Makes everything in the delivery address group box not read only so that 
        /// edits can be made in their fields.
        /// </summary>
        private void TurnEditable()
        {
            TXTDeliveryStreet.ReadOnly = false;
            TXTDeliveryCity.ReadOnly = false;
            TXTDeliveryZipCode.ReadOnly = false;
            TXTDeliveryState.ReadOnly = false;
            TXTDeliverySubDivision.ReadOnly = false;
            TXTDeliveryName.ReadOnly = false;
            TXTDeliveryPhoneNumber.ReadOnly = false;
        }

        /// <summary>
        /// clears all the text in delivery address groupbox
        /// </summary>
        private void ClearDeliveryAddressData()
        {
            TXTDeliveryName.Clear();
            TXTDeliveryStreet.Clear();
            TXTDeliveryCity.Clear();
            TXTDeliveryState.Clear();
            TXTDeliveryZipCode.Clear();
            TXTDeliverySubDivision.Clear();
            TXTDeliveryPhoneNumber.Clear();
        }

        /// <summary>
        /// Clears the data in all the textboxes of the delivery address groupbox
        /// </summary>
        private void ClearAllData()
        {
            //TXTDeliveryStreet.Clear();
            //TXTDeliveryCity.Clear();
            //TXTDeliveryZipCode.Clear();
            //TXTDeliveryState.Clear();
            //TXTDeliverySubDivision.Clear();

            //clearing all addresses
            TXTDeliveryName.Clear();
            TXTCustomerName.Clear();
            TXTDeliveryStreet.Clear();
            TXTStreetAddress.Clear();
            TXTDeliveryCity.Clear();
            TXTCity.Clear();
            TXTDeliveryState.Clear();
            TXTState.Clear();
            TXTDeliveryZipCode.Clear();
            TXTZipCode.Clear();
            TXTDeliverySubDivision.Clear();
            TXTSubdivision.Clear();
            TXTDeliveryPhoneNumber.Clear();
            TXTPhoneNumber.Clear();

            //resetting radio button
            RDODelivery.Checked = true;

            //resetting the checkbox
            CHKSameAsDelivery.Checked = false;

            //resetting order form textboxes
            TXTQuantity.Clear();
            TXTOrderTotal.Clear();
            TXTSubtotal.Clear();

            //resetting combobox indexes to 0
            CBXFoodItem.SelectedIndex = 0;
            CBXBreadCrustOption.SelectedIndex = 0;

            //clearing list boxes
            LBXOrderItems.Items.Clear();

            //clearng list
            lstFoods.Clear();


        }

        /// <summary>
        /// Copies the address over for delivery address groupbox
        /// </summary>
        public void CopyAddress()
        {
            //TXTDeliveryStreet.Text = TXTStreetAddress.Text.ToString();
            //TXTDeliveryCity.Text = TXTCity.Text.ToString();
            //TXTDeliveryState.Text = TXTState.Text.ToString();
            //TXTDeliveryZipCode.Text = TXTZipCode.Text.ToString();


            TXTDeliveryName.Text = TXTCustomerName.Text;
            TXTDeliveryName.Text = TXTCustomerName.Text;
            TXTDeliveryStreet.Text = TXTStreetAddress.Text;
            TXTDeliveryCity.Text = TXTCity.Text;
            TXTDeliveryState.Text = TXTState.Text;
            TXTDeliveryZipCode.Text = TXTZipCode.Text;
            TXTDeliverySubDivision.Text = TXTSubdivision.Text;
            TXTDeliveryPhoneNumber.Text = TXTPhoneNumber.Text;
        }

        /// <summary>
        /// deletes all the information from delivery address group box if 
        /// there is a change made to customer address group box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextChange(object sender, EventArgs e)
        {


            if(CHKSameAsDelivery.Checked == true)
            {
                CHKSameAsDelivery.Checked = false;
                CHKSameAsDelivery_CheckedChanged(sender, e);
            }
            //else if(CHKSameAsDelivery.Checked == false)
            //{

            //}


        }

        

        //private bool IsValidData()
        //{
        //    string strErrorMessage = "";

        //    if (strErrorMessage != "")//if we generated one or more validation errors
        //    {
        //        MessageBox.Show(strErrorMessage, "Input Error(s)");
        //        return false; // errors. Data input is invalid.
        //    }
        //    else
        //    {
        //        return true; //no errors. The data input is valid
        //    }
        //}

        /// <summary>
        /// Ensure that the inputs made to customer information section is valid
        /// </summary>
        /// <returns></returns>
        private bool IsValidData()
        {
            string strErrorMessage = "";

            //ensure that the customer name textbox has an input
            strErrorMessage += Validator.IsPresent(TXTCustomerName.Text, TXTCustomerName.Tag.ToString());
            //ensure that the street address textbox has an input
            strErrorMessage += Validator.IsPresent(TXTStreetAddress.Text, TXTStreetAddress.Tag.ToString());

            //ensure that the city textbox has an input
            strErrorMessage += Validator.IsPresent(TXTCity.Text, TXTCity.Tag.ToString());
            //ensure that the state textbox has an input
            strErrorMessage += Validator.IsPresent(TXTState.Text, TXTState.Tag.ToString());


            //strErrorMessage += Validator.IsCorrectCity(TXTCity.Text, TXTCity.Tag.ToString(), "Bryan", "College Station");
            ////strErrorMessage += Validator.IsCorrectState(TXTState.Text, TXTState.Tag.ToString(), "TX");

            //ensure that the zip code textbox input has 5 digits
            strErrorMessage += Validator.IsCorrectZip(TXTZipCode.Text, TXTZipCode.Tag.ToString());
            //ensure that the subdivision textbox has an input
            strErrorMessage += Validator.IsPresent(TXTSubdivision.Text, TXTSubdivision.Tag.ToString());
            //ensure that the phone number textbox input has 10 digits
            strErrorMessage += Validator.IsCorrectPhoneNumber(TXTPhoneNumber.Text, TXTPhoneNumber.Tag.ToString());

            //if (strErrorMessage != "")
            //{
            //    MessageBox.Show(strErrorMessage, "Input Error(s). Please enter valid information.");
            //    return false;//we do NOT validate
            //}

            //strErrorMessage += Validator.IsCorrectCity(TXTCity.Text, TXTCity.Tag.ToString(), "Bryan", "College Station");
            //strErrorMessage += Validator.IsCorrectState(TXTState.Text, TXTState.Tag.ToString(), "TX");

            //display error message if error message isnt empty
            if (strErrorMessage != "")
            {
                MessageBox.Show(strErrorMessage, "Input Error(s). Please enter valid information.");
                return false;//we do NOT validate
            }

            //if user wants delivery then delivery group boxes are validated
            if (RDODelivery.Checked == true)
            {
                strErrorMessage += Validator.IsPresent(TXTDeliveryName.Text, TXTDeliveryName.Tag.ToString());
                strErrorMessage += Validator.IsPresent(TXTDeliveryStreet.Text, TXTDeliveryStreet.Tag.ToString());
                strErrorMessage += Validator.IsCorrectCity(TXTDeliveryCity.Text, TXTDeliveryCity.Tag.ToString(), "Bryan", "College Station");
                strErrorMessage += Validator.IsCorrectState(TXTDeliveryState.Text, TXTDeliveryState.Tag.ToString(), "TX");
                strErrorMessage += Validator.IsCorrectZip(TXTDeliveryZipCode.Text, TXTDeliveryZipCode.Tag.ToString());
                strErrorMessage += Validator.IsPresent(TXTDeliverySubDivision.Text, TXTDeliverySubDivision.Tag.ToString());
                strErrorMessage += Validator.IsCorrectPhoneNumber(TXTDeliveryPhoneNumber.Text, TXTDeliveryPhoneNumber.Tag.ToString());

                //display error message if error message isnt empty
                if (strErrorMessage != "")
                {
                    MessageBox.Show(strErrorMessage, "Input Error(s). Please enter valid information.");
                    return false;//we do NOT validate
                }
            }
            //make sure quantity entered is an integer
            strErrorMessage += Validator.IsInteger(TXTQuantity.Text, TXTQuantity.Tag.ToString());

            //display error message if error message isnt empty
            if (strErrorMessage != "")
            {
                MessageBox.Show(strErrorMessage, "Input Error(s). Please enter valid information.");
                return false;//we do NOT validate
            }
            
            //make sure quantity is from 1-100
            strErrorMessage += Validator.IsWithinRange(TXTQuantity.Text, TXTQuantity.Tag.ToString(), 1m, 100m);

            //display error message if error message isnt empty
            if (strErrorMessage != "")
            {
                MessageBox.Show(strErrorMessage, "Input Error(s). Please enter valid information.");
                return false;//we do NOT validate
            }
            return true;

        }



        /// <summary>
        /// ensure that the inputs made to customer information section is valid for whn the use enters 
        /// the complete button.Main difference is that we don't check for quantity
        /// </summary>
        /// <returns></returns>
        private bool IsValidDataComplete()
        {
            string strErrorMessage = "";

            //ensure that the customer name textbox has an input
            strErrorMessage += Validator.IsPresent(TXTCustomerName.Text, TXTCustomerName.Tag.ToString());
            //ensure that the street address textbox has an input
            strErrorMessage += Validator.IsPresent(TXTStreetAddress.Text, TXTStreetAddress.Tag.ToString());

            //ensure that the city textbox has an input
            strErrorMessage += Validator.IsPresent(TXTCity.Text, TXTCity.Tag.ToString());
            //ensure that the state textbox has an input
            strErrorMessage += Validator.IsPresent(TXTState.Text, TXTState.Tag.ToString());


            //strErrorMessage += Validator.IsCorrectCity(TXTCity.Text, TXTCity.Tag.ToString(), "Bryan", "College Station");
            ////strErrorMessage += Validator.IsCorrectState(TXTState.Text, TXTState.Tag.ToString(), "TX");

            //ensure that the zip code textbox input has 5 digits
            strErrorMessage += Validator.IsCorrectZip(TXTZipCode.Text, TXTZipCode.Tag.ToString());
            //ensure that the subdivision textbox has an input
            strErrorMessage += Validator.IsPresent(TXTSubdivision.Text, TXTSubdivision.Tag.ToString());
            //ensure that the phone number textbox input has 10 digits
            strErrorMessage += Validator.IsCorrectPhoneNumber(TXTPhoneNumber.Text, TXTPhoneNumber.Tag.ToString());

            //if (strErrorMessage != "")
            //{
            //    MessageBox.Show(strErrorMessage, "Input Error(s). Please enter valid information.");
            //    return false;//we do NOT validate
            //}

            //strErrorMessage += Validator.IsCorrectCity(TXTCity.Text, TXTCity.Tag.ToString(), "Bryan", "College Station");
            //strErrorMessage += Validator.IsCorrectState(TXTState.Text, TXTState.Tag.ToString(), "TX");

            //display error message if error message isnt empty
            if (strErrorMessage != "")
            {
                MessageBox.Show(strErrorMessage, "Input Error(s). Please enter valid information.");
                return false;//we do NOT validate
            }

            //if user wants delivery then delivery group boxes are validated
            if (RDODelivery.Checked == true)
            {
                strErrorMessage += Validator.IsPresent(TXTDeliveryName.Text, TXTDeliveryName.Tag.ToString());
                strErrorMessage += Validator.IsPresent(TXTDeliveryStreet.Text, TXTDeliveryStreet.Tag.ToString());
                strErrorMessage += Validator.IsCorrectCity(TXTDeliveryCity.Text, TXTDeliveryCity.Tag.ToString(), "Bryan", "College Station");
                strErrorMessage += Validator.IsCorrectState(TXTDeliveryState.Text, TXTDeliveryState.Tag.ToString(), "TX");
                strErrorMessage += Validator.IsCorrectZip(TXTDeliveryZipCode.Text, TXTDeliveryZipCode.Tag.ToString());
                strErrorMessage += Validator.IsPresent(TXTDeliverySubDivision.Text, TXTDeliverySubDivision.Tag.ToString());
                strErrorMessage += Validator.IsCorrectPhoneNumber(TXTDeliveryPhoneNumber.Text, TXTDeliveryPhoneNumber.Tag.ToString());

                //display error message if error message isnt empty
                if (strErrorMessage != "")
                {
                    MessageBox.Show(strErrorMessage, "Input Error(s). Please enter valid information.");
                    return false;//we do NOT validate
                }
            }
            //make sure quantity entered is an integer
            //strErrorMessage += Validator.IsInteger(TXTQuantity.Text, TXTQuantity.Tag.ToString());

            //display error message if error message isnt empty
            //if (strErrorMessage != "")
            //{
            //    MessageBox.Show(strErrorMessage, "Input Error(s). Please enter valid information.");
            //    return false;//we do NOT validate
            //}

            //make sure quantity is from 1-100
            //strErrorMessage += Validator.IsWithinRange(TXTQuantity.Text, TXTQuantity.Tag.ToString(), 1m, 100m);

            //display error message if error message isnt empty
            if (strErrorMessage != "")
            {
                MessageBox.Show(strErrorMessage, "Input Error(s). Please enter valid information.");
                return false;//we do NOT validate
            }
            return true;

        }
        #endregion



        #region 4buttons

        /// <summary>
        /// Exits the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BTNClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// clears all data and resets form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BTNClearData_Click(object sender, EventArgs e)
        {
            ClearAllData();

        }

        /// <summary>
        /// Adds order to list box and updates subtotal and order total.
        /// Comboboxs and quantity text boxes are reset.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BTNAdd_Click(object sender, EventArgs e)
        {
            //add try catch block and vaildation

            //Food newFoodCandidate = Form.GetNewFood();

            //LBXOrderItems.Items.Add(newFoodCandidate.GetDisplayText());

            try
            {
                if (IsValidData())
                {
                    //string variable to store the food type
                    string strTypeTest = CBXFoodItem.Text;

                    //if (RDODelivery.Enabled == true)
                    //{
                        if (strTypeTest.IndexOf("Sandwich") >= 0)
                        {
                        //executes if the food type is a sandwhich
                            Food newFoodCandidate = new Food(CBXFoodItem.Text, CBXBreadCrustOption.Text, Convert.ToInt32(TXTQuantity.Text), decSandwichCost);//creating a new food item
                            if (newFoodCandidate != null) //if we got a product from the new product form
                            {
                                lstFoods.Add(newFoodCandidate);
                                FillOrderListBox();
                                TXTSubtotal.Clear();


                                decimal decSubtotal = 0m;// newFoodCandidate.Price * newFoodCandidate.Quantity;


                                foreach (Food food in lstFoods)
                                {
                                    //LBXOrderItems.Items.Add(food.GetDisplayText());

                                //subtotal of order updated and displayed
                                    decSubtotal += (food.Quantity * food.Price);
                                    TXTSubtotal.Text = decSubtotal.ToString("c");

                                //order total updated and displayed
                                    decimal decOrderTotal = decSubtotal * (1+decTaxRate);

                                
                                    TXTOrderTotal.Text = decOrderTotal.ToString("c");

                                }

                                //comboboxes and quanity reset
                                CBXFoodItem.SelectedIndex = 0;
                                CBXBreadCrustOption.SelectedIndex = 0;
                                TXTQuantity.Clear();
                                



                            }
                        }
                        else if (strTypeTest.IndexOf("Pizza") >= 0)
                        {
                        //executes if the food type is a pizza(most functionality same as above, main difference is price calculation)
                            Food newFoodCandidate = new Food(CBXFoodItem.Text, CBXBreadCrustOption.Text, Convert.ToInt32(TXTQuantity.Text), decPizzaCost);
                            if (newFoodCandidate != null) //if we got a product from the new product form
                            {
                                lstFoods.Add(newFoodCandidate);
                                FillOrderListBox();
                                TXTSubtotal.Clear();
                                decimal decSubtotal = 0m;// newFoodCandidate.Price * newFoodCandidate.Quantity;
                                foreach (Food food in lstFoods)
                                {
                                    //LBXOrderItems.Items.Add(food.GetDisplayText());

                                    decSubtotal += (food.Quantity * food.Price);
                                    TXTSubtotal.Text = decSubtotal.ToString("c");

                                    decimal decOrderTotal = decSubtotal * (1+decTaxRate);

                                    TXTOrderTotal.Text = decOrderTotal.ToString("c");
                                }

                                CBXFoodItem.SelectedIndex = 0;
                                CBXBreadCrustOption.SelectedIndex = 0;
                                TXTQuantity.Clear();
                        }
                        }
                    //}

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
        /// Completes and process the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BTNComplete_Click(object sender, EventArgs e)
        {
 

            try
            {
                if (IsValidDataComplete())
                {
                   

                    //if address data is stll valid then the form will progress

                    //data is cleared and order is "processed"

                    if (lstFoods.Count > 0)
                    {
                        MessageBox.Show("Thank you for ordering with us! Your order will be ready shortly.", "Order Complete");
                        
                        //updating inventory info:
                        
                        // Iterate through each food item in the order list
                        foreach (Food food in lstFoods)
                        {
                            int intQuantityOrdered = food.Quantity; // The quantity of the food ordered
                            int intFoodIndex = GetFoodIndex(food); // Get the index of the food in the 2D array

                            // Iterate through each ingredient
                            for (int i = 0; i < decIngredientsPerItem.GetLength(0); i++)
                            {
                                // Calculate the total amount of the ingredient needed for this food item
                                decimal decAmountUsed = decIngredientsPerItem[i, intFoodIndex] * intQuantityOrdered;

                                // Subtract the used amount from the corresponding inventory
                                decIngredientInventory[i] -= decAmountUsed;
                            }
                        }
                        ClearAllData();//clearing all the data
                    }
                    else
                    {
                        MessageBox.Show("Please add atleast 1 item to your order.");
                    }

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
        /// Helper function to get the index of a food type in the 2D array
        /// </summary>
        /// <param name="food"></param>
        /// <returns></returns>
        private int GetFoodIndex(Food food)
        {
            // Define the food types in order
            //string[] foodTypes = { "Ham and Swiss", "Turkey and Provolone", "BLT",
            //               "Medium Cheese Pizza", "Medium Pepperoni Pizza", "Medium Supreme Pizza" };

            // Return the index of the food type in the array
            return Array.IndexOf(strFoodItems, food.FoodType);
        }

        #endregion


        /// <summary>
        /// Since only two radio buttons are used as long as one radio button is changed the other one is also changed.
        /// If user checks the carryout radio button then nothing in delivery address is enabled. If the user wants a delivery 
        /// then the delivery groupbox is enabled so that edits can be made.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RDOCarryout_CheckedChanged(object sender, EventArgs e)
        {
            //if (RDOCarryout.Checked == false)
            //{
            //    if (CBXDeliveryAddress.Checked == true)
            //    {
            //        TurnReadOnly();
            //        CopyAddress();
            //    }
            //    else
            //    {
            //        TurnEditable();
            //        ClearData();
            //    }
            //}

            //disable delivery address group box if carryout radio button is checked
            if (RDOCarryout.Checked == true) 
            {

                ClearDeliveryAddressData();
                CHKSameAsDelivery.Checked = false;
                CHKSameAsDelivery.Enabled = false;
                GBXDeliveryAddress.Enabled = false;


               
            }
            //enable delivery address group box if carryout radio button is not checked
            else if (RDOCarryout.Checked == false)
            {
                GBXDeliveryAddress.Enabled = true;
                CHKSameAsDelivery.Enabled = true;
            }
        }




        /// <summary>
        /// If the delivery and customer address same checkbox is checked, the customer address is copied into the delivery address
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CHKSameAsDelivery_CheckedChanged(object sender, EventArgs e)
        {
            if(CHKSameAsDelivery.Checked == true)
            {
                //TXTDeliveryName.Text = TXTCustomerName.Text;
                //TXTDeliveryStreet.Text = TXTStreetAddress.Text;
                //TXTDeliveryCity.Text = TXTCity.Text;
                //TXTDeliveryState.Text = TXTState.Text;
                //TXTDeliveryZipCode.Text = TXTZipCode.Text;
                //TXTDeliverySubDivision.Text = TXTSubdivision.Text;
                //TXTDeliveryPhoneNumber.Text = TXTPhoneNumber.Text;

                //call copy address method to copy the customer address to delivery address group box
                CopyAddress();
                TurnReadOnly();
            }
            else
            {
                TurnEditable();
                ClearDeliveryAddressData();
            }
        }

       

        /// <summary>
        /// Loading up the combo boxes when the form is loaded
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FRMOrder_Load(object sender, EventArgs e)
        {
            //clear any items from food item combo box 
            CBXFoodItem.Items.Clear();

            //populate the food item combo box with each food item listed in food item array
            foreach (string foodItem in strFoodItems)
            {
                CBXFoodItem.Items.Add(foodItem);
            }
            //make the default selection in the  food item combo box as the first item
            CBXFoodItem.SelectedIndex = 0;
            //clear any items from bread crust combo box 
            CBXBreadCrustOption.Items.Clear();
            //populate the crust option combo box with each crust option listed in bread option array
            foreach (string bread in strBreadOptions)
            {
                CBXBreadCrustOption.Items.Add(bread);
            }
            //make the default selection in the bread crust option combo box as the first item
            CBXBreadCrustOption.SelectedIndex = 0;
            //make the deli picture visible upon form load
            PBXDeli.Visible = true;
            //hide the pizza picture so only the deli picture shows
            PBXPizza.Visible = false;

        }


        /// <summary>
        /// When the selected index is changed in the food item combo box the respective appropriate 
        /// bread/crust options are displayed along with the correct picture
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CBXFoodItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            //get item type selected in food item combo box
            string strTypeTest = CBXFoodItem.Text;
            //if the user chooses a sandwich option
            if (strTypeTest.IndexOf("Sandwich") >= 0)
            {
                //first clear bread crust combo box
                CBXBreadCrustOption.Items.Clear();
                //populate the bread crust combo box with bread options
                foreach (string bread in strBreadOptions)
                {
                    CBXBreadCrustOption.Items.Add(bread);
                }
                //make the default selection in the bread crust option combo box as the first item
                CBXBreadCrustOption.SelectedIndex = 0;

                //make the deli picture visible
                PBXDeli.Visible = true;
                //hide the pizza picture so only the deli picture shows
                PBXPizza.Visible = false;


            }
            //if the user chooses a pizza option
            else if (strTypeTest.IndexOf("Pizza") >= 0)
            {
                //first clear bread crust combo box
                CBXBreadCrustOption.Items.Clear();
                //populate the bread crust combo box with crust options
                foreach (string crust in strCrustOptions)
                {
                    CBXBreadCrustOption.Items.Add(crust);
                }
                //make the default selection in the bread crust option combo box as the first item
                CBXBreadCrustOption.SelectedIndex = 0;

                //hide the deli picture so only the pizza picture shows
                PBXDeli.Visible = false;
                //make the pizza picture visible
                PBXPizza.Visible = true;
            }



        }


        /// <summary>
        /// displays the vendor form to the user
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BTNDisplayVendors_Click(object sender, EventArgs e)
        {

            FRMVendor vendorForm = new FRMVendor();
            vendorForm.ShowDialog();

            


            //creating and showing a new inventory form
            //FRMInventory inventoryForm = new FRMInventory(strIngredients, decIngredientInventory);
            //inventoryForm.Show();

            //inventoryForm.DisplayUpdatedInventory();
        }
    }
}
