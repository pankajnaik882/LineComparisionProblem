using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisionProblem
{
    public class CheckLineComparision
    {
        public static void checkLineComparision() 
        {
            Console.WriteLine("Enter the x1 co-ordinate");
            double x1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the y1 co-ordinate");
            double y1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the x2 co-ordinate");
            double x2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the y2 co-ordinate");
            double y2 = Convert.ToDouble(Console.ReadLine());

            double lengthOfLine = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine("The lenght of line using co-ordinate : " + lengthOfLine);

            //Use Case 3.
            bool checkX = Math.Equals(x2 - x1, lengthOfLine);
            bool checkY = Math.Equals(y2 - y1, lengthOfLine);

            if ((x1, y1) == (x2, y2))
            {
                Console.WriteLine("x1 , y1 and x2 , y2 both are equal");
            }
            else if (x1 > x2 && y1 > y2)
            {
                Console.WriteLine("x1 , y1 is greater then x2 , y2");
            }
            else
            {
                Console.WriteLine("x2 , y2 is greater than x1 , y1 ");
            }
        }
    }
}
