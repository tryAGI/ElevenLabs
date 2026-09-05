
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AllowedValues
    {
        /// <summary>
        /// Name of a dynamic variable that must resolve to a JSON array of permitted values, e.g. ["ws_alpha", "ws_beta"]. System variables work only if they resolve to a list.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dynamic_variable")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DynamicVariable { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AllowedValues" /> class.
        /// </summary>
        /// <param name="dynamicVariable">
        /// Name of a dynamic variable that must resolve to a JSON array of permitted values, e.g. ["ws_alpha", "ws_beta"]. System variables work only if they resolve to a list.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AllowedValues(
            string dynamicVariable)
        {
            this.DynamicVariable = dynamicVariable ?? throw new global::System.ArgumentNullException(nameof(dynamicVariable));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AllowedValues" /> class.
        /// </summary>
        public AllowedValues()
        {
        }

    }
}