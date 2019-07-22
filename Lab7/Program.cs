using System;
using System.Text.RegularExpressions;


namespace Lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            UserName();
            GetEmail();
            GetPhoneNumber();
            GetDate();
        }

        public static void UserName()
        {

            Console.WriteLine("Enter in your first name (capitalize first letter)");
            string name = Console.ReadLine();

            if (Regex.IsMatch(name, @"^[A-Z][a-z][A-Za-z]*$"))
            {
                Console.WriteLine("Name is valid");
            }

            else
            {
                Console.WriteLine("Name is invalid");
            }

        }

        public static void GetEmail()
        {

            Console.WriteLine("\nEnter in a valid email");
            string email = Console.ReadLine();

            if (Regex.IsMatch(email, @"^([A-Z[0-9[a-z]{5,30})@([a-z]{5,10})+\.+([a-z]{2,3})$"))
            {
                Console.WriteLine("Valid email");
            }

            else
            {
                Console.WriteLine("Invalid email");
            }
        }

        public static void GetPhoneNumber()
        {
            Console.WriteLine("\nEnter in a valid phone number (###-###-####)");
            string phoneNumber = Console.ReadLine();

            if (Regex.IsMatch(phoneNumber, @"^\(?([0-9]{3})\)?([ .-]?)([0-9]{3})\2([0-9]{4})$"))
            {
                Console.WriteLine("Valid phone number");
            }

            else
            {
                Console.WriteLine("Invalid email");
            }

        }

        public static void GetDate()
        {
            Console.WriteLine("\nEnter in a valid date (mm/dd/yyyy)");
            string date = Console.ReadLine();

            if (Regex.IsMatch(date, @"^[0-9]{2}[-|\/]{1}[0-9]{2}[-|\/]{1}[0-9]{4}$"))
            {
                Console.WriteLine("Valid date");
            }

            else
            {
                Console.WriteLine("Invalid date");
            }


        }

    }
}
