using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace aspnetapp.Model
{
    public class DtmXmlObjectParameter
    {
        public int Id { get; set; }
        public int XmlObjectParametersXmlObjectId { get; set; }
        public int XmlObjectParametersParameterId { get; set; }
    }
}
