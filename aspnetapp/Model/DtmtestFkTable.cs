using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace aspnetapp.Model
{
    public class DtmtestFkTable
    {
        public DtmtestFkTable()
        {
            DtmtestTables = new HashSet<DtmtestTable>();
        }

        public int Id { get; set; }
        public string FkValue { get; set; }
        public string FkLink { get; set; }

        public virtual ICollection<DtmtestTable> DtmtestTables { get; set; }
    }
}
