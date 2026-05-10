
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// OCSF User object.<br/>
    /// Spec: https://schema.ocsf.io/1.6.0/objects/user
    /// </summary>
    public sealed partial class UserModel
    {
        /// <summary>
        /// Username
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Unique user identifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uid")]
        public string? Uid { get; set; }

        /// <summary>
        /// Account type identifier<br/>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type_id")]
        public int? TypeId { get; set; }

        /// <summary>
        /// Account type description
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// User email address
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email_addr")]
        public string? EmailAddr { get; set; }

        /// <summary>
        /// Full name of the user
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("full_name")]
        public string? FullName { get; set; }

        /// <summary>
        /// User's domain
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("domain")]
        public string? Domain { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserModel" /> class.
        /// </summary>
        /// <param name="name">
        /// Username
        /// </param>
        /// <param name="uid">
        /// Unique user identifier
        /// </param>
        /// <param name="typeId">
        /// Account type identifier<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="type">
        /// Account type description
        /// </param>
        /// <param name="emailAddr">
        /// User email address
        /// </param>
        /// <param name="fullName">
        /// Full name of the user
        /// </param>
        /// <param name="domain">
        /// User's domain
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserModel(
            string? name,
            string? uid,
            int? typeId,
            string? type,
            string? emailAddr,
            string? fullName,
            string? domain)
        {
            this.Name = name;
            this.Uid = uid;
            this.TypeId = typeId;
            this.Type = type;
            this.EmailAddr = emailAddr;
            this.FullName = fullName;
            this.Domain = domain;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserModel" /> class.
        /// </summary>
        public UserModel()
        {
        }

    }
}