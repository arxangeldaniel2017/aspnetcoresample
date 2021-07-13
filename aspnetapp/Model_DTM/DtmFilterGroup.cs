using System;
using System.Collections.Generic;

#nullable disable

namespace aspnetapp.Model
{
    public class DtmFilterGroup
    {
        public decimal FilterGroupId { get; set; }
        public string FilterGroupName { get; set; }
        public decimal FilterGroupOperatorId { get; set; }
        public decimal FilterGroupFilterId { get; set; }
        public decimal FilterGroupFilterOperatorId { get; set; }
        public int FilterGroupOrderBy { get; set; }
    }
}
