
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Audit log entry with Firestore document ID for API responses.
    /// </summary>
    public sealed partial class WorkspaceAuditLogEntryResponse
    {
        /// <summary>
        /// Event metadata
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Event time in milliseconds since epoch
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("time")]
        public long? Time { get; set; }

        /// <summary>
        /// Activity ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("activity_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ActivityId { get; set; }

        /// <summary>
        /// Activity name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("activity_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ActivityName { get; set; }

        /// <summary>
        /// Event category<br/>
        /// Default Value: Identity &amp; Access Management
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("category_name")]
        public string? CategoryName { get; set; }

        /// <summary>
        /// Category UID for IAM<br/>
        /// Default Value: 3
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("category_uid")]
        public int? CategoryUid { get; set; }

        /// <summary>
        /// Event class name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("class_name")]
        public string? ClassName { get; set; }

        /// <summary>
        /// Event class UID<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("class_uid")]
        public int? ClassUid { get; set; }

        /// <summary>
        /// Severity level<br/>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("severity_id")]
        public int? SeverityId { get; set; }

        /// <summary>
        /// Status of the action
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int StatusId { get; set; }

        /// <summary>
        /// Actor performing the action
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actor")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::ElevenLabs.ActorModel Actor { get; set; }

        /// <summary>
        /// Device information
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("device")]
        public global::ElevenLabs.DeviceModel? Device { get; set; }

        /// <summary>
        /// HTTP request details
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("http_request")]
        public global::ElevenLabs.HttpRequestModel? HttpRequest { get; set; }

        /// <summary>
        /// Human-readable event description
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// Attributes not mapped to OCSF
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unmapped")]
        public object? Unmapped { get; set; }

        /// <summary>
        /// Firestore document ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Event time in human-readable RFC 3339 format, derived from 'time'.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("time_dt")]
        public string TimeDt { get; set; } = default!;

        /// <summary>
        /// OCSF type_uid is class_uid * 100 + activity_id.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type_uid")]
        public int TypeUid { get; set; } = default!;

        /// <summary>
        /// OCSF type_name combines class_name and activity_name.<br/>
        /// Included only in responses
        /// </summary>
        /// <default>default!</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type_name")]
        public string TypeName { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkspaceAuditLogEntryResponse" /> class.
        /// </summary>
        /// <param name="activityId">
        /// Activity ID
        /// </param>
        /// <param name="activityName">
        /// Activity name
        /// </param>
        /// <param name="statusId">
        /// Status of the action
        /// </param>
        /// <param name="actor">
        /// Actor performing the action
        /// </param>
        /// <param name="message">
        /// Human-readable event description
        /// </param>
        /// <param name="id">
        /// Firestore document ID
        /// </param>
        /// <param name="metadata">
        /// Event metadata
        /// </param>
        /// <param name="time">
        /// Event time in milliseconds since epoch
        /// </param>
        /// <param name="categoryName">
        /// Event category<br/>
        /// Default Value: Identity &amp; Access Management
        /// </param>
        /// <param name="categoryUid">
        /// Category UID for IAM<br/>
        /// Default Value: 3
        /// </param>
        /// <param name="className">
        /// Event class name
        /// </param>
        /// <param name="classUid">
        /// Event class UID<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="severityId">
        /// Severity level<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="device">
        /// Device information
        /// </param>
        /// <param name="httpRequest">
        /// HTTP request details
        /// </param>
        /// <param name="unmapped">
        /// Attributes not mapped to OCSF
        /// </param>
        /// <param name="timeDt">
        /// Event time in human-readable RFC 3339 format, derived from 'time'.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="typeUid">
        /// OCSF type_uid is class_uid * 100 + activity_id.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="typeName">
        /// OCSF type_name combines class_name and activity_name.<br/>
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WorkspaceAuditLogEntryResponse(
            int activityId,
            string activityName,
            int statusId,
            global::ElevenLabs.ActorModel actor,
            string message,
            string id,
            object? metadata,
            long? time,
            string? categoryName,
            int? categoryUid,
            string? className,
            int? classUid,
            int? severityId,
            global::ElevenLabs.DeviceModel? device,
            global::ElevenLabs.HttpRequestModel? httpRequest,
            object? unmapped,
            string timeDt = default!,
            int typeUid = default!,
            string typeName = default!)
        {
            this.Metadata = metadata;
            this.Time = time;
            this.ActivityId = activityId;
            this.ActivityName = activityName ?? throw new global::System.ArgumentNullException(nameof(activityName));
            this.CategoryName = categoryName;
            this.CategoryUid = categoryUid;
            this.ClassName = className;
            this.ClassUid = classUid;
            this.SeverityId = severityId;
            this.StatusId = statusId;
            this.Actor = actor ?? throw new global::System.ArgumentNullException(nameof(actor));
            this.Device = device;
            this.HttpRequest = httpRequest;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Unmapped = unmapped;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.TimeDt = timeDt;
            this.TypeUid = typeUid;
            this.TypeName = typeName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkspaceAuditLogEntryResponse" /> class.
        /// </summary>
        public WorkspaceAuditLogEntryResponse()
        {
        }
    }
}