
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// A system tool is a tool that is used to call a system method in the server
    /// </summary>
    public sealed partial class SystemToolConfigInput
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
        /// The maximum time in seconds to wait for the tool call to complete.<br/>
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
        /// Default Value: system
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.SystemToolConfigInputTypeJsonConverter))]
        public global::ElevenLabs.SystemToolConfigInputType? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("params")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.ParamsJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.Params Params { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SystemToolConfigInput" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="responseTimeoutSecs">
        /// The maximum time in seconds to wait for the tool call to complete.<br/>
        /// Default Value: 20
        /// </param>
        /// <param name="assignments">
        /// Configuration for extracting values from tool responses and assigning them to dynamic variables
        /// </param>
        /// <param name="type">
        /// The type of tool<br/>
        /// Default Value: system
        /// </param>
        /// <param name="params"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SystemToolConfigInput(
            string name,
            string description,
            global::ElevenLabs.Params @params,
            int? responseTimeoutSecs,
            global::System.Collections.Generic.IList<global::ElevenLabs.DynamicVariableAssignment>? assignments,
            global::ElevenLabs.SystemToolConfigInputType? type)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.Params = @params;
            this.ResponseTimeoutSecs = responseTimeoutSecs;
            this.Assignments = assignments;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SystemToolConfigInput" /> class.
        /// </summary>
        public SystemToolConfigInput()
        {
        }
    }
}