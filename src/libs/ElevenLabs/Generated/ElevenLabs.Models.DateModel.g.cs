
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Represents a calendar date as individual numeric components.
    /// </summary>
    public sealed partial class DateModel
    {
        /// <summary>
        /// Year
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("year")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Year { get; set; }

        /// <summary>
        /// Month (1-12)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("month")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Month { get; set; }

        /// <summary>
        /// Day of month (1-31)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("day")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Day { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DateModel" /> class.
        /// </summary>
        /// <param name="year">
        /// Year
        /// </param>
        /// <param name="month">
        /// Month (1-12)
        /// </param>
        /// <param name="day">
        /// Day of month (1-31)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DateModel(
            int year,
            int month,
            int day)
        {
            this.Year = year;
            this.Month = month;
            this.Day = day;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DateModel" /> class.
        /// </summary>
        public DateModel()
        {
        }

    }
}