
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class OTelSpan
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("traceId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TraceId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spanId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SpanId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parentSpanId")]
        public string? ParentSpanId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Kind { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("startTimeUnixNano")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string StartTimeUnixNano { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endTimeUnixNano")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EndTimeUnixNano { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attributes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::ElevenLabs.OTelAttribute> Attributes { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.OTelStatus Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OTelSpan" /> class.
        /// </summary>
        /// <param name="traceId"></param>
        /// <param name="spanId"></param>
        /// <param name="name"></param>
        /// <param name="kind"></param>
        /// <param name="startTimeUnixNano"></param>
        /// <param name="endTimeUnixNano"></param>
        /// <param name="attributes"></param>
        /// <param name="status"></param>
        /// <param name="parentSpanId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OTelSpan(
            string traceId,
            string spanId,
            string name,
            int kind,
            string startTimeUnixNano,
            string endTimeUnixNano,
            global::System.Collections.Generic.IList<global::ElevenLabs.OTelAttribute> attributes,
            global::ElevenLabs.OTelStatus status,
            string? parentSpanId)
        {
            this.TraceId = traceId ?? throw new global::System.ArgumentNullException(nameof(traceId));
            this.SpanId = spanId ?? throw new global::System.ArgumentNullException(nameof(spanId));
            this.ParentSpanId = parentSpanId;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Kind = kind;
            this.StartTimeUnixNano = startTimeUnixNano ?? throw new global::System.ArgumentNullException(nameof(startTimeUnixNano));
            this.EndTimeUnixNano = endTimeUnixNano ?? throw new global::System.ArgumentNullException(nameof(endTimeUnixNano));
            this.Attributes = attributes ?? throw new global::System.ArgumentNullException(nameof(attributes));
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OTelSpan" /> class.
        /// </summary>
        public OTelSpan()
        {
        }

    }
}