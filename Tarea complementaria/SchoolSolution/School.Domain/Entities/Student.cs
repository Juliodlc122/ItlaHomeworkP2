using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using School.Domain.Core;

namespace School.Domain.Entities
{
    public class Student : Person
    {
        public DateTime EnrollmentDate { get; set; }
        public virtual ICollection<Course> Courses { get; set; } = new List<Course>();
    }
}