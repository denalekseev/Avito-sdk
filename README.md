# Avito SDK

[![Avito API Client v2.0](https://img.shields.io/badge/Avito%20api-v2.0-%2300B33C)](https://api-docs.Avito.ru/29923741.html)
[![Code quality](https://img.shields.io/codefactor/grade/github/restub/AvitoSdk)](https://www.codefactor.io/repository/github/restub/AvitoSdk)
[![GitHub Actions](https://img.shields.io/endpoint.svg?url=https%3A%2F%2Factions-badge.atrox.dev%2Fyallie%2FAvitoSdk%2Fbadge&label=build&logo=none)](https://actions-badge.atrox.dev/yallie/AvitoSdk/goto)
[![.NET Framework 4.62](https://img.shields.io/badge/.net-v4.62-yellow)](https://www.microsoft.com/ru-RU/download/details.aspx?id=53321)
[![NuGet](https://img.shields.io/nuget/v/AvitoSdk.svg)](https://nuget.org/packages/AvitoSdk)
[![AutoGenerateClasses](https://jsonutils.com/)

# Getting started

* Install AvitoSdk Nuget package: https://www.nuget.org/packages/AvitoSdk
* Register on the [Avito website](https://www.Avito.ru/) to get your username and password, or use `Credentials.TestCredentials`
* Create `AvitoClient` using your credentials and connect to either endpoint:
  * `AvitoClient.SandboxApiUrl` — for testing
  * `AvitoClient.ProductionApiUrl` — for production code
* Set `AvitoClient.Tracer` callback to your favorite logger's `WriteLine` method:
  * Tracer = Console.WriteLine — to trace all API calls to the system console
  * Tracer = TestContext.Progress.WriteLine — to trace your unit tests to Visual Studio Output window 
* Invoke `AvitoClient` methods to calculate delivery tariffs, place orders, etc.
* Consult the original API documentation for the available methods:
  * [Russian documentation](https://api.Avito.ru/docs/)

## Sample code


```c#
var client = new AvitoClient();

// trace all API calls to the console
client.Tracer = Console.WriteLine;

var stores = client.GetStores();
```


# SDK versioning

The project uses [Nerdbank.GitVersioning](https://github.com/dotnet/Nerdbank.GitVersioning) tool to manage versions.  
Each library build can be traced back to the original git commit.

## Preparing and publishing a new release

1. Make sure that `nbgv` dotnet CLI tool is installed and is up to date
2. Run `nbgv prepare-release` to create a stable branch for the upcoming release, i.e. release/v1.0
3. Switch to the release branch: `git checkout release/v1.0`
4. Execute unit tests, update the README, etc. Commit and push your changes.
5. Run `dotnet pack -c Release` and check that it builds Nuget packages with the right version number.
6. Run `nbgv tag release/v1.0` to tag the last commit on the release branch with your current version number, i.e. v1.0.7.
7. Push tags as suggested by nbgv tool: `git push origin v1.0.7`
8. Go to github project page and create a release out of the last tag v1.0.7.
9. Verify that github workflow for publishing the nuget package has completed.
