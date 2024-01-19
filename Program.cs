using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the wages per hour: ");
            string wages = Console.ReadLine();
            Console.WriteLine("Enter total hours: ");
            string hours = Console.ReadLine();
            Console.WriteLine("Enter total days worked in per month: ");
            string days = Console.ReadLine();
            Console.WriteLine("Total wage in a month is: ");
            Console.WriteLine((Convert.ToInt32(wages) * Convert.ToInt32(hours)) * Convert.ToInt32(days));
            Console.ReadLine();
        }
    }
}
