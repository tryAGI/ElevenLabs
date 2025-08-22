
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UnitTestSummaryResponseModel
    {
        /// <summary>
        /// The ID of the test
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Name of the test
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("access_info")]
        public global::ElevenLabs.ResourceAccessInfo? AccessInfo { get; set; }

        /// <summary>
        /// Creation time of the test in unix seconds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at_unix_secs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CreatedAtUnixSecs { get; set; }

        /// <summary>
        /// Last update time of the test in unix seconds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_updated_at_unix_secs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int LastUpdatedAtUnixSecs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UnitTestSummaryResponseModel" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the test
        /// </param>
        /// <param name="name">
        /// Name of the test
        /// </param>
        /// <param name="accessInfo"></param>
        /// <param name="createdAtUnixSecs">
        /// Creation time of the test in unix seconds
        /// </param>
        /// <param name="lastUpdatedAtUnixSecs">
        /// Last update time of the test in unix seconds
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UnitTestSummaryResponseModel(
            string id,
            string name,
            int createdAtUnixSecs,
            int lastUpdatedAtUnixSecs,
            global::ElevenLabs.ResourceAccessInfo? accessInfo)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.CreatedAtUnixSecs = createdAtUnixSecs;
            this.LastUpdatedAtUnixSecs = lastUpdatedAtUnixSecs;
            this.AccessInfo = accessInfo;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnitTestSummaryResponseModel" /> class.
        /// </summary>
        public UnitTestSummaryResponseModel()
        {
        }
    }
}