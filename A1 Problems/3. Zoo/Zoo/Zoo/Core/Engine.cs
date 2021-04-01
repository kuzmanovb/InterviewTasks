using System;
using Zoo.Model;
using Zoo.Core.Contract;
using Zoo.Model.Contract;

namespace Zoo.Core
{
    public class Engine : IEngine
    {
        private readonly IController controller;

        public Engine()
        {
            this.controller = new Controller();
        }


        public void Run()
        {

            var animals = new IAnimal[15];
            for (int i = 0; i < 15; i++)
            {
                if (i <= 5)
                {
                   animals[i] = new Monkey(); 
                }
                else if (i <= 10)
                {
                    animals[i] = new Lion();
                }
                else
                {
                    animals[i] = new Elephant();
                }
            }
           

           while(true)
            {

                try
                {
                    Console.WriteLine("Enter a command (Feed, Hungry, Alive, Exit): ");
                    string command = Console.ReadLine();

                    if (command == "Exit")
                    {
                        Environment.Exit(0);
                    }
                    else if (command == "Feed")
                    {
                        controller.FeedAnimals(animals);

                    }
                    else if (command == "Hungry")
                    {
                        controller.HungryAnimals(animals);
                    }
                    else if (command == "Alive")
                    {
                        Console.WriteLine(controller.AliveAnimals(animals));

                    }
                }
                catch
                {
                    Console.WriteLine("Wrong entry");
                }

            }
        }
    }
}
