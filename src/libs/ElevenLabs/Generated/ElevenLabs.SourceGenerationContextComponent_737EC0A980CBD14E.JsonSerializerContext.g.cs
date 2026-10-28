
#nullable enable
namespace ElevenLabs
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_737EC0A980CBD14E
    {

        internal static readonly global::ElevenLabs.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::ElevenLabs.SourceGenerationContextMetadataScope>[] {
                    static () => global::ElevenLabs.SourceGenerationContextComponent_046ADFFC77F60686.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_059B573B148B83EB.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_0B7965F7DCB94E9C.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_44659B0A0C5B0790.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_4B1768F011D5DFB7.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_4E59E475DBA1594D.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_593A47E47F329EDE.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_5F6D60615B1D1A14.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_6C9161A85F254228.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_825015F42A9C0667.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_92FECC139630E7A5.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_9A8FB441E506E607.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_9EEFEC1156EA3412.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_AD2B6B767E1F565D.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_B4B07EB385647852.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_B83551101C160EC4.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_D328E2272A7D1B76.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_DBEEE15F0E8596E1.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_E6E7FCE1842F418F.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_E87801891A25DC66.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_EBFCC76C26499957.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_F04068AB701AB6AE.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::ElevenLabs.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::ElevenLabs.JsonConverters.ResultVariant1JsonConverter>(static () => new global::ElevenLabs.JsonConverters.ResultVariant1JsonConverter());
            collector.AddEager<global::ElevenLabs.JsonConverters.UnixTimestampJsonConverter>(static () => new global::ElevenLabs.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::ElevenLabs.ResultVariant1))
                {
                    return global::ElevenLabs.SourceGenerationContextMetadata0FactoryBatch0163.Create_ResultVariant1(options);
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