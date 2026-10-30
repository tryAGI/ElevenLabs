
#nullable enable
namespace ElevenLabs
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_A7A7D66A682A0F26
    {

        internal static readonly global::ElevenLabs.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::ElevenLabs.SourceGenerationContextMetadataScope>[] {
                    static () => global::ElevenLabs.SourceGenerationContextComponent_1E534CF851F0CA95.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_47E45E77EFE3C1F3.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_98AFE1A10B7D666B.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_A5D585A5636445B4.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_D7F9CA2B32C9D8CE.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_E6E21D46821F560B.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::ElevenLabs.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::ElevenLabs.DependenciesVariant1Item>, global::System.Collections.Generic.IList<global::ElevenLabs.DependenciesVariant2Item>, global::System.Collections.Generic.IList<global::ElevenLabs.DependentPhoneNumberIdentifier>>>(static () => new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::ElevenLabs.DependenciesVariant1Item>, global::System.Collections.Generic.IList<global::ElevenLabs.DependenciesVariant2Item>, global::System.Collections.Generic.IList<global::ElevenLabs.DependentPhoneNumberIdentifier>>());
            collector.AddEager<global::ElevenLabs.JsonConverters.UnixTimestampJsonConverter>(static () => new global::ElevenLabs.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::ElevenLabs.AnyOf<global::System.Collections.Generic.IList<global::ElevenLabs.DependenciesVariant1Item>, global::System.Collections.Generic.IList<global::ElevenLabs.DependenciesVariant2Item>, global::System.Collections.Generic.IList<global::ElevenLabs.DependentPhoneNumberIdentifier>>))
                {
                    return global::ElevenLabs.SourceGenerationContextMetadata0FactoryBatch0211.Create_SourceGenerationContextMetadataType_A7A7D66A682A0F26(options);
                }
                if (type == typeof(global::ElevenLabs.AnyOf<global::System.Collections.Generic.List<global::ElevenLabs.DependenciesVariant1Item>, global::System.Collections.Generic.List<global::ElevenLabs.DependenciesVariant2Item>, global::System.Collections.Generic.List<global::ElevenLabs.DependentPhoneNumberIdentifier>>))
                {
                    return global::ElevenLabs.SourceGenerationContextMetadata0FactoryBatch0188.Create_SourceGenerationContextMetadataType_3D1BBB4219925403(options);
                }
                if (type == typeof(global::ElevenLabs.AnyOf<global::System.Collections.Generic.IList<global::ElevenLabs.DependenciesVariant1Item>, global::System.Collections.Generic.IList<global::ElevenLabs.DependenciesVariant2Item>, global::System.Collections.Generic.IList<global::ElevenLabs.DependentPhoneNumberIdentifier>>?))
                {
                    return global::ElevenLabs.SourceGenerationContextMetadata0FactoryBatch0192.Create_SourceGenerationContextMetadataType_4CD13784B3467A1B(options);
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