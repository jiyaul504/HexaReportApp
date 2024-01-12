namespace HexaReportApp.Models
{
    public class MonthlyReportDisplay
    {
        public MonthReport Report { get; set;}
        public EmpMast Employee { get; set; }

    }

    public class MonthlyReportDisplaySummary
    {
        public string Empcode { get; set; }
        public int totalPresentCount { get; set; }
        public int totalWOCount { get; set; }
        public int totalHLCount { get; set; }
        public int totalLVCount { get; set; }
        public int totalAbsent { get; set; }
        public string totalOT { get; set; }
        public string totalOTPlusWork { get; set; } = string.Empty;

    }


}
 