
#nullable enable
namespace ElevenLabs.Realtime
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    public sealed partial class RealtimeSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {

        internal static global::ElevenLabs.Realtime.RealtimeSourceGenerationContextMetadataScope MetadataScope => ScopeHolder.Value;
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => MetadataScope;
        private static class ScopeHolder
        {
            internal static readonly global::ElevenLabs.Realtime.RealtimeSourceGenerationContextMetadataScope Value = new(
                null,
                new global::System.Func<global::ElevenLabs.Realtime.RealtimeSourceGenerationContextMetadataScope>[] {
                    static () => global::ElevenLabs.Realtime.RealtimeSourceGenerationContextComponent_B760F44FA5965C24.MetadataScope,                    static () => global::ElevenLabs.Realtime.RealtimeSourceGenerationContextComponent_2CE06A9E7F8C3E6B.MetadataScope,                    static () => global::ElevenLabs.Realtime.RealtimeSourceGenerationContextComponent_8654C363EBB03B9F.MetadataScope,                    static () => global::ElevenLabs.Realtime.RealtimeSourceGenerationContextComponent_D6C419C25C532B3D.MetadataScope,                    static () => global::ElevenLabs.Realtime.RealtimeSourceGenerationContextComponent_1791A6590553071C.MetadataScope,                    static () => global::ElevenLabs.Realtime.RealtimeSourceGenerationContextComponent_8D6801BC7059E12A.MetadataScope,                    static () => global::ElevenLabs.Realtime.RealtimeSourceGenerationContextComponent_20860E292D2AFFC4.MetadataScope,                    static () => global::ElevenLabs.Realtime.RealtimeSourceGenerationContextComponent_D74BE2DF133727AE.MetadataScope,                    static () => global::ElevenLabs.Realtime.RealtimeSourceGenerationContextComponent_B39640CCC9FC3212.MetadataScope,                    static () => global::ElevenLabs.Realtime.RealtimeSourceGenerationContextComponent_55A161933BEEFB14.MetadataScope,                    static () => global::ElevenLabs.Realtime.RealtimeSourceGenerationContextComponent_318982751006B693.MetadataScope,                    static () => global::ElevenLabs.Realtime.RealtimeSourceGenerationContextComponent_7DD7227E6E90BF01.MetadataScope,                    static () => global::ElevenLabs.Realtime.RealtimeSourceGenerationContextComponent_DC1370134BA9FB1C.MetadataScope,                    static () => global::ElevenLabs.Realtime.RealtimeSourceGenerationContextComponent_EE92ECA8488CDCE9.MetadataScope,                    static () => global::ElevenLabs.Realtime.RealtimeSourceGenerationContextComponent_233FB25A2E483D07.MetadataScope,                    static () => global::ElevenLabs.Realtime.RealtimeSourceGenerationContextComponent_11EF339D108D9764.MetadataScope,                    static () => global::ElevenLabs.Realtime.RealtimeSourceGenerationContextComponent_CC96F45A1184CE4D.MetadataScope,                    static () => global::ElevenLabs.Realtime.RealtimeSourceGenerationContextComponent_101DDDC1AE57E168.MetadataScope,                    static () => global::ElevenLabs.Realtime.RealtimeSourceGenerationContextComponent_344E66F7146E1CF4.MetadataScope,                    static () => global::ElevenLabs.Realtime.RealtimeSourceGenerationContextComponent_4E92F6F83EFA0996.MetadataScope,                    static () => global::ElevenLabs.Realtime.RealtimeSourceGenerationContextComponent_4EFE2E4FA269E026.MetadataScope,                    static () => global::ElevenLabs.Realtime.RealtimeSourceGenerationContextComponent_05BF36C073875770.MetadataScope,                    static () => global::ElevenLabs.Realtime.RealtimeSourceGenerationContextComponent_6DA88C34BA124C41.MetadataScope,                    static () => global::ElevenLabs.Realtime.RealtimeSourceGenerationContextComponent_473287F8298DBA71.MetadataScope,
                }, null);
        }
        private static class DefaultHolder
        {
            internal static readonly global::System.Text.Json.JsonSerializerOptions Options = MetadataScope.CreateOptions();
            internal static readonly RealtimeSourceGenerationContext Instance = new(Options);
        }
        /// <summary>The default context for this scope.</summary>
        public static RealtimeSourceGenerationContext Default => DefaultHolder.Instance;
        private RealtimeSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options) : base(options) { }
        /// <inheritdoc />
        protected override global::System.Text.Json.JsonSerializerOptions? GeneratedSerializerOptions => DefaultHolder.Options;
        /// <inheritdoc />
        public override global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(global::System.Type type) =>
            MetadataScope.GetTypeInfo(type, Options);

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

    }
}