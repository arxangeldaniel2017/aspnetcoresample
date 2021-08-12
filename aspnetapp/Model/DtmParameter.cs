using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace aspnetapp.Model
{
    public class DtmParameter
    {
        public int Id { get; set; }
        public string ParameterName { get; set; }
        public int ParameterSiteId { get; set; }
        public int ParameterParameterTypeId { get; set; }
        //public object ParameterDefaultValue { get; set; }
    }
}
