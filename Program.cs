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
            Random random = new Random();
            int isPresent = random.Next(0, 3);
            if (isPresent == 0)
            {
                Console.WriteLine("Employee is Absent");
            }
            else if (isPresent == 1)
            {
                Console.WriteLine("Employee is working Full Time");
                Console.WriteLine("Enter employee wage: ");
                string wage = Console.ReadLine();
                Console.WriteLine("Enter total hours");
                string hours = Console.ReadLine();
                Console.WriteLine(Convert.ToInt32(wage) * Convert.ToInt32(hours));
            }
            else
            {
                Console.WriteLine("Employee is working Part time");
                Console.WriteLine("Enter employee wage: ");
                string wageparttime = Console.ReadLine();
                Console.WriteLine("Enter total hours");
                string hoursparttime = Console.ReadLine();
                Console.WriteLine(Convert.ToInt32(wageparttime) * Convert.ToInt32(hoursparttime));
            }
            Console.ReadLine();
        }
    }
}
