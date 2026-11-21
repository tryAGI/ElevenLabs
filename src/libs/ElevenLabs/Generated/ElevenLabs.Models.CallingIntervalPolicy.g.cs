
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CallingIntervalPolicy
    {
        /// <summary>
        /// Local start time, as `HH:MM`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Start { get; set; }

        /// <summary>
        /// Local end time, as `HH:MM`; `24:00` ends at midnight.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string End { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CallingIntervalPolicy" /> class.
        /// </summary>
        /// <param name="start">
        /// Local start time, as `HH:MM`.
        /// </param>
        /// <param name="end">
        /// Local end time, as `HH:MM`; `24:00` ends at midnight.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CallingIntervalPolicy(
            string start,
            string end)
        {
            this.Start = start ?? throw new global::System.ArgumentNullException(nameof(start));
            this.End = end ?? throw new global::System.ArgumentNullException(nameof(end));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CallingIntervalPolicy" /> class.
        /// </summary>
        public CallingIntervalPolicy()
        {
        }

    }
}