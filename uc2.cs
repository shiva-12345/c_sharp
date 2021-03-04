using System;
using System.Collections.Generic;
using System.Text;

namespace emp_present_ornot
{
    class uc2
    {
        public static void partimeempwage()
        {
            int is_full_time = 1;
            int emp_rate_per_hour = 20;
            int is_part_time = 2;
            int emphrs = 0;
            int empwage = 0;
            Random random = new Random();
            int empcheck = random.Next(0, 2);
            if (empcheck == is_part_time)
                emphrs = 4;
            else if (empcheck == is_full_time)
                emphrs = 8;
            else
                emphrs = 0;
            empwage = emphrs * emp_rate_per_hour;
            Console.WriteLine("emp wage" + empwage);
            


        }
    }
}
