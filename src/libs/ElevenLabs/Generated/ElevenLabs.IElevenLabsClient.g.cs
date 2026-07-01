
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// This is the documentation for the ElevenLabs API. You can use this API to use our service programmatically, this is done by using your API key. You can find your API key in the dashboard at https://elevenlabs.io/app/settings/api-keys.<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public partial interface IElevenLabsClient : global::System.IDisposable
    {
        /// <summary>
        /// The HttpClient instance.
        /// </summary>
        public global::System.Net.Http.HttpClient HttpClient { get; }

        /// <summary>
        /// The base URL for the API.
        /// </summary>
        public System.Uri? BaseUri { get; }

        /// <summary>
        /// The authorizations to use for the requests.
        /// </summary>
        public global::System.Collections.Generic.List<global::ElevenLabs.EndPointAuthorization> Authorizations { get; }

        /// <summary>
        /// Gets or sets a value indicating whether the response content should be read as a string.
        /// True by default in debug builds, false otherwise.
        /// When false, successful responses are deserialized directly from the response stream for better performance.
        /// Error responses are always read as strings regardless of this setting,
        /// ensuring <see cref="ApiException.ResponseBody"/> is populated.
        /// </summary>
        public bool ReadResponseAsString { get; set; }
        /// <summary>
        /// Client-wide request defaults such as headers, query parameters, retries, and timeout.
        /// </summary>
        public global::ElevenLabs.AutoSDKClientOptions Options { get; }


        /// <summary>
        /// 
        /// </summary>
        global::System.Text.Json.Serialization.JsonSerializerContext JsonSerializerContext { get; set; }


        /// <summary>
        /// Endpoints accessible to all authenticated callers regardless of scope.
        /// </summary>
        public AccessAllClient AccessAll { get; }

        /// <summary>
        /// Query analytics and insights about agent conversations and performance.
        /// </summary>
        public AgentsInsightsClient AgentsInsights { get; }

        /// <summary>
        /// Build, configure and manage Conversational AI agents, knowledge bases, tools, and conversations.
        /// </summary>
        public AgentsPlatformClient AgentsPlatform { get; }

        /// <summary>
        /// Workspace-level analytics for Conversational AI usage.
        /// </summary>
        public AgentsWorkspaceAnalyticsClient AgentsWorkspaceAnalytics { get; }

        /// <summary>
        /// 
        /// </summary>
        public AudioIsolationClient AudioIsolation { get; }

        /// <summary>
        /// 
        /// </summary>
        public AudioNativeClient AudioNative { get; }

        /// <summary>
        /// Build and manage conversational AI agents (legacy tag — see also Agents Platform).
        /// </summary>
        public ConversationalAiClient ConversationalAi { get; }

        /// <summary>
        /// 
        /// </summary>
        public ConversationalAi2Client ConversationalAi2 { get; }

        /// <summary>
        /// Dub audio and video content into other languages while preserving the original speaker's voice.
        /// </summary>
        public DubbingClient Dubbing { get; }

        /// <summary>
        /// 
        /// </summary>
        public EnvironmentVariablesClient EnvironmentVariables { get; }

        /// <summary>
        /// 
        /// </summary>
        public ForcedAlignmentClient ForcedAlignment { get; }

        /// <summary>
        /// 
        /// </summary>
        public HistoryClient History { get; }

        /// <summary>
        /// Access the different models of the platform.
        /// </summary>
        public ModelsClient Models { get; }

        /// <summary>
        /// 
        /// </summary>
        public MusicClient Music { get; }

        /// <summary>
        /// Generate music from a text prompt.
        /// </summary>
        public MusicGenerationClient MusicGeneration { get; }

        /// <summary>
        /// Access and manage ElevenProductions orders.
        /// </summary>
        public ProductionsClient Productions { get; }

        /// <summary>
        /// 
        /// </summary>
        public PronunciationDictionariesClient PronunciationDictionaries { get; }

        /// <summary>
        /// Manage pronunciation dictionaries that override how specific words are pronounced.
        /// </summary>
        public PronunciationDictionaryClient PronunciationDictionary { get; }

        /// <summary>
        /// Create and manage Professional Voice Clones (PVCs).
        /// </summary>
        public PvcVoicesClient PvcVoices { get; }

        /// <summary>
        /// Access to your samples. A sample is any audio file you attached to a voice. A voice can have one or more samples.
        /// </summary>
        public SamplesClient Samples { get; }

        /// <summary>
        /// Mint short-lived, single-use tokens for client-side use of Conversational AI agents.
        /// </summary>
        public SingleUseTokenClient SingleUseToken { get; }

        /// <summary>
        /// 
        /// </summary>
        public SpeechEngineClient SpeechEngine { get; }

        /// <summary>
        /// 
        /// </summary>
        public SpeechToSpeechClient SpeechToSpeech { get; }

        /// <summary>
        /// Transcribe your audio files with detailed speaker annotations and precise timestamps using our cutting-edge model.
        /// </summary>
        public SpeechToTextClient SpeechToText { get; }

        /// <summary>
        /// 
        /// </summary>
        public SpeechToText2Client SpeechToText2 { get; }

        /// <summary>
        /// Access, create and convert Studio Projects programmatically. Only specifically whitelisted accounts can access the Studio API. If you need access please contact our sales team.
        /// </summary>
        public StudioClient Studio { get; }

        /// <summary>
        /// 
        /// </summary>
        public TextToDialogueClient TextToDialogue { get; }

        /// <summary>
        /// 
        /// </summary>
        public TextToSoundEffectsClient TextToSoundEffects { get; }

        /// <summary>
        /// 
        /// </summary>
        public TextToSpeechClient TextToSpeech { get; }

        /// <summary>
        /// Design and generate custom voices from a text prompt.
        /// </summary>
        public TextToVoiceClient TextToVoice { get; }

        /// <summary>
        /// 
        /// </summary>
        public TextToVoice2Client TextToVoice2 { get; }

        /// <summary>
        /// 
        /// </summary>
        public UserClient User { get; }

        /// <summary>
        /// Access to voices created either by you or ElevenLabs.
        /// </summary>
        public VoicesClient Voices { get; }

        /// <summary>
        /// 
        /// </summary>
        public WebhooksClient Webhooks { get; }

        /// <summary>
        /// Access to workspace related endpoints.
        /// </summary>
        public WorkspaceClient Workspace { get; }

    }
}