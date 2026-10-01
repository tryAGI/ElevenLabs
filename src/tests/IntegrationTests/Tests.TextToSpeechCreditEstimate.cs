namespace ElevenLabs.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public void TextToSpeechCreditEstimate_UsesKnownSelfServeRatesWithoutNetwork()
    {
        using var client = new TextToSpeechClient();

        var multilingual = client.EstimateCredits("Hello world", "eleven_multilingual_v2");
        multilingual.CharacterCount.Should().Be(11);
        multilingual.Credits.Should().Be(11m);
        multilingual.ApproxUsd.Should().BeNull();

        var flash = client.EstimateCredits("Hello world", "eleven_flash_v2_5");
        flash.Credits.Should().Be(5.5m);
    }

    [TestMethod]
    public void TextToSpeechCreditEstimate_AppliesPlanAndVoiceOverrides()
    {
        using var client = new TextToSpeechClient();

        var estimate = client.EstimateCredits(
            "Hi 👋",
            "custom-model",
            creditsPerCharacter: 0.75m,
            voiceMultiplier: 1.5m,
            usdPerCredit: 0.001m);

        estimate.CharacterCount.Should().Be(4);
        estimate.Credits.Should().Be(4.5m);
        estimate.ApproxUsd.Should().Be(0.0045m);
    }

    [TestMethod]
    public void TextToSpeechCreditEstimate_RequiresUnknownModelRate()
    {
        using var client = new TextToSpeechClient();

        Action estimate = () => client.EstimateCredits("Hello", "custom-model");
        estimate.Should().Throw<ArgumentException>();
    }
}
