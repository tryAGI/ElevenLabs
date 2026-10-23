
#nullable enable
namespace ElevenLabs
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_2677690238D7C310
    {

        internal static readonly global::ElevenLabs.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::ElevenLabs.SourceGenerationContextMetadataScope>[] {
                    static () => global::ElevenLabs.SourceGenerationContextComponent_05B6120F0AB84577.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_43BF78199BB1DB30.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_E88FF76F9007F7F1.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_F296327DCCCEF012.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::ElevenLabs.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::ElevenLabs.JsonConverters.UpdateAgentResponseTestRouteResponseJsonConverter>(static () => new global::ElevenLabs.JsonConverters.UpdateAgentResponseTestRouteResponseJsonConverter());
            collector.AddEager<global::ElevenLabs.JsonConverters.UnixTimestampJsonConverter>(static () => new global::ElevenLabs.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::ElevenLabs.UpdateAgentResponseTestRouteResponse))
                {
                    return global::ElevenLabs.SourceGenerationContextMetadata0FactoryBatch0231.Create_UpdateAgentResponseTestRouteResponse2(options);
                }
                if (type == typeof(global::ElevenLabs.UpdateAgentResponseTestRouteResponse?))
                {
                    return global::ElevenLabs.SourceGenerationContextMetadata0FactoryBatch0133.Create_NullableUpdateAgentResponseTestRouteResponse2(options);
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