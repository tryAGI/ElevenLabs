
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// A Voice Library voice the uploaded audio matched, offered in place of the clone.
    /// </summary>
    public sealed partial class LibraryVoiceMatchResponseModel
    {
        /// <summary>
        /// The ID of the matched Voice Library voice.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("library_voice_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string LibraryVoiceId { get; set; }

        /// <summary>
        /// The public owner ID of the Voice Library voice. Pass it with library_voice_id to POST /v1/voices/add/{public_user_id}/{voice_id} to add the voice.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("public_owner_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PublicOwnerId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LibraryVoiceMatchResponseModel" /> class.
        /// </summary>
        /// <param name="libraryVoiceId">
        /// The ID of the matched Voice Library voice.
        /// </param>
        /// <param name="publicOwnerId">
        /// The public owner ID of the Voice Library voice. Pass it with library_voice_id to POST /v1/voices/add/{public_user_id}/{voice_id} to add the voice.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LibraryVoiceMatchResponseModel(
            string libraryVoiceId,
            string publicOwnerId)
        {
            this.LibraryVoiceId = libraryVoiceId ?? throw new global::System.ArgumentNullException(nameof(libraryVoiceId));
            this.PublicOwnerId = publicOwnerId ?? throw new global::System.ArgumentNullException(nameof(publicOwnerId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LibraryVoiceMatchResponseModel" /> class.
        /// </summary>
        public LibraryVoiceMatchResponseModel()
        {
        }

    }
}