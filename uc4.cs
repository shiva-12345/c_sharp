using System;
using System.Collections.Generic;
using System.Text;

namespace emp_present_ornot
{
    class uc4
    {
        public const int is_full_time = 1;
        public const int is_part_time = 2;
        public const int emp_rate_per_hour = 20;
        public static void partimeempwageswitchcase()
        {
           
            int emphrs = 0;
            int empwage = 0;            
            Random random = new Random();
            int empcheck = random.Next(0, 3);
            switch (empcheck)
            {
                case is_part_time:
                    emphrs = 4;
                    break;
                case is_full_time:
                    emphrs = 8;
                    break;
                default:
                    emphrs = 0;
                    break;

            }
            empwage = emphrs * emp_rate_per_hour;
            Console.WriteLine("emp wage" + empwage);
            Console.ReadKey();


        }
    }

} 
