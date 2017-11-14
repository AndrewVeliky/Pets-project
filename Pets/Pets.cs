using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pets
{
    class Pets
    {
        protected string name;
        protected int age;
        protected string type;
        protected string food;
        protected string phrase;

        public Pets()
        {

        }

        public Pets(string name, int age, string type, string food, string phrase)
        {
            this.name = name;
            this.age = age;
            this.type = type;
            this.food = food;
            this.phrase = phrase;
        }

        
        public string Name { set; get; }

        public int Age { set { age = value; } get { return age; } }

        public string Type { set { type = value; } get { return type; } }

        public string Food { set { food = value; } get { return food; } }

        public string Pharse { set { phrase = value; } get { return phrase; } }


        public virtual void Eating()
        {
            Console.WriteLine("{0} eat some {1}",name, food);
        }


        public virtual void Aging(int years)
        {
            age+=years;
            Console.WriteLine("{0} become older on {1} years", name, years);
            Console.WriteLine("Now {0} {1} years old.",name, age);
        }

        public virtual void Sleep()
        {
            Console.WriteLine("ZzzZzzzZzzz");
        }

        public virtual string InfoAbout(Pets obj)
        {
            string info = "Name: " + name +
                "\nAge: " + age + "\nType: " + type;
            return info;
        }

        public virtual string MakeSomeNoize()
        {
            string noize = name + " say: " + phrase;
            return noize;
        }
    }
}
