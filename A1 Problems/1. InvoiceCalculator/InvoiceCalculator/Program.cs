using System;

namespace InvoiceCalculator
{
    public class Program
    {
        //public static decimal monthlyFee;
        //public static int numberSms;
        //public static int numberMms;
        //public static int overIncludeMinutesA1;
        //public static int minutesToTelenor;
        //public static int minutesToVivacom;
        //public static int minutesInRoaming;
        //public static int overIncludeMb;
        //public static int mbInEU;
        //public static int mbOutEU;
        //public static decimal otherFee;
        //public static decimal discount;

        static void Main(string[] args)
        {
            bool flag = true;

            while (flag)
            {
                try
                {
                    Console.WriteLine("Моля въведете следните дани за фактурата" + Environment.NewLine);

                    Console.Write("- месечна такса: ");
                    decimal monthlyFee = decimal.Parse(Console.ReadLine());

                    Console.Write("- изпратени SMS: ");
                    int numberSms = int.Parse(Console.ReadLine());

                    Console.Write("- изпратени MMS: ");
                    int numberMms = int.Parse(Console.ReadLine());

                    Console.Write("- минути към А1 извън включените: ");
                    int overIncludeMinutesA1 = int.Parse(Console.ReadLine());

                    Console.Write("- минути към Теленор извън включените: ");
                    int minutesToTelenor = int.Parse(Console.ReadLine());

                    Console.Write("- минути към Виваком извън включените: ");
                    int minutesToVivacom = int.Parse(Console.ReadLine());

                    Console.Write("- минути в роуминг: ");
                    int minutesInRoaming = int.Parse(Console.ReadLine());

                    Console.Write("- използвани МБ в страната извън влючените: ");
                    int overIncludeMb = int.Parse(Console.ReadLine());

                    Console.Write("- използвани МБ в ЕС извън влючените: ");
                    int mbInEU = int.Parse(Console.ReadLine());

                    Console.Write("- използвани МБ извън ЕС извън влючените: ");
                    int mbOutEU = int.Parse(Console.ReadLine());

                    Console.Write("- други такси: ");
                    decimal otherFee = decimal.Parse(Console.ReadLine());

                    Console.Write("- отстъпки: ");
                    decimal discount = decimal.Parse(Console.ReadLine());
                    Console.WriteLine();

                    var feeds = new Fees(monthlyFee, numberSms, numberMms, overIncludeMinutesA1, minutesToTelenor, minutesToVivacom,
                                                minutesInRoaming, overIncludeMb, mbInEU, mbOutEU, otherFee, discount);

                    decimal invoiceSum = Result(feeds);
                    PrintResult(invoiceSum);

                    flag = false;
                }
                catch
                {
                    Console.WriteLine("Грешно въведени данни" + Environment.NewLine);
                }
            }

        }


        public static decimal Result(Fees fees)
        {
            decimal result = fees.MonthlyFee;

            // Add SMS sum to result
            if (fees.NumberSms < 50)
            {
                result += fees.NumberSms * 0.18m;
            }
            else if (fees.NumberSms >= 50 && fees.NumberSms <= 100)
            {
                result += fees.NumberSms * 0.16m;
            }
            else
            {
                result += fees.NumberSms * 0.11m;
            }

            // Add MMS sum to result
            if (fees.NumberMms < 50)
            {
                result += fees.NumberMms * 0.25m;
            }
            else if (fees.NumberMms >= 50 && fees.NumberMms <= 100)
            {
                result += fees.NumberMms * 0.23m;
            }
            else
            {
                result += fees.NumberMms * 0.18m;
            }

            result += fees.OverIncludeMinutesA1 * 0.03m;
            result += (fees.MinutesToTelenor + fees.MinutesToVivacom) * 0.09m;
            result += fees.MinutesInRoaming * 0.15m;
            result += fees.OverIncludeMb * 0.02m;
            result += fees.MbInEU * 0.05m;
            result += fees.MbOutEU * 0.20m;
            result += fees.OtherFee;
            result -= fees.Discount;

            return result;
        }

        public static void PrintResult(decimal result)
        {
            Console.WriteLine($"Дължимата сума: {result:f2} лв.");
        }
    }
}
