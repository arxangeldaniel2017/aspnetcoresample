using System;
using System.Collections.Generic;

#nullable disable

namespace aspnetapp.Model_DTM
{
    public partial class DtmHtmlTableCell
    {
        public decimal HtmlTableCellId { get; set; }
        public decimal HtmlTableCellHtmlTableRowId { get; set; }
        public string HtmlTableCellPropertiesString { get; set; }
        public int? HtmlTableCellCollspan { get; set; }
        public int HtmlTableCellOrderBy { get; set; }
    }
}
