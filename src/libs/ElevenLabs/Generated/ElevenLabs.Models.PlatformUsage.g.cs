
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Per-category breakdown of ``platform_charge`` (the analogue of ``llm_usage``).
    /// </summary>
    public sealed partial class PlatformUsage
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("category_usage")]
        public global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.PlatformCategoryUsage>? CategoryUsage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PlatformUsage" /> class.
        /// </summary>
        /// <param name="categoryUsage"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PlatformUsage(
            global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.PlatformCategoryUsage>? categoryUsage)
        {
            this.CategoryUsage = categoryUsage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PlatformUsage" /> class.
        /// </summary>
        public PlatformUsage()
        {
        }

    }
}