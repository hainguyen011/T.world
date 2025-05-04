using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T.world.Server.Utilities
{
    class ServiceResultLogin<T>
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public T Data { get; set; }

        public static ServiceResultLogin<T> Ok(T data, string message = "") =>
            new ServiceResultLogin<T> { Success = true, Message = message, Data = data };

        public static ServiceResultLogin<T> Fail(string message) =>
            new ServiceResultLogin<T> { Success = false, Message = message };
    }
}
