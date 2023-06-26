using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Day19_UserRegistrationAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration assignment");
            Console.WriteLine("Enter your first name:");
            string firstName = Console.ReadLine();

            // Validate the first name using regular expression
            if (IsValidFirstName(firstName))
            {
                Console.WriteLine("Valid first name entered.");
            }
            else
            {
                Console.WriteLine("Invalid first name entered.");
            }
            Console.ReadLine();
        }

        static bool IsValidFirstName(string firstName)
        {
            // Regular expression pattern to match the first name condition
            string pattern = @"^[A-Z][a-zA-Z]{2,}$";

            // Check if the first name matches the pattern
            return Regex.IsMatch(firstName, pattern);
        }
    }
}
