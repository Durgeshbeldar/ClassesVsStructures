using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesVsStructures.Models
{
    public class ChildClass : ClassObject
    {
       
        public ChildClass(int id, string name): base(id, name) { }

        // Point 4 Implementation is here...
        public override void PrintClass()
        {
            Console.WriteLine("\nInside Child Class Overriden Function\n");
        }
    }
}
