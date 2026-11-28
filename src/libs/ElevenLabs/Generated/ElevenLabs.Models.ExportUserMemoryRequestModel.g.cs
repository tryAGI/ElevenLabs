
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Example: {"user_id":"ausr_01k6m3w9xq4f2c8t7n5b0r1d2e"}
    /// </summary>
    public sealed partial class ExportUserMemoryRequestModel
    {
        /// <summary>
        /// ID of the end user whose memory the agent is to export. Find it from the `user_id` your conversation initiation data sent with Find Agents User By Identity.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExportUserMemoryRequestModel" /> class.
        /// </summary>
        /// <param name="userId">
        /// ID of the end user whose memory the agent is to export. Find it from the `user_id` your conversation initiation data sent with Find Agents User By Identity.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExportUserMemoryRequestModel(
            string userId)
        {
            this.UserId = userId ?? throw new global::System.ArgumentNullException(nameof(userId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExportUserMemoryRequestModel" /> class.
        /// </summary>
        public ExportUserMemoryRequestModel()
        {
        }

    }
}