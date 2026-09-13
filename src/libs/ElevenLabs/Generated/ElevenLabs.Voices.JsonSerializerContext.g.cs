
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AddVoiceIVCResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AddVoiceResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<byte[]>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyAddSharedVoiceV1VoicesAddPublicUserIdVoiceIdPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyAddVoiceV1VoicesAddPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AnyOf<global::System.Collections.Generic.Dictionary<string, string>, string, object>), TypeInfoPropertyName = "AnyOfDictionaryStringStringStringObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyEditVoiceV1VoicesVoiceIdEditPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyGetSimilarLibraryVoicesV1SimilarVoicesPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.VoiceSettingsResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DeleteVoiceResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.EditVoiceResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.EditVoiceSettingsResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.FineTuningResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.FineTuningResponseModelState2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.FineTuningResponseModelState2), TypeInfoPropertyName = "FineTuningResponseModelState22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.VerificationAttemptResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.VerificationAttemptResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ManualVerificationResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetLibraryVoicesResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.LibraryVoiceResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.LibraryVoiceResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetVoiceAccentsResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.VoiceAccentResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.VoiceAccentResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetVoicesResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.VoiceResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.VoiceResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetVoicesV2ResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.HTTPValidationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.ValidationError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ValidationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.LibraryVoiceResponseModelCategory), TypeInfoPropertyName = "LibraryVoiceResponseModelCategory2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.VerifiedVoiceLanguageResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.VerifiedVoiceLanguageResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ManualVerificationFileResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.ManualVerificationFileResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ReaderResourceResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ReaderResourceResponseModelResourceType), TypeInfoPropertyName = "ReaderResourceResponseModelResourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.RecordingResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ReplicateVoiceToIsolatedEnvironmentRequestModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ReplicateVoiceToIsolatedEnvironmentResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SampleResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SpeakerSeparationResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SpeakerResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.UtteranceResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.UtteranceResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SpeakerSeparationResponseModelStatus), TypeInfoPropertyName = "SpeakerSeparationResponseModelStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.SpeakerResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.AnyOf<string, int?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AnyOf<string, int?>), TypeInfoPropertyName = "AnyOfStringInt322")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.SampleResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.VoiceResponseModelCategory), TypeInfoPropertyName = "VoiceResponseModelCategory2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.VoiceSharingResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.VoiceResponseModelSafetyControl), TypeInfoPropertyName = "VoiceResponseModelSafetyControl2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.VoiceVerificationResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.VoiceResponseModelRecordingQuality), TypeInfoPropertyName = "VoiceResponseModelRecordingQuality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.VoiceResponseModelLabellingStatus), TypeInfoPropertyName = "VoiceResponseModelLabellingStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.VoiceSharingModerationCheckResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.VoiceSharingResponseModelStatus), TypeInfoPropertyName = "VoiceSharingResponseModelStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.VoiceSharingResponseModelCategory), TypeInfoPropertyName = "VoiceSharingResponseModelCategory2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.VoiceSharingResponseModelReviewStatus), TypeInfoPropertyName = "VoiceSharingResponseModelReviewStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.ReaderResourceResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AnyOf<global::System.Collections.Generic.Dictionary<string, string>, string, object>?), TypeInfoPropertyName = "NullableAnyOfDictionaryStringStringStringObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.FineTuningResponseModelState2?), TypeInfoPropertyName = "NullableFineTuningResponseModelState22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.LibraryVoiceResponseModelCategory?), TypeInfoPropertyName = "NullableLibraryVoiceResponseModelCategory2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ReaderResourceResponseModelResourceType?), TypeInfoPropertyName = "NullableReaderResourceResponseModelResourceType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SpeakerSeparationResponseModelStatus?), TypeInfoPropertyName = "NullableSpeakerSeparationResponseModelStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AnyOf<string, int?>?), TypeInfoPropertyName = "NullableAnyOfStringInt322")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.VoiceResponseModelCategory?), TypeInfoPropertyName = "NullableVoiceResponseModelCategory2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.VoiceResponseModelSafetyControl?), TypeInfoPropertyName = "NullableVoiceResponseModelSafetyControl2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.VoiceResponseModelRecordingQuality?), TypeInfoPropertyName = "NullableVoiceResponseModelRecordingQuality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.VoiceResponseModelLabellingStatus?), TypeInfoPropertyName = "NullableVoiceResponseModelLabellingStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.VoiceSharingResponseModelStatus?), TypeInfoPropertyName = "NullableVoiceSharingResponseModelStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.VoiceSharingResponseModelCategory?), TypeInfoPropertyName = "NullableVoiceSharingResponseModelCategory2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.VoiceSharingResponseModelReviewStatus?), TypeInfoPropertyName = "NullableVoiceSharingResponseModelReviewStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<byte[]>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.VerificationAttemptResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.LibraryVoiceResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.VoiceAccentResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.VoiceResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.ValidationError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.VerifiedVoiceLanguageResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.ManualVerificationFileResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.UtteranceResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.AnyOf<string, int?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.SampleResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.ReaderResourceResponseModel>))]
    internal sealed partial class VoicesSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class VoicesSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static VoicesSourceGenerationContext Default { get; } = new(DefaultOptions);

        private VoicesSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
            : base(options)
        {
        }

        /// <inheritdoc />
        protected override global::System.Text.Json.JsonSerializerOptions? GeneratedSerializerOptions => DefaultOptions;

        /// <inheritdoc />
        public override global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(global::System.Type type)
        {
            return Resolver.GetTypeInfo(type, Options);
        }

        /// <summary>
        /// Adds this package's converters to <paramref name="options"/>.
        /// </summary>
        /// <remarks>
        /// A converter has to be on the options a chained resolver builds its JsonTypeInfo against,
        /// and a context resolves types from every package below it. Each package contributes only
        /// what it owns and calls down the chain for the rest, so the family's converter table is
        /// written once rather than copied into all of them.
        /// </remarks>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options)
        {
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<double?, int?>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<double?, int?>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, int?, double?, bool?, object>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.Dictionary<string, string>, string, object>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.Dictionary<string, string>, string, object>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, object, object>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, object>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, object>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<bool?, string>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, int?, double?, global::System.DateTime?, bool?, object>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, int?, double?, bool?, global::System.Collections.Generic.IList<object>, object, object>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<int?, string>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, int?, double?, bool?, object>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, bool?, double?>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<int?, string>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, int?>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, int?, double?, bool?, global::System.DateTime?, object>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<int?, string, object>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<int?, string, object>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.UnixTimestampJsonConverter());
            options.Converters.Add(new LazyEnumJsonConverterFactory());
        }

        private static global::System.Text.Json.JsonSerializerOptions CreateDefaultOptions()
        {
            var options = new global::System.Text.Json.JsonSerializerOptions
            {
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                TypeInfoResolver = Resolver,
            };
            AddConverters(options);

            return options;
        }


        private sealed class LazyEnumJsonConverterFactory : global::System.Text.Json.Serialization.JsonConverterFactory
        {
            public override bool CanConvert(global::System.Type typeToConvert)
            {
                return
                    typeToConvert == typeof(global::ElevenLabs.FineTuningResponseModelState2)

                    || typeToConvert == typeof(global::ElevenLabs.FineTuningResponseModelState2?)

                    || typeToConvert == typeof(global::ElevenLabs.LibraryVoiceResponseModelCategory)

                    || typeToConvert == typeof(global::ElevenLabs.LibraryVoiceResponseModelCategory?)

                    || typeToConvert == typeof(global::ElevenLabs.ReaderResourceResponseModelResourceType)

                    || typeToConvert == typeof(global::ElevenLabs.ReaderResourceResponseModelResourceType?)

                    || typeToConvert == typeof(global::ElevenLabs.SpeakerSeparationResponseModelStatus)

                    || typeToConvert == typeof(global::ElevenLabs.SpeakerSeparationResponseModelStatus?)

                    || typeToConvert == typeof(global::ElevenLabs.VoiceResponseModelCategory)

                    || typeToConvert == typeof(global::ElevenLabs.VoiceResponseModelCategory?)

                    || typeToConvert == typeof(global::ElevenLabs.VoiceResponseModelSafetyControl)

                    || typeToConvert == typeof(global::ElevenLabs.VoiceResponseModelSafetyControl?)

                    || typeToConvert == typeof(global::ElevenLabs.VoiceResponseModelRecordingQuality)

                    || typeToConvert == typeof(global::ElevenLabs.VoiceResponseModelRecordingQuality?)

                    || typeToConvert == typeof(global::ElevenLabs.VoiceResponseModelLabellingStatus)

                    || typeToConvert == typeof(global::ElevenLabs.VoiceResponseModelLabellingStatus?)

                    || typeToConvert == typeof(global::ElevenLabs.VoiceSharingResponseModelStatus)

                    || typeToConvert == typeof(global::ElevenLabs.VoiceSharingResponseModelStatus?)

                    || typeToConvert == typeof(global::ElevenLabs.VoiceSharingResponseModelCategory)

                    || typeToConvert == typeof(global::ElevenLabs.VoiceSharingResponseModelCategory?)

                    || typeToConvert == typeof(global::ElevenLabs.VoiceSharingResponseModelReviewStatus)

                    || typeToConvert == typeof(global::ElevenLabs.VoiceSharingResponseModelReviewStatus?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::ElevenLabs.FineTuningResponseModelState2))
                {
                    return new global::ElevenLabs.JsonConverters.FineTuningResponseModelState2JsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.FineTuningResponseModelState2?))
                {
                    return new global::ElevenLabs.JsonConverters.FineTuningResponseModelState2NullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.LibraryVoiceResponseModelCategory))
                {
                    return new global::ElevenLabs.JsonConverters.LibraryVoiceResponseModelCategoryJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.LibraryVoiceResponseModelCategory?))
                {
                    return new global::ElevenLabs.JsonConverters.LibraryVoiceResponseModelCategoryNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ReaderResourceResponseModelResourceType))
                {
                    return new global::ElevenLabs.JsonConverters.ReaderResourceResponseModelResourceTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ReaderResourceResponseModelResourceType?))
                {
                    return new global::ElevenLabs.JsonConverters.ReaderResourceResponseModelResourceTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.SpeakerSeparationResponseModelStatus))
                {
                    return new global::ElevenLabs.JsonConverters.SpeakerSeparationResponseModelStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.SpeakerSeparationResponseModelStatus?))
                {
                    return new global::ElevenLabs.JsonConverters.SpeakerSeparationResponseModelStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.VoiceResponseModelCategory))
                {
                    return new global::ElevenLabs.JsonConverters.VoiceResponseModelCategoryJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.VoiceResponseModelCategory?))
                {
                    return new global::ElevenLabs.JsonConverters.VoiceResponseModelCategoryNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.VoiceResponseModelSafetyControl))
                {
                    return new global::ElevenLabs.JsonConverters.VoiceResponseModelSafetyControlJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.VoiceResponseModelSafetyControl?))
                {
                    return new global::ElevenLabs.JsonConverters.VoiceResponseModelSafetyControlNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.VoiceResponseModelRecordingQuality))
                {
                    return new global::ElevenLabs.JsonConverters.VoiceResponseModelRecordingQualityJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.VoiceResponseModelRecordingQuality?))
                {
                    return new global::ElevenLabs.JsonConverters.VoiceResponseModelRecordingQualityNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.VoiceResponseModelLabellingStatus))
                {
                    return new global::ElevenLabs.JsonConverters.VoiceResponseModelLabellingStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.VoiceResponseModelLabellingStatus?))
                {
                    return new global::ElevenLabs.JsonConverters.VoiceResponseModelLabellingStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.VoiceSharingResponseModelStatus))
                {
                    return new global::ElevenLabs.JsonConverters.VoiceSharingResponseModelStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.VoiceSharingResponseModelStatus?))
                {
                    return new global::ElevenLabs.JsonConverters.VoiceSharingResponseModelStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.VoiceSharingResponseModelCategory))
                {
                    return new global::ElevenLabs.JsonConverters.VoiceSharingResponseModelCategoryJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.VoiceSharingResponseModelCategory?))
                {
                    return new global::ElevenLabs.JsonConverters.VoiceSharingResponseModelCategoryNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.VoiceSharingResponseModelReviewStatus))
                {
                    return new global::ElevenLabs.JsonConverters.VoiceSharingResponseModelReviewStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.VoiceSharingResponseModelReviewStatus?))
                {
                    return new global::ElevenLabs.JsonConverters.VoiceSharingResponseModelReviewStatusNullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[1];

            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                for (var index = 0; index < _resolvers.Length; index++)
                {
                    var typeInfo = GetResolver(index).GetTypeInfo(type, options);
                    if (typeInfo is not null)
                    {
                        return typeInfo;
                    }
                }

                return null;
            }

            private global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver GetResolver(int index)
            {
                var resolver = global::System.Threading.Volatile.Read(ref _resolvers[index]);
                if (resolver is not null)
                {
                    return resolver;
                }

                lock (_gate)
                {
                    return _resolvers[index] ??= CreateResolver(index);
                }
            }

            private static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver CreateResolver(int index)
            {
                return index switch
                {
                    0 => new VoicesSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}