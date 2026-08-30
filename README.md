[![](https://img.shields.io/nuget/v/soenneker.datatables.attributes.searchable.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.datatables.attributes.searchable/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.datatables.attributes.searchable/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.datatables.attributes.searchable/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.datatables.attributes.searchable.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.datatables.attributes.searchable/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.datatables.attributes.searchable/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.datatables.attributes.searchable/actions/workflows/codeql.yml)

# Soenneker.DataTables.Attributes.Searchable

`DataTableSearchableAttribute` marks model properties that a server-side DataTables query layer may include in search operations.

## Installation

```bash
dotnet add package Soenneker.DataTables.Attributes.Searchable
```

## Usage

```csharp
using Soenneker.DataTables.Attributes.Searchable;

public sealed class CustomerRow
{
    [DataTableSearchable]
    public required string Name { get; init; }

    [DataTableSearchable]
    public required string Email { get; init; }

    public string? InternalNote { get; init; }
}
```

Use reflection to build an explicit allow-list for a server-side search expression:

```csharp
using System.Reflection;

PropertyInfo[] searchableProperties = typeof(CustomerRow)
    .GetProperties(BindingFlags.Instance | BindingFlags.Public)
    .Where(property => property.IsDefined(typeof(DataTableSearchableAttribute)))
    .ToArray();
```

This package does not parse requests or generate queries. The consuming layer decides how each marked type is searched. Parameterize user-supplied search text, and avoid applying string operations indiscriminately to dates, numbers, or identifiers.
