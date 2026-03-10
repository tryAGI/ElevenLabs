
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ASTLessThanOrEqualsOperatorNodeOutputRightDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.ASTLessThanOrEqualsOperatorNodeOutputRightDiscriminatorTypeJsonConverter))]
        public global::ElevenLabs.ASTLessThanOrEqualsOperatorNodeOutputRightDiscriminatorType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ASTLessThanOrEqualsOperatorNodeOutputRightDiscriminator" /> class.
        /// </summary>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ASTLessThanOrEqualsOperatorNodeOutputRightDiscriminator(
            global::ElevenLabs.ASTLessThanOrEqualsOperatorNodeOutputRightDiscriminatorType? type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ASTLessThanOrEqualsOperatorNodeOutputRightDiscriminator" /> class.
        /// </summary>
        public ASTLessThanOrEqualsOperatorNodeOutputRightDiscriminator()
        {
        }
    }
}