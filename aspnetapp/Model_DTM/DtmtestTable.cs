﻿using System;
using System.Collections.Generic;

#nullable disable

namespace aspnetapp.Model
{
    public class DtmtestTable
    {
        public int Id { get; set; }
        public int? FkId { get; set; }
        public string TestString { get; set; }
        public DateTime? InsertDate { get; set; }
        public decimal? UploadId { get; set; }
        public string UploadName { get; set; }
        public string UploadFile { get; set; }
        public string UploadFileName { get; set; }

        public virtual DtmtestFkTable Fk { get; set; }
    }
}
