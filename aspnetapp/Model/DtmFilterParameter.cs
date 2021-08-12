using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace aspnetapp.Model
{
    public class DtmFilterParameter
    {
        public int Id { get; set; }
        public int FilterParametersFilterId { get; set; }
        public int FilterParametersParameterId { get; set; }
    }
}
