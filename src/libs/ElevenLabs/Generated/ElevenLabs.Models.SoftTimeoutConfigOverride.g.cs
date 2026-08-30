
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Example: {"message":"Hhmmmm...yeah."}
    /// </summary>
    public sealed partial class SoftTimeoutConfigOverride
    {
        /// <summary>
        /// Message to show when the first soft timeout is reached while waiting for LLM response. Supports dynamic variables (e.g., {{system__time}}, {{custom_variable}}).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Extra static filler messages for subsequent soft timeouts in the same LLM generation. The first timeout uses `message`. If fewer messages are configured than `max_soft_timeouts_per_generation`, the last configured message is repeated; otherwise a built-in filler is used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("additional_soft_timeout_messages")]
        public global::System.Collections.Generic.IList<string>? AdditionalSoftTimeoutMessages { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SoftTimeoutConfigOverride" /> class.
        /// </summary>
        /// <param name="message">
        /// Message to show when the first soft timeout is reached while waiting for LLM response. Supports dynamic variables (e.g., {{system__time}}, {{custom_variable}}).
        /// </param>
        /// <param name="additionalSoftTimeoutMessages">
        /// Extra static filler messages for subsequent soft timeouts in the same LLM generation. The first timeout uses `message`. If fewer messages are configured than `max_soft_timeouts_per_generation`, the last configured message is repeated; otherwise a built-in filler is used.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SoftTimeoutConfigOverride(
            string? message,
            global::System.Collections.Generic.IList<string>? additionalSoftTimeoutMessages)
        {
            this.Message = message;
            this.AdditionalSoftTimeoutMessages = additionalSoftTimeoutMessages;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SoftTimeoutConfigOverride" /> class.
        /// </summary>
        public SoftTimeoutConfigOverride()
        {
        }

    }
}