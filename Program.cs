using System;

namespace UC5
{
    class Program
    {
        public const int IS_Part_Time = 1;
        public const int IS_Full_Time = 2;
        public const int Emp_Rate_Per_Hour = 20;
        public const int No_Of_Work_Days = 20;
        static void Main(string[] args)
        {
            int empHrs = 0;
            int empWage = 0;
            int totalEmpWage = 0;


            for(int day=0; day < No_Of_Work_Days; day++)
            {
                Random random = new Random();
                int empCheck = random.Next(0, 3);

                switch (empCheck)
                {
                    case IS_Part_Time:
                        empHrs = 4;
                        break;

                    case IS_Full_Time:
                        empHrs = 8;
                        break;

                    default:
                        empHrs = 0;
                        break;
                }
                empWage = empHrs * Emp_Rate_Per_Hour;
                totalEmpWage += empWage;
                Console.WriteLine("Emp Wage :" + empWage);

            }
            Console.WriteLine("Toal Emp Wage of 20 Days :" + totalEmpWage);


        }
    }
}

