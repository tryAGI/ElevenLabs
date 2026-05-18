
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RootModelAnnotatedUnionPairedLanguagesResponseSingleLanguagesResponseFieldInfoAnnotationNoneTypeRequiredTrueDiscriminatorKindDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.RootModelAnnotatedUnionPairedLanguagesResponseSingleLanguagesResponseFieldInfoAnnotationNoneTypeRequiredTrueDiscriminatorKindDiscriminatorKindJsonConverter))]
        public global::ElevenLabs.RootModelAnnotatedUnionPairedLanguagesResponseSingleLanguagesResponseFieldInfoAnnotationNoneTypeRequiredTrueDiscriminatorKindDiscriminatorKind? Kind { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RootModelAnnotatedUnionPairedLanguagesResponseSingleLanguagesResponseFieldInfoAnnotationNoneTypeRequiredTrueDiscriminatorKindDiscriminator" /> class.
        /// </summary>
        /// <param name="kind"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RootModelAnnotatedUnionPairedLanguagesResponseSingleLanguagesResponseFieldInfoAnnotationNoneTypeRequiredTrueDiscriminatorKindDiscriminator(
            global::ElevenLabs.RootModelAnnotatedUnionPairedLanguagesResponseSingleLanguagesResponseFieldInfoAnnotationNoneTypeRequiredTrueDiscriminatorKindDiscriminatorKind? kind)
        {
            this.Kind = kind;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RootModelAnnotatedUnionPairedLanguagesResponseSingleLanguagesResponseFieldInfoAnnotationNoneTypeRequiredTrueDiscriminatorKindDiscriminator" /> class.
        /// </summary>
        public RootModelAnnotatedUnionPairedLanguagesResponseSingleLanguagesResponseFieldInfoAnnotationNoneTypeRequiredTrueDiscriminatorKindDiscriminator()
        {
        }

    }
}