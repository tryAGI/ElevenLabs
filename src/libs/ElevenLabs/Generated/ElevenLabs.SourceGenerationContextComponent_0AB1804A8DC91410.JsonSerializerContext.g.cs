
#nullable enable
namespace ElevenLabs
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_0AB1804A8DC91410
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
            collector.AddEnum(typeof(global::ElevenLabs.PromptAgentAPIModelOutputToolDiscriminatorType), static () => new global::ElevenLabs.JsonConverters.PromptAgentAPIModelOutputToolDiscriminatorTypeJsonConverter());
            collector.AddEnum(typeof(global::ElevenLabs.PromptAgentAPIModelOutputToolDiscriminatorType?), static () => new global::ElevenLabs.JsonConverters.PromptAgentAPIModelOutputToolDiscriminatorTypeNullableJsonConverter());
            collector.AddEager<global::ElevenLabs.JsonConverters.UnixTimestampJsonConverter>(static () => new global::ElevenLabs.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::ElevenLabs.PromptAgentAPIModelOutputToolDiscriminatorType))
                {
                    return global::ElevenLabs.SourceGenerationContextMetadata0FactoryBatch0151.Create_PromptAgentAPIModelOutputToolDiscriminatorType2(options);
                }
                if (type == typeof(global::ElevenLabs.PromptAgentAPIModelOutputToolDiscriminatorType?))
                {
                    return global::ElevenLabs.SourceGenerationContextMetadata0FactoryBatch0124.Create_NullablePromptAgentAPIModelOutputToolDiscriminatorType2(options);
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