using System;
using System.Collections.Generic;

namespace HexaReportApp.Models;

public partial class PMail
{
    public DateTime? Date { get; set; }

    public string? SendMail { get; set; }

    public string? Mailid { get; set; }
}
