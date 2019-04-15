using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechAcademy
{
    public class OddSum
    {
        public static void Main()
        {
            String hold_display = "";
            var sum = 0;
            int[] num_array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            foreach (int item in num_array) {
                if (item % 2 != 0) {
                    sum += item;
                }
            }
            Console.Out.WriteLine("The total of odd numbers is: {0}", sum);
            while (hold_display != "Q") {
                Console.Out.Write("Enter Q to quit.");
                hold_display = Console.ReadLine();
            }
        }
    }
}
