#addin nuget:?package=Cake.FileHelpers&version=3.3.0

var packageVersion = FileReadLines("./package_version.config").First();

string cakeReference = $@"#load nuget:https://ci.appveyor.com/nuget/cake-recipe?package=Cake.Recipe&version={packageVersion}&prerelease";

IEnumerable<FilePath> buildScripts;

if (HasEnvironmentVariable("CAKE_SCRIPT_NAME"))
{
    buildScripts = new FilePath[] { "./src/" + EnvironmentVariable("CAKE_SCRIPT_NAME") + ".cake" };
}
else
{
    buildScripts = GetFiles("src/*.cake");
}
DirectoryPath workingDir = "./src";

var target = Argument("target", EnvironmentVariable("TEST_TARGET") ?? "Default");

foreach (var script in buildScripts) {
    Task(script.GetFilenameWithoutExtension().ToString())
        .IsDependeeOf("Default")
        .Does(() => {
    ReplaceRegexInFiles(script.FullPath,
        @"^\s*#l(oad)?.*Cake\.Recipe.*",
        cakeReference.Trim());
    
    Information("Bootstrapping {0}", script);
    // First we need to bootstrapt the cake script, before running it
    CakeExecuteScript(script,
        new CakeSettings {
            Arguments = new Dictionary<string, string>{
                { "bootstrap", ""}
            },
            WorkingDirectory = workingDir,
        });

        
    Information("Testing {0}", script);
    CakeExecuteScript(script,
        new CakeSettings {
            Arguments = new Dictionary<string, string>{
                { "verbosity", Context.Log.Verbosity.ToString("F") },
                { "target", target },
                { "ignore-cake-version", "" }
            },
            WorkingDirectory = workingDir,
        });
    });
}

Task("Default");

Information("Running target: {0}", target);

RunTarget("Default");