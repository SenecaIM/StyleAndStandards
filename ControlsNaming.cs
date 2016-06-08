using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Standard
{
        class Controls_naming
    {
        
        //Controls naming will have a certain rule
        //Each control will have a variable prefix 
        //But also every control will be named depending on the type of the control
         Examples: portfolioButton; configurationListView; setupLabel; transactionOLV 
        //For long names of the controls, shortcuts will be used. Example : transactionOLV instead of transactionObjectListView
         void portfolioButton_Click(Object sender,EventArgs e)
         {
             //Actions
         }
         
         
         //Arrays examples:
         
         int[] numbers = new int[5] {1, 2, 3, 4, 5};
         //or
         string[] names = new string[3] {"Matt", "Joanne", "Robert"};
         
    }
}
