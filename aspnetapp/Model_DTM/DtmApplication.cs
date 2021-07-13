using System;
using System.Collections.Generic;

#nullable disable

namespace aspnetapp.Model_DTM
{
    public partial class DtmApplication
    {
        public decimal ApplicationId { get; set; }
        public decimal ApplicationSiteId { get; set; }
        public string ApplicationName { get; set; }
        public string ApplicationCaption { get; set; }
    }
}
