
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BehaviorOverride
    {
        /// <summary>
        /// Verbosity override. Underlying default applies when unset.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("verbosity")]
        public global::ElevenLabs.Verbosity? Verbosity { get; set; }

        /// <summary>
        /// Output format override. Underlying default applies when unset.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_format")]
        public global::ElevenLabs.OutputFormat? OutputFormat { get; set; }

        /// <summary>
        /// Interaction budget override. Underlying default applies when unset.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("interaction_budget")]
        public global::ElevenLabs.InteractionBudget? InteractionBudget { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BehaviorOverride" /> class.
        /// </summary>
        /// <param name="verbosity">
        /// Verbosity override. Underlying default applies when unset.
        /// </param>
        /// <param name="outputFormat">
        /// Output format override. Underlying default applies when unset.
        /// </param>
        /// <param name="interactionBudget">
        /// Interaction budget override. Underlying default applies when unset.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BehaviorOverride(
            global::ElevenLabs.Verbosity? verbosity,
            global::ElevenLabs.OutputFormat? outputFormat,
            global::ElevenLabs.InteractionBudget? interactionBudget)
        {
            this.Verbosity = verbosity;
            this.OutputFormat = outputFormat;
            this.InteractionBudget = interactionBudget;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BehaviorOverride" /> class.
        /// </summary>
        public BehaviorOverride()
        {
        }

    }
}