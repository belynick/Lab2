using System;
using System.Text;

namespace Lab2_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;

            Employee employee = new Employee("Ivan", "Ivanov");

            Console.WriteLine(employee.PrintInfo());

            Console.ReadLine();
        }
    }
}
