using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace aspnetapp.Model
{
    public class DtmDatabaseType
    {
        [Key]
        public decimal DatabaseTypeId { get; set; }
        public string DatabaseTypeName { get; set; }
    }
}
