[![](https://img.shields.io/nuget/v/soenneker.datatables.attributes.searchable.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.datatables.attributes.searchable/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.datatables.attributes.searchable/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.datatables.attributes.searchable/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.datatables.attributes.searchable.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.datatables.attributes.searchable/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.datatables.attributes.searchable/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.datatables.attributes.searchable/actions/workflows/codeql.yml)

# Soenneker.DataTables.Attributes.Searchable

Indicates that a property should be used for search operations in DataTables.

## Install

```bash
dotnet add package Soenneker.DataTables.Attributes.Searchable
```

## Quick start

```csharp
using Soenneker.DataTables.Attributes.Searchable;

public sealed class Request
{
    [DataTableSearchable]
    public string? Value { get; init; }
}
```

Indicates that a property should be used for search operations in DataTables.

## What you get

- `DataTableSearchableAttribute` — Indicates that a property should be used for search operations in DataTables.
