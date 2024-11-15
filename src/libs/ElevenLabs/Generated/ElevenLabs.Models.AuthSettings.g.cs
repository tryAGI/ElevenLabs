
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AuthSettings
    {
        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enable_auth")]
        public bool? EnableAuth { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthSettings" /> class.
        /// </summary>
        /// <param name="enableAuth">
        /// Default Value: false
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public AuthSettings(
            bool? enableAuth)
        {
            this.EnableAuth = enableAuth;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthSettings" /> class.
        /// </summary>
        public AuthSettings()
        {
        }
    }
}