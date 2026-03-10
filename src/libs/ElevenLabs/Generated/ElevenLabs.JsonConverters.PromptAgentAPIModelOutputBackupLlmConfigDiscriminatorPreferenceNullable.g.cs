#nullable enable

namespace ElevenLabs.JsonConverters
{
    /// <inheritdoc />
    public sealed class PromptAgentAPIModelOutputBackupLlmConfigDiscriminatorPreferenceNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ElevenLabs.PromptAgentAPIModelOutputBackupLlmConfigDiscriminatorPreference?>
    {
        /// <inheritdoc />
        public override global::ElevenLabs.PromptAgentAPIModelOutputBackupLlmConfigDiscriminatorPreference? Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::ElevenLabs.PromptAgentAPIModelOutputBackupLlmConfigDiscriminatorPreferenceExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::ElevenLabs.PromptAgentAPIModelOutputBackupLlmConfigDiscriminatorPreference)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::ElevenLabs.PromptAgentAPIModelOutputBackupLlmConfigDiscriminatorPreference?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::ElevenLabs.PromptAgentAPIModelOutputBackupLlmConfigDiscriminatorPreference? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::ElevenLabs.PromptAgentAPIModelOutputBackupLlmConfigDiscriminatorPreferenceExtensions.ToValueString(value.Value));
            }
        }
    }
}
