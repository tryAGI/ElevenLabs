
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Example: {"sandbox":false}
    /// </summary>
    public sealed partial class CreateOrderRequest
    {
        /// <summary>
        /// When true, creates a sandbox order that auto-progresses without producer intervention.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sandbox")]
        public bool? Sandbox { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOrderRequest" /> class.
        /// </summary>
        /// <param name="sandbox">
        /// When true, creates a sandbox order that auto-progresses without producer intervention.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateOrderRequest(
            bool? sandbox)
        {
            this.Sandbox = sandbox;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOrderRequest" /> class.
        /// </summary>
        public CreateOrderRequest()
        {
        }

    }
}