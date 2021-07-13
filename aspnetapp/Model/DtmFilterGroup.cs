using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace aspnetapp.Model
{
    public class DtmFilterGroup
    {
        [Key]
        public decimal FilterGroupId { get; set; }
        public string FilterGroupName { get; set; }
        public decimal FilterGroupOperatorId { get; set; }
        public decimal FilterGroupFilterId { get; set; }
        public decimal FilterGroupFilterOperatorId { get; set; }
        public int FilterGroupOrderBy { get; set; }
    }
}
