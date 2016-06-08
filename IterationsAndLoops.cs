using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Standard
{
    class Iterations_and_Loops
    {
        
        //do-while loop example
        
         int x = 0;
        do 
        {
            Console.WriteLine(x);
            x++;
        } while (x < 5);
        
        
        //While loop
        
        int n = 1;
        while (n < 6) 
        {
            Console.WriteLine("Current value of n is {0}", n);
            n++;
        }
        
        
        
        //LINQ method (same output)
        int[] fibarray = new int[] { 0, 1, 1, 2, 3, 5, 8, 13 };
        public void hello()
        {
           fibarray.ToList().ForEach(p => { System.Console.WriteLine(p.ToString()); });
        }
        
        //For loop Example (same output)
        int[] fibarray = new int[] { 0, 1, 1, 2, 3, 5, 8, 13 };
        for (int i = 0; i < fibarray.Length; i++)
        {
            System.Console.WriteLine(fibarray[i]);
        }
        System.Console.WriteLine();

        
        
        //Foreach loop example
         int[] fibarray = new int[] { 0, 1, 1, 2, 3, 5, 8, 13 };
        foreach (int element in fibarray)
        {
            System.Console.WriteLine(element);
        }
        System.Console.WriteLine();

        
        
        //Switch statement example
        
        switch (Object or Condition)
        {
             case (condition):
                 action
                 break;
             case (condition):
                 action
                 break;
             default:
                 action
                 break;
        }
        
        
        //if statement example
        if (condition)
        {
            action
        }
        else if(condition)
        {
            action
        }
        else
        {
            action
        }
        
        //Short if statement example
        if (condition) {action}
        
        
        
    }
    
}
