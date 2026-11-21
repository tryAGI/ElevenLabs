
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ConflictResolution
    {
        /// <summary>
        /// `id` of the conflict this resolves, as the merge or rebase preview reported it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conflict_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ConflictId { get; set; }

        /// <summary>
        /// Keep the source value, the target value, or `custom_value`. On a list of entities, the side settles the entities both branches changed; ones only one branch changed still merge in.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("choice")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.ConflictResolutionChoiceJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.ConflictResolutionChoice Choice { get; set; }

        /// <summary>
        /// Text to keep when `choice` is `custom`, or for a procedure conflict the id of the procedure version to pin. Only conflicts with `accepts_custom_value` take one.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custom_value")]
        public string? CustomValue { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConflictResolution" /> class.
        /// </summary>
        /// <param name="conflictId">
        /// `id` of the conflict this resolves, as the merge or rebase preview reported it.
        /// </param>
        /// <param name="choice">
        /// Keep the source value, the target value, or `custom_value`. On a list of entities, the side settles the entities both branches changed; ones only one branch changed still merge in.
        /// </param>
        /// <param name="customValue">
        /// Text to keep when `choice` is `custom`, or for a procedure conflict the id of the procedure version to pin. Only conflicts with `accepts_custom_value` take one.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConflictResolution(
            string conflictId,
            global::ElevenLabs.ConflictResolutionChoice choice,
            string? customValue)
        {
            this.ConflictId = conflictId ?? throw new global::System.ArgumentNullException(nameof(conflictId));
            this.Choice = choice;
            this.CustomValue = customValue;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConflictResolution" /> class.
        /// </summary>
        public ConflictResolution()
        {
        }

    }
}