using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises1_20_1
{
    class Person
    {
        public string name { get; set; }
        public int height { get; set; }
        public int age { get; set; }

        public Person(string n, int h, int a)
        {
            name = n;
            height = h;
            age = a;
        }
    }
}
