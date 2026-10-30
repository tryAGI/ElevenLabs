
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BodySmbUpdateTransferRule
    {
        /// <summary>
        /// Request model for updating an existing transfer rule.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.SMBUpdateTransferRuleRequest Request { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodySmbUpdateTransferRule" /> class.
        /// </summary>
        /// <param name="request">
        /// Request model for updating an existing transfer rule.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BodySmbUpdateTransferRule(
            global::ElevenLabs.SMBUpdateTransferRuleRequest request)
        {
            this.Request = request ?? throw new global::System.ArgumentNullException(nameof(request));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodySmbUpdateTransferRule" /> class.
        /// </summary>
        public BodySmbUpdateTransferRule()
        {
        }

    }
}