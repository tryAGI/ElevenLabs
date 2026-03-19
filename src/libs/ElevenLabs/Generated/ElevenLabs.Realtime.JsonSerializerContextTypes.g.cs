
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace ElevenLabs.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class JsonSerializerContextTypes
    {
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? StringStringDictionary { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, object>? StringObjectDictionary { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public global::System.Text.Json.JsonElement? JsonElement { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public global::ElevenLabs.Realtime.InputAudioChunkPayload? Type0 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ElevenLabs.Realtime.InputAudioChunkPayloadMessageType? Type1 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string? Type2 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool? Type3 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int? Type4 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ElevenLabs.Realtime.SessionConfig? Type5 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? Type6 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ElevenLabs.Realtime.SessionStartedPayload? Type7 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ElevenLabs.Realtime.SessionStartedPayloadMessageType? Type8 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ElevenLabs.Realtime.PartialTranscriptPayload? Type9 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ElevenLabs.Realtime.PartialTranscriptPayloadMessageType? Type10 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ElevenLabs.Realtime.CommittedTranscriptPayload? Type11 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ElevenLabs.Realtime.CommittedTranscriptPayloadMessageType? Type12 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ElevenLabs.Realtime.TranscriptionWord? Type13 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ElevenLabs.Realtime.TranscriptionWordType? Type14 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<string>? Type15 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ElevenLabs.Realtime.CommittedTranscriptWithTimestampsPayload? Type16 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ElevenLabs.Realtime.CommittedTranscriptWithTimestampsPayloadMessageType? Type17 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.Realtime.TranscriptionWord>? Type18 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ElevenLabs.Realtime.ErrorPayload? Type19 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ElevenLabs.Realtime.ErrorPayloadMessageType? Type20 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ElevenLabs.Realtime.ServerEvent? Type21 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ElevenLabs.Realtime.ServerEventDiscriminator? Type22 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::ElevenLabs.Realtime.ServerEventDiscriminatorMessageType? Type23 { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<string>? ListType0 { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.Realtime.TranscriptionWord>? ListType1 { get; set; }
    }
}