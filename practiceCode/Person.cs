using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practiceCode
{
    internal class Person
    {
        public string name = "Bob";
        public int weight = 150;
        public static string species = "Human";
        public static int personCount = 0;

        public Person(string newName)
        {
            name = newName;
            personCount++;
        }

        public Person(string newName, int newWeight) 
        {
            name = newName;
            weight = newWeight;
            personCount++;
        }

        public void Eat(int val)
        {
            weight += val;
        }

        public char FirstInitial()
        {
            return name[0];
        }
    }
}
