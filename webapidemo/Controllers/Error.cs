using Microsoft.AspNetCore.Mvc;

namespace webapidemo.Controllers
{
    internal class Error : ActionResult
    { 
        public string Message { get; set; }
        public int Code { get; set; }

        public Error(string message, int code = 400)
        {
            Message = message;
            Code = code;
        }
    }
}