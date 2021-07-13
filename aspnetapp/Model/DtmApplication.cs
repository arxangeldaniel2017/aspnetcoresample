using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace aspnetapp.Model
{
    public class DtmApplication
    {
        [Key]
        public decimal ApplicationId { get; set; }
        public decimal ApplicationSiteId { get; set; }
        public string ApplicationName { get; set; }
        public string ApplicationCaption { get; set; }
    }
}
