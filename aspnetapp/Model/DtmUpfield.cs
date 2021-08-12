using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace aspnetapp.Model
{
    public class DtmUpfield
    {
        public int Id { get; set; }
        public int? UpfieldTableId { get; set; }
        public string UpfieldPath { get; set; }
        public int? UpfieldUnqueNameFieldId { get; set; }
        public string UpfieldFtpsite { get; set; }
        public string UpfieldFtppath { get; set; }
        public string UpfieldFtploggin { get; set; }
        public int? UpfieldUploadTypeId { get; set; }
    }
}
