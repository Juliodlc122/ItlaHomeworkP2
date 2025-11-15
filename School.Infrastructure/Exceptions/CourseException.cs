using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Infrastructure.Exceptions
{
    public class CourseException : Exception
    {
        public CourseException(string message) : base(message) { }
    }
}