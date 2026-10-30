
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BodySmbUpdateAgentProcedure
    {
        /// <summary>
        /// Request model for updating an existing procedure.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.SMBUpdateProcedureRequest Request { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodySmbUpdateAgentProcedure" /> class.
        /// </summary>
        /// <param name="request">
        /// Request model for updating an existing procedure.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BodySmbUpdateAgentProcedure(
            global::ElevenLabs.SMBUpdateProcedureRequest request)
        {
            this.Request = request ?? throw new global::System.ArgumentNullException(nameof(request));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodySmbUpdateAgentProcedure" /> class.
        /// </summary>
        public BodySmbUpdateAgentProcedure()
        {
        }

    }
}