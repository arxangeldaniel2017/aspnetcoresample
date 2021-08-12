using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace aspnetapp.Model
{
    public class DtmFkValue
    {
        public int Id { get; set; }
        public int FkValueFkfieldId { get; set; }
        public int FkValueFieldId { get; set; }
        public string FkvalueSeparator { get; set; }
        public int? FkvalueOrder { get; set; }
        public bool? FkvalueDoNotDisplay { get; set; }
    }
}
