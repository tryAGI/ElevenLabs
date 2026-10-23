
#nullable enable
namespace ElevenLabs
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_EEE469A8D759DAF2
    {

        internal static readonly global::ElevenLabs.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::ElevenLabs.SourceGenerationContextMetadataScope>[] {
                    static () => global::ElevenLabs.SourceGenerationContextComponent_15C2C80CE4793985.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_3062147427826B21.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_B768A45B9063ACC2.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_C3AA63B1473C5EDB.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_E38D6526D5EE40D8.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::ElevenLabs.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::ElevenLabs.JsonConverters.InputOverridesVariant13JsonConverter>(static () => new global::ElevenLabs.JsonConverters.InputOverridesVariant13JsonConverter());
            collector.AddEager<global::ElevenLabs.JsonConverters.UnixTimestampJsonConverter>(static () => new global::ElevenLabs.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::ElevenLabs.InputOverridesVariant13))
                {
                    return global::ElevenLabs.SourceGenerationContextMetadata0FactoryBatch0080.Create_InputOverridesVariant132(options);
                }
                if (type == typeof(global::ElevenLabs.InputOverridesVariant13?))
                {
                    return global::ElevenLabs.SourceGenerationContextMetadata0FactoryBatch0116.Create_NullableInputOverridesVariant132(options);
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