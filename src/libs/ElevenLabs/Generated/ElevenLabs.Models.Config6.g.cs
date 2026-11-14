#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct Config6 : global::System.IEquatable<Config6>
    {
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TwilioTransferOutputConfigDiscriminatorType? Type { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.TwilioWarmConferenceTransferConfigOutput? TwilioWarmConferenceTransfer { get; init; }
#else
        public global::ElevenLabs.TwilioWarmConferenceTransferConfigOutput? TwilioWarmConferenceTransfer { get; }
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
            out global::ElevenLabs.TwilioWarmConferenceTransferConfigOutput? value)
        {
            value = TwilioWarmConferenceTransfer;
            return IsTwilioWarmConferenceTransfer;
        }

        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TwilioWarmConferenceTransferConfigOutput PickTwilioWarmConferenceTransfer() => TwilioWarmConferenceTransfer is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'TwilioWarmConferenceTransfer' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.TwilioColdBlindTransferConfigOutput? TwilioColdBlindTransfer { get; init; }
#else
        public global::ElevenLabs.TwilioColdBlindTransferConfigOutput? TwilioColdBlindTransfer { get; }
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
            out global::ElevenLabs.TwilioColdBlindTransferConfigOutput? value)
        {
            value = TwilioColdBlindTransfer;
            return IsTwilioColdBlindTransfer;
        }

        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TwilioColdBlindTransferConfigOutput PickTwilioColdBlindTransfer() => TwilioColdBlindTransfer is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'TwilioColdBlindTransfer' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator Config6(global::ElevenLabs.TwilioWarmConferenceTransferConfigOutput value) => new Config6((global::ElevenLabs.TwilioWarmConferenceTransferConfigOutput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::ElevenLabs.TwilioWarmConferenceTransferConfigOutput?(Config6 @this) => @this.TwilioWarmConferenceTransfer;

        /// <summary>
        ///
        /// </summary>
        public Config6(global::ElevenLabs.TwilioWarmConferenceTransferConfigOutput? value)
        {
            TwilioWarmConferenceTransfer = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Config6 FromTwilioWarmConferenceTransfer(global::ElevenLabs.TwilioWarmConferenceTransferConfigOutput? value) => new Config6(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Config6(global::ElevenLabs.TwilioColdBlindTransferConfigOutput value) => new Config6((global::ElevenLabs.TwilioColdBlindTransferConfigOutput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::ElevenLabs.TwilioColdBlindTransferConfigOutput?(Config6 @this) => @this.TwilioColdBlindTransfer;

        /// <summary>
        ///
        /// </summary>
        public Config6(global::ElevenLabs.TwilioColdBlindTransferConfigOutput? value)
        {
            TwilioColdBlindTransfer = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Config6 FromTwilioColdBlindTransfer(global::ElevenLabs.TwilioColdBlindTransferConfigOutput? value) => new Config6(value);

        /// <summary>
        ///
        /// </summary>
        public Config6(
            global::ElevenLabs.TwilioTransferOutputConfigDiscriminatorType? type,
            global::ElevenLabs.TwilioWarmConferenceTransferConfigOutput? twilioWarmConferenceTransfer,
            global::ElevenLabs.TwilioColdBlindTransferConfigOutput? twilioColdBlindTransfer
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
            global::System.Func<global::ElevenLabs.TwilioWarmConferenceTransferConfigOutput, TResult>? twilioWarmConferenceTransfer = null,
            global::System.Func<global::ElevenLabs.TwilioColdBlindTransferConfigOutput, TResult>? twilioColdBlindTransfer = null,
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
            global::System.Action<global::ElevenLabs.TwilioWarmConferenceTransferConfigOutput>? twilioWarmConferenceTransfer = null,

            global::System.Action<global::ElevenLabs.TwilioColdBlindTransferConfigOutput>? twilioColdBlindTransfer = null,
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
            global::System.Action<global::ElevenLabs.TwilioWarmConferenceTransferConfigOutput>? twilioWarmConferenceTransfer = null,
            global::System.Action<global::ElevenLabs.TwilioColdBlindTransferConfigOutput>? twilioColdBlindTransfer = null,
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
                typeof(global::ElevenLabs.TwilioWarmConferenceTransferConfigOutput),
                TwilioColdBlindTransfer,
                typeof(global::ElevenLabs.TwilioColdBlindTransferConfigOutput),
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
        public bool Equals(Config6 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.TwilioWarmConferenceTransferConfigOutput?>.Default.Equals(TwilioWarmConferenceTransfer, other.TwilioWarmConferenceTransfer) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.TwilioColdBlindTransferConfigOutput?>.Default.Equals(TwilioColdBlindTransfer, other.TwilioColdBlindTransfer)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(Config6 obj1, Config6 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Config6>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(Config6 obj1, Config6 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Config6 o && Equals(o);
        }
    }
}
