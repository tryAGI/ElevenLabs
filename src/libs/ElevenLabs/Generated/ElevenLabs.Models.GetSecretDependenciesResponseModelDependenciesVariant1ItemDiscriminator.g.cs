
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetSecretDependenciesResponseModelDependenciesVariant1ItemDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.GetSecretDependenciesResponseModelDependenciesVariant1ItemDiscriminatorTypeJsonConverter))]
        public global::ElevenLabs.GetSecretDependenciesResponseModelDependenciesVariant1ItemDiscriminatorType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetSecretDependenciesResponseModelDependenciesVariant1ItemDiscriminator" /> class.
        /// </summary>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetSecretDependenciesResponseModelDependenciesVariant1ItemDiscriminator(
            global::ElevenLabs.GetSecretDependenciesResponseModelDependenciesVariant1ItemDiscriminatorType? type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetSecretDependenciesResponseModelDependenciesVariant1ItemDiscriminator" /> class.
        /// </summary>
        public GetSecretDependenciesResponseModelDependenciesVariant1ItemDiscriminator()
        {
        }
    }
}