
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TransferToNumberResultAmazonConnectSuccessModel
    {
        /// <summary>
        /// Default Value: transfer_to_number_amazon_connect_success
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result_type")]
        public string? ResultType { get; set; }

        /// <summary>
        /// Default Value: success
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// Why the agent escalated, as sent to Amazon Connect with the Escalate outcome.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason")]
        public string? Reason { get; set; }

        /// <summary>
        /// Message spoken to the caller before the session was handed back to Amazon Connect.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_message")]
        public string? ClientMessage { get; set; }

        /// <summary>
        /// Set when the agent echoed an invalid option and the only configured one was used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("note")]
        public string? Note { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TransferToNumberResultAmazonConnectSuccessModel" /> class.
        /// </summary>
        /// <param name="resultType">
        /// Default Value: transfer_to_number_amazon_connect_success
        /// </param>
        /// <param name="status">
        /// Default Value: success
        /// </param>
        /// <param name="reason">
        /// Why the agent escalated, as sent to Amazon Connect with the Escalate outcome.
        /// </param>
        /// <param name="clientMessage">
        /// Message spoken to the caller before the session was handed back to Amazon Connect.
        /// </param>
        /// <param name="note">
        /// Set when the agent echoed an invalid option and the only configured one was used.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TransferToNumberResultAmazonConnectSuccessModel(
            string? resultType,
            string? status,
            string? reason,
            string? clientMessage,
            string? note)
        {
            this.ResultType = resultType;
            this.Status = status;
            this.Reason = reason;
            this.ClientMessage = clientMessage;
            this.Note = note;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TransferToNumberResultAmazonConnectSuccessModel" /> class.
        /// </summary>
        public TransferToNumberResultAmazonConnectSuccessModel()
        {
        }

    }
}