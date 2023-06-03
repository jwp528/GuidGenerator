# GuidGenerator
A simple .NET CLI tool for generating Guids. 

## Adjust your allowable max
```
const int MAX_ALLOWABLE_GUIDS = 10_000;
```
## Installation
To install the tool simply run the install command
```
.\install.cmd
```
## Updating the tool
When making updates to the tool. Make sure to update the Version in the .csproj file prior to updating
```
<Project Sdk="Microsoft.NET.Sdk">

  <PropertyGroup>
    <OutputType>Exe</OutputType>
    <TargetFramework>net7.0</TargetFramework>
    <ImplicitUsings>enable</ImplicitUsings>
    <Nullable>enable</Nullable>
	  <PackAsTool>true</PackAsTool>
	  <ToolCommandName>Guid</ToolCommandName>
	  <PackageOutputPath>./nupkg</PackageOutputPath>
	  <VersionPrefix>1.0.0-</VersionPrefix>
	  
	  --- UPDATE THIS --- 
	  <Version>1.0.2</Version>

  </PropertyGroup>

  <ItemGroup>
    <PackageReference Include="TextCopy" Version="6.2.1" />
  </ItemGroup>

</Project>
```

Then run the updater
```
.\update.cmd
```
