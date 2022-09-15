using Employee_Management_System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management_System_consoleapp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WELCOME TO LITWARE");
            Console.WriteLine("-----------------");

            Console.WriteLine("Enter EMPLOYEE NUMBER");
            int no = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter EMPLOYEE'S NAME");
            string name = Console.ReadLine();

            Console.WriteLine("Enter EMPLOYEE'S SALARY");
            double sal = Convert.ToDouble(Console.ReadLine());

            Employee emp = new Employee(no, name, sal);
            emp.CalculatedSalary();
        }
    }
}
