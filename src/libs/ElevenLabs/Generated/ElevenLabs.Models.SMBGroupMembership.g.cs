
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Membership of an item in a single user-defined group, with its display rank inside that group.
    /// </summary>
    public sealed partial class SMBGroupMembership
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Label { get; set; }

        /// <summary>
        /// 0-based display position within this group. Change it with the reorder endpoint; send back the value you read to keep the order, a membership sent without it goes to position 0.<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rank")]
        public int? Rank { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SMBGroupMembership" /> class.
        /// </summary>
        /// <param name="label"></param>
        /// <param name="rank">
        /// 0-based display position within this group. Change it with the reorder endpoint; send back the value you read to keep the order, a membership sent without it goes to position 0.<br/>
        /// Default Value: 0
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SMBGroupMembership(
            string label,
            int? rank)
        {
            this.Label = label ?? throw new global::System.ArgumentNullException(nameof(label));
            this.Rank = rank;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SMBGroupMembership" /> class.
        /// </summary>
        public SMBGroupMembership()
        {
        }

    }
}