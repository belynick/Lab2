using System;

namespace Lab2_3
{
    public class Employee
    {
        private string _name;
        private string _surname;
        private int _experience;
        private double _salary;
        private double _tax;
        private Position _position;



        public enum Position
        {
            Junior = 0,
            Middle = 1,
            Senior = 2
        }

        public Employee(string Name, string Surname)
        {
            _name = Name;
            _surname = Surname;
            Random random = new Random();
            _experience = random.Next(1, 4);
            _position = (Position)random.Next(0, 3);

            Calculation(_position);

            _tax = _salary * 0.18d;
        }

        private double Calculation(Position position)
        {
            switch (position)
            {
                case Position.Junior:
                    _salary = 1500 * _experience;
                    return _salary;
                case Position.Middle:
                    _salary = 2000 * _experience;
                    return _salary;
                case Position.Senior:
                    _salary = 2500 * _experience;
                    return _salary;     
            }
            return 0.0;
        }

        public string PrintInfo()
        {
            return $"Прізвище: {_surname}\nІм'я: {_name}\nПосада: {_position} (Досвід {_experience} роки)\nОклад: {_salary}\nПодатковий збір: {_tax}";
        }
    }
}

