#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace ElevenLabs.JsonConverters
{
    /// <inheritdoc />
    public class RefreshUrlDocumentRouteResponseJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ElevenLabs.RefreshUrlDocumentRouteResponse>
    {
        /// <inheritdoc />
        public override global::ElevenLabs.RefreshUrlDocumentRouteResponse Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.RefreshUrlDocumentRouteResponseDiscriminator>(ref readerCopy, options);

            global::ElevenLabs.GetKnowledgeBaseURLResponseModel? url = default;
            if (discriminator?.Type == global::ElevenLabs.RefreshUrlDocumentRouteResponseDiscriminatorType.Url)
            {
                url = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.GetKnowledgeBaseURLResponseModel>(ref reader, options);
            }
            global::ElevenLabs.GetKnowledgeBaseFileResponseModel? file = default;
            if (discriminator?.Type == global::ElevenLabs.RefreshUrlDocumentRouteResponseDiscriminatorType.File)
            {
                file = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.GetKnowledgeBaseFileResponseModel>(ref reader, options);
            }
            global::ElevenLabs.GetKnowledgeBaseTextResponseModel? text = default;
            if (discriminator?.Type == global::ElevenLabs.RefreshUrlDocumentRouteResponseDiscriminatorType.Text)
            {
                text = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.GetKnowledgeBaseTextResponseModel>(ref reader, options);
            }
            global::ElevenLabs.GetKnowledgeBaseFolderResponseModel? folder = default;
            if (discriminator?.Type == global::ElevenLabs.RefreshUrlDocumentRouteResponseDiscriminatorType.Folder)
            {
                folder = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.GetKnowledgeBaseFolderResponseModel>(ref reader, options);
            }

            var __value = new global::ElevenLabs.RefreshUrlDocumentRouteResponse(
                discriminator?.Type,
                url,

                file,

                text,

                folder
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::ElevenLabs.RefreshUrlDocumentRouteResponse value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsUrl)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Url, typeof(global::ElevenLabs.GetKnowledgeBaseURLResponseModel), options);
            }
            else if (value.IsFile)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.File, typeof(global::ElevenLabs.GetKnowledgeBaseFileResponseModel), options);
            }
            else if (value.IsText)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Text, typeof(global::ElevenLabs.GetKnowledgeBaseTextResponseModel), options);
            }
            else if (value.IsFolder)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Folder, typeof(global::ElevenLabs.GetKnowledgeBaseFolderResponseModel), options);
            }
        }
    }
}