# DinkToPdfAll
.NET Standard library which wrapping the [DinkToPdf](https://github.com/rdvojmoc/DinkToPdf) library that include x64 and x86 version of the wkhtmltox library for all desktop platforms.

## Install
This library is available in [NuGet](https://www.nuget.org/packages/DinkToPdfAllOs/).  
At nuget package manager, run the follow command.
```
PM> Install-Package DinkToPdfAllOs 
```
At .NET CLI console, run the follow command. 
```
dotnet add package DinkToPdfAllOs
```

## How to load wkhtmltox library?
You must call the Load method in ConfigurateService at Startup.
```csharp
 DinkToPdfAllOs.LibraryLoader.Load();
```
## How to use it?
Please read the official documentation of [DinkToPdf](https://github.com/rdvojmoc/DinkToPdf).
