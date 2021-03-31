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
            IAnimal monkey1 = new Monkey();
            IAnimal monkey2 = new Monkey();
            IAnimal monkey3 = new Monkey();
            IAnimal monkey4 = new Monkey();
            IAnimal monkey5 = new Monkey();

            IAnimal lion1 = new Monkey();
            IAnimal lion2 = new Monkey();
            IAnimal lion3 = new Monkey();
            IAnimal lion4 = new Monkey();
            IAnimal lion5 = new Monkey();

            IAnimal elephant1 = new Monkey();
            IAnimal elephant2 = new Monkey();
            IAnimal elephant3 = new Monkey();
            IAnimal elephant4 = new Monkey();
            IAnimal elephant5 = new Monkey();

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
                        controller.FeedAnimals(monkey1, monkey2, monkey3, monkey4, monkey5,
                                               lion1, lion2, lion3, lion4, lion5,
                                               elephant1, elephant2, elephant3, elephant4, elephant5);

                    }
                    else if (command == "Hungry")
                    {
                        controller.HungryAnimals(monkey1, monkey2, monkey3, monkey4, monkey5,
                                               lion1, lion2, lion3, lion4, lion5,
                                               elephant1, elephant2, elephant3, elephant4, elephant5);
                    }
                    else if (command == "Alive")
                    {
                        Console.WriteLine(controller.AliveAnimals(monkey1, monkey2, monkey3, monkey4, monkey5,
                                               lion1, lion2, lion3, lion4, lion5,
                                               elephant1, elephant2, elephant3, elephant4, elephant5));

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
