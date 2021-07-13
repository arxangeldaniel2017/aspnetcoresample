using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace aspnetapp.Model
{
    public class DtmUpfield
    {
        [Key]
        public decimal UpfieldId { get; set; }
        public decimal? UpfieldTableId { get; set; }
        public string UpfieldPath { get; set; }
        public decimal? UpfieldUnqueNameFieldId { get; set; }
        public string UpfieldFtpsite { get; set; }
        public string UpfieldFtppath { get; set; }
        public string UpfieldFtploggin { get; set; }
        public decimal? UpfieldUploadTypeId { get; set; }
    }
}
