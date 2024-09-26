using ClassesVsStructures.Models;
using ClassesVsStructures.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesVsStructures
{
    public class Program
    {
        

        static void Main(string[] args)
        {
            // POC : Proof of Concept On Class vs Structures in C#
            // Here I have Demonstrated Class vs Struct Concept with Implementation

            // NOTE : Each Concept is specify By Using Numbers :

            // =====================================================================================
            /* Point 1 : Memory Allocation --> Structures Stored in Stack and Classes Stored in Heap.
               OR you can say class is reference type and struct is value type. also we can say Class
               is Pass by reference and Struct is Pass by value */
            // =====================================================================================

            // Initialization of Class Objects...
            Console.WriteLine("\n***** Point 1 : Memory Allocations in Class and Struct & Class = Ref Type and Struct Value Type *****\n");
            ClassObject classObject = new ClassObject(1, "Class Object");
            ClassObject classObject2 = new ClassObject(3, "Class Object2");

            //Initialization of Struct Objects...
            StructObject structObject2 = new StructObject("Struct Object2", 200);
            StructObject structObject = new StructObject("Struct Object", 100);

            MemoryAllocation.MemoryAllocationInStructure(structObject,structObject2,classObject,classObject2);


            // =====================================================================================
            /* Point 2 : We Can Define Parameterless Constructor In Class but Not in Structure 
               before C# 10 Note : Refer StructObject.cs */
            // =====================================================================================

            Console.WriteLine("\n***** Point 2 : We Cant Define Parameterless Constructor in Structure *****\n");

            // =====================================================================================
            /* Point 3 : Classes support inheritance, which means you can create a new class based 
               on an existing class. Structs do not support inheritance, so you cannot inherit from
               a struct  Refer File ChildofStruct.cs */
            // =====================================================================================

            Console.WriteLine("\n***** Point 3 : Inheritance is not Possible in Structure *****\n");

            // =====================================================================================
            /* Point 4 : Creating Virtual and Abstract Functions in Struct is not Possible while in
               In Class Virtual and Abstract Methods/Functions are possible*/
            // =====================================================================================

            Console.WriteLine("\n***** Point 4 : Virtual OR Abstract Functions is not allowed in Struct *****\n");
          
            // I have created Parent Class ref and store parent class runtime object
            // and again I created Parent Class ref and stored runtime object of child Class.
            // You can refer both the files ClassObject.cs and ChildClass.cs for Implementation of virtual function
            // You can also refer StructObject.cs commentted code shows creating virtual functions is not possible

            ClassObject parentClass1 = new ClassObject(101, "Parent Class Object");
            ClassObject parentClass = new ChildClass(101, "Child Object");

            parentClass1.PrintClass();
            parentClass.PrintClass();

            // There are so many points we can implement which are mention in the pdf which is in the project folder
            // so please refer that pdf to get detailed analysis on struct and class.

            //Thank You .....

        }

    }
}
