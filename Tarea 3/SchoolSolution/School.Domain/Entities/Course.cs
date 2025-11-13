using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using School.Domain.Core;

namespace School.Domain.Entities
{
    public class Course : BaseEntity
    {
        public string? Title { get; set; }
        public int Credits { get; set; }
        public int DepartmentID { get; set; }
        public virtual Department? Department { get; set; }
        public virtual ICollection<Student> Students { get; set; } = new List<Student>();
    }
}