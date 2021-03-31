using Zoo.Core;
using Zoo.Core.Contract;

namespace Zoo
{
    public class StaptUp
    {
        static void Main(string[] args)
        {
            IEngine engine = new Engine();
            engine.Run();
        }
    }
}
