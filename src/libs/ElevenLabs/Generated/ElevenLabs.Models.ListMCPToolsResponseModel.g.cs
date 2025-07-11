
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Response model for testing tools available on an MCP server.
    /// </summary>
    public sealed partial class ListMCPToolsResponseModel
    {
        /// <summary>
        /// Indicates if the operation was successful.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("success")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Success { get; set; }

        /// <summary>
        /// A list of tools available on the MCP server.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::ElevenLabs.Tool> Tools { get; set; }

        /// <summary>
        /// Error message if the operation was not successful.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_message")]
        public string? ErrorMessage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListMCPToolsResponseModel" /> class.
        /// </summary>
        /// <param name="success">
        /// Indicates if the operation was successful.
        /// </param>
        /// <param name="tools">
        /// A list of tools available on the MCP server.
        /// </param>
        /// <param name="errorMessage">
        /// Error message if the operation was not successful.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListMCPToolsResponseModel(
            bool success,
            global::System.Collections.Generic.IList<global::ElevenLabs.Tool> tools,
            string? errorMessage)
        {
            this.Success = success;
            this.Tools = tools ?? throw new global::System.ArgumentNullException(nameof(tools));
            this.ErrorMessage = errorMessage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListMCPToolsResponseModel" /> class.
        /// </summary>
        public ListMCPToolsResponseModel()
        {
        }
    }
}