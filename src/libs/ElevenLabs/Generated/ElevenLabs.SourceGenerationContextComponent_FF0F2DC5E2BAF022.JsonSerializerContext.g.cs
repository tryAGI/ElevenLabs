
#nullable enable
namespace ElevenLabs
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_FF0F2DC5E2BAF022
    {

        internal static readonly global::ElevenLabs.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::ElevenLabs.SourceGenerationContextMetadataScope>[] {
                    static () => global::ElevenLabs.SourceGenerationContextComponent_26599EE16C22139B.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_44022632973EEA2C.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_5C69D3BFC7301A2C.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_7F249496107131B7.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_856F46612893082C.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_8E9BA2907E30767B.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_C245CEAB29050054.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_D2A2B3E06ADFA3C7.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_E0B9DC76733B4FF7.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_E4C60D6686A7CC9C.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_F4B91E6884D24049.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_FE119DD7BA80AD20.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::ElevenLabs.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::ElevenLabs.JsonConverters.ImageGenerationRequestJsonConverter>(static () => new global::ElevenLabs.JsonConverters.ImageGenerationRequestJsonConverter());
            collector.AddEager<global::ElevenLabs.JsonConverters.UnixTimestampJsonConverter>(static () => new global::ElevenLabs.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::ElevenLabs.ImageGenerationRequest))
                {
                    return global::ElevenLabs.SourceGenerationContextMetadata0FactoryBatch0078.Create_ImageGenerationRequest2(options);
                }
                if (type == typeof(global::ElevenLabs.ImageGenerationRequest?))
                {
                    return global::ElevenLabs.SourceGenerationContextMetadata0FactoryBatch0115.Create_NullableImageGenerationRequest2(options);
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