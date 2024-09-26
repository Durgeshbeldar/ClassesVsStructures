using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesVsStructures.Models
{
    public class ClassObject
    {
        //This is Simple Class for Demonstration
        public int Id { get; set; }
        public string Name { get; set; }

        public ClassObject(int id,string name) {
            Id = id;
            Name = name;
        }

        // Point 4 Demonstration is here 
        public virtual void PrintClass()
        {
            Console.WriteLine("\nInside Parrent Class Virtual Function");
        }
        public override string ToString()
        {
            return $"Class ID : {Id}" +
                $"\nClass Name : {Name}\n";
        }



    }
}
