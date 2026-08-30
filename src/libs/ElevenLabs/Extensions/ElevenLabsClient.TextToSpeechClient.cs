#nullable enable
#pragma warning disable MEAI001

using System.Runtime.CompilerServices;
using Microsoft.Extensions.AI;

namespace ElevenLabs;

public sealed partial class ElevenLabsClient : Microsoft.Extensions.AI.ITextToSpeechClient
{
    private const string DefaultTtsModel = "eleven_flash_v2_5";
    private const TextToSpeechFullOutputFormat DefaultFullOutputFormat = TextToSpeechFullOutputFormat.Mp344100128;
    private const TextToSpeechStreamOutputFormat DefaultStreamOutputFormat = TextToSpeechStreamOutputFormat.Mp344100128;
    private TextToSpeechClientMetadata? _textToSpeechMetadata;

    object? Microsoft.Extensions.AI.ITextToSpeechClient.GetService(Type serviceType, object? serviceKey)
    {
        ArgumentNullException.ThrowIfNull(serviceType);

        return serviceKey is not null ? null :
            serviceType == typeof(TextToSpeechClientMetadata) ? (_textToSpeechMetadata ??= new("elevenlabs", new Uri(DefaultBaseUrl), DefaultTtsModel)) :
            serviceType.IsInstanceOfType(this) ? this :
            null;
    }

    async Task<TextToSpeechResponse> Microsoft.Extensions.AI.ITextToSpeechClient.GetAudioAsync(
        string text,
        TextToSpeechOptions? options,
        CancellationToken cancellationToken)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(text);

        var voiceId = ResolveVoiceId(options);
        var request = CreateFullRequest(text, options);
        var outputFormat = ResolveFullOutputFormat(options);
        var audio = await TextToSpeech.ConvertAsync(
            voiceId: voiceId,
            request: request,
            enableLogging: options.GetBool(ElevenLabsTextToSpeechPropertyNames.EnableLogging),
            optimizeStreamingLatency: options.GetInt(ElevenLabsTextToSpeechPropertyNames.OptimizeStreamingLatency),
            outputFormat: outputFormat,
            cancellationToken: cancellationToken).ConfigureAwait(false);

