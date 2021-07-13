using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace aspnetapp.Model
{
    public class DtmFieldType
    {
        [Key]
        public decimal FieldTypeId { get; set; }
        public string FieldTypeName { get; set; }
    }
}
