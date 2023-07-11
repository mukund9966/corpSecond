using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
       

        static void Main(string[] args)
        {

            Console.WriteLine("Employee Type");
            Console.WriteLine("1) HR");
            Console.WriteLine("2) Admin");
            Console.WriteLine("3) Software developer");
            Console.WriteLine("ENTER EMPLOYEE TYPE");
            int kind = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("ENTER working hours");
            int hours = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("ENTER working days");
            int days = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("ENTER handles");
            int handles = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("ENTER extras");
            int extras = Convert.ToInt32(Console.ReadLine());

            float salary = calculateSalary(kind, hours, days, handles, extras);
            Console.WriteLine("Salary is Rs " + salary);
            Console.ReadLine();



        }

        public static float calculateSalary(int kind, int hours, int days, int handles, int extras)
        {
            float salary1 = 0;

            switch (kind)
            {
                //hr
                case 1:
                    salary1 = hours * days * 100;
                    break;

                case 2:
                    salary1 = hours * days * 100 + handles * 3000;
                    break;

                case 3:
                    salary1 = hours * days * 100 + handles * 3000 + extras * 2000;
                    break;

                default:
                    Console.WriteLine("Write valid emplyoee type");
                    break;
            }


            return salary1;
        }
    }
}
