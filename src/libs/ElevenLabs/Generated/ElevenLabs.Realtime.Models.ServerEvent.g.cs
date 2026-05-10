#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace ElevenLabs.Realtime
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ServerEvent : global::System.IEquatable<ServerEvent>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::ElevenLabs.Realtime.ServerEventDiscriminatorMessageType? MessageType { get; }

        /// <summary>
        /// Event sent when a realtime session is established.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.Realtime.SessionStartedPayload? SessionStarted { get; init; }
#else
        public global::ElevenLabs.Realtime.SessionStartedPayload? SessionStarted { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SessionStarted))]
#endif
        public bool IsSessionStarted => SessionStarted != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickSessionStarted(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.Realtime.SessionStartedPayload? value)
        {
            value = SessionStarted;
            return IsSessionStarted;
        }

        /// <summary>
        /// Event containing a partial (in-progress) transcript.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.Realtime.PartialTranscriptPayload? PartialTranscript { get; init; }
#else
        public global::ElevenLabs.Realtime.PartialTranscriptPayload? PartialTranscript { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PartialTranscript))]
#endif
        public bool IsPartialTranscript => PartialTranscript != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickPartialTranscript(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.Realtime.PartialTranscriptPayload? value)
        {
            value = PartialTranscript;
            return IsPartialTranscript;
        }

        /// <summary>
        /// Event containing a committed (final) transcript.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.Realtime.CommittedTranscriptPayload? CommittedTranscript { get; init; }
#else
        public global::ElevenLabs.Realtime.CommittedTranscriptPayload? CommittedTranscript { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CommittedTranscript))]
#endif
        public bool IsCommittedTranscript => CommittedTranscript != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickCommittedTranscript(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.Realtime.CommittedTranscriptPayload? value)
        {
            value = CommittedTranscript;
            return IsCommittedTranscript;
        }

        /// <summary>
        /// Event containing a committed transcript with word-level timestamps.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.Realtime.CommittedTranscriptWithTimestampsPayload? CommittedTranscriptWithTimestamps { get; init; }
#else
        public global::ElevenLabs.Realtime.CommittedTranscriptWithTimestampsPayload? CommittedTranscriptWithTimestamps { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CommittedTranscriptWithTimestamps))]
#endif
        public bool IsCommittedTranscriptWithTimestamps => CommittedTranscriptWithTimestamps != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickCommittedTranscriptWithTimestamps(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.Realtime.CommittedTranscriptWithTimestampsPayload? value)
        {
            value = CommittedTranscriptWithTimestamps;
            return IsCommittedTranscriptWithTimestamps;
        }

        /// <summary>
        /// Error event from the ElevenLabs service.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.Realtime.ErrorPayload? Error { get; init; }
#else
        public global::ElevenLabs.Realtime.ErrorPayload? Error { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Error))]
