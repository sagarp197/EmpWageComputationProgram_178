using System;

namespace UC2
{
    class Program
    {
        static void Main(string[] args)
        {
            int Is_Full_Time = 1;
            int Emp_Rate_Per_Hour = 20;

            int EmpHrs = 0;
            int EmpWage = 0;

            Random random = new Random();
            int empCheck = random.Next(0, 2);

            if (empCheck == Is_Full_Time)
            {
                Console.WriteLine("Employee is Working Full Time");
                EmpHrs = 8;
            }
            else
            {
                Console.WriteLine("Employee is Absent");
                EmpHrs = 0;
            }

            EmpWage = EmpHrs * Emp_Rate_Per_Hour;
            Console.WriteLine("Emp Wage is " + EmpWage);
        }
    }
}
