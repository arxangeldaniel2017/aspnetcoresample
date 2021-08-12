using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace aspnetapp.Model
{
    public class DtmApplication
    {
        public int Id { get; set; }
        public int ApplicationSiteId { get; set; }
        public string ApplicationName { get; set; }
        public string ApplicationCaption { get; set; }
    }
}
