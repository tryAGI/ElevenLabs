
#nullable enable
namespace ElevenLabs.TextToDialogueRealtime
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class TextToDialogueRealtimeJsonContextComponent_E8E2FBCB8E3ADB2F
    {

        internal static readonly global::ElevenLabs.TextToDialogueRealtime.TextToDialogueRealtimeJsonContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::ElevenLabs.TextToDialogueRealtime.TextToDialogueRealtimeJsonContextMetadataScope>[] {
                    static () => global::ElevenLabs.TextToDialogueRealtime.TextToDialogueRealtimeJsonContextComponent_B760F44FA5965C24.MetadataScope,
                }, null);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::ElevenLabs.TextToDialogueRealtime.TextToDialogueWebsocketFinalAudioForTurn))
                {
                    return global::ElevenLabs.TextToDialogueRealtime.TextToDialogueRealtimeJsonContextMetadata0FactoryBatch0001.Create_TextToDialogueWebsocketFinalAudioForTurn(options);
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