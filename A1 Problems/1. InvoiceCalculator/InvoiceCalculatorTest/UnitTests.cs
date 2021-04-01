using InvoiceCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InvoiceCalculatorTest
{
    [TestClass]
    public class UnitTests
    {

        [TestMethod]
        public void TestMethod1()
        {
            decimal monthlyFee = 9.99m;
            int numberSms = 2;
            int numberMms = 0;
            int overIncludeMinutesA1 = 15;
            int minutesToTelenor = 6;
            int minutesToVivacom = 32;
            int minutesInRoaming = 0;
            int overIncludeMb = 0;
            int mbInEU = 0;
            int mbOutEU = 0;
            decimal otherFee = 1.99m;
            decimal discount = 1.50m;
            var fees = new Fees(monthlyFee, numberSms, numberMms, overIncludeMinutesA1, minutesToTelenor, minutesToVivacom,
                                                minutesInRoaming, overIncludeMb, mbInEU, mbOutEU, otherFee, discount);


            var result = Program.Result(fees);
            Assert.AreEqual(14.71m, result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            decimal monthlyFee = 9.99m;
            int numberSms = 51;
            int numberMms = 3;
            int overIncludeMinutesA1 = 15;
            int minutesToTelenor = 6;
            int minutesToVivacom = 32;
            int minutesInRoaming = 5;
            int overIncludeMb = 7;
            int mbInEU = 14;
            int mbOutEU = 21;
            decimal otherFee = 1.99m;
            decimal discount = 1.50m;
            var fees = new Fees(monthlyFee, numberSms, numberMms, overIncludeMinutesA1, minutesToTelenor, minutesToVivacom,
                                               minutesInRoaming, overIncludeMb, mbInEU, mbOutEU, otherFee, discount);

            var result = Program.Result(fees);

            Assert.AreEqual(29.05m, result);
        }
    }
}
