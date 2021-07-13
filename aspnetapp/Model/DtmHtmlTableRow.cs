using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace aspnetapp.Model
{
    public class DtmHtmlTableRow
    {
        [Key]
        public decimal HtmlTableRowId { get; set; }
        public decimal HtmlTableRowHtmlTableId { get; set; }
        public string HtmlTableRowPropertiesString { get; set; }
        public int? HtmlTableRowRowspan { get; set; }
        public int HtmlTableRowOrderBy { get; set; }
    }
}
