using System;
using System.Collections.Generic;

namespace DTOExample.Models;

public partial class Department
{
    public int DeptId { get; set; }

    public string? DeptName { get; set; }

    public virtual ICollection<Employee>? Employees { get; set; } = new List<Employee>();
}

//{
//  "deptId": 0,
//  "deptName": "string",
//  "employees": [
//    {
//      "empId": 0,
//      "empName": "string",
//      "deptId": 0,
//      "dept": "string"
//    }
//  ]
//}