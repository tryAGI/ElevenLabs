
#nullable enable
namespace ElevenLabs.TextToDialogueMultiContextRealtime
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class TextToDialogueMultiContextRealtimeJsonContextComponent_CF34C2C3884E94E7
    {

        internal static readonly global::ElevenLabs.TextToDialogueMultiContextRealtime.TextToDialogueMultiContextRealtimeJsonContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::ElevenLabs.TextToDialogueMultiContextRealtime.TextToDialogueMultiContextRealtimeJsonContextMetadataScope>[] {
                    static () => global::ElevenLabs.TextToDialogueMultiContextRealtime.TextToDialogueMultiContextRealtimeJsonContextComponent_D15AD3B8539E1CE1.MetadataScope,
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
                if (type == typeof(global::System.Collections.Generic.IList<global::ElevenLabs.TextToDialogueMultiContextRealtime.TextToDialogueWebsocketVoiceInput>))
                {
                    return global::ElevenLabs.TextToDialogueMultiContextRealtime.TextToDialogueMultiContextRealtimeJsonContextMetadata0FactoryBatch0001.Create_TextToDialogueMultiContextRealtimeJsonContextMetadataType_CF34C2C3884E94E7(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::ElevenLabs.TextToDialogueMultiContextRealtime.TextToDialogueWebsocketVoiceInput>))
                {
                    return global::ElevenLabs.TextToDialogueMultiContextRealtime.TextToDialogueMultiContextRealtimeJsonContextMetadata0FactoryBatch0001.Create_TextToDialogueMultiContextRealtimeJsonContextMetadataType_232E8E14AA329ADA(options);
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