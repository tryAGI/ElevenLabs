
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodySpeechToSpeechStreamingV1SpeechToSpeechVoiceIdStreamPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodySpeechToSpeechStreamingV1SpeechToSpeechVoiceIdStreamPostFileFormat), TypeInfoPropertyName = "BodySpeechToSpeechStreamingV1SpeechToSpeechVoiceIdStreamPostFileFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodySpeechToSpeechV1SpeechToSpeechVoiceIdPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodySpeechToSpeechV1SpeechToSpeechVoiceIdPostFileFormat), TypeInfoPropertyName = "BodySpeechToSpeechV1SpeechToSpeechVoiceIdPostFileFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SpeechToSpeechFullOutputFormat), TypeInfoPropertyName = "SpeechToSpeechFullOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SpeechToSpeechStreamOutputFormat), TypeInfoPropertyName = "SpeechToSpeechStreamOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodySpeechToSpeechStreamingV1SpeechToSpeechVoiceIdStreamPostFileFormat?), TypeInfoPropertyName = "NullableBodySpeechToSpeechStreamingV1SpeechToSpeechVoiceIdStreamPostFileFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodySpeechToSpeechV1SpeechToSpeechVoiceIdPostFileFormat?), TypeInfoPropertyName = "NullableBodySpeechToSpeechV1SpeechToSpeechVoiceIdPostFileFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SpeechToSpeechFullOutputFormat?), TypeInfoPropertyName = "NullableSpeechToSpeechFullOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SpeechToSpeechStreamOutputFormat?), TypeInfoPropertyName = "NullableSpeechToSpeechStreamOutputFormat2")]
    internal sealed partial class PartitionOrphan7SourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PartitionOrphan7SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static PartitionOrphan7SourceGenerationContext Default { get; } = new(DefaultOptions);

        private PartitionOrphan7SourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::ElevenLabs.BodySpeechToSpeechStreamingV1SpeechToSpeechVoiceIdStreamPostFileFormat)

                    || typeToConvert == typeof(global::ElevenLabs.BodySpeechToSpeechStreamingV1SpeechToSpeechVoiceIdStreamPostFileFormat?)

                    || typeToConvert == typeof(global::ElevenLabs.BodySpeechToSpeechV1SpeechToSpeechVoiceIdPostFileFormat)

                    || typeToConvert == typeof(global::ElevenLabs.BodySpeechToSpeechV1SpeechToSpeechVoiceIdPostFileFormat?)

                    || typeToConvert == typeof(global::ElevenLabs.SpeechToSpeechFullOutputFormat)

                    || typeToConvert == typeof(global::ElevenLabs.SpeechToSpeechFullOutputFormat?)

                    || typeToConvert == typeof(global::ElevenLabs.SpeechToSpeechStreamOutputFormat)

                    || typeToConvert == typeof(global::ElevenLabs.SpeechToSpeechStreamOutputFormat?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::ElevenLabs.BodySpeechToSpeechStreamingV1SpeechToSpeechVoiceIdStreamPostFileFormat))
                {
                    return new global::ElevenLabs.JsonConverters.BodySpeechToSpeechStreamingV1SpeechToSpeechVoiceIdStreamPostFileFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.BodySpeechToSpeechStreamingV1SpeechToSpeechVoiceIdStreamPostFileFormat?))
                {
                    return new global::ElevenLabs.JsonConverters.BodySpeechToSpeechStreamingV1SpeechToSpeechVoiceIdStreamPostFileFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.BodySpeechToSpeechV1SpeechToSpeechVoiceIdPostFileFormat))
                {
                    return new global::ElevenLabs.JsonConverters.BodySpeechToSpeechV1SpeechToSpeechVoiceIdPostFileFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.BodySpeechToSpeechV1SpeechToSpeechVoiceIdPostFileFormat?))
                {
                    return new global::ElevenLabs.JsonConverters.BodySpeechToSpeechV1SpeechToSpeechVoiceIdPostFileFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.SpeechToSpeechFullOutputFormat))
                {
                    return new global::ElevenLabs.JsonConverters.SpeechToSpeechFullOutputFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.SpeechToSpeechFullOutputFormat?))
                {
                    return new global::ElevenLabs.JsonConverters.SpeechToSpeechFullOutputFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.SpeechToSpeechStreamOutputFormat))
                {
                    return new global::ElevenLabs.JsonConverters.SpeechToSpeechStreamOutputFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.SpeechToSpeechStreamOutputFormat?))
                {
                    return new global::ElevenLabs.JsonConverters.SpeechToSpeechStreamOutputFormatNullableJsonConverter();
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
                    0 => new PartitionOrphan7SourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),

                    1 => global::ElevenLabs.PartitionCoreSourceGenerationContext.TypeInfoResolver,
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}