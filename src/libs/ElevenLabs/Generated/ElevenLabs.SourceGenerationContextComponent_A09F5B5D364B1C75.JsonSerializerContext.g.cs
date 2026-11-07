
#nullable enable
namespace ElevenLabs
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_A09F5B5D364B1C75
    {

        internal static readonly global::ElevenLabs.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::ElevenLabs.SourceGenerationContextMetadataScope>[] {
                    static () => global::ElevenLabs.SourceGenerationContextComponent_473287F8298DBA71.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_8832AE862E6FC582.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_8E53E29DCA3004AA.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_B1D53766E8D7F83E.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::ElevenLabs.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::ElevenLabs.JsonConverters.OneOfJsonConverter<global::ElevenLabs.LLMLiteralJsonSchemaProperty, global::ElevenLabs.LLMObjectJsonSchemaPropertyInput, global::ElevenLabs.LLMArrayJsonSchemaPropertyInput, global::ElevenLabs.LLMAnyOfJsonSchemaPropertyInput>>(static () => new global::ElevenLabs.JsonConverters.OneOfJsonConverter<global::ElevenLabs.LLMLiteralJsonSchemaProperty, global::ElevenLabs.LLMObjectJsonSchemaPropertyInput, global::ElevenLabs.LLMArrayJsonSchemaPropertyInput, global::ElevenLabs.LLMAnyOfJsonSchemaPropertyInput>());
            collector.AddEager<global::ElevenLabs.JsonConverters.UnixTimestampJsonConverter>(static () => new global::ElevenLabs.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::ElevenLabs.LLMArrayJsonSchemaPropertyInput))
                {
                    return global::ElevenLabs.SourceGenerationContextMetadata0FactoryBatch0087.Create_LLMArrayJsonSchemaPropertyInput(options);
                }
                if (type == typeof(global::ElevenLabs.OneOf<global::ElevenLabs.LLMLiteralJsonSchemaProperty, global::ElevenLabs.LLMObjectJsonSchemaPropertyInput, global::ElevenLabs.LLMArrayJsonSchemaPropertyInput, global::ElevenLabs.LLMAnyOfJsonSchemaPropertyInput>))
                {
                    return global::ElevenLabs.SourceGenerationContextMetadata0FactoryBatch0204.Create_SourceGenerationContextMetadataType_5F2BAC42FC67371A(options);
                }
                if (type == typeof(global::ElevenLabs.OneOf<global::ElevenLabs.LLMLiteralJsonSchemaProperty, global::ElevenLabs.LLMObjectJsonSchemaPropertyInput, global::ElevenLabs.LLMArrayJsonSchemaPropertyInput, global::ElevenLabs.LLMAnyOfJsonSchemaPropertyInput>?))
                {
                    return global::ElevenLabs.SourceGenerationContextMetadata0FactoryBatch0207.Create_SourceGenerationContextMetadataType_6D768641B4370A09(options);
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