#addin nuget:?package=Cake.FileHelpers&version=3.2.0

string cakeReference = @"#load nuget:https://ci.appveyor.com/nuget/cake-recipe?package=Cake.Recipe&version=2.0.0-alpha0254";

IEnumerable<FilePath> buildScripts;

if (HasEnvironmentVariable("CAKE_SCRIPT_NAME"))
{
    buildScripts = new FilePath[] { "./src/" + EnvironmentVariable("CAKE_SCRIPT_NAME") + ".cake" };
}
else
{
    var buildScripts = GetFiles("src/*.cake");
}

var target = Argument("target", EnvironmentVariable("TEST_TARGET") ?? "Default");

Information($"Running target: {target}");

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
            }
        });

        
    Information("Testing {0}", script);
    CakeExecuteScript(script,
        new CakeSettings {
            Arguments = new Dictionary<string, string>{
                { "verbosity", Context.Log.Verbosity.ToString("F") },
                { "target", target }
            }
        });

        Information("Finished tests for {0}", script);
    });
}

Task("Default");

RunTarget("Default");