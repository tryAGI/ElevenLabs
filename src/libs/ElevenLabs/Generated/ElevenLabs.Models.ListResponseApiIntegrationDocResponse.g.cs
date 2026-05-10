
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListResponseApiIntegrationDocResponse
    {
        /// <summary>
        /// Default Value: {}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("meta")]
        public global::ElevenLabs.ListResponseMeta? Meta { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("results")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::ElevenLabs.ApiIntegrationDocResponse> Results { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListResponseApiIntegrationDocResponse" /> class.
        /// </summary>
        /// <param name="results"></param>
        /// <param name="meta">
        /// Default Value: {}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListResponseApiIntegrationDocResponse(
            global::System.Collections.Generic.IList<global::ElevenLabs.ApiIntegrationDocResponse> results,
            global::ElevenLabs.ListResponseMeta? meta)
        {
            this.Meta = meta;
            this.Results = results ?? throw new global::System.ArgumentNullException(nameof(results));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListResponseApiIntegrationDocResponse" /> class.
        /// </summary>
        public ListResponseApiIntegrationDocResponse()
        {
        }

    }
}