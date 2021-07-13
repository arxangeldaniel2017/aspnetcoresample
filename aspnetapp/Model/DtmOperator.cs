using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace aspnetapp.Model
{
    public class DtmOperator
    {
        [Key]
        public decimal OperatorId { get; set; }
        public string OperatorName { get; set; }
        public string OperatorValue { get; set; }
    }
}
