using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace aspnetapp.Model
{
    public class DtmFilterParameter
    {
        [Key]
        public decimal FilterParametersId { get; set; }
        public decimal FilterParametersFilterId { get; set; }
        public decimal FilterParametersParameterId { get; set; }
    }
}
