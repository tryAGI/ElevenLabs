#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace ElevenLabs.JsonConverters
{
    /// <inheritdoc />
    public class ResultsItemJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ElevenLabs.ResultsItem>
    {
        /// <inheritdoc />
        public override global::ElevenLabs.ResultsItem Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");
            typeInfoResolver = global::ElevenLabs.AutoSDKJsonMetadataCachedResolver.Instance;


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.UpdateAnalysisItemAttachmentsResponseModelResultDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.UpdateAnalysisItemAttachmentsResponseModelResultDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.UpdateAnalysisItemAttachmentsResponseModelResultDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::ElevenLabs.BatchSuccessResponseModelAnalysisItemAttachmentResultData? success = default;
            if (discriminator?.Status == global::ElevenLabs.UpdateAnalysisItemAttachmentsResponseModelResultDiscriminatorStatus.Success)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.BatchSuccessResponseModelAnalysisItemAttachmentResultData), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.BatchSuccessResponseModelAnalysisItemAttachmentResultData> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.BatchSuccessResponseModelAnalysisItemAttachmentResultData)}");
                success = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.BatchFailureResponseModel? failure = default;
            if (discriminator?.Status == global::ElevenLabs.UpdateAnalysisItemAttachmentsResponseModelResultDiscriminatorStatus.Failure)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.BatchFailureResponseModel), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.BatchFailureResponseModel> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.BatchFailureResponseModel)}");
                failure = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::ElevenLabs.ResultsItem(
                discriminator?.Status,
                success,

                failure
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::ElevenLabs.ResultsItem value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");
            typeInfoResolver = global::ElevenLabs.AutoSDKJsonMetadataCachedResolver.Instance;

            if (value.IsSuccess)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.BatchSuccessResponseModelAnalysisItemAttachmentResultData), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.BatchSuccessResponseModelAnalysisItemAttachmentResultData?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.BatchSuccessResponseModelAnalysisItemAttachmentResultData).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickSuccess(), typeInfo);
            }
            else if (value.IsFailure)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.BatchFailureResponseModel), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.BatchFailureResponseModel?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.BatchFailureResponseModel).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PickFailure(), typeInfo);
            }
        }
    }
}