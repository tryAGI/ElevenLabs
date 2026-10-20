
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ListProductsParams
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("list_kwargs")]
        public object? ListKwargs { get; set; }

        /// <summary>
        /// Default Value: list_products
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("smb_tool_type")]
        public string? SmbToolType { get; set; }

        /// <summary>
        /// List every owner-editable field, including stock counts and a quoted product's price. Only for the owner's assistant: the customer-facing listing withholds those from callers.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("owner_view")]
        public bool? OwnerView { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListProductsParams" /> class.
        /// </summary>
        /// <param name="listKwargs"></param>
        /// <param name="smbToolType">
        /// Default Value: list_products
        /// </param>
        /// <param name="ownerView">
        /// List every owner-editable field, including stock counts and a quoted product's price. Only for the owner's assistant: the customer-facing listing withholds those from callers.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListProductsParams(
            object? listKwargs,
            string? smbToolType,
            bool? ownerView)
        {
            this.ListKwargs = listKwargs;
            this.SmbToolType = smbToolType;
            this.OwnerView = ownerView;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListProductsParams" /> class.
        /// </summary>
        public ListProductsParams()
        {
        }

    }
}