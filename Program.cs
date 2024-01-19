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
            Console.WriteLine("Enter wage per hour : ");
            String wageperhour = Console.ReadLine();
            Console.WriteLine("Enter total hours worked : ");
            String hours = Console.ReadLine();
            Console.WriteLine(Convert.ToInt32(wageperhour) * Convert.ToInt32(hours));
            Console.ReadLine();
        }
    }
}
