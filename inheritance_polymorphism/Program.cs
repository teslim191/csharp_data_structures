using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance_polymorphism
{
    class Animal
    {
        public string Name { get; set; }
        public string Sound { get; set; }

        public Animal()
            :this("No Name", "No Sound") { }

        public Animal(string name)
            :this(name, "No Sound"){ }

        public Animal(string name, string sound)
        {
            Name = name;
            Sound = sound;
        }
     

        public virtual void MakeSound()
        {
            //making use of string interpolation
            Console.WriteLine($"{Name} makes sound {Sound}");
        }

        //working with interclass
        public class AnimalHealth
        {
            public bool HealthyAnimal(double weight, double height)
            {
                double health = weight / height;
                if ((health > .18) && (weight <= .15))
                {
                    return true;
                }
                else return false;
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Animal cat = new Animal()
            {
                Name = "Tom",
                Sound = "Meow"
            };
            cat.MakeSound();

            //derived class
            Dog dog_1 = new Dog()
            {
                Name = "Jake",
                Breed = "Labrador",
                Sound = "wooof"
            };

            dog_1.AnimalDesc();
            //derived class can make use of method from base class
            dog_1.MakeSound();

            Animal.AnimalHealth new_health = new Animal.AnimalHealth();
            Console.WriteLine("is animal healthy? {0}",new_health.HealthyAnimal(56.5,78.5));

            //polymorphism
            Animal animal_3 = new Animal()
            {
                Name = "Butch",
                Sound = "Meowww"
            };

            Animal dog_2 = new Dog()
            {
                Name = "John",
                Breed = "bull dog",
                Sound = "woof",
                Sound2 = "woooof"
            };
            animal_3.MakeSound();
            // it doesnt call sound2 from the overwritten method. it is calling the animal version of make sound
            dog_2.MakeSound();

            //with polymorphism, we want to call the Dog version of make sound 
            // add virtual keyword to the animal version of MakeSound that way, it can be overwritten
            // replace new with override to the Dog version of MakeSound
            
        }
    }
}
