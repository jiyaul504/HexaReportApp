using System;
using System.Collections.Generic;

namespace HexaReportApp.Models;

public partial class LeaveBal
{
    public string? Empcode { get; set; }

    public string? LeaveCode { get; set; }

    public int? Balance { get; set; }

    public string? Year { get; set; }

    public int Sr { get; set; }
}
