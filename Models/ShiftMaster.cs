using System;
using System.Collections.Generic;

namespace HexaReportApp.Models;

public partial class ShiftMaster
{
    public string? Shiftname { get; set; }

    public string? ShiftCode { get; set; }

    public string? ShiftInTime { get; set; }

    public string? ShiftOutTime { get; set; }

    public string? ShiftHrs { get; set; }

    public string? BreakOutTime { get; set; }

    public string? BreakInTime { get; set; }

    public string? Ssd { get; set; }
}