#endif
        public bool IsError => Error != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickError(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.Realtime.ErrorPayload? value)
        {
            value = Error;
            return IsError;
        }
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ServerEvent(global::ElevenLabs.Realtime.SessionStartedPayload value) => new ServerEvent((global::ElevenLabs.Realtime.SessionStartedPayload?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.Realtime.SessionStartedPayload?(ServerEvent @this) => @this.SessionStarted;

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(global::ElevenLabs.Realtime.SessionStartedPayload? value)
        {
            SessionStarted = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ServerEvent FromSessionStarted(global::ElevenLabs.Realtime.SessionStartedPayload? value) => new ServerEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ServerEvent(global::ElevenLabs.Realtime.PartialTranscriptPayload value) => new ServerEvent((global::ElevenLabs.Realtime.PartialTranscriptPayload?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.Realtime.PartialTranscriptPayload?(ServerEvent @this) => @this.PartialTranscript;

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(global::ElevenLabs.Realtime.PartialTranscriptPayload? value)
        {
            PartialTranscript = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ServerEvent FromPartialTranscript(global::ElevenLabs.Realtime.PartialTranscriptPayload? value) => new ServerEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ServerEvent(global::ElevenLabs.Realtime.CommittedTranscriptPayload value) => new ServerEvent((global::ElevenLabs.Realtime.CommittedTranscriptPayload?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.Realtime.CommittedTranscriptPayload?(ServerEvent @this) => @this.CommittedTranscript;

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(global::ElevenLabs.Realtime.CommittedTranscriptPayload? value)
        {
            CommittedTranscript = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ServerEvent FromCommittedTranscript(global::ElevenLabs.Realtime.CommittedTranscriptPayload? value) => new ServerEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ServerEvent(global::ElevenLabs.Realtime.CommittedTranscriptWithTimestampsPayload value) => new ServerEvent((global::ElevenLabs.Realtime.CommittedTranscriptWithTimestampsPayload?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.Realtime.CommittedTranscriptWithTimestampsPayload?(ServerEvent @this) => @this.CommittedTranscriptWithTimestamps;

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(global::ElevenLabs.Realtime.CommittedTranscriptWithTimestampsPayload? value)
        {
            CommittedTranscriptWithTimestamps = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ServerEvent FromCommittedTranscriptWithTimestamps(global::ElevenLabs.Realtime.CommittedTranscriptWithTimestampsPayload? value) => new ServerEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ServerEvent(global::ElevenLabs.Realtime.ErrorPayload value) => new ServerEvent((global::ElevenLabs.Realtime.ErrorPayload?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.Realtime.ErrorPayload?(ServerEvent @this) => @this.Error;

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(global::ElevenLabs.Realtime.ErrorPayload? value)
        {
            Error = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ServerEvent FromError(global::ElevenLabs.Realtime.ErrorPayload? value) => new ServerEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(
            global::ElevenLabs.Realtime.ServerEventDiscriminatorMessageType? messageType,
            global::ElevenLabs.Realtime.SessionStartedPayload? sessionStarted,
            global::ElevenLabs.Realtime.PartialTranscriptPayload? partialTranscript,
            global::ElevenLabs.Realtime.CommittedTranscriptPayload? committedTranscript,
            global::ElevenLabs.Realtime.CommittedTranscriptWithTimestampsPayload? committedTranscriptWithTimestamps,
            global::ElevenLabs.Realtime.ErrorPayload? error
            )
        {
            MessageType = messageType;

            SessionStarted = sessionStarted;
            PartialTranscript = partialTranscript;
            CommittedTranscript = committedTranscript;
            CommittedTranscriptWithTimestamps = committedTranscriptWithTimestamps;
            Error = error;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Error as object ??
            CommittedTranscriptWithTimestamps as object ??
            CommittedTranscript as object ??
            PartialTranscript as object ??
            SessionStarted as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            SessionStarted?.ToString() ??
            PartialTranscript?.ToString() ??
            CommittedTranscript?.ToString() ??
            CommittedTranscriptWithTimestamps?.ToString() ??
            Error?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsSessionStarted && !IsPartialTranscript && !IsCommittedTranscript && !IsCommittedTranscriptWithTimestamps && !IsError || !IsSessionStarted && IsPartialTranscript && !IsCommittedTranscript && !IsCommittedTranscriptWithTimestamps && !IsError || !IsSessionStarted && !IsPartialTranscript && IsCommittedTranscript && !IsCommittedTranscriptWithTimestamps && !IsError || !IsSessionStarted && !IsPartialTranscript && !IsCommittedTranscript && IsCommittedTranscriptWithTimestamps && !IsError || !IsSessionStarted && !IsPartialTranscript && !IsCommittedTranscript && !IsCommittedTranscriptWithTimestamps && IsError;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::ElevenLabs.Realtime.SessionStartedPayload, TResult>? sessionStarted = null,
            global::System.Func<global::ElevenLabs.Realtime.PartialTranscriptPayload, TResult>? partialTranscript = null,
            global::System.Func<global::ElevenLabs.Realtime.CommittedTranscriptPayload, TResult>? committedTranscript = null,
            global::System.Func<global::ElevenLabs.Realtime.CommittedTranscriptWithTimestampsPayload, TResult>? committedTranscriptWithTimestamps = null,
            global::System.Func<global::ElevenLabs.Realtime.ErrorPayload, TResult>? error = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSessionStarted && sessionStarted != null)
            {
                return sessionStarted(SessionStarted!);
            }
            else if (IsPartialTranscript && partialTranscript != null)
            {
                return partialTranscript(PartialTranscript!);
            }
            else if (IsCommittedTranscript && committedTranscript != null)
            {
                return committedTranscript(CommittedTranscript!);
            }
            else if (IsCommittedTranscriptWithTimestamps && committedTranscriptWithTimestamps != null)
            {
                return committedTranscriptWithTimestamps(CommittedTranscriptWithTimestamps!);
            }
            else if (IsError && error != null)
            {
                return error(Error!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::ElevenLabs.Realtime.SessionStartedPayload>? sessionStarted = null,

            global::System.Action<global::ElevenLabs.Realtime.PartialTranscriptPayload>? partialTranscript = null,

            global::System.Action<global::ElevenLabs.Realtime.CommittedTranscriptPayload>? committedTranscript = null,

            global::System.Action<global::ElevenLabs.Realtime.CommittedTranscriptWithTimestampsPayload>? committedTranscriptWithTimestamps = null,

            global::System.Action<global::ElevenLabs.Realtime.ErrorPayload>? error = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSessionStarted)
            {
                sessionStarted?.Invoke(SessionStarted!);
            }
            else if (IsPartialTranscript)
            {
                partialTranscript?.Invoke(PartialTranscript!);
            }
            else if (IsCommittedTranscript)
            {
                committedTranscript?.Invoke(CommittedTranscript!);
            }
            else if (IsCommittedTranscriptWithTimestamps)
            {
                committedTranscriptWithTimestamps?.Invoke(CommittedTranscriptWithTimestamps!);
            }
            else if (IsError)
            {
                error?.Invoke(Error!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::ElevenLabs.Realtime.SessionStartedPayload>? sessionStarted = null,
            global::System.Action<global::ElevenLabs.Realtime.PartialTranscriptPayload>? partialTranscript = null,
            global::System.Action<global::ElevenLabs.Realtime.CommittedTranscriptPayload>? committedTranscript = null,
            global::System.Action<global::ElevenLabs.Realtime.CommittedTranscriptWithTimestampsPayload>? committedTranscriptWithTimestamps = null,
            global::System.Action<global::ElevenLabs.Realtime.ErrorPayload>? error = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSessionStarted)
            {
                sessionStarted?.Invoke(SessionStarted!);
            }
            else if (IsPartialTranscript)
            {
                partialTranscript?.Invoke(PartialTranscript!);
            }
            else if (IsCommittedTranscript)
            {
                committedTranscript?.Invoke(CommittedTranscript!);
            }
            else if (IsCommittedTranscriptWithTimestamps)
            {
                committedTranscriptWithTimestamps?.Invoke(CommittedTranscriptWithTimestamps!);
            }
            else if (IsError)
            {
                error?.Invoke(Error!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                SessionStarted,
                typeof(global::ElevenLabs.Realtime.SessionStartedPayload),
                PartialTranscript,
                typeof(global::ElevenLabs.Realtime.PartialTranscriptPayload),
                CommittedTranscript,
                typeof(global::ElevenLabs.Realtime.CommittedTranscriptPayload),
                CommittedTranscriptWithTimestamps,
                typeof(global::ElevenLabs.Realtime.CommittedTranscriptWithTimestampsPayload),
                Error,
                typeof(global::ElevenLabs.Realtime.ErrorPayload),
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
        public bool Equals(ServerEvent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.Realtime.SessionStartedPayload?>.Default.Equals(SessionStarted, other.SessionStarted) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.Realtime.PartialTranscriptPayload?>.Default.Equals(PartialTranscript, other.PartialTranscript) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.Realtime.CommittedTranscriptPayload?>.Default.Equals(CommittedTranscript, other.CommittedTranscript) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.Realtime.CommittedTranscriptWithTimestampsPayload?>.Default.Equals(CommittedTranscriptWithTimestamps, other.CommittedTranscriptWithTimestamps) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.Realtime.ErrorPayload?>.Default.Equals(Error, other.Error) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ServerEvent obj1, ServerEvent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ServerEvent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ServerEvent obj1, ServerEvent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ServerEvent o && Equals(o);
        }
    }
}
