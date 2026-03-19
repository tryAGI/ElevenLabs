namespace ElevenLabs.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public void RealtimeSpeechToTextOptions_Defaults_AreExpected()
    {
        var options = new RealtimeSpeechToTextOptions();

        options.AudioFormat.Should().Be(RealtimeAudioFormat.Pcm16000);
        options.CommitStrategy.Should().Be(RealtimeCommitStrategy.Manual);
        options.IncludeTimestamps.Should().BeFalse();
        options.IncludeLanguageDetection.Should().BeFalse();
    }
}
