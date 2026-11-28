
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TextOutputItem
    {
        /// <summary>
        /// Default Value: text
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        /// <default>"agent"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        public string Role { get; set; } = "agent";

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at_unix_ms")]
        public long? CreatedAtUnixMs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TextOutputItem" /> class.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="type">
        /// Default Value: text
        /// </param>
        /// <param name="id"></param>
        /// <param name="createdAtUnixMs"></param>
        /// <param name="role"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TextOutputItem(
            string text,
            string? type,
            string? id,
            long? createdAtUnixMs,
            string role = "agent")
        {
            this.Type = type;
            this.Role = role;
            this.Id = id;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.CreatedAtUnixMs = createdAtUnixMs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TextOutputItem" /> class.
        /// </summary>
        public TextOutputItem()
        {
        }

        /// <summary>
        /// Creates a new <see cref="TextOutputItem"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static TextOutputItem FromText(string text)
        {
            return new TextOutputItem
            {
                Text = text,
            };
        }

    }
}