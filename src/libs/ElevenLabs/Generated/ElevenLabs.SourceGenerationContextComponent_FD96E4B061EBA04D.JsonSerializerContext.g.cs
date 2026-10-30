
#nullable enable
namespace ElevenLabs
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_FD96E4B061EBA04D
    {

        internal static readonly global::ElevenLabs.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::ElevenLabs.SourceGenerationContextMetadataScope>[] {
                    static () => global::ElevenLabs.SourceGenerationContextComponent_05C7AB5B34415A9F.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_2CE06A9E7F8C3E6B.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_473287F8298DBA71.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_6DA88C34BA124C41.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_B760F44FA5965C24.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::ElevenLabs.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::ElevenLabs.JsonConverters.TemplateRunInputJsonConverter>(static () => new global::ElevenLabs.JsonConverters.TemplateRunInputJsonConverter());
            collector.AddEager<global::ElevenLabs.JsonConverters.UnixTimestampJsonConverter>(static () => new global::ElevenLabs.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::ElevenLabs.TemplateRunInput))
                {
                    return global::ElevenLabs.SourceGenerationContextMetadata0FactoryBatch0237.Create_TemplateRunInput2(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::ElevenLabs.TemplateRunInput>))
                {
                    return global::ElevenLabs.SourceGenerationContextMetadata0FactoryBatch0183.Create_SourceGenerationContextMetadataType_20851B05E2031706(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::ElevenLabs.TemplateRunInput>))
                {
                    return global::ElevenLabs.SourceGenerationContextMetadata0FactoryBatch0194.Create_SourceGenerationContextMetadataType_549352927FB63142(options);
                }
                if (type == typeof(global::ElevenLabs.TemplateRunInput?))
                {
                    return global::ElevenLabs.SourceGenerationContextMetadata0FactoryBatch0134.Create_NullableTemplateRunInput2(options);
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