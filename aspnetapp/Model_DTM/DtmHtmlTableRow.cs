using System;
using System.Collections.Generic;

#nullable disable

namespace aspnetapp.Model_DTM
{
    public partial class DtmHtmlTableRow
    {
        public decimal HtmlTableRowId { get; set; }
        public decimal HtmlTableRowHtmlTableId { get; set; }
        public string HtmlTableRowPropertiesString { get; set; }
        public int? HtmlTableRowRowspan { get; set; }
        public int HtmlTableRowOrderBy { get; set; }
    }
}
