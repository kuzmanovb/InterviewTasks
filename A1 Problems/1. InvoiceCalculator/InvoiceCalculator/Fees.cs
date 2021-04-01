namespace InvoiceCalculator
{
    public class Fees
    {
        public Fees(decimal monthlyFee, int numberSms, int numberMms, int overIncludeMinutesA1, int minutesToTelenor, int minutesToVivacom,
                                     int minutesInRoaming, int overIncludeMb, int mbInEU, int mbOutEU, decimal otherFee, decimal discount)
        {
            MonthlyFee = monthlyFee;
            NumberSms = numberSms;
            NumberMms = numberMms;
            OverIncludeMinutesA1 = overIncludeMinutesA1;
            MinutesToTelenor = minutesToTelenor;
            MinutesToVivacom = minutesToVivacom;
            MinutesInRoaming = minutesInRoaming;
            OverIncludeMb = overIncludeMb;
            MbInEU = mbInEU;
            MbOutEU = mbOutEU;
            OtherFee = otherFee;
            Discount = discount;
        }

        public decimal MonthlyFee { get; set; }
        public int NumberSms { get; set; }
        public int NumberMms { get; set; }
        public int OverIncludeMinutesA1 { get; set; }
        public int MinutesToTelenor { get; set; }
        public int MinutesToVivacom { get; set; }
        public int MinutesInRoaming { get; set; }
        public int OverIncludeMb { get; set; }
        public int MbInEU { get; set; }
        public int MbOutEU { get; set; }
        public decimal OtherFee { get; set; }
        public decimal Discount { get; set; }
    }
}
