
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyCreateDubbingLanguageTargetV1DubbingProjectProjectIdLanguagePost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.VoiceSettings))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyCreateDubbingProjectV1DubbingProjectPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AnyOf<global::ElevenLabs.BodyCreateDubbingProjectV1DubbingProjectPostModelId?, string>), TypeInfoPropertyName = "AnyOfBodyCreateDubbingProjectV1DubbingProjectPostModelIdString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyCreateDubbingProjectV1DubbingProjectPostModelId), TypeInfoPropertyName = "BodyCreateDubbingProjectV1DubbingProjectPostModelId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DubbingBulkSegmentUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.DubbingSegmentUpdateRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DubbingSegmentUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DubbingBulkSourceSegmentUpdateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.DubbingTranscriptSegment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DubbingTranscriptSegment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DubbingBulkTargetSegmentUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.DubbingTargetSegmentUpdateRequest>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DubbingTargetSegmentUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DubbingBulkTargetSegmentUpdateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.DubbingTargetTranscriptSegment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DubbingTargetTranscriptSegment))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DubbingError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DubbingLanguageListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.DubbingLanguageResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DubbingLanguageResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DubbingLanguageOutputs))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DubbingLanguageResponseStatus), TypeInfoPropertyName = "DubbingLanguageResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.VoicesNotPermittedWarning>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.VoicesNotPermittedWarning))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DubbingProjectListResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.DubbingProjectResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DubbingProjectResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DubbingProjectResponseStatus), TypeInfoPropertyName = "DubbingProjectResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DubbingSourceMediaInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DubbingRegenerateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DubbingSegmentCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DubbingSourceSegmentUpdateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DubbingSourceTranscriptResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DubbingTargetSegmentUpdateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DubbingTargetTranscriptResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DubbingTranscriptRevisionResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DubbingProjectListSortDirection), TypeInfoPropertyName = "DubbingProjectListSortDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AnyOf<global::ElevenLabs.BodyCreateDubbingProjectV1DubbingProjectPostModelId?, string>?), TypeInfoPropertyName = "NullableAnyOfBodyCreateDubbingProjectV1DubbingProjectPostModelIdString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyCreateDubbingProjectV1DubbingProjectPostModelId?), TypeInfoPropertyName = "NullableBodyCreateDubbingProjectV1DubbingProjectPostModelId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DubbingLanguageResponseStatus?), TypeInfoPropertyName = "NullableDubbingLanguageResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DubbingProjectResponseStatus?), TypeInfoPropertyName = "NullableDubbingProjectResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DubbingProjectListSortDirection?), TypeInfoPropertyName = "NullableDubbingProjectListSortDirection2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.DubbingTranscriptSegment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.DubbingTargetTranscriptSegment>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.DubbingLanguageResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.VoicesNotPermittedWarning>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.DubbingProjectResponse>))]
    internal sealed partial class DubbingSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DubbingSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static DubbingSourceGenerationContext Default { get; } = new(DefaultOptions);

        private DubbingSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.BodyCreateDubbingProjectV1DubbingProjectPostModelId?, string>());
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
                    typeToConvert == typeof(global::ElevenLabs.BodyCreateDubbingProjectV1DubbingProjectPostModelId)

                    || typeToConvert == typeof(global::ElevenLabs.BodyCreateDubbingProjectV1DubbingProjectPostModelId?)

                    || typeToConvert == typeof(global::ElevenLabs.DubbingLanguageResponseStatus)

                    || typeToConvert == typeof(global::ElevenLabs.DubbingLanguageResponseStatus?)

                    || typeToConvert == typeof(global::ElevenLabs.DubbingProjectResponseStatus)

                    || typeToConvert == typeof(global::ElevenLabs.DubbingProjectResponseStatus?)

                    || typeToConvert == typeof(global::ElevenLabs.DubbingProjectListSortDirection)

                    || typeToConvert == typeof(global::ElevenLabs.DubbingProjectListSortDirection?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::ElevenLabs.BodyCreateDubbingProjectV1DubbingProjectPostModelId))
                {
                    return new global::ElevenLabs.JsonConverters.BodyCreateDubbingProjectV1DubbingProjectPostModelIdJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.BodyCreateDubbingProjectV1DubbingProjectPostModelId?))
                {
                    return new global::ElevenLabs.JsonConverters.BodyCreateDubbingProjectV1DubbingProjectPostModelIdNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.DubbingLanguageResponseStatus))
                {
                    return new global::ElevenLabs.JsonConverters.DubbingLanguageResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.DubbingLanguageResponseStatus?))
                {
                    return new global::ElevenLabs.JsonConverters.DubbingLanguageResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.DubbingProjectResponseStatus))
                {
                    return new global::ElevenLabs.JsonConverters.DubbingProjectResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.DubbingProjectResponseStatus?))
                {
                    return new global::ElevenLabs.JsonConverters.DubbingProjectResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.DubbingProjectListSortDirection))
                {
                    return new global::ElevenLabs.JsonConverters.DubbingProjectListSortDirectionJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.DubbingProjectListSortDirection?))
                {
                    return new global::ElevenLabs.JsonConverters.DubbingProjectListSortDirectionNullableJsonConverter();
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
                    0 => new DubbingSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),

                    1 => global::ElevenLabs.PartitionCoreSourceGenerationContext.TypeInfoResolver,
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}