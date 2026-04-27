
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
        /// Asset IDs of user-uploaded files to describe.<br/>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("asset_ids")]
        public global::System.Collections.Generic.IList<string>? AssetIds { get; set; }

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
        /// Asset IDs of user-uploaded files to describe.<br/>
        /// Default Value: []
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DescribeMediaInput(
            global::System.Collections.Generic.IList<string>? nodeIds,
            global::System.Collections.Generic.IList<string>? assetIds)
        {
            this.NodeIds = nodeIds;
            this.AssetIds = assetIds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DescribeMediaInput" /> class.
        /// </summary>
        public DescribeMediaInput()
        {
        }
    }
}