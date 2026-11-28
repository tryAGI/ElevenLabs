
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UpdateProcedureVisibilityRequestModel
    {
        /// <summary>
        /// The condition that controls if the procedure is visible to the agent in its procedure menu. Null clears it, so the procedure is always visible.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("visibility")]
        public global::ElevenLabs.ProcedureVisibilityInput? Visibility { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateProcedureVisibilityRequestModel" /> class.
        /// </summary>
        /// <param name="visibility">
        /// The condition that controls if the procedure is visible to the agent in its procedure menu. Null clears it, so the procedure is always visible.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateProcedureVisibilityRequestModel(
            global::ElevenLabs.ProcedureVisibilityInput? visibility)
        {
            this.Visibility = visibility;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateProcedureVisibilityRequestModel" /> class.
        /// </summary>
        public UpdateProcedureVisibilityRequestModel()
        {
        }

    }
}