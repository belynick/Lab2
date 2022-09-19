using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;

            User user = new User();

            user.Login = "qwerty123";
            user.Name = "Ivan";
            user.Surname = "Ivanov";
            user.Age = 18;

            Console.WriteLine("User:");
            Console.WriteLine($"Login: {user.Login}");
            Console.WriteLine($"Name: {user.Name}");
            Console.WriteLine($"Surname: {user.Surname}");
            Console.WriteLine($"Age: {user.Age}");
            Console.WriteLine($"Date of the form: {user.FillingDate}");

            Console.ReadLine();
        }
    }
}
