
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyCreateANewVoiceFromVoicePreviewV1TextToVoiceCreateVoiceFromPreviewPost
    {
        /// <summary>
        /// Name to use for the created voice.<br/>
        /// Example: Little squeaky mouse
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VoiceName { get; set; }

        /// <summary>
        /// Description to use for the created voice.<br/>
        /// Example: A sassy little squeaky mouse
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voice_description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VoiceDescription { get; set; }

        /// <summary>
        /// The generated_voice_id to create, call POST /v1/voice-generation/generate-voice and fetch the generated_voice_id from the response header if don't have one yet.<br/>
        /// Example: 37HceQefKmEi3bGovXjL
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generated_voice_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string GeneratedVoiceId { get; set; }

        /// <summary>
        /// Optional, metadata to add to the created voice. Defaults to None.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("labels")]
        public global::System.Collections.Generic.Dictionary<string, string>? Labels { get; set; }

        /// <summary>
        /// List of voice ids that the user has played but not selected. Used for RLHF.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("played_not_selected_voice_ids")]
        public global::System.Collections.Generic.IList<string>? PlayedNotSelectedVoiceIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();


        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerContext.
        /// </summary>
        public string ToJson(
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                this.GetType(),
                jsonSerializerContext);
        }

        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public string ToJson(
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerContext.
        /// </summary>
        public static global::ElevenLabs.BodyCreateANewVoiceFromVoicePreviewV1TextToVoiceCreateVoiceFromPreviewPost? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::ElevenLabs.BodyCreateANewVoiceFromVoicePreviewV1TextToVoiceCreateVoiceFromPreviewPost),
                jsonSerializerContext) as global::ElevenLabs.BodyCreateANewVoiceFromVoicePreviewV1TextToVoiceCreateVoiceFromPreviewPost;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::ElevenLabs.BodyCreateANewVoiceFromVoicePreviewV1TextToVoiceCreateVoiceFromPreviewPost? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.BodyCreateANewVoiceFromVoicePreviewV1TextToVoiceCreateVoiceFromPreviewPost>(
                json,
                jsonSerializerOptions);
        }

    }
}