using Zoo.Model.Contract;

namespace Zoo.Core.Contract
{
    public interface IController
    {
        void HungryAnimals(IAnimal[] animals);

        void FeedAnimals(IAnimal[] animals);

        int AliveAnimals(IAnimal[] animals);
    }
}
