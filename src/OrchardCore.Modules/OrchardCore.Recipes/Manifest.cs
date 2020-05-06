using OrchardCore.Modules.Manifest;

[assembly: Module(
    Name = "Recipes",
    Author = ManifestConstants.OrchardCoreTeam,
    Website = ManifestConstants.OrchardCoreWebsite,
    Version = ManifestConstants.OrchardCoreVersion,
    Description = "Provides Orchard Recipes.",
    Dependencies = new[]
    {
        "OrchardCore.Features",
        "OrchardCore.Scripting"
    },
    Category = "Infrastructure",
    IsAlwaysEnabled = true
)]
