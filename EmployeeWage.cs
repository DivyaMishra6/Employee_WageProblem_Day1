using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Wages_Day1
{
    public class EmployeeWage
    {
        public const int isFullTime = 1;
        public const int isPartTime = 2;
       
        public int ComputeEmpWage(string company, int EmpRatePerHr, int NumOfWorkingDays, int MaxHrInMonth)
        {


            int empWage = 0;
            int empHrs = 0;
            int totalEmpWage = 0;
            int totalWorkingDays = 0;
            int totalEmpHours = 0;


            while (totalEmpHours <= MaxHrInMonth && totalWorkingDays < NumOfWorkingDays)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(3);
                switch (empCheck)
                {

                    case isFullTime:

                        {
                            empHrs = 8;
                            break;
                        }

                    case isPartTime:

                        {
                            empHrs = 4;
                            break;
                        }

                    default:

                        {
                            empHrs = 0;
                            break;
                        }


                }
                totalEmpHours += empHrs;

                Console.WriteLine("Day#:" + totalWorkingDays + "Emp Hrs:" + empHrs + "Emp Wages:" + empWage);
                empWage = empHrs * EmpRatePerHr;
                totalEmpWage += empWage;

            }
            Console.WriteLine("wages of employee per month is " + totalEmpWage);
            return totalEmpWage;

        }


    }
    
}

