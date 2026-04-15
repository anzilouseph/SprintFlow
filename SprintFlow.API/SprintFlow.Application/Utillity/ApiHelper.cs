using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SprintFlow.Application.Utillity
{
    public class ApiHelper <T>
    {
        public ApiHelper(T data, string message, bool success)
        {
            this.data = data;
            this.message = message;
            this.success = success;
        }

        public T data { get; set; }
        public string message { get; set; } 
        public bool success { get; set; }

        public static ApiHelper<T> Error(string message)
        {
            return new ApiHelper<T>(default, message, false);
        }
        public static ApiHelper<T> Success (T data, string message)
        {

            return new ApiHelper<T>(data, message, true);
        }
    }
}
