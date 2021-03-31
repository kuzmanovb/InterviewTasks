namespace Zoo.Model.Contract
{
    public interface IAnimal
    {
        int HealthPoints { get;}

        bool IsAlive { get;}

        void Hungry();

        void Feed(int food);
    }
}
