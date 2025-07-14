
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CustomLLM
    {
        /// <summary>
        /// The URL of the Chat Completions compatible endpoint
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// The model ID to be used if URL serves multiple models
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_id")]
        public string? ModelId { get; set; }

        /// <summary>
        /// Used to reference a secret from the agent's secret store.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_key")]
        public global::ElevenLabs.ConvAISecretLocator? ApiKey { get; set; }

        /// <summary>
        /// Headers that should be included in the request
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_headers")]
        public object? RequestHeaders { get; set; }

        /// <summary>
        /// The API version to use for the request
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_version")]
        public string? ApiVersion { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomLLM" /> class.
        /// </summary>
        /// <param name="url">
        /// The URL of the Chat Completions compatible endpoint
        /// </param>
        /// <param name="modelId">
        /// The model ID to be used if URL serves multiple models
        /// </param>
        /// <param name="apiKey">
        /// Used to reference a secret from the agent's secret store.
        /// </param>
        /// <param name="requestHeaders">
        /// Headers that should be included in the request
        /// </param>
        /// <param name="apiVersion">
        /// The API version to use for the request
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CustomLLM(
            string url,
            string? modelId,
            global::ElevenLabs.ConvAISecretLocator? apiKey,
            object? requestHeaders,
            string? apiVersion)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.ModelId = modelId;
            this.ApiKey = apiKey;
            this.RequestHeaders = requestHeaders;
            this.ApiVersion = apiVersion;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomLLM" /> class.
        /// </summary>
        public CustomLLM()
        {
        }
    }
}