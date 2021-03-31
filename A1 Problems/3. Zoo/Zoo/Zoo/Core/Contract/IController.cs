using Zoo.Model.Contract;

namespace Zoo.Core.Contract
{
    public interface IController
    {
        void HungryAnimals(IAnimal monkey1, IAnimal monkey2, IAnimal monkey3, IAnimal monkey4, IAnimal monkey5,
                           IAnimal lion1, IAnimal lion2, IAnimal lion3, IAnimal lion4, IAnimal lion5,
                           IAnimal elephant1, IAnimal elephant2, IAnimal elephant3, IAnimal elephant4, IAnimal elephant5);

        void FeedAnimals(IAnimal monkey1, IAnimal monkey2, IAnimal monkey3, IAnimal monkey4, IAnimal monkey5,
                         IAnimal lion1, IAnimal lion2, IAnimal lion3, IAnimal lion4, IAnimal lion5,
                         IAnimal elephant1, IAnimal elephant2, IAnimal elephant3, IAnimal elephant4, IAnimal elephant5);

        int AliveAnimals(IAnimal monkey1, IAnimal monkey2, IAnimal monkey3, IAnimal monkey4, IAnimal monkey5,
                         IAnimal lion1, IAnimal lion2, IAnimal lion3, IAnimal lion4, IAnimal lion5,
                         IAnimal elephant1, IAnimal elephant2, IAnimal elephant3, IAnimal elephant4, IAnimal elephant5);
    }
}
