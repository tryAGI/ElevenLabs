
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WorkspaceAnalyticsQueryResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("columns")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Columns { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("column_types")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::ElevenLabs.WorkspaceAnalyticsQueryResponseModelColumnType> ColumnTypes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rows")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::ElevenLabs.AnyOf<string, int?, double?, bool?, global::System.DateTime?, object>>> Rows { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("column_units")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::ElevenLabs.ColumnUnit> ColumnUnits { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkspaceAnalyticsQueryResponseModel" /> class.
        /// </summary>
        /// <param name="columns"></param>
        /// <param name="columnTypes"></param>
        /// <param name="rows"></param>
        /// <param name="columnUnits"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WorkspaceAnalyticsQueryResponseModel(
            global::System.Collections.Generic.IList<string> columns,
            global::System.Collections.Generic.IList<global::ElevenLabs.WorkspaceAnalyticsQueryResponseModelColumnType> columnTypes,
            global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::ElevenLabs.AnyOf<string, int?, double?, bool?, global::System.DateTime?, object>>> rows,
            global::System.Collections.Generic.IList<global::ElevenLabs.ColumnUnit> columnUnits)
        {
            this.Columns = columns ?? throw new global::System.ArgumentNullException(nameof(columns));
            this.ColumnTypes = columnTypes ?? throw new global::System.ArgumentNullException(nameof(columnTypes));
            this.Rows = rows ?? throw new global::System.ArgumentNullException(nameof(rows));
            this.ColumnUnits = columnUnits ?? throw new global::System.ArgumentNullException(nameof(columnUnits));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkspaceAnalyticsQueryResponseModel" /> class.
        /// </summary>
        public WorkspaceAnalyticsQueryResponseModel()
        {
        }
    }
}