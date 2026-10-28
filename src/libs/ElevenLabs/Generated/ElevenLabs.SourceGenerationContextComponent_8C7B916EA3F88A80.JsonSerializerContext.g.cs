
#nullable enable
namespace ElevenLabs
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_8C7B916EA3F88A80
    {

        internal static readonly global::ElevenLabs.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::ElevenLabs.SourceGenerationContextMetadataScope>[] {
                    static () => global::ElevenLabs.SourceGenerationContextComponent_11D2DD9739512B26.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_40E9E0C2319790FF.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_473287F8298DBA71.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_89B98F8D05B2E635.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_8CEB1352117A604F.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_C408D52BB1FB9178.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_CE0AC82A184EA9EC.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_F0D9F71F4B978AF3.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::ElevenLabs.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::ElevenLabs.JsonConverters.ASTNodeOutputJsonConverter>(static () => new global::ElevenLabs.JsonConverters.ASTNodeOutputJsonConverter());
            collector.AddEager<global::ElevenLabs.JsonConverters.UnixTimestampJsonConverter>(static () => new global::ElevenLabs.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::ElevenLabs.ASTAdditionOperatorNodeOutput))
                {
                    return global::ElevenLabs.SourceGenerationContextMetadata0FactoryBatch0000.Create_ASTAdditionOperatorNodeOutput(options);
                }
                if (type == typeof(global::ElevenLabs.ASTAndOperatorNodeOutput))
                {
                    return global::ElevenLabs.SourceGenerationContextMetadata0FactoryBatch0000.Create_ASTAndOperatorNodeOutput(options);
                }
                if (type == typeof(global::ElevenLabs.ASTConditionalOperatorNodeOutput))
                {
                    return global::ElevenLabs.SourceGenerationContextMetadata0FactoryBatch0000.Create_ASTConditionalOperatorNodeOutput(options);
                }
                if (type == typeof(global::ElevenLabs.ASTDivisionOperatorNodeOutput))
                {
                    return global::ElevenLabs.SourceGenerationContextMetadata0FactoryBatch0001.Create_ASTDivisionOperatorNodeOutput(options);
                }
                if (type == typeof(global::ElevenLabs.ASTEqualsOperatorNodeOutput))
                {
                    return global::ElevenLabs.SourceGenerationContextMetadata0FactoryBatch0001.Create_ASTEqualsOperatorNodeOutput(options);
                }
                if (type == typeof(global::ElevenLabs.ASTGreaterThanOperatorNodeOutput))
                {
                    return global::ElevenLabs.SourceGenerationContextMetadata0FactoryBatch0001.Create_ASTGreaterThanOperatorNodeOutput(options);
                }
                if (type == typeof(global::ElevenLabs.ASTGreaterThanOrEqualsOperatorNodeOutput))
                {
                    return global::ElevenLabs.SourceGenerationContextMetadata0FactoryBatch0001.Create_ASTGreaterThanOrEqualsOperatorNodeOutput(options);
                }
                if (type == typeof(global::ElevenLabs.ASTLessThanOperatorNodeOutput))
                {
                    return global::ElevenLabs.SourceGenerationContextMetadata0FactoryBatch0001.Create_ASTLessThanOperatorNodeOutput(options);
                }
                if (type == typeof(global::ElevenLabs.ASTLessThanOrEqualsOperatorNodeOutput))
                {
                    return global::ElevenLabs.SourceGenerationContextMetadata0FactoryBatch0002.Create_ASTLessThanOrEqualsOperatorNodeOutput(options);
                }
                if (type == typeof(global::ElevenLabs.ASTMultiplicationOperatorNodeOutput))
                {
                    return global::ElevenLabs.SourceGenerationContextMetadata0FactoryBatch0002.Create_ASTMultiplicationOperatorNodeOutput(options);
                }
                if (type == typeof(global::ElevenLabs.ASTNodeOutput))
                {
                    return global::ElevenLabs.SourceGenerationContextMetadata0FactoryBatch0002.Create_ASTNodeOutput2(options);
                }
                if (type == typeof(global::ElevenLabs.ASTNotEqualsOperatorNodeOutput))
                {
                    return global::ElevenLabs.SourceGenerationContextMetadata0FactoryBatch0002.Create_ASTNotEqualsOperatorNodeOutput(options);
                }
                if (type == typeof(global::ElevenLabs.ASTOrOperatorNodeOutput))
                {
                    return global::ElevenLabs.SourceGenerationContextMetadata0FactoryBatch0003.Create_ASTOrOperatorNodeOutput(options);
                }
                if (type == typeof(global::ElevenLabs.ASTSubtractionOperatorNodeOutput))
                {
                    return global::ElevenLabs.SourceGenerationContextMetadata0FactoryBatch0003.Create_ASTSubtractionOperatorNodeOutput(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::ElevenLabs.ASTNodeOutput>))
                {
                    return global::ElevenLabs.SourceGenerationContextMetadata0FactoryBatch0174.Create_SourceGenerationContextMetadataType_092F9E589CAF1B8E(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::ElevenLabs.ASTNodeOutput>))
                {
                    return global::ElevenLabs.SourceGenerationContextMetadata0FactoryBatch0226.Create_SourceGenerationContextMetadataType_FFB6F64435C8A9EB(options);
                }
                if (type == typeof(global::ElevenLabs.ASTNodeOutput?))
                {
                    return global::ElevenLabs.SourceGenerationContextMetadata0FactoryBatch0098.Create_NullableASTNodeOutput2(options);
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