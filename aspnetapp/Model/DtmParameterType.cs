using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace aspnetapp.Model
{
    public class DtmParameterType
    {
        [Key]
        public decimal ParameterTypeId { get; set; }
        public string ParameterTypeName { get; set; }
    }
}
