using System;
using System.Collections.Generic;

#nullable disable

namespace aspnetapp.Model_DTM
{
    public partial class DtmFkValue
    {
        public decimal FkValueId { get; set; }
        public decimal FkValueFkfieldId { get; set; }
        public decimal FkValueFieldId { get; set; }
        public string FkvalueSeparator { get; set; }
        public decimal? FkvalueOrder { get; set; }
        public bool? FkvalueDoNotDisplay { get; set; }
    }
}
