
#nullable enable
namespace ElevenLabs.TextToDialogueMultiContextRealtime
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    public sealed partial class TextToDialogueMultiContextRealtimeJsonContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {

        internal static global::ElevenLabs.TextToDialogueMultiContextRealtime.TextToDialogueMultiContextRealtimeJsonContextMetadataScope MetadataScope => ScopeHolder.Value;
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => MetadataScope;
        private static class ScopeHolder
        {
            internal static readonly global::ElevenLabs.TextToDialogueMultiContextRealtime.TextToDialogueMultiContextRealtimeJsonContextMetadataScope Value = new(
                null,
                new global::System.Func<global::ElevenLabs.TextToDialogueMultiContextRealtime.TextToDialogueMultiContextRealtimeJsonContextMetadataScope>[] {
                    static () => global::ElevenLabs.TextToDialogueMultiContextRealtime.TextToDialogueMultiContextRealtimeJsonContextComponent_B760F44FA5965C24.MetadataScope,                    static () => global::ElevenLabs.TextToDialogueMultiContextRealtime.TextToDialogueMultiContextRealtimeJsonContextComponent_2CE06A9E7F8C3E6B.MetadataScope,                    static () => global::ElevenLabs.TextToDialogueMultiContextRealtime.TextToDialogueMultiContextRealtimeJsonContextComponent_AEAC355F2EAB6119.MetadataScope,                    static () => global::ElevenLabs.TextToDialogueMultiContextRealtime.TextToDialogueMultiContextRealtimeJsonContextComponent_4C1769551F7F69EA.MetadataScope,                    static () => global::ElevenLabs.TextToDialogueMultiContextRealtime.TextToDialogueMultiContextRealtimeJsonContextComponent_5994A40CC6840DF8.MetadataScope,                    static () => global::ElevenLabs.TextToDialogueMultiContextRealtime.TextToDialogueMultiContextRealtimeJsonContextComponent_88BC87CCE3F66452.MetadataScope,                    static () => global::ElevenLabs.TextToDialogueMultiContextRealtime.TextToDialogueMultiContextRealtimeJsonContextComponent_96EC429B499EAB97.MetadataScope,                    static () => global::ElevenLabs.TextToDialogueMultiContextRealtime.TextToDialogueMultiContextRealtimeJsonContextComponent_77B5432CB70F5AEE.MetadataScope,                    static () => global::ElevenLabs.TextToDialogueMultiContextRealtime.TextToDialogueMultiContextRealtimeJsonContextComponent_9DA77C6C6A48ACBB.MetadataScope,                    static () => global::ElevenLabs.TextToDialogueMultiContextRealtime.TextToDialogueMultiContextRealtimeJsonContextComponent_F63A337AAC7AC0DB.MetadataScope,                    static () => global::ElevenLabs.TextToDialogueMultiContextRealtime.TextToDialogueMultiContextRealtimeJsonContextComponent_D15AD3B8539E1CE1.MetadataScope,                    static () => global::ElevenLabs.TextToDialogueMultiContextRealtime.TextToDialogueMultiContextRealtimeJsonContextComponent_4DD7695DA4D7E1FB.MetadataScope,                    static () => global::ElevenLabs.TextToDialogueMultiContextRealtime.TextToDialogueMultiContextRealtimeJsonContextComponent_F3FE67195B4ED374.MetadataScope,                    static () => global::ElevenLabs.TextToDialogueMultiContextRealtime.TextToDialogueMultiContextRealtimeJsonContextComponent_CF34C2C3884E94E7.MetadataScope,                    static () => global::ElevenLabs.TextToDialogueMultiContextRealtime.TextToDialogueMultiContextRealtimeJsonContextComponent_827998FE1115C670.MetadataScope,                    static () => global::ElevenLabs.TextToDialogueMultiContextRealtime.TextToDialogueMultiContextRealtimeJsonContextComponent_05BF36C073875770.MetadataScope,                    static () => global::ElevenLabs.TextToDialogueMultiContextRealtime.TextToDialogueMultiContextRealtimeJsonContextComponent_6DA88C34BA124C41.MetadataScope,                    static () => global::ElevenLabs.TextToDialogueMultiContextRealtime.TextToDialogueMultiContextRealtimeJsonContextComponent_473287F8298DBA71.MetadataScope,
                }, null);
        }
        private static class DefaultHolder
        {
            internal static readonly global::System.Text.Json.JsonSerializerOptions Options = MetadataScope.CreateOptions();
            internal static readonly TextToDialogueMultiContextRealtimeJsonContext Instance = new(Options);
        }
        /// <summary>The default context for this scope.</summary>
        public static TextToDialogueMultiContextRealtimeJsonContext Default => DefaultHolder.Instance;
        private TextToDialogueMultiContextRealtimeJsonContext(global::System.Text.Json.JsonSerializerOptions options) : base(options) { }
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