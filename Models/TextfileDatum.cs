using System;
using System.Collections.Generic;

namespace HexaReportApp.Models;

public partial class TextfileDatum
{
    public string? MachineNo { get; set; }

    public string? Empcardno { get; set; }

    public string? Flag { get; set; }

    public DateTime? Date { get; set; }

    public string? Time { get; set; }

    public string? Day { get; set; }

    public string? Month { get; set; }

    public string? Year { get; set; }

    public string? RCode { get; set; }

    public string? Mflag { get; set; }

    public string? Temperature { get; set; }
}
