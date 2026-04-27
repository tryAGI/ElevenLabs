
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// A static asset node response (image, video, text, or audio).<br/>
    /// Example: {"asset":{"content_asset_id":"asset_xyz789"},"id":"S1Abc2defGHI3jkl","label":"Static Image","modality":"image","position":{"x":100,"y":150},"template_id":"tmpl_abc123","type":"static_asset"}
    /// </summary>
    public sealed partial class StaticAssetNode
    {
        /// <summary>
        /// Globally unique identifier for this node (must be unique across all templates). Clients must generate a random alphanumeric ID with sufficient entropy to avoid collisions.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Label for the node, displayed in the UI.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Label { get; set; }

        /// <summary>
        /// ID of the template this node belongs to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("template_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TemplateId { get; set; }

        /// <summary>
        /// Position of the node on the canvas.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("position")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.NodePosition Position { get; set; }

        /// <summary>
        /// User ID of the person who last modified this node.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modified_by")]
        public string? ModifiedBy { get; set; }

        /// <summary>
        /// When this node was last modified.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modified_at_utc")]
        public global::System.DateTime? ModifiedAtUtc { get; set; }

        /// <summary>
        /// Default Value: static_asset
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// The type of asset (image, video, text, or audio).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modality")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.StaticAssetNodeModalityJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.StaticAssetNodeModality Modality { get; set; }

        /// <summary>
        /// Reference to the static asset.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("asset")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.AnyOfJsonConverter<global::ElevenLabs.ReferenceImage, global::ElevenLabs.ReferenceVideo, global::ElevenLabs.ReferenceText, global::ElevenLabs.ReferenceAudio, object>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.AnyOf<global::ElevenLabs.ReferenceImage, global::ElevenLabs.ReferenceVideo, global::ElevenLabs.ReferenceText, global::ElevenLabs.ReferenceAudio, object> Asset { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StaticAssetNode" /> class.
        /// </summary>
        /// <param name="id">
        /// Globally unique identifier for this node (must be unique across all templates). Clients must generate a random alphanumeric ID with sufficient entropy to avoid collisions.
        /// </param>
        /// <param name="label">
        /// Label for the node, displayed in the UI.
        /// </param>
        /// <param name="templateId">
        /// ID of the template this node belongs to.
        /// </param>
        /// <param name="position">
        /// Position of the node on the canvas.
        /// </param>
        /// <param name="modality">
        /// The type of asset (image, video, text, or audio).
        /// </param>
        /// <param name="asset">
        /// Reference to the static asset.
        /// </param>
        /// <param name="modifiedBy">
        /// User ID of the person who last modified this node.
        /// </param>
        /// <param name="modifiedAtUtc">
        /// When this node was last modified.
        /// </param>
        /// <param name="type">
        /// Default Value: static_asset
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StaticAssetNode(
            string id,
            string label,
            string templateId,
            global::ElevenLabs.NodePosition position,
            global::ElevenLabs.StaticAssetNodeModality modality,
            global::ElevenLabs.AnyOf<global::ElevenLabs.ReferenceImage, global::ElevenLabs.ReferenceVideo, global::ElevenLabs.ReferenceText, global::ElevenLabs.ReferenceAudio, object> asset,
            string? modifiedBy,
            global::System.DateTime? modifiedAtUtc,
            string? type)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Label = label ?? throw new global::System.ArgumentNullException(nameof(label));
            this.TemplateId = templateId ?? throw new global::System.ArgumentNullException(nameof(templateId));
            this.Position = position ?? throw new global::System.ArgumentNullException(nameof(position));
            this.ModifiedBy = modifiedBy;
            this.ModifiedAtUtc = modifiedAtUtc;
            this.Type = type;
            this.Modality = modality;
            this.Asset = asset;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StaticAssetNode" /> class.
        /// </summary>
        public StaticAssetNode()
        {
        }
    }
}