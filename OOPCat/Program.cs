using System;

namespace OOPCat
{
    class Program
    {
        class Dog
        {
            string name;
            string spots;
            double happiness;

            public Dog(string _name, string _spots)
            {
                name = _name;
                spots = _spots;
                happiness = 0;
                Console.WriteLine($"The cat {name} has been created.");
            }
            public string Name
            {
                get { return name; }
            }

            public string Spots
            {
                get { return spots; }
            }

            public double Happiness
            {
                get { return happiness; }
            }

            public void Barks()
            {
                Console.WriteLine($"{Name} is sleeping...");
                Console.WriteLine("Hunger has increased by 0.2");
                happiness += 0.2;
            }
            public void Wags()
            {
                Console.WriteLine($"{name}: Meow");
            }
          
            public void ShowDogData()
            {
                Console.WriteLine($"name: {name}");
                Console.WriteLine($"color: {spots}");
                Console.WriteLine($"level of happiness: {happiness}");
            }
        }
        static void Main(string[] args)
        {
            Dog myDog = new Dog("kass", "black");
            myDog.Barks();
            Console.WriteLine($"{myDog.Name}'s level of happiness: {myDog.Happiness}");

            while (myDog.Happiness != 1)
            {
                myDog.Barks();
            }
            myDog.Wags();

            Console.WriteLine("Input:");
            string userInput = Console.ReadLine();
            if(userInput == ".")
            {
                myDog.ShowDogData();
            }
            else
            {
                Console.WriteLine("Invalid input");
            }



        }
    }
}