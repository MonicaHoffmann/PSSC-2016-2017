﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace University_App.Models.Generics
{
    public class EventData
    {
        public Guid Id { get; set; }
        public DateTime Created { get; set; }
        public string AggregateType { get; set; }
        public Guid AggregateId { get; set; }
        public int Version { get; set; }
        public string Event { get; set; }
        public string Metadata { get; set; }
    }
}