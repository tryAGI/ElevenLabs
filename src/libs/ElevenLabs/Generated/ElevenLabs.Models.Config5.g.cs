#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct Config5 : global::System.IEquatable<Config5>
    {
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TwilioTransferInputConfigDiscriminatorType? Type { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.TwilioWarmConferenceTransferConfigInput? TwilioWarmConferenceTransfer { get; init; }
#else
        public global::ElevenLabs.TwilioWarmConferenceTransferConfigInput? TwilioWarmConferenceTransfer { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TwilioWarmConferenceTransfer))]
#endif
        public bool IsTwilioWarmConferenceTransfer => TwilioWarmConferenceTransfer != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickTwilioWarmConferenceTransfer(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.TwilioWarmConferenceTransferConfigInput? value)
        {
            value = TwilioWarmConferenceTransfer;
            return IsTwilioWarmConferenceTransfer;
        }

        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TwilioWarmConferenceTransferConfigInput PickTwilioWarmConferenceTransfer() => TwilioWarmConferenceTransfer is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'TwilioWarmConferenceTransfer' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.TwilioColdBlindTransferConfigInput? TwilioColdBlindTransfer { get; init; }
#else
        public global::ElevenLabs.TwilioColdBlindTransferConfigInput? TwilioColdBlindTransfer { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TwilioColdBlindTransfer))]
#endif
        public bool IsTwilioColdBlindTransfer => TwilioColdBlindTransfer != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickTwilioColdBlindTransfer(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.TwilioColdBlindTransferConfigInput? value)
        {
            value = TwilioColdBlindTransfer;
            return IsTwilioColdBlindTransfer;
        }

        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TwilioColdBlindTransferConfigInput PickTwilioColdBlindTransfer() => TwilioColdBlindTransfer is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'TwilioColdBlindTransfer' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator Config5(global::ElevenLabs.TwilioWarmConferenceTransferConfigInput value) => new Config5((global::ElevenLabs.TwilioWarmConferenceTransferConfigInput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::ElevenLabs.TwilioWarmConferenceTransferConfigInput?(Config5 @this) => @this.TwilioWarmConferenceTransfer;

        /// <summary>
        ///
        /// </summary>
        public Config5(global::ElevenLabs.TwilioWarmConferenceTransferConfigInput? value)
        {
            TwilioWarmConferenceTransfer = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Config5 FromTwilioWarmConferenceTransfer(global::ElevenLabs.TwilioWarmConferenceTransferConfigInput? value) => new Config5(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Config5(global::ElevenLabs.TwilioColdBlindTransferConfigInput value) => new Config5((global::ElevenLabs.TwilioColdBlindTransferConfigInput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::ElevenLabs.TwilioColdBlindTransferConfigInput?(Config5 @this) => @this.TwilioColdBlindTransfer;

        /// <summary>
        ///
        /// </summary>
        public Config5(global::ElevenLabs.TwilioColdBlindTransferConfigInput? value)
        {
            TwilioColdBlindTransfer = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Config5 FromTwilioColdBlindTransfer(global::ElevenLabs.TwilioColdBlindTransferConfigInput? value) => new Config5(value);

        /// <summary>
        ///
        /// </summary>
        public Config5(
            global::ElevenLabs.TwilioTransferInputConfigDiscriminatorType? type,
            global::ElevenLabs.TwilioWarmConferenceTransferConfigInput? twilioWarmConferenceTransfer,
            global::ElevenLabs.TwilioColdBlindTransferConfigInput? twilioColdBlindTransfer
            )
        {
            Type = type;

            TwilioWarmConferenceTransfer = twilioWarmConferenceTransfer;
            TwilioColdBlindTransfer = twilioColdBlindTransfer;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            TwilioColdBlindTransfer as object ??
            TwilioWarmConferenceTransfer as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            TwilioWarmConferenceTransfer?.ToString() ??
            TwilioColdBlindTransfer?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsTwilioWarmConferenceTransfer && !IsTwilioColdBlindTransfer || !IsTwilioWarmConferenceTransfer && IsTwilioColdBlindTransfer;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::ElevenLabs.TwilioWarmConferenceTransferConfigInput, TResult>? twilioWarmConferenceTransfer = null,
            global::System.Func<global::ElevenLabs.TwilioColdBlindTransferConfigInput, TResult>? twilioColdBlindTransfer = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (TwilioWarmConferenceTransfer is { } __value0 && twilioWarmConferenceTransfer != null)
            {
                return twilioWarmConferenceTransfer(__value0);
            }
            else if (TwilioColdBlindTransfer is { } __value1 && twilioColdBlindTransfer != null)
            {
                return twilioColdBlindTransfer(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::ElevenLabs.TwilioWarmConferenceTransferConfigInput>? twilioWarmConferenceTransfer = null,

            global::System.Action<global::ElevenLabs.TwilioColdBlindTransferConfigInput>? twilioColdBlindTransfer = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (TwilioWarmConferenceTransfer is { } __value0)
            {
                twilioWarmConferenceTransfer?.Invoke(__value0);
            }
            else if (TwilioColdBlindTransfer is { } __value1)
            {
                twilioColdBlindTransfer?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::ElevenLabs.TwilioWarmConferenceTransferConfigInput>? twilioWarmConferenceTransfer = null,
            global::System.Action<global::ElevenLabs.TwilioColdBlindTransferConfigInput>? twilioColdBlindTransfer = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (TwilioWarmConferenceTransfer is { } __value0)
            {
                twilioWarmConferenceTransfer?.Invoke(__value0);
            }
            else if (TwilioColdBlindTransfer is { } __value1)
            {
                twilioColdBlindTransfer?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                TwilioWarmConferenceTransfer,
                typeof(global::ElevenLabs.TwilioWarmConferenceTransferConfigInput),
                TwilioColdBlindTransfer,
                typeof(global::ElevenLabs.TwilioColdBlindTransferConfigInput),
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
        public bool Equals(Config5 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.TwilioWarmConferenceTransferConfigInput?>.Default.Equals(TwilioWarmConferenceTransfer, other.TwilioWarmConferenceTransfer) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.TwilioColdBlindTransferConfigInput?>.Default.Equals(TwilioColdBlindTransfer, other.TwilioColdBlindTransfer)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(Config5 obj1, Config5 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Config5>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(Config5 obj1, Config5 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Config5 o && Equals(o);
        }
    }
}
