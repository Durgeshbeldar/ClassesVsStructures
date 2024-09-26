using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesVsStructures.Models
{
    public struct StructObject
    {
        // This is Simple Demonstration of Structure.
        public string Name { get; set; }
        public int Value { get; set; }

        // We Cant Create Parameterless Constructor as Follow :
        //public StructObject()
        //{

        //}
        public StructObject(string name, int value)
        {
            Name = name;
            Value = value;
        }
        // Point 4 Demo : We cant create virtual or abstract functions in structure.
        /*public virtual void PrintStructure()
          {

          }*/
        public override string ToString()
        {
            return $"Struct Name : {Name}" +
                $"\nStruct Value : {Value}\n";
        }
    }
}
