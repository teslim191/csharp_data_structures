namespace inheritance_polymorphism
{
    //class Dog which is the derived class inherits from Class Animal which is the base class
    class Dog: Animal
    {
        public string Breed { get; set; }
        public string Sound2 { get; set; }

        public Dog()
            :this("No breed","No Sound","No Name","No Sound") { }
        public Dog(string breed, string sound2, string name, string sound)
            :base(name, sound)
        {
            Breed = breed;
            Sound2 = sound2;
        }

        public void AnimalDesc()
        {
            System.Console.WriteLine($"{Name} belongs to the breed of {Breed} made a sound {Sound}");

        }

        //overwrite the method using void
        // replace new with override
        public override void MakeSound()
        {
            System.Console.WriteLine($"{Name} makes a sound {Sound} and sound {Sound2}");
        }

    }
}
