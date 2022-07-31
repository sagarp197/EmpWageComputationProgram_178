using System;

namespace UC4
{
    class Program
    {
        public const int IS_Part_Time = 1;
        public const int IS_Full_Time = 2;
        public const int Emp_Rate_Per_Hour = 20;
        static void Main(string[] args)
        {
            int empHrs = 0;
            int empWage = 0;
            Random random = new Random();
            int empCheck = random.Next(0,3);

            switch (empCheck)
            {
                case IS_Part_Time:
                    Console.WriteLine("Employee is Working Part Time");
                    empHrs = 4;
                    break;

                case IS_Full_Time:
                    Console.WriteLine("Employee is Present Full Time");
                    empHrs = 8;
                    break;

                default:
                    Console.WriteLine("Employee is Absent");
                    empHrs = 0;
                    break;
            }
            empWage = empHrs * Emp_Rate_Per_Hour;
            Console.WriteLine("Emp Wage :" + empWage);
        }
    }
}
