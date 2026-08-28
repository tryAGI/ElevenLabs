
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class OTelResource
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attributes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::ElevenLabs.OTelAttribute> Attributes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OTelResource" /> class.
        /// </summary>
        /// <param name="attributes"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OTelResource(
            global::System.Collections.Generic.IList<global::ElevenLabs.OTelAttribute> attributes)
        {
            this.Attributes = attributes ?? throw new global::System.ArgumentNullException(nameof(attributes));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OTelResource" /> class.
        /// </summary>
        public OTelResource()
        {
        }

    }
}