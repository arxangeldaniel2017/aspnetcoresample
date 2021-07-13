using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace aspnetapp.Model
{
    public class DtmXmlObject
    {
        [Key]
        public decimal XmlObjectId { get; set; }
        public string XmlObjectName { get; set; }
        public decimal? XmlObjectTableId { get; set; }
        public string XmlObjectCustomSelect { get; set; }
        public string XmlObjectXslString { get; set; }
        public string XmlObjectXslFile { get; set; }
    }
}
