
#nullable enable
namespace ElevenLabs
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_05C7AB5B34415A9F
    {

        internal static readonly global::ElevenLabs.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::ElevenLabs.SourceGenerationContextMetadataScope>[] {
                    static () => global::ElevenLabs.SourceGenerationContextComponent_305DE77F26EC7431.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_5B5D39E88015ED55.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_6A0A9B85ECB07320.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_762EF1081DA0277D.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_AC7FBE80FCABBD3D.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::ElevenLabs.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::ElevenLabs.JsonConverters.TemplateInputReferenceJsonConverter>(static () => new global::ElevenLabs.JsonConverters.TemplateInputReferenceJsonConverter());
            collector.AddEager<global::ElevenLabs.JsonConverters.UnixTimestampJsonConverter>(static () => new global::ElevenLabs.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::ElevenLabs.TemplateInputReference))
                {
                    return global::ElevenLabs.SourceGenerationContextMetadata0FactoryBatch0232.Create_TemplateInputReference2(options);
                }
                if (type == typeof(global::ElevenLabs.TemplateInputReference?))
                {
                    return global::ElevenLabs.SourceGenerationContextMetadata0FactoryBatch0133.Create_NullableTemplateInputReference2(options);
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