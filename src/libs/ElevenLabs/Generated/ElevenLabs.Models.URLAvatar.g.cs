
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class URLAvatar
    {
        /// <summary>
        /// Default Value: url
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.URLAvatarTypeJsonConverter))]
        public global::ElevenLabs.URLAvatarType? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_url")]
        public string? CustomUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="URLAvatar" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: url
        /// </param>
        /// <param name="customUrl"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public URLAvatar(
            global::ElevenLabs.URLAvatarType? type,
            string? customUrl)
        {
            this.Type = type;
            this.CustomUrl = customUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="URLAvatar" /> class.
        /// </summary>
        public URLAvatar()
        {
        }
    }
}