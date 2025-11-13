using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Application.Core
{
    public class ServiceResult
    {
        public bool Success { get; set; } = true;
        public string Message { get; set; } = string.Empty;
    }

    public class ServiceResult<T> : ServiceResult
    {
        public T? Data { get; set; }
    }
}