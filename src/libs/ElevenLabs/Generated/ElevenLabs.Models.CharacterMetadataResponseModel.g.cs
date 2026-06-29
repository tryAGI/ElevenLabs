
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CharacterMetadataResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sample_message")]
        public string? SampleMessage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gender")]
        public global::ElevenLabs.CharacterGender? Gender { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("age")]
        public global::ElevenLabs.CharacterAge? Age { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("accent")]
        public string? Accent { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CharacterMetadataResponseModel" /> class.
        /// </summary>
        /// <param name="description"></param>
        /// <param name="sampleMessage"></param>
        /// <param name="gender"></param>
        /// <param name="age"></param>
        /// <param name="accent"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CharacterMetadataResponseModel(
            string? description,
            string? sampleMessage,
            global::ElevenLabs.CharacterGender? gender,
            global::ElevenLabs.CharacterAge? age,
            string? accent)
        {
            this.Description = description;
            this.SampleMessage = sampleMessage;
            this.Gender = gender;
            this.Age = age;
            this.Accent = accent;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CharacterMetadataResponseModel" /> class.
        /// </summary>
        public CharacterMetadataResponseModel()
        {
        }

    }
}