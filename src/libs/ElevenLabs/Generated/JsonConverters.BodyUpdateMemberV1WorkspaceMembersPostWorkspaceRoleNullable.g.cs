#nullable enable

namespace ElevenLabs.JsonConverters
{
    /// <inheritdoc />
    public sealed class BodyUpdateMemberV1WorkspaceMembersPostWorkspaceRoleNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ElevenLabs.BodyUpdateMemberV1WorkspaceMembersPostWorkspaceRole?>
    {
        /// <inheritdoc />
        public override global::ElevenLabs.BodyUpdateMemberV1WorkspaceMembersPostWorkspaceRole? Read(
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
                        return global::ElevenLabs.BodyUpdateMemberV1WorkspaceMembersPostWorkspaceRoleExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::ElevenLabs.BodyUpdateMemberV1WorkspaceMembersPostWorkspaceRole)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::ElevenLabs.BodyUpdateMemberV1WorkspaceMembersPostWorkspaceRole? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::ElevenLabs.BodyUpdateMemberV1WorkspaceMembersPostWorkspaceRoleExtensions.ToValueString(value.Value));
            }
        }
    }
}
