using System;

namespace OOP_PartI
{
    class Program
    {
        class Dog
        {
            string name;
            int spots;
            double happiness;

            public Dog(string _name, int _spots)
            {
                name = _name;
                spots = _spots;
                happiness = 0;
                Console.WriteLine($"The dog {name} has been created.");
            }
            public string Name
            {
                get { return name; }
            }

            public int Spots
            {
                get { return spots; }
            }

            public double Happiness
            {
                get { return happiness; }
            }

            public void Barks()
            {
                Console.WriteLine("Woof-woof");
                happiness += 0.2; 
            }
            public void Wags()
            {
                Console.WriteLine($"{name}: Wiggle-wiggle");
            }
            public void Rename(string newName)
            {
                name = newName;
            }
            public void ShowDogData()
            {
                Console.WriteLine($"name: {name}");
                Console.WriteLine($"spots: {spots}");
                Console.WriteLine($"level of happiness: {happiness}");
            }
        }
        static void Main(string[] args)
        {
            Dog myDog = new Dog("Koer", 15);
            myDog.Barks();
            Console.WriteLine($"{myDog.Name}'s level of happiness: {myDog.Happiness}");
            Dog lolDog = new Dog("Dogwater", 69);
            Console.WriteLine($"{lolDog.Name}'s level of happiness: {lolDog.Happiness}");
            
            while(myDog.Happiness != 1)
            {
                myDog.Barks();
            }
            myDog.Wags();

            Console.WriteLine($"Enter a new name for the dog {myDog.Name}");
            string userInput = Console.ReadLine();
            myDog.Rename(userInput);
            myDog.ShowDogData();




        }
    }
}