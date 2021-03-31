using System;
using Zoo.Core.Contract;
using Zoo.Model.Contract;

namespace Zoo.Core
{
    public class Controller : IController
    {
        public int AliveAnimals(IAnimal monkey1, IAnimal monkey2, IAnimal monkey3, IAnimal monkey4, IAnimal monkey5,
                                IAnimal lion1, IAnimal lion2, IAnimal lion3, IAnimal lion4, IAnimal lion5,
                                IAnimal elephant1, IAnimal elephant2, IAnimal elephant3, IAnimal elephant4, IAnimal elephant5)
        {
            int aliveAnimal = 0;

            if (monkey1.IsAlive)
            { aliveAnimal++; }

            if (monkey2.IsAlive)
            { aliveAnimal++; }

            if (monkey3.IsAlive)
            { aliveAnimal++; }

            if (monkey4.IsAlive)
            { aliveAnimal++; }

            if (monkey5.IsAlive)
            { aliveAnimal++; }

            if (lion1.IsAlive)
            { aliveAnimal++; }

            if (lion2.IsAlive)
            { aliveAnimal++; }

            if (lion3.IsAlive)
            { aliveAnimal++; }

            if (lion4.IsAlive)
            { aliveAnimal++; }

            if (lion5.IsAlive)
            { aliveAnimal++; }


            if (elephant1.IsAlive)
            { aliveAnimal++; }

            if (elephant2.IsAlive)
            { aliveAnimal++; }

            if (elephant3.IsAlive)
            { aliveAnimal++; }

            if (elephant4.IsAlive)
            { aliveAnimal++; }

            if (elephant5.IsAlive)
            { aliveAnimal++; }

            return aliveAnimal;

        }

        public void FeedAnimals(IAnimal monkey1, IAnimal monkey2, IAnimal monkey3, IAnimal monkey4, IAnimal monkey5,
                                IAnimal lion1, IAnimal lion2, IAnimal lion3, IAnimal lion4, IAnimal lion5,
                                IAnimal elephant1, IAnimal elephant2, IAnimal elephant3, IAnimal elephant4, IAnimal elephant5)
        {
            Random rnd = new Random();
            int monkeyFood = rnd.Next(5, 25);
            int lionFood = rnd.Next(5, 25);
            int elephantFood = rnd.Next(5, 25);

            monkey1.Feed(monkeyFood);
            monkey2.Feed(monkeyFood);
            monkey3.Feed(monkeyFood);
            monkey4.Feed(monkeyFood);
            monkey5.Feed(monkeyFood);


            lion1.Feed(lionFood);
            lion2.Feed(lionFood);
            lion3.Feed(lionFood);
            lion4.Feed(lionFood);
            lion5.Feed(lionFood);


            elephant1.Feed(elephantFood);
            elephant2.Feed(elephantFood);
            elephant3.Feed(elephantFood);
            elephant4.Feed(elephantFood);
            elephant5.Feed(elephantFood);
        }

        public void HungryAnimals(IAnimal monkey1, IAnimal monkey2, IAnimal monkey3, IAnimal monkey4, IAnimal monkey5,
                                  IAnimal lion1, IAnimal lion2, IAnimal lion3, IAnimal lion4, IAnimal lion5,
                                  IAnimal elephant1, IAnimal elephant2, IAnimal elephant3, IAnimal elephant4, IAnimal elephant5)
        {

            monkey1.Hungry();
            monkey2.Hungry();
            monkey3.Hungry();
            monkey4.Hungry();
            monkey5.Hungry();


            lion1.Hungry();
            lion2.Hungry();
            lion3.Hungry();
            lion4.Hungry();
            lion5.Hungry();


            elephant1.Hungry();
            elephant2.Hungry();
            elephant3.Hungry();
            elephant4.Hungry();
            elephant5.Hungry();
        }
    }
}
