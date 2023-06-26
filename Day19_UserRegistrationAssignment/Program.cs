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
            Console.WriteLine("Enter your first name:");
            string firstName = Console.ReadLine();

            Console.WriteLine("Enter your last name:");
            string lastName = Console.ReadLine();

            // Validate the first name and last name using regular expressions
            if (IsValidFirstName(firstName) && IsValidLastName(lastName))
            {
                Console.WriteLine("Valid first name and last name entered.");
            }
            else
            {
                Console.WriteLine("Invalid first name or last name entered.");
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

        static bool IsValidLastName(string lastName)
        {
            // Regular expression pattern to match the last name condition
            string pattern = @"^[A-Z][a-zA-Z]{2,}$";

            // Check if the last name matches the pattern
            return Regex.IsMatch(lastName, pattern);
        }
    }
}
