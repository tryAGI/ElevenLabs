#nullable enable

namespace ElevenLabs.JsonConverters
{
    /// <inheritdoc />
    public sealed class BodyListApiRequestsV1WorkspaceAnalyticsRequestsPostSortNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ElevenLabs.BodyListApiRequestsV1WorkspaceAnalyticsRequestsPostSort?>
    {
        /// <inheritdoc />
        public override global::ElevenLabs.BodyListApiRequestsV1WorkspaceAnalyticsRequestsPostSort? Read(
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
                        return global::ElevenLabs.BodyListApiRequestsV1WorkspaceAnalyticsRequestsPostSortExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::ElevenLabs.BodyListApiRequestsV1WorkspaceAnalyticsRequestsPostSort)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::ElevenLabs.BodyListApiRequestsV1WorkspaceAnalyticsRequestsPostSort?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::ElevenLabs.BodyListApiRequestsV1WorkspaceAnalyticsRequestsPostSort? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::ElevenLabs.BodyListApiRequestsV1WorkspaceAnalyticsRequestsPostSortExtensions.ToValueString(value.Value));
            }
        }
    }
}
