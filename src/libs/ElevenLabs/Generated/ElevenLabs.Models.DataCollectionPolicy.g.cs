
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DataCollectionPolicy
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("callback_time")]
        public string? CallbackTime { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("redirect_phone_number")]
        public string? RedirectPhoneNumber { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stop")]
        public string? Stop { get; set; }

        /// <summary>
        /// Copies data collection results into dynamic variables for later calls: each key is a data collection item ID and its value the variable's name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mappings")]
        public global::System.Collections.Generic.Dictionary<string, string>? Mappings { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DataCollectionPolicy" /> class.
        /// </summary>
        /// <param name="callbackTime"></param>
        /// <param name="redirectPhoneNumber"></param>
        /// <param name="stop"></param>
        /// <param name="mappings">
        /// Copies data collection results into dynamic variables for later calls: each key is a data collection item ID and its value the variable's name.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DataCollectionPolicy(
            string? callbackTime,
            string? redirectPhoneNumber,
            string? stop,
            global::System.Collections.Generic.Dictionary<string, string>? mappings)
        {
            this.CallbackTime = callbackTime;
            this.RedirectPhoneNumber = redirectPhoneNumber;
            this.Stop = stop;
            this.Mappings = mappings;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataCollectionPolicy" /> class.
        /// </summary>
        public DataCollectionPolicy()
        {
        }

    }
}