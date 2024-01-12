using System;
using System.Collections.Generic;

namespace HexaReportApp.Models;

public partial class Machine
{
    public string? MachineNo { get; set; }

    public string? Ipaddress { get; set; }

    public string? PortNo { get; set; }

    public string? Password { get; set; }

    public string? MachineType { get; set; }

    public string? ConStatus { get; set; }

    public string? P2pid { get; set; }

    public string? P2pip { get; set; }

    public string? P2pport { get; set; }

    public string? Type { get; set; }
}
