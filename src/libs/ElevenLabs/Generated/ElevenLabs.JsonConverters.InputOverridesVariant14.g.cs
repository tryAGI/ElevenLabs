#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace ElevenLabs.JsonConverters
{
    /// <inheritdoc />
    public class InputOverridesVariant14JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ElevenLabs.InputOverridesVariant14>
    {
        /// <inheritdoc />
        public override global::ElevenLabs.InputOverridesVariant14 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.MCPToolConfigOverrideCreateRequestModelInputOverridesDiscriminator>(ref readerCopy, options);

            global::ElevenLabs.ConstantSchemaOverride? constant = default;
            if (discriminator?.Source == global::ElevenLabs.MCPToolConfigOverrideCreateRequestModelInputOverridesDiscriminatorSource.Constant)
            {
                constant = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.ConstantSchemaOverride>(ref reader, options);
            }
            global::ElevenLabs.DynamicVariableSchemaOverride? dynamicVariable = default;
            if (discriminator?.Source == global::ElevenLabs.MCPToolConfigOverrideCreateRequestModelInputOverridesDiscriminatorSource.DynamicVariable)
            {
                dynamicVariable = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.DynamicVariableSchemaOverride>(ref reader, options);
            }
            global::ElevenLabs.LLMSchemaOverride? llm = default;
            if (discriminator?.Source == global::ElevenLabs.MCPToolConfigOverrideCreateRequestModelInputOverridesDiscriminatorSource.Llm)
            {
                llm = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.LLMSchemaOverride>(ref reader, options);
            }

            var __value = new global::ElevenLabs.InputOverridesVariant14(
                discriminator?.Source,
                constant,

                dynamicVariable,

                llm
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::ElevenLabs.InputOverridesVariant14 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsConstant)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Constant, typeof(global::ElevenLabs.ConstantSchemaOverride), options);
            }
            else if (value.IsDynamicVariable)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.DynamicVariable, typeof(global::ElevenLabs.DynamicVariableSchemaOverride), options);
            }
            else if (value.IsLlm)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Llm, typeof(global::ElevenLabs.LLMSchemaOverride), options);
            }
        }
    }
}