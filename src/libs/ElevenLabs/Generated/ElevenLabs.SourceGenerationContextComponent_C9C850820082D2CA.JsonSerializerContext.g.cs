
#nullable enable
namespace ElevenLabs
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_C9C850820082D2CA
    {

        internal static readonly global::ElevenLabs.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::ElevenLabs.SourceGenerationContextMetadataScope>[] {
                    static () => global::ElevenLabs.SourceGenerationContextComponent_3C1F0C5076163AB5.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_B4500A989C56C97C.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::ElevenLabs.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.MusicPrompt, global::ElevenLabs.CompositionPlan>>(static () => new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.MusicPrompt, global::ElevenLabs.CompositionPlan>());
            collector.AddEager<global::ElevenLabs.JsonConverters.UnixTimestampJsonConverter>(static () => new global::ElevenLabs.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::ElevenLabs.AnyOf<global::ElevenLabs.MusicPrompt, global::ElevenLabs.CompositionPlan>))
                {
                    return global::ElevenLabs.SourceGenerationContextMetadata0FactoryBatch0218.Create_SourceGenerationContextMetadataType_C9C850820082D2CA(options);
                }
                if (type == typeof(global::ElevenLabs.AnyOf<global::ElevenLabs.MusicPrompt, global::ElevenLabs.CompositionPlan>?))
                {
                    return global::ElevenLabs.SourceGenerationContextMetadata0FactoryBatch0189.Create_SourceGenerationContextMetadataType_3FDFB8184E966D83(options);
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