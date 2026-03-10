#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace ElevenLabs.JsonConverters
{
    /// <inheritdoc />
    public class Left9JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ElevenLabs.Left9>
    {
        /// <inheritdoc />
        public override global::ElevenLabs.Left9 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.ASTLessThanOrEqualsOperatorNodeInputLeftDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.ASTLessThanOrEqualsOperatorNodeInputLeftDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.ASTLessThanOrEqualsOperatorNodeInputLeftDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::ElevenLabs.ASTStringNodeInput? stringLiteral = default;
            if (discriminator?.Type == global::ElevenLabs.ASTLessThanOrEqualsOperatorNodeInputLeftDiscriminatorType.StringLiteral)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.ASTStringNodeInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.ASTStringNodeInput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.ASTStringNodeInput)}");
                stringLiteral = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.ASTNumberNodeInput? numberLiteral = default;
            if (discriminator?.Type == global::ElevenLabs.ASTLessThanOrEqualsOperatorNodeInputLeftDiscriminatorType.NumberLiteral)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.ASTNumberNodeInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.ASTNumberNodeInput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.ASTNumberNodeInput)}");
                numberLiteral = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.ASTBooleanNodeInput? booleanLiteral = default;
            if (discriminator?.Type == global::ElevenLabs.ASTLessThanOrEqualsOperatorNodeInputLeftDiscriminatorType.BooleanLiteral)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.ASTBooleanNodeInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.ASTBooleanNodeInput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.ASTBooleanNodeInput)}");
                booleanLiteral = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.ASTLLMNodeInput? llm = default;
            if (discriminator?.Type == global::ElevenLabs.ASTLessThanOrEqualsOperatorNodeInputLeftDiscriminatorType.Llm)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.ASTLLMNodeInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.ASTLLMNodeInput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.ASTLLMNodeInput)}");
                llm = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.ASTDynamicVariableNodeInput? dynamicVariable = default;
            if (discriminator?.Type == global::ElevenLabs.ASTLessThanOrEqualsOperatorNodeInputLeftDiscriminatorType.DynamicVariable)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.ASTDynamicVariableNodeInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.ASTDynamicVariableNodeInput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.ASTDynamicVariableNodeInput)}");
                dynamicVariable = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.ASTOrOperatorNodeInput? orOperator = default;
            if (discriminator?.Type == global::ElevenLabs.ASTLessThanOrEqualsOperatorNodeInputLeftDiscriminatorType.OrOperator)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.ASTOrOperatorNodeInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.ASTOrOperatorNodeInput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.ASTOrOperatorNodeInput)}");
                orOperator = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.ASTAndOperatorNodeInput? andOperator = default;
            if (discriminator?.Type == global::ElevenLabs.ASTLessThanOrEqualsOperatorNodeInputLeftDiscriminatorType.AndOperator)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.ASTAndOperatorNodeInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.ASTAndOperatorNodeInput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.ASTAndOperatorNodeInput)}");
                andOperator = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.ASTEqualsOperatorNodeInput? eqOperator = default;
            if (discriminator?.Type == global::ElevenLabs.ASTLessThanOrEqualsOperatorNodeInputLeftDiscriminatorType.EqOperator)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.ASTEqualsOperatorNodeInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.ASTEqualsOperatorNodeInput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.ASTEqualsOperatorNodeInput)}");
                eqOperator = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.ASTNotEqualsOperatorNodeInput? neqOperator = default;
            if (discriminator?.Type == global::ElevenLabs.ASTLessThanOrEqualsOperatorNodeInputLeftDiscriminatorType.NeqOperator)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.ASTNotEqualsOperatorNodeInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.ASTNotEqualsOperatorNodeInput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.ASTNotEqualsOperatorNodeInput)}");
                neqOperator = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.ASTGreaterThanOperatorNodeInput? gtOperator = default;
            if (discriminator?.Type == global::ElevenLabs.ASTLessThanOrEqualsOperatorNodeInputLeftDiscriminatorType.GtOperator)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.ASTGreaterThanOperatorNodeInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.ASTGreaterThanOperatorNodeInput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.ASTGreaterThanOperatorNodeInput)}");
                gtOperator = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.ASTLessThanOperatorNodeInput? ltOperator = default;
            if (discriminator?.Type == global::ElevenLabs.ASTLessThanOrEqualsOperatorNodeInputLeftDiscriminatorType.LtOperator)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.ASTLessThanOperatorNodeInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.ASTLessThanOperatorNodeInput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.ASTLessThanOperatorNodeInput)}");
                ltOperator = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.ASTGreaterThanOrEqualsOperatorNodeInput? gteOperator = default;
            if (discriminator?.Type == global::ElevenLabs.ASTLessThanOrEqualsOperatorNodeInputLeftDiscriminatorType.GteOperator)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.ASTGreaterThanOrEqualsOperatorNodeInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.ASTGreaterThanOrEqualsOperatorNodeInput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.ASTGreaterThanOrEqualsOperatorNodeInput)}");
                gteOperator = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.ASTLessThanOrEqualsOperatorNodeInput? lteOperator = default;
            if (discriminator?.Type == global::ElevenLabs.ASTLessThanOrEqualsOperatorNodeInputLeftDiscriminatorType.LteOperator)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.ASTLessThanOrEqualsOperatorNodeInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.ASTLessThanOrEqualsOperatorNodeInput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.ASTLessThanOrEqualsOperatorNodeInput)}");
                lteOperator = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var result = new global::ElevenLabs.Left9(
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
            global::ElevenLabs.Left9 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsStringLiteral)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.ASTStringNodeInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.ASTStringNodeInput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.ASTStringNodeInput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StringLiteral, typeInfo);
            }
            else if (value.IsNumberLiteral)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.ASTNumberNodeInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.ASTNumberNodeInput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.ASTNumberNodeInput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.NumberLiteral, typeInfo);
            }
            else if (value.IsBooleanLiteral)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.ASTBooleanNodeInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.ASTBooleanNodeInput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.ASTBooleanNodeInput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.BooleanLiteral, typeInfo);
            }
            else if (value.IsLlm)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.ASTLLMNodeInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.ASTLLMNodeInput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.ASTLLMNodeInput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Llm, typeInfo);
            }
            else if (value.IsDynamicVariable)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.ASTDynamicVariableNodeInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.ASTDynamicVariableNodeInput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.ASTDynamicVariableNodeInput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.DynamicVariable, typeInfo);
            }
            else if (value.IsOrOperator)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.ASTOrOperatorNodeInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.ASTOrOperatorNodeInput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.ASTOrOperatorNodeInput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OrOperator, typeInfo);
            }
            else if (value.IsAndOperator)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.ASTAndOperatorNodeInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.ASTAndOperatorNodeInput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.ASTAndOperatorNodeInput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.AndOperator, typeInfo);
            }
            else if (value.IsEqOperator)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.ASTEqualsOperatorNodeInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.ASTEqualsOperatorNodeInput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.ASTEqualsOperatorNodeInput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.EqOperator, typeInfo);
            }
            else if (value.IsNeqOperator)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.ASTNotEqualsOperatorNodeInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.ASTNotEqualsOperatorNodeInput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.ASTNotEqualsOperatorNodeInput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.NeqOperator, typeInfo);
            }
            else if (value.IsGtOperator)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.ASTGreaterThanOperatorNodeInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.ASTGreaterThanOperatorNodeInput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.ASTGreaterThanOperatorNodeInput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GtOperator, typeInfo);
            }
            else if (value.IsLtOperator)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.ASTLessThanOperatorNodeInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.ASTLessThanOperatorNodeInput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.ASTLessThanOperatorNodeInput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.LtOperator, typeInfo);
            }
            else if (value.IsGteOperator)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.ASTGreaterThanOrEqualsOperatorNodeInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.ASTGreaterThanOrEqualsOperatorNodeInput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.ASTGreaterThanOrEqualsOperatorNodeInput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.GteOperator, typeInfo);
            }
            else if (value.IsLteOperator)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.ASTLessThanOrEqualsOperatorNodeInput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.ASTLessThanOrEqualsOperatorNodeInput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.ASTLessThanOrEqualsOperatorNodeInput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.LteOperator, typeInfo);
            }
        }
    }
}