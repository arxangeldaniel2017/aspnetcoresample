using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace aspnetapp.Model
{
    public class DtmUploadType
    {
        [Key]
        public decimal UploadTypeId { get; set; }
        public string UploadTypeName { get; set; }
    }
}
