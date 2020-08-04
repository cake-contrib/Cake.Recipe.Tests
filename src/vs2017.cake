#load nuget:?package=Cake.Recipe&Version=1.0.0

Environment.SetVariableNames();

BuildParameters.SetParameters(context: Context,
                              buildSystem: BuildSystem,
                              sourceDirectoryPath: "./vs2017",
                              solutionFilePath: IsRunningOnWindows() ? "./vs2017.sln" : "./vs2017_unix.sln",
                              title: "VS2017 Tests",
                              repositoryOwner: "AdmiringWorm",
                              repositoryName: "Cake.Recipe.Tests",
                              appVeyorAccountName: "AdmiringWorm",
                              shouldRunDupFinder: false,
                              shouldUseDeterministicBuilds: false,
                              shouldRunCodecov: true);

BuildParameters.PrintParameters(Context);

ToolSettings.SetToolSettings(context: Context,
                             testCoverageFilter: "+[*]*");

Build.Run();
