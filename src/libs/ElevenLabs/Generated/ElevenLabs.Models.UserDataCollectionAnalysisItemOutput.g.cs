
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UserDataCollectionAnalysisItemOutput
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Default Value: user
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        public string? Source { get; set; }

        /// <summary>
        /// LLM to use for this item. If unset, the attaching agent's analysis_llm default is used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("llm")]
        public global::ElevenLabs.Llm? Llm { get; set; }

        /// <summary>
        /// Default Value: data_collection
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        public string? Kind { get; set; }

        /// <summary>
        /// Type/description/enum describing the value to extract.<br/>
        /// Example: {"description":"A user-provided message","type":"string"}
        /// </summary>
        /// <example>{"description":"A user-provided message","type":"string"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("value_schema")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.DataCollectionValueSchema ValueSchema { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserDataCollectionAnalysisItemOutput" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="valueSchema">
        /// Type/description/enum describing the value to extract.<br/>
        /// Example: {"description":"A user-provided message","type":"string"}
        /// </param>
        /// <param name="source">
        /// Default Value: user
        /// </param>
        /// <param name="llm">
        /// LLM to use for this item. If unset, the attaching agent's analysis_llm default is used.
        /// </param>
        /// <param name="kind">
        /// Default Value: data_collection
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserDataCollectionAnalysisItemOutput(
            string name,
            global::ElevenLabs.DataCollectionValueSchema valueSchema,
            string? source,
            global::ElevenLabs.Llm? llm,
            string? kind)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Source = source;
            this.Llm = llm;
            this.Kind = kind;
            this.ValueSchema = valueSchema ?? throw new global::System.ArgumentNullException(nameof(valueSchema));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserDataCollectionAnalysisItemOutput" /> class.
        /// </summary>
        public UserDataCollectionAnalysisItemOutput()
        {
        }

    }
}