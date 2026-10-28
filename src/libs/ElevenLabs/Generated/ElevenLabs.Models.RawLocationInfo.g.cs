
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// A single branch/location extracted from a page.
    /// </summary>
    public sealed partial class RawLocationInfo
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("address")]
        public string? Address { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("operating_hours")]
        public object? OperatingHours { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RawLocationInfo" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="address"></param>
        /// <param name="operatingHours"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RawLocationInfo(
            string? name,
            string? address,
            object? operatingHours)
        {
            this.Name = name;
            this.Address = address;
            this.OperatingHours = operatingHours;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RawLocationInfo" /> class.
        /// </summary>
        public RawLocationInfo()
        {
        }

    }
}