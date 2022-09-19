using System;

namespace Lab2_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            var converter = new Converter(40.172, 39.860, 0.45);

            Console.Write("Напишіть значення в UAH: ");
            converter.ConvertFromUah(Convert.ToInt32(Console.ReadLine()));

            Console.WriteLine();

            Console.Write("Напишіть значення в будь-якій іншій валюті: ");
            converter.ConvertToUah(Convert.ToInt32(Console.ReadLine()));

            Console.ReadLine();
        }
    }
}
