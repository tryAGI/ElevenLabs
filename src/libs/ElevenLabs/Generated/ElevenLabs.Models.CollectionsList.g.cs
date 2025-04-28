
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CollectionsList
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("collections")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::ElevenLabs.CollectionModel> Collections { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CollectionsList" /> class.
        /// </summary>
        /// <param name="collections"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CollectionsList(
            global::System.Collections.Generic.IList<global::ElevenLabs.CollectionModel> collections)
        {
            this.Collections = collections ?? throw new global::System.ArgumentNullException(nameof(collections));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CollectionsList" /> class.
        /// </summary>
        public CollectionsList()
        {
        }
    }
}