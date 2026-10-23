
#nullable enable
namespace ElevenLabs.Realtime
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class RealtimeSourceGenerationContextComponent_233FB25A2E483D07
    {

        internal static readonly global::ElevenLabs.Realtime.RealtimeSourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::ElevenLabs.Realtime.RealtimeSourceGenerationContextMetadataScope>[] {
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::ElevenLabs.Realtime.RealtimeSourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEnum(typeof(global::ElevenLabs.Realtime.ServerEventDiscriminatorMessageType), static () => new global::ElevenLabs.Realtime.JsonConverters.ServerEventDiscriminatorMessageTypeJsonConverter());
            collector.AddEnum(typeof(global::ElevenLabs.Realtime.ServerEventDiscriminatorMessageType?), static () => new global::ElevenLabs.Realtime.JsonConverters.ServerEventDiscriminatorMessageTypeNullableJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::ElevenLabs.Realtime.ServerEventDiscriminatorMessageType))
                {
                    return global::ElevenLabs.Realtime.RealtimeSourceGenerationContextMetadata0FactoryBatch0002.Create_ServerEventDiscriminatorMessageType2(options);
                }
                if (type == typeof(global::ElevenLabs.Realtime.ServerEventDiscriminatorMessageType?))
                {
                    return global::ElevenLabs.Realtime.RealtimeSourceGenerationContextMetadata0FactoryBatch0001.Create_NullableServerEventDiscriminatorMessageType2(options);
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