
#nullable enable
namespace ElevenLabs
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_69E7956908860853
    {

        internal static readonly global::ElevenLabs.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::ElevenLabs.SourceGenerationContextMetadataScope>[] {
                    static () => global::ElevenLabs.SourceGenerationContextComponent_07AE5AEE57A8A362.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_2F7439255DC13EEF.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_4AA79CE633CE70B5.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_5C8D8396C1655A1D.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_8762962E06A5EC2B.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_92232DB15F41205A.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_A6A99E9562EFD2B7.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_B21E61583923F841.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_D02387BC0D417FF7.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_DAFB6094A1E3075A.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_E9D196961845DA58.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_F10B9685CB3B3119.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::ElevenLabs.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::ElevenLabs.JsonConverters.EventsItemJsonConverter>(static () => new global::ElevenLabs.JsonConverters.EventsItemJsonConverter());
            collector.AddEager<global::ElevenLabs.JsonConverters.UnixTimestampJsonConverter>(static () => new global::ElevenLabs.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::ElevenLabs.EventsItem))
                {
                    return global::ElevenLabs.SourceGenerationContextMetadata0FactoryBatch0075.Create_EventsItem2(options);
                }
                if (type == typeof(global::ElevenLabs.EventsItem?))
                {
                    return global::ElevenLabs.SourceGenerationContextMetadata0FactoryBatch0130.Create_NullableEventsItem2(options);
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