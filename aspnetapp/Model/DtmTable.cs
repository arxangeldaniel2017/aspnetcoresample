using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace aspnetapp.Model
{
    public class DtmTable
    {
        public int Id { get; set; }
        public int TableDatabaseId { get; set; }
        public string TableName { get; set; }
        public string TableCaption { get; set; }
        public string TableDesc { get; set; }
        public bool? TableAllowPaging { get; set; }
        public int? TablePageSize { get; set; }
        public bool? TableAllowSorting { get; set; }
        public bool? TableDisplayFilter { get; set; }
        public bool? TableIsAdd { get; set; }
        public bool? TableIsDelete { get; set; }
        public bool? TableIsUpdate { get; set; }
        public bool? TableIsScroll { get; set; }
    }
}
