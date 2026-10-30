
#nullable enable
namespace ElevenLabs
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_F681122DBEF4055D
    {

        internal static readonly global::ElevenLabs.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::ElevenLabs.SourceGenerationContextMetadataScope>[] {
                    static () => global::ElevenLabs.SourceGenerationContextComponent_02F1327EA86273F2.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_05373C23FDDC7F23.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_4DC9341620EA10C8.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_9D9869A2E3BAD251.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_D2EF18019920266E.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::ElevenLabs.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::ElevenLabs.JsonConverters.ToolConfigJsonConverter>(static () => new global::ElevenLabs.JsonConverters.ToolConfigJsonConverter());
            collector.AddEager<global::ElevenLabs.JsonConverters.UnixTimestampJsonConverter>(static () => new global::ElevenLabs.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::ElevenLabs.ToolConfig))
                {
                    return global::ElevenLabs.SourceGenerationContextMetadata0FactoryBatch0240.Create_ToolConfig2_3(options);
                }
                if (type == typeof(global::ElevenLabs.ToolConfig?))
                {
                    return global::ElevenLabs.SourceGenerationContextMetadata0FactoryBatch0136.Create_NullableToolConfig2_3(options);
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