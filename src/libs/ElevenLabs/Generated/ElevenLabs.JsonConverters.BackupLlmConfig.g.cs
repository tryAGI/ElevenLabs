#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace ElevenLabs.JsonConverters
{
    /// <inheritdoc />
    public class BackupLlmConfigJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ElevenLabs.BackupLlmConfig>
    {
        /// <inheritdoc />
        public override global::ElevenLabs.BackupLlmConfig Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.PromptAgentAPIModelInputBackupLlmConfigDiscriminator>(ref readerCopy, options);

            global::ElevenLabs.BackupLLMDefault? @default = default;
            if (discriminator?.Preference == global::ElevenLabs.PromptAgentAPIModelInputBackupLlmConfigDiscriminatorPreference.Default)
            {
                @default = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.BackupLLMDefault>(ref reader, options);
            }
            global::ElevenLabs.BackupLLMDisabled? disabled = default;
            if (discriminator?.Preference == global::ElevenLabs.PromptAgentAPIModelInputBackupLlmConfigDiscriminatorPreference.Disabled)
            {
                disabled = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.BackupLLMDisabled>(ref reader, options);
            }
            global::ElevenLabs.BackupLLMOverride? @override = default;
            if (discriminator?.Preference == global::ElevenLabs.PromptAgentAPIModelInputBackupLlmConfigDiscriminatorPreference.Override)
            {
                @override = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.BackupLLMOverride>(ref reader, options);
            }

            var __value = new global::ElevenLabs.BackupLlmConfig(
                discriminator?.Preference,
                @default,

                disabled,

                @override
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::ElevenLabs.BackupLlmConfig value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsDefault)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Default, typeof(global::ElevenLabs.BackupLLMDefault), options);
            }
            else if (value.IsDisabled)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Disabled, typeof(global::ElevenLabs.BackupLLMDisabled), options);
            }
            else if (value.IsOverride)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Override, typeof(global::ElevenLabs.BackupLLMOverride), options);
            }
        }
    }
}