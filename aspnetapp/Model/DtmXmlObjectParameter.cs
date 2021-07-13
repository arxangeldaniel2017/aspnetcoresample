using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace aspnetapp.Model
{
    public class DtmXmlObjectParameter
    {
        [Key]
        public decimal XmlObjectParametersId { get; set; }
        public decimal XmlObjectParametersXmlObjectId { get; set; }
        public decimal XmlObjectParametersParameterId { get; set; }
    }
}
