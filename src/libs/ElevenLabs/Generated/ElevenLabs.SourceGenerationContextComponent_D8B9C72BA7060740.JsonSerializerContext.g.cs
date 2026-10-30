
#nullable enable
namespace ElevenLabs
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_D8B9C72BA7060740
    {

        internal static readonly global::ElevenLabs.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::ElevenLabs.SourceGenerationContextMetadataScope>[] {
                    static () => global::ElevenLabs.SourceGenerationContextComponent_0E49E116529A7378.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_3E14613F1D674819.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_75C100A0E3547B02.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_81E2BDB87D173851.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_81E3EFC7698A4C04.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_BABB0654D08B5C1F.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_BADA1872B7ED2FB5.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_C94A42AA06D1AA5B.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_D1FF120E543E51DD.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_D8CC4689BF3FCF16.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_E3819AA9C29E4389.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_EBEA7AC65AE7C43A.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::ElevenLabs.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::ElevenLabs.JsonConverters.Params2JsonConverter>(static () => new global::ElevenLabs.JsonConverters.Params2JsonConverter());
            collector.AddEager<global::ElevenLabs.JsonConverters.UnixTimestampJsonConverter>(static () => new global::ElevenLabs.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::ElevenLabs.Params2))
                {
                    return global::ElevenLabs.SourceGenerationContextMetadata0FactoryBatch0149.Create_Params22(options);
                }
                if (type == typeof(global::ElevenLabs.Params2?))
                {
                    return global::ElevenLabs.SourceGenerationContextMetadata0FactoryBatch0125.Create_NullableParams22(options);
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