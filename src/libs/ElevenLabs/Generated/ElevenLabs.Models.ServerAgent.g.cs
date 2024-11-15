
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ServerAgent
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("server_events")]
        public global::System.Collections.Generic.IList<global::ElevenLabs.ServerEvent>? ServerEvents { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("secret")]
        public string? Secret { get; set; }

        /// <summary>
        /// Default Value: 5
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeout")]
        public double? Timeout { get; set; }

        /// <summary>
        /// Default Value: 2
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_retries")]
        public int? NumRetries { get; set; }

        /// <summary>
        /// Default Value: I encountered an internal error occurred while handling your request and I am not able to respond at the moment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_message")]
        public string? ErrorMessage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ServerAgent" /> class.
        /// </summary>
        /// <param name="url"></param>
        /// <param name="serverEvents"></param>
        /// <param name="secret"></param>
        /// <param name="timeout">
        /// Default Value: 5
        /// </param>
        /// <param name="numRetries">
        /// Default Value: 2
        /// </param>
        /// <param name="errorMessage">
        /// Default Value: I encountered an internal error occurred while handling your request and I am not able to respond at the moment.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ServerAgent(
            string url,
            global::System.Collections.Generic.IList<global::ElevenLabs.ServerEvent>? serverEvents,
            string? secret,
            double? timeout,
            int? numRetries,
            string? errorMessage)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.ServerEvents = serverEvents;
            this.Secret = secret;
            this.Timeout = timeout;
            this.NumRetries = numRetries;
            this.ErrorMessage = errorMessage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ServerAgent" /> class.
        /// </summary>
        public ServerAgent()
        {
        }
    }
}