﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeWebAPI.Models
{
    [Table("Department")]
    public class Department
    {   
        [Key]
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
    }
}

