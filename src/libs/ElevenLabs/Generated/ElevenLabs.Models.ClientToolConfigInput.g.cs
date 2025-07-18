
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// A client tool is one that sends an event to the user's client to trigger something client side
    /// </summary>
    public sealed partial class ClientToolConfigInput
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// The maximum time in seconds to wait for the tool call to complete. Must be between 1 and 120 seconds (inclusive).<br/>
        /// Default Value: 20
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_timeout_secs")]
        public int? ResponseTimeoutSecs { get; set; }

        /// <summary>
        /// Configuration for extracting values from tool responses and assigning them to dynamic variables
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assignments")]
        public global::System.Collections.Generic.IList<global::ElevenLabs.DynamicVariableAssignment>? Assignments { get; set; }

        /// <summary>
        /// The type of tool<br/>
        /// Default Value: client
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.ClientToolConfigInputTypeJsonConverter))]
        public global::ElevenLabs.ClientToolConfigInputType? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parameters")]
        public global::ElevenLabs.ObjectJsonSchemaPropertyInput? Parameters { get; set; }

        /// <summary>
        /// If true, calling this tool should block the conversation until the client responds with some response which is passed to the llm. If false then we will continue the conversation without waiting for the client to respond, this is useful to show content to a user but not block the conversation<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expects_response")]
        public bool? ExpectsResponse { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dynamic_variables")]
        public global::ElevenLabs.DynamicVariablesConfig? DynamicVariables { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientToolConfigInput" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="responseTimeoutSecs">
        /// The maximum time in seconds to wait for the tool call to complete. Must be between 1 and 120 seconds (inclusive).<br/>
        /// Default Value: 20
        /// </param>
        /// <param name="assignments">
        /// Configuration for extracting values from tool responses and assigning them to dynamic variables
        /// </param>
        /// <param name="type">
        /// The type of tool<br/>
        /// Default Value: client
        /// </param>
        /// <param name="parameters"></param>
        /// <param name="expectsResponse">
        /// If true, calling this tool should block the conversation until the client responds with some response which is passed to the llm. If false then we will continue the conversation without waiting for the client to respond, this is useful to show content to a user but not block the conversation<br/>
        /// Default Value: false
        /// </param>
        /// <param name="dynamicVariables"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ClientToolConfigInput(
            string name,
            string description,
            int? responseTimeoutSecs,
            global::System.Collections.Generic.IList<global::ElevenLabs.DynamicVariableAssignment>? assignments,
            global::ElevenLabs.ClientToolConfigInputType? type,
            global::ElevenLabs.ObjectJsonSchemaPropertyInput? parameters,
            bool? expectsResponse,
            global::ElevenLabs.DynamicVariablesConfig? dynamicVariables)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.ResponseTimeoutSecs = responseTimeoutSecs;
            this.Assignments = assignments;
            this.Type = type;
            this.Parameters = parameters;
            this.ExpectsResponse = expectsResponse;
            this.DynamicVariables = dynamicVariables;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientToolConfigInput" /> class.
        /// </summary>
        public ClientToolConfigInput()
        {
        }
    }
}