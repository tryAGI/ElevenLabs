using AutoSDK.Extensions;
using AutoSDK.Models;
using Microsoft.OpenApi;

var path = args[0];
var yamlOrJson = await File.ReadAllTextAsync(path);

var openApiDocument = yamlOrJson.GetOpenApiDocument(Settings.Default);

openApiDocument.Servers?.Clear();
openApiDocument.Servers?.Add(new OpenApiServer
{
    Url = "https://api.elevenlabs.io",
});
openApiDocument.Components!.SecuritySchemes!["ApiKeyAuth"] = new OpenApiSecurityScheme
{
    Type = SecuritySchemeType.ApiKey,
    In = ParameterLocation.Header,
    Name = "xi-api-key",
};
openApiDocument.Security =
[
    new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecuritySchemeReference("ApiKeyAuth", openApiDocument),
            new List<string>()
        }
    }
];

((OpenApiSchema)openApiDocument.Components.Schemas!["FineTuningResponseModel"]!.Properties!["next_max_verification_attempts_reset_unix_ms"]!).Format = "int64";

yamlOrJson = await openApiDocument.SerializeAsYamlAsync(OpenApiSpecVersion.OpenApi3_2);

await File.WriteAllTextAsync(path, yamlOrJson);
