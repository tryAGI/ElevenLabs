
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ValidateUserVerificationCodeParams
    {
        /// <summary>
        /// Default Value: validate_user_verification_code
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("smb_tool_type")]
        public string? SmbToolType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ValidateUserVerificationCodeParams" /> class.
        /// </summary>
        /// <param name="smbToolType">
        /// Default Value: validate_user_verification_code
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ValidateUserVerificationCodeParams(
            string? smbToolType)
        {
            this.SmbToolType = smbToolType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ValidateUserVerificationCodeParams" /> class.
        /// </summary>
        public ValidateUserVerificationCodeParams()
        {
        }

    }
}