
#nullable enable
namespace ElevenLabs
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_65D79AEDDA00AB86
    {

        internal static readonly global::ElevenLabs.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::ElevenLabs.SourceGenerationContextMetadataScope>[] {
                    static () => global::ElevenLabs.SourceGenerationContextComponent_31DAAFADF99D605B.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_544A4D30653EAC4D.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_6BD053DDCB13FCBD.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_B2BA9DD5D77CE075.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::ElevenLabs.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::ElevenLabs.JsonConverters.GetPhoneNumberRouteResponseJsonConverter>(static () => new global::ElevenLabs.JsonConverters.GetPhoneNumberRouteResponseJsonConverter());
            collector.AddEager<global::ElevenLabs.JsonConverters.UnixTimestampJsonConverter>(static () => new global::ElevenLabs.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::ElevenLabs.GetPhoneNumberRouteResponse))
                {
                    return global::ElevenLabs.SourceGenerationContextMetadata0FactoryBatch0074.Create_GetPhoneNumberRouteResponse2(options);
                }
                if (type == typeof(global::ElevenLabs.GetPhoneNumberRouteResponse?))
                {
                    return global::ElevenLabs.SourceGenerationContextMetadata0FactoryBatch0114.Create_NullableGetPhoneNumberRouteResponse2(options);
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