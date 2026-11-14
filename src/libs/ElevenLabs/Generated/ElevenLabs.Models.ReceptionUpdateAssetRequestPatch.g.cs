
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ReceptionUpdateAssetRequestPatch
    {
        /// <summary>
        /// Group memberships for this item. Each entry carries the group label and the item's 0-based rank within that group.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("groups")]
        public global::System.Collections.Generic.IList<global::ElevenLabs.ReceptionGroupMembership>? Groups { get; set; }

        /// <summary>
        /// Display position among items with no group; `null` sorts last. Change it with the reorder endpoint.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ungrouped_rank")]
        public int? UngroupedRank { get; set; }

        /// <summary>
        /// Internal/admin name of the asset, shown in the dashboard and owner notifications.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Description of the asset.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Whether the asset can be booked. Inactive assets keep their booking history.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_active")]
        public bool? IsActive { get; set; }

        /// <summary>
        /// Custom availability hours for this asset. Null means follow the assigned location's operating_hours (requires location_id).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("available_hours")]
        public global::ElevenLabs.WorkingHours? AvailableHours { get; set; }

        /// <summary>
        /// URL of a photo of the asset.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("photo_url")]
        public string? PhotoUrl { get; set; }

        /// <summary>
        /// Location this asset belongs to; empty means available at all locations.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("location_id")]
        public string? LocationId { get; set; }

        /// <summary>
        /// Optional public-facing label. When empty, `name` is shown to customers too. `name` stays the internal/admin label used in the dashboard and business-owner notifications.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("customer_facing_name")]
        public string? CustomerFacingName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReceptionUpdateAssetRequestPatch" /> class.
        /// </summary>
        /// <param name="groups">
        /// Group memberships for this item. Each entry carries the group label and the item's 0-based rank within that group.
        /// </param>
        /// <param name="ungroupedRank">
        /// Display position among items with no group; `null` sorts last. Change it with the reorder endpoint.
        /// </param>
        /// <param name="name">
        /// Internal/admin name of the asset, shown in the dashboard and owner notifications.
        /// </param>
        /// <param name="description">
        /// Description of the asset.
        /// </param>
        /// <param name="isActive">
        /// Whether the asset can be booked. Inactive assets keep their booking history.
        /// </param>
        /// <param name="availableHours">
        /// Custom availability hours for this asset. Null means follow the assigned location's operating_hours (requires location_id).
        /// </param>
        /// <param name="photoUrl">
        /// URL of a photo of the asset.
        /// </param>
        /// <param name="locationId">
        /// Location this asset belongs to; empty means available at all locations.
        /// </param>
        /// <param name="customerFacingName">
        /// Optional public-facing label. When empty, `name` is shown to customers too. `name` stays the internal/admin label used in the dashboard and business-owner notifications.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReceptionUpdateAssetRequestPatch(
            global::System.Collections.Generic.IList<global::ElevenLabs.ReceptionGroupMembership>? groups,
            int? ungroupedRank,
            string? name,
            string? description,
            bool? isActive,
            global::ElevenLabs.WorkingHours? availableHours,
            string? photoUrl,
            string? locationId,
            string? customerFacingName)
        {
            this.Groups = groups;
            this.UngroupedRank = ungroupedRank;
            this.Name = name;
            this.Description = description;
            this.IsActive = isActive;
            this.AvailableHours = availableHours;
            this.PhotoUrl = photoUrl;
            this.LocationId = locationId;
            this.CustomerFacingName = customerFacingName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReceptionUpdateAssetRequestPatch" /> class.
        /// </summary>
        public ReceptionUpdateAssetRequestPatch()
        {
        }

    }
}