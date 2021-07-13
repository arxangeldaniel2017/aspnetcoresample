using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace aspnetapp.Model
{
    public class DtmParameter
    {
        [Key]
        public decimal ParameterId { get; set; }
        public string ParameterName { get; set; }
        public decimal ParameterSiteId { get; set; }
        public decimal ParameterParameterTypeId { get; set; }
        //public object ParameterDefaultValue { get; set; }
    }
}
