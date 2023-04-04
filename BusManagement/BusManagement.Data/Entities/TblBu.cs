using System;
using System.Collections.Generic;

namespace BusManagement.Data.Entities;

public partial class TblBu
{
    public int BusNumber { get; set; }

    public string? BusDestinationCity { get; set; }

    public string? BusSourceCity { get; set; }

    public int? BusCapacity { get; set; }

    public string? BusType { get; set; }

    public DateTime? BusDeparture { get; set; }

    public DateTime? BusArrival { get; set; }
}
