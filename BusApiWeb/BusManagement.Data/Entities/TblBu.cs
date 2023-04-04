using System;
using System.Collections.Generic;

namespace BusManagement.Data.Entities;

public partial class TblBu
{
    public int BusNumber { get; set; }

    public string? Destination { get; set; }

    public string? SourceCity { get; set; }

    public int? Capacity { get; set; }

    public string? Type { get; set; }

    public DateOnly? Departure { get; set; }

    public DateOnly? Arrival { get; set; }
}
