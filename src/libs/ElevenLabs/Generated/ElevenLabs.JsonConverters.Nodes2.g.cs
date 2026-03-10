#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace ElevenLabs.JsonConverters
{
    /// <inheritdoc />
    public class Nodes2JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ElevenLabs.Nodes2>
    {
        /// <inheritdoc />
        public override global::ElevenLabs.Nodes2 Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.AgentWorkflowResponseModelNodesDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.AgentWorkflowResponseModelNodesDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.AgentWorkflowResponseModelNodesDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::ElevenLabs.WorkflowStartNodeModelOutput? start = default;
            if (discriminator?.Type == global::ElevenLabs.AgentWorkflowResponseModelNodesDiscriminatorType.Start)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.WorkflowStartNodeModelOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.WorkflowStartNodeModelOutput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.WorkflowStartNodeModelOutput)}");
                start = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.WorkflowEndNodeModelOutput? end = default;
            if (discriminator?.Type == global::ElevenLabs.AgentWorkflowResponseModelNodesDiscriminatorType.End)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.WorkflowEndNodeModelOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.WorkflowEndNodeModelOutput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.WorkflowEndNodeModelOutput)}");
                end = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.WorkflowPhoneNumberNodeModelOutput? phoneNumber = default;
            if (discriminator?.Type == global::ElevenLabs.AgentWorkflowResponseModelNodesDiscriminatorType.PhoneNumber)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.WorkflowPhoneNumberNodeModelOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.WorkflowPhoneNumberNodeModelOutput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.WorkflowPhoneNumberNodeModelOutput)}");
                phoneNumber = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.WorkflowOverrideAgentNodeModelOutput? overrideAgent = default;
            if (discriminator?.Type == global::ElevenLabs.AgentWorkflowResponseModelNodesDiscriminatorType.OverrideAgent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.WorkflowOverrideAgentNodeModelOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.WorkflowOverrideAgentNodeModelOutput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.WorkflowOverrideAgentNodeModelOutput)}");
                overrideAgent = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.WorkflowStandaloneAgentNodeModelOutput? standaloneAgent = default;
            if (discriminator?.Type == global::ElevenLabs.AgentWorkflowResponseModelNodesDiscriminatorType.StandaloneAgent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.WorkflowStandaloneAgentNodeModelOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.WorkflowStandaloneAgentNodeModelOutput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.WorkflowStandaloneAgentNodeModelOutput)}");
                standaloneAgent = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.WorkflowToolNodeModelOutput? tool = default;
            if (discriminator?.Type == global::ElevenLabs.AgentWorkflowResponseModelNodesDiscriminatorType.Tool)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.WorkflowToolNodeModelOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.WorkflowToolNodeModelOutput> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.WorkflowToolNodeModelOutput)}");
                tool = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var result = new global::ElevenLabs.Nodes2(
                discriminator?.Type,
                start,
                end,
                phoneNumber,
                overrideAgent,
                standaloneAgent,
                tool
                );

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::ElevenLabs.Nodes2 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsStart)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.WorkflowStartNodeModelOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.WorkflowStartNodeModelOutput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.WorkflowStartNodeModelOutput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Start, typeInfo);
            }
            else if (value.IsEnd)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.WorkflowEndNodeModelOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.WorkflowEndNodeModelOutput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.WorkflowEndNodeModelOutput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.End, typeInfo);
            }
            else if (value.IsPhoneNumber)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.WorkflowPhoneNumberNodeModelOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.WorkflowPhoneNumberNodeModelOutput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.WorkflowPhoneNumberNodeModelOutput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.PhoneNumber, typeInfo);
            }
            else if (value.IsOverrideAgent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.WorkflowOverrideAgentNodeModelOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.WorkflowOverrideAgentNodeModelOutput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.WorkflowOverrideAgentNodeModelOutput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OverrideAgent, typeInfo);
            }
            else if (value.IsStandaloneAgent)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.WorkflowStandaloneAgentNodeModelOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.WorkflowStandaloneAgentNodeModelOutput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.WorkflowStandaloneAgentNodeModelOutput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.StandaloneAgent, typeInfo);
            }
            else if (value.IsTool)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.WorkflowToolNodeModelOutput), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.WorkflowToolNodeModelOutput?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.WorkflowToolNodeModelOutput).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Tool, typeInfo);
            }
        }
    }
}