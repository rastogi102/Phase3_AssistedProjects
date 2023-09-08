using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp1._29_RazorViewEngine.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }
        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}