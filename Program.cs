namespace Employee_Wages_Day1
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to employee wage Problem");

            // Compute Employee wages for multiple Company

            Console.WriteLine("Enter the name of the company Dmart or Relince:");
            string company = Console.ReadLine();

            EmployeeWage wage = new EmployeeWage();
            if (company == "Dmart")
            {
                wage.ComputeEmpWage(company, 20, 10, 90);
            }
            else if (company == "Relince") 
            {
                wage.ComputeEmpWage(company, 20, 10, 90);
            }
            else 
            {
                Console.WriteLine("Please enter correct company!!"); 
            }


        }
    }


}
