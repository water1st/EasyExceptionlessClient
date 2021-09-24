# EasyExceptionlessClient

### Getting started
To use the easy exceptionless client, first install the [NuGet package](https://www.nuget.org/packages/EasyExceptionlessClient/):

```powershell
Install-Package EasyExceptionlessClient
```

Next, register to IServiceCollection
```csharp
services.AddExceptionlessLogging("Your Api Key", "http://YourExceptionLessAPIServerUrl");
```

done !