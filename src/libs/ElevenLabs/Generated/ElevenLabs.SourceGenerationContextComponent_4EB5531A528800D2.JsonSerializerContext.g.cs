
#nullable enable
namespace ElevenLabs
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_4EB5531A528800D2
    {

        internal static readonly global::ElevenLabs.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::ElevenLabs.SourceGenerationContextMetadataScope>[] {
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::ElevenLabs.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEnum(typeof(global::ElevenLabs.TicketSubscribersChangedEventResponseAuthorDiscriminatorType), static () => new global::ElevenLabs.JsonConverters.TicketSubscribersChangedEventResponseAuthorDiscriminatorTypeJsonConverter());
            collector.AddEnum(typeof(global::ElevenLabs.TicketSubscribersChangedEventResponseAuthorDiscriminatorType?), static () => new global::ElevenLabs.JsonConverters.TicketSubscribersChangedEventResponseAuthorDiscriminatorTypeNullableJsonConverter());
            collector.AddEager<global::ElevenLabs.JsonConverters.UnixTimestampJsonConverter>(static () => new global::ElevenLabs.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::ElevenLabs.TicketSubscribersChangedEventResponseAuthorDiscriminatorType))
                {
                    return global::ElevenLabs.SourceGenerationContextMetadata0FactoryBatch0285.Create_TicketSubscribersChangedEventResponseAuthorDiscriminatorType2(options);
                }
                if (type == typeof(global::ElevenLabs.TicketSubscribersChangedEventResponseAuthorDiscriminatorType?))
                {
                    return global::ElevenLabs.SourceGenerationContextMetadata0FactoryBatch0157.Create_NullableTicketSubscribersChangedEventResponseAuthorDiscriminatorType2(options);
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