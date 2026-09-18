
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetPhoneNumbersPageResponseModel
    {
        /// <summary>
        /// The phone numbers on this page
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("phone_numbers")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::ElevenLabs.PhoneNumbersItem2> PhoneNumbers { get; set; }

        /// <summary>
        /// Pass this value as `cursor` to fetch the next page. Null when there are no more results.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_cursor")]
        public string? NextCursor { get; set; }

        /// <summary>
        /// Whether there are more results available<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_more")]
        public bool? HasMore { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetPhoneNumbersPageResponseModel" /> class.
        /// </summary>
        /// <param name="phoneNumbers">
        /// The phone numbers on this page
        /// </param>
        /// <param name="nextCursor">
        /// Pass this value as `cursor` to fetch the next page. Null when there are no more results.
        /// </param>
        /// <param name="hasMore">
        /// Whether there are more results available<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetPhoneNumbersPageResponseModel(
            global::System.Collections.Generic.IList<global::ElevenLabs.PhoneNumbersItem2> phoneNumbers,
            string? nextCursor,
            bool? hasMore)
        {
            this.PhoneNumbers = phoneNumbers ?? throw new global::System.ArgumentNullException(nameof(phoneNumbers));
            this.NextCursor = nextCursor;
            this.HasMore = hasMore;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetPhoneNumbersPageResponseModel" /> class.
        /// </summary>
        public GetPhoneNumbersPageResponseModel()
        {
        }

    }
}