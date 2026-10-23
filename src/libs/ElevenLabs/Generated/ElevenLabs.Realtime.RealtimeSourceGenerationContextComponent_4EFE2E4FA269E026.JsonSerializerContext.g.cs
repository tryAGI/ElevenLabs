
#nullable enable
namespace ElevenLabs.Realtime
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class RealtimeSourceGenerationContextComponent_4EFE2E4FA269E026
    {

        internal static readonly global::ElevenLabs.Realtime.RealtimeSourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::ElevenLabs.Realtime.RealtimeSourceGenerationContextMetadataScope>[] {
                    static () => global::ElevenLabs.Realtime.RealtimeSourceGenerationContextComponent_344E66F7146E1CF4.MetadataScope,
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
                if (type == typeof(global::System.Collections.Generic.IList<global::ElevenLabs.Realtime.TranscriptionWord>))
                {
                    return global::ElevenLabs.Realtime.RealtimeSourceGenerationContextMetadata0FactoryBatch0001.Create_RealtimeSourceGenerationContextMetadataType_4EFE2E4FA269E026(options);
                }
                if (type == typeof(global::System.Collections.Generic.List<global::ElevenLabs.Realtime.TranscriptionWord>))
                {
                    return global::ElevenLabs.Realtime.RealtimeSourceGenerationContextMetadata0FactoryBatch0001.Create_RealtimeSourceGenerationContextMetadataType_241C93FEEADCF5E9(options);
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