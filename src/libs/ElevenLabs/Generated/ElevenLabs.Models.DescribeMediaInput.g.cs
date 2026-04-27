
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DescribeMediaInput
    {
        /// <summary>
        /// Node IDs whose latest completed generation should be described.<br/>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("node_ids")]
        public global::System.Collections.Generic.IList<string>? NodeIds { get; set; }

        /// <summary>
        /// IDs of user-uploaded assets to describe. Use the value from a `content_asset_id=&lt;id&gt;` reference line.<br/>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("asset_ids")]
        public global::System.Collections.Generic.IList<string>? AssetIds { get; set; }

        /// <summary>
        /// IDs of saved content generations to describe. Use the value from a `generation_id=&lt;id&gt;` reference line.<br/>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generation_ids")]
        public global::System.Collections.Generic.IList<string>? GenerationIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DescribeMediaInput" /> class.
        /// </summary>
        /// <param name="nodeIds">
        /// Node IDs whose latest completed generation should be described.<br/>
        /// Default Value: []
        /// </param>
        /// <param name="assetIds">
        /// IDs of user-uploaded assets to describe. Use the value from a `content_asset_id=&lt;id&gt;` reference line.<br/>
        /// Default Value: []
        /// </param>
        /// <param name="generationIds">
        /// IDs of saved content generations to describe. Use the value from a `generation_id=&lt;id&gt;` reference line.<br/>
        /// Default Value: []
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DescribeMediaInput(
            global::System.Collections.Generic.IList<string>? nodeIds,
            global::System.Collections.Generic.IList<string>? assetIds,
            global::System.Collections.Generic.IList<string>? generationIds)
        {
            this.NodeIds = nodeIds;
            this.AssetIds = assetIds;
            this.GenerationIds = generationIds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DescribeMediaInput" /> class.
        /// </summary>
        public DescribeMediaInput()
        {
        }
    }
}