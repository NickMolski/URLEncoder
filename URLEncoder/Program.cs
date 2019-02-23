using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URLEncoder
{
    class Program
    {
        static string urlFormatString = "https://companyserver.com/content/{0}/files/{1}/{1}Report.pdf";

        static void Main(string[] args)
        {
            Console.WriteLine("URL Encoder");

            do
            {
                Console.Write("\nProject name: ");
                string projectName = GetUserInput();
                Console.Write("Activity name: ");
                string activityName = GetUserInput();

                Console.WriteLine(CreateURL(projectName, activityName));

                Console.Write("Would you like to do another? (y/n): ");
            } while (Console.ReadLine().ToLower().Equals("y"));
        }

        static string CreateURL(string projectName, string activityName) {
            // create the URL string and return it
            string urlFormatString = "https://companyserver.com/content/{0}/files/{1}/{1}Report.pdf";
        }

        static string GetUserInput()
        {
            // get valid input from the user
            // disallow strings with control characters
            // IsValid() below is used to check if input is valid
            string input = "";
            do
            {
                input = Console.ReadLine();
                if (IsValid(input)) return input;
                Console.Write("The input contains invalid characters. Enter again: ");
            } while (true);
        }

        static bool IsValid(string input) {
            // check if the string is valid and does not
            // contain control characters
            // if valid, return true
            // if not valid, return false
            foreach (char character in input.ToCharArray())
            {
                if (character == 0x1F)
                {
                    // do something about the character being 0x1F
                }
                // check each character to see if it matches any of the not-allowed control characters
            }
        }

        static string Encode(string value)
        {
            // return an encoded version of the 
            // string provided in value
            string encodedValue = "";
            foreach (char character in value.ToCharArray())
            {
                // build the encodedValue string by getting each character
                // in the original string and adding it to encodedValue if the original is ok
                // OR changing it to an encoded value and adding the encoded value to the string
                // if it is one of the values that needs to change
            }
            return encodedValue;
        }
    }
}
