using System;
using System.Collections.Generic;

#nullable disable

namespace aspnetapp.Model
{
    public class DtmFilter
    {
        public decimal FilterId { get; set; }
        public string FilterName { get; set; }
        public decimal FilterOperatorId { get; set; }
        public decimal? FilterFieldId { get; set; }
        public decimal? FilterFieldOperatorId { get; set; }
        public string FilterCustomSelect { get; set; }
        public string FilterDefaultValue { get; set; }
        public int FilterOrderBy { get; set; }
    }
}
