
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetAvailableVoicesInput
    {
        /// <summary>
        /// Optional search query to filter voices by name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("search")]
        public string? Search { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAvailableVoicesInput" /> class.
        /// </summary>
        /// <param name="search">
        /// Optional search query to filter voices by name.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetAvailableVoicesInput(
            string? search)
        {
            this.Search = search;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAvailableVoicesInput" /> class.
        /// </summary>
        public GetAvailableVoicesInput()
        {
        }
    }
}