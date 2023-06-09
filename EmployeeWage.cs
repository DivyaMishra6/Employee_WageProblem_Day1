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
            int IS_FULL_TIME = 1;
            Random random = new Random();

            int empCheck = random.Next(2);

            if (empCheck == IS_FULL_TIME)
            {
                Console.WriteLine("Employee is Present");

            }
            else
            {
                Console.WriteLine("Employee is Absent");

            }
        }
    }
}

