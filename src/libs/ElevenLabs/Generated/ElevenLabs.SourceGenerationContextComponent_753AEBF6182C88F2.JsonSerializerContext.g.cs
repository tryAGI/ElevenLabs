
#nullable enable
namespace ElevenLabs
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_753AEBF6182C88F2
    {

        internal static readonly global::ElevenLabs.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::ElevenLabs.SourceGenerationContextMetadataScope>[] {
                    static () => global::ElevenLabs.SourceGenerationContextComponent_145E3F47DDEF94D3.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_81252B19AB32F681.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_938E58D95F6D0169.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_A714474553776E46.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_AFA8BB8956849E47.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::ElevenLabs.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::ElevenLabs.JsonConverters.RefreshUrlDocumentRouteResponseJsonConverter>(static () => new global::ElevenLabs.JsonConverters.RefreshUrlDocumentRouteResponseJsonConverter());
            collector.AddEager<global::ElevenLabs.JsonConverters.UnixTimestampJsonConverter>(static () => new global::ElevenLabs.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::ElevenLabs.RefreshUrlDocumentRouteResponse))
                {
                    return global::ElevenLabs.SourceGenerationContextMetadata0FactoryBatch0155.Create_RefreshUrlDocumentRouteResponse2(options);
                }
                if (type == typeof(global::ElevenLabs.RefreshUrlDocumentRouteResponse?))
                {
                    return global::ElevenLabs.SourceGenerationContextMetadata0FactoryBatch0125.Create_NullableRefreshUrlDocumentRouteResponse2(options);
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