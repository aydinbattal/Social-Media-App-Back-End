using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models.Entities
{
    public class Response<T>
    {
        public T Data { get; set; }
        public Response(T data)
        {
            Data = data;
        }
    }
}