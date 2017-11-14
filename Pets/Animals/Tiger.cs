using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pets
{
    class Tiger: Pets
    {
        protected double tailLength;

        public Tiger() :base()
        {

        }
        public Tiger(string name, int age, string type, string food, string phrase, double tailLength) : base (name, age, type, food, phrase)
        {
            this.tailLength = tailLength;
        }

        public double TailLength { get { return tailLength; } set { tailLength = value; } }

        public override void Eating()
        {
            base.Eating();
        }

        public override void Aging(int years)
        {
            base.Aging(years+1);
        }

        public override string InfoAbout(Pets obj)
        {
            return base.InfoAbout(obj)+ "\nTail length: " + tailLength;
        }

        public override string MakeSomeNoize()
        {
            return base.MakeSomeNoize();
        }
    }
}
