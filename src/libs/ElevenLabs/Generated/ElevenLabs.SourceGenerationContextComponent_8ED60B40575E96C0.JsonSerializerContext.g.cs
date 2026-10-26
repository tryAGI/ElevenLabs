
#nullable enable
namespace ElevenLabs
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_8ED60B40575E96C0
    {

        internal static readonly global::ElevenLabs.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::ElevenLabs.SourceGenerationContextMetadataScope>[] {
                    static () => global::ElevenLabs.SourceGenerationContextComponent_182344E7E78E3543.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_473287F8298DBA71.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_48449D4B9F390D16.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_698542E87931BDBC.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_88FA8EEF98A7A1F3.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_AE2B48A8862C0CCA.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_B5EB0801DD1D757C.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_F829A5724CC7CBB5.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::ElevenLabs.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::ElevenLabs.JsonConverters.ASTNodeInputJsonConverter>(static () => new global::ElevenLabs.JsonConverters.ASTNodeInputJsonConverter());
            collector.AddEager<global::ElevenLabs.JsonConverters.UnixTimestampJsonConverter>(static () => new global::ElevenLabs.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::ElevenLabs.ASTAdditionOperatorNodeInput))
                {
                    return global::ElevenLabs.SourceGenerationContextMetadata0FactoryBatch0000.Create_ASTAdditionOperatorNodeInput(options);
                }
                if (type == typeof(global::ElevenLabs.ASTAndOperatorNodeInput))
                {
                    return global::ElevenLabs.SourceGenerationContextMetadata0FactoryBatch0000.Create_ASTAndOperatorNodeInput(options);
                }
                if (type == typeof(global::ElevenLabs.ASTConditionalOperatorNodeInput))
                {
                    return global::ElevenLabs.SourceGenerationContextMetadata0FactoryBatch0000.Create_ASTConditionalOperatorNodeInput(options);
                }
                if (type == typeof(global::ElevenLabs.ASTDivisionOperatorNodeInput))
                {
                    return global::ElevenLabs.SourceGenerationContextMetadata0FactoryBatch0000.Create_ASTDivisionOperatorNodeInput(options);
                }
                if (type == typeof(global::ElevenLabs.ASTEqualsOperatorNodeInput))
                {
                    return global::ElevenLabs.SourceGenerationContextMetadata0FactoryBatch0001.Create_ASTEqualsOperatorNodeInput(options);
                }
                if (type == typeof(global::ElevenLabs.ASTGreaterThanOperatorNodeInput))
                {
                    return global::ElevenLabs.SourceGenerationContextMetadata0FactoryBatch0001.Create_ASTGreaterThanOperatorNodeInput(options);
                }
                if (type == typeof(global::ElevenLabs.ASTGreaterThanOrEqualsOperatorNodeInput))
                {
                    return global::ElevenLabs.SourceGenerationContextMetadata0FactoryBatch0001.Create_ASTGreaterThanOrEqualsOperatorNodeInput(options);
                }
                if (type == typeof(global::ElevenLabs.ASTLessThanOperatorNodeInput))
                {
                    return global::ElevenLabs.SourceGenerationContextMetadata0FactoryBatch0001.Create_ASTLessThanOperatorNodeInput(options);
                }
                if (type == typeof(global::ElevenLabs.ASTLessThanOrEqualsOperatorNodeInput))
                {
                    return global::ElevenLabs.SourceGenerationContextMetadata0FactoryBatch0001.Create_ASTLessThanOrEqualsOperatorNodeInput(options);
                }
                if (type == typeof(global::ElevenLabs.ASTMultiplicationOperatorNodeInput))
                {
                    return global::ElevenLabs.SourceGenerationContextMetadata0FactoryBatch0002.Create_ASTMultiplicationOperatorNodeInput(options);
                }
                if (type == typeof(global::ElevenLabs.ASTNodeInput))
                {
                    return global::ElevenLabs.SourceGenerationContextMetadata0FactoryBatch0002.Create_ASTNodeInput2(options);
                }
                if (type == typeof(global::ElevenLabs.ASTNotEqualsOperatorNodeInput))
                {
                    return global::ElevenLabs.SourceGenerationContextMetadata0FactoryBatch0002.Create_ASTNotEqualsOperatorNodeInput(options);
                }
                if (type == typeof(global::ElevenLabs.ASTOrOperatorNodeInput))
                {
                    return global::ElevenLabs.SourceGenerationContextMetadata0FactoryBatch0002.Create_ASTOrOperatorNodeInput(options);
                }
                if (type == typeof(global::ElevenLabs.ASTSubtractionOperatorNodeInput))
                {
                    return global::ElevenLabs.SourceGenerationContextMetadata0FactoryBatch0003.Create_ASTSubtractionOperatorNodeInput(options);
                }
                if (type == typeof(global::System.Collections.Generic.IList<global::ElevenLabs.ASTNodeInput>))
                {
                    return global::ElevenLabs.SourceGenerationContextMetadata0FactoryBatch0186.Create_SourceGenerationContextMetadataType_6EF5E0FE9F74B870(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::ElevenLabs.ASTNodeInput>))
                {
                    return global::ElevenLabs.SourceGenerationContextMetadata0FactoryBatch0169.Create_SourceGenerationContextMetadataType_18F9B20DD805F230(options);
                }
                if (type == typeof(global::ElevenLabs.ASTNodeInput?))
                {
                    return global::ElevenLabs.SourceGenerationContextMetadata0FactoryBatch0096.Create_NullableASTNodeInput2(options);
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