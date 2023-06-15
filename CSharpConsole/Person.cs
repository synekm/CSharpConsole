using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConsole
{
    internal class Person
    {
        public Person(string name, int age, int hp = 100)
        {
            Name = name;
            Age = age;
            Hp = hp;
        }

        public string Name { get; set; }
        public int Age { get; set; }
        public int Hp { get; set; }
    }
}
