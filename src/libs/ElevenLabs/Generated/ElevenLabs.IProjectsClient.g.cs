
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Access, create and convert Projects programmatically, only specifically whitelisted accounts can access the Projects API. If you need access please contact our sales team.<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public partial interface IProjectsClient : global::System.IDisposable
    {
        /// <summary>
        /// 
        /// </summary>
        global::System.Text.Json.Serialization.JsonSerializerContext JsonSerializerContext { get; set; }


    }
}