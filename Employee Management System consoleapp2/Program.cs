using Employee_Management_System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management_System_consoleapp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            bool a = true;

            Console.WriteLine("WELCOME TO LITWARE");
            Console.WriteLine("-----------------------------------");
            try
            {
                while (a)
                {


                    Console.WriteLine("Enter EMPLOYEE NUMBER");
                    int no = Convert.ToInt32(Console.ReadLine());


                    Console.WriteLine("Enter EMPLOYEE'S NAME");
                    string name = Console.ReadLine();


                    Console.WriteLine("Enter EMPLOYEE'S SALARY");
                    double sal = Convert.ToDouble(Console.ReadLine());



                    Employee emp = new Employee(no, name, sal);
                    employees.Add(emp);

                    emp.CalculatedSalary();

                    Console.WriteLine("you have successfully registered");

                    Console.WriteLine("enter 0 to exit");

                    int i = Convert.ToInt32(Console.ReadLine());
                    if (i == 0)
                    {
                        a = false;
                    }

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
