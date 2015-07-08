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

    interface IAnimal
    {
        string Name { get; set; }
        string MakeSound();
    }

    interface IBird
    {

    }

    class Bear : IAnimal
    {
        public string Name { get; set; }

        public Bear()
        {
            this.Name = "Bear";
        }

        public string MakeSound()
        {
            if (this is IBird)
            {
                return "Roar! Flap, flap, flap.";
            }
            else
            {
                return "Roar!";
            }
        }
    }

    class Chicken : IAnimal, IBird
    {
        public string Name { get; set; }

        public Chicken()
        {
            this.Name = "Chicken";
        }

        public string MakeSound()
        {
            if (this is IBird)
            {
                return "Bwaawk! Flap, flap, flap.";
            }
            else
            {
                return "Bwaawk!";
            }
        }
    }

    class Eagle : IAnimal, IBird
    {
        public string Name { get; set; }

        public Eagle()
        {
            this.Name = "Eagle";
        }

        public string MakeSound()
        {
            if (this is IBird)
            {
                return "Scree! Flap, flap, flap.";
            }
            else
            {
                return "Scree!";
            }
        }
    }

    class AnimalUtility
    {
        public static void DoSomething(IAnimal a)
        {
            Console.WriteLine(string.Format("A {0} makes a sound like {1}", a.Name, a.MakeSound()));
        }
    }
}
