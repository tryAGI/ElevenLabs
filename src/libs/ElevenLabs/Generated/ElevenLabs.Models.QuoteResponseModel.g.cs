
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class QuoteResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("quote_usd")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double QuoteUsd { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("valid_until")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime ValidUntil { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.QuoteRequestModel Request { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("quote_token")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string QuoteToken { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="QuoteResponseModel" /> class.
        /// </summary>
        /// <param name="quoteUsd"></param>
        /// <param name="validUntil"></param>
        /// <param name="request"></param>
        /// <param name="quoteToken"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public QuoteResponseModel(
            double quoteUsd,
            global::System.DateTime validUntil,
            global::ElevenLabs.QuoteRequestModel request,
            string quoteToken)
        {
            this.QuoteUsd = quoteUsd;
            this.ValidUntil = validUntil;
            this.Request = request ?? throw new global::System.ArgumentNullException(nameof(request));
            this.QuoteToken = quoteToken ?? throw new global::System.ArgumentNullException(nameof(quoteToken));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QuoteResponseModel" /> class.
        /// </summary>
        public QuoteResponseModel()
        {
        }
    }
}