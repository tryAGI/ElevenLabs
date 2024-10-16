
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// This is the documentation for the ElevenLabs API. You can use this API to use our service programmatically, this is done by using your xi-api-key. &lt;br/&gt; You can view your xi-api-key using the 'Profile' tab on https://elevenlabs.io. Our API is experimental so all endpoints are subject to change.<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public sealed partial class ElevenLabsClient : global::ElevenLabs.IElevenLabsClient, global::System.IDisposable
    {
        /// <summary>
        /// 
        /// </summary>
        public const string BaseUrl = "https://api.elevenlabs.io";

        private readonly global::System.Net.Http.HttpClient _httpClient;
        private global::System.Collections.Generic.List<global::ElevenLabs.EndPointAuthorization> _authorizations;

        /// <summary>
        /// 
        /// </summary>
        public global::System.Text.Json.Serialization.JsonSerializerContext JsonSerializerContext { get; set; } = global::ElevenLabs.SourceGenerationContext.Default;


        /// <summary>
        /// Convert text into lifelike speech using a voice of your choice.
        /// </summary>
        public TextToSpeechClient TextToSpeech => new TextToSpeechClient(_httpClient, authorizations: _authorizations)
        {
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// Create speech by combining the style and content of an audio file you upload with a voice of your choice.
        /// </summary>
        public SpeechToSpeechClient SpeechToSpeech => new SpeechToSpeechClient(_httpClient, authorizations: _authorizations)
        {
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// Access the different models of the platform.
        /// </summary>
        public ModelsClient Models => new ModelsClient(_httpClient, authorizations: _authorizations)
        {
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// Access to voices created either by you or us.
        /// </summary>
        public VoicesClient Voices => new VoicesClient(_httpClient, authorizations: _authorizations)
        {
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// Access to your samples. A sample is any audio file you attached to a voice. A voice can have one or more samples.
        /// </summary>
        public SamplesClient Samples => new SamplesClient(_httpClient, authorizations: _authorizations)
        {
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// Accesses your speech history. Your speech history is a list of all your created audio including its metadata using our text-to-speech and speech-to-speech models.
        /// </summary>
        public SpeechHistoryClient SpeechHistory => new SpeechHistoryClient(_httpClient, authorizations: _authorizations)
        {
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// Access, create and convert Projects programmatically, only specifically whitelisted accounts can access the Projects API. If you need access please contact our sales team.
        /// </summary>
        public ProjectsClient Projects => new ProjectsClient(_httpClient, authorizations: _authorizations)
        {
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// 
        /// </summary>
        public SoundGenerationClient SoundGeneration => new SoundGenerationClient(_httpClient, authorizations: _authorizations)
        {
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// 
        /// </summary>
        public AudioIsolationClient AudioIsolation => new AudioIsolationClient(_httpClient, authorizations: _authorizations)
        {
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// 
        /// </summary>
        public VoiceGenerationClient VoiceGeneration => new VoiceGenerationClient(_httpClient, authorizations: _authorizations)
        {
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// 
        /// </summary>
        public UserClient User => new UserClient(_httpClient, authorizations: _authorizations)
        {
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// 
        /// </summary>
        public DubbingClient Dubbing => new DubbingClient(_httpClient, authorizations: _authorizations)
        {
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// 
        /// </summary>
        public WorkspaceClient Workspace => new WorkspaceClient(_httpClient, authorizations: _authorizations)
        {
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// 
        /// </summary>
        public AudioNativeClient AudioNative => new AudioNativeClient(_httpClient, authorizations: _authorizations)
        {
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// 
        /// </summary>
        public UsageClient Usage => new UsageClient(_httpClient, authorizations: _authorizations)
        {
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// 
        /// </summary>
        public PronunciationDictionaryClient PronunciationDictionary => new PronunciationDictionaryClient(_httpClient, authorizations: _authorizations)
        {
            JsonSerializerContext = JsonSerializerContext,
        };

        /// <summary>
        /// Creates a new instance of the ElevenLabsClient.
        /// If no httpClient is provided, a new one will be created.
        /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
        /// </summary>
        /// <param name="httpClient"></param>
        /// <param name="baseUri"></param>
        /// <param name="authorizations"></param>
        public ElevenLabsClient(
            global::System.Net.Http.HttpClient? httpClient = null,
            global::System.Uri? baseUri = null,
            global::System.Collections.Generic.List<global::ElevenLabs.EndPointAuthorization>? authorizations = null)
        {
            _httpClient = httpClient ?? new global::System.Net.Http.HttpClient();
            _httpClient.BaseAddress ??= baseUri ?? new global::System.Uri(BaseUrl);
            _authorizations = authorizations ?? new global::System.Collections.Generic.List<global::ElevenLabs.EndPointAuthorization>();

            Initialized(_httpClient);
        }

        /// <inheritdoc/>
        public void Dispose()
        {
            _httpClient.Dispose();
        }

        partial void Initialized(
            global::System.Net.Http.HttpClient client);
        partial void PrepareArguments(
            global::System.Net.Http.HttpClient client);
        partial void PrepareRequest(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpRequestMessage request);
        partial void ProcessResponse(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpResponseMessage response);
        partial void ProcessResponseContent(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpResponseMessage response,
            ref string content);
    }
}