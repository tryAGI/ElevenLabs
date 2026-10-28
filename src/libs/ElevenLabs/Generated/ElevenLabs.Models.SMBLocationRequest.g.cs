
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Request model for creating or updating a location.
    /// </summary>
    public sealed partial class SMBLocationRequest
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
        /// Per-location operating hours. On create, omit to have the server prefill from the most recently added active location.
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
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_active")]
        public bool? IsActive { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SMBLocationRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// Internal name, e.g. 'Main Office' or 'Downtown Branch', shown in the dashboard and owner notifications.
        /// </param>
        /// <param name="address">
        /// Street address.
        /// </param>
        /// <param name="notes">
        /// Directions or other notes for customers, e.g. 'Free parking behind the building'.
        /// </param>
        /// <param name="operatingHours">
        /// Per-location operating hours. On create, omit to have the server prefill from the most recently added active location.
        /// </param>
        /// <param name="customerFacingName">
        /// Name shown to customers; empty reuses name.
        /// </param>
        /// <param name="maxConcurrentAppointments">
        /// Maximum number of appointments that may overlap at this location at a single instant. Only enforced while the booking page setting concurrent_limit_enabled is on.<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="isActive">
        /// Default Value: true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SMBLocationRequest(
            string name,
            string? address,
            string? notes,
            global::ElevenLabs.WorkingHours? operatingHours,
            string? customerFacingName,
            int? maxConcurrentAppointments,
            bool? isActive)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Address = address;
            this.Notes = notes;
            this.OperatingHours = operatingHours;
            this.CustomerFacingName = customerFacingName;
            this.MaxConcurrentAppointments = maxConcurrentAppointments;
            this.IsActive = isActive;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SMBLocationRequest" /> class.
        /// </summary>
        public SMBLocationRequest()
        {
        }

    }
}