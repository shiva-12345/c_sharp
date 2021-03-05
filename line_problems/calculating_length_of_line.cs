using System;
using System.Collections.Generic;
using System.Text;

namespace line_comparision_problems
{
    class calculating_length_of_line
    {
        static void cal_lenght()
        {
            Console.WriteLine("enter the values of x1 and y1:");
            var x1 = Convert.ToDouble(Console.ReadLine());
            var y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter the values of x2 and y2:");
            var x2 = Convert.ToDouble(Console.ReadLine());
            var y2 = Convert.ToDouble(Console.ReadLine());
            Double finalresult = distance(x1,x2,y1,y2);
            Console.WriteLine("distance between the coordinates {0},{1} and {2},{3} is {4}", finalresult);


        }
        private static Double distance(Double x1, Double x2, Double y1, Double y2)
        {
            var temp1 = Math.Pow((x2 - x1), 2);
            var temp2 = Math.Pow((y2 - y1), 2);
            var result = Math.Sqrt(temp1 + temp2);
            return (Double)result;
        }
    }

}
