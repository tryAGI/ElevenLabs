
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public enum GetTicketResponseEventDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        AssigneeChanged,
        /// <summary>
        ///
        /// </summary>
        DeadlineChanged,
        /// <summary>
        ///
        /// </summary>
        Message,
        /// <summary>
        ///
        /// </summary>
        PriorityChanged,
        /// <summary>
        ///
        /// </summary>
        SecondaryAssigneeChanged,
        /// <summary>
        ///
        /// </summary>
        StatusChanged,
        /// <summary>
        ///
        /// </summary>
        SubjectChanged,
        /// <summary>
        ///
        /// </summary>
        SubscribersChanged,
        /// <summary>
        ///
        /// </summary>
        TagIdsChanged,
        /// <summary>
        ///
        /// </summary>
        TicketCreated,
        /// <summary>
        ///
        /// </summary>
        TicketDeleted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetTicketResponseEventDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetTicketResponseEventDiscriminatorType value)
        {
            return value switch
            {
                GetTicketResponseEventDiscriminatorType.AssigneeChanged => "assignee_changed",
                GetTicketResponseEventDiscriminatorType.DeadlineChanged => "deadline_changed",
                GetTicketResponseEventDiscriminatorType.Message => "message",
                GetTicketResponseEventDiscriminatorType.PriorityChanged => "priority_changed",
                GetTicketResponseEventDiscriminatorType.SecondaryAssigneeChanged => "secondary_assignee_changed",
                GetTicketResponseEventDiscriminatorType.StatusChanged => "status_changed",
                GetTicketResponseEventDiscriminatorType.SubjectChanged => "subject_changed",
                GetTicketResponseEventDiscriminatorType.SubscribersChanged => "subscribers_changed",
                GetTicketResponseEventDiscriminatorType.TagIdsChanged => "tag_ids_changed",
                GetTicketResponseEventDiscriminatorType.TicketCreated => "ticket_created",
                GetTicketResponseEventDiscriminatorType.TicketDeleted => "ticket_deleted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetTicketResponseEventDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "assignee_changed" => GetTicketResponseEventDiscriminatorType.AssigneeChanged,
                "deadline_changed" => GetTicketResponseEventDiscriminatorType.DeadlineChanged,
                "message" => GetTicketResponseEventDiscriminatorType.Message,
                "priority_changed" => GetTicketResponseEventDiscriminatorType.PriorityChanged,
                "secondary_assignee_changed" => GetTicketResponseEventDiscriminatorType.SecondaryAssigneeChanged,
                "status_changed" => GetTicketResponseEventDiscriminatorType.StatusChanged,
                "subject_changed" => GetTicketResponseEventDiscriminatorType.SubjectChanged,
                "subscribers_changed" => GetTicketResponseEventDiscriminatorType.SubscribersChanged,
                "tag_ids_changed" => GetTicketResponseEventDiscriminatorType.TagIdsChanged,
                "ticket_created" => GetTicketResponseEventDiscriminatorType.TicketCreated,
                "ticket_deleted" => GetTicketResponseEventDiscriminatorType.TicketDeleted,
                _ => null,
            };
        }
    }
}