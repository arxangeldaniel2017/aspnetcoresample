using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace aspnetapp.Model
{
    public class DtmApplicationXmlObject
    {
        [Key]
        public int ApplicationXmlObjectsId { get; set; }
        public int ApplicationXmlObjectsApplicationId { get; set; }
        public int ApplicationXmlObjectsXmlObjectId { get; set; }
        public int ApplicationXmlObjectsHtmlTableCellId { get; set; }
    }
}
