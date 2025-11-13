using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Infrastructure.Exceptions
{
    public class DepartmentException : Exception
    {
        public DepartmentException(string message) : base(message) { }
    }
}