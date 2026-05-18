
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyUpsertOrderItemV1ProductionsWorkspaceWorkspaceIdOrdersOrderIdItemsPost
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.UpsertOrderItemRequest Request { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyUpsertOrderItemV1ProductionsWorkspaceWorkspaceIdOrdersOrderIdItemsPost" /> class.
        /// </summary>
        /// <param name="request"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BodyUpsertOrderItemV1ProductionsWorkspaceWorkspaceIdOrdersOrderIdItemsPost(
            global::ElevenLabs.UpsertOrderItemRequest request)
        {
            this.Request = request ?? throw new global::System.ArgumentNullException(nameof(request));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyUpsertOrderItemV1ProductionsWorkspaceWorkspaceIdOrdersOrderIdItemsPost" /> class.
        /// </summary>
        public BodyUpsertOrderItemV1ProductionsWorkspaceWorkspaceIdOrdersOrderIdItemsPost()
        {
        }

    }
}