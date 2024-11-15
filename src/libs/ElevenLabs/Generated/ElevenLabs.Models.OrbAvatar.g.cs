
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OrbAvatar
    {
        /// <summary>
        /// Default Value: orb
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.OrbAvatarTypeJsonConverter))]
        public global::ElevenLabs.OrbAvatarType? Type { get; set; }

        /// <summary>
        /// Default Value: #2792dc
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("color_1")]
        public string? Color1 { get; set; }

        /// <summary>
        /// Default Value: #9ce6e6
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("color_2")]
        public string? Color2 { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrbAvatar" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: orb
        /// </param>
        /// <param name="color1">
        /// Default Value: #2792dc
        /// </param>
        /// <param name="color2">
        /// Default Value: #9ce6e6
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public OrbAvatar(
            global::ElevenLabs.OrbAvatarType? type,
            string? color1,
            string? color2)
        {
            this.Type = type;
            this.Color1 = color1;
            this.Color2 = color2;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrbAvatar" /> class.
        /// </summary>
        public OrbAvatar()
        {
        }
    }
}