
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Scrape-reachable subset of an asset (resource that can be booked).
    /// </summary>
    public sealed partial class SMBAssetScrapable
    {
        /// <summary>
        /// Group memberships for this item. Each entry carries the group label and the item's 0-based rank within that group.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("groups")]
        public global::System.Collections.Generic.IList<global::ElevenLabs.SMBGroupMembership>? Groups { get; set; }

        /// <summary>
        /// Display position among items with no group; `null` sorts last. Change it with the reorder endpoint.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ungrouped_rank")]
        public int? UngroupedRank { get; set; }

        /// <summary>
        /// Internal/admin name of the asset, shown in the dashboard and owner notifications.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Description of the asset.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SMBAssetScrapable" /> class.
        /// </summary>
        /// <param name="name">
        /// Internal/admin name of the asset, shown in the dashboard and owner notifications.
        /// </param>
        /// <param name="groups">
        /// Group memberships for this item. Each entry carries the group label and the item's 0-based rank within that group.
        /// </param>
        /// <param name="ungroupedRank">
        /// Display position among items with no group; `null` sorts last. Change it with the reorder endpoint.
        /// </param>
        /// <param name="description">
        /// Description of the asset.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SMBAssetScrapable(
            string name,
            global::System.Collections.Generic.IList<global::ElevenLabs.SMBGroupMembership>? groups,
            int? ungroupedRank,
            string? description)
        {
            this.Groups = groups;
            this.UngroupedRank = ungroupedRank;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SMBAssetScrapable" /> class.
        /// </summary>
        public SMBAssetScrapable()
        {
        }

    }
}