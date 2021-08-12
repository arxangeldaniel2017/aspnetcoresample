using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace aspnetapp.Model
{
    public class DtmField
    {
        public int Id { get; set; }
        public int FieldTableId { get; set; }
        public int FieldTypeId { get; set; }
        public string FieldName { get; set; }
        public string FieldCaption { get; set; }
        public bool? FieldRequired { get; set; }
        public int? FieldFkfieldId { get; set; }
        public int? FieldUpfieldId { get; set; }
        public int? FieldOrder { get; set; }
        public bool? FieldReadOnly { get; set; }
        public bool FieldIsPk { get; set; }
        public bool? FieldAutoIncrement { get; set; }
        public int? FieldAutoIncrementSeed { get; set; }
        public int? FieldAutoIncrementStep { get; set; }
        public string FieldDataTypeString { get; set; }
        public bool? FieldUnique { get; set; }
        public bool? FieldIsFilter { get; set; }
        public bool? FieldDoNotDisplay { get; set; }
        public bool? FieldDisplayOnly { get; set; }
        public string FieldParamValue { get; set; }
        public bool? FieldIsQueryStringFilter { get; set; }
        public int? FieldWidth { get; set; }
        public int? FieldHeight { get; set; }
        public int? FieldViewDescriptionChars { get; set; }
        public int? FieldMaxChars { get; set; }
        public string FieldUrlLink { get; set; }
    }
}
