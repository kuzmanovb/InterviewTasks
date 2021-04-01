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
      

    }
}
