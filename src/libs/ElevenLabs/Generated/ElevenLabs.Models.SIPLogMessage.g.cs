
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SIPLogMessage
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("call_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CallId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("phone_numbers")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> PhoneNumbers { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("local_address")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string LocalAddress { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("remote_address")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RemoteAddress { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transport")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Transport { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("raw_message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RawMessage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ErrorMessage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("direction")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.SIPLogMessageDirectionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.SIPLogMessageDirection Direction { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at_unix_micro")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CreatedAtUnixMicro { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SIPLogMessage" /> class.
        /// </summary>
        /// <param name="callId"></param>
        /// <param name="phoneNumbers"></param>
        /// <param name="localAddress"></param>
        /// <param name="remoteAddress"></param>
        /// <param name="transport"></param>
        /// <param name="rawMessage"></param>
        /// <param name="errorMessage"></param>
        /// <param name="direction"></param>
        /// <param name="createdAtUnixMicro"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SIPLogMessage(
            string callId,
            global::System.Collections.Generic.IList<string> phoneNumbers,
            string localAddress,
            string remoteAddress,
            string transport,
            string rawMessage,
            string errorMessage,
            global::ElevenLabs.SIPLogMessageDirection direction,
            int createdAtUnixMicro)
        {
            this.CallId = callId ?? throw new global::System.ArgumentNullException(nameof(callId));
            this.PhoneNumbers = phoneNumbers ?? throw new global::System.ArgumentNullException(nameof(phoneNumbers));
            this.LocalAddress = localAddress ?? throw new global::System.ArgumentNullException(nameof(localAddress));
            this.RemoteAddress = remoteAddress ?? throw new global::System.ArgumentNullException(nameof(remoteAddress));
            this.Transport = transport ?? throw new global::System.ArgumentNullException(nameof(transport));
            this.RawMessage = rawMessage ?? throw new global::System.ArgumentNullException(nameof(rawMessage));
            this.ErrorMessage = errorMessage ?? throw new global::System.ArgumentNullException(nameof(errorMessage));
            this.Direction = direction;
            this.CreatedAtUnixMicro = createdAtUnixMicro;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SIPLogMessage" /> class.
        /// </summary>
        public SIPLogMessage()
        {
        }
    }
}