#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace ElevenLabs.JsonConverters
{
    /// <inheritdoc />
    public class Left6JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ElevenLabs.Left6>
    {
        /// <inheritdoc />
        public override global::ElevenLabs.Left6 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.ASTGreaterThanOrEqualsOperatorNodeOutputLeftDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.ASTGreaterThanOrEqualsOperatorNodeOutputLeftDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.ASTGreaterThanOrEqualsOperatorNodeOutputLeftDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::ElevenLabs.ASTStringNodeOutput? stringLiteral = default;
            if (discriminator?.Type == global::ElevenLabs.ASTGreaterThanOrEqualsOperatorNodeOutputLeftDiscriminatorType.StringLiteral)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.ASTStringNodeOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.ASTStringNodeOutput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.ASTStringNodeOutput)}");
                stringLiteral = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.ASTNumberNodeOutput? numberLiteral = default;
            if (discriminator?.Type == global::ElevenLabs.ASTGreaterThanOrEqualsOperatorNodeOutputLeftDiscriminatorType.NumberLiteral)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.ASTNumberNodeOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.ASTNumberNodeOutput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.ASTNumberNodeOutput)}");
                numberLiteral = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.ASTBooleanNodeOutput? booleanLiteral = default;
            if (discriminator?.Type == global::ElevenLabs.ASTGreaterThanOrEqualsOperatorNodeOutputLeftDiscriminatorType.BooleanLiteral)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.ASTBooleanNodeOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.ASTBooleanNodeOutput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.ASTBooleanNodeOutput)}");
                booleanLiteral = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.ASTLLMNodeOutput? llm = default;
            if (discriminator?.Type == global::ElevenLabs.ASTGreaterThanOrEqualsOperatorNodeOutputLeftDiscriminatorType.Llm)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.ASTLLMNodeOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.ASTLLMNodeOutput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.ASTLLMNodeOutput)}");
                llm = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.ASTDynamicVariableNodeOutput? dynamicVariable = default;
            if (discriminator?.Type == global::ElevenLabs.ASTGreaterThanOrEqualsOperatorNodeOutputLeftDiscriminatorType.DynamicVariable)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.ASTDynamicVariableNodeOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.ASTDynamicVariableNodeOutput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.ASTDynamicVariableNodeOutput)}");
                dynamicVariable = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.ASTOrOperatorNodeOutput? orOperator = default;
            if (discriminator?.Type == global::ElevenLabs.ASTGreaterThanOrEqualsOperatorNodeOutputLeftDiscriminatorType.OrOperator)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.ASTOrOperatorNodeOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.ASTOrOperatorNodeOutput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.ASTOrOperatorNodeOutput)}");
                orOperator = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.ASTAndOperatorNodeOutput? andOperator = default;
            if (discriminator?.Type == global::ElevenLabs.ASTGreaterThanOrEqualsOperatorNodeOutputLeftDiscriminatorType.AndOperator)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.ASTAndOperatorNodeOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.ASTAndOperatorNodeOutput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.ASTAndOperatorNodeOutput)}");
                andOperator = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.ASTEqualsOperatorNodeOutput? eqOperator = default;
            if (discriminator?.Type == global::ElevenLabs.ASTGreaterThanOrEqualsOperatorNodeOutputLeftDiscriminatorType.EqOperator)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.ASTEqualsOperatorNodeOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.ASTEqualsOperatorNodeOutput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.ASTEqualsOperatorNodeOutput)}");
                eqOperator = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.ASTNotEqualsOperatorNodeOutput? neqOperator = default;
            if (discriminator?.Type == global::ElevenLabs.ASTGreaterThanOrEqualsOperatorNodeOutputLeftDiscriminatorType.NeqOperator)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.ASTNotEqualsOperatorNodeOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.ASTNotEqualsOperatorNodeOutput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.ASTNotEqualsOperatorNodeOutput)}");
                neqOperator = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.ASTGreaterThanOperatorNodeOutput? gtOperator = default;
            if (discriminator?.Type == global::ElevenLabs.ASTGreaterThanOrEqualsOperatorNodeOutputLeftDiscriminatorType.GtOperator)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.ASTGreaterThanOperatorNodeOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.ASTGreaterThanOperatorNodeOutput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.ASTGreaterThanOperatorNodeOutput)}");
                gtOperator = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.ASTLessThanOperatorNodeOutput? ltOperator = default;
            if (discriminator?.Type == global::ElevenLabs.ASTGreaterThanOrEqualsOperatorNodeOutputLeftDiscriminatorType.LtOperator)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.ASTLessThanOperatorNodeOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.ASTLessThanOperatorNodeOutput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.ASTLessThanOperatorNodeOutput)}");
                ltOperator = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.ASTGreaterThanOrEqualsOperatorNodeOutput? gteOperator = default;
            if (discriminator?.Type == global::ElevenLabs.ASTGreaterThanOrEqualsOperatorNodeOutputLeftDiscriminatorType.GteOperator)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.ASTGreaterThanOrEqualsOperatorNodeOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.ASTGreaterThanOrEqualsOperatorNodeOutput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.ASTGreaterThanOrEqualsOperatorNodeOutput)}");
                gteOperator = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.ASTLessThanOrEqualsOperatorNodeOutput? lteOperator = default;
            if (discriminator?.Type == global::ElevenLabs.ASTGreaterThanOrEqualsOperatorNodeOutputLeftDiscriminatorType.LteOperator)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.ASTLessThanOrEqualsOperatorNodeOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.ASTLessThanOrEqualsOperatorNodeOutput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.ASTLessThanOrEqualsOperatorNodeOutput)}");
                lteOperator = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var result = new global::ElevenLabs.Left6(
                discriminator?.Type,
                stringLiteral,
                numberLiteral,
                booleanLiteral,
                llm,
                dynamicVariable,
                orOperator,
                andOperator,
                eqOperator,
                neqOperator,
                gtOperator,
                ltOperator,
                gteOperator,
                lteOperator
                );

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::ElevenLabs.Left6 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsStringLiteral)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.ASTStringNodeOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.ASTStringNodeOutput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.ASTStringNodeOutput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StringLiteral, typeInfo);
            }
            else if (value.IsNumberLiteral)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.ASTNumberNodeOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.ASTNumberNodeOutput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.ASTNumberNodeOutput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.NumberLiteral, typeInfo);
            }
            else if (value.IsBooleanLiteral)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.ASTBooleanNodeOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.ASTBooleanNodeOutput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.ASTBooleanNodeOutput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BooleanLiteral, typeInfo);
            }
            else if (value.IsLlm)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.ASTLLMNodeOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.ASTLLMNodeOutput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.ASTLLMNodeOutput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Llm, typeInfo);
            }
            else if (value.IsDynamicVariable)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.ASTDynamicVariableNodeOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.ASTDynamicVariableNodeOutput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.ASTDynamicVariableNodeOutput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.DynamicVariable, typeInfo);
            }
            else if (value.IsOrOperator)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.ASTOrOperatorNodeOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.ASTOrOperatorNodeOutput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.ASTOrOperatorNodeOutput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OrOperator, typeInfo);
            }
            else if (value.IsAndOperator)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.ASTAndOperatorNodeOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.ASTAndOperatorNodeOutput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.ASTAndOperatorNodeOutput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AndOperator, typeInfo);
            }
            else if (value.IsEqOperator)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.ASTEqualsOperatorNodeOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.ASTEqualsOperatorNodeOutput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.ASTEqualsOperatorNodeOutput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.EqOperator, typeInfo);
            }
            else if (value.IsNeqOperator)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.ASTNotEqualsOperatorNodeOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.ASTNotEqualsOperatorNodeOutput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.ASTNotEqualsOperatorNodeOutput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.NeqOperator, typeInfo);
            }
            else if (value.IsGtOperator)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.ASTGreaterThanOperatorNodeOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.ASTGreaterThanOperatorNodeOutput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.ASTGreaterThanOperatorNodeOutput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GtOperator, typeInfo);
            }
            else if (value.IsLtOperator)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.ASTLessThanOperatorNodeOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.ASTLessThanOperatorNodeOutput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.ASTLessThanOperatorNodeOutput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.LtOperator, typeInfo);
            }
            else if (value.IsGteOperator)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.ASTGreaterThanOrEqualsOperatorNodeOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.ASTGreaterThanOrEqualsOperatorNodeOutput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.ASTGreaterThanOrEqualsOperatorNodeOutput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GteOperator, typeInfo);
            }
            else if (value.IsLteOperator)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.ASTLessThanOrEqualsOperatorNodeOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.ASTLessThanOrEqualsOperatorNodeOutput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.ASTLessThanOrEqualsOperatorNodeOutput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.LteOperator, typeInfo);
            }
        }
    }
}