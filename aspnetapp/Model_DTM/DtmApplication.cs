using System;
using System.Collections.Generic;

#nullable disable

namespace aspnetapp.Model
{
    public class DtmApplication
    {
        public decimal ApplicationId { get; set; }
        public decimal ApplicationSiteId { get; set; }
        public string ApplicationName { get; set; }
        public string ApplicationCaption { get; set; }
    }
}
