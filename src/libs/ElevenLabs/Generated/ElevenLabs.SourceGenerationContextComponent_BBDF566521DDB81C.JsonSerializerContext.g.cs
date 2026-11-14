
#nullable enable
namespace ElevenLabs
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_BBDF566521DDB81C
    {

        internal static readonly global::ElevenLabs.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::ElevenLabs.SourceGenerationContextMetadataScope>[] {
                    static () => global::ElevenLabs.SourceGenerationContextComponent_20E67396D4D908CA.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_2F8FEF21D487F0EB.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_44C33E03A3908F04.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_8B207969AABACFFD.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_C58FE9260D4312F3.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_D014D7742AB91D01.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_DAE5E446651B59CC.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_F6CBA07B79DADB49.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::ElevenLabs.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::ElevenLabs.JsonConverters.EventJsonConverter>(static () => new global::ElevenLabs.JsonConverters.EventJsonConverter());
            collector.AddEager<global::ElevenLabs.JsonConverters.UnixTimestampJsonConverter>(static () => new global::ElevenLabs.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::ElevenLabs.Event))
                {
                    return global::ElevenLabs.SourceGenerationContextMetadata0FactoryBatch0072.Create_Event2(options);
                }
                if (type == typeof(global::ElevenLabs.Event?))
                {
                    return global::ElevenLabs.SourceGenerationContextMetadata0FactoryBatch0127.Create_NullableEvent2(options);
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