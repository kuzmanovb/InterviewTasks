using System;

namespace Zoo.Model
{
    public class Еlephant : Animal
    {
        private bool isAlive;
        public Еlephant(int deadHealth = 0)
                   : base(deadHealth)
        {
            this.IsAlive = true;
        }

        public new bool IsAlive { get => isAlive; set => isAlive = value;}

        public bool CanNotWalker { get; set; }

        public override void Hungry()
        {
            Random rnd = new Random();
            int hungry = rnd.Next(0, 20);

            HealthPoints -= hungry;

            if (CanNotWalker)
            {
                IsAlive = false;
            }
            
            if (HealthPoints < 70)
            {
                CanNotWalker = true;
            }
            

            
        }
    }
}
