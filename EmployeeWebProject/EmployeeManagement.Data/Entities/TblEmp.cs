using System;
using System.Collections.Generic;

namespace EmployeeManagement.Data.Entities;

public partial class TblEmp
{
    public int EmpId { get; set; }

    public string? EmpName { get; set; }

    public string? EmpAddress { get; set; }

    public int? EmpSalary { get; set; }

    public string? Designation { get; set; }
}
