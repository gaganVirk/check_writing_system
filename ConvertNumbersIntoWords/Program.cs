using System;

namespace ConvertNumbersIntoWords
{
    class Program
    {
        public static string ConvertAmount(double amount)
        {
            try
            {
                int amount_int = (int)amount;
                int amount_dec = (int)Math.Round((amount - (double)(amount_int)) * 100);
                if (amount_dec == 0)
                {
                    return NumberToWords(amount_int) + " dollars.";
                }
                else
                {
                    return NumberToWords(amount_int).ToUpper() + " dollars and " + NumberToWords(amount_dec) + " cents.";
                }
            }
            catch (Exception e)
            {
                // TODO: handle exception  
            }
            return "";
        }
        public static string NumberToWords(int number)
        {
            if (number == 0)
                return "zero";

            if (number < 0)
                return "Number has to be non-negative";
                

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

        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter a Number to convert into words");
                string number = Console.ReadLine();
                number = ConvertAmount(double.Parse(number));

                Console.WriteLine("Number in words is \n{0}", number);
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }

    }
}
