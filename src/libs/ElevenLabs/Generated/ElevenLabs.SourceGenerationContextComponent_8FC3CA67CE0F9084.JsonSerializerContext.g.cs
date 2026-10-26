
#nullable enable
namespace ElevenLabs
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_8FC3CA67CE0F9084
    {

        internal static readonly global::ElevenLabs.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::ElevenLabs.SourceGenerationContextMetadataScope>[] {
                    static () => global::ElevenLabs.SourceGenerationContextComponent_0562F0B782AF8C0B.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_145E3F47DDEF94D3.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_938E58D95F6D0169.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_A714474553776E46.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_AFA8BB8956849E47.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::ElevenLabs.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::ElevenLabs.JsonConverters.GetDocumentationFromKnowledgeBaseResponseJsonConverter>(static () => new global::ElevenLabs.JsonConverters.GetDocumentationFromKnowledgeBaseResponseJsonConverter());
            collector.AddEager<global::ElevenLabs.JsonConverters.UnixTimestampJsonConverter>(static () => new global::ElevenLabs.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::ElevenLabs.GetDocumentationFromKnowledgeBaseResponse))
                {
                    return global::ElevenLabs.SourceGenerationContextMetadata0FactoryBatch0072.Create_GetDocumentationFromKnowledgeBaseResponse2(options);
                }
                if (type == typeof(global::ElevenLabs.GetDocumentationFromKnowledgeBaseResponse?))
                {
                    return global::ElevenLabs.SourceGenerationContextMetadata0FactoryBatch0114.Create_NullableGetDocumentationFromKnowledgeBaseResponse2(options);
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