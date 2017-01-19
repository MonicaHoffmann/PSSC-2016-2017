using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace University_App.Models.Cqrs
{
    public class CommandResult
    {
        // Simple result class for command handlers to return 
        public class CommandResult
        {
            public bool Success { get; set; }

            public string Message { get; set; }

            public object Data { get; set; }
        } 
    }
}