using System;

namespace Lab2_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var address = new Address();

            address.Country = "England";
            address.City = "London";
            address.Street = "Baker Street";
            address.House = "221B";
            address.Apartment = "all house";
            address.Index = 1;

            Console.WriteLine("Address:");
            Console.WriteLine($"Index: {address.Index}");
            Console.WriteLine($"Country: {address.Country}");
            Console.WriteLine($"City: {address.City}");
            Console.WriteLine($"Street: {address.Street}");
            Console.WriteLine($"House: {address.House}");
            Console.WriteLine($"Apartment: {address.Apartment}");

            Console.ReadLine();

        }
    }
}
