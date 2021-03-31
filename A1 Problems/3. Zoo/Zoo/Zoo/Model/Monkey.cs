using System;

namespace Zoo.Model
{
    public class Monkey : Animal
    {
        private const int deadHealthMonky = 40;
        public Monkey(int deadHealth = deadHealthMonky) 
                   : base(deadHealth)
        {
        }
        public override void Hungry()
        {
            Random rnd = new Random();
            int hungry = rnd.Next(0, 20);

            HealthPoints -= hungry;
        }

    }
}
