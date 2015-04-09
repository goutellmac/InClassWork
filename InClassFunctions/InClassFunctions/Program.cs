using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClassFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            //SpecificLetterCounter("s", "Sally sells sea shells");
            //Console.WriteLine(AnnoyingTextIfyer("Yoda is the greatest dang jedi of all time"));
           // Console.WriteLine(AnotherAnnoyingTextIfyer("Darth Maul is a legend"));
            Console.WriteLine(NumberRounder(26));
            Console.WriteLine(NumberRounder(116));
            Console.WriteLine(NumberRounder(298));
            Console.WriteLine(NumberRounder(110586));
            Console.ReadKey();
        }

        static void SpecificLetterCounter(string letterToCount, string stringToSearch)
        {
            int counter = 0;
            //function to find number of a specific letter within a string
            for (int i = 0; i < stringToSearch.Length; i++)
            {
                string letter = stringToSearch[i].ToString();
                if(letter.ToLower() == letterToCount)
                {
                    counter++;
                }
            }

            Console.WriteLine("We found " + counter + " " + letterToCount + "'s" + " in " + stringToSearch);
        }

        static string AnnoyingTextIfyer(string notAnnoyingString)
        {
            string returnString = string.Empty;
            for (int i = 0; i < notAnnoyingString.Length; i++)
            {
                string letter = notAnnoyingString[i].ToString();
                if (i % 2 == 0)
                {
                    returnString = returnString + letter.ToUpper();
                }
                else
                {
                    returnString = returnString + letter.ToLower();
                }
            }

            return returnString;
        }

        static string AnotherAnnoyingTextIfyer(string userString)
        {
            string returnString2 = string.Empty;
            for (int i = 0; i < userString.Length; i++)
            {
                string letter2 = userString[i].ToString();
                if (i % 2 == 0)
                {
                    returnString2 = returnString2 + letter2.ToUpper();   
                }
                else
                {
                    returnString2 = returnString2 + letter2.ToLower() + "!";
                }

            }

            return returnString2;
        }

        static int NumberRounder(int numberToRound)
        {
            int returnNumber = 0;
            int remainder = numberToRound % 5;
            if(remainder >= 3)
            {
                returnNumber = numberToRound + (5 - remainder);
                return returnNumber;
            }

            else
            {
                returnNumber = numberToRound - remainder;
                return returnNumber;
            }


        }
    }
}
