#nullable enable

namespace ElevenLabs.JsonConverters
{
    /// <inheritdoc />
    public sealed class Kling3ProMotionControlParametersCharacterOrientationNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ElevenLabs.Kling3ProMotionControlParametersCharacterOrientation?>
    {
        /// <inheritdoc />
        public override global::ElevenLabs.Kling3ProMotionControlParametersCharacterOrientation? Read(
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
                        return global::ElevenLabs.Kling3ProMotionControlParametersCharacterOrientationExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::ElevenLabs.Kling3ProMotionControlParametersCharacterOrientation)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::ElevenLabs.Kling3ProMotionControlParametersCharacterOrientation?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::ElevenLabs.Kling3ProMotionControlParametersCharacterOrientation? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::ElevenLabs.Kling3ProMotionControlParametersCharacterOrientationExtensions.ToValueString(value.Value));
            }
        }
    }
}
