using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace aspnetapp.Model
{
    public class DtmFkValue
    {
        [Key]
        public decimal FkValueId { get; set; }
        public decimal FkValueFkfieldId { get; set; }
        public decimal FkValueFieldId { get; set; }
        public string FkvalueSeparator { get; set; }
        public decimal? FkvalueOrder { get; set; }
        public bool? FkvalueDoNotDisplay { get; set; }
    }
}
