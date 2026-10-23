
#nullable enable
namespace ElevenLabs
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    public sealed partial class PartitionOrphan6SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {

        internal static global::ElevenLabs.SourceGenerationContextMetadataScope MetadataScope => ScopeHolder.Value;
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => MetadataScope;
        private static class ScopeHolder
        {
            internal static readonly global::ElevenLabs.SourceGenerationContextMetadataScope Value = new(
                null,
                new global::System.Func<global::ElevenLabs.SourceGenerationContextMetadataScope>[] {
                    static () => global::ElevenLabs.SourceGenerationContextComponent_3FCFA3212CF63930.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_9849B7A74A7373EB.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_6B3E82EE7850E936.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_7C6D68F116EA980F.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_F10D5149204380CA.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_A7584CC2AC70BC6F.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_2693EB9BDF3FD97A.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_3FBA47CF7D125837.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_7F8673F03C64BB06.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_2764FE788BB9809C.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_5E645B2D0C5B3A27.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_B643FB4335ABC7D8.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_05BF36C073875770.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_16D70ACA0D58A95C.MetadataScope,                    static () => global::ElevenLabs.PartitionCoreSourceGenerationContext.MetadataScope,
                }, ContributeConverters);
        }
        private static class DefaultHolder
        {
            internal static readonly global::System.Text.Json.JsonSerializerOptions Options = MetadataScope.CreateOptions();
            internal static readonly PartitionOrphan6SourceGenerationContext Instance = new(Options);
        }
        /// <summary>The default context for this scope.</summary>
        public static PartitionOrphan6SourceGenerationContext Default => DefaultHolder.Instance;
        private PartitionOrphan6SourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options) : base(options) { }
        /// <inheritdoc />
        protected override global::System.Text.Json.JsonSerializerOptions? GeneratedSerializerOptions => DefaultHolder.Options;
        /// <inheritdoc />
        public override global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(global::System.Type type) =>
            MetadataScope.GetTypeInfo(type, Options);

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::ElevenLabs.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEnum(typeof(global::ElevenLabs.GetSpeechHistorySortDirection), static () => new global::ElevenLabs.JsonConverters.GetSpeechHistorySortDirectionJsonConverter());
            collector.AddEnum(typeof(global::ElevenLabs.GetSpeechHistorySortDirection?), static () => new global::ElevenLabs.JsonConverters.GetSpeechHistorySortDirectionNullableJsonConverter());
            collector.AddEnum(typeof(global::ElevenLabs.GetSpeechHistorySource), static () => new global::ElevenLabs.JsonConverters.GetSpeechHistorySourceJsonConverter());
            collector.AddEnum(typeof(global::ElevenLabs.GetSpeechHistorySource?), static () => new global::ElevenLabs.JsonConverters.GetSpeechHistorySourceNullableJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

    }
}