# Cake.Recipe.Tests

Test projects for testing changes in [Cake.Recipe](https://github.com/cake-contrib/Cake.Recipe)

## Integration Tests Status

| Provider  | Latest Status                                                                                                                                           |
| --------- | ------------------------------------------------------------------------------------------------------------------------------------------------------- |
| AppVeyor  | [![Build status](https://ci.appveyor.com/api/projects/status/abck470m3ayquvn4?svg=true)](https://ci.appveyor.com/project/cakecontrib/cake-recipe-tests) |
| Travis CI | [![Build Status](https://travis-ci.org/cake-contrib/Cake.Recipe.Tests.svg)](https://travis-ci.org/cake-contrib/Cake.Recipe.Tests)                       |

### How to trigger new integration builds

New integration builds can be triggered through github (when changing the Cake.Recipe version).

1. Navigate to https://github.com/cake-contrib/Cake.Recipe.Tests/actions?query=workflow%3A%22Trigger+Integration+Tests%22
2. Select `Run workflow` (keep the branch selected on `develop`)
3. Input the Cake.Recipe version that you want to test (as specified in NuGet artifacts on AppVeyor Build Server).
   For instance: `2.0.0-alpha0354`

Without changing the Cake.Recipe version.
To trigger a new build of the integration tests without changing the Cake.Recipe version,
you would need to create a new commit on the repository.
It do not matter if this commit is empty, or changes something.
