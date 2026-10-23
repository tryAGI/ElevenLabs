
#nullable enable
namespace ElevenLabs.TextToDialogueMultiContextRealtime
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class TextToDialogueMultiContextRealtimeJsonContextComponent_F3FE67195B4ED374
    {

        internal static readonly global::ElevenLabs.TextToDialogueMultiContextRealtime.TextToDialogueMultiContextRealtimeJsonContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::ElevenLabs.TextToDialogueMultiContextRealtime.TextToDialogueMultiContextRealtimeJsonContextMetadataScope>[] {
                    static () => global::ElevenLabs.TextToDialogueMultiContextRealtime.TextToDialogueMultiContextRealtimeJsonContextComponent_4C1769551F7F69EA.MetadataScope,
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
                if (type == typeof(global::System.Collections.Generic.IList<global::ElevenLabs.TextToDialogueMultiContextRealtime.PronunciationDictionaryLocator>))
                {
                    return global::ElevenLabs.TextToDialogueMultiContextRealtime.TextToDialogueMultiContextRealtimeJsonContextMetadata0FactoryBatch0001.Create_TextToDialogueMultiContextRealtimeJsonContextMetadataType_F3FE67195B4ED374(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::ElevenLabs.TextToDialogueMultiContextRealtime.PronunciationDictionaryLocator>))
                {
                    return global::ElevenLabs.TextToDialogueMultiContextRealtime.TextToDialogueMultiContextRealtimeJsonContextMetadata0FactoryBatch0001.Create_TextToDialogueMultiContextRealtimeJsonContextMetadataType_215549B70FC2F03B(options);
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