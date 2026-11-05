
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// A single business location stored inline in agent info.
    /// </summary>
    public sealed partial class SMBLocationInput
    {
        /// <summary>
        /// Internal name, e.g. 'Main Office' or 'Downtown Branch', shown in the dashboard and owner notifications.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Street address.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("address")]
        public string? Address { get; set; }

        /// <summary>
        /// Directions or other notes for customers, e.g. 'Free parking behind the building'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("notes")]
        public string? Notes { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("operating_hours")]
        public global::ElevenLabs.WorkingHours? OperatingHours { get; set; }

        /// <summary>
        /// Name shown to customers; empty reuses name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("customer_facing_name")]
        public string? CustomerFacingName { get; set; }

        /// <summary>
        /// Maximum number of appointments that may overlap at this location at a single instant. Only enforced while the booking page setting concurrent_limit_enabled is on.<br/>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_concurrent_appointments")]
        public int? MaxConcurrentAppointments { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Unix timestamp when this location was deactivated. None when active.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deactivated_at_unix")]
        public int? DeactivatedAtUnix { get; set; }

        /// <summary>
        /// Why this location was deactivated. None when active.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deactivation_reason")]
        public global::ElevenLabs.SMBLocationDeactivationReason? DeactivationReason { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SMBLocationInput" /> class.
        /// </summary>
        /// <param name="name">
        /// Internal name, e.g. 'Main Office' or 'Downtown Branch', shown in the dashboard and owner notifications.
        /// </param>
        /// <param name="id"></param>
        /// <param name="address">
        /// Street address.
        /// </param>
        /// <param name="notes">
        /// Directions or other notes for customers, e.g. 'Free parking behind the building'.
        /// </param>
        /// <param name="operatingHours"></param>
        /// <param name="customerFacingName">
        /// Name shown to customers; empty reuses name.
        /// </param>
        /// <param name="maxConcurrentAppointments">
        /// Maximum number of appointments that may overlap at this location at a single instant. Only enforced while the booking page setting concurrent_limit_enabled is on.<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="deactivatedAtUnix">
        /// Unix timestamp when this location was deactivated. None when active.
        /// </param>
        /// <param name="deactivationReason">
        /// Why this location was deactivated. None when active.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SMBLocationInput(
            string name,
            string id,
            string? address,
            string? notes,
            global::ElevenLabs.WorkingHours? operatingHours,
            string? customerFacingName,
            int? maxConcurrentAppointments,
            int? deactivatedAtUnix,
            global::ElevenLabs.SMBLocationDeactivationReason? deactivationReason)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Address = address;
            this.Notes = notes;
            this.OperatingHours = operatingHours;
            this.CustomerFacingName = customerFacingName;
            this.MaxConcurrentAppointments = maxConcurrentAppointments;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.DeactivatedAtUnix = deactivatedAtUnix;
            this.DeactivationReason = deactivationReason;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SMBLocationInput" /> class.
        /// </summary>
        public SMBLocationInput()
        {
        }

    }
}