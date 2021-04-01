using System;
using Zoo.Core.Contract;
using Zoo.Model;
using Zoo.Model.Contract;

namespace Zoo.Core
{
    public class Controller : IController
    {
        public int AliveAnimals(IAnimal[] animals)
        {
            int aliveAnimal = 0;

            for (int i = 0; i < animals.Length; i++)
            {
                if (animals[i].IsAlive)
                { aliveAnimal++; }
            }
           
            return aliveAnimal;

        }

        public void FeedAnimals(IAnimal[] animals)
        {
            Random rnd = new Random();
            int monkeyFood = rnd.Next(5, 25);
            int lionFood = rnd.Next(5, 25);
            int elephantFood = rnd.Next(5, 25);

            for (int i = 0; i < animals.Length; i++)
            {
                if (animals[i].GetType() == typeof(Monkey))
                {
                    animals[i].Feed(monkeyFood);
                }
                else if (animals[i].GetType() == typeof(Lion))
                {
                    animals[i].Feed(lionFood);
                }
                else if (animals[i].GetType() == typeof(Elephant))
                {
                    animals[i].Feed(elephantFood);
                }
            }
        }

        public void HungryAnimals(IAnimal [] animals)
        {

            for (int i = 0; i < animals.Length; i++)
            {
                animals[i].Hungry();
            }
        }
    }
}
