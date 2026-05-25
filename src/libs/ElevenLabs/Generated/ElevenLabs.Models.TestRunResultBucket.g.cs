
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TestRunResultBucket
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("test_run_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> TestRunIds { get; set; }

        /// <summary>
        /// Short one-line title for this bucket
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        /// Short summary of why the test runs in this bucket passed or failed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Reason { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.TestRunStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.TestRunStatus Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TestRunResultBucket" /> class.
        /// </summary>
        /// <param name="testRunIds"></param>
        /// <param name="title">
        /// Short one-line title for this bucket
        /// </param>
        /// <param name="reason">
        /// Short summary of why the test runs in this bucket passed or failed
        /// </param>
        /// <param name="status"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TestRunResultBucket(
            global::System.Collections.Generic.IList<string> testRunIds,
            string title,
            string reason,
            global::ElevenLabs.TestRunStatus status)
        {
            this.TestRunIds = testRunIds ?? throw new global::System.ArgumentNullException(nameof(testRunIds));
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.Reason = reason ?? throw new global::System.ArgumentNullException(nameof(reason));
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TestRunResultBucket" /> class.
        /// </summary>
        public TestRunResultBucket()
        {
        }

    }
}