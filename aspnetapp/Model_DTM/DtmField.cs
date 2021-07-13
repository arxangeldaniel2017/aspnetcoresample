using System;
using System.Collections.Generic;

#nullable disable

namespace aspnetapp.Model
{
    public class DtmField
    {
        public decimal FieldId { get; set; }
        public decimal FieldTableId { get; set; }
        public decimal FieldTypeId { get; set; }
        public string FieldName { get; set; }
        public string FieldCaption { get; set; }
        public bool? FieldRequired { get; set; }
        public decimal? FieldFkfieldId { get; set; }
        public decimal? FieldUpfieldId { get; set; }
        public decimal? FieldOrder { get; set; }
        public bool? FieldReadOnly { get; set; }
        public bool FieldIsPk { get; set; }
        public bool? FieldAutoIncrement { get; set; }
        public decimal? FieldAutoIncrementSeed { get; set; }
        public decimal? FieldAutoIncrementStep { get; set; }
        public string FieldDataTypeString { get; set; }
        public bool? FieldUnique { get; set; }
        public bool? FieldIsFilter { get; set; }
        public bool? FieldDoNotDisplay { get; set; }
        public bool? FieldDisplayOnly { get; set; }
        public string FieldParamValue { get; set; }
        public bool? FieldIsQueryStringFilter { get; set; }
        public decimal? FieldWidth { get; set; }
        public decimal? FieldHeight { get; set; }
        public decimal? FieldViewDescriptionChars { get; set; }
        public decimal? FieldMaxChars { get; set; }
        public string FieldUrlLink { get; set; }
    }
}
