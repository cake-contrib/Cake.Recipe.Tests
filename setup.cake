#addin nuget:?package=Cake.FileHelpers&version=3.2.0

string cakeReference = @"#load nuget:?package=Cake.Recipe&version=1.0.0
";

var buildScripts = new[] {
    "./src/vs2015.cake"
};

foreach (var script in buildScripts) {
    ReplaceRegexInFiles(script,
        @"^\s*#l(oad)?.*Cake\.Recipe.*",
        cakeReference.Trim());
    
    Information("Testing {0}", script);
    CakeExecuteScript(script,
        new CakeSettings {
            Arguments = new Dictionary<string, string>{
                { "verbosity", Context.Log.Verbosity.ToString("F") }
            }
        });
}