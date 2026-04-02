#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace ElevenLabs.JsonConverters
{
    /// <inheritdoc />
    public class DataJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ElevenLabs.Data>
    {
        /// <inheritdoc />
        public override global::ElevenLabs.Data Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.KnowledgeBaseSummaryBatchSuccessfulResponseModelDataDiscriminator>(ref readerCopy, options);

            global::ElevenLabs.GetKnowledgeBaseSummaryURLResponseModel? url = default;
            if (discriminator?.Type == global::ElevenLabs.KnowledgeBaseSummaryBatchSuccessfulResponseModelDataDiscriminatorType.Url)
            {
                url = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.GetKnowledgeBaseSummaryURLResponseModel>(ref reader, options);
            }
            global::ElevenLabs.GetKnowledgeBaseSummaryFileResponseModel? file = default;
            if (discriminator?.Type == global::ElevenLabs.KnowledgeBaseSummaryBatchSuccessfulResponseModelDataDiscriminatorType.File)
            {
                file = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.GetKnowledgeBaseSummaryFileResponseModel>(ref reader, options);
            }
            global::ElevenLabs.GetKnowledgeBaseSummaryTextResponseModel? text = default;
            if (discriminator?.Type == global::ElevenLabs.KnowledgeBaseSummaryBatchSuccessfulResponseModelDataDiscriminatorType.Text)
            {
                text = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.GetKnowledgeBaseSummaryTextResponseModel>(ref reader, options);
            }
            global::ElevenLabs.GetKnowledgeBaseSummaryFolderResponseModel? folder = default;
            if (discriminator?.Type == global::ElevenLabs.KnowledgeBaseSummaryBatchSuccessfulResponseModelDataDiscriminatorType.Folder)
            {
                folder = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.GetKnowledgeBaseSummaryFolderResponseModel>(ref reader, options);
            }

            var __value = new global::ElevenLabs.Data(
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
            global::ElevenLabs.Data value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsUrl)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Url, typeof(global::ElevenLabs.GetKnowledgeBaseSummaryURLResponseModel), options);
            }
            else if (value.IsFile)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.File, typeof(global::ElevenLabs.GetKnowledgeBaseSummaryFileResponseModel), options);
            }
            else if (value.IsText)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Text, typeof(global::ElevenLabs.GetKnowledgeBaseSummaryTextResponseModel), options);
            }
            else if (value.IsFolder)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Folder, typeof(global::ElevenLabs.GetKnowledgeBaseSummaryFolderResponseModel), options);
            }
        }
    }
}