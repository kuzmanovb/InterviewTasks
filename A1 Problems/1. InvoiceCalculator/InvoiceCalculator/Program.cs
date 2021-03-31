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

                    decimal invoiceSum = Result(monthlyFee, numberSms, numberMms, overIncludeMinutesA1, minutesToTelenor, minutesToVivacom,
                                                minutesInRoaming, overIncludeMb, mbInEU, mbOutEU, otherFee, discount);
                    PrintResult(invoiceSum);

                    flag = false;
                }
                catch
                {
                    Console.WriteLine("Грешно въведени данни" + Environment.NewLine);
                }
            }

        }


        public static decimal Result(decimal monthlyFee, int numberSms, int numberMms, int overIncludeMinutesA1, int minutesToTelenor, int minutesToVivacom,
                                     int minutesInRoaming, int overIncludeMb, int mbInEU, int mbOutEU, decimal otherFee, decimal discount)
        {
            decimal result = monthlyFee;

            // Add SMS sum to result
            if (numberSms < 50)
            {
                result += numberSms * 0.18m;
            }
            else if (numberSms >= 50 && numberSms <= 100)
            {
                result += numberSms * 0.16m;
            }
            else
            {
                result += numberSms * 0.11m;
            }

            // Add MMS sum to result
            if (numberMms < 50)
            {
                result += numberMms * 0.25m;
            }
            else if (numberMms >= 50 && numberMms <= 100)
            {
                result += numberMms * 0.23m;
            }
            else
            {
                result += numberMms * 0.18m;
            }

            result += overIncludeMinutesA1 * 0.03m;
            result += (minutesToTelenor + minutesToVivacom) * 0.09m;
            result += minutesInRoaming * 0.15m;
            result += overIncludeMb * 0.02m;
            result += mbInEU * 0.05m;
            result += mbOutEU * 0.20m;
            result += otherFee;
            result -= discount;

            return result;
        }

        public static void PrintResult(decimal result)
        {
            Console.WriteLine($"Дължимата сума: {result:f2} лв.");
        }
    }
}
