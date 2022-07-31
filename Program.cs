using System;

namespace UC6
{
    class Program
    {
        public const int IS_Part_Time = 1;
        public const int IS_Full_Time = 2;
        public const int Emp_Rate_Per_Hour = 20;
        public const int No_Of_Work_Days = 20;
        public const int Max_Hours_In_Month = 100;
        static void Main(string[] args)
        {
            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;


            while (totalEmpHrs <= Max_Hours_In_Month && totalWorkingDays < No_Of_Work_Days)
            {
                totalWorkingDays++;
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
                
                totalEmpHrs += empHrs;
                Console.WriteLine("Days: " + totalWorkingDays +  " - Emp Working Hrs " + empHrs);

            }
            Console.WriteLine("Toal Emp Hrs  :" + totalEmpHrs);
            int totalEmpWage = totalEmpHrs * Emp_Rate_Per_Hour;
            Console.WriteLine("Toal Emp Wage  :" + totalEmpWage);


        }
    }
}


