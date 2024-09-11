using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryMaintenance
{
    public static class Validator
    {

        public static string IsPresent(string strTestValue, string strControlName)
        {
            string strMessage = "";
            if (strTestValue.Trim() == "")
            {
                strMessage += strControlName + " is a required field.\n";
            }
            return strMessage;
        }


        public static string IsInteger(string strTestValue, string strControlName)
        {
            string strMessage = "";
            if (!Int64.TryParse(strTestValue, out _))
            {
                strMessage += strControlName + " must be a valid integer value.\n";
            }
            return strMessage;
        }

        public static string IsDecimal(string strTestValue, string strControlName)
        {
            string strMessage = "";
            if (!Decimal.TryParse(strTestValue, out _))
            {
                strMessage += strControlName + " must be a valid decimal value.\n";
            }
            return strMessage;
        }

        public static string IsWithinRange(string strTestValue, string strControlName, decimal decMin, decimal decMax)
        {

            decimal decTestNumber = Convert.ToDecimal(strTestValue);
            string strMessage = "";
            if (decTestNumber < decMin || decTestNumber > decMax)
            {
                strMessage += strControlName + " must be between " + decMin + " and " + decMax + " per order.\n";
            }
            return strMessage;
        }

        public static string IsGreaterThan(string strTestValue, string strControlName, decimal decMin)
        {

            decimal decTestNumber = Convert.ToDecimal(strTestValue);
            string strMessage = "";
            if (decTestNumber <= decMin)
            {
                strMessage += strControlName + " must be greater than " + decMin + ".\n";
            }
            return strMessage;
        }

        public static string IsLessThan(string strTestValue, string strControlName, decimal decMax)
        {

            decimal decTestNumber = Convert.ToDecimal(strTestValue);
            string strMessage = "";
            if (decTestNumber >= decMax || decTestNumber > decMax)
            {
                strMessage += strControlName + " must be less than " + decMax + ".\n";
            }
            return strMessage;
        }


        public static string IsCorrectCity(string strTestValue, string strTestControlName, string strAddress1, string strAddress2)
        {
            string strMessage = "";
            strTestValue = strTestValue.Trim();
            strTestValue = strTestValue.ToUpper();
            strAddress1 = strAddress1.ToUpper();
            strAddress2 = strAddress2.ToUpper();
            if (strTestValue != strAddress1 && strTestValue != strAddress2)
            {
                strMessage += "Order cannot be delivered to " + strTestValue + ". Orders can only be delivered to either " + strAddress1 + " or " + strAddress2 + ".\n";
            }
            return strMessage;
        }

        public static string IsCorrectState(string strTestValue, string strTestControlName, string strAddress)
        {
            string strMessage = "";
            strTestValue = strTestValue.Trim();
            strTestValue = strTestValue.ToUpper();
            strAddress = strAddress.ToUpper();
            if (strTestValue != strAddress)
            {
                strMessage += "Order cannot be delivered to " + strTestValue + ". Orders can only be delivered within " + strAddress + " Please enter a valid abbreviation.\n";
            }

            return strMessage;
        }

        public static string IsCorrectCountry(string strTestValue, string strTestControlName, string strAddress1, string strAddress2)
        {
            string strMessage = "";
            strTestValue = strTestValue.Trim();
            strTestValue = strTestValue.ToUpper();
            strAddress1 = strAddress1.ToUpper();
            strAddress2 = strAddress2.ToUpper();
            if (strTestValue != strAddress1 && strTestValue != strAddress2)
            {
                strMessage += "Order cannot be delivered to " + strTestValue + "\n" + "Orders can only be delivered to either " + strAddress1 + " or " + strAddress2 + ".\n";
            }
            return strMessage;
        }

        public static string IsCorrectZip(string strTestValue, string strTestControlName)
        {
            string strMessage = "";
            if (IsInteger(strTestValue, strTestControlName) == "")
            {
                strTestValue = strTestValue.Trim();
                if (strTestValue.Length != 5)
                {
                    strMessage += strTestControlName + " must be a valid 5 digit zip code.\n";
                }
                return strMessage;
            }
            else
            {
                strMessage += strTestControlName + " must be a valid 5 digit zip code.\n";
            }

            return strMessage;

        }
        public static string IsCorrectPhoneNumber(string strTestValue, string strTestControlName)
        {
            string strMessage = "";
            if (IsInteger(strTestValue, strTestControlName) == "")
            {
                strTestValue = strTestValue.Trim();
                if (strTestValue.Length != 10)
                {
                    strMessage += strTestControlName + " must be a valid phone number without any special characters.\n";
                }
                return strMessage;
            }
            else
            {
                strMessage += strTestControlName + " must be a valid phone number without any special characters.\n";
            }

            return strMessage;

        }


        #region FRMVendor Specific Validation:

        /// <summary>
        /// checks if a string of numbers is a valid 9 or 10 digit phone number
        /// </summary>
        /// <param name="strTestValue"></param>
        /// <param name="strTestControlName"></param>
        /// <returns></returns>
        public static string IsCorrectPhoneNumberVendor(string strTestValue, string strTestControlName)
        {
            string strMessage = "";
            if (IsInteger(strTestValue, strTestControlName) == "")//checking if valid integer
            {
                strTestValue = strTestValue.Trim();
                if (strTestValue.Length != 9 && strTestValue.Length != 10)//checking if the number is not 9 digits and not 10 digits
                {
                    strMessage += strTestControlName + " must be a valid 9 or 10 digit phone number without any special characters.\n";//strMessage updated since not valid(inccorrect digits)
                }
                return strMessage;
            }
            else
            {
                strMessage += strTestControlName + " must be a valid 9 or 10 digit phone number without any special characters.\n";//strMessage updated since not integer
            }

            return strMessage;//returning strMessage

        }



        #endregion


    }
}
