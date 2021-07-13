using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace aspnetapp.Model
{
    public class DtmFkfield
    {
        [Key]
        public decimal FkfieldId { get; set; }
        public decimal FkfieldTableId { get; set; }
        public decimal FkfieldKeyFieldId { get; set; }
    }
}
