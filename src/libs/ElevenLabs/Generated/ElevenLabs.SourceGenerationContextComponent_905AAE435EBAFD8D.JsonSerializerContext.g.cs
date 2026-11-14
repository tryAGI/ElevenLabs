
#nullable enable
namespace ElevenLabs
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_905AAE435EBAFD8D
    {

        internal static readonly global::ElevenLabs.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::ElevenLabs.SourceGenerationContextMetadataScope>[] {
                    static () => global::ElevenLabs.SourceGenerationContextComponent_30E50D3F1105795B.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_358C13E5F7E8A8E8.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_9EF6F066D2C4B25E.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_CE9481C622E45CB3.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_D31F751B35ED7478.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::ElevenLabs.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::ElevenLabs.JsonConverters.TransferDestination5JsonConverter>(static () => new global::ElevenLabs.JsonConverters.TransferDestination5JsonConverter());
            collector.AddEager<global::ElevenLabs.JsonConverters.UnixTimestampJsonConverter>(static () => new global::ElevenLabs.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::ElevenLabs.TransferDestination5))
                {
                    return global::ElevenLabs.SourceGenerationContextMetadata0FactoryBatch0278.Create_TransferDestination52(options);
                }
                if (type == typeof(global::ElevenLabs.TransferDestination5?))
                {
                    return global::ElevenLabs.SourceGenerationContextMetadata0FactoryBatch0155.Create_NullableTransferDestination52(options);
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