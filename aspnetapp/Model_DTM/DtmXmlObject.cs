using System;
using System.Collections.Generic;

#nullable disable

namespace aspnetapp.Model
{
    public class DtmXmlObject
    {
        public decimal XmlObjectId { get; set; }
        public string XmlObjectName { get; set; }
        public decimal? XmlObjectTableId { get; set; }
        public string XmlObjectCustomSelect { get; set; }
        public string XmlObjectXslString { get; set; }
        public string XmlObjectXslFile { get; set; }
    }
}
