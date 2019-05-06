#addin nuget:?package=Cake.FileHelpers&version=3.2.0

string cakeReference = @"#load nuget:?package=Cake.Recipe&Error
";

var buildScripts = GetFiles("src/*.cake");

foreach (var script in buildScripts) {
    Task(script.GetFilenameWithoutExtension().ToString())
        .IsDependeeOf("Default")
        .Does(() => {
    ReplaceRegexInFiles(script.FullPath,
        @"^\s*#l(oad)?.*Cake\.Recipe.*",
        cakeReference.Trim());
    
    Information("Testing {0}", script);
    CakeExecuteScript(script,
        new CakeSettings {
            Arguments = new Dictionary<string, string>{
                { "verbosity", Context.Log.Verbosity.ToString("F") }
            }
        });
    });
}

Task("Default");

var target = Argument<string>("target", null) ?? EnvironmentVariable("TEST_TARGET") ?? "Default";
RunTarget(target);