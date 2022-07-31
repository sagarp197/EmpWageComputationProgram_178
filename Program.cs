using System;

namespace UC3
{
    class Program
    {
        static void Main(string[] args)
        {

            int Emp_Rate_Per_Hour = 20;
            int empHrs = 0;
            int empWage = 0;

            Random random = new Random();
            int empCheck = random.Next(0, 3);

            if (empCheck == 0)
            {
                Console.WriteLine("Employee is Present Full Time");
                empHrs = 8;
            }
            else if (empCheck == 1)
            {
                Console.WriteLine("Employee is Working Part Time");
                empHrs = 4;
            }
            else
            {
                Console.WriteLine("Employee is Absent");
                empHrs = 0;
            }
            empWage = empHrs * Emp_Rate_Per_Hour;
            Console.WriteLine("Emp Wage :" + empWage);

        }

    }
}
