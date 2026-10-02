
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyGetWorkspaceUsageV1WorkspaceAnalyticsQueryUsageByProductOverTimePost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.BodyGetWorkspaceUsageV1WorkspaceAnalyticsQueryUsageByProductOverTimePostGroupByVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyGetWorkspaceUsageV1WorkspaceAnalyticsQueryUsageByProductOverTimePostGroupByVariant1Item), TypeInfoPropertyName = "BodyGetWorkspaceUsageV1WorkspaceAnalyticsQueryUsageByProductOverTimePostGroupByVariant1Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.ColumnFilter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ColumnFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyListApiRequestsV1WorkspaceAnalyticsRequestsPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyListApiRequestsV1WorkspaceAnalyticsRequestsPostSort), TypeInfoPropertyName = "BodyListApiRequestsV1WorkspaceAnalyticsRequestsPostSort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ColumnFilterOperation), TypeInfoPropertyName = "ColumnFilterOperation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ColumnUnit), TypeInfoPropertyName = "ColumnUnit2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WorkspaceAnalyticsQueryResponseModel))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.WorkspaceAnalyticsQueryResponseModelColumnType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WorkspaceAnalyticsQueryResponseModelColumnType), TypeInfoPropertyName = "WorkspaceAnalyticsQueryResponseModelColumnType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.ColumnUnit?>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyGetWorkspaceUsageV1WorkspaceAnalyticsQueryUsageByProductOverTimePostGroupByVariant1Item?), TypeInfoPropertyName = "NullableBodyGetWorkspaceUsageV1WorkspaceAnalyticsQueryUsageByProductOverTimePostGroupByVariant1Item2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyListApiRequestsV1WorkspaceAnalyticsRequestsPostSort?), TypeInfoPropertyName = "NullableBodyListApiRequestsV1WorkspaceAnalyticsRequestsPostSort2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ColumnFilterOperation?), TypeInfoPropertyName = "NullableColumnFilterOperation2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ColumnUnit?), TypeInfoPropertyName = "NullableColumnUnit2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.WorkspaceAnalyticsQueryResponseModelColumnType?), TypeInfoPropertyName = "NullableWorkspaceAnalyticsQueryResponseModelColumnType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.BodyGetWorkspaceUsageV1WorkspaceAnalyticsQueryUsageByProductOverTimePostGroupByVariant1Item>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.ColumnFilter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.WorkspaceAnalyticsQueryResponseModelColumnType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.ColumnUnit?>))]
    internal sealed partial class AccessAllSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AccessAllSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static AccessAllSourceGenerationContext Default { get; } = new(DefaultOptions);

        private AccessAllSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::ElevenLabs.BodyGetWorkspaceUsageV1WorkspaceAnalyticsQueryUsageByProductOverTimePostGroupByVariant1Item)

                    || typeToConvert == typeof(global::ElevenLabs.BodyGetWorkspaceUsageV1WorkspaceAnalyticsQueryUsageByProductOverTimePostGroupByVariant1Item?)

                    || typeToConvert == typeof(global::ElevenLabs.BodyListApiRequestsV1WorkspaceAnalyticsRequestsPostSort)

                    || typeToConvert == typeof(global::ElevenLabs.BodyListApiRequestsV1WorkspaceAnalyticsRequestsPostSort?)

                    || typeToConvert == typeof(global::ElevenLabs.ColumnFilterOperation)

                    || typeToConvert == typeof(global::ElevenLabs.ColumnFilterOperation?)

                    || typeToConvert == typeof(global::ElevenLabs.ColumnUnit)

                    || typeToConvert == typeof(global::ElevenLabs.ColumnUnit?)

                    || typeToConvert == typeof(global::ElevenLabs.WorkspaceAnalyticsQueryResponseModelColumnType)

                    || typeToConvert == typeof(global::ElevenLabs.WorkspaceAnalyticsQueryResponseModelColumnType?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::ElevenLabs.BodyGetWorkspaceUsageV1WorkspaceAnalyticsQueryUsageByProductOverTimePostGroupByVariant1Item))
                {
                    return new global::ElevenLabs.JsonConverters.BodyGetWorkspaceUsageV1WorkspaceAnalyticsQueryUsageByProductOverTimePostGroupByVariant1ItemJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.BodyGetWorkspaceUsageV1WorkspaceAnalyticsQueryUsageByProductOverTimePostGroupByVariant1Item?))
                {
                    return new global::ElevenLabs.JsonConverters.BodyGetWorkspaceUsageV1WorkspaceAnalyticsQueryUsageByProductOverTimePostGroupByVariant1ItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.BodyListApiRequestsV1WorkspaceAnalyticsRequestsPostSort))
                {
                    return new global::ElevenLabs.JsonConverters.BodyListApiRequestsV1WorkspaceAnalyticsRequestsPostSortJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.BodyListApiRequestsV1WorkspaceAnalyticsRequestsPostSort?))
                {
                    return new global::ElevenLabs.JsonConverters.BodyListApiRequestsV1WorkspaceAnalyticsRequestsPostSortNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ColumnFilterOperation))
                {
                    return new global::ElevenLabs.JsonConverters.ColumnFilterOperationJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ColumnFilterOperation?))
                {
                    return new global::ElevenLabs.JsonConverters.ColumnFilterOperationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ColumnUnit))
                {
                    return new global::ElevenLabs.JsonConverters.ColumnUnitJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.ColumnUnit?))
                {
                    return new global::ElevenLabs.JsonConverters.ColumnUnitNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.WorkspaceAnalyticsQueryResponseModelColumnType))
                {
                    return new global::ElevenLabs.JsonConverters.WorkspaceAnalyticsQueryResponseModelColumnTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.WorkspaceAnalyticsQueryResponseModelColumnType?))
                {
                    return new global::ElevenLabs.JsonConverters.WorkspaceAnalyticsQueryResponseModelColumnTypeNullableJsonConverter();
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
                    0 => new AccessAllSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),

                    1 => global::ElevenLabs.PartitionCoreSourceGenerationContext.TypeInfoResolver,
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}