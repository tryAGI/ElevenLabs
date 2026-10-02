
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyDubAVideoOrAnAudioFileV1DubbingPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyDubAVideoOrAnAudioFileV1DubbingPostMode), TypeInfoPropertyName = "BodyDubAVideoOrAnAudioFileV1DubbingPostMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DeleteDubbingResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DoDubbingResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DubbingMediaMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DubbingMetadataPageResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.DubbingMetadataResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DubbingMetadataResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DubbingTranscript))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.DubbingTranscriptUtterance>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DubbingTranscriptUtterance))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DubbingTranscriptCharacter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DubbingTranscriptResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.DubbingTranscriptWord>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DubbingTranscriptWord))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.DubbingTranscriptCharacter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DubbingTranscriptsResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DubbingTranscriptsResponseModelTranscriptFormat), TypeInfoPropertyName = "DubbingTranscriptsResponseModelTranscriptFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ListDubsDubbingStatus), TypeInfoPropertyName = "ListDubsDubbingStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.ListDubsDubbingStatusesVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ListDubsDubbingStatusesVariant1Item), TypeInfoPropertyName = "ListDubsDubbingStatusesVariant1Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.ListDubsDubbingModelsVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ListDubsDubbingModelsVariant1Item), TypeInfoPropertyName = "ListDubsDubbingModelsVariant1Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.ListDubsCreationSourcesVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ListDubsCreationSourcesVariant1Item), TypeInfoPropertyName = "ListDubsCreationSourcesVariant1Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ListDubsFilterByCreator), TypeInfoPropertyName = "ListDubsFilterByCreator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ListDubsOrderBy), TypeInfoPropertyName = "ListDubsOrderBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ListDubsOrderDirection), TypeInfoPropertyName = "ListDubsOrderDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetDubbedTranscriptFileFormatType), TypeInfoPropertyName = "GetDubbedTranscriptFileFormatType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetDubbingTranscriptsFormatType), TypeInfoPropertyName = "GetDubbingTranscriptsFormatType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AnyOf<global::ElevenLabs.DubbingTranscriptResponseModel, string>), TypeInfoPropertyName = "AnyOfDubbingTranscriptResponseModelString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyDubAVideoOrAnAudioFileV1DubbingPostMode?), TypeInfoPropertyName = "NullableBodyDubAVideoOrAnAudioFileV1DubbingPostMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DubbingTranscriptsResponseModelTranscriptFormat?), TypeInfoPropertyName = "NullableDubbingTranscriptsResponseModelTranscriptFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ListDubsDubbingStatus?), TypeInfoPropertyName = "NullableListDubsDubbingStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ListDubsDubbingStatusesVariant1Item?), TypeInfoPropertyName = "NullableListDubsDubbingStatusesVariant1Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ListDubsDubbingModelsVariant1Item?), TypeInfoPropertyName = "NullableListDubsDubbingModelsVariant1Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ListDubsCreationSourcesVariant1Item?), TypeInfoPropertyName = "NullableListDubsCreationSourcesVariant1Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ListDubsFilterByCreator?), TypeInfoPropertyName = "NullableListDubsFilterByCreator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ListDubsOrderBy?), TypeInfoPropertyName = "NullableListDubsOrderBy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ListDubsOrderDirection?), TypeInfoPropertyName = "NullableListDubsOrderDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetDubbedTranscriptFileFormatType?), TypeInfoPropertyName = "NullableGetDubbedTranscriptFileFormatType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetDubbingTranscriptsFormatType?), TypeInfoPropertyName = "NullableGetDubbingTranscriptsFormatType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AnyOf<global::ElevenLabs.DubbingTranscriptResponseModel, string>?), TypeInfoPropertyName = "NullableAnyOfDubbingTranscriptResponseModelString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.DubbingMetadataResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.DubbingTranscriptUtterance>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.DubbingTranscriptWord>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.DubbingTranscriptCharacter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.ListDubsDubbingStatusesVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.ListDubsDubbingModelsVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.ListDubsCreationSourcesVariant1Item>))]
    internal sealed partial class Dubbing2SourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class Dubbing2SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static Dubbing2SourceGenerationContext Default { get; } = new(DefaultOptions);

        private Dubbing2SourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.DubbingTranscriptResponseModel, string>());
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
                    typeToConvert == typeof(global::ElevenLabs.BodyDubAVideoOrAnAudioFileV1DubbingPostMode)

                    || typeToConvert == typeof(global::ElevenLabs.BodyDubAVideoOrAnAudioFileV1DubbingPostMode?)

                    || typeToConvert == typeof(global::ElevenLabs.DubbingTranscriptsResponseModelTranscriptFormat)

                    || typeToConvert == typeof(global::ElevenLabs.DubbingTranscriptsResponseModelTranscriptFormat?)

                    || typeToConvert == typeof(global::ElevenLabs.ListDubsDubbingStatus)

                    || typeToConvert == typeof(global::ElevenLabs.ListDubsDubbingStatus?)

                    || typeToConvert == typeof(global::ElevenLabs.ListDubsDubbingStatusesVariant1Item)

                    || typeToConvert == typeof(global::ElevenLabs.ListDubsDubbingStatusesVariant1Item?)

                    || typeToConvert == typeof(global::ElevenLabs.ListDubsDubbingModelsVariant1Item)

                    || typeToConvert == typeof(global::ElevenLabs.ListDubsDubbingModelsVariant1Item?)

                    || typeToConvert == typeof(global::ElevenLabs.ListDubsCreationSourcesVariant1Item)

                    || typeToConvert == typeof(global::ElevenLabs.ListDubsCreationSourcesVariant1Item?)

                    || typeToConvert == typeof(global::ElevenLabs.ListDubsFilterByCreator)

                    || typeToConvert == typeof(global::ElevenLabs.ListDubsFilterByCreator?)

                    || typeToConvert == typeof(global::ElevenLabs.ListDubsOrderBy)

                    || typeToConvert == typeof(global::ElevenLabs.ListDubsOrderBy?)

                    || typeToConvert == typeof(global::ElevenLabs.ListDubsOrderDirection)

                    || typeToConvert == typeof(global::ElevenLabs.ListDubsOrderDirection?)

                    || typeToConvert == typeof(global::ElevenLabs.GetDubbedTranscriptFileFormatType)

                    || typeToConvert == typeof(global::ElevenLabs.GetDubbedTranscriptFileFormatType?)

                    || typeToConvert == typeof(global::ElevenLabs.GetDubbingTranscriptsFormatType)

                    || typeToConvert == typeof(global::ElevenLabs.GetDubbingTranscriptsFormatType?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::ElevenLabs.BodyDubAVideoOrAnAudioFileV1DubbingPostMode))
                {
                    return new global::ElevenLabs.JsonConverters.BodyDubAVideoOrAnAudioFileV1DubbingPostModeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.BodyDubAVideoOrAnAudioFileV1DubbingPostMode?))
                {
                    return new global::ElevenLabs.JsonConverters.BodyDubAVideoOrAnAudioFileV1DubbingPostModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.DubbingTranscriptsResponseModelTranscriptFormat))
                {
                    return new global::ElevenLabs.JsonConverters.DubbingTranscriptsResponseModelTranscriptFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.DubbingTranscriptsResponseModelTranscriptFormat?))
                {
                    return new global::ElevenLabs.JsonConverters.DubbingTranscriptsResponseModelTranscriptFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ListDubsDubbingStatus))
                {
                    return new global::ElevenLabs.JsonConverters.ListDubsDubbingStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ListDubsDubbingStatus?))
                {
                    return new global::ElevenLabs.JsonConverters.ListDubsDubbingStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ListDubsDubbingStatusesVariant1Item))
                {
                    return new global::ElevenLabs.JsonConverters.ListDubsDubbingStatusesVariant1ItemJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ListDubsDubbingStatusesVariant1Item?))
                {
                    return new global::ElevenLabs.JsonConverters.ListDubsDubbingStatusesVariant1ItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ListDubsDubbingModelsVariant1Item))
                {
                    return new global::ElevenLabs.JsonConverters.ListDubsDubbingModelsVariant1ItemJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ListDubsDubbingModelsVariant1Item?))
                {
                    return new global::ElevenLabs.JsonConverters.ListDubsDubbingModelsVariant1ItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ListDubsCreationSourcesVariant1Item))
                {
                    return new global::ElevenLabs.JsonConverters.ListDubsCreationSourcesVariant1ItemJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ListDubsCreationSourcesVariant1Item?))
                {
                    return new global::ElevenLabs.JsonConverters.ListDubsCreationSourcesVariant1ItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ListDubsFilterByCreator))
                {
                    return new global::ElevenLabs.JsonConverters.ListDubsFilterByCreatorJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ListDubsFilterByCreator?))
                {
                    return new global::ElevenLabs.JsonConverters.ListDubsFilterByCreatorNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ListDubsOrderBy))
                {
                    return new global::ElevenLabs.JsonConverters.ListDubsOrderByJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ListDubsOrderBy?))
                {
                    return new global::ElevenLabs.JsonConverters.ListDubsOrderByNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ListDubsOrderDirection))
                {
                    return new global::ElevenLabs.JsonConverters.ListDubsOrderDirectionJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ListDubsOrderDirection?))
                {
                    return new global::ElevenLabs.JsonConverters.ListDubsOrderDirectionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.GetDubbedTranscriptFileFormatType))
                {
                    return new global::ElevenLabs.JsonConverters.GetDubbedTranscriptFileFormatTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.GetDubbedTranscriptFileFormatType?))
                {
                    return new global::ElevenLabs.JsonConverters.GetDubbedTranscriptFileFormatTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.GetDubbingTranscriptsFormatType))
                {
                    return new global::ElevenLabs.JsonConverters.GetDubbingTranscriptsFormatTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.GetDubbingTranscriptsFormatType?))
                {
                    return new global::ElevenLabs.JsonConverters.GetDubbingTranscriptsFormatTypeNullableJsonConverter();
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
                    0 => new Dubbing2SourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),

                    1 => global::ElevenLabs.PartitionCoreSourceGenerationContext.TypeInfoResolver,
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}