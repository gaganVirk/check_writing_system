using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChequeWritingSystem.Models
{
    public class ChequeWriting
    {
        public int Number { get; set; }
        public string Currency { get; set; }

        public static string ConvertAmount(double amount)
        {
            
            int amount_int = (int)amount;
            int amount_dec = (int)Math.Round((amount - (double)(amount_int)) * 100);
            if (amount_dec == 0)
            {
                return NumberToWords(amount_int).First().ToString().ToUpper() + String.Join("", NumberToWords(amount_int).Skip(1)) + " dollars.";
            }
            else
            {
                return NumberToWords(amount_int).First().ToString().ToUpper() + String.Join("", NumberToWords(amount_int).Skip(1)) + " dollars and " + NumberToWords(amount_dec) + " cents.";
            }
            
        }
        public static string NumberToWords(int number)
        {
            if (number == 0)
                return "Zero";

            if (number < 0)
                return "Please don't enter negative";


            string words = "";

            if ((number / 1000000) > 0)
            {
                words += NumberToWords(number / 1000000) + " million, ";
                number %= 1000000;
            }

            if ((number / 1000) > 0)
            {
                words += NumberToWords(number / 1000) + " thousand, ";
                number %= 1000;
            }

            if ((number / 100) > 0)
            {
                words += NumberToWords(number / 100) + " hundred ";
                number %= 100;
            }

            if (number > 0)
            {
                if (words != "")
                    words += "and ";

                var unitsMap = new[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
                var tensMap = new[] { "zero", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

                if (number < 20)
                    words += unitsMap[number];
                else
                {
                    words += tensMap[number / 10];
                    if ((number % 10) > 0)
                        words += " " + unitsMap[number % 10];
                }
            }

            return words;
        }
    }
}