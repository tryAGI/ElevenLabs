
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BackupLLMOverride
    {
        /// <summary>
        /// Default Value: override
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("preference")]
        public string? Preference { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("order")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::System.Collections.Generic.IList<global::ElevenLabs.Llm> Order { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BackupLLMOverride" /> class.
        /// </summary>
        /// <param name="preference">
        /// Default Value: override
        /// </param>
        /// <param name="order"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BackupLLMOverride(
            global::System.Collections.Generic.IList<global::ElevenLabs.Llm> order,
            string? preference)
        {
            this.Order = order ?? throw new global::System.ArgumentNullException(nameof(order));
            this.Preference = preference;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BackupLLMOverride" /> class.
        /// </summary>
        public BackupLLMOverride()
        {
        }
    }
}