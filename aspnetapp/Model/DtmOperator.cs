using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace aspnetapp.Model
{
    public class DtmOperator
    {
        public int Id { get; set; }
        public string OperatorName { get; set; }
        public string OperatorValue { get; set; }
    }
}
