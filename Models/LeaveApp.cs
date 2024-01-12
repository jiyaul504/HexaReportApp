using System;
using System.Collections.Generic;

namespace HexaReportApp.Models;

public partial class LeaveApp
{
    public string? Empcode { get; set; }

    public string? Optype { get; set; }

    public DateTime? FromDate { get; set; }

    public DateTime? ToDate { get; set; }

    public string? LeaveCode { get; set; }

    public int? Days { get; set; }

    public string? Year { get; set; }

    public int Sr { get; set; }
}
