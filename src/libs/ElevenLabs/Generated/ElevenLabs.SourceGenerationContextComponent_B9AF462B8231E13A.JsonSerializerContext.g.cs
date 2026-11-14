
#nullable enable
namespace ElevenLabs
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_B9AF462B8231E13A
    {

        internal static readonly global::ElevenLabs.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::ElevenLabs.SourceGenerationContextMetadataScope>[] {
                    static () => global::ElevenLabs.SourceGenerationContextComponent_2EBC5F89CCB94DB0.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_473287F8298DBA71.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_8832AE862E6FC582.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_98134B227BBF4E3D.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::ElevenLabs.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::ElevenLabs.JsonConverters.OneOfJsonConverter<global::ElevenLabs.LLMLiteralJsonSchemaProperty, global::ElevenLabs.LLMObjectJsonSchemaPropertyOutput, global::ElevenLabs.LLMArrayJsonSchemaPropertyOutput, global::ElevenLabs.LLMAnyOfJsonSchemaPropertyOutput>>(static () => new global::ElevenLabs.JsonConverters.OneOfJsonConverter<global::ElevenLabs.LLMLiteralJsonSchemaProperty, global::ElevenLabs.LLMObjectJsonSchemaPropertyOutput, global::ElevenLabs.LLMArrayJsonSchemaPropertyOutput, global::ElevenLabs.LLMAnyOfJsonSchemaPropertyOutput>());
            collector.AddEager<global::ElevenLabs.JsonConverters.UnixTimestampJsonConverter>(static () => new global::ElevenLabs.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::ElevenLabs.LLMArrayJsonSchemaPropertyOutput))
                {
                    return global::ElevenLabs.SourceGenerationContextMetadata0FactoryBatch0095.Create_LLMArrayJsonSchemaPropertyOutput(options);
                }
                if (type == typeof(global::ElevenLabs.OneOf<global::ElevenLabs.LLMLiteralJsonSchemaProperty, global::ElevenLabs.LLMObjectJsonSchemaPropertyOutput, global::ElevenLabs.LLMArrayJsonSchemaPropertyOutput, global::ElevenLabs.LLMAnyOfJsonSchemaPropertyOutput>))
                {
                    return global::ElevenLabs.SourceGenerationContextMetadata0FactoryBatch0248.Create_SourceGenerationContextMetadataType_C7B0E523E633E707(options);
                }
                if (type == typeof(global::ElevenLabs.OneOf<global::ElevenLabs.LLMLiteralJsonSchemaProperty, global::ElevenLabs.LLMObjectJsonSchemaPropertyOutput, global::ElevenLabs.LLMArrayJsonSchemaPropertyOutput, global::ElevenLabs.LLMAnyOfJsonSchemaPropertyOutput>?))
                {
                    return global::ElevenLabs.SourceGenerationContextMetadata0FactoryBatch0252.Create_SourceGenerationContextMetadataType_D92E6C7B13C016F7(options);
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