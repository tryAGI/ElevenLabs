
#nullable enable
namespace ElevenLabs
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_1D7314931637BAF1
    {

        internal static readonly global::ElevenLabs.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::ElevenLabs.SourceGenerationContextMetadataScope>[] {
                    static () => global::ElevenLabs.SourceGenerationContextComponent_31E1C08D886ACFFA.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_42418CC00A385122.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_6CDA9762EDFF887A.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::ElevenLabs.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::ElevenLabs.JsonConverters.PostKnowledgeBaseBulkDeleteRouteResponse2JsonConverter>(static () => new global::ElevenLabs.JsonConverters.PostKnowledgeBaseBulkDeleteRouteResponse2JsonConverter());
            collector.AddEager<global::ElevenLabs.JsonConverters.UnixTimestampJsonConverter>(static () => new global::ElevenLabs.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::ElevenLabs.PostKnowledgeBaseBulkDeleteRouteResponse2))
                {
                    return global::ElevenLabs.SourceGenerationContextMetadata0FactoryBatch0148.Create_PostKnowledgeBaseBulkDeleteRouteResponse22(options);
                }
                if (type == typeof(global::ElevenLabs.PostKnowledgeBaseBulkDeleteRouteResponse2?))
                {
                    return global::ElevenLabs.SourceGenerationContextMetadata0FactoryBatch0123.Create_NullablePostKnowledgeBaseBulkDeleteRouteResponse22(options);
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