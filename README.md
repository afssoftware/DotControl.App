# DotControl.App
Readme:
This project is created as assessment for DotContol.
Here is the description of the solution and the references.

 
The solution contains of 3 projects
1- DotControl.UI (Type: Console App (.NET Framework 74.7.2)
2- DotControl.CLibrary (Type: Class library (.NET Framework 74.7.2)
3- DOtControl.Tests ((Type: Class Libbrary (.NET Framework 74.7.2)

1- DotControl.UI: is the presentation project
2- DotControl.CLibrary: is the businesLogic project
3- DOtControl.Tests: is the test project 

NuGet Packages:
The DotControl.UI includes: 
-autofac: is a IoC container

The DotControl.Tests includes:
-xUnit
-xunit.runner.console
-xunit.runner.visualstudio



Methods:
Class Account in the DotControl.Library includes two methods
1-RefreshBalance (): Which refreshes the Balance  
2-RefreshBalanceAsync (): Which refreshes the Balance (which means happening at the same time.)


DotControl.UI project uses dependency injection to register the classes in the project and in DotControl.CLibrary.
