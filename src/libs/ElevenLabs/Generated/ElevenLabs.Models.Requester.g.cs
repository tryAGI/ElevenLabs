#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct Requester : global::System.IEquatable<Requester>
    {
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CreateTicketRequestRequesterDiscriminatorType? Type { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.TicketRequesterByUserIdRequest? UserId { get; init; }
#else
        public global::ElevenLabs.TicketRequesterByUserIdRequest? UserId { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UserId))]
#endif
        public bool IsUserId => UserId != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickUserId(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.TicketRequesterByUserIdRequest? value)
        {
            value = UserId;
            return IsUserId;
        }

        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TicketRequesterByUserIdRequest PickUserId() => UserId is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'UserId' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.TicketRequesterByEmailRequest? Email { get; init; }
#else
        public global::ElevenLabs.TicketRequesterByEmailRequest? Email { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Email))]
#endif
        public bool IsEmail => Email != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickEmail(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.TicketRequesterByEmailRequest? value)
        {
            value = Email;
            return IsEmail;
        }

        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TicketRequesterByEmailRequest PickEmail() => Email is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Email' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.TicketRequesterBySlackRequest? Slack { get; init; }
#else
        public global::ElevenLabs.TicketRequesterBySlackRequest? Slack { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Slack))]
#endif
        public bool IsSlack => Slack != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSlack(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.TicketRequesterBySlackRequest? value)
        {
            value = Slack;
            return IsSlack;
        }

        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TicketRequesterBySlackRequest PickSlack() => Slack is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Slack' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator Requester(global::ElevenLabs.TicketRequesterByUserIdRequest value) => new Requester((global::ElevenLabs.TicketRequesterByUserIdRequest?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::ElevenLabs.TicketRequesterByUserIdRequest?(Requester @this) => @this.UserId;

        /// <summary>
        ///
        /// </summary>
        public Requester(global::ElevenLabs.TicketRequesterByUserIdRequest? value)
        {
            UserId = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Requester FromUserId(global::ElevenLabs.TicketRequesterByUserIdRequest? value) => new Requester(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Requester(global::ElevenLabs.TicketRequesterByEmailRequest value) => new Requester((global::ElevenLabs.TicketRequesterByEmailRequest?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::ElevenLabs.TicketRequesterByEmailRequest?(Requester @this) => @this.Email;

        /// <summary>
        ///
        /// </summary>
        public Requester(global::ElevenLabs.TicketRequesterByEmailRequest? value)
        {
            Email = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Requester FromEmail(global::ElevenLabs.TicketRequesterByEmailRequest? value) => new Requester(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Requester(global::ElevenLabs.TicketRequesterBySlackRequest value) => new Requester((global::ElevenLabs.TicketRequesterBySlackRequest?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::ElevenLabs.TicketRequesterBySlackRequest?(Requester @this) => @this.Slack;

        /// <summary>
        ///
        /// </summary>
        public Requester(global::ElevenLabs.TicketRequesterBySlackRequest? value)
        {
            Slack = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Requester FromSlack(global::ElevenLabs.TicketRequesterBySlackRequest? value) => new Requester(value);

        /// <summary>
        ///
        /// </summary>
        public Requester(
            global::ElevenLabs.CreateTicketRequestRequesterDiscriminatorType? type,
            global::ElevenLabs.TicketRequesterByUserIdRequest? userId,
            global::ElevenLabs.TicketRequesterByEmailRequest? email,
            global::ElevenLabs.TicketRequesterBySlackRequest? slack
            )
        {
            Type = type;

            UserId = userId;
            Email = email;
            Slack = slack;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Slack as object ??
            Email as object ??
            UserId as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            UserId?.ToString() ??
            Email?.ToString() ??
            Slack?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsUserId && !IsEmail && !IsSlack || !IsUserId && IsEmail && !IsSlack || !IsUserId && !IsEmail && IsSlack;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::ElevenLabs.TicketRequesterByUserIdRequest, TResult>? userId = null,
            global::System.Func<global::ElevenLabs.TicketRequesterByEmailRequest, TResult>? email = null,
            global::System.Func<global::ElevenLabs.TicketRequesterBySlackRequest, TResult>? slack = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (UserId is { } __value0 && userId != null)
            {
                return userId(__value0);
            }
            else if (Email is { } __value1 && email != null)
            {
                return email(__value1);
            }
            else if (Slack is { } __value2 && slack != null)
            {
                return slack(__value2);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::ElevenLabs.TicketRequesterByUserIdRequest>? userId = null,

            global::System.Action<global::ElevenLabs.TicketRequesterByEmailRequest>? email = null,

            global::System.Action<global::ElevenLabs.TicketRequesterBySlackRequest>? slack = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (UserId is { } __value0)
            {
                userId?.Invoke(__value0);
            }
            else if (Email is { } __value1)
            {
                email?.Invoke(__value1);
            }
            else if (Slack is { } __value2)
            {
                slack?.Invoke(__value2);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::ElevenLabs.TicketRequesterByUserIdRequest>? userId = null,
            global::System.Action<global::ElevenLabs.TicketRequesterByEmailRequest>? email = null,
            global::System.Action<global::ElevenLabs.TicketRequesterBySlackRequest>? slack = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (UserId is { } __value0)
            {
                userId?.Invoke(__value0);
            }
            else if (Email is { } __value1)
            {
                email?.Invoke(__value1);
            }
            else if (Slack is { } __value2)
            {
                slack?.Invoke(__value2);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                UserId,
                typeof(global::ElevenLabs.TicketRequesterByUserIdRequest),
                Email,
                typeof(global::ElevenLabs.TicketRequesterByEmailRequest),
                Slack,
                typeof(global::ElevenLabs.TicketRequesterBySlackRequest),
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
        public bool Equals(Requester other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.TicketRequesterByUserIdRequest?>.Default.Equals(UserId, other.UserId) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.TicketRequesterByEmailRequest?>.Default.Equals(Email, other.Email) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.TicketRequesterBySlackRequest?>.Default.Equals(Slack, other.Slack)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(Requester obj1, Requester obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Requester>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(Requester obj1, Requester obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Requester o && Equals(o);
        }
    }
}
