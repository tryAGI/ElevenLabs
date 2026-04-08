
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetSecretDependenciesResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dependencies")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::ElevenLabs.DependenciesVariant1Item>, global::System.Collections.Generic.IList<global::ElevenLabs.DependenciesVariant2Item>, global::System.Collections.Generic.IList<global::ElevenLabs.DependentPhoneNumberIdentifier>>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.AnyOf<global::System.Collections.Generic.IList<global::ElevenLabs.DependenciesVariant1Item>, global::System.Collections.Generic.IList<global::ElevenLabs.DependenciesVariant2Item>, global::System.Collections.Generic.IList<global::ElevenLabs.DependentPhoneNumberIdentifier>> Dependencies { get; set; }

        /// <summary>
        /// Cursor for fetching the next page of dependencies
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_cursor")]
        public string? NextCursor { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetSecretDependenciesResponseModel" /> class.
        /// </summary>
        /// <param name="dependencies"></param>
        /// <param name="nextCursor">
        /// Cursor for fetching the next page of dependencies
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetSecretDependenciesResponseModel(
            global::ElevenLabs.AnyOf<global::System.Collections.Generic.IList<global::ElevenLabs.DependenciesVariant1Item>, global::System.Collections.Generic.IList<global::ElevenLabs.DependenciesVariant2Item>, global::System.Collections.Generic.IList<global::ElevenLabs.DependentPhoneNumberIdentifier>> dependencies,
            string? nextCursor)
        {
            this.Dependencies = dependencies;
            this.NextCursor = nextCursor;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetSecretDependenciesResponseModel" /> class.
        /// </summary>
        public GetSecretDependenciesResponseModel()
        {
        }
    }
}