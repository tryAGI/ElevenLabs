
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ResellerUpcomingPaymentsResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("payments")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::ElevenLabs.ResellerUpcomingPayment> Payments { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResellerUpcomingPaymentsResponse" /> class.
        /// </summary>
        /// <param name="payments"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResellerUpcomingPaymentsResponse(
            global::System.Collections.Generic.IList<global::ElevenLabs.ResellerUpcomingPayment> payments)
        {
            this.Payments = payments ?? throw new global::System.ArgumentNullException(nameof(payments));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResellerUpcomingPaymentsResponse" /> class.
        /// </summary>
        public ResellerUpcomingPaymentsResponse()
        {
        }

    }
}