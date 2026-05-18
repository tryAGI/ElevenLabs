
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RootModelAnnotatedUnionDubOrderItemRequestSubtitleOrderItemRequestFieldInfoAnnotationNoneTypeRequiredTrueDiscriminatorKindInputDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.RootModelAnnotatedUnionDubOrderItemRequestSubtitleOrderItemRequestFieldInfoAnnotationNoneTypeRequiredTrueDiscriminatorKindInputDiscriminatorKindJsonConverter))]
        public global::ElevenLabs.RootModelAnnotatedUnionDubOrderItemRequestSubtitleOrderItemRequestFieldInfoAnnotationNoneTypeRequiredTrueDiscriminatorKindInputDiscriminatorKind? Kind { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RootModelAnnotatedUnionDubOrderItemRequestSubtitleOrderItemRequestFieldInfoAnnotationNoneTypeRequiredTrueDiscriminatorKindInputDiscriminator" /> class.
        /// </summary>
        /// <param name="kind"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RootModelAnnotatedUnionDubOrderItemRequestSubtitleOrderItemRequestFieldInfoAnnotationNoneTypeRequiredTrueDiscriminatorKindInputDiscriminator(
            global::ElevenLabs.RootModelAnnotatedUnionDubOrderItemRequestSubtitleOrderItemRequestFieldInfoAnnotationNoneTypeRequiredTrueDiscriminatorKindInputDiscriminatorKind? kind)
        {
            this.Kind = kind;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RootModelAnnotatedUnionDubOrderItemRequestSubtitleOrderItemRequestFieldInfoAnnotationNoneTypeRequiredTrueDiscriminatorKindInputDiscriminator" /> class.
        /// </summary>
        public RootModelAnnotatedUnionDubOrderItemRequestSubtitleOrderItemRequestFieldInfoAnnotationNoneTypeRequiredTrueDiscriminatorKindInputDiscriminator()
        {
        }

    }
}