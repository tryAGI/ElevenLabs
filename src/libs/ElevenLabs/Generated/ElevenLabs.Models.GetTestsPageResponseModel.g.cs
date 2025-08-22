
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetTestsPageResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tests")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::ElevenLabs.UnitTestSummaryResponseModel> Tests { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_cursor")]
        public string? NextCursor { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_more")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasMore { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTestsPageResponseModel" /> class.
        /// </summary>
        /// <param name="tests"></param>
        /// <param name="nextCursor"></param>
        /// <param name="hasMore"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetTestsPageResponseModel(
            global::System.Collections.Generic.IList<global::ElevenLabs.UnitTestSummaryResponseModel> tests,
            bool hasMore,
            string? nextCursor)
        {
            this.Tests = tests ?? throw new global::System.ArgumentNullException(nameof(tests));
            this.HasMore = hasMore;
            this.NextCursor = nextCursor;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetTestsPageResponseModel" /> class.
        /// </summary>
        public GetTestsPageResponseModel()
        {
        }
    }
}