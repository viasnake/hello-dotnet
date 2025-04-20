# Hello-Dotnet

## How to create a new .NET project

```shell
dotnet new sln
dotnet new gitignore
dotnet new editorconfig
dotnet new console -o src/ExampleDotnet
dotnet sln add src/ExampleDotnet/ExampleDotnet.csproj
dotnet new xunit -o test/ExampleDotnet.Tests
dotnet sln add test/ExampleDotnet.Tests/ExampleDotnet.Tests.csproj reference src/ExampleDotnet/ExampleDotnet.csproj
```

## test

```shell
dotnet test
```

## build

```shell
dotnet build
```
