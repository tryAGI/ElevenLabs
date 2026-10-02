
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull
    )]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>), TypeInfoPropertyName = "IListString_System_Collections_Generic_IList_string")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string?>), TypeInfoPropertyName = "IListString_System_Collections_Generic_IList_string_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>), TypeInfoPropertyName = "ListString_System_Collections_Generic_List_string")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string?>), TypeInfoPropertyName = "ListString_System_Collections_Generic_List_string_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AdditionalFormatResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.ExportOptions>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ExportOptions), TypeInfoPropertyName = "ExportOptions2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodySpeechToTextV1SpeechToTextPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DetectedEntity))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DocxExportOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.EditedTranscript))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SegmentedJsonExportOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.PdfExportOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.TxtExportOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.HtmlExportOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SrtExportOptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ExportOptionsDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ExportOptionsDiscriminatorFormat), TypeInfoPropertyName = "ExportOptionsDiscriminatorFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.MultichannelSpeechToTextResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.SpeechToTextChunkResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SpeechToTextChunkResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SpeechToTextCharacterResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.SpeechToTextWordResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SpeechToTextWordResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.AdditionalFormatResponseModel?>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.DetectedEntity>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.EditedTranscriptVariant1))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.TranscriptEditError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SpeechToTextChunkResponseModelEditedTranscriptVariant1Discriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SpeechToTextChunkResponseModelEditedTranscriptVariant1DiscriminatorKind), TypeInfoPropertyName = "SpeechToTextChunkResponseModelEditedTranscriptVariant1DiscriminatorKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SpeechToTextWebhookResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SpeechToTextWordResponseModelType), TypeInfoPropertyName = "SpeechToTextWordResponseModelType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.SpeechToTextCharacterResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AnyOf<global::ElevenLabs.SpeechToTextChunkResponseModel, global::ElevenLabs.MultichannelSpeechToTextResponseModel, global::ElevenLabs.SpeechToTextWebhookResponseModel>), TypeInfoPropertyName = "AnyOfSpeechToTextChunkResponseModelMultichannelSpeechToTextResponseModelSpeechToTextWebhookResponseModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AnyOf<global::ElevenLabs.SpeechToTextChunkResponseModel, global::ElevenLabs.MultichannelSpeechToTextResponseModel>), TypeInfoPropertyName = "AnyOfSpeechToTextChunkResponseModelMultichannelSpeechToTextResponseModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ExportOptions?), TypeInfoPropertyName = "NullableExportOptions2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ExportOptionsDiscriminatorFormat?), TypeInfoPropertyName = "NullableExportOptionsDiscriminatorFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SpeechToTextChunkResponseModelEditedTranscriptVariant1DiscriminatorKind?), TypeInfoPropertyName = "NullableSpeechToTextChunkResponseModelEditedTranscriptVariant1DiscriminatorKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SpeechToTextWordResponseModelType?), TypeInfoPropertyName = "NullableSpeechToTextWordResponseModelType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AnyOf<global::ElevenLabs.SpeechToTextChunkResponseModel, global::ElevenLabs.MultichannelSpeechToTextResponseModel, global::ElevenLabs.SpeechToTextWebhookResponseModel>?), TypeInfoPropertyName = "NullableAnyOfSpeechToTextChunkResponseModelMultichannelSpeechToTextResponseModelSpeechToTextWebhookResponseModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AnyOf<global::ElevenLabs.SpeechToTextChunkResponseModel, global::ElevenLabs.MultichannelSpeechToTextResponseModel>?), TypeInfoPropertyName = "NullableAnyOfSpeechToTextChunkResponseModelMultichannelSpeechToTextResponseModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.ExportOptions>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.SpeechToTextChunkResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.SpeechToTextWordResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.AdditionalFormatResponseModel?>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.DetectedEntity>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.SpeechToTextCharacterResponseModel>))]
    internal sealed partial class SpeechToTextSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SpeechToTextSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SpeechToTextSourceGenerationContext Default { get; } = new(DefaultOptions);

        private SpeechToTextSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            global::ElevenLabs.PartitionCoreSourceGenerationContext.AddConverters(options);
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ExportOptionsJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.EditedTranscriptVariant1JsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.SpeechToTextChunkResponseModel, global::ElevenLabs.MultichannelSpeechToTextResponseModel, global::ElevenLabs.SpeechToTextWebhookResponseModel>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.SpeechToTextChunkResponseModel, global::ElevenLabs.MultichannelSpeechToTextResponseModel>());
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
                    typeToConvert == typeof(global::ElevenLabs.ExportOptionsDiscriminatorFormat)

                    || typeToConvert == typeof(global::ElevenLabs.ExportOptionsDiscriminatorFormat?)

                    || typeToConvert == typeof(global::ElevenLabs.SpeechToTextChunkResponseModelEditedTranscriptVariant1DiscriminatorKind)

                    || typeToConvert == typeof(global::ElevenLabs.SpeechToTextChunkResponseModelEditedTranscriptVariant1DiscriminatorKind?)

                    || typeToConvert == typeof(global::ElevenLabs.SpeechToTextWordResponseModelType)

                    || typeToConvert == typeof(global::ElevenLabs.SpeechToTextWordResponseModelType?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::ElevenLabs.ExportOptionsDiscriminatorFormat))
                {
                    return new global::ElevenLabs.JsonConverters.ExportOptionsDiscriminatorFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ExportOptionsDiscriminatorFormat?))
                {
                    return new global::ElevenLabs.JsonConverters.ExportOptionsDiscriminatorFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.SpeechToTextChunkResponseModelEditedTranscriptVariant1DiscriminatorKind))
                {
                    return new global::ElevenLabs.JsonConverters.SpeechToTextChunkResponseModelEditedTranscriptVariant1DiscriminatorKindJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.SpeechToTextChunkResponseModelEditedTranscriptVariant1DiscriminatorKind?))
                {
                    return new global::ElevenLabs.JsonConverters.SpeechToTextChunkResponseModelEditedTranscriptVariant1DiscriminatorKindNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.SpeechToTextWordResponseModelType))
                {
                    return new global::ElevenLabs.JsonConverters.SpeechToTextWordResponseModelTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.SpeechToTextWordResponseModelType?))
                {
                    return new global::ElevenLabs.JsonConverters.SpeechToTextWordResponseModelTypeNullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[2];

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
                    0 => new SpeechToTextSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),

                    1 => global::ElevenLabs.PartitionCoreSourceGenerationContext.TypeInfoResolver,
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}