using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace aspnetapp.Model
{
    public class DtmHtmlTableCell
    {
        [Key]
        public decimal HtmlTableCellId { get; set; }
        public decimal HtmlTableCellHtmlTableRowId { get; set; }
        public string HtmlTableCellPropertiesString { get; set; }
        public int? HtmlTableCellCollspan { get; set; }
        public int HtmlTableCellOrderBy { get; set; }
    }
}
