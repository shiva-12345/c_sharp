using System;
using System.Collections.Generic;
using System.Text;

namespace emp_present_ornot
{
    public class uc1
    {
        public static void employee_attendence()
        {
            int is_full_time = 1;
            Random random = new Random();
            int empCheck = random.Next(0, 2);
            if (empCheck == is_full_time)
                Console.WriteLine("employee is present");
            else
                Console.WriteLine("employee is not present");
        }
    }
}
