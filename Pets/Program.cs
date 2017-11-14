using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pets
{
   
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            List<Tiger> tigers = new List<Tiger>();
            List<string> names =  new List<string>();
            names.Add("Petya");
            names.Add("Vasya");
            names.Add("Kolya");
            names.Add("Andrey");
            names.Add("Dima");

            List<int> ages = new List<int>();
            ages.Add(1);
            ages.Add(5);
            ages.Add(4);
            ages.Add(3);
            ages.Add(2);

            List<string> phrases = new List<string>();
            phrases.Add("Ave");
            phrases.Add("Maria");
            phrases.Add("De");
            phrases.Add("Us");
            phrases.Add("Vult");

            List<string> types  = new List<string>();
            types.Add("Panthera tigris altaica");
            types.Add("Panthera tigris tigris");
            types.Add("Panthera tigris corbetti");
            types.Add("Panthera tigris jacksoni");
            types.Add("Panthera tigris sumatrae");
            types.Add("Panthera tigris amoyensis");
            types.Add("Panthera tigris balica");



            for (int i = 0; i < 100; i++)
            {
                Tiger newTiger = new Tiger();
                newTiger.Name = names[rnd.Next(names.Count)];
                newTiger.Age = ages[rnd.Next(ages.Count)];
                newTiger.Type = types[rnd.Next(types.Count)];
                newTiger.Food = "Meat";
                newTiger.Pharse = phrases[rnd.Next(phrases.Count)];
                newTiger.TailLength = 3.14;
                
                tigers.Add(newTiger);
            }

            /*      for(int i = 0; i<tigers.Count; i++)
              {
                  Console.WriteLine(i + ". " + tigers[i].InfoAbout(tigers[i])+ "\n");
              }

              tigers[8].InfoAbout(tigers[8]);
              tigers[15].Sleep();
              tigers[28].Aging(9);
              tigers[50].Eating();
              */

            /*for (int i = 1; i <= tigers.Count; i++)
            {
                Console.WriteLine(i + ". " +  tigers[i].MakeSomeNoize() );
            }*/
            Console.ReadKey();
        }

        

    }
}
