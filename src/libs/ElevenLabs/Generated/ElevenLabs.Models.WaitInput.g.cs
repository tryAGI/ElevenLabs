
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WaitInput
    {
        /// <summary>
        /// Maximum seconds to wait (up to 3 minutes). Resolves early on completion or failure.<br/>
        /// Default Value: 120
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seconds")]
        public double? Seconds { get; set; }

        /// <summary>
        /// Deprecated: use session_ids. Single session ID to monitor.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_id")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? SessionId { get; set; }

        /// <summary>
        /// Session IDs from run_node to monitor. Resolves when ALL complete or any fails.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_ids")]
        public global::System.Collections.Generic.IList<string>? SessionIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WaitInput" /> class.
        /// </summary>
        /// <param name="seconds">
        /// Maximum seconds to wait (up to 3 minutes). Resolves early on completion or failure.<br/>
        /// Default Value: 120
        /// </param>
        /// <param name="sessionIds">
        /// Session IDs from run_node to monitor. Resolves when ALL complete or any fails.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WaitInput(
            double? seconds,
            global::System.Collections.Generic.IList<string>? sessionIds)
        {
            this.Seconds = seconds;
            this.SessionIds = sessionIds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WaitInput" /> class.
        /// </summary>
        public WaitInput()
        {
        }
    }
}