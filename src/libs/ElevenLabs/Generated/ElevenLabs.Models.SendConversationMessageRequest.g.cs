
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SendConversationMessageRequest
    {
        /// <summary>
        /// Either one `user_message`, which starts a new turn, or `client_tool_result` items, which answer the `required_actions` of the waiting turn and continue it. Calls that they leave out stay pending. Client tools wait with no timeout. While calls are pending, a `user_message` is rejected. A `user_message` can come with `contextual_update` items, at most one per `context_id`. `client_tool_result` items that answer every pending call can come with `end` updates.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::ElevenLabs.InputItem> Input { get; set; }

        /// <summary>
        /// If true, return a 202 handle after the turn is admitted instead of waiting for generation to finish.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("background")]
        public bool? Background { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SendConversationMessageRequest" /> class.
        /// </summary>
        /// <param name="input">
        /// Either one `user_message`, which starts a new turn, or `client_tool_result` items, which answer the `required_actions` of the waiting turn and continue it. Calls that they leave out stay pending. Client tools wait with no timeout. While calls are pending, a `user_message` is rejected. A `user_message` can come with `contextual_update` items, at most one per `context_id`. `client_tool_result` items that answer every pending call can come with `end` updates.
        /// </param>
        /// <param name="background">
        /// If true, return a 202 handle after the turn is admitted instead of waiting for generation to finish.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SendConversationMessageRequest(
            global::System.Collections.Generic.IList<global::ElevenLabs.InputItem> input,
            bool? background)
        {
            this.Input = input ?? throw new global::System.ArgumentNullException(nameof(input));
            this.Background = background;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SendConversationMessageRequest" /> class.
        /// </summary>
        public SendConversationMessageRequest()
        {
        }

    }
}