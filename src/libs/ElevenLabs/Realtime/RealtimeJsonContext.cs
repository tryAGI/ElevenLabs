using System.Text.Json.Serialization;

namespace ElevenLabs;

[JsonSerializable(typeof(InputAudioChunk))]
[JsonSourceGenerationOptions(
    DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull)]
internal sealed partial class RealtimeJsonContext : JsonSerializerContext;
