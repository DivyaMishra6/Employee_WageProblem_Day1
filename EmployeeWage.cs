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
            int EmpHrs = 0;
            int total_Work_Hour = 0;
            int Wage_Per_Hour = 20;
            int total_Salary = 0;

            int Total_Days = 20;

            for (int day = 1; day <= Total_Days; day++)
            {

                Random random = new Random();
                int num = random.Next(3);



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
                total_Work_Hour = (total_Work_Hour + EmpHrs);

                total_Salary = (total_Work_Hour * Wage_Per_Hour);
            }

            Console.WriteLine("Total working hour in a Month " + total_Work_Hour);

            Console.WriteLine("Total salary for a month  " + total_Salary);



        }
    }
}

