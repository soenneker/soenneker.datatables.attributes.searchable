using System;

namespace Soenneker.DataTables.Attributes.Searchable;

/// <summary>
/// Indicates that a property should be used for search operations in DataTables.
/// </summary>
[AttributeUsage(AttributeTargets.Property)]
public sealed class DataTableSearchableAttribute : Attribute;