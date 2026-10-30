
#nullable enable
namespace ElevenLabs
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_6D94BEB28CC9D679
    {

        internal static readonly global::ElevenLabs.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::ElevenLabs.SourceGenerationContextMetadataScope>[] {
                    static () => global::ElevenLabs.SourceGenerationContextComponent_25CB09A3FA594B26.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_E22FFF99C3107DAE.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_FC62FB368B06AE3B.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::ElevenLabs.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::ElevenLabs.JsonConverters.UnixTimestampJsonConverter>(static () => new global::ElevenLabs.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::System.Collections.Generic.IList<global::ElevenLabs.AnyOf<global::ElevenLabs.PronunciationDictionaryAliasRuleResponseModel, global::ElevenLabs.PronunciationDictionaryPhonemeRuleResponseModel>>))
                {
                    return global::ElevenLabs.SourceGenerationContextMetadata0FactoryBatch0199.Create_SourceGenerationContextMetadataType_6D94BEB28CC9D679(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::ElevenLabs.AnyOf<global::ElevenLabs.PronunciationDictionaryAliasRuleResponseModel, global::ElevenLabs.PronunciationDictionaryPhonemeRuleResponseModel>>))
                {
                    return global::ElevenLabs.SourceGenerationContextMetadata0FactoryBatch0193.Create_SourceGenerationContextMetadataType_50CC93CED7E61E86(options);
                }
                global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? additional = null;
                ResolveAdditionalTypeInfo(type, options, ref additional);
                return additional;
            }

            static partial void ResolveAdditionalTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options,
                ref global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? result);
        }

    }
}