#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace ElevenLabs.JsonConverters
{
    /// <inheritdoc />
    public class BackupLlmConfig2JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ElevenLabs.BackupLlmConfig2>
    {
        /// <inheritdoc />
        public override global::ElevenLabs.BackupLlmConfig2 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.PromptAgentAPIModelOutputBackupLlmConfigDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.PromptAgentAPIModelOutputBackupLlmConfigDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.PromptAgentAPIModelOutputBackupLlmConfigDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::ElevenLabs.BackupLLMDefault? @default = default;
            if (discriminator?.Preference == global::ElevenLabs.PromptAgentAPIModelOutputBackupLlmConfigDiscriminatorPreference.Default)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.BackupLLMDefault), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.BackupLLMDefault> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.BackupLLMDefault)}");
                @default = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.BackupLLMDisabled? disabled = default;
            if (discriminator?.Preference == global::ElevenLabs.PromptAgentAPIModelOutputBackupLlmConfigDiscriminatorPreference.Disabled)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.BackupLLMDisabled), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.BackupLLMDisabled> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.BackupLLMDisabled)}");
                disabled = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.BackupLLMOverride? @override = default;
            if (discriminator?.Preference == global::ElevenLabs.PromptAgentAPIModelOutputBackupLlmConfigDiscriminatorPreference.Override)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.BackupLLMOverride), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.BackupLLMOverride> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.BackupLLMOverride)}");
                @override = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var result = new global::ElevenLabs.BackupLlmConfig2(
                discriminator?.Preference,
                @default,
                disabled,
                @override
                );

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::ElevenLabs.BackupLlmConfig2 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsDefault)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.BackupLLMDefault), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.BackupLLMDefault?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.BackupLLMDefault).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Default, typeInfo);
            }
            else if (value.IsDisabled)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.BackupLLMDisabled), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.BackupLLMDisabled?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.BackupLLMDisabled).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Disabled, typeInfo);
            }
            else if (value.IsOverride)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.BackupLLMOverride), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.BackupLLMOverride?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.BackupLLMOverride).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Override, typeInfo);
            }
        }
    }
}