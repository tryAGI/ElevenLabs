
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Example: {"erased_at_unix_secs":1790000000,"opted_out":true}
    /// </summary>
    public sealed partial class EraseUserMemoryResponseModel
    {
        /// <summary>
        /// The agent remembers nothing about the user from before this time.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("erased_at_unix_secs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ErasedAtUnixSecs { get; set; }

        /// <summary>
        /// Whether the agent's memory is off for this user in future conversations.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("opted_out")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool OptedOut { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EraseUserMemoryResponseModel" /> class.
        /// </summary>
        /// <param name="erasedAtUnixSecs">
        /// The agent remembers nothing about the user from before this time.
        /// </param>
        /// <param name="optedOut">
        /// Whether the agent's memory is off for this user in future conversations.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EraseUserMemoryResponseModel(
            int erasedAtUnixSecs,
            bool optedOut)
        {
            this.ErasedAtUnixSecs = erasedAtUnixSecs;
            this.OptedOut = optedOut;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EraseUserMemoryResponseModel" /> class.
        /// </summary>
        public EraseUserMemoryResponseModel()
        {
        }

    }
}