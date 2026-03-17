
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateEnvironmentVariableRequest
    {
        /// <summary>
        /// Values to replace. Set to null to remove an environment (except 'production').
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("values")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Values { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateEnvironmentVariableRequest" /> class.
        /// </summary>
        /// <param name="values">
        /// Values to replace. Set to null to remove an environment (except 'production').
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateEnvironmentVariableRequest(
            object values)
        {
            this.Values = values ?? throw new global::System.ArgumentNullException(nameof(values));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateEnvironmentVariableRequest" /> class.
        /// </summary>
        public UpdateEnvironmentVariableRequest()
        {
        }
    }
}