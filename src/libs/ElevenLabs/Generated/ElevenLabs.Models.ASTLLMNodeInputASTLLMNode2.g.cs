
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ASTLLMNodeInputASTLLMNode2
    {
        /// <summary>
        /// Default Value: llm
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// The prompt to evaluate to a boolean value. Deprecated. Use a boolean schema instead.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ASTLLMNodeInputASTLLMNode2" /> class.
        /// </summary>
        /// <param name="prompt">
        /// The prompt to evaluate to a boolean value. Deprecated. Use a boolean schema instead.
        /// </param>
        /// <param name="type">
        /// Default Value: llm
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ASTLLMNodeInputASTLLMNode2(
            string prompt,
            string? type)
        {
            this.Type = type;
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ASTLLMNodeInputASTLLMNode2" /> class.
        /// </summary>
        public ASTLLMNodeInputASTLLMNode2()
        {
        }

    }
}