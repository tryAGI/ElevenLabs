
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Example: {"environments":[{"name":"production","updated_at_unix_secs":1714000000},{"created_by_user_id":"user_7k2m9x","name":"staging","updated_at_unix_secs":1714003600}]}
    /// </summary>
    public sealed partial class EnvironmentsListResponse
    {
        /// <summary>
        /// All workspace environments, 'production' first. Variables without a value for an environment fall back to their production value.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environments")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::ElevenLabs.EnvironmentResponse> Environments { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EnvironmentsListResponse" /> class.
        /// </summary>
        /// <param name="environments">
        /// All workspace environments, 'production' first. Variables without a value for an environment fall back to their production value.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EnvironmentsListResponse(
            global::System.Collections.Generic.IList<global::ElevenLabs.EnvironmentResponse> environments)
        {
            this.Environments = environments ?? throw new global::System.ArgumentNullException(nameof(environments));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EnvironmentsListResponse" /> class.
        /// </summary>
        public EnvironmentsListResponse()
        {
        }

    }
}