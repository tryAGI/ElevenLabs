
#nullable enable
namespace ElevenLabs
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_C084E12E4AD70625
    {

        internal static readonly global::ElevenLabs.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::ElevenLabs.SourceGenerationContextMetadataScope>[] {
                    static () => global::ElevenLabs.SourceGenerationContextComponent_0037FE0B81D695CF.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_01489ECA514A6ED9.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_A90CCB40FFAE92C9.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::ElevenLabs.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.BackupLLMDefault, global::ElevenLabs.BackupLLMDisabled, global::ElevenLabs.BackupLLMOverride>>(static () => new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.BackupLLMDefault, global::ElevenLabs.BackupLLMDisabled, global::ElevenLabs.BackupLLMOverride>());
            collector.AddEager<global::ElevenLabs.JsonConverters.UnixTimestampJsonConverter>(static () => new global::ElevenLabs.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::ElevenLabs.AnyOf<global::ElevenLabs.BackupLLMDefault, global::ElevenLabs.BackupLLMDisabled, global::ElevenLabs.BackupLLMOverride>))
                {
                    return global::ElevenLabs.SourceGenerationContextMetadata0FactoryBatch0201.Create_SourceGenerationContextMetadataType_C084E12E4AD70625(options);
                }
                if (type == typeof(global::ElevenLabs.AnyOf<global::ElevenLabs.BackupLLMDefault, global::ElevenLabs.BackupLLMDisabled, global::ElevenLabs.BackupLLMOverride>?))
                {
                    return global::ElevenLabs.SourceGenerationContextMetadata0FactoryBatch0170.Create_SourceGenerationContextMetadataType_20A3514C08657814(options);
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