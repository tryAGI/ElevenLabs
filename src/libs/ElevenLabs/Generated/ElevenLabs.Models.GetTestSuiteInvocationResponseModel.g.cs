
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetTestSuiteInvocationResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        public string? AgentId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("branch_id")]
        public string? BranchId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public int? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("folder_id")]
        public string? FolderId { get; set; }

        /// <summary>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repeat_count")]
        public int? RepeatCount { get; set; }

        /// <summary>
        /// None when repeat_count==1 (no bucketing). Otherwise tracks bucketing lifecycle.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bucketing_status")]
        public global::ElevenLabs.BucketingStatus? BucketingStatus { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result_groups")]
        public global::System.Collections.Generic.IList<global::ElevenLabs.TestRunResultSummary>? ResultGroups { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("test_runs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::ElevenLabs.UnitTestRunResponseModel> TestRuns { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTestSuiteInvocationResponseModel" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="testRuns"></param>
        /// <param name="agentId"></param>
        /// <param name="branchId"></param>
        /// <param name="createdAt"></param>
        /// <param name="folderId"></param>
        /// <param name="repeatCount">
        /// Default Value: 1
        /// </param>
        /// <param name="bucketingStatus">
        /// None when repeat_count==1 (no bucketing). Otherwise tracks bucketing lifecycle.
        /// </param>
        /// <param name="resultGroups"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetTestSuiteInvocationResponseModel(
            string id,
            global::System.Collections.Generic.IList<global::ElevenLabs.UnitTestRunResponseModel> testRuns,
            string? agentId,
            string? branchId,
            int? createdAt,
            string? folderId,
            int? repeatCount,
            global::ElevenLabs.BucketingStatus? bucketingStatus,
            global::System.Collections.Generic.IList<global::ElevenLabs.TestRunResultSummary>? resultGroups)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.AgentId = agentId;
            this.BranchId = branchId;
            this.CreatedAt = createdAt;
            this.FolderId = folderId;
            this.RepeatCount = repeatCount;
            this.BucketingStatus = bucketingStatus;
            this.ResultGroups = resultGroups;
            this.TestRuns = testRuns ?? throw new global::System.ArgumentNullException(nameof(testRuns));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTestSuiteInvocationResponseModel" /> class.
        /// </summary>
        public GetTestSuiteInvocationResponseModel()
        {
        }

    }
}