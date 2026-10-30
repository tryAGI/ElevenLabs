
#nullable enable
namespace ElevenLabs
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_E5ACC400B95281B0
    {

        internal static readonly global::ElevenLabs.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::ElevenLabs.SourceGenerationContextMetadataScope>[] {
                    static () => global::ElevenLabs.SourceGenerationContextComponent_2AFB00D91E3B1013.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_87492E7E3AE12647.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_90B5FB6443513913.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_C337170EF5952E7E.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_CF70BB76B4A06DB7.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_D06F7DFF6D32DD26.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_EF356E8CB3F5E292.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::ElevenLabs.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::ElevenLabs.JsonConverters.Nodes2JsonConverter>(static () => new global::ElevenLabs.JsonConverters.Nodes2JsonConverter());
            collector.AddEager<global::ElevenLabs.JsonConverters.UnixTimestampJsonConverter>(static () => new global::ElevenLabs.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::ElevenLabs.Nodes2))
                {
                    return global::ElevenLabs.SourceGenerationContextMetadata0FactoryBatch0098.Create_Nodes22(options);
                }
                if (type == typeof(global::ElevenLabs.Nodes2?))
                {
                    return global::ElevenLabs.SourceGenerationContextMetadata0FactoryBatch0124.Create_NullableNodes22(options);
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