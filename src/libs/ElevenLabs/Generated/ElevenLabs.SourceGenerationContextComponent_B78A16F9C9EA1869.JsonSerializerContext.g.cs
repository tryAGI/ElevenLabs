
#nullable enable
namespace ElevenLabs
{
    /// <summary>Source-generated JSON metadata for this scope.</summary>
    internal static partial class SourceGenerationContextComponent_B78A16F9C9EA1869
    {

        internal static readonly global::ElevenLabs.SourceGenerationContextMetadataScope MetadataScope = new(
                new SharedMetadataResolver(),
                new global::System.Func<global::ElevenLabs.SourceGenerationContextMetadataScope>[] {
                    static () => global::ElevenLabs.SourceGenerationContextComponent_05A4A4A298710497.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_05BF36C073875770.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_1287000F738EC84D.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_32EED9F3016C4051.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_473287F8298DBA71.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_681A11E69F9080CB.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_85B95FB9201F241C.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_C2CA0B60E240B3D1.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_C6D6414AA4E26C44.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_E29D02AC4B3701AD.MetadataScope,                    static () => global::ElevenLabs.SourceGenerationContextComponent_F2D31BE02B21961D.MetadataScope,
                }, ContributeConverters);
        internal static global::System.Text.Json.Serialization.JsonSerializerContext Default => MetadataScope.Default;

        /// <summary>Adds converters required by this scope.</summary>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options) => MetadataScope.AddConverters(options);

        #pragma warning disable CS0612, CS0618 // Generated converters may target deprecated API models.
        private static void ContributeConverters(global::ElevenLabs.SourceGenerationContextMetadataScope.ConverterCollector collector)
        {
            collector.AddEager<global::ElevenLabs.JsonConverters.ContentSchemaJsonConverter>(static () => new global::ElevenLabs.JsonConverters.ContentSchemaJsonConverter());
            collector.AddEager<global::ElevenLabs.JsonConverters.UnixTimestampJsonConverter>(static () => new global::ElevenLabs.JsonConverters.UnixTimestampJsonConverter());
        }
        #pragma warning restore CS0612, CS0618

        private sealed partial class SharedMetadataResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type, global::System.Text.Json.JsonSerializerOptions options)
            {
                if (type == typeof(global::ElevenLabs.ArraySchema))
                {
                    return global::ElevenLabs.SourceGenerationContextMetadata0FactoryBatch0013.Create_ArraySchema(options);
                }
                if (type == typeof(global::ElevenLabs.ContentSchema))
                {
                    return global::ElevenLabs.SourceGenerationContextMetadata0FactoryBatch0038.Create_ContentSchema2(options);
                }
                if (type == typeof(global::ElevenLabs.ObjectSchema))
                {
                    return global::ElevenLabs.SourceGenerationContextMetadata0FactoryBatch0144.Create_ObjectSchema(options);
                }
                if (type == typeof(global::System.Collections.Generic.Dictionary<string, global::ElevenLabs.ContentSchema>))
                {
                    return global::ElevenLabs.SourceGenerationContextMetadata0FactoryBatch0207.Create_SourceGenerationContextMetadataType_A75EB51312C893EE(options);
                }
                if (type == typeof(global::ElevenLabs.ContentSchema?))
                {
                    return global::ElevenLabs.SourceGenerationContextMetadata0FactoryBatch0107.Create_NullableContentSchema2(options);
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