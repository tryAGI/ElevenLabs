
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TicketEventRequesterAuthorResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("first_name")]
        public string? FirstName { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_name")]
        public string? LastName { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("full_name")]
        public string? FullName { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        public string? Email { get; set; }

        /// <summary>
        /// Default Value: requester
        /// </summary>
        /// <default>"requester"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "requester";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TicketEventRequesterAuthorResponse" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="fullName"></param>
        /// <param name="email"></param>
        /// <param name="type">
        /// Default Value: requester
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TicketEventRequesterAuthorResponse(
            string id,
            string? firstName,
            string? lastName,
            string? fullName,
            string? email,
            string type = "requester")
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.FirstName = firstName;
            this.LastName = lastName;
            this.FullName = fullName;
            this.Email = email;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TicketEventRequesterAuthorResponse" /> class.
        /// </summary>
        public TicketEventRequesterAuthorResponse()
        {
        }

        /// <summary>
        /// Creates a new <see cref="TicketEventRequesterAuthorResponse"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static TicketEventRequesterAuthorResponse FromId(string id)
        {
            return new TicketEventRequesterAuthorResponse
            {
                Id = id,
            };
        }

    }
}