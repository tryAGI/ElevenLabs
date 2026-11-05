
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class WorkspaceNow
    {
        /// <summary>
        /// Represents a calendar date as individual numeric components.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("today")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.DateModel Today { get; set; }

        /// <summary>
        /// Current hour (0-23)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hour")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Hour { get; set; }

        /// <summary>
        /// Current minute (0-59)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("minute")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Minute { get; set; }

        /// <summary>
        /// Unix timestamp in milliseconds when this was generated
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fetched_at_ms")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long FetchedAtMs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkspaceNow" /> class.
        /// </summary>
        /// <param name="today">
        /// Represents a calendar date as individual numeric components.
        /// </param>
        /// <param name="hour">
        /// Current hour (0-23)
        /// </param>
        /// <param name="minute">
        /// Current minute (0-59)
        /// </param>
        /// <param name="fetchedAtMs">
        /// Unix timestamp in milliseconds when this was generated
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WorkspaceNow(
            global::ElevenLabs.DateModel today,
            int hour,
            int minute,
            long fetchedAtMs)
        {
            this.Today = today ?? throw new global::System.ArgumentNullException(nameof(today));
            this.Hour = hour;
            this.Minute = minute;
            this.FetchedAtMs = fetchedAtMs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkspaceNow" /> class.
        /// </summary>
        public WorkspaceNow()
        {
        }

    }
}