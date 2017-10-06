Instructions for running example code on Linux using dotnetcore.

# Prerequisites for Linux

Install dotnetcore for your flavour of Linux:

https://www.microsoft.com/net/core

Arch Linux is not supported officially. Installation via AUR is one line of code:

`aurget -S --noedit --noconfirm --deps dotnet-sdk-2.0`

https://aur.archlinux.org/packages/dotnet-sdk-2.0/

# Editor for Linux

dotnetcore has **complete CLI support**, so you can use the editor of your choice (CLI: Command Line Interface; compiling, testing from the command line via `dotnet` command). An obvious choice for this session might be **VIM** ;-) 

Nevertheless, I would recommend giving **Visual Studio Code** a try. 

https://code.visualstudio.com/docs/setup/linux

VS Code is a lightweight, free, and cross-plattform editor similar to Atom, Sublime, etc. ("Visual Studio Code" is NOT the same as "Visual Studio"). Working with dotnetcore feels very natural with "Visual Studio Code". And yes: there is also a VIM plugin for VS Code (https://marketplace.visualstudio.com/items?itemName=vscodevim.vim)... ;-)

Again, Arch Linux is not supported officially. Install via AUR.

https://aur.archlinux.org/packages/visual-studio-code

# Testing

Executing `dotnet test` in the shell of your choice should look something like this:

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

# Initial project setup

This is just a note to myself on how I created the project.

(tested with Ubuntu Linux and Arch Linux)

## Scaffolding of project structure

- `dotnet new xunit -o RailwayDemoCore`
- `cd RailwayDemoCore`

## Installing packages

- `dotnet add package FluentAssertions`
- `dotnet add package NSubstitute`
- `dotnet add package CSharpFunctionalExtensions`
- `dotnet restore`

## Version info

```
$ dotnet --info
.NET Command Line Tools (2.0.0)

Product Information:
 Version:            2.0.0
 Commit SHA-1 hash:  cdcd1928c9

Runtime Environment:
 OS Name:     ubuntu
 OS Version:  16.04
 OS Platform: Linux
 RID:         ubuntu.16.04-x64
 Base Path:   /usr/share/dotnet/sdk/2.0.0/

Microsoft .NET Core Shared Framework Host

  Version  : 2.0.0
  Build    : e8b8861ac7faf042c87a5c2f9f2d04c98b69f28d
```