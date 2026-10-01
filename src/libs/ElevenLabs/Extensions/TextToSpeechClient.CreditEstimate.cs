using System.Text;

namespace ElevenLabs;

/// <summary>
/// A local estimate of text-to-speech usage. Actual charges may differ by plan, model, or voice.
/// </summary>
public sealed record TextToSpeechCreditEstimate(
    int CharacterCount,
    decimal Credits,
    decimal? ApproxUsd);

/// <summary>
/// Local text-to-speech usage estimates for generated clients.
/// </summary>
public static class TextToSpeechClientCreditExtensions
{
    /// <summary>
    /// Estimates credits before sending a text-to-speech request, without contacting ElevenLabs.
    /// Known model defaults reflect self-serve API pricing; supply <paramref name="creditsPerCharacter"/>
    /// for other models or negotiated plan rates. Supply <paramref name="voiceMultiplier"/> for a
    /// voice with a custom rate, and <paramref name="usdPerCredit"/> for a plan-specific dollar estimate.
    /// </summary>
    public static TextToSpeechCreditEstimate EstimateCredits(
        this TextToSpeechClient client,
        string text,
        string modelId,
        decimal? creditsPerCharacter = null,
        decimal voiceMultiplier = 1m,
        decimal? usdPerCredit = null)
    {
        ArgumentNullException.ThrowIfNull(client);
        ArgumentNullException.ThrowIfNull(text);
        ArgumentException.ThrowIfNullOrWhiteSpace(modelId);

        var rate = creditsPerCharacter ?? modelId switch
        {
            "eleven_multilingual_v2" or "eleven_multilingual_v1" or "eleven_english_v1" => 1m,
            "eleven_flash_v2" or "eleven_flash_v2_5" or
            "eleven_turbo_v2" or "eleven_turbo_v2_5" => 0.5m,
            _ => throw new ArgumentException(
                "Unknown model rate. Supply creditsPerCharacter for this model and plan.",
                nameof(modelId)),
        };

        ArgumentOutOfRangeException.ThrowIfNegativeOrZero(rate);
        ArgumentOutOfRangeException.ThrowIfNegativeOrZero(voiceMultiplier);
        if (usdPerCredit is { } dollarRate)
        {
            ArgumentOutOfRangeException.ThrowIfNegative(dollarRate);
        }

        var characterCount = text.EnumerateRunes().Count();
        var credits = characterCount * rate * voiceMultiplier;
        return new TextToSpeechCreditEstimate(
            characterCount,
            credits,
            usdPerCredit is { } dollarsPerCredit ? credits * dollarsPerCredit : null);
    }
}
