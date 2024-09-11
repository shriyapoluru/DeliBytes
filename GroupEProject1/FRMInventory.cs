using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//AUTHOR: Shriya Poluru, Elvin Vanegas, Andy Zhu, Esther Chiu
//COURSE: ISTM 250.501
//FORM:FRMInventory
//PURPOSE: Allow for inventory of the deli to be stored and changed based on orders.
//INPUT: Arrays and other information from FRMOrder
//PROCESS: Gathers data and uses a for loop to loop through one dimensional array.
//Also creates a string variable with the correct syntax so that it is ready
//to be loaded into the listbox.
//OUTPUT:LBXInventory is loaded up with the correct inventory numbers and items
//HONOR CODE: “On my honor, as an Aggie, I have neither given
// nor received unauthorized aid on this academic
// work.”

namespace GroupEProject1
{
    public partial class FRMInventory : Form
    {
        // Declare instance variables for the arrays
        private string[] strIngredientsArray;
        private decimal[] decIngredientsInventoryArray;

        /// <summary>
        /// constructor that assigns the two arrays from the Order form to arrays
        /// usable in this class whenever this constructor is called from the Order form
        /// </summary>
        /// <param name="strIngredients"></param>
        /// <param name="decIngredientInventory"></param>
        public FRMInventory(string[] strIngredients, decimal[] decIngredientInventory)
        {
            strIngredientsArray = strIngredients;
            decIngredientsInventoryArray = decIngredientInventory;

            InitializeComponent();
        }

        /// <summary>
        /// Closes the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BTNClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// will display the updated inventory to the LBXInventory list box
        /// </summary>
        public void DisplayUpdatedInventory()
        {
            // Clear the existing items in the listbox
            LBXInventory.Items.Clear();

            // Iterate through each ingredient
            for (int i = 0; i < strIngredientsArray.Length; i++)
            {
                // Get the name of the ingredient and the remaining amount
                string strIngredientName = strIngredientsArray[i];
                decimal decRemainingAmount = decIngredientsInventoryArray[i];

                // Create a string displaying the ingredient and the remaining amount
                string strDisplayText = strIngredientName + ": " + decRemainingAmount + " units";

                // Add the string to the listbox
                LBXInventory.Items.Add(strDisplayText);
            }
        }

    }
}
