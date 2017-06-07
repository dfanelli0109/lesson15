using System;
using System.Text;

namespace StringsNullablesConversionsDecisions
{
    class Program
    {
        static void Main()
        {
            char x = 'c';
            string originalString = "Cat";             
            System.Text.StringBuilder sb =
                new System.Text.StringBuilder(originalString); 
            sb[0] = 'R';                                       
            string resultingString = sb.ToString();            
            System.Console.WriteLine(resultingString);


            int? Y = null;
            
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine(x);
                if (Y == null) {
                    Console.WriteLine(false);

                } else {
                    Console.WriteLine(true);
                }
                Y = 42;

            }

            System.DateTime aDateTime =
        System.Convert.ToDateTime("4 July 1776");
            System.Console.WriteLine(aDateTime);




            // Declare a variable of type char named ch and initialize it with the value '7'.
            // Then test it in an if statement to see if it is a letter or a
            // non-letter character. Display output on the console that indicates
            // whether it is a letter or a non-letter.

            char ch = '7';
            var isletter = char.IsLetter(ch);
            if (isletter)
            {
                Console.WriteLine(ch + " is a character.");

            }
            else
            {

                Console.WriteLine(ch + " is not a character.");
            }


        }
    }
}