
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Workspace-wide user memory policy, applied to the memory of every agent in it.
    /// </summary>
    public sealed partial class WorkspaceUserMemorySettings
    {
        /// <summary>
        /// Days to retain a user's memories after their last conversation with an agent that has user memory on. None means the system default (365). A change applies to each user from their next such conversation. Unlimited retention is not expressible. Only a workspace admin can change it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("retention_days")]
        public int? RetentionDays { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkspaceUserMemorySettings" /> class.
        /// </summary>
        /// <param name="retentionDays">
        /// Days to retain a user's memories after their last conversation with an agent that has user memory on. None means the system default (365). A change applies to each user from their next such conversation. Unlimited retention is not expressible. Only a workspace admin can change it.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WorkspaceUserMemorySettings(
            int? retentionDays)
        {
            this.RetentionDays = retentionDays;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkspaceUserMemorySettings" /> class.
        /// </summary>
        public WorkspaceUserMemorySettings()
        {
        }

    }
}