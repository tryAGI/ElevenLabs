
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TurnConfig
    {
        /// <summary>
        /// Default Value: 7
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("turn_timeout")]
        public double? TurnTimeout { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TurnConfig" /> class.
        /// </summary>
        /// <param name="turnTimeout">
        /// Default Value: 7
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public TurnConfig(
            double? turnTimeout)
        {
            this.TurnTimeout = turnTimeout;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TurnConfig" /> class.
        /// </summary>
        public TurnConfig()
        {
        }
    }
}