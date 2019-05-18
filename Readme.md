# NhtsaClient  [![NuGet Package](https://img.shields.io/nuget/v/NhtsaClient.svg)](https://www.nuget.org/packages/NhtsaClient)

A C# API wrapper for: https://vpic.nhtsa.dot.gov/api


### Package Manager Console

```
Install-Package NhtsaClient
```

### .NET Core CLI

```
dotnet add package NhtsaClient
```


### Usage

```
var client = new NhtsaClient();

var makes = await client.GetMakesForManufacturerAndYear("honda", 2019);

```
