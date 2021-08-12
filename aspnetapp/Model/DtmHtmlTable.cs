using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace aspnetapp.Model
{
    public class DtmHtmlTable
    {
        public int Id { get; set; }
        public string HtmlTableName { get; set; }
        public string HtmlTablePropertiesString { get; set; }
        public int HtmlTableOrderBy { get; set; }
    }
}
