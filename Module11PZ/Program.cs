using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module11PZ
{
    public enum Vacancies
    {
        Manager,
        Developer,
        Designer,
        Other
    }

    public struct Employee
    {
        public string Name;
        public Vacancies Vacancy;
        public int[] HireDate; 
        public int Salary;
    }

    class Program
    {
        static void Main()
        {
            Employee employee1;
            employee1.Name = "Nursultan Gazhdanbek";
            employee1.Vacancy = Vacancies.Developer;
            employee1.HireDate = new int[] { 2023, 11, 03 };
            employee1.Salary = 50000;

            Console.WriteLine($"Имя: {employee1.Name}");
            Console.WriteLine($"Должность: {employee1.Vacancy}");
            Console.WriteLine($"Дата приема на работу: {employee1.HireDate[2]}.{employee1.HireDate[1]}.{employee1.HireDate[0]}");
            Console.WriteLine($"Зарплата: {employee1.Salary}");

        }
    }
}
