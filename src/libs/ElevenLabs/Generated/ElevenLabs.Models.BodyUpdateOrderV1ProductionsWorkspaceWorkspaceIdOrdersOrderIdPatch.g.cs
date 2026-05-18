
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyUpdateOrderV1ProductionsWorkspaceWorkspaceIdOrdersOrderIdPatch
    {
        /// <summary>
        /// Example: {"name":"Spanish Dubs"}
        /// </summary>
        /// <example>{"name":"Spanish Dubs"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("request")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.UpdateOrderRequest Request { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyUpdateOrderV1ProductionsWorkspaceWorkspaceIdOrdersOrderIdPatch" /> class.
        /// </summary>
        /// <param name="request">
        /// Example: {"name":"Spanish Dubs"}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BodyUpdateOrderV1ProductionsWorkspaceWorkspaceIdOrdersOrderIdPatch(
            global::ElevenLabs.UpdateOrderRequest request)
        {
            this.Request = request ?? throw new global::System.ArgumentNullException(nameof(request));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyUpdateOrderV1ProductionsWorkspaceWorkspaceIdOrdersOrderIdPatch" /> class.
        /// </summary>
        public BodyUpdateOrderV1ProductionsWorkspaceWorkspaceIdOrdersOrderIdPatch()
        {
        }

    }
}