using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace aspnetapp.Model
{
    public class DtmtestTable
    {
        public int Id { get; set; }
        public int? FkId { get; set; }
        public string TestString { get; set; }
        public DateTime? InsertDate { get; set; }
        public int? UploadId { get; set; }
        public string UploadName { get; set; }
        public string UploadFile { get; set; }
        public string UploadFileName { get; set; }

        public virtual DtmtestFkTable Fk { get; set; }
    }
}
