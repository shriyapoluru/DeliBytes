using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupEProject1
{
    internal class Food
    {

        //setting up a new class
        private string foodType;
        private string breadCrustType;
        private int quantity;
        private decimal price;

        private Food newFoodCandidate = null;

        public Food GetNewFood()
        {
            return newFoodCandidate;
        }

        public Food() { }


        /// <summary>
        /// constructor that receives food type, bread crust type, quantity, and price
        /// </summary>
        /// <param name="foodType"></param>
        /// <param name="breadCrustType"></param>
        /// <param name="quantity"></param>
        /// <param name="price"></param>
        public Food(string foodType, string breadCrustType, int quantity, decimal price)
        {
            this.FoodType = foodType;
            this.BreadCrustType = breadCrustType;
            this.Quantity = quantity;
            this.Price = price;

        }

        public string FoodType
        {
            //when user asks for information, it is retrieved from food type variable
            get
            {
                return foodType;
            }
            //when user gives information, it is stored in food type variable
            set
            {
                foodType = value;
            }
        }

        public string BreadCrustType
        {
            //when user asks for information, it is retrieved from bread crust type variable
            get
            {
                return breadCrustType;
            }
            //when user gives information, it is stored in bread crust type variable
            set
            {
                breadCrustType = value;
            }
        }

        public int Quantity
        {
            //when user asks for information, it is retrieved from quantity variable
            get
            {
                return quantity;
            }
            //when user gives information, it is stored in quantity variable
            set
            {
                quantity = value;
            }
        }

        public decimal Price
        {
            //when user asks for information, it is retrieved from price variable
            get
            {
                return price;
            }
            //when user gives information, it is stored in price variable
            set
            {
                price = value;
            }
        }

        /// <summary>
        ///  return the bread crust type, food type, quantity, price and total in appropriate format
        /// </summary>
        /// <returns></returns>
        public string GetDisplayText()
        {
            return breadCrustType + " " + foodType + ", " + quantity.ToString() + "@" + price.ToString("c") + ", total: " + (quantity * price).ToString("c");
        }







    }
}
