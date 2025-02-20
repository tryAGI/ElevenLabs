
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SafetyResponseModel
    {
        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_blocked_ivc")]
        public bool? IsBlockedIvc { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_blocked_non_ivc")]
        public bool? IsBlockedNonIvc { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SafetyResponseModel" /> class.
        /// </summary>
        /// <param name="isBlockedIvc">
        /// Default Value: false
        /// </param>
        /// <param name="isBlockedNonIvc">
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SafetyResponseModel(
            bool? isBlockedIvc,
            bool? isBlockedNonIvc)
        {
            this.IsBlockedIvc = isBlockedIvc;
            this.IsBlockedNonIvc = isBlockedNonIvc;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SafetyResponseModel" /> class.
        /// </summary>
        public SafetyResponseModel()
        {
        }
    }
}