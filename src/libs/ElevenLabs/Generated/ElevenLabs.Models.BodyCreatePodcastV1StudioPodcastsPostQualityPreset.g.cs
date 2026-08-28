
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Output quality of the generated audio. Must be one of:<br/>
    /// 'standard' - standard output format, 128kbps with 44.1kHz sample rate.<br/>
    /// 'high' - high quality output format, 192kbps with 44.1kHz sample rate and major improvements on our side.<br/>
    /// 'ultra' - ultra quality output format, 192kbps with 44.1kHz sample rate and highest improvements on our side.<br/>
    /// 'ultra_lossless' - ultra quality output format, 705.6kbps with 44.1kHz sample rate and highest improvements on our side in a fully lossless format.<br/>
    /// If not provided, defaults to the highest quality preset available on your subscription tier.
    /// </summary>
    public sealed partial class BodyCreatePodcastV1StudioPodcastsPostQualityPreset
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}