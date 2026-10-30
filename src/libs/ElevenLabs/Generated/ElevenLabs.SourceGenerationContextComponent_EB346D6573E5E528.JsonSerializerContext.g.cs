
#nullable enable
namespace ElevenLabs
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_EB346D6573E5E528
    {

        internal static readonly global::ElevenLabs.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::ElevenLabs.SourceGenerationContextMetadataScope>[] {
                    static () => global::ElevenLabs.SourceGenerationContextComponent_473287F8298DBA71.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_D1DD9BFE79BD1F55.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_EA16F7EE34795607.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::ElevenLabs.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, global::ElevenLabs.EnvironmentVariableSecretValueRequest, global::ElevenLabs.EnvironmentVariableAuthConnectionValueRequest>>(static () => new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<string, global::ElevenLabs.EnvironmentVariableSecretValueRequest, global::ElevenLabs.EnvironmentVariableAuthConnectionValueRequest>());
            collector.AddEager<global::ElevenLabs.JsonConverters.UnixTimestampJsonConverter>(static () => new global::ElevenLabs.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::ElevenLabs.AnyOf<string, global::ElevenLabs.EnvironmentVariableSecretValueRequest, global::ElevenLabs.EnvironmentVariableAuthConnectionValueRequest>))
                {
                    return global::ElevenLabs.SourceGenerationContextMetadata0FactoryBatch0224.Create_SourceGenerationContextMetadataType_EB346D6573E5E528(options);
                }
                if (type == typeof(global::ElevenLabs.AnyOf<string, global::ElevenLabs.EnvironmentVariableSecretValueRequest, global::ElevenLabs.EnvironmentVariableAuthConnectionValueRequest>?))
                {
                    return global::ElevenLabs.SourceGenerationContextMetadata0FactoryBatch0204.Create_SourceGenerationContextMetadataType_89FFF1F983E30A67(options);
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