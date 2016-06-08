using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Standard
{
    class Constructors_and_arrays
    {
        //Constructor example
        
        public Employee(int weeklySalary, int numberOfWeeks)
        {
            salary = weeklySalary * numberOfWeeks;
        }
         
        
        //Class within a class and a constructor example
        
        public class Manager : Employee
        {
            public Manager(int annualSalary) : base(annualSalary)
                {
                     //Add further instructions here.
                }
        }



    }
}
