using Zoo.Model.Contract;

namespace Zoo.Model
{
    public abstract class Animal : IAnimal
    {
        private int healthPoints;
        private int deadHealth;
        public Animal(int deadHealth)
        {
            this.HealthPoints = 100;
            this.deadHealth = deadHealth;
        }

        public bool IsAlive => HealthPoints >= deadHealth;

        public int HealthPoints { get => healthPoints; internal set => this.healthPoints = value; }

        public void Feed(int food)
        {
            HealthPoints += food;
        }

        public abstract void Hungry();

    }
}
