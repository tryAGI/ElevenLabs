
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AllowedOutputFormats), TypeInfoPropertyName = "AllowedOutputFormats2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AudioRefChunk))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.TimeRange))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(byte[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyComposeMusicWithADetailedResponseV1MusicDetailedPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.MusicGenerationMode), TypeInfoPropertyName = "MusicGenerationMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.MusicPrompt))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.OneOf<global::ElevenLabs.MusicPrompt, global::ElevenLabs.CompositionPlan>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CompositionPlan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.MusicModelID), TypeInfoPropertyName = "MusicModelID2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyComposeMusicWithADetailedResponseV1MusicDetailedPostModelStylePrefix), TypeInfoPropertyName = "BodyComposeMusicWithADetailedResponseV1MusicDetailedPostModelStylePrefix2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyComposeMusicV1MusicPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyGenerateCompositionPlanV1MusicPlanPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AnyOf<global::ElevenLabs.MusicPrompt, global::ElevenLabs.CompositionPlan, object>), TypeInfoPropertyName = "AnyOfMusicPromptCompositionPlanObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyStemSeparationV1MusicStemSeparationPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyStemSeparationV1MusicStemSeparationPostStemVariationId), TypeInfoPropertyName = "BodyStemSeparationV1MusicStemSeparationPostStemVariationId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyStreamComposedMusicV1MusicStreamPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyStreamComposedMusicWithADetailedResponseV1MusicDetailedStreamPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyUploadMusicV1MusicUploadPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AnyOf<bool?, global::ElevenLabs.MusicModelID?>), TypeInfoPropertyName = "AnyOfBooleanMusicModelID2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.OneOf<global::ElevenLabs.GenerationChunkInput, global::ElevenLabs.AudioRefChunk>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.OneOf<global::ElevenLabs.GenerationChunkInput, global::ElevenLabs.AudioRefChunk>), TypeInfoPropertyName = "OneOfGenerationChunkInputAudioRefChunk2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GenerationChunkInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AnyOf<global::ElevenLabs.MusicPrompt, global::ElevenLabs.CompositionPlan>), TypeInfoPropertyName = "AnyOfMusicPromptCompositionPlan2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.WordTimestamp>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WordTimestamp))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GenerationChunkInputContextAdherence), TypeInfoPropertyName = "GenerationChunkInputContextAdherence2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GenerationChunkInputConditionStrength), TypeInfoPropertyName = "GenerationChunkInputConditionStrength2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.HTTPValidationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.ValidationError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ValidationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.SongSection>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SongSection))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.MusicUploadResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SectionSource))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.TimeRange>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.AnyOf<string, int?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AnyOf<string, int?>), TypeInfoPropertyName = "AnyOfStringInt322")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GenerateOutputFormat), TypeInfoPropertyName = "GenerateOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ComposeDetailedOutputFormat), TypeInfoPropertyName = "ComposeDetailedOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ComposeDetailedStreamOutputFormat), TypeInfoPropertyName = "ComposeDetailedStreamOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.StreamComposeOutputFormat), TypeInfoPropertyName = "StreamComposeOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AllowedOutputFormats?), TypeInfoPropertyName = "NullableAllowedOutputFormats2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.MusicGenerationMode?), TypeInfoPropertyName = "NullableMusicGenerationMode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.MusicModelID?), TypeInfoPropertyName = "NullableMusicModelID2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyComposeMusicWithADetailedResponseV1MusicDetailedPostModelStylePrefix?), TypeInfoPropertyName = "NullableBodyComposeMusicWithADetailedResponseV1MusicDetailedPostModelStylePrefix2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AnyOf<global::ElevenLabs.MusicPrompt, global::ElevenLabs.CompositionPlan, object>?), TypeInfoPropertyName = "NullableAnyOfMusicPromptCompositionPlanObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyStemSeparationV1MusicStemSeparationPostStemVariationId?), TypeInfoPropertyName = "NullableBodyStemSeparationV1MusicStemSeparationPostStemVariationId2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AnyOf<bool?, global::ElevenLabs.MusicModelID?>?), TypeInfoPropertyName = "NullableAnyOfBooleanMusicModelID2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.OneOf<global::ElevenLabs.GenerationChunkInput, global::ElevenLabs.AudioRefChunk>?), TypeInfoPropertyName = "NullableOneOfGenerationChunkInputAudioRefChunk2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AnyOf<global::ElevenLabs.MusicPrompt, global::ElevenLabs.CompositionPlan>?), TypeInfoPropertyName = "NullableAnyOfMusicPromptCompositionPlan2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GenerationChunkInputContextAdherence?), TypeInfoPropertyName = "NullableGenerationChunkInputContextAdherence2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GenerationChunkInputConditionStrength?), TypeInfoPropertyName = "NullableGenerationChunkInputConditionStrength2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AnyOf<string, int?>?), TypeInfoPropertyName = "NullableAnyOfStringInt322")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GenerateOutputFormat?), TypeInfoPropertyName = "NullableGenerateOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ComposeDetailedOutputFormat?), TypeInfoPropertyName = "NullableComposeDetailedOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ComposeDetailedStreamOutputFormat?), TypeInfoPropertyName = "NullableComposeDetailedStreamOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.StreamComposeOutputFormat?), TypeInfoPropertyName = "NullableStreamComposeOutputFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.OneOf<global::ElevenLabs.GenerationChunkInput, global::ElevenLabs.AudioRefChunk>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.WordTimestamp>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.ValidationError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.SongSection>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.TimeRange>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.AnyOf<string, int?>>))]
    internal sealed partial class MusicGenerationSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class MusicGenerationSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


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
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<double?, int?>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<double?, int?>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, int?, double?, bool?, object>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.Dictionary<string, string>, string, object>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.OneOfJsonConverter<global::ElevenLabs.MusicPrompt, global::ElevenLabs.CompositionPlan>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.OneOfJsonConverter<global::ElevenLabs.MusicPrompt, global::ElevenLabs.CompositionPlan>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.Dictionary<string, string>, string, object>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.MusicPrompt, global::ElevenLabs.CompositionPlan, object>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, object, object>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, object>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>, object>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.OneOfJsonConverter<global::ElevenLabs.MusicPrompt, global::ElevenLabs.CompositionPlan>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.OneOfJsonConverter<global::ElevenLabs.MusicPrompt, global::ElevenLabs.CompositionPlan>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<bool?, global::ElevenLabs.MusicModelID?>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<bool?, string>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, int?, double?, global::System.DateTime?, bool?, object>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.OneOfJsonConverter<global::ElevenLabs.GenerationChunkInput, global::ElevenLabs.AudioRefChunk>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, int?, double?, bool?, global::System.Collections.Generic.IList<object>, object, object>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.MusicPrompt, global::ElevenLabs.CompositionPlan>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<int?, string>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, int?, double?, bool?, object>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.MusicPrompt, global::ElevenLabs.CompositionPlan, object>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, bool?, double?>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<int?, string>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, int?>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, int?, double?, bool?, global::System.DateTime?, object>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<int?, string, object>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<int?, string, object>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.MusicPrompt, global::ElevenLabs.CompositionPlan>());
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
                    typeToConvert == typeof(global::ElevenLabs.AllowedOutputFormats)

                    || typeToConvert == typeof(global::ElevenLabs.AllowedOutputFormats?)

                    || typeToConvert == typeof(global::ElevenLabs.BodyComposeMusicWithADetailedResponseV1MusicDetailedPostModelStylePrefix)

                    || typeToConvert == typeof(global::ElevenLabs.BodyComposeMusicWithADetailedResponseV1MusicDetailedPostModelStylePrefix?)

                    || typeToConvert == typeof(global::ElevenLabs.BodyStemSeparationV1MusicStemSeparationPostStemVariationId)

                    || typeToConvert == typeof(global::ElevenLabs.BodyStemSeparationV1MusicStemSeparationPostStemVariationId?)

                    || typeToConvert == typeof(global::ElevenLabs.GenerationChunkInputContextAdherence)

                    || typeToConvert == typeof(global::ElevenLabs.GenerationChunkInputContextAdherence?)

                    || typeToConvert == typeof(global::ElevenLabs.GenerationChunkInputConditionStrength)

                    || typeToConvert == typeof(global::ElevenLabs.GenerationChunkInputConditionStrength?)

                    || typeToConvert == typeof(global::ElevenLabs.MusicGenerationMode)

                    || typeToConvert == typeof(global::ElevenLabs.MusicGenerationMode?)

                    || typeToConvert == typeof(global::ElevenLabs.MusicModelID)

                    || typeToConvert == typeof(global::ElevenLabs.MusicModelID?)

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
                if (typeToConvert == typeof(global::ElevenLabs.AllowedOutputFormats))
                {
                    return new global::ElevenLabs.JsonConverters.AllowedOutputFormatsJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.AllowedOutputFormats?))
                {
                    return new global::ElevenLabs.JsonConverters.AllowedOutputFormatsNullableJsonConverter();
                }

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

                if (typeToConvert == typeof(global::ElevenLabs.GenerationChunkInputContextAdherence))
                {
                    return new global::ElevenLabs.JsonConverters.GenerationChunkInputContextAdherenceJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.GenerationChunkInputContextAdherence?))
                {
                    return new global::ElevenLabs.JsonConverters.GenerationChunkInputContextAdherenceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.GenerationChunkInputConditionStrength))
                {
                    return new global::ElevenLabs.JsonConverters.GenerationChunkInputConditionStrengthJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.GenerationChunkInputConditionStrength?))
                {
                    return new global::ElevenLabs.JsonConverters.GenerationChunkInputConditionStrengthNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.MusicGenerationMode))
                {
                    return new global::ElevenLabs.JsonConverters.MusicGenerationModeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.MusicGenerationMode?))
                {
                    return new global::ElevenLabs.JsonConverters.MusicGenerationModeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.MusicModelID))
                {
                    return new global::ElevenLabs.JsonConverters.MusicModelIDJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.MusicModelID?))
                {
                    return new global::ElevenLabs.JsonConverters.MusicModelIDNullableJsonConverter();
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
                    0 => new MusicGenerationSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}