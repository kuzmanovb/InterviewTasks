using System;

namespace Zoo.Model
{
    public class Lion : Animal
    {
        private const int deadHealthLion = 50;
        public Lion(int deadHealth = deadHealthLion)
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
