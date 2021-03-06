﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;

public class SqlServerColumn
{
    [JsonIgnore] // only used in-memory to associate column with parent table
    public string Database { get; set; }

    [JsonIgnore] // only used in-memory to associate column with parent table
    public string TableSchema { get; set; }

    [JsonIgnore] // only used in-memory to associate column with parent table
    public string TableName { get; set; }

    public string ColumnName { get; set; }

    public int OrdinalPosition { get; set; }

    public string DefaultSetting { get; set; }

    public bool IsNullable { get; set; }

    public string SqlDataType { get; set; }

    /// <summary>
    /// CLR Type which is equivalent to the SqlDataType
    /// </summary>
    public string ClrType { get; set; }

    [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
    public int? MaxLength { get; set; }

    [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
    public int? DateTimePrecision { get; set; }

    [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
    public int? NumericScale { get; set; }

    [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
    public int? NumericPrecision { get; set; }

    public bool IsIdentity { get; set; }

    public bool IsComputed { get; set; }

    public bool IsRowGuid { get; set; }

    public bool IsPrimaryKeyMember { get; set; }

    [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
    public int? PrimaryKeyOrdinalPosition { get; set; }

    public bool IsForeignKeyMember { get; set; }

    public string ColumnDescription { get; set; }
}
