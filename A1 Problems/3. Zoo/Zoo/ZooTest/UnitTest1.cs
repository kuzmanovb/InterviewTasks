using NUnit.Framework;
using Zoo.Model;

namespace ZooTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestMonkeyFeedMethod()
        {
            var monkey = new Monkey();

            monkey.Feed(10);

            Assert.AreEqual(110, monkey.HealthPoints);
        }

        [Test]
        public void TestMonkeyHungryMethod()
        {
            var monkey = new Monkey();

            monkey.Hungry();

            Assert.AreNotEqual(100, monkey.HealthPoints);
        }

        [Test]
        public void TestMonkeyAliveMethod()
        {
            var monkey = new Monkey();

            for (int i = 0; i < 8; i++)
            {
                monkey.Hungry();
            }


            Assert.IsFalse(monkey.IsAlive);
        }

        [Test]
        public void TestElephantCanNotWalkerMethod()
        {
            var elephant = new Elephant();

            for (int i = 0; i < 8; i++)
            {

                elephant.Hungry();
            }

            Assert.IsTrue(elephant.CanNotWalker);
            Assert.IsFalse(elephant.IsAlive);
        }

        [Test]
        public void TestLionFeedMethod()
        {
            var lion = new Lion();

            lion.Feed(10);

            Assert.AreEqual(110, lion.HealthPoints);
        }

        [Test]
        public void TestLionHungryMethod()
        {
            var lion = new Lion();

            lion.Hungry();

            Assert.AreNotEqual(100, lion.HealthPoints);
        }

        [Test]
        public void TestLionAliveMethod()
        {
            var lion = new Lion();

            for (int i = 0; i < 9; i++)
            {
            lion.Hungry();

            }
          
            Assert.IsFalse(lion.IsAlive);
        }


    }
}