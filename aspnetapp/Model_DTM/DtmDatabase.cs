using System;
using System.Collections.Generic;

#nullable disable

namespace aspnetapp.Model_DTM
{
    public partial class DtmDatabase
    {
        public decimal DatabaseId { get; set; }
        public string DatabaseName { get; set; }
        public string DatabaseApplicationString { get; set; }
        public string DatabaseConnString { get; set; }
        public decimal? DatabaseTypeId { get; set; }
    }
}