        return new TextToSpeechResponse([
            new DataContent(audio, GetMediaType(outputFormat.ToValueString())),
        ])
        {
            ResponseId = TextToSpeech.LastRequestId,
            ModelId = request.ModelId,
            RawRepresentation = request,
            AdditionalProperties = CreateResponseProperties(
                modelId: request.ModelId,
                voiceId: voiceId,
                outputFormat: outputFormat.ToValueString(),
                mediaType: GetMediaType(outputFormat.ToValueString()),
                requestId: TextToSpeech.LastRequestId),
        };
    }

    async IAsyncEnumerable<TextToSpeechResponseUpdate> Microsoft.Extensions.AI.ITextToSpeechClient.GetStreamingAudioAsync(
        string text,
        TextToSpeechOptions? options,
        [EnumeratorCancellation] CancellationToken cancellationToken)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(text);

        var voiceId = ResolveVoiceId(options);
        var request = CreateStreamRequest(text, options);
        var outputFormat = ResolveStreamOutputFormat(options);
        var responseId = Guid.NewGuid().ToString("N");
        var outputFormatId = outputFormat.ToValueString();
        var mediaType = GetMediaType(outputFormatId);

        yield return new TextToSpeechResponseUpdate
        {
            Kind = TextToSpeechResponseUpdateKind.SessionOpen,
            ResponseId = responseId,
            ModelId = request.ModelId,
            RawRepresentation = request,
            AdditionalProperties = CreateResponseProperties(
                modelId: request.ModelId,
                voiceId: voiceId,
                outputFormat: outputFormatId,
                mediaType: mediaType),
        };

        using var stream = await TextToSpeech.StreamAsync(
            voiceId: voiceId,
            request: request,
            enableLogging: options.GetBool(ElevenLabsTextToSpeechPropertyNames.EnableLogging),
            optimizeStreamingLatency: options.GetInt(ElevenLabsTextToSpeechPropertyNames.OptimizeStreamingLatency),
            outputFormat: outputFormat,
            cancellationToken: cancellationToken).ConfigureAwait(false);

        var requestId = TextToSpeech.LastRequestId;
        var buffer = new byte[16 * 1024];
        while (true)
        {
            var bytesRead = await stream.ReadAsync(buffer, cancellationToken).ConfigureAwait(false);
            if (bytesRead <= 0)
            {
                break;
            }

            var chunk = buffer.AsSpan(0, bytesRead).ToArray();
            yield return new TextToSpeechResponseUpdate([
                new DataContent(chunk, mediaType),
            ])
            {
                Kind = TextToSpeechResponseUpdateKind.AudioUpdating,
                ResponseId = requestId ?? responseId,
                ModelId = request.ModelId,
                AdditionalProperties = CreateResponseProperties(
                    modelId: request.ModelId,
                    voiceId: voiceId,
                    outputFormat: outputFormatId,
                    mediaType: mediaType,
                    requestId: requestId),
            };
        }

        yield return new TextToSpeechResponseUpdate
        {
            Kind = TextToSpeechResponseUpdateKind.AudioUpdated,
            ResponseId = requestId ?? responseId,
            ModelId = request.ModelId,
            AdditionalProperties = CreateResponseProperties(
                modelId: request.ModelId,
                voiceId: voiceId,
                outputFormat: outputFormatId,
                mediaType: mediaType,
                requestId: requestId),
        };

        yield return new TextToSpeechResponseUpdate
        {
            Kind = TextToSpeechResponseUpdateKind.SessionClose,
            ResponseId = requestId ?? responseId,
            ModelId = request.ModelId,
        };
    }

    private BodyTextToSpeechFull CreateFullRequest(string text, TextToSpeechOptions? options)
    {
        var request = options?.RawRepresentationFactory?.Invoke(this) as BodyTextToSpeechFull
            ?? new BodyTextToSpeechFull { Text = text };

        if (string.IsNullOrWhiteSpace(request.Text))
        {
            request.Text = text;
        }

        ApplyCommonOptions(request, options);
        request.ApplyTextNormalization = ResolveFullTextNormalization(options, request.ApplyTextNormalization);

        return request;
    }

    private BodyTextToSpeechStream CreateStreamRequest(string text, TextToSpeechOptions? options)
    {
        var request = options?.RawRepresentationFactory?.Invoke(this) as BodyTextToSpeechStream
            ?? new BodyTextToSpeechStream { Text = text };

        if (string.IsNullOrWhiteSpace(request.Text))
        {
            request.Text = text;
        }

        ApplyCommonOptions(request, options);
        request.ApplyTextNormalization = ResolveStreamTextNormalization(options, request.ApplyTextNormalization);

        return request;
    }

    private static void ApplyCommonOptions(BodyTextToSpeechFull request, TextToSpeechOptions? options)
    {
        request.ModelId = options?.ModelId is { Length: > 0 } ? options.ModelId : request.ModelId ?? DefaultTtsModel;
        request.LanguageCode = options?.Language is { Length: > 0 } ? NormalizeLanguage(options.Language) : request.LanguageCode;
        request.Seed ??= options.GetInt(ElevenLabsTextToSpeechPropertyNames.Seed);
        request.PreviousText ??= options.GetString(ElevenLabsTextToSpeechPropertyNames.PreviousText);
        request.NextText ??= options.GetString(ElevenLabsTextToSpeechPropertyNames.NextText);
        request.VoiceSettings = CreateVoiceSettings(options, request.VoiceSettings);
    }

    private static void ApplyCommonOptions(BodyTextToSpeechStream request, TextToSpeechOptions? options)
    {
        request.ModelId = options?.ModelId is { Length: > 0 } ? options.ModelId : request.ModelId ?? DefaultTtsModel;
        request.LanguageCode = options?.Language is { Length: > 0 } ? NormalizeLanguage(options.Language) : request.LanguageCode;
        request.Seed ??= options.GetInt(ElevenLabsTextToSpeechPropertyNames.Seed);
        request.PreviousText ??= options.GetString(ElevenLabsTextToSpeechPropertyNames.PreviousText);
        request.NextText ??= options.GetString(ElevenLabsTextToSpeechPropertyNames.NextText);
        request.VoiceSettings = CreateVoiceSettings(options, request.VoiceSettings);
    }

    private static string ResolveVoiceId(TextToSpeechOptions? options) =>
        options?.VoiceId is { Length: > 0 } voiceId
            ? voiceId
            : throw new ArgumentException("ElevenLabs TTS requires TextToSpeechOptions.VoiceId to be set.", nameof(options));

    private static string NormalizeLanguage(string language)
    {
        var normalized = language.Split('-', '_')[0];
        return normalized.Length > 0 ? normalized : language;
    }

    private static VoiceSettingsResponseModel? CreateVoiceSettings(
        TextToSpeechOptions? options,
        VoiceSettingsResponseModel? voiceSettings)
    {
        if (options is null)
        {
            return voiceSettings;
        }

        voiceSettings ??= new VoiceSettingsResponseModel();
        voiceSettings.Speed ??= options.Speed;
        voiceSettings.Stability ??= options.GetDouble(ElevenLabsTextToSpeechPropertyNames.Stability);
        voiceSettings.SimilarityBoost ??= options.GetDouble(ElevenLabsTextToSpeechPropertyNames.SimilarityBoost);
        voiceSettings.Style ??= options.GetDouble(ElevenLabsTextToSpeechPropertyNames.Style);
        voiceSettings.UseSpeakerBoost ??= options.GetBool(ElevenLabsTextToSpeechPropertyNames.UseSpeakerBoost);

        return voiceSettings.Speed is null
            && voiceSettings.Stability is null
            && voiceSettings.SimilarityBoost is null
            && voiceSettings.Style is null
            && voiceSettings.UseSpeakerBoost is null
            && voiceSettings.AdditionalProperties.Count == 0
                ? null
                : voiceSettings;
    }

    private static TextToSpeechFullOutputFormat ResolveFullOutputFormat(TextToSpeechOptions? options)
    {
        var format = options.GetString(ElevenLabsTextToSpeechPropertyNames.OutputFormat)
            ?? options?.AudioFormat;

        if (format is not { Length: > 0 })
        {
            return DefaultFullOutputFormat;
        }

        return TextToSpeechFullOutputFormatExtensions.ToEnum(NormalizeFullOutputFormat(format))
            ?? throw new NotSupportedException($"Unsupported ElevenLabs TTS audio format '{format}'.");
    }

    private static TextToSpeechStreamOutputFormat ResolveStreamOutputFormat(TextToSpeechOptions? options)
    {
        var format = options.GetString(ElevenLabsTextToSpeechPropertyNames.OutputFormat)
            ?? options?.AudioFormat;

        if (format is not { Length: > 0 })
        {
            return DefaultStreamOutputFormat;
        }

        return TextToSpeechStreamOutputFormatExtensions.ToEnum(NormalizeStreamOutputFormat(format))
            ?? throw new NotSupportedException($"Unsupported ElevenLabs streaming TTS audio format '{format}'.");
    }

    private static string NormalizeFullOutputFormat(string format)
    {
        if (string.Equals(format, "audio/mpeg", StringComparison.OrdinalIgnoreCase)
            || string.Equals(format, "audio/mp3", StringComparison.OrdinalIgnoreCase)
            || string.Equals(format, "mp3", StringComparison.OrdinalIgnoreCase))
        {
            return "mp3_44100_128";
        }

        if (string.Equals(format, "audio/wav", StringComparison.OrdinalIgnoreCase)
            || string.Equals(format, "audio/wave", StringComparison.OrdinalIgnoreCase)
            || string.Equals(format, "wav", StringComparison.OrdinalIgnoreCase))
        {
            return "wav_44100";
        }

        if (string.Equals(format, "audio/pcm", StringComparison.OrdinalIgnoreCase)
            || string.Equals(format, "pcm", StringComparison.OrdinalIgnoreCase)
            || string.Equals(format, "pcm_s16le", StringComparison.OrdinalIgnoreCase))
        {
            return "pcm_24000";
        }

        return format;
    }

    private static string NormalizeStreamOutputFormat(string format)
    {
        if (string.Equals(format, "wav", StringComparison.OrdinalIgnoreCase)
            || string.Equals(format, "audio/wav", StringComparison.OrdinalIgnoreCase)
            || string.Equals(format, "audio/wave", StringComparison.OrdinalIgnoreCase))
        {
            throw new NotSupportedException("ElevenLabs streaming TTS does not expose WAV output. Use 'mp3', 'pcm_24000', 'pcm_s16le', 'ulaw_8000', or another streaming output format.");
        }

        return NormalizeFullOutputFormat(format);
    }

    private static BodyTextToSpeechFullApplyTextNormalization? ResolveFullTextNormalization(
        TextToSpeechOptions? options,
        BodyTextToSpeechFullApplyTextNormalization? current)
    {
        if (options.GetString(ElevenLabsTextToSpeechPropertyNames.ApplyTextNormalization) is not { } value)
        {
            return current;
        }

        return BodyTextToSpeechFullApplyTextNormalizationExtensions.ToEnum(value)
            ?? throw new ArgumentException($"Unknown ElevenLabs text normalization mode '{value}'.", nameof(options));
    }

    private static BodyTextToSpeechStreamApplyTextNormalization? ResolveStreamTextNormalization(
        TextToSpeechOptions? options,
        BodyTextToSpeechStreamApplyTextNormalization? current)
    {
        if (options.GetString(ElevenLabsTextToSpeechPropertyNames.ApplyTextNormalization) is not { } value)
        {
            return current;
        }

        return BodyTextToSpeechStreamApplyTextNormalizationExtensions.ToEnum(value)
            ?? throw new ArgumentException($"Unknown ElevenLabs text normalization mode '{value}'.", nameof(options));
    }

    private static string GetMediaType(string outputFormat)
    {
        if (outputFormat.StartsWith("mp3_", StringComparison.Ordinal))
        {
            return "audio/mpeg";
        }

        if (outputFormat.StartsWith("wav_", StringComparison.Ordinal))
        {
            return "audio/wav";
        }

        if (outputFormat.StartsWith("pcm_", StringComparison.Ordinal))
        {
            var sampleRate = outputFormat["pcm_".Length..];
            return $"audio/pcm;codec=s16le;rate={sampleRate};channels=1";
        }

        if (outputFormat.StartsWith("opus_", StringComparison.Ordinal))
        {
            return "audio/ogg;codecs=opus";
        }

        return outputFormat switch
        {
            "ulaw_8000" => "audio/basic;rate=8000;channels=1",
            "alaw_8000" => "audio/pcma;rate=8000;channels=1",
            _ => "application/octet-stream",
        };
    }

    private static AdditionalPropertiesDictionary CreateResponseProperties(
        string? modelId,
        string voiceId,
        string outputFormat,
        string mediaType,
        string? requestId = null)
    {
        AdditionalPropertiesDictionary properties = new()
        {
            ["voice_id"] = voiceId,
            [ElevenLabsTextToSpeechPropertyNames.OutputFormat] = outputFormat,
            ["media_type"] = mediaType,
        };

        if (modelId is { Length: > 0 })
        {
            properties["model_id"] = modelId;
        }

        if (requestId is { Length: > 0 })
        {
            properties["request_id"] = requestId;
        }

        return properties;
    }
}

