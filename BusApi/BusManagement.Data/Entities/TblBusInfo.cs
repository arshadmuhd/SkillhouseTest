using System;
using System.Collections.Generic;

namespace BusManagement.Data.Entities;

public partial class TblBusInfo
{
    public int BusNumber { get; set; }

    public string? Destination { get; set; }

    public string? SourceCity { get; set; }

    public int? Capacity { get; set; }

    public string? Type { get; set; }

    public DateTime? Departure { get; set; }

    public DateTime? Arrival { get; set; }
}
