using ClassesVsStructures.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesVsStructures.Services
{
    public class MemoryAllocation
    {
        // [Memory Allocation] *** in Class Vs Struct, Class Object Stored in the Heap and Struct is Stored In the Stack.
        // Simple Demonstration to Proof This Following Points 
        /* Structure is Value Type and that is the reason Struct Object are stored at Stack Memory.
         * Where as Class Object is Reference Type and Stored in Heap Memory. */


        public static void MemoryAllocationInStructure(StructObject structObject1, StructObject structObject2,ClassObject classObject1, ClassObject classObject2)
        {
            structObject1 = structObject2;
            structObject1.Value = 500;
            //Changes in structObject1 can't Change the Value of structObject2.
            Console.WriteLine("**** Changes is not happend in both struct OR Value Type Objects **** \n");
            Console.WriteLine(structObject1.ToString());
            Console.WriteLine(structObject2.ToString());

            classObject1 = classObject2;
            classObject1.Id = 500;
            // Changes In classObject1 is Reflected in both the objects because Object1 is ref to object2.
            Console.WriteLine("**** Changes happens in Both the Class Objects ****\n");
            Console.WriteLine(classObject1.ToString());
            Console.WriteLine(classObject2.ToString());
        }
    }
}