internal static class ElevenLabsTextToSpeechOptionsExtensions
{
    public static bool? GetBool(this TextToSpeechOptions? options, string key)
    {
        if (options?.AdditionalProperties is not { } properties || !properties.TryGetValue(key, out var value))
        {
            return null;
        }

        return value switch
        {
            bool boolValue => boolValue,
            string text when bool.TryParse(text, out var parsed) => parsed,
            _ => null,
        };
    }

    public static double? GetDouble(this TextToSpeechOptions? options, string key)
    {
        if (options?.AdditionalProperties is not { } properties || !properties.TryGetValue(key, out var value))
        {
            return null;
        }

        return value switch
        {
            double doubleValue => doubleValue,
            float floatValue => floatValue,
            decimal decimalValue => (double)decimalValue,
            int intValue => intValue,
            long longValue => longValue,
            string text when double.TryParse(
                text,
                System.Globalization.NumberStyles.Float,
                System.Globalization.CultureInfo.InvariantCulture,
                out var parsed) => parsed,
            _ => null,
        };
    }

    public static int? GetInt(this TextToSpeechOptions? options, string key)
    {
        if (options?.AdditionalProperties is not { } properties || !properties.TryGetValue(key, out var value))
        {
            return null;
        }

        return value switch
        {
            int intValue => intValue,
            long longValue when longValue is >= int.MinValue and <= int.MaxValue => (int)longValue,
            string text when int.TryParse(text, out var parsed) => parsed,
            _ => null,
        };
    }

    public static string? GetString(this TextToSpeechOptions? options, string key)
    {
        return options?.AdditionalProperties is { } properties
            && properties.TryGetValue(key, out var value)
            && value is string text
            && text.Length > 0
                ? text
                : null;
    }
}
