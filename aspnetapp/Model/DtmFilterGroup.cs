using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace aspnetapp.Model
{
    public class DtmFilterGroup
    {
        public int Id { get; set; }
        public string FilterGroupName { get; set; }
        public int FilterGroupOperatorId { get; set; }
        public int FilterGroupFilterId { get; set; }
        public int FilterGroupFilterOperatorId { get; set; }
        public int FilterGroupOrderBy { get; set; }
    }
}
