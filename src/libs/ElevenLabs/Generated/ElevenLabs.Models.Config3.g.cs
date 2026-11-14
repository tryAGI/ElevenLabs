#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct Config3 : global::System.IEquatable<Config3>
    {
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SIPTransferInputConfigDiscriminatorType? Type { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.SIPColdConferenceTransferConfigInput? SipColdConferenceTransfer { get; init; }
#else
        public global::ElevenLabs.SIPColdConferenceTransferConfigInput? SipColdConferenceTransfer { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SipColdConferenceTransfer))]
#endif
        public bool IsSipColdConferenceTransfer => SipColdConferenceTransfer != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSipColdConferenceTransfer(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.SIPColdConferenceTransferConfigInput? value)
        {
            value = SipColdConferenceTransfer;
            return IsSipColdConferenceTransfer;
        }

        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SIPColdConferenceTransferConfigInput PickSipColdConferenceTransfer() => SipColdConferenceTransfer is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'SipColdConferenceTransfer' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.SIPColdReferTransferConfigInput? SipColdReferTransfer { get; init; }
#else
        public global::ElevenLabs.SIPColdReferTransferConfigInput? SipColdReferTransfer { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SipColdReferTransfer))]
#endif
        public bool IsSipColdReferTransfer => SipColdReferTransfer != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSipColdReferTransfer(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.SIPColdReferTransferConfigInput? value)
        {
            value = SipColdReferTransfer;
            return IsSipColdReferTransfer;
        }

        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SIPColdReferTransferConfigInput PickSipColdReferTransfer() => SipColdReferTransfer is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'SipColdReferTransfer' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator Config3(global::ElevenLabs.SIPColdConferenceTransferConfigInput value) => new Config3((global::ElevenLabs.SIPColdConferenceTransferConfigInput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::ElevenLabs.SIPColdConferenceTransferConfigInput?(Config3 @this) => @this.SipColdConferenceTransfer;

        /// <summary>
        ///
        /// </summary>
        public Config3(global::ElevenLabs.SIPColdConferenceTransferConfigInput? value)
        {
            SipColdConferenceTransfer = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Config3 FromSipColdConferenceTransfer(global::ElevenLabs.SIPColdConferenceTransferConfigInput? value) => new Config3(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Config3(global::ElevenLabs.SIPColdReferTransferConfigInput value) => new Config3((global::ElevenLabs.SIPColdReferTransferConfigInput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::ElevenLabs.SIPColdReferTransferConfigInput?(Config3 @this) => @this.SipColdReferTransfer;

        /// <summary>
        ///
        /// </summary>
        public Config3(global::ElevenLabs.SIPColdReferTransferConfigInput? value)
        {
            SipColdReferTransfer = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Config3 FromSipColdReferTransfer(global::ElevenLabs.SIPColdReferTransferConfigInput? value) => new Config3(value);

        /// <summary>
        ///
        /// </summary>
        public Config3(
            global::ElevenLabs.SIPTransferInputConfigDiscriminatorType? type,
            global::ElevenLabs.SIPColdConferenceTransferConfigInput? sipColdConferenceTransfer,
            global::ElevenLabs.SIPColdReferTransferConfigInput? sipColdReferTransfer
            )
        {
            Type = type;

            SipColdConferenceTransfer = sipColdConferenceTransfer;
            SipColdReferTransfer = sipColdReferTransfer;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            SipColdReferTransfer as object ??
            SipColdConferenceTransfer as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            SipColdConferenceTransfer?.ToString() ??
            SipColdReferTransfer?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsSipColdConferenceTransfer && !IsSipColdReferTransfer || !IsSipColdConferenceTransfer && IsSipColdReferTransfer;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::ElevenLabs.SIPColdConferenceTransferConfigInput, TResult>? sipColdConferenceTransfer = null,
            global::System.Func<global::ElevenLabs.SIPColdReferTransferConfigInput, TResult>? sipColdReferTransfer = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (SipColdConferenceTransfer is { } __value0 && sipColdConferenceTransfer != null)
            {
                return sipColdConferenceTransfer(__value0);
            }
            else if (SipColdReferTransfer is { } __value1 && sipColdReferTransfer != null)
            {
                return sipColdReferTransfer(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::ElevenLabs.SIPColdConferenceTransferConfigInput>? sipColdConferenceTransfer = null,

            global::System.Action<global::ElevenLabs.SIPColdReferTransferConfigInput>? sipColdReferTransfer = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (SipColdConferenceTransfer is { } __value0)
            {
                sipColdConferenceTransfer?.Invoke(__value0);
            }
            else if (SipColdReferTransfer is { } __value1)
            {
                sipColdReferTransfer?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::ElevenLabs.SIPColdConferenceTransferConfigInput>? sipColdConferenceTransfer = null,
            global::System.Action<global::ElevenLabs.SIPColdReferTransferConfigInput>? sipColdReferTransfer = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (SipColdConferenceTransfer is { } __value0)
            {
                sipColdConferenceTransfer?.Invoke(__value0);
            }
            else if (SipColdReferTransfer is { } __value1)
            {
                sipColdReferTransfer?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                SipColdConferenceTransfer,
                typeof(global::ElevenLabs.SIPColdConferenceTransferConfigInput),
                SipColdReferTransfer,
                typeof(global::ElevenLabs.SIPColdReferTransferConfigInput),
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
        public bool Equals(Config3 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.SIPColdConferenceTransferConfigInput?>.Default.Equals(SipColdConferenceTransfer, other.SipColdConferenceTransfer) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.SIPColdReferTransferConfigInput?>.Default.Equals(SipColdReferTransfer, other.SipColdReferTransfer)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(Config3 obj1, Config3 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Config3>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(Config3 obj1, Config3 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Config3 o && Equals(o);
        }
    }
}
