
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Scrape-reachable subset of a service (classic, rental or group).<br/>
    /// The extraction pipeline uses one LLM prompt per kind (so the model sees<br/>
    /// kind-specific guidance), but every code path produces this single shape:<br/>
    /// onboarding, imports and the unified ``smb_services`` collection all<br/>
    /// discriminate by the ``kind`` field.
    /// </summary>
    public sealed partial class SMBServiceScrapable
    {
        /// <summary>
        /// 'fixed' (default): the item has a known price the agent can quote, and customers can book or order it directly. 'quote': the price depends on the job (renovation, catering, custom work), so no price or slot is offered; the agent collects the intake_questions and files a quote request instead. Takes effect only while quotes are enabled for the business. Group services cannot use 'quote'.<br/>
        /// Default Value: fixed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pricing_mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.PricingModeJsonConverter))]
        public global::ElevenLabs.PricingMode? PricingMode { get; set; }

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
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Bookable options for this service. Always non-empty; ``variants[0]`` is the default option shown when callers don't pick a specific variant. Each entry has its own duration and (optional) price, and uniqueness is keyed by duration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("variants")]
        public global::System.Collections.Generic.IList<global::ElevenLabs.SMBServiceVariant>? Variants { get; set; }

        /// <summary>
        /// Classic = staff-delivered; rental = asset-based; group = multi-participant session. Populated by the extraction category.<br/>
        /// Default Value: classic
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.SMBServiceKindJsonConverter))]
        public global::ElevenLabs.SMBServiceKind? Kind { get; set; }

        /// <summary>
        /// Turnover/cleanup time reserved after each booking. Applies to every service kind; default 0 means no buffer.<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("buffer_minutes")]
        public int? BufferMinutes { get; set; }

        /// <summary>
        /// Where the service is delivered. ``business`` = client visits the business location (default); ``customer`` = staff travels to the client. Only meaningful for ``kind='classic'``.<br/>
        /// Default Value: business
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("service_location")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.ServiceLocationTypeJsonConverter))]
        public global::ElevenLabs.ServiceLocationType? ServiceLocation { get; set; }

        /// <summary>
        /// Optional extras scraped from the website that can be attached to a booking of this service.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("add_ons")]
        public global::System.Collections.Generic.IList<global::ElevenLabs.SMBAddOn>? AddOns { get; set; }

        /// <summary>
        /// Capacity for ``kind='group'``: how many seats a single session can sell across all registrations. Must be ``None`` for classic and rental services (those are always exclusive to one client per booking).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_participants")]
        public int? MaxParticipants { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SMBServiceScrapable" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="pricingMode">
        /// 'fixed' (default): the item has a known price the agent can quote, and customers can book or order it directly. 'quote': the price depends on the job (renovation, catering, custom work), so no price or slot is offered; the agent collects the intake_questions and files a quote request instead. Takes effect only while quotes are enabled for the business. Group services cannot use 'quote'.<br/>
        /// Default Value: fixed
        /// </param>
        /// <param name="groups">
        /// Group memberships for this item. Each entry carries the group label and the item's 0-based rank within that group.
        /// </param>
        /// <param name="ungroupedRank">
        /// Display position among items with no group; `null` sorts last. Change it with the reorder endpoint.
        /// </param>
        /// <param name="description"></param>
        /// <param name="variants">
        /// Bookable options for this service. Always non-empty; ``variants[0]`` is the default option shown when callers don't pick a specific variant. Each entry has its own duration and (optional) price, and uniqueness is keyed by duration.
        /// </param>
        /// <param name="kind">
        /// Classic = staff-delivered; rental = asset-based; group = multi-participant session. Populated by the extraction category.<br/>
        /// Default Value: classic
        /// </param>
        /// <param name="bufferMinutes">
        /// Turnover/cleanup time reserved after each booking. Applies to every service kind; default 0 means no buffer.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="serviceLocation">
        /// Where the service is delivered. ``business`` = client visits the business location (default); ``customer`` = staff travels to the client. Only meaningful for ``kind='classic'``.<br/>
        /// Default Value: business
        /// </param>
        /// <param name="addOns">
        /// Optional extras scraped from the website that can be attached to a booking of this service.
        /// </param>
        /// <param name="maxParticipants">
        /// Capacity for ``kind='group'``: how many seats a single session can sell across all registrations. Must be ``None`` for classic and rental services (those are always exclusive to one client per booking).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SMBServiceScrapable(
            string name,
            global::ElevenLabs.PricingMode? pricingMode,
            global::System.Collections.Generic.IList<global::ElevenLabs.SMBGroupMembership>? groups,
            int? ungroupedRank,
            string? description,
            global::System.Collections.Generic.IList<global::ElevenLabs.SMBServiceVariant>? variants,
            global::ElevenLabs.SMBServiceKind? kind,
            int? bufferMinutes,
            global::ElevenLabs.ServiceLocationType? serviceLocation,
            global::System.Collections.Generic.IList<global::ElevenLabs.SMBAddOn>? addOns,
            int? maxParticipants)
        {
            this.PricingMode = pricingMode;
            this.Groups = groups;
            this.UngroupedRank = ungroupedRank;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.Variants = variants;
            this.Kind = kind;
            this.BufferMinutes = bufferMinutes;
            this.ServiceLocation = serviceLocation;
            this.AddOns = addOns;
            this.MaxParticipants = maxParticipants;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SMBServiceScrapable" /> class.
        /// </summary>
        public SMBServiceScrapable()
        {
        }

    }
}