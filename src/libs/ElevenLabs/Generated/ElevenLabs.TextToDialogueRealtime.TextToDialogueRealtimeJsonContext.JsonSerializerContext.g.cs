
#nullable enable
namespace ElevenLabs.TextToDialogueRealtime
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    public sealed partial class TextToDialogueRealtimeJsonContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {

        internal static global::ElevenLabs.TextToDialogueRealtime.TextToDialogueRealtimeJsonContextMetadataScope MetadataScope => ScopeHolder.Value;
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => MetadataScope;
        private static class ScopeHolder
        {
            internal static readonly global::ElevenLabs.TextToDialogueRealtime.TextToDialogueRealtimeJsonContextMetadataScope Value = new(
                null,
                new global::System.Func<global::ElevenLabs.TextToDialogueRealtime.TextToDialogueRealtimeJsonContextMetadataScope>[] {
                    static () => global::ElevenLabs.TextToDialogueRealtime.TextToDialogueRealtimeJsonContextComponent_B760F44FA5965C24.MetadataScope,                    static () => global::ElevenLabs.TextToDialogueRealtime.TextToDialogueRealtimeJsonContextComponent_2CE06A9E7F8C3E6B.MetadataScope,                    static () => global::ElevenLabs.TextToDialogueRealtime.TextToDialogueRealtimeJsonContextComponent_2B7042361A7F6BB5.MetadataScope,                    static () => global::ElevenLabs.TextToDialogueRealtime.TextToDialogueRealtimeJsonContextComponent_825AAB0184482842.MetadataScope,                    static () => global::ElevenLabs.TextToDialogueRealtime.TextToDialogueRealtimeJsonContextComponent_E47B2860122A7D75.MetadataScope,                    static () => global::ElevenLabs.TextToDialogueRealtime.TextToDialogueRealtimeJsonContextComponent_72832701EE7C753A.MetadataScope,                    static () => global::ElevenLabs.TextToDialogueRealtime.TextToDialogueRealtimeJsonContextComponent_10CAB764DC3294EF.MetadataScope,                    static () => global::ElevenLabs.TextToDialogueRealtime.TextToDialogueRealtimeJsonContextComponent_91194FEA58A0A8A9.MetadataScope,                    static () => global::ElevenLabs.TextToDialogueRealtime.TextToDialogueRealtimeJsonContextComponent_48E34CF644C9AE5A.MetadataScope,                    static () => global::ElevenLabs.TextToDialogueRealtime.TextToDialogueRealtimeJsonContextComponent_E8E2FBCB8E3ADB2F.MetadataScope,                    static () => global::ElevenLabs.TextToDialogueRealtime.TextToDialogueRealtimeJsonContextComponent_270BEC88F4C53F93.MetadataScope,                    static () => global::ElevenLabs.TextToDialogueRealtime.TextToDialogueRealtimeJsonContextComponent_9149AB9A065169C6.MetadataScope,                    static () => global::ElevenLabs.TextToDialogueRealtime.TextToDialogueRealtimeJsonContextComponent_9961997CE790293E.MetadataScope,                    static () => global::ElevenLabs.TextToDialogueRealtime.TextToDialogueRealtimeJsonContextComponent_A4BA5EAA2D7BC81F.MetadataScope,                    static () => global::ElevenLabs.TextToDialogueRealtime.TextToDialogueRealtimeJsonContextComponent_827998FE1115C670.MetadataScope,                    static () => global::ElevenLabs.TextToDialogueRealtime.TextToDialogueRealtimeJsonContextComponent_05BF36C073875770.MetadataScope,                    static () => global::ElevenLabs.TextToDialogueRealtime.TextToDialogueRealtimeJsonContextComponent_6DA88C34BA124C41.MetadataScope,                    static () => global::ElevenLabs.TextToDialogueRealtime.TextToDialogueRealtimeJsonContextComponent_473287F8298DBA71.MetadataScope,
                }, null);
        }
        private static class DefaultHolder
        {
            internal static readonly global::System.Text.Json.JsonSerializerOptions Options = MetadataScope.CreateOptions();
            internal static readonly TextToDialogueRealtimeJsonContext Instance = new(Options);
        }
        /// <summary>The default context for this scope.</summary>
        public static TextToDialogueRealtimeJsonContext Default => DefaultHolder.Instance;
        private TextToDialogueRealtimeJsonContext(global::System.Text.Json.JsonSerializerOptions options) : base(options) { }
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