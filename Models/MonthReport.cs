using System;
using System.Collections.Generic;

namespace HexaReportApp.Models;

public partial class MonthReport
{
    public int Id { get; set; }

    public string? Empcode { get; set; }

    public DateTime? Date { get; set; }

    public string? Shift { get; set; }

    public string? Woff1 { get; set; }

    public string? Woff2 { get; set; }

    public string? MonthName { get; set; }

    public string? Year { get; set; }

    public string? TotalWork { get; set; }

    public string? TotalPresent { get; set; }

    public string? TotalAbsent { get; set; }

    public string? Intime { get; set; }

    public string? Outtime { get; set; }

    public string? WorkTime { get; set; }

    public string? OverTime { get; set; }

    public string? BreakTime { get; set; }

    public string? Status { get; set; }

    public string? Day { get; set; }

    public string? TotalOverTime { get; set; }

    public string? DateString { get; set; }

    public string? Out1 { get; set; }

    public string? In2 { get; set; }

    public string? Out2 { get; set; }

    public string? In3 { get; set; }

    public string? Out3 { get; set; }

    public string? In4 { get; set; }

    public string? Out4 { get; set; }

    public string? In5 { get; set; }

    public string? Out5 { get; set; }

    public string? In6 { get; set; }

    public string? Out6 { get; set; }

    public string? In7 { get; set; }

    public string? Out7 { get; set; }

    public string? In8 { get; set; }

    public string? Remark1 { get; set; }

    public string? Remark2 { get; set; }

    public string? ErlIn { get; set; }

    public string? ErlOut { get; set; }

    public string? LateIn { get; set; }

    public string? Ot { get; set; }

    public string? Ei { get; set; }

    public string? Eo { get; set; }

    public string? Lt { get; set; }

    public string? Otm { get; set; }

    public string? Lin { get; set; }

    public string? Lout { get; set; }

    public string? Lesswrk { get; set; }

    public string? Wo { get; set; }
}
