using System;
using System.Collections.Generic;

namespace DTOExample.Models;

public partial class Employee
{
    public int EmpId { get; set; }

    public string? EmpName { get; set; }

    public int? DeptId { get; set; }

    public virtual Department? Dept { get; set; }
}
