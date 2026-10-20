
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AudioFormat), TypeInfoPropertyName = "AudioFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AudioInputPacing), TypeInfoPropertyName = "AudioInputPacing2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ClientSecretResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.OpenAISessionConfigOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CreateClientSecretRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.OpenAISessionConfigInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ExpiresAfter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.Eagerness), TypeInfoPropertyName = "Eagerness2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.OpenAIAudioConfigInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.OpenAIAudioInputConfigInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.OpenAIAudioOutputConfigInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.OpenAIAudioConfigOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.OpenAIAudioInputConfigOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.OpenAIAudioOutputConfigOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.OpenAIAudioInputFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.OpenAIAudioInputTranscription))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.OpenAITurnDetection))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.OpenAIAudioOutputFormat))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.OpenAIFunctionTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.OpenAIMCPTool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.OpenAIMCPToolRequireApproval), TypeInfoPropertyName = "OpenAIMCPToolRequireApproval2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.RealtimeModel), TypeInfoPropertyName = "RealtimeModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.ToolsItem3>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ToolsItem3), TypeInfoPropertyName = "ToolsItem32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AnyOf<string, global::ElevenLabs.OpenAIToolChoiceFunction>), TypeInfoPropertyName = "AnyOfStringOpenAIToolChoiceFunction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.OpenAIToolChoiceFunction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AnyOf<global::ElevenLabs.OpenAITurnDetection, string>), TypeInfoPropertyName = "AnyOfOpenAITurnDetectionString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.OneOf<string, global::ElevenLabs.OpenAITracingConfiguration>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.OpenAITracingConfiguration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.ToolsItem4>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ToolsItem4), TypeInfoPropertyName = "ToolsItem42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.OpenAISessionConfigOutputToolDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.OpenAISessionConfigOutputToolDiscriminatorType), TypeInfoPropertyName = "OpenAISessionConfigOutputToolDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.OpenAIToolChoiceFunctionInner))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.TurnDetectionType), TypeInfoPropertyName = "TurnDetectionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AudioFormat?), TypeInfoPropertyName = "NullableAudioFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AudioInputPacing?), TypeInfoPropertyName = "NullableAudioInputPacing2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.Eagerness?), TypeInfoPropertyName = "NullableEagerness2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.OpenAIMCPToolRequireApproval?), TypeInfoPropertyName = "NullableOpenAIMCPToolRequireApproval2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.RealtimeModel?), TypeInfoPropertyName = "NullableRealtimeModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ToolsItem3?), TypeInfoPropertyName = "NullableToolsItem32")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AnyOf<string, global::ElevenLabs.OpenAIToolChoiceFunction>?), TypeInfoPropertyName = "NullableAnyOfStringOpenAIToolChoiceFunction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AnyOf<global::ElevenLabs.OpenAITurnDetection, string>?), TypeInfoPropertyName = "NullableAnyOfOpenAITurnDetectionString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ToolsItem4?), TypeInfoPropertyName = "NullableToolsItem42")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.OpenAISessionConfigOutputToolDiscriminatorType?), TypeInfoPropertyName = "NullableOpenAISessionConfigOutputToolDiscriminatorType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.TurnDetectionType?), TypeInfoPropertyName = "NullableTurnDetectionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.ToolsItem3>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.ToolsItem4>))]
    internal sealed partial class RealtimeSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RealtimeSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static RealtimeSourceGenerationContext Default { get; } = new(DefaultOptions);

        private RealtimeSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ToolsItem3JsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.ToolsItem4JsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, global::ElevenLabs.OpenAIToolChoiceFunction>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.OpenAITurnDetection, string>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.OneOfJsonConverter<string, global::ElevenLabs.OpenAITracingConfiguration>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, global::ElevenLabs.OpenAIToolChoiceFunction>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.OneOfJsonConverter<string, global::ElevenLabs.OpenAITracingConfiguration>());
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
                    typeToConvert == typeof(global::ElevenLabs.AudioFormat)

                    || typeToConvert == typeof(global::ElevenLabs.AudioFormat?)

                    || typeToConvert == typeof(global::ElevenLabs.AudioInputPacing)

                    || typeToConvert == typeof(global::ElevenLabs.AudioInputPacing?)

                    || typeToConvert == typeof(global::ElevenLabs.Eagerness)

                    || typeToConvert == typeof(global::ElevenLabs.Eagerness?)

                    || typeToConvert == typeof(global::ElevenLabs.OpenAIMCPToolRequireApproval)

                    || typeToConvert == typeof(global::ElevenLabs.OpenAIMCPToolRequireApproval?)

                    || typeToConvert == typeof(global::ElevenLabs.OpenAISessionConfigOutputToolDiscriminatorType)

                    || typeToConvert == typeof(global::ElevenLabs.OpenAISessionConfigOutputToolDiscriminatorType?)

                    || typeToConvert == typeof(global::ElevenLabs.RealtimeModel)

                    || typeToConvert == typeof(global::ElevenLabs.RealtimeModel?)

                    || typeToConvert == typeof(global::ElevenLabs.TurnDetectionType)

                    || typeToConvert == typeof(global::ElevenLabs.TurnDetectionType?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::ElevenLabs.AudioFormat))
                {
                    return new global::ElevenLabs.JsonConverters.AudioFormatJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.AudioFormat?))
                {
                    return new global::ElevenLabs.JsonConverters.AudioFormatNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.AudioInputPacing))
                {
                    return new global::ElevenLabs.JsonConverters.AudioInputPacingJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.AudioInputPacing?))
                {
                    return new global::ElevenLabs.JsonConverters.AudioInputPacingNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.Eagerness))
                {
                    return new global::ElevenLabs.JsonConverters.EagernessJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.Eagerness?))
                {
                    return new global::ElevenLabs.JsonConverters.EagernessNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.OpenAIMCPToolRequireApproval))
                {
                    return new global::ElevenLabs.JsonConverters.OpenAIMCPToolRequireApprovalJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.OpenAIMCPToolRequireApproval?))
                {
                    return new global::ElevenLabs.JsonConverters.OpenAIMCPToolRequireApprovalNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.OpenAISessionConfigOutputToolDiscriminatorType))
                {
                    return new global::ElevenLabs.JsonConverters.OpenAISessionConfigOutputToolDiscriminatorTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.OpenAISessionConfigOutputToolDiscriminatorType?))
                {
                    return new global::ElevenLabs.JsonConverters.OpenAISessionConfigOutputToolDiscriminatorTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.RealtimeModel))
                {
                    return new global::ElevenLabs.JsonConverters.RealtimeModelJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.RealtimeModel?))
                {
                    return new global::ElevenLabs.JsonConverters.RealtimeModelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.TurnDetectionType))
                {
                    return new global::ElevenLabs.JsonConverters.TurnDetectionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.TurnDetectionType?))
                {
                    return new global::ElevenLabs.JsonConverters.TurnDetectionTypeNullableJsonConverter();
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
                    0 => new RealtimeSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),

                    1 => global::ElevenLabs.PartitionCoreSourceGenerationContext.TypeInfoResolver,
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}