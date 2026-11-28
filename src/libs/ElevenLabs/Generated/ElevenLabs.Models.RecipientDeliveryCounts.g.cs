
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RecipientDeliveryCounts
    {
        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sent")]
        public int? Sent { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("delivered")]
        public int? Delivered { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("read")]
        public int? Read { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("replied")]
        public int? Replied { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failed")]
        public int? Failed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RecipientDeliveryCounts" /> class.
        /// </summary>
        /// <param name="sent">
        /// Default Value: 0
        /// </param>
        /// <param name="delivered">
        /// Default Value: 0
        /// </param>
        /// <param name="read">
        /// Default Value: 0
        /// </param>
        /// <param name="replied">
        /// Default Value: 0
        /// </param>
        /// <param name="failed">
        /// Default Value: 0
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RecipientDeliveryCounts(
            int? sent,
            int? delivered,
            int? read,
            int? replied,
            int? failed)
        {
            this.Sent = sent;
            this.Delivered = delivered;
            this.Read = read;
            this.Replied = replied;
            this.Failed = failed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RecipientDeliveryCounts" /> class.
        /// </summary>
        public RecipientDeliveryCounts()
        {
        }

    }
}