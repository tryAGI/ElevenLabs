
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SendConversationMessageStreamRequest
    {
        /// <summary>
        /// Either one `user_message`, which starts a new turn, or `client_tool_result` items, which answer the `required_actions` of the waiting turn and continue it. Calls that they leave out stay pending. Client tools wait with no timeout. While calls are pending, a `user_message` is rejected. A `user_message` can come with `contextual_update` items, at most one per `context_id`. `client_tool_result` items that answer every pending call can come with `end` updates.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::ElevenLabs.InputItem2> Input { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SendConversationMessageStreamRequest" /> class.
        /// </summary>
        /// <param name="input">
        /// Either one `user_message`, which starts a new turn, or `client_tool_result` items, which answer the `required_actions` of the waiting turn and continue it. Calls that they leave out stay pending. Client tools wait with no timeout. While calls are pending, a `user_message` is rejected. A `user_message` can come with `contextual_update` items, at most one per `context_id`. `client_tool_result` items that answer every pending call can come with `end` updates.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SendConversationMessageStreamRequest(
            global::System.Collections.Generic.IList<global::ElevenLabs.InputItem2> input)
        {
            this.Input = input ?? throw new global::System.ArgumentNullException(nameof(input));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SendConversationMessageStreamRequest" /> class.
        /// </summary>
        public SendConversationMessageStreamRequest()
        {
        }

    }
}