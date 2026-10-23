
#nullable enable
namespace ElevenLabs
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_49855FA188C63348
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
            collector.AddEnum(typeof(global::ElevenLabs.BodyCreateStudioProjectV1StudioProjectsPostApplyTextNormalization), static () => new global::ElevenLabs.JsonConverters.BodyCreateStudioProjectV1StudioProjectsPostApplyTextNormalizationJsonConverter());
            collector.AddEnum(typeof(global::ElevenLabs.BodyCreateStudioProjectV1StudioProjectsPostApplyTextNormalization?), static () => new global::ElevenLabs.JsonConverters.BodyCreateStudioProjectV1StudioProjectsPostApplyTextNormalizationNullableJsonConverter());
            collector.AddEager<global::ElevenLabs.JsonConverters.UnixTimestampJsonConverter>(static () => new global::ElevenLabs.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::ElevenLabs.BodyCreateStudioProjectV1StudioProjectsPostApplyTextNormalization))
                {
                    return global::ElevenLabs.SourceGenerationContextMetadata0FactoryBatch0021.Create_BodyCreateStudioProjectV1StudioProjectsPostApplyTextNormalization2(options);
                }
                if (type == typeof(global::ElevenLabs.BodyCreateStudioProjectV1StudioProjectsPostApplyTextNormalization?))
                {
                    return global::ElevenLabs.SourceGenerationContextMetadata0FactoryBatch0099.Create_NullableBodyCreateStudioProjectV1StudioProjectsPostApplyTextNormalization2(options);
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