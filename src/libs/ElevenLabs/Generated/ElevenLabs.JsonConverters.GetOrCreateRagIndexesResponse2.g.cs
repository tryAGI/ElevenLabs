#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace ElevenLabs.JsonConverters
{
    /// <inheritdoc />
    public class GetOrCreateRagIndexesResponse2JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ElevenLabs.GetOrCreateRagIndexesResponse2>
    {
        /// <inheritdoc />
        public override global::ElevenLabs.GetOrCreateRagIndexesResponse2 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.GetOrCreateRagIndexesResponseDiscriminator>(ref readerCopy, options);

            global::ElevenLabs.RAGIndexBatchSuccessfulResponseModel? success = default;
            if (discriminator?.Status == global::ElevenLabs.GetOrCreateRagIndexesResponseDiscriminatorStatus.Success)
            {
                success = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.RAGIndexBatchSuccessfulResponseModel>(ref reader, options);
            }
            global::ElevenLabs.BatchFailureResponseModel? failure = default;
            if (discriminator?.Status == global::ElevenLabs.GetOrCreateRagIndexesResponseDiscriminatorStatus.Failure)
            {
                failure = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.BatchFailureResponseModel>(ref reader, options);
            }

            var __value = new global::ElevenLabs.GetOrCreateRagIndexesResponse2(
                discriminator?.Status,
                success,

                failure
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::ElevenLabs.GetOrCreateRagIndexesResponse2 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsSuccess)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Success, typeof(global::ElevenLabs.RAGIndexBatchSuccessfulResponseModel), options);
            }
            else if (value.IsFailure)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Failure, typeof(global::ElevenLabs.BatchFailureResponseModel), options);
            }
        }
    }
}