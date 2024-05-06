[![GitHub Workflow Status](https://img.shields.io/github/actions/workflow/status/hughesjs/UniversalDiveDataFormat/dotnet-ci.yml?label=BUILD%20CI&style=for-the-badge&branch=master)](https://github.com/hughesjs/UniversalDiveDataFormat/actions)
[![GitHub Workflow Status](https://img.shields.io/github/actions/workflow/status/hughesjs/UniversalDiveDataFormat/dotnet-cd.yml?label=BUILD%20CD&style=for-the-badge&branch=master)](https://github.com/hughesjs/UniversalDiveDataFormat/actions)
[![Nuget (with prereleases)](https://img.shields.io/nuget/vpre/UniversalDiveDataFormat?style=for-the-badge)](https://nuget.org/packages/UniversalDiveDataFormat)
![GitHub top language](https://img.shields.io/github/languages/top/hughesjs/UniversalDiveDataFormat?style=for-the-badge)
[![GitHub](https://img.shields.io/github/license/hughesjs/UniversalDiveDataFormat?style=for-the-badge)](LICENSE)
![FTB](https://raw.githubusercontent.com/hughesjs/custom-badges/master/made-in/made-in-scotland.svg)


# Universal Dive Data Format ``

This is a C# library for reading and writing the [Universal Dive Data Format](https://www.streit.cc/extern/uddf_v321/en/index.html).

Currently, the library primarily consists of the Models required to deserialize UDDF files using the [XmlSerializer](https://docs.microsoft.com/en-us/dotnet/api/system.xml.serialization.xmlserializer?view=net-7.0).

Future versions might include extra services for enforcing constraints and validation.

## Usage

The library is available on [NuGet](https://www.nuget.org/packages/UniversalDiveDataFormat/).

You can install it using your package manager or with the cli:

```bash
dotnet add package UniversalDiveDataFormat
```

```csharp
using System.Xml.Serialization;
using UniversalDiveDataFormat.Models;

// Deserialize a complete UDDF file
var serializer = new XmlSerializer(typeof(UniversalDiveDataFormat.Models.UniversalDiveDataFormatRoot));
var uddf = serializer.Deserialize(File.OpenRead("my_dive_log.uddf"));
```

## Contributing

I haven't written an application using this library yet, so it's entirely possible that I've missed things when I was going through the UDDF specification.

If you find a bug or have a feature request, please open an issue or a pull request.

## License

This project is licensed under The Unlicense. Do whatever you want with it but don't blame me for the results.