
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Example: {"created_by_user_id":"user_7k2m9x","name":"staging","updated_at_unix_secs":1714003600}
    /// </summary>
    public sealed partial class EnvironmentResponse
    {
        /// <summary>
        /// Name of the environment, e.g. 'staging'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// When the environment was created or one of its values last changed. Unset when neither is known.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at_unix_secs")]
        public int? UpdatedAtUnixSecs { get; set; }

        /// <summary>
        /// Unset for 'production' and when the creator is not known.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_by_user_id")]
        public string? CreatedByUserId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EnvironmentResponse" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the environment, e.g. 'staging'.
        /// </param>
        /// <param name="updatedAtUnixSecs">
        /// When the environment was created or one of its values last changed. Unset when neither is known.
        /// </param>
        /// <param name="createdByUserId">
        /// Unset for 'production' and when the creator is not known.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EnvironmentResponse(
            string name,
            int? updatedAtUnixSecs,
            string? createdByUserId)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.UpdatedAtUnixSecs = updatedAtUnixSecs;
            this.CreatedByUserId = createdByUserId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EnvironmentResponse" /> class.
        /// </summary>
        public EnvironmentResponse()
        {
        }

    }
}