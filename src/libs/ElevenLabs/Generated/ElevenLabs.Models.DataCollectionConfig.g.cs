
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// The agent's data collection items that steer follow-up calls. Each defaults<br/>
    /// to the built-in item for its purpose; `null` turns it off.
    /// </summary>
    public sealed partial class DataCollectionConfig
    {
        /// <summary>
        /// The item holding when the contact asked to be called back.<br/>
        /// Default Value: __system_data_collection_callback_time
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("callback_time")]
        public string? CallbackTime { get; set; }

        /// <summary>
        /// The item holding another number the contact asked to be called on.<br/>
        /// Default Value: __system_data_collection_redirect_phone_number
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("redirect_phone_number")]
        public string? RedirectPhoneNumber { get; set; }

        /// <summary>
        /// The item that is true when the contact asked not to be called again.<br/>
        /// Default Value: __system_data_collection_do_not_call
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
        /// Initializes a new instance of the <see cref="DataCollectionConfig" /> class.
        /// </summary>
        /// <param name="callbackTime">
        /// The item holding when the contact asked to be called back.<br/>
        /// Default Value: __system_data_collection_callback_time
        /// </param>
        /// <param name="redirectPhoneNumber">
        /// The item holding another number the contact asked to be called on.<br/>
        /// Default Value: __system_data_collection_redirect_phone_number
        /// </param>
        /// <param name="stop">
        /// The item that is true when the contact asked not to be called again.<br/>
        /// Default Value: __system_data_collection_do_not_call
        /// </param>
        /// <param name="mappings">
        /// Copies data collection results into dynamic variables for later calls: each key is a data collection item ID and its value the variable's name.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DataCollectionConfig(
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
        /// Initializes a new instance of the <see cref="DataCollectionConfig" /> class.
        /// </summary>
        public DataCollectionConfig()
        {
        }

    }
}