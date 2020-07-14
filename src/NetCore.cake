#load nuget:https://ci.appveyor.com/nuget/cake-recipe?package=Cake.Recipe&version=2.0.0-alpha0282&prerelease

Environment.SetVariableNames();

BuildParameters.SetParameters(context: Context,
                              buildSystem: BuildSystem,
                              sourceDirectoryPath: "./NetCore",
                              solutionFilePath: "./NetCore.sln",
                              title: ".NET Core Tests",
                              repositoryOwner: "AdmiringWorm",
                              repositoryName: "Cake.Recipe.Tests",
                              appVeyorAccountName: "AdmiringWorm",
                              shouldRunDupFinder: false,
                              shouldRunGitVersion: true,
                              shouldUseDeterministicBuilds: true,
                              shouldRunDotNetCorePack: true,
                              shouldRunCodecov: true,
                              nugetConfig: "./NetCore/nuget.config",
                              packageSourceDatas: new List<PackageSourceData> {
                                  new PackageSourceData(Context, "feedz", "https://f.feedz.io/wormiecorp/packages/nuget/index.json", FeedType.NuGet, false)
                              });

BuildParameters.PrintParameters(Context);

ToolSettings.SetToolSettings(context: Context,
                             testCoverageFilter: "+[*]*");

Build.RunDotNetCore();