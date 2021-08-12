using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace aspnetapp.Model
{
    public class DtmHtmlTableCell
    {
        public int Id { get; set; }
        public int HtmlTableCellHtmlTableRowId { get; set; }
        public string HtmlTableCellPropertiesString { get; set; }
        public int? HtmlTableCellCollspan { get; set; }
        public int HtmlTableCellOrderBy { get; set; }
    }
}
