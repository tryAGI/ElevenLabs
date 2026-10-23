
#nullable enable
namespace ElevenLabs
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_67B995394F5AAE50
    {

        internal static readonly global::ElevenLabs.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::ElevenLabs.SourceGenerationContextMetadataScope>[] {
                    static () => global::ElevenLabs.SourceGenerationContextComponent_6B6B4BC3154FC93F.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_6CF24CAE37093626.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_9BE35E8C5FC5BF28.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_A8D7339FC5407514.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_AF1A45291971F88F.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_C3413DCB7754979B.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_DD4173C8FC47D0F5.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::ElevenLabs.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.CreateOAuth2ClientCredsRequest, global::ElevenLabs.CreateCustomHeaderAuthRequest, global::ElevenLabs.CreateBasicAuthRequest, global::ElevenLabs.CreateBearerAuthRequest, global::ElevenLabs.CreateOAuth2JWTRequest, global::ElevenLabs.CreatePrivateKeyJWTRequest, global::ElevenLabs.CreateMTLSAuthRequest>>(static () => new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.CreateOAuth2ClientCredsRequest, global::ElevenLabs.CreateCustomHeaderAuthRequest, global::ElevenLabs.CreateBasicAuthRequest, global::ElevenLabs.CreateBearerAuthRequest, global::ElevenLabs.CreateOAuth2JWTRequest, global::ElevenLabs.CreatePrivateKeyJWTRequest, global::ElevenLabs.CreateMTLSAuthRequest>());
            collector.AddEager<global::ElevenLabs.JsonConverters.UnixTimestampJsonConverter>(static () => new global::ElevenLabs.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::ElevenLabs.AnyOf<global::ElevenLabs.CreateOAuth2ClientCredsRequest, global::ElevenLabs.CreateCustomHeaderAuthRequest, global::ElevenLabs.CreateBasicAuthRequest, global::ElevenLabs.CreateBearerAuthRequest, global::ElevenLabs.CreateOAuth2JWTRequest, global::ElevenLabs.CreatePrivateKeyJWTRequest, global::ElevenLabs.CreateMTLSAuthRequest>))
                {
                    return global::ElevenLabs.SourceGenerationContextMetadata0FactoryBatch0184.Create_SourceGenerationContextMetadataType_67B995394F5AAE50(options);
                }
                if (type == typeof(global::ElevenLabs.AnyOf<global::ElevenLabs.CreateOAuth2ClientCredsRequest, global::ElevenLabs.CreateCustomHeaderAuthRequest, global::ElevenLabs.CreateBasicAuthRequest, global::ElevenLabs.CreateBearerAuthRequest, global::ElevenLabs.CreateOAuth2JWTRequest, global::ElevenLabs.CreatePrivateKeyJWTRequest, global::ElevenLabs.CreateMTLSAuthRequest>?))
                {
                    return global::ElevenLabs.SourceGenerationContextMetadata0FactoryBatch0164.Create_SourceGenerationContextMetadataType_086A6AB1C4CB6ED6(options);
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