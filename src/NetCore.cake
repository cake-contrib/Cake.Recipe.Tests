#load nuget:https://ci.appveyor.com/nuget/cake-recipe?package=Cake.Recipe&version=2.0.0-alpha0276&prerelease

Environment.SetVariableNames();

var solution = EnvironmentVariable("APPVEYOR_BUILD_WORKER_IMAGE") == "Visual Studio 2015" || IsRunningOnUnix() ? "./NetCore_min.sln" : "./NetCore.sln";

BuildParameters.SetParameters(context: Context,
                              buildSystem: BuildSystem,
                              sourceDirectoryPath: "./NetCore",
                              solutionFilePath: solution,
                              title: ".NET Core Tests",
                              repositoryOwner: "AdmiringWorm",
                              repositoryName: "Cake.Recipe.Tests",
                              appVeyorAccountName: "AdmiringWorm",
                              shouldRunDupFinder: false,
                              shouldRunGitVersion: true,
                              shouldUseDeterministicBuilds: true,
                              shouldRunCodecov: true,
                              nugetConfig: "./NetCore/nuget.config");

BuildParameters.PrintParameters(Context);

ToolSettings.SetToolSettings(context: Context,
                             testCoverageFilter: "+[*]*");

Build.RunDotNetCore();