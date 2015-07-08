using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Bear b = new Bear();
            Chicken c = new Chicken();
            Eagle e = new Eagle();

            AnimalUtility.DoSomething(b);
            AnimalUtility.DoSomething(c);
            AnimalUtility.DoSomething(e);

            //pause
            Console.ReadLine();
        }
    }

    abstract class Animal
    {
        public string Name { get; set; }
        public string Sound { get; set; }

        public string MakeSound()
        {
            if (this is IBird)
            {
                return this.Sound + " Flap, flap, flap.";
            }
            else
            {
                return this.Sound;
            }
        }
    }

    interface IBird
    {

    }

    class Bear : Animal
    {
        public Bear()
        {
            Name = "Bear";
            Sound = "Roar!";
        }
    }

    class Chicken : Animal, IBird
    {
        public Chicken()
        {
            Name = "Chicken";
            Sound = "Bwaawk!";
        }
    }

    class Eagle : Animal, IBird
    {
        public Eagle()
        {
            Name = "Eagle";
            Sound = "Scree!";
        }
    }

    class AnimalUtility
    {
        public static void DoSomething(Animal a)
        {
            Console.WriteLine(string.Format("A {0} makes a sound like {1}", a.Name, a.MakeSound()));
        }
    }
}
