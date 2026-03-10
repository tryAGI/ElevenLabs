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

yamlOrJson = await openApiDocument.SerializeAsYamlAsync(OpenApiSpecVersion.OpenApi3_2);

await File.WriteAllTextAsync(path, yamlOrJson);
