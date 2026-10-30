
#nullable enable
namespace ElevenLabs
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_04CE54ED6588E38C
    {

        internal static readonly global::ElevenLabs.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::ElevenLabs.SourceGenerationContextMetadataScope>[] {
                    static () => global::ElevenLabs.SourceGenerationContextComponent_3C28B81D1E962F8C.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_3C7D8BEF5867F4EF.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_473287F8298DBA71.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_A3A6468A43A54812.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_B760F44FA5965C24.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::ElevenLabs.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::ElevenLabs.JsonConverters.OneOfJsonConverter<global::ElevenLabs.LiteralJsonSchemaProperty, global::ElevenLabs.ObjectJsonSchemaPropertyOutput, global::ElevenLabs.ArrayJsonSchemaPropertyOutput>>(static () => new global::ElevenLabs.JsonConverters.OneOfJsonConverter<global::ElevenLabs.LiteralJsonSchemaProperty, global::ElevenLabs.ObjectJsonSchemaPropertyOutput, global::ElevenLabs.ArrayJsonSchemaPropertyOutput>());
            collector.AddEager<global::ElevenLabs.JsonConverters.UnixTimestampJsonConverter>(static () => new global::ElevenLabs.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::ElevenLabs.ArrayJsonSchemaPropertyOutput))
                {
                    return global::ElevenLabs.SourceGenerationContextMetadata0FactoryBatch0013.Create_ArrayJsonSchemaPropertyOutput(options);
                }
                if (type == typeof(global::ElevenLabs.OneOf<global::ElevenLabs.LiteralJsonSchemaProperty, global::ElevenLabs.ObjectJsonSchemaPropertyOutput, global::ElevenLabs.ArrayJsonSchemaPropertyOutput>))
                {
                    return global::ElevenLabs.SourceGenerationContextMetadata0FactoryBatch0219.Create_SourceGenerationContextMetadataType_CF737D780E50D145(options);
                }
                if (type == typeof(global::ElevenLabs.OneOf<global::ElevenLabs.LiteralJsonSchemaProperty, global::ElevenLabs.ObjectJsonSchemaPropertyOutput, global::ElevenLabs.ArrayJsonSchemaPropertyOutput>?))
                {
                    return global::ElevenLabs.SourceGenerationContextMetadata0FactoryBatch0217.Create_SourceGenerationContextMetadataType_C8170BE92CF9D0C1(options);
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