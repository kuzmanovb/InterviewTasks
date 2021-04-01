namespace Zoo.Model
{
    public class Lion : Animal
    {
        private const int deadHealthLion = 50;
        public Lion(int deadHealth = deadHealthLion)
                   : base(deadHealth)
        {
        }
    }
}
