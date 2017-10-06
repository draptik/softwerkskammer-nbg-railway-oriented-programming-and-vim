# Initial project setup

(tested with Ubuntu Linux)

- `dotnet new xunit -o RailwayDemoCore`
- `cd RailwayDemoCore`

## Installing packages

- `dotnet add package FluentAssertions`
- `dotnet add package NSubstitute`
- `dotnet add package CSharpFunctionalExtensions`
- `dotnet restore`

# Testing

- `dotnet test`

Expected output:

```
20:19 $ dotnet test
Build started, please wait...
Build completed.

Test run for /home/patrick/Documents/talks/2017-10-softwerkskammer-nbg-railway-oriented-programming-vim/rop/RailwayDemoCore/bin/Debug/netcoreapp2.0/RailwayDemoCore.dll(.NETCoreApp,Version=v2.0)
Microsoft (R) Test Execution Command Line Tool Version 15.3.0-preview-20170628-02
Copyright (c) Microsoft Corporation.  All rights reserved.

Starting test execution, please wait...
[xUnit.net 00:00:00.4464011]   Discovering: RailwayDemoCore
[xUnit.net 00:00:00.5423791]   Discovered:  RailwayDemoCore
[xUnit.net 00:00:00.5957257]   Starting:    RailwayDemoCore
[xUnit.net 00:00:00.8844927]   Finished:    RailwayDemoCore

Total tests: 7. Passed: 7. Failed: 0. Skipped: 0.
Test Run Successful.
Test execution time: 1.7075 Seconds
```