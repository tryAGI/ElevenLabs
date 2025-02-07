
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VoiceSharingModerationCheckResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("date_checked_unix")]
        public int? DateCheckedUnix { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name_value")]
        public string? NameValue { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name_check")]
        public bool? NameCheck { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description_value")]
        public string? DescriptionValue { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description_check")]
        public bool? DescriptionCheck { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sample_ids")]
        public global::System.Collections.Generic.IList<string>? SampleIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sample_checks")]
        public global::System.Collections.Generic.IList<double>? SampleChecks { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("captcha_ids")]
        public global::System.Collections.Generic.IList<string>? CaptchaIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("captcha_checks")]
        public global::System.Collections.Generic.IList<double>? CaptchaChecks { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceSharingModerationCheckResponseModel" /> class.
        /// </summary>
        /// <param name="dateCheckedUnix"></param>
        /// <param name="nameValue"></param>
        /// <param name="nameCheck"></param>
        /// <param name="descriptionValue"></param>
        /// <param name="descriptionCheck"></param>
        /// <param name="sampleIds"></param>
        /// <param name="sampleChecks"></param>
        /// <param name="captchaIds"></param>
        /// <param name="captchaChecks"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VoiceSharingModerationCheckResponseModel(
            int? dateCheckedUnix,
            string? nameValue,
            bool? nameCheck,
            string? descriptionValue,
            bool? descriptionCheck,
            global::System.Collections.Generic.IList<string>? sampleIds,
            global::System.Collections.Generic.IList<double>? sampleChecks,
            global::System.Collections.Generic.IList<string>? captchaIds,
            global::System.Collections.Generic.IList<double>? captchaChecks)
        {
            this.DateCheckedUnix = dateCheckedUnix;
            this.NameValue = nameValue;
            this.NameCheck = nameCheck;
            this.DescriptionValue = descriptionValue;
            this.DescriptionCheck = descriptionCheck;
            this.SampleIds = sampleIds;
            this.SampleChecks = sampleChecks;
            this.CaptchaIds = captchaIds;
            this.CaptchaChecks = captchaChecks;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceSharingModerationCheckResponseModel" /> class.
        /// </summary>
        public VoiceSharingModerationCheckResponseModel()
        {
        }
    }
}