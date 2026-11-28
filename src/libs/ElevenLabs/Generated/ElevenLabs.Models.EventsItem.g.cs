#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct EventsItem : global::System.IEquatable<EventsItem>
    {
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GetTicketResponseEventDiscriminatorType? Type { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.TicketMessageEventResponse? Message { get; init; }
#else
        public global::ElevenLabs.TicketMessageEventResponse? Message { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Message))]
#endif
        public bool IsMessage => Message != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickMessage(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.TicketMessageEventResponse? value)
        {
            value = Message;
            return IsMessage;
        }

        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TicketMessageEventResponse PickMessage() => Message is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Message' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.TicketCreatedEventResponse? TicketCreated { get; init; }
#else
        public global::ElevenLabs.TicketCreatedEventResponse? TicketCreated { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TicketCreated))]
#endif
        public bool IsTicketCreated => TicketCreated != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickTicketCreated(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.TicketCreatedEventResponse? value)
        {
            value = TicketCreated;
            return IsTicketCreated;
        }

        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TicketCreatedEventResponse PickTicketCreated() => TicketCreated is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'TicketCreated' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.TicketDeletedEventResponse? TicketDeleted { get; init; }
#else
        public global::ElevenLabs.TicketDeletedEventResponse? TicketDeleted { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TicketDeleted))]
#endif
        public bool IsTicketDeleted => TicketDeleted != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickTicketDeleted(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.TicketDeletedEventResponse? value)
        {
            value = TicketDeleted;
            return IsTicketDeleted;
        }

        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TicketDeletedEventResponse PickTicketDeleted() => TicketDeleted is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'TicketDeleted' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.TicketAssigneeChangedEventResponse? AssigneeChanged { get; init; }
#else
        public global::ElevenLabs.TicketAssigneeChangedEventResponse? AssigneeChanged { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AssigneeChanged))]
#endif
        public bool IsAssigneeChanged => AssigneeChanged != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAssigneeChanged(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.TicketAssigneeChangedEventResponse? value)
        {
            value = AssigneeChanged;
            return IsAssigneeChanged;
        }

        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TicketAssigneeChangedEventResponse PickAssigneeChanged() => AssigneeChanged is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'AssigneeChanged' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.TicketSecondaryAssigneeChangedEventResponse? SecondaryAssigneeChanged { get; init; }
#else
        public global::ElevenLabs.TicketSecondaryAssigneeChangedEventResponse? SecondaryAssigneeChanged { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SecondaryAssigneeChanged))]
#endif
        public bool IsSecondaryAssigneeChanged => SecondaryAssigneeChanged != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSecondaryAssigneeChanged(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.TicketSecondaryAssigneeChangedEventResponse? value)
        {
            value = SecondaryAssigneeChanged;
            return IsSecondaryAssigneeChanged;
        }

        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TicketSecondaryAssigneeChangedEventResponse PickSecondaryAssigneeChanged() => SecondaryAssigneeChanged is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'SecondaryAssigneeChanged' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.TicketSubscribersChangedEventResponse? SubscribersChanged { get; init; }
#else
        public global::ElevenLabs.TicketSubscribersChangedEventResponse? SubscribersChanged { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SubscribersChanged))]
#endif
        public bool IsSubscribersChanged => SubscribersChanged != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSubscribersChanged(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.TicketSubscribersChangedEventResponse? value)
        {
            value = SubscribersChanged;
            return IsSubscribersChanged;
        }

        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TicketSubscribersChangedEventResponse PickSubscribersChanged() => SubscribersChanged is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'SubscribersChanged' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.TicketSubjectChangedEventResponse? SubjectChanged { get; init; }
#else
        public global::ElevenLabs.TicketSubjectChangedEventResponse? SubjectChanged { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SubjectChanged))]
#endif
        public bool IsSubjectChanged => SubjectChanged != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSubjectChanged(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.TicketSubjectChangedEventResponse? value)
        {
            value = SubjectChanged;
            return IsSubjectChanged;
        }

        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TicketSubjectChangedEventResponse PickSubjectChanged() => SubjectChanged is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'SubjectChanged' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.TicketPriorityChangedEventResponse? PriorityChanged { get; init; }
#else
        public global::ElevenLabs.TicketPriorityChangedEventResponse? PriorityChanged { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PriorityChanged))]
#endif
        public bool IsPriorityChanged => PriorityChanged != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickPriorityChanged(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.TicketPriorityChangedEventResponse? value)
        {
            value = PriorityChanged;
            return IsPriorityChanged;
        }

        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TicketPriorityChangedEventResponse PickPriorityChanged() => PriorityChanged is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'PriorityChanged' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.TicketStatusChangedEventResponse? StatusChanged { get; init; }
#else
        public global::ElevenLabs.TicketStatusChangedEventResponse? StatusChanged { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StatusChanged))]
#endif
        public bool IsStatusChanged => StatusChanged != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickStatusChanged(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.TicketStatusChangedEventResponse? value)
        {
            value = StatusChanged;
            return IsStatusChanged;
        }

        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TicketStatusChangedEventResponse PickStatusChanged() => StatusChanged is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'StatusChanged' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.TicketDeadlineChangedEventResponse? DeadlineChanged { get; init; }
#else
        public global::ElevenLabs.TicketDeadlineChangedEventResponse? DeadlineChanged { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DeadlineChanged))]
#endif
        public bool IsDeadlineChanged => DeadlineChanged != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickDeadlineChanged(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.TicketDeadlineChangedEventResponse? value)
        {
            value = DeadlineChanged;
            return IsDeadlineChanged;
        }

        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TicketDeadlineChangedEventResponse PickDeadlineChanged() => DeadlineChanged is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'DeadlineChanged' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.TicketTagIdsChangedEventResponse? TagIdsChanged { get; init; }
#else
        public global::ElevenLabs.TicketTagIdsChangedEventResponse? TagIdsChanged { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TagIdsChanged))]
#endif
        public bool IsTagIdsChanged => TagIdsChanged != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickTagIdsChanged(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.TicketTagIdsChangedEventResponse? value)
        {
            value = TagIdsChanged;
            return IsTagIdsChanged;
        }

        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TicketTagIdsChangedEventResponse PickTagIdsChanged() => TagIdsChanged is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'TagIdsChanged' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator EventsItem(global::ElevenLabs.TicketMessageEventResponse value) => new EventsItem((global::ElevenLabs.TicketMessageEventResponse?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::ElevenLabs.TicketMessageEventResponse?(EventsItem @this) => @this.Message;

        /// <summary>
        ///
        /// </summary>
        public EventsItem(global::ElevenLabs.TicketMessageEventResponse? value)
        {
            Message = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static EventsItem FromMessage(global::ElevenLabs.TicketMessageEventResponse? value) => new EventsItem(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator EventsItem(global::ElevenLabs.TicketCreatedEventResponse value) => new EventsItem((global::ElevenLabs.TicketCreatedEventResponse?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::ElevenLabs.TicketCreatedEventResponse?(EventsItem @this) => @this.TicketCreated;

        /// <summary>
        ///
        /// </summary>
        public EventsItem(global::ElevenLabs.TicketCreatedEventResponse? value)
        {
            TicketCreated = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static EventsItem FromTicketCreated(global::ElevenLabs.TicketCreatedEventResponse? value) => new EventsItem(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator EventsItem(global::ElevenLabs.TicketDeletedEventResponse value) => new EventsItem((global::ElevenLabs.TicketDeletedEventResponse?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::ElevenLabs.TicketDeletedEventResponse?(EventsItem @this) => @this.TicketDeleted;

        /// <summary>
        ///
        /// </summary>
        public EventsItem(global::ElevenLabs.TicketDeletedEventResponse? value)
        {
            TicketDeleted = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static EventsItem FromTicketDeleted(global::ElevenLabs.TicketDeletedEventResponse? value) => new EventsItem(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator EventsItem(global::ElevenLabs.TicketAssigneeChangedEventResponse value) => new EventsItem((global::ElevenLabs.TicketAssigneeChangedEventResponse?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::ElevenLabs.TicketAssigneeChangedEventResponse?(EventsItem @this) => @this.AssigneeChanged;

        /// <summary>
        ///
        /// </summary>
        public EventsItem(global::ElevenLabs.TicketAssigneeChangedEventResponse? value)
        {
            AssigneeChanged = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static EventsItem FromAssigneeChanged(global::ElevenLabs.TicketAssigneeChangedEventResponse? value) => new EventsItem(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator EventsItem(global::ElevenLabs.TicketSecondaryAssigneeChangedEventResponse value) => new EventsItem((global::ElevenLabs.TicketSecondaryAssigneeChangedEventResponse?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::ElevenLabs.TicketSecondaryAssigneeChangedEventResponse?(EventsItem @this) => @this.SecondaryAssigneeChanged;

        /// <summary>
        ///
        /// </summary>
        public EventsItem(global::ElevenLabs.TicketSecondaryAssigneeChangedEventResponse? value)
        {
            SecondaryAssigneeChanged = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static EventsItem FromSecondaryAssigneeChanged(global::ElevenLabs.TicketSecondaryAssigneeChangedEventResponse? value) => new EventsItem(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator EventsItem(global::ElevenLabs.TicketSubscribersChangedEventResponse value) => new EventsItem((global::ElevenLabs.TicketSubscribersChangedEventResponse?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::ElevenLabs.TicketSubscribersChangedEventResponse?(EventsItem @this) => @this.SubscribersChanged;

        /// <summary>
        ///
        /// </summary>
        public EventsItem(global::ElevenLabs.TicketSubscribersChangedEventResponse? value)
        {
            SubscribersChanged = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static EventsItem FromSubscribersChanged(global::ElevenLabs.TicketSubscribersChangedEventResponse? value) => new EventsItem(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator EventsItem(global::ElevenLabs.TicketSubjectChangedEventResponse value) => new EventsItem((global::ElevenLabs.TicketSubjectChangedEventResponse?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::ElevenLabs.TicketSubjectChangedEventResponse?(EventsItem @this) => @this.SubjectChanged;

        /// <summary>
        ///
        /// </summary>
        public EventsItem(global::ElevenLabs.TicketSubjectChangedEventResponse? value)
        {
            SubjectChanged = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static EventsItem FromSubjectChanged(global::ElevenLabs.TicketSubjectChangedEventResponse? value) => new EventsItem(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator EventsItem(global::ElevenLabs.TicketPriorityChangedEventResponse value) => new EventsItem((global::ElevenLabs.TicketPriorityChangedEventResponse?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::ElevenLabs.TicketPriorityChangedEventResponse?(EventsItem @this) => @this.PriorityChanged;

        /// <summary>
        ///
        /// </summary>
        public EventsItem(global::ElevenLabs.TicketPriorityChangedEventResponse? value)
        {
            PriorityChanged = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static EventsItem FromPriorityChanged(global::ElevenLabs.TicketPriorityChangedEventResponse? value) => new EventsItem(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator EventsItem(global::ElevenLabs.TicketStatusChangedEventResponse value) => new EventsItem((global::ElevenLabs.TicketStatusChangedEventResponse?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::ElevenLabs.TicketStatusChangedEventResponse?(EventsItem @this) => @this.StatusChanged;

        /// <summary>
        ///
        /// </summary>
        public EventsItem(global::ElevenLabs.TicketStatusChangedEventResponse? value)
        {
            StatusChanged = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static EventsItem FromStatusChanged(global::ElevenLabs.TicketStatusChangedEventResponse? value) => new EventsItem(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator EventsItem(global::ElevenLabs.TicketDeadlineChangedEventResponse value) => new EventsItem((global::ElevenLabs.TicketDeadlineChangedEventResponse?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::ElevenLabs.TicketDeadlineChangedEventResponse?(EventsItem @this) => @this.DeadlineChanged;

        /// <summary>
        ///
        /// </summary>
        public EventsItem(global::ElevenLabs.TicketDeadlineChangedEventResponse? value)
        {
            DeadlineChanged = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static EventsItem FromDeadlineChanged(global::ElevenLabs.TicketDeadlineChangedEventResponse? value) => new EventsItem(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator EventsItem(global::ElevenLabs.TicketTagIdsChangedEventResponse value) => new EventsItem((global::ElevenLabs.TicketTagIdsChangedEventResponse?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::ElevenLabs.TicketTagIdsChangedEventResponse?(EventsItem @this) => @this.TagIdsChanged;

        /// <summary>
        ///
        /// </summary>
        public EventsItem(global::ElevenLabs.TicketTagIdsChangedEventResponse? value)
        {
            TagIdsChanged = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static EventsItem FromTagIdsChanged(global::ElevenLabs.TicketTagIdsChangedEventResponse? value) => new EventsItem(value);

        /// <summary>
        ///
        /// </summary>
        public EventsItem(
            global::ElevenLabs.GetTicketResponseEventDiscriminatorType? type,
            global::ElevenLabs.TicketMessageEventResponse? message,
            global::ElevenLabs.TicketCreatedEventResponse? ticketCreated,
            global::ElevenLabs.TicketDeletedEventResponse? ticketDeleted,
            global::ElevenLabs.TicketAssigneeChangedEventResponse? assigneeChanged,
            global::ElevenLabs.TicketSecondaryAssigneeChangedEventResponse? secondaryAssigneeChanged,
            global::ElevenLabs.TicketSubscribersChangedEventResponse? subscribersChanged,
            global::ElevenLabs.TicketSubjectChangedEventResponse? subjectChanged,
            global::ElevenLabs.TicketPriorityChangedEventResponse? priorityChanged,
            global::ElevenLabs.TicketStatusChangedEventResponse? statusChanged,
            global::ElevenLabs.TicketDeadlineChangedEventResponse? deadlineChanged,
            global::ElevenLabs.TicketTagIdsChangedEventResponse? tagIdsChanged
            )
        {
            Type = type;

            Message = message;
            TicketCreated = ticketCreated;
            TicketDeleted = ticketDeleted;
            AssigneeChanged = assigneeChanged;
            SecondaryAssigneeChanged = secondaryAssigneeChanged;
            SubscribersChanged = subscribersChanged;
            SubjectChanged = subjectChanged;
            PriorityChanged = priorityChanged;
            StatusChanged = statusChanged;
            DeadlineChanged = deadlineChanged;
            TagIdsChanged = tagIdsChanged;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            TagIdsChanged as object ??
            DeadlineChanged as object ??
            StatusChanged as object ??
            PriorityChanged as object ??
            SubjectChanged as object ??
            SubscribersChanged as object ??
            SecondaryAssigneeChanged as object ??
            AssigneeChanged as object ??
            TicketDeleted as object ??
            TicketCreated as object ??
            Message as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Message?.ToString() ??
            TicketCreated?.ToString() ??
            TicketDeleted?.ToString() ??
            AssigneeChanged?.ToString() ??
            SecondaryAssigneeChanged?.ToString() ??
            SubscribersChanged?.ToString() ??
            SubjectChanged?.ToString() ??
            PriorityChanged?.ToString() ??
            StatusChanged?.ToString() ??
            DeadlineChanged?.ToString() ??
            TagIdsChanged?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsMessage && !IsTicketCreated && !IsTicketDeleted && !IsAssigneeChanged && !IsSecondaryAssigneeChanged && !IsSubscribersChanged && !IsSubjectChanged && !IsPriorityChanged && !IsStatusChanged && !IsDeadlineChanged && !IsTagIdsChanged || !IsMessage && IsTicketCreated && !IsTicketDeleted && !IsAssigneeChanged && !IsSecondaryAssigneeChanged && !IsSubscribersChanged && !IsSubjectChanged && !IsPriorityChanged && !IsStatusChanged && !IsDeadlineChanged && !IsTagIdsChanged || !IsMessage && !IsTicketCreated && IsTicketDeleted && !IsAssigneeChanged && !IsSecondaryAssigneeChanged && !IsSubscribersChanged && !IsSubjectChanged && !IsPriorityChanged && !IsStatusChanged && !IsDeadlineChanged && !IsTagIdsChanged || !IsMessage && !IsTicketCreated && !IsTicketDeleted && IsAssigneeChanged && !IsSecondaryAssigneeChanged && !IsSubscribersChanged && !IsSubjectChanged && !IsPriorityChanged && !IsStatusChanged && !IsDeadlineChanged && !IsTagIdsChanged || !IsMessage && !IsTicketCreated && !IsTicketDeleted && !IsAssigneeChanged && IsSecondaryAssigneeChanged && !IsSubscribersChanged && !IsSubjectChanged && !IsPriorityChanged && !IsStatusChanged && !IsDeadlineChanged && !IsTagIdsChanged || !IsMessage && !IsTicketCreated && !IsTicketDeleted && !IsAssigneeChanged && !IsSecondaryAssigneeChanged && IsSubscribersChanged && !IsSubjectChanged && !IsPriorityChanged && !IsStatusChanged && !IsDeadlineChanged && !IsTagIdsChanged || !IsMessage && !IsTicketCreated && !IsTicketDeleted && !IsAssigneeChanged && !IsSecondaryAssigneeChanged && !IsSubscribersChanged && IsSubjectChanged && !IsPriorityChanged && !IsStatusChanged && !IsDeadlineChanged && !IsTagIdsChanged || !IsMessage && !IsTicketCreated && !IsTicketDeleted && !IsAssigneeChanged && !IsSecondaryAssigneeChanged && !IsSubscribersChanged && !IsSubjectChanged && IsPriorityChanged && !IsStatusChanged && !IsDeadlineChanged && !IsTagIdsChanged || !IsMessage && !IsTicketCreated && !IsTicketDeleted && !IsAssigneeChanged && !IsSecondaryAssigneeChanged && !IsSubscribersChanged && !IsSubjectChanged && !IsPriorityChanged && IsStatusChanged && !IsDeadlineChanged && !IsTagIdsChanged || !IsMessage && !IsTicketCreated && !IsTicketDeleted && !IsAssigneeChanged && !IsSecondaryAssigneeChanged && !IsSubscribersChanged && !IsSubjectChanged && !IsPriorityChanged && !IsStatusChanged && IsDeadlineChanged && !IsTagIdsChanged || !IsMessage && !IsTicketCreated && !IsTicketDeleted && !IsAssigneeChanged && !IsSecondaryAssigneeChanged && !IsSubscribersChanged && !IsSubjectChanged && !IsPriorityChanged && !IsStatusChanged && !IsDeadlineChanged && IsTagIdsChanged;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::ElevenLabs.TicketMessageEventResponse, TResult>? message = null,
            global::System.Func<global::ElevenLabs.TicketCreatedEventResponse, TResult>? ticketCreated = null,
            global::System.Func<global::ElevenLabs.TicketDeletedEventResponse, TResult>? ticketDeleted = null,
            global::System.Func<global::ElevenLabs.TicketAssigneeChangedEventResponse, TResult>? assigneeChanged = null,
            global::System.Func<global::ElevenLabs.TicketSecondaryAssigneeChangedEventResponse, TResult>? secondaryAssigneeChanged = null,
            global::System.Func<global::ElevenLabs.TicketSubscribersChangedEventResponse, TResult>? subscribersChanged = null,
            global::System.Func<global::ElevenLabs.TicketSubjectChangedEventResponse, TResult>? subjectChanged = null,
            global::System.Func<global::ElevenLabs.TicketPriorityChangedEventResponse, TResult>? priorityChanged = null,
            global::System.Func<global::ElevenLabs.TicketStatusChangedEventResponse, TResult>? statusChanged = null,
            global::System.Func<global::ElevenLabs.TicketDeadlineChangedEventResponse, TResult>? deadlineChanged = null,
            global::System.Func<global::ElevenLabs.TicketTagIdsChangedEventResponse, TResult>? tagIdsChanged = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Message is { } __value0 && message != null)
            {
                return message(__value0);
            }
            else if (TicketCreated is { } __value1 && ticketCreated != null)
            {
                return ticketCreated(__value1);
            }
            else if (TicketDeleted is { } __value2 && ticketDeleted != null)
            {
                return ticketDeleted(__value2);
            }
            else if (AssigneeChanged is { } __value3 && assigneeChanged != null)
            {
                return assigneeChanged(__value3);
            }
            else if (SecondaryAssigneeChanged is { } __value4 && secondaryAssigneeChanged != null)
            {
                return secondaryAssigneeChanged(__value4);
            }
            else if (SubscribersChanged is { } __value5 && subscribersChanged != null)
            {
                return subscribersChanged(__value5);
            }
            else if (SubjectChanged is { } __value6 && subjectChanged != null)
            {
                return subjectChanged(__value6);
            }
            else if (PriorityChanged is { } __value7 && priorityChanged != null)
            {
                return priorityChanged(__value7);
            }
            else if (StatusChanged is { } __value8 && statusChanged != null)
            {
                return statusChanged(__value8);
            }
            else if (DeadlineChanged is { } __value9 && deadlineChanged != null)
            {
                return deadlineChanged(__value9);
            }
            else if (TagIdsChanged is { } __value10 && tagIdsChanged != null)
            {
                return tagIdsChanged(__value10);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::ElevenLabs.TicketMessageEventResponse>? message = null,

            global::System.Action<global::ElevenLabs.TicketCreatedEventResponse>? ticketCreated = null,

            global::System.Action<global::ElevenLabs.TicketDeletedEventResponse>? ticketDeleted = null,

            global::System.Action<global::ElevenLabs.TicketAssigneeChangedEventResponse>? assigneeChanged = null,

            global::System.Action<global::ElevenLabs.TicketSecondaryAssigneeChangedEventResponse>? secondaryAssigneeChanged = null,

            global::System.Action<global::ElevenLabs.TicketSubscribersChangedEventResponse>? subscribersChanged = null,

            global::System.Action<global::ElevenLabs.TicketSubjectChangedEventResponse>? subjectChanged = null,

            global::System.Action<global::ElevenLabs.TicketPriorityChangedEventResponse>? priorityChanged = null,

            global::System.Action<global::ElevenLabs.TicketStatusChangedEventResponse>? statusChanged = null,

            global::System.Action<global::ElevenLabs.TicketDeadlineChangedEventResponse>? deadlineChanged = null,

            global::System.Action<global::ElevenLabs.TicketTagIdsChangedEventResponse>? tagIdsChanged = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Message is { } __value0)
            {
                message?.Invoke(__value0);
            }
            else if (TicketCreated is { } __value1)
            {
                ticketCreated?.Invoke(__value1);
            }
            else if (TicketDeleted is { } __value2)
            {
                ticketDeleted?.Invoke(__value2);
            }
            else if (AssigneeChanged is { } __value3)
            {
                assigneeChanged?.Invoke(__value3);
            }
            else if (SecondaryAssigneeChanged is { } __value4)
            {
                secondaryAssigneeChanged?.Invoke(__value4);
            }
            else if (SubscribersChanged is { } __value5)
            {
                subscribersChanged?.Invoke(__value5);
            }
            else if (SubjectChanged is { } __value6)
            {
                subjectChanged?.Invoke(__value6);
            }
            else if (PriorityChanged is { } __value7)
            {
                priorityChanged?.Invoke(__value7);
            }
            else if (StatusChanged is { } __value8)
            {
                statusChanged?.Invoke(__value8);
            }
            else if (DeadlineChanged is { } __value9)
            {
                deadlineChanged?.Invoke(__value9);
            }
            else if (TagIdsChanged is { } __value10)
            {
                tagIdsChanged?.Invoke(__value10);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::ElevenLabs.TicketMessageEventResponse>? message = null,
            global::System.Action<global::ElevenLabs.TicketCreatedEventResponse>? ticketCreated = null,
            global::System.Action<global::ElevenLabs.TicketDeletedEventResponse>? ticketDeleted = null,
            global::System.Action<global::ElevenLabs.TicketAssigneeChangedEventResponse>? assigneeChanged = null,
            global::System.Action<global::ElevenLabs.TicketSecondaryAssigneeChangedEventResponse>? secondaryAssigneeChanged = null,
            global::System.Action<global::ElevenLabs.TicketSubscribersChangedEventResponse>? subscribersChanged = null,
            global::System.Action<global::ElevenLabs.TicketSubjectChangedEventResponse>? subjectChanged = null,
            global::System.Action<global::ElevenLabs.TicketPriorityChangedEventResponse>? priorityChanged = null,
            global::System.Action<global::ElevenLabs.TicketStatusChangedEventResponse>? statusChanged = null,
            global::System.Action<global::ElevenLabs.TicketDeadlineChangedEventResponse>? deadlineChanged = null,
            global::System.Action<global::ElevenLabs.TicketTagIdsChangedEventResponse>? tagIdsChanged = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Message is { } __value0)
            {
                message?.Invoke(__value0);
            }
            else if (TicketCreated is { } __value1)
            {
                ticketCreated?.Invoke(__value1);
            }
            else if (TicketDeleted is { } __value2)
            {
                ticketDeleted?.Invoke(__value2);
            }
            else if (AssigneeChanged is { } __value3)
            {
                assigneeChanged?.Invoke(__value3);
            }
            else if (SecondaryAssigneeChanged is { } __value4)
            {
                secondaryAssigneeChanged?.Invoke(__value4);
            }
            else if (SubscribersChanged is { } __value5)
            {
                subscribersChanged?.Invoke(__value5);
            }
            else if (SubjectChanged is { } __value6)
            {
                subjectChanged?.Invoke(__value6);
            }
            else if (PriorityChanged is { } __value7)
            {
                priorityChanged?.Invoke(__value7);
            }
            else if (StatusChanged is { } __value8)
            {
                statusChanged?.Invoke(__value8);
            }
            else if (DeadlineChanged is { } __value9)
            {
                deadlineChanged?.Invoke(__value9);
            }
            else if (TagIdsChanged is { } __value10)
            {
                tagIdsChanged?.Invoke(__value10);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Message,
                typeof(global::ElevenLabs.TicketMessageEventResponse),
                TicketCreated,
                typeof(global::ElevenLabs.TicketCreatedEventResponse),
                TicketDeleted,
                typeof(global::ElevenLabs.TicketDeletedEventResponse),
                AssigneeChanged,
                typeof(global::ElevenLabs.TicketAssigneeChangedEventResponse),
                SecondaryAssigneeChanged,
                typeof(global::ElevenLabs.TicketSecondaryAssigneeChangedEventResponse),
                SubscribersChanged,
                typeof(global::ElevenLabs.TicketSubscribersChangedEventResponse),
                SubjectChanged,
                typeof(global::ElevenLabs.TicketSubjectChangedEventResponse),
                PriorityChanged,
                typeof(global::ElevenLabs.TicketPriorityChangedEventResponse),
                StatusChanged,
                typeof(global::ElevenLabs.TicketStatusChangedEventResponse),
                DeadlineChanged,
                typeof(global::ElevenLabs.TicketDeadlineChangedEventResponse),
                TagIdsChanged,
                typeof(global::ElevenLabs.TicketTagIdsChangedEventResponse),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        ///
        /// </summary>
        public bool Equals(EventsItem other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.TicketMessageEventResponse?>.Default.Equals(Message, other.Message) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.TicketCreatedEventResponse?>.Default.Equals(TicketCreated, other.TicketCreated) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.TicketDeletedEventResponse?>.Default.Equals(TicketDeleted, other.TicketDeleted) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.TicketAssigneeChangedEventResponse?>.Default.Equals(AssigneeChanged, other.AssigneeChanged) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.TicketSecondaryAssigneeChangedEventResponse?>.Default.Equals(SecondaryAssigneeChanged, other.SecondaryAssigneeChanged) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.TicketSubscribersChangedEventResponse?>.Default.Equals(SubscribersChanged, other.SubscribersChanged) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.TicketSubjectChangedEventResponse?>.Default.Equals(SubjectChanged, other.SubjectChanged) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.TicketPriorityChangedEventResponse?>.Default.Equals(PriorityChanged, other.PriorityChanged) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.TicketStatusChangedEventResponse?>.Default.Equals(StatusChanged, other.StatusChanged) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.TicketDeadlineChangedEventResponse?>.Default.Equals(DeadlineChanged, other.DeadlineChanged) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.TicketTagIdsChangedEventResponse?>.Default.Equals(TagIdsChanged, other.TagIdsChanged)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(EventsItem obj1, EventsItem obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<EventsItem>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(EventsItem obj1, EventsItem obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is EventsItem o && Equals(o);
        }
    }
}
