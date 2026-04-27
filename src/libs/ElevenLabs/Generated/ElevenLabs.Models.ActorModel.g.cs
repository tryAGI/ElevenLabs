
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// OCSF Actor object - describes the entity that performed the action.<br/>
    /// Spec: https://schema.ocsf.io/1.6.0/objects/actor
    /// </summary>
    public sealed partial class ActorModel
    {
        /// <summary>
        /// User who performed the action
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.UserModel User { get; set; }

        /// <summary>
        /// Client application or service name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("app_name")]
        public string? AppName { get; set; }

        /// <summary>
        /// Client application unique identifier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("app_uid")]
        public string? AppUid { get; set; }

        /// <summary>
        /// Session information
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session")]
        public object? Session { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ActorModel" /> class.
        /// </summary>
        /// <param name="user">
        /// User who performed the action
        /// </param>
        /// <param name="appName">
        /// Client application or service name
        /// </param>
        /// <param name="appUid">
        /// Client application unique identifier
        /// </param>
        /// <param name="session">
        /// Session information
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ActorModel(
            global::ElevenLabs.UserModel user,
            string? appName,
            string? appUid,
            object? session)
        {
            this.User = user ?? throw new global::System.ArgumentNullException(nameof(user));
            this.AppName = appName;
            this.AppUid = appUid;
            this.Session = session;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActorModel" /> class.
        /// </summary>
        public ActorModel()
        {
        }
    }
}