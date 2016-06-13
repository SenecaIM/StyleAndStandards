using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Standard
{
    class Exeption_handling
    {
        
        //Exceptions examples

        // This if statement is optional as it is very unlikely that the stream would ever be null.
        if (fileToRead == null)
        {
            throw new System.ArgumentNullException();
        }
        
        
        //Or we can use a try-catch block 
        
        try
        {
            conn.Close();
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine(ex.GetType().FullName);
            Console.WriteLine(ex.Message);
        }
        
        
        //The overall rule is to always display the right exception as it is very helpful when it comes to debugging
        //Especially if the code is big and chunky

    }
}
