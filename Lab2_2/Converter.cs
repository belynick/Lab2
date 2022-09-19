using System;

namespace Lab2_2
{
    internal class Converter
    {
        public Converter(double usd, double eur, double rub)
        {
            _usd = usd;
            _eur = eur;
            _rub = rub;
        }

        private double _usd;
        private double _eur;
        private double _rub;

        private void Checker( bool div, int value)
        {
            Console.WriteLine("Яку валюту ви хочете обрати?");
            Console.WriteLine("Для переведення в USD натисніть 1.");
            Console.WriteLine("Для переведення в EUR натисніть 2.");
            Console.WriteLine("Для переведення в RUB натисніть 3.");

            string choise = Console.ReadLine();
            switch (choise)
            {
                case "1":
                    if (div)
                    {
                        Console.WriteLine($"Ваш результат з USD в UAH = {_usd * value}");
                        break;
                    }

                    Console.WriteLine($"Ваш результат з UAH в USD = {value / _usd}");
                    break;

                case "2":
                    if (div)
                    {
                        Console.WriteLine($"Ваш результат з EUR в UAH = {_eur * value}");
                        break;
                    }

                    Console.WriteLine($"Ваш результат з UAH в EUR = {value / _eur}");
                    break;

                case "3":
                    if (div)
                    {
                        Console.WriteLine($"Ваш результат з RUB в UAH = {_rub * value}");
                        break;
                    }

                    Console.WriteLine($"Ваш результат з UAH в RUB = {value / _rub}");
                    break;

                default:
                    throw new Exception("Неправильна валюта");

            }
        }

        public void ConvertToUah(int curency)
        {
            Checker(true, curency);

        }

        public void ConvertFromUah(int curency)
        {
            Checker(false, curency);

        }
    }
}
