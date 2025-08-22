
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TestConditionResultCommonModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.EvaluationSuccessResultJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.EvaluationSuccessResult Result { get; set; }

        /// <summary>
        /// Structured rationale for test condition results containing individual failure/success reasons.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rationale")]
        public global::ElevenLabs.TestConditionRationaleCommonModel? Rationale { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TestConditionResultCommonModel" /> class.
        /// </summary>
        /// <param name="result"></param>
        /// <param name="rationale">
        /// Structured rationale for test condition results containing individual failure/success reasons.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TestConditionResultCommonModel(
            global::ElevenLabs.EvaluationSuccessResult result,
            global::ElevenLabs.TestConditionRationaleCommonModel? rationale)
        {
            this.Result = result;
            this.Rationale = rationale;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TestConditionResultCommonModel" /> class.
        /// </summary>
        public TestConditionResultCommonModel()
        {
        }
    }
}