
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TransferToNumberResultSipSuccessModel
    {
        /// <summary>
        /// Default Value: transfer_to_number_sip_success
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.TransferToNumberResultSipSuccessModelResultTypeJsonConverter))]
        public global::ElevenLabs.TransferToNumberResultSipSuccessModelResultType? ResultType { get; set; }

        /// <summary>
        /// Default Value: success
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.TransferToNumberResultSipSuccessModelStatusJsonConverter))]
        public global::ElevenLabs.TransferToNumberResultSipSuccessModelStatus? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transfer_number")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TransferNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason")]
        public string? Reason { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("note")]
        public string? Note { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TransferToNumberResultSipSuccessModel" /> class.
        /// </summary>
        /// <param name="resultType">
        /// Default Value: transfer_to_number_sip_success
        /// </param>
        /// <param name="status">
        /// Default Value: success
        /// </param>
        /// <param name="transferNumber"></param>
        /// <param name="reason"></param>
        /// <param name="note"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TransferToNumberResultSipSuccessModel(
            string transferNumber,
            global::ElevenLabs.TransferToNumberResultSipSuccessModelResultType? resultType,
            global::ElevenLabs.TransferToNumberResultSipSuccessModelStatus? status,
            string? reason,
            string? note)
        {
            this.TransferNumber = transferNumber ?? throw new global::System.ArgumentNullException(nameof(transferNumber));
            this.ResultType = resultType;
            this.Status = status;
            this.Reason = reason;
            this.Note = note;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TransferToNumberResultSipSuccessModel" /> class.
        /// </summary>
        public TransferToNumberResultSipSuccessModel()
        {
        }
    }
}