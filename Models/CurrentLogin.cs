using System;
using System.Collections.Generic;

namespace HexaReportApp.Models;

public partial class CurrentLogin
{
    public string? LoginName { get; set; }

    public string? Password { get; set; }

    public string? Type { get; set; }

    public string? RegCode { get; set; }

    public string? RegCount { get; set; }

    public string? OfflineKey { get; set; }

    public string? OfflineKey1 { get; set; }

    public string? OfflineKey2 { get; set; }

    public string? Reg { get; set; }
}
