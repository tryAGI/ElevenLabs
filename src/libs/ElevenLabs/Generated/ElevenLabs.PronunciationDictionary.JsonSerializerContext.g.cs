
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull
    )]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>), TypeInfoPropertyName = "IListString_System_Collections_Generic_IList_string")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string?>), TypeInfoPropertyName = "IListString_System_Collections_Generic_IList_string_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>), TypeInfoPropertyName = "ListString_System_Collections_Generic_List_string")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string?>), TypeInfoPropertyName = "ListString_System_Collections_Generic_List_string_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AddPronunciationDictionaryResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AddPronunciationDictionaryResponseModelPermissionOnResource), TypeInfoPropertyName = "AddPronunciationDictionaryResponseModelPermissionOnResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyAddAPronunciationDictionaryV1PronunciationDictionariesAddFromFilePost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyAddAPronunciationDictionaryV1PronunciationDictionariesAddFromFilePostWorkspaceAccess), TypeInfoPropertyName = "BodyAddAPronunciationDictionaryV1PronunciationDictionariesAddFromFilePostWorkspaceAccess2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyAddAPronunciationDictionaryV1PronunciationDictionariesAddFromRulesPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.AnyOf<global::ElevenLabs.PronunciationDictionaryAliasRuleRequestModel, global::ElevenLabs.PronunciationDictionaryPhonemeRuleRequestModel>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AnyOf<global::ElevenLabs.PronunciationDictionaryAliasRuleRequestModel, global::ElevenLabs.PronunciationDictionaryPhonemeRuleRequestModel>), TypeInfoPropertyName = "AnyOfPronunciationDictionaryAliasRuleRequestModelPronunciationDictionaryPhonemeRuleRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.PronunciationDictionaryAliasRuleRequestModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.PronunciationDictionaryPhonemeRuleRequestModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyAddAPronunciationDictionaryV1PronunciationDictionariesAddFromRulesPostWorkspaceAccess), TypeInfoPropertyName = "BodyAddAPronunciationDictionaryV1PronunciationDictionariesAddFromRulesPostWorkspaceAccess2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyAddRulesToThePronunciationDictionaryV1PronunciationDictionariesPronunciationDictionaryIdAddRulesPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyRemoveRulesFromThePronunciationDictionaryV1PronunciationDictionariesPronunciationDictionaryIdRemoveRulesPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodySetRulesOnThePronunciationDictionaryV1PronunciationDictionariesPronunciationDictionaryIdSetRulesPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyUpdatePronunciationDictionaryV1PronunciationDictionariesPronunciationDictionaryIdPatch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetPronunciationDictionariesMetadataResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.GetPronunciationDictionaryMetadataResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetPronunciationDictionaryMetadataResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetPronunciationDictionaryMetadataResponseModelPermissionOnResource), TypeInfoPropertyName = "GetPronunciationDictionaryMetadataResponseModelPermissionOnResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetPronunciationDictionaryWithRulesResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetPronunciationDictionaryWithRulesResponseModelPermissionOnResource), TypeInfoPropertyName = "GetPronunciationDictionaryWithRulesResponseModelPermissionOnResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.AnyOf<global::ElevenLabs.PronunciationDictionaryAliasRuleResponseModel, global::ElevenLabs.PronunciationDictionaryPhonemeRuleResponseModel>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AnyOf<global::ElevenLabs.PronunciationDictionaryAliasRuleResponseModel, global::ElevenLabs.PronunciationDictionaryPhonemeRuleResponseModel>), TypeInfoPropertyName = "AnyOfPronunciationDictionaryAliasRuleResponseModelPronunciationDictionaryPhonemeRuleResponseModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.PronunciationDictionaryAliasRuleResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.PronunciationDictionaryPhonemeRuleResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.PronunciationDictionaryRulesResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetPronunciationDictionariesMetadataSort), TypeInfoPropertyName = "GetPronunciationDictionariesMetadataSort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AddPronunciationDictionaryResponseModelPermissionOnResource?), TypeInfoPropertyName = "NullableAddPronunciationDictionaryResponseModelPermissionOnResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyAddAPronunciationDictionaryV1PronunciationDictionariesAddFromFilePostWorkspaceAccess?), TypeInfoPropertyName = "NullableBodyAddAPronunciationDictionaryV1PronunciationDictionariesAddFromFilePostWorkspaceAccess2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AnyOf<global::ElevenLabs.PronunciationDictionaryAliasRuleRequestModel, global::ElevenLabs.PronunciationDictionaryPhonemeRuleRequestModel>?), TypeInfoPropertyName = "NullableAnyOfPronunciationDictionaryAliasRuleRequestModelPronunciationDictionaryPhonemeRuleRequestModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyAddAPronunciationDictionaryV1PronunciationDictionariesAddFromRulesPostWorkspaceAccess?), TypeInfoPropertyName = "NullableBodyAddAPronunciationDictionaryV1PronunciationDictionariesAddFromRulesPostWorkspaceAccess2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetPronunciationDictionaryMetadataResponseModelPermissionOnResource?), TypeInfoPropertyName = "NullableGetPronunciationDictionaryMetadataResponseModelPermissionOnResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetPronunciationDictionaryWithRulesResponseModelPermissionOnResource?), TypeInfoPropertyName = "NullableGetPronunciationDictionaryWithRulesResponseModelPermissionOnResource2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.AnyOf<global::ElevenLabs.PronunciationDictionaryAliasRuleResponseModel, global::ElevenLabs.PronunciationDictionaryPhonemeRuleResponseModel>?), TypeInfoPropertyName = "NullableAnyOfPronunciationDictionaryAliasRuleResponseModelPronunciationDictionaryPhonemeRuleResponseModel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.GetPronunciationDictionariesMetadataSort?), TypeInfoPropertyName = "NullableGetPronunciationDictionariesMetadataSort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.AnyOf<global::ElevenLabs.PronunciationDictionaryAliasRuleRequestModel, global::ElevenLabs.PronunciationDictionaryPhonemeRuleRequestModel>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.GetPronunciationDictionaryMetadataResponseModel>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.AnyOf<global::ElevenLabs.PronunciationDictionaryAliasRuleResponseModel, global::ElevenLabs.PronunciationDictionaryPhonemeRuleResponseModel>>))]
    internal sealed partial class PronunciationDictionarySourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PronunciationDictionarySourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static PronunciationDictionarySourceGenerationContext Default { get; } = new(DefaultOptions);

        private PronunciationDictionarySourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
            : base(options)
        {
        }

        /// <inheritdoc />
        protected override global::System.Text.Json.JsonSerializerOptions? GeneratedSerializerOptions => DefaultOptions;

        /// <inheritdoc />
        public override global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(global::System.Type type)
        {
            return Resolver.GetTypeInfo(type, Options);
        }

        /// <summary>
        /// Adds this package's converters to <paramref name="options"/>.
        /// </summary>
        /// <remarks>
        /// A converter has to be on the options a chained resolver builds its JsonTypeInfo against,
        /// and a context resolves types from every package below it. Each package contributes only
        /// what it owns and calls down the chain for the rest, so the family's converter table is
        /// written once rather than copied into all of them.
        /// </remarks>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options)
        {
            global::ElevenLabs.PartitionCoreSourceGenerationContext.AddConverters(options);
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.PronunciationDictionaryAliasRuleRequestModel, global::ElevenLabs.PronunciationDictionaryPhonemeRuleRequestModel>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.PronunciationDictionaryAliasRuleRequestModel, global::ElevenLabs.PronunciationDictionaryPhonemeRuleRequestModel>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.PronunciationDictionaryAliasRuleRequestModel, global::ElevenLabs.PronunciationDictionaryPhonemeRuleRequestModel>());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.PronunciationDictionaryAliasRuleResponseModel, global::ElevenLabs.PronunciationDictionaryPhonemeRuleResponseModel>());
            options.Converters.Add(new LazyEnumJsonConverterFactory());
        }

        private static global::System.Text.Json.JsonSerializerOptions CreateDefaultOptions()
        {
            var options = new global::System.Text.Json.JsonSerializerOptions
            {
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                TypeInfoResolver = Resolver,
            };
            AddConverters(options);

            return options;
        }


        private sealed class LazyEnumJsonConverterFactory : global::System.Text.Json.Serialization.JsonConverterFactory
        {
            public override bool CanConvert(global::System.Type typeToConvert)
            {
                return
                    typeToConvert == typeof(global::ElevenLabs.AddPronunciationDictionaryResponseModelPermissionOnResource)

                    || typeToConvert == typeof(global::ElevenLabs.AddPronunciationDictionaryResponseModelPermissionOnResource?)

                    || typeToConvert == typeof(global::ElevenLabs.BodyAddAPronunciationDictionaryV1PronunciationDictionariesAddFromFilePostWorkspaceAccess)

                    || typeToConvert == typeof(global::ElevenLabs.BodyAddAPronunciationDictionaryV1PronunciationDictionariesAddFromFilePostWorkspaceAccess?)

                    || typeToConvert == typeof(global::ElevenLabs.BodyAddAPronunciationDictionaryV1PronunciationDictionariesAddFromRulesPostWorkspaceAccess)

                    || typeToConvert == typeof(global::ElevenLabs.BodyAddAPronunciationDictionaryV1PronunciationDictionariesAddFromRulesPostWorkspaceAccess?)

                    || typeToConvert == typeof(global::ElevenLabs.GetPronunciationDictionaryMetadataResponseModelPermissionOnResource)

                    || typeToConvert == typeof(global::ElevenLabs.GetPronunciationDictionaryMetadataResponseModelPermissionOnResource?)

                    || typeToConvert == typeof(global::ElevenLabs.GetPronunciationDictionaryWithRulesResponseModelPermissionOnResource)

                    || typeToConvert == typeof(global::ElevenLabs.GetPronunciationDictionaryWithRulesResponseModelPermissionOnResource?)

                    || typeToConvert == typeof(global::ElevenLabs.GetPronunciationDictionariesMetadataSort)

                    || typeToConvert == typeof(global::ElevenLabs.GetPronunciationDictionariesMetadataSort?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::ElevenLabs.AddPronunciationDictionaryResponseModelPermissionOnResource))
                {
                    return new global::ElevenLabs.JsonConverters.AddPronunciationDictionaryResponseModelPermissionOnResourceJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.AddPronunciationDictionaryResponseModelPermissionOnResource?))
                {
                    return new global::ElevenLabs.JsonConverters.AddPronunciationDictionaryResponseModelPermissionOnResourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.BodyAddAPronunciationDictionaryV1PronunciationDictionariesAddFromFilePostWorkspaceAccess))
                {
                    return new global::ElevenLabs.JsonConverters.BodyAddAPronunciationDictionaryV1PronunciationDictionariesAddFromFilePostWorkspaceAccessJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.BodyAddAPronunciationDictionaryV1PronunciationDictionariesAddFromFilePostWorkspaceAccess?))
                {
                    return new global::ElevenLabs.JsonConverters.BodyAddAPronunciationDictionaryV1PronunciationDictionariesAddFromFilePostWorkspaceAccessNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.BodyAddAPronunciationDictionaryV1PronunciationDictionariesAddFromRulesPostWorkspaceAccess))
                {
                    return new global::ElevenLabs.JsonConverters.BodyAddAPronunciationDictionaryV1PronunciationDictionariesAddFromRulesPostWorkspaceAccessJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.BodyAddAPronunciationDictionaryV1PronunciationDictionariesAddFromRulesPostWorkspaceAccess?))
                {
                    return new global::ElevenLabs.JsonConverters.BodyAddAPronunciationDictionaryV1PronunciationDictionariesAddFromRulesPostWorkspaceAccessNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.GetPronunciationDictionaryMetadataResponseModelPermissionOnResource))
                {
                    return new global::ElevenLabs.JsonConverters.GetPronunciationDictionaryMetadataResponseModelPermissionOnResourceJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.GetPronunciationDictionaryMetadataResponseModelPermissionOnResource?))
                {
                    return new global::ElevenLabs.JsonConverters.GetPronunciationDictionaryMetadataResponseModelPermissionOnResourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.GetPronunciationDictionaryWithRulesResponseModelPermissionOnResource))
                {
                    return new global::ElevenLabs.JsonConverters.GetPronunciationDictionaryWithRulesResponseModelPermissionOnResourceJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.GetPronunciationDictionaryWithRulesResponseModelPermissionOnResource?))
                {
                    return new global::ElevenLabs.JsonConverters.GetPronunciationDictionaryWithRulesResponseModelPermissionOnResourceNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.GetPronunciationDictionariesMetadataSort))
                {
                    return new global::ElevenLabs.JsonConverters.GetPronunciationDictionariesMetadataSortJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.GetPronunciationDictionariesMetadataSort?))
                {
                    return new global::ElevenLabs.JsonConverters.GetPronunciationDictionariesMetadataSortNullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[2];

            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                for (var index = 0; index < _resolvers.Length; index++)
                {
                    var typeInfo = GetResolver(index).GetTypeInfo(type, options);
                    if (typeInfo is not null)
                    {
                        return typeInfo;
                    }
                }

                return null;
            }

            private global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver GetResolver(int index)
            {
                var resolver = global::System.Threading.Volatile.Read(ref _resolvers[index]);
                if (resolver is not null)
                {
                    return resolver;
                }

                lock (_gate)
                {
                    return _resolvers[index] ??= CreateResolver(index);
                }
            }

            private static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver CreateResolver(int index)
            {
                return index switch
                {
                    0 => new PronunciationDictionarySourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),

                    1 => global::ElevenLabs.PartitionCoreSourceGenerationContext.TypeInfoResolver,
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}