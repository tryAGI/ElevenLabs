
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AllowlistItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hostname")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Hostname { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AllowlistItem" /> class.
        /// </summary>
        /// <param name="hostname"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public AllowlistItem(
            string hostname)
        {
            this.Hostname = hostname ?? throw new global::System.ArgumentNullException(nameof(hostname));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AllowlistItem" /> class.
        /// </summary>
        public AllowlistItem()
        {
        }
    }
}