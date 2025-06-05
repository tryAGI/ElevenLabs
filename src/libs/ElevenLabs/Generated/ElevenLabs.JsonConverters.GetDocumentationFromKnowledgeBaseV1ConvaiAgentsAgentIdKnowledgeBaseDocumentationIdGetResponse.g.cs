#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace ElevenLabs.JsonConverters
{
    /// <inheritdoc />
    public class GetDocumentationFromKnowledgeBaseV1ConvaiAgentsAgentIdKnowledgeBaseDocumentationIdGetResponseJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ElevenLabs.GetDocumentationFromKnowledgeBaseV1ConvaiAgentsAgentIdKnowledgeBaseDocumentationIdGetResponse>
    {
        /// <inheritdoc />
        public override global::ElevenLabs.GetDocumentationFromKnowledgeBaseV1ConvaiAgentsAgentIdKnowledgeBaseDocumentationIdGetResponse Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.GetDocumentationFromKnowledgeBaseV1ConvaiAgentsAgentIdKnowledgeBaseDocumentationIdGetResponseDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.GetDocumentationFromKnowledgeBaseV1ConvaiAgentsAgentIdKnowledgeBaseDocumentationIdGetResponseDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.GetDocumentationFromKnowledgeBaseV1ConvaiAgentsAgentIdKnowledgeBaseDocumentationIdGetResponseDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::ElevenLabs.GetKnowledgeBaseURLResponseModel? url = default;
            if (discriminator?.Type == global::ElevenLabs.GetDocumentationFromKnowledgeBaseV1ConvaiAgentsAgentIdKnowledgeBaseDocumentationIdGetResponseDiscriminatorType.Url)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.GetKnowledgeBaseURLResponseModel), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.GetKnowledgeBaseURLResponseModel> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.GetKnowledgeBaseURLResponseModel)}");
                url = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.GetKnowledgeBaseFileResponseModel? file = default;
            if (discriminator?.Type == global::ElevenLabs.GetDocumentationFromKnowledgeBaseV1ConvaiAgentsAgentIdKnowledgeBaseDocumentationIdGetResponseDiscriminatorType.File)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.GetKnowledgeBaseFileResponseModel), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.GetKnowledgeBaseFileResponseModel> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.GetKnowledgeBaseFileResponseModel)}");
                file = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.GetKnowledgeBaseTextResponseModel? text = default;
            if (discriminator?.Type == global::ElevenLabs.GetDocumentationFromKnowledgeBaseV1ConvaiAgentsAgentIdKnowledgeBaseDocumentationIdGetResponseDiscriminatorType.Text)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.GetKnowledgeBaseTextResponseModel), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.GetKnowledgeBaseTextResponseModel> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.GetKnowledgeBaseTextResponseModel)}");
                text = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var result = new global::ElevenLabs.GetDocumentationFromKnowledgeBaseV1ConvaiAgentsAgentIdKnowledgeBaseDocumentationIdGetResponse(
                discriminator?.Type,
                url,
                file,
                text
                );

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::ElevenLabs.GetDocumentationFromKnowledgeBaseV1ConvaiAgentsAgentIdKnowledgeBaseDocumentationIdGetResponse value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsUrl)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.GetKnowledgeBaseURLResponseModel), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.GetKnowledgeBaseURLResponseModel?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.GetKnowledgeBaseURLResponseModel).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Url, typeInfo);
            }
            else if (value.IsFile)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.GetKnowledgeBaseFileResponseModel), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.GetKnowledgeBaseFileResponseModel?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.GetKnowledgeBaseFileResponseModel).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.File, typeInfo);
            }
            else if (value.IsText)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.GetKnowledgeBaseTextResponseModel), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.GetKnowledgeBaseTextResponseModel?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.GetKnowledgeBaseTextResponseModel).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Text, typeInfo);
            }
        }
    }
}