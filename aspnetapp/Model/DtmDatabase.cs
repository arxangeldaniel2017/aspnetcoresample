using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace aspnetapp.Model
{
    public class DtmDatabase
    {
        public int Id { get; set; }
        public string DatabaseName { get; set; }
        public string DatabaseApplicationString { get; set; }
        public string DatabaseConnString { get; set; }
        public int? DatabaseTypeId { get; set; }
    }
}
