using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using School.Domain.Core;

namespace School.Domain.Entities
{
    public class Instructor : Person
    {
        public DateTime HireDate { get; set; }
        public int DepartmentID { get; set; }
        public virtual Department? Department { get; set; }
    }
}