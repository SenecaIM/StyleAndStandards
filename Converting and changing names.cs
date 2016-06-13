using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Standard
{
    class Converting_and_changing_names
    {
        //Converting data types is simple, examples:
        
        string myString = "true";
        try
        {
            bool myBool = Convert.ToBoolean(myString);
            Console.WriteLine(myBool);
        }
        
        //Or that:
        
        Int64 myInt64 = 123456789;
        try
        {
            int myInt = Convert.ToInt32(myInt64);
            Console.WriteLine(myInt);
        }
        
        //Now changing names
        
        //General rules:
        //Try to use the rename function in Visual Studio, it renames what we want throughout the entire solution, faster, better.
        //Make sure the name that you are changing to is not taken, and if there is no way to avoid that
        //Make sure our then overload the method so it can take 2 objects of the same name
        //With converting stick to the example and the general rule
        //When changing a name make sure you let Martin know or at least leave a comment in  the code,
        //sometimes we get used to a particular name ;)
        
    }
}
