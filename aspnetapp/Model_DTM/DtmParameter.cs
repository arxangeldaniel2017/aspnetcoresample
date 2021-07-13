using System;
using System.Collections.Generic;

#nullable disable

namespace aspnetapp.Model_DTM
{
    public partial class DtmParameter
    {
        public decimal ParameterId { get; set; }
        public string ParameterName { get; set; }
        public decimal ParameterSiteId { get; set; }
        public decimal ParameterParameterTypeId { get; set; }
        public object ParameterDefaultValue { get; set; }
    }
}
