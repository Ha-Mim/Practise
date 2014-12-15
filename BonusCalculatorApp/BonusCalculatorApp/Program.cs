using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusCalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter salary of employee : ");
            int salary = Convert.ToInt32(Console.ReadLine());
            if (salary > 10000)
            {
                Console.WriteLine("Bonus is 5%");
            }
            else if(salary>=8000 && salary<=10000)
            {
                Console.WriteLine("Bonus is 6%");
            }
            else
            {
                Console.WriteLine("Bonus is 7%");
            }
            Console.ReadLine();
        }
    }
}
