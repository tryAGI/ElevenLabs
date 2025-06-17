using AutoSDK.Helpers;
using Microsoft.OpenApi;
using Microsoft.OpenApi.Extensions;
using Microsoft.OpenApi.Models;
using Microsoft.OpenApi.Readers;

var path = args[0];
var yamlOrJson = await File.ReadAllTextAsync(path);

if (OpenApi31Support.IsOpenApi31(yamlOrJson))
{
    yamlOrJson = OpenApi31Support.ConvertToOpenApi30(yamlOrJson);
}

var openApiDocument = new OpenApiStringReader().Read(yamlOrJson, out var diagnostics);

//openApiDocument.Components.Schemas["GenerateCompletionRequest"]!.Properties["stream"]!.Default = new OpenApiBoolean(true);

openApiDocument.Servers.Add(new OpenApiServer
{
    Url = "https://api.elevenlabs.io",
});
openApiDocument.Components.SecuritySchemes["ApiKeyAuth"] = new OpenApiSecurityScheme
{
    Type = SecuritySchemeType.ApiKey,
    In = ParameterLocation.Header,
    Name = "xi-api-key",
};
openApiDocument.SecurityRequirements.Add(new OpenApiSecurityRequirement
{
    {
        new OpenApiSecurityScheme
        {
            Reference = new OpenApiReference
            {
                Type = ReferenceType.SecurityScheme,
                Id = "ApiKeyAuth",
            },
        },
        new List<string>()
    },
});

openApiDocument.Components.Schemas["FineTuningResponseModel"].Properties["next_max_verification_attempts_reset_unix_ms"]!.Format = "int64";

yamlOrJson = openApiDocument.SerializeAsYaml(OpenApiSpecVersion.OpenApi3_0);
_ = new OpenApiStringReader().Read(yamlOrJson, out diagnostics);

if (diagnostics.Errors.Count > 0)
{
    foreach (var error in diagnostics.Errors)
    {
        Console.WriteLine(error.Message);
    }
    // Return Exit code 1
    Environment.Exit(1);
}

await File.WriteAllTextAsync(path, yamlOrJson);