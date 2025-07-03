
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PhoneNumberTransfer
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transfer_destination")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.TransferDestinationJsonConverter))]
        public global::ElevenLabs.TransferDestination? TransferDestination { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("phone_number")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? PhoneNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("condition")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Condition { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transfer_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.TransferTypeEnumJsonConverter))]
        public global::ElevenLabs.TransferTypeEnum? TransferType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PhoneNumberTransfer" /> class.
        /// </summary>
        /// <param name="transferDestination"></param>
        /// <param name="condition"></param>
        /// <param name="transferType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PhoneNumberTransfer(
            string condition,
            global::ElevenLabs.TransferDestination? transferDestination,
            global::ElevenLabs.TransferTypeEnum? transferType)
        {
            this.Condition = condition ?? throw new global::System.ArgumentNullException(nameof(condition));
            this.TransferDestination = transferDestination;
            this.TransferType = transferType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PhoneNumberTransfer" /> class.
        /// </summary>
        public PhoneNumberTransfer()
        {
        }
    }
}