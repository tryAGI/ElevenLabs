
#nullable enable
namespace ElevenLabs
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_7B848DF4EC066324
    {

        internal static readonly global::ElevenLabs.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::ElevenLabs.SourceGenerationContextMetadataScope>[] {
                    static () => global::ElevenLabs.SourceGenerationContextComponent_064342CE56797D04.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_217DF97B33AA4E43.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_4670CD4761C88DDA.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_5BC79D3B4DF83704.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_7439E3FB6FFE316A.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_9D01B07CAAD0455D.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_E1F6AEB0BCEFD913.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::ElevenLabs.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::ElevenLabs.JsonConverters.NodesJsonConverter>(static () => new global::ElevenLabs.JsonConverters.NodesJsonConverter());
            collector.AddEager<global::ElevenLabs.JsonConverters.UnixTimestampJsonConverter>(static () => new global::ElevenLabs.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::ElevenLabs.Nodes))
                {
                    return global::ElevenLabs.SourceGenerationContextMetadata0FactoryBatch0097.Create_Nodes2_3(options);
                }
                if (type == typeof(global::ElevenLabs.Nodes?))
                {
                    return global::ElevenLabs.SourceGenerationContextMetadata0FactoryBatch0124.Create_NullableNodes2_3(options);
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