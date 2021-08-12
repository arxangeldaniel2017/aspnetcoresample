using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace aspnetapp.Model
{
    public class DtmFkfield
    {
        public int Id { get; set; }
        public int FkfieldTableId { get; set; }
        public int FkfieldKeyFieldId { get; set; }
    }
}
