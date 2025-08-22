
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SingleTestRunRequestModel
    {
        /// <summary>
        /// ID of the test to run
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("test_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TestId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SingleTestRunRequestModel" /> class.
        /// </summary>
        /// <param name="testId">
        /// ID of the test to run
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SingleTestRunRequestModel(
            string testId)
        {
            this.TestId = testId ?? throw new global::System.ArgumentNullException(nameof(testId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SingleTestRunRequestModel" /> class.
        /// </summary>
        public SingleTestRunRequestModel()
        {
        }
    }
}