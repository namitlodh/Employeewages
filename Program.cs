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
            Random rnd = new Random();
            int a = rnd.Next(0, 2);
            if (a == 0)
            {
                Console.WriteLine("Employee is Absent");
            }
            else
            {
                Console.WriteLine("Employee is Present");
            }
            Console.ReadLine();
        }
    }
}
