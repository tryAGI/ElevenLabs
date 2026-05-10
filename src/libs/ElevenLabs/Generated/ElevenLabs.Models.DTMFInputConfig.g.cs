
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Configuration for DTMF (keypad) input collection during phone calls.
    /// </summary>
    public sealed partial class DTMFInputConfig
    {
        /// <summary>
        /// Timeout in seconds to wait for additional DTMF digits<br/>
        /// Default Value: 2F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dtmf_input_timeout")]
        public double? DtmfInputTimeout { get; set; }

        /// <summary>
        /// If true, pressing # immediately completes DTMF input<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hash_terminator")]
        public bool? HashTerminator { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DTMFInputConfig" /> class.
        /// </summary>
        /// <param name="dtmfInputTimeout">
        /// Timeout in seconds to wait for additional DTMF digits<br/>
        /// Default Value: 2F
        /// </param>
        /// <param name="hashTerminator">
        /// If true, pressing # immediately completes DTMF input<br/>
        /// Default Value: true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DTMFInputConfig(
            double? dtmfInputTimeout,
            bool? hashTerminator)
        {
            this.DtmfInputTimeout = dtmfInputTimeout;
            this.HashTerminator = hashTerminator;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DTMFInputConfig" /> class.
        /// </summary>
        public DTMFInputConfig()
        {
        }

    }
}