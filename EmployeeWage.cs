using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Wages_Day1
{
    public class EmployeeWage
    {

        public void EmployeeAttendence()
        {
            int Max_Days = 20;
            int Max_Hours = 100;
            int Wage_Per_hrs = 20;
            int EmpHrs = 0;

            int Total_Wage = 0;

            int Total_Work_Hour = 0;
            int day = 1;

            while (day <= Max_Days && Total_Work_Hour <= Max_Hours)
            {

                Random random = new Random();
                int num = random.Next(0,3);

                switch (num)
                {
                    case 0:
                        Console.WriteLine("Employee is Absent");
                        EmpHrs = 0;
                        break;

                    case 1:
                        Console.WriteLine("Employee is present for part time");
                        EmpHrs = 4;
                        break;

                    case 2:
                        Console.WriteLine("Employee is present for full time");
                        EmpHrs = 8;
                        break;
                }
                day++;
                Total_Work_Hour = (Total_Work_Hour + EmpHrs);

                Total_Wage = (Total_Work_Hour * Wage_Per_hrs);
            }

            Console.WriteLine("Total working hour in a Month " + Total_Work_Hour);

            Console.WriteLine("Total salary for a month  " + Total_Wage);



        }
    }
}

