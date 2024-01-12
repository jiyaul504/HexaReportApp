using System;
using System.Collections.Generic;

namespace HexaReportApp.Models;

public partial class UserRight
{
    public string? UserName { get; set; }

    public string? MasterName { get; set; }

    public string? Add { get; set; }

    public string? Modify { get; set; }

    public string? View { get; set; }

    public string? Delete { get; set; }

    public string? Allow { get; set; }

    public string? Type { get; set; }
}
