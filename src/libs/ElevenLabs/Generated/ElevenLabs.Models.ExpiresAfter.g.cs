
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ExpiresAfter
    {
        /// <summary>
        /// Default Value: created_at
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("anchor")]
        public string? Anchor { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seconds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Seconds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExpiresAfter" /> class.
        /// </summary>
        /// <param name="seconds"></param>
        /// <param name="anchor">
        /// Default Value: created_at
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExpiresAfter(
            int seconds,
            string? anchor)
        {
            this.Anchor = anchor;
            this.Seconds = seconds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExpiresAfter" /> class.
        /// </summary>
        public ExpiresAfter()
        {
        }

    }
}