
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyComposeMusicWithADetailedResponseV1MusicDetailedPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.MusicGenerationMode), TypeInfoPropertyName = "MusicGenerationMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyComposeMusicWithADetailedResponseV1MusicDetailedPostModelStylePrefix), TypeInfoPropertyName = "BodyComposeMusicWithADetailedResponseV1MusicDetailedPostModelStylePrefix2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyComposeMusicV1MusicPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyGenerateCompositionPlanV1MusicPlanPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyStemSeparationV1MusicStemSeparationPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyStemSeparationV1MusicStemSeparationPostStemVariationId), TypeInfoPropertyName = "BodyStemSeparationV1MusicStemSeparationPostStemVariationId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyStreamComposedMusicV1MusicStreamPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyStreamComposedMusicWithADetailedResponseV1MusicDetailedStreamPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyUploadMusicV1MusicUploadPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.WordTimestamp>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WordTimestamp))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.MusicUploadResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GenerateOutputFormat), TypeInfoPropertyName = "GenerateOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ComposeDetailedOutputFormat), TypeInfoPropertyName = "ComposeDetailedOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ComposeDetailedStreamOutputFormat), TypeInfoPropertyName = "ComposeDetailedStreamOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.StreamComposeOutputFormat), TypeInfoPropertyName = "StreamComposeOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.MusicGenerationMode?), TypeInfoPropertyName = "NullableMusicGenerationMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyComposeMusicWithADetailedResponseV1MusicDetailedPostModelStylePrefix?), TypeInfoPropertyName = "NullableBodyComposeMusicWithADetailedResponseV1MusicDetailedPostModelStylePrefix2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyStemSeparationV1MusicStemSeparationPostStemVariationId?), TypeInfoPropertyName = "NullableBodyStemSeparationV1MusicStemSeparationPostStemVariationId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GenerateOutputFormat?), TypeInfoPropertyName = "NullableGenerateOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ComposeDetailedOutputFormat?), TypeInfoPropertyName = "NullableComposeDetailedOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ComposeDetailedStreamOutputFormat?), TypeInfoPropertyName = "NullableComposeDetailedStreamOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.StreamComposeOutputFormat?), TypeInfoPropertyName = "NullableStreamComposeOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.WordTimestamp>))]
    internal sealed partial class MusicGenerationSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class MusicGenerationSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static MusicGenerationSourceGenerationContext Default { get; } = new(DefaultOptions);

        private MusicGenerationSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::ElevenLabs.BodyComposeMusicWithADetailedResponseV1MusicDetailedPostModelStylePrefix)

                    || typeToConvert == typeof(global::ElevenLabs.BodyComposeMusicWithADetailedResponseV1MusicDetailedPostModelStylePrefix?)

                    || typeToConvert == typeof(global::ElevenLabs.BodyStemSeparationV1MusicStemSeparationPostStemVariationId)

                    || typeToConvert == typeof(global::ElevenLabs.BodyStemSeparationV1MusicStemSeparationPostStemVariationId?)

                    || typeToConvert == typeof(global::ElevenLabs.MusicGenerationMode)

                    || typeToConvert == typeof(global::ElevenLabs.MusicGenerationMode?)

                    || typeToConvert == typeof(global::ElevenLabs.GenerateOutputFormat)

                    || typeToConvert == typeof(global::ElevenLabs.GenerateOutputFormat?)

                    || typeToConvert == typeof(global::ElevenLabs.ComposeDetailedOutputFormat)

                    || typeToConvert == typeof(global::ElevenLabs.ComposeDetailedOutputFormat?)

                    || typeToConvert == typeof(global::ElevenLabs.ComposeDetailedStreamOutputFormat)

                    || typeToConvert == typeof(global::ElevenLabs.ComposeDetailedStreamOutputFormat?)

                    || typeToConvert == typeof(global::ElevenLabs.StreamComposeOutputFormat)

                    || typeToConvert == typeof(global::ElevenLabs.StreamComposeOutputFormat?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::ElevenLabs.BodyComposeMusicWithADetailedResponseV1MusicDetailedPostModelStylePrefix))
                {
                    return new global::ElevenLabs.JsonConverters.BodyComposeMusicWithADetailedResponseV1MusicDetailedPostModelStylePrefixJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.BodyComposeMusicWithADetailedResponseV1MusicDetailedPostModelStylePrefix?))
                {
                    return new global::ElevenLabs.JsonConverters.BodyComposeMusicWithADetailedResponseV1MusicDetailedPostModelStylePrefixNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.BodyStemSeparationV1MusicStemSeparationPostStemVariationId))
                {
                    return new global::ElevenLabs.JsonConverters.BodyStemSeparationV1MusicStemSeparationPostStemVariationIdJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.BodyStemSeparationV1MusicStemSeparationPostStemVariationId?))
                {
                    return new global::ElevenLabs.JsonConverters.BodyStemSeparationV1MusicStemSeparationPostStemVariationIdNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.MusicGenerationMode))
                {
                    return new global::ElevenLabs.JsonConverters.MusicGenerationModeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.MusicGenerationMode?))
                {
                    return new global::ElevenLabs.JsonConverters.MusicGenerationModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.GenerateOutputFormat))
                {
                    return new global::ElevenLabs.JsonConverters.GenerateOutputFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.GenerateOutputFormat?))
                {
                    return new global::ElevenLabs.JsonConverters.GenerateOutputFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ComposeDetailedOutputFormat))
                {
                    return new global::ElevenLabs.JsonConverters.ComposeDetailedOutputFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ComposeDetailedOutputFormat?))
                {
                    return new global::ElevenLabs.JsonConverters.ComposeDetailedOutputFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ComposeDetailedStreamOutputFormat))
                {
                    return new global::ElevenLabs.JsonConverters.ComposeDetailedStreamOutputFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ComposeDetailedStreamOutputFormat?))
                {
                    return new global::ElevenLabs.JsonConverters.ComposeDetailedStreamOutputFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.StreamComposeOutputFormat))
                {
                    return new global::ElevenLabs.JsonConverters.StreamComposeOutputFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.StreamComposeOutputFormat?))
                {
                    return new global::ElevenLabs.JsonConverters.StreamComposeOutputFormatNullableJsonConverter();
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
                    0 => new MusicGenerationSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),

                    1 => global::ElevenLabs.PartitionCoreSourceGenerationContext.TypeInfoResolver,
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}