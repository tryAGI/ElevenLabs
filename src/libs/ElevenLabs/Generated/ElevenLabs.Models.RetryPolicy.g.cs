
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RetryPolicy
    {
        /// <summary>
        /// How long to wait before a short retry.<br/>
        /// Default Value: 600
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("retry_delay_seconds")]
        public int? RetryDelaySeconds { get; set; }

        /// <summary>
        /// Retries a calling window allows after a failed call. Once used up, the next retry waits for the following window, which starts afresh.<br/>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_short_retries")]
        public int? MaxShortRetries { get; set; }

        /// <summary>
        /// The most calls a lead gets, counting the first.<br/>
        /// Default Value: 6
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_total_calls")]
        public int? MaxTotalCalls { get; set; }

        /// <summary>
        /// The most callbacks to honor for one number.<br/>
        /// Default Value: 2
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_callbacks")]
        public int? MaxCallbacks { get; set; }

        /// <summary>
        /// The most times a lead follows a request to call another number.<br/>
        /// Default Value: 2
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_redirects")]
        public int? MaxRedirects { get; set; }

        /// <summary>
        /// Where in a later calling window a pushed-back call lands: at its `start`, at a `random` time, or `rotate`d `rotate_step_seconds` past where the last call in that window failed.<br/>
        /// Default Value: start
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("interval_placement")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.IntervalPlacementJsonConverter))]
        public global::ElevenLabs.IntervalPlacement? IntervalPlacement { get; set; }

        /// <summary>
        /// How far `rotate` placement moves each call. Only used by `rotate`.<br/>
        /// Default Value: 900
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rotate_step_seconds")]
        public int? RotateStepSeconds { get; set; }

        /// <summary>
        /// Calls to one number that may fail in a row before the lead moves on to its next listed number, or ends when there is none. An answered call, or a redirect to a new number, restarts the count. Unset leaves only `max_total_calls`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_consecutive_failures_per_number")]
        public int? MaxConsecutiveFailuresPerNumber { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RetryPolicy" /> class.
        /// </summary>
        /// <param name="retryDelaySeconds">
        /// How long to wait before a short retry.<br/>
        /// Default Value: 600
        /// </param>
        /// <param name="maxShortRetries">
        /// Retries a calling window allows after a failed call. Once used up, the next retry waits for the following window, which starts afresh.<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="maxTotalCalls">
        /// The most calls a lead gets, counting the first.<br/>
        /// Default Value: 6
        /// </param>
        /// <param name="maxCallbacks">
        /// The most callbacks to honor for one number.<br/>
        /// Default Value: 2
        /// </param>
        /// <param name="maxRedirects">
        /// The most times a lead follows a request to call another number.<br/>
        /// Default Value: 2
        /// </param>
        /// <param name="intervalPlacement">
        /// Where in a later calling window a pushed-back call lands: at its `start`, at a `random` time, or `rotate`d `rotate_step_seconds` past where the last call in that window failed.<br/>
        /// Default Value: start
        /// </param>
        /// <param name="rotateStepSeconds">
        /// How far `rotate` placement moves each call. Only used by `rotate`.<br/>
        /// Default Value: 900
        /// </param>
        /// <param name="maxConsecutiveFailuresPerNumber">
        /// Calls to one number that may fail in a row before the lead moves on to its next listed number, or ends when there is none. An answered call, or a redirect to a new number, restarts the count. Unset leaves only `max_total_calls`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RetryPolicy(
            int? retryDelaySeconds,
            int? maxShortRetries,
            int? maxTotalCalls,
            int? maxCallbacks,
            int? maxRedirects,
            global::ElevenLabs.IntervalPlacement? intervalPlacement,
            int? rotateStepSeconds,
            int? maxConsecutiveFailuresPerNumber)
        {
            this.RetryDelaySeconds = retryDelaySeconds;
            this.MaxShortRetries = maxShortRetries;
            this.MaxTotalCalls = maxTotalCalls;
            this.MaxCallbacks = maxCallbacks;
            this.MaxRedirects = maxRedirects;
            this.IntervalPlacement = intervalPlacement;
            this.RotateStepSeconds = rotateStepSeconds;
            this.MaxConsecutiveFailuresPerNumber = maxConsecutiveFailuresPerNumber;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RetryPolicy" /> class.
        /// </summary>
        public RetryPolicy()
        {
        }

    }
}