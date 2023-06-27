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

            Console.WriteLine("Enter your email address:");
            string email = Console.ReadLine();

            Console.WriteLine("Enter your mobile number:");
            string mobileNumber = Console.ReadLine();

            if (IsValidFirstName(firstName))
            {
                Console.WriteLine("Valid first name.");
            }
            else
            {
                Console.WriteLine("Invalid first name.");
            }

            if (IsValidLastName(lastName))
            {
                Console.WriteLine("Valid last name.");
            }
            else
            {
                Console.WriteLine("Invalid last name.");
            }

            if (IsValidEmail(email))
            {
                Console.WriteLine("Valid email address entered.");
            }
            else
            {
                Console.WriteLine("Invalid email address entered.");
            }

            if (IsValidMobileNumber(mobileNumber))
            {
                Console.WriteLine("Valid mobile number entered.");
            }
            else
            {
                Console.WriteLine("Invalid mobile number entered.");
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

        static bool IsValidEmail(string email)
        {
            // Regular expression pattern to match the email address condition
            string pattern = @"^[a-zA-Z0-9]+(?:\.[a-zA-Z0-9]+)*@[a-zA-Z0-9]+(?:\.[a-zA-Z0-9]+)*(?:\.[a-zA-Z]{2,})$";

            // Check if the email address matches the pattern
            return Regex.IsMatch(email, pattern);
        }

        static bool IsValidMobileNumber(string mobileNumber)
        {
            // Regular expression pattern to match the mobile number condition
            string pattern = @"^91 \d{10}$";

            // Check if the mobile number matches the pattern
            return Regex.IsMatch(mobileNumber, pattern);
        }
    }
}
