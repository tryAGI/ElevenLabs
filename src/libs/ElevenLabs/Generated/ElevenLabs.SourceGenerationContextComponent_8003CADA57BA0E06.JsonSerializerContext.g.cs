
#nullable enable
namespace ElevenLabs
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_8003CADA57BA0E06
    {

        internal static readonly global::ElevenLabs.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::ElevenLabs.SourceGenerationContextMetadataScope>[] {
                    static () => global::ElevenLabs.SourceGenerationContextComponent_0B83FC8C6050B58B.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_0C9B9BA981FD303D.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_32E695AD235AB6BA.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_3AB4CB0AE90ECC2B.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_3FF8657257F129C4.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_473287F8298DBA71.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_58D69FDC38376E51.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_71237F0B823805D8.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_7FD59F7FE0280286.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_8CBC39DD7D008FCC.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_9573B7AC44307D2E.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_9DCFCE20771BBAC6.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_A05EDE220FE5E6BF.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_A1E44342F0C2446D.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_B1C5D6DD42FD1440.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_B760F44FA5965C24.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_C525D212C6D748DB.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_E2B70D428B9432E1.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_EA2D4459AF0BD58B.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_F30D2549A0DE5DAC.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::ElevenLabs.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::ElevenLabs.JsonConverters.UnixTimestampJsonConverter>(static () => new global::ElevenLabs.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::ElevenLabs.AgentPlatformSettingsRequestModel))
                {
                    return global::ElevenLabs.SourceGenerationContextMetadata0FactoryBatch0007.Create_AgentPlatformSettingsRequestModel(options);
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