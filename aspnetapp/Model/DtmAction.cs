using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;



namespace aspnetapp.Model
{
    public class DtmAction
    {
        [Key]
        public int ActionId { get; set; }
        public string ActionName { get; set; }
    }
}
