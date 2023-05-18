# Blazor .NET 7

[![.NET](https://github.com/damienbod/BlazorNet7/actions/workflows/dotnet.yml/badge.svg)](https://github.com/damienbod/BlazorNet7/actions/workflows/dotnet.yml)

Blazor Hosted application with CSP protection. 

BFF security architecture used with standard OpenID Connect authentication (confidential client code flow with PKCE)

Will working against any OpenID Connect server, only default packages used.

## Update from .NET 6 => 7 breaking changes

All packages were updated to use the latest preview version

Name claim definition now using no namespace in .NET 7.

```csharp
userInfo.NameClaimType = "name";
userInfo.RoleClaimType = "role";

// breaking change .NET 7
//if (claimsPrincipal?.Identity is ClaimsIdentity claimsIdentity)
//{
//    userInfo.NameClaimType = claimsIdentity.NameClaimType;
//    userInfo.RoleClaimType = claimsIdentity.RoleClaimType;
//}
//else
//{
//    userInfo.NameClaimType = ClaimTypes.Name;
//    userInfo.RoleClaimType = ClaimTypes.Role;
//}
```

## CSP problems (FIXED is latest VS preview 2023-05-18)

see issues: https://github.com/dotnet/aspnetcore/issues/42007

https://developercommunity.visualstudio.com/t/browserlink-CSP-support-NET-7/10061464

CSP definition

```
style-src 'self' 'nonce-sqi6CzGBUG33ijD0/eGi98On5PPVa8cXRJH6/aimV/0='; 
script-src 'self' 'sha256-ZD0chCyBaNHl+4UwQHJIHGoYhKwMeyCXGgJTKW5/67E=' 'unsafe-eval' 'nonce-sqi6CzGBUG33ijD0/eGi98On5PPVa8cXRJH6/aimV/0='; 
object-src 'none'; block-all-mixed-content; 
img-src 'self' data:; 
form-action 'self' https://localhost:44395; 
font-src 'self'; base-uri 'self'; 
frame-ancestors 'none'
```

## Test OIDC server

https://github.com/damienbod/AspNetCoreOpeniddict/tree/main/OpeniddictServer

## Created using the following template

https://github.com/damienbod/Blazor.BFF.OpenIDConnect.Template

## Links:

https://devblogs.microsoft.com/dotnet/asp-net-core-updates-in-dotnet-7-preview-3/

https://devblogs.microsoft.com/dotnet/announcing-dotnet-7-preview-3/

https://github.com/dotnet/aspnetcore/issues/39504

https://dotnet.microsoft.com/en-us/download/dotnet/7.0

https://docs.microsoft.com/en-us/dotnet/core/compatibility/7.0

https://devblogs.microsoft.com/visualstudio/introducing-private-preview-port-tunneling-visual-studio-for-asp-net-core-projects/
