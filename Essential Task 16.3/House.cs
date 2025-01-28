using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential_Task_16._3
{
    class House : ICloneable
    {
        public House(IEnumerable<Person> people)
        {
            People = new List<Person>(people);    
        }

        public double RentCost { get; set; }
        public List<Person> People { get; private set; }

        public object Clone()
        {
            return MemberwiseClone();
        }

        public House DeepClone()
        {
            var clone = Clone() as House;
            clone.People = [];

            return clone;
        }
    }
}
