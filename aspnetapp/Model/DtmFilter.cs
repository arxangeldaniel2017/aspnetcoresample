using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace aspnetapp.Model
{
    public class DtmFilter
    {
        public int Id { get; set; }
        public string FilterName { get; set; }
        public int FilterOperatorId { get; set; }
        public int? FilterFieldId { get; set; }
        public int? FilterFieldOperatorId { get; set; }
        public string FilterCustomSelect { get; set; }
        public string FilterDefaultValue { get; set; }
        public int FilterOrderBy { get; set; }
    }
}
