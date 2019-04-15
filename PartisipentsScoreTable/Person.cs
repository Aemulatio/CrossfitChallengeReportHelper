using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartisipentsScoreTable
{
  public class Person
    {
        public int Number { get; set; }
        public string Name { get; set; }

        public Person() { }


        public Person(int number, string name)
        {
            Number = number;
            Name = name;
        }
    }
}