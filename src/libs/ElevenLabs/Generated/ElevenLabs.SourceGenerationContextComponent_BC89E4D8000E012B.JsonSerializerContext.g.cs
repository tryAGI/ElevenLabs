
#nullable enable
namespace ElevenLabs
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_BC89E4D8000E012B
    {

        internal static readonly global::ElevenLabs.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::ElevenLabs.SourceGenerationContextMetadataScope>[] {
                    static () => global::ElevenLabs.SourceGenerationContextComponent_0357E37AA483AC7F.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_20E5298AAB8F8F25.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_222B6810A4195BD8.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_4DEDF0D3AA167C99.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_681F43F89656CEC0.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_86EBBA45EF3A56C2.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_DA586296EEFD28BA.MetadataScope,
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
                if (type == typeof(global::ElevenLabs.ConversationalConfigAPIModelWorkflowOverrideInput))
                {
                    return global::ElevenLabs.SourceGenerationContextMetadata0FactoryBatch0046.Create_ConversationalConfigAPIModelWorkflowOverrideInput(options);
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