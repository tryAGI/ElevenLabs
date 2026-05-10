
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Device information.<br/>
    /// Spec: https://schema.ocsf.io/1.6.0/objects/device
    /// </summary>
    public sealed partial class DeviceModel
    {
        /// <summary>
        /// IP address
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ip")]
        public string? Ip { get; set; }

        /// <summary>
        /// Device hostname
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hostname")]
        public string? Hostname { get; set; }

        /// <summary>
        /// Device type ID (99 = Unknown)<br/>
        /// Default Value: 99
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type_id")]
        public int? TypeId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceModel" /> class.
        /// </summary>
        /// <param name="ip">
        /// IP address
        /// </param>
        /// <param name="hostname">
        /// Device hostname
        /// </param>
        /// <param name="typeId">
        /// Device type ID (99 = Unknown)<br/>
        /// Default Value: 99
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeviceModel(
            string? ip,
            string? hostname,
            int? typeId)
        {
            this.Ip = ip;
            this.Hostname = hostname;
            this.TypeId = typeId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceModel" /> class.
        /// </summary>
        public DeviceModel()
        {
        }

    }
}