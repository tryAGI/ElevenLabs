
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyRegisterMediaV1ProductionsOrdersOrderIdMediaPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyUpdateOrderV1ProductionsOrdersOrderIdPatch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.UpdateOrderRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.BodyUpsertOrderItemV1ProductionsOrdersOrderIdItemsPost))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.UpsertOrderItemRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CreateOrderRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CreateOrderResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.CueOptionsRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DeliverableInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.DubOrderItemRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.LanguageInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.LanguagePairInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.LanguageInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.LanguagesResponse), TypeInfoPropertyName = "LanguagesResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.PairedLanguagesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SingleLanguagesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.LanguagesResponseDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.LanguagesResponseDiscriminatorKind), TypeInfoPropertyName = "LanguagesResponseDiscriminatorKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.ListOrdersResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.OrderSummary>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.OrderSummary))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.OrderDeliverablesResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.DeliverableInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.OrderItemInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.OrderItemRequestOutput), TypeInfoPropertyName = "OrderItemRequestOutput2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.QuoteInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.OrderItemKind), TypeInfoPropertyName = "OrderItemKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.OrderItemRequestInput), TypeInfoPropertyName = "OrderItemRequestInput2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SubtitleOrderItemRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.TranscriptionOrderItemRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.OrderItemRequestInputDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.OrderItemRequestInputDiscriminatorKind), TypeInfoPropertyName = "OrderItemRequestInputDiscriminatorKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.OrderItemRequestOutputDiscriminator))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.OrderItemRequestOutputDiscriminatorKind), TypeInfoPropertyName = "OrderItemRequestOutputDiscriminatorKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.OrderMediaResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.OrderResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.OrderState), TypeInfoPropertyName = "OrderState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.OrderItemInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.LanguagePairInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.RegisterMediaResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.RemoveOrderItemResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.SubmitOrderResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.UpdateOrderResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.UpsertOrderItemResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.OrderState>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.LanguagesResponse?), TypeInfoPropertyName = "NullableLanguagesResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.LanguagesResponseDiscriminatorKind?), TypeInfoPropertyName = "NullableLanguagesResponseDiscriminatorKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.OrderItemRequestOutput?), TypeInfoPropertyName = "NullableOrderItemRequestOutput2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.OrderItemKind?), TypeInfoPropertyName = "NullableOrderItemKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.OrderItemRequestInput?), TypeInfoPropertyName = "NullableOrderItemRequestInput2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.OrderItemRequestInputDiscriminatorKind?), TypeInfoPropertyName = "NullableOrderItemRequestInputDiscriminatorKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.OrderItemRequestOutputDiscriminatorKind?), TypeInfoPropertyName = "NullableOrderItemRequestOutputDiscriminatorKind2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::ElevenLabs.OrderState?), TypeInfoPropertyName = "NullableOrderState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.LanguageInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.OrderSummary>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.DeliverableInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.OrderItemInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.LanguagePairInfo>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::ElevenLabs.OrderState>))]
    internal sealed partial class ProductionsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ProductionsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static ProductionsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private ProductionsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::ElevenLabs.JsonConverters.LanguagesResponseJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.OrderItemRequestInputJsonConverter());
            options.Converters.Add(new global::ElevenLabs.JsonConverters.OrderItemRequestOutputJsonConverter());
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
                    typeToConvert == typeof(global::ElevenLabs.LanguagesResponseDiscriminatorKind)

                    || typeToConvert == typeof(global::ElevenLabs.LanguagesResponseDiscriminatorKind?)

                    || typeToConvert == typeof(global::ElevenLabs.OrderItemKind)

                    || typeToConvert == typeof(global::ElevenLabs.OrderItemKind?)

                    || typeToConvert == typeof(global::ElevenLabs.OrderItemRequestInputDiscriminatorKind)

                    || typeToConvert == typeof(global::ElevenLabs.OrderItemRequestInputDiscriminatorKind?)

                    || typeToConvert == typeof(global::ElevenLabs.OrderItemRequestOutputDiscriminatorKind)

                    || typeToConvert == typeof(global::ElevenLabs.OrderItemRequestOutputDiscriminatorKind?)

                    || typeToConvert == typeof(global::ElevenLabs.OrderState)

                    || typeToConvert == typeof(global::ElevenLabs.OrderState?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::ElevenLabs.LanguagesResponseDiscriminatorKind))
                {
                    return new global::ElevenLabs.JsonConverters.LanguagesResponseDiscriminatorKindJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.LanguagesResponseDiscriminatorKind?))
                {
                    return new global::ElevenLabs.JsonConverters.LanguagesResponseDiscriminatorKindNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.OrderItemKind))
                {
                    return new global::ElevenLabs.JsonConverters.OrderItemKindJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.OrderItemKind?))
                {
                    return new global::ElevenLabs.JsonConverters.OrderItemKindNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.OrderItemRequestInputDiscriminatorKind))
                {
                    return new global::ElevenLabs.JsonConverters.OrderItemRequestInputDiscriminatorKindJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.OrderItemRequestInputDiscriminatorKind?))
                {
                    return new global::ElevenLabs.JsonConverters.OrderItemRequestInputDiscriminatorKindNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.OrderItemRequestOutputDiscriminatorKind))
                {
                    return new global::ElevenLabs.JsonConverters.OrderItemRequestOutputDiscriminatorKindJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.OrderItemRequestOutputDiscriminatorKind?))
                {
                    return new global::ElevenLabs.JsonConverters.OrderItemRequestOutputDiscriminatorKindNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.OrderState))
                {
                    return new global::ElevenLabs.JsonConverters.OrderStateJsonConverter();
                }

                if (typeToConvert == typeof(global::ElevenLabs.OrderState?))
                {
                    return new global::ElevenLabs.JsonConverters.OrderStateNullableJsonConverter();
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
                    0 => new ProductionsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),

                    1 => global::ElevenLabs.PartitionCoreSourceGenerationContext.TypeInfoResolver,
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}