using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Standard
{
    public class Class1
    {
        
        //Naming data types is not very complicated as there aren't many of built-in data types
        
        //The overall rule is to make sure that the naming stays relevant to the purpose which the data type is used in
        
        //Examples:
        
        int a = 1;
        string s = "Hello";
        XmlDocument tempDocument = new XmlDocument();
        double d;
        bool a = true;
        
        
        //When working with data types in big projects make sure the naming stays relevant
        //Examples:
        
        public class Car
        {
            int Wheels;
            double Speed;
            string Make;
            bool AfterAccident;
        }
        
        //Bad examples:
        
        public class Motorbike
        {
            int cfd;
            double a;
            string String;
            bool True;
        }
    }
}
