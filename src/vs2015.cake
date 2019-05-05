#load nuget:?package=Cake.Recipe&Error=vs2015

Environment.SetVariableNames();

BuildParameters.SetParameters(context: Context,
                              buildSystem: BuildSystem,
                              sourceDirectoryPath: "./vs2015",
                              solutionFilePath: "./vs2015.sln",
                              title: "VS2015 Tests",
                              repositoryOwner: "AdmiringWorm",
                              repositoryName: "Cake.Recipe.Tests",
                              appVeyorAccountName: "AdmiringWorm",
                              shouldRunDupFinder: false,
                              shouldRunGitVersion: true);

BuildParameters.PrintParameters(Context);

ToolSettings.SetToolSettings(context: Context,
                             testCoverageFilter: "+[*]*");

Build.Run();
