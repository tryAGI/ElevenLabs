#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct Config4 : global::System.IEquatable<Config4>
    {
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SIPTransferOutputConfigDiscriminatorType? Type { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.SIPColdConferenceTransferConfigOutput? SipColdConferenceTransfer { get; init; }
#else
        public global::ElevenLabs.SIPColdConferenceTransferConfigOutput? SipColdConferenceTransfer { get; }
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
            out global::ElevenLabs.SIPColdConferenceTransferConfigOutput? value)
        {
            value = SipColdConferenceTransfer;
            return IsSipColdConferenceTransfer;
        }

        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SIPColdConferenceTransferConfigOutput PickSipColdConferenceTransfer() => SipColdConferenceTransfer is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'SipColdConferenceTransfer' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.SIPColdReferTransferConfigOutput? SipColdReferTransfer { get; init; }
#else
        public global::ElevenLabs.SIPColdReferTransferConfigOutput? SipColdReferTransfer { get; }
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
            out global::ElevenLabs.SIPColdReferTransferConfigOutput? value)
        {
            value = SipColdReferTransfer;
            return IsSipColdReferTransfer;
        }

        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SIPColdReferTransferConfigOutput PickSipColdReferTransfer() => SipColdReferTransfer is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'SipColdReferTransfer' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator Config4(global::ElevenLabs.SIPColdConferenceTransferConfigOutput value) => new Config4((global::ElevenLabs.SIPColdConferenceTransferConfigOutput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::ElevenLabs.SIPColdConferenceTransferConfigOutput?(Config4 @this) => @this.SipColdConferenceTransfer;

        /// <summary>
        ///
        /// </summary>
        public Config4(global::ElevenLabs.SIPColdConferenceTransferConfigOutput? value)
        {
            SipColdConferenceTransfer = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Config4 FromSipColdConferenceTransfer(global::ElevenLabs.SIPColdConferenceTransferConfigOutput? value) => new Config4(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Config4(global::ElevenLabs.SIPColdReferTransferConfigOutput value) => new Config4((global::ElevenLabs.SIPColdReferTransferConfigOutput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::ElevenLabs.SIPColdReferTransferConfigOutput?(Config4 @this) => @this.SipColdReferTransfer;

        /// <summary>
        ///
        /// </summary>
        public Config4(global::ElevenLabs.SIPColdReferTransferConfigOutput? value)
        {
            SipColdReferTransfer = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Config4 FromSipColdReferTransfer(global::ElevenLabs.SIPColdReferTransferConfigOutput? value) => new Config4(value);

        /// <summary>
        ///
        /// </summary>
        public Config4(
            global::ElevenLabs.SIPTransferOutputConfigDiscriminatorType? type,
            global::ElevenLabs.SIPColdConferenceTransferConfigOutput? sipColdConferenceTransfer,
            global::ElevenLabs.SIPColdReferTransferConfigOutput? sipColdReferTransfer
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
            global::System.Func<global::ElevenLabs.SIPColdConferenceTransferConfigOutput, TResult>? sipColdConferenceTransfer = null,
            global::System.Func<global::ElevenLabs.SIPColdReferTransferConfigOutput, TResult>? sipColdReferTransfer = null,
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
            global::System.Action<global::ElevenLabs.SIPColdConferenceTransferConfigOutput>? sipColdConferenceTransfer = null,

            global::System.Action<global::ElevenLabs.SIPColdReferTransferConfigOutput>? sipColdReferTransfer = null,
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
            global::System.Action<global::ElevenLabs.SIPColdConferenceTransferConfigOutput>? sipColdConferenceTransfer = null,
            global::System.Action<global::ElevenLabs.SIPColdReferTransferConfigOutput>? sipColdReferTransfer = null,
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
                typeof(global::ElevenLabs.SIPColdConferenceTransferConfigOutput),
                SipColdReferTransfer,
                typeof(global::ElevenLabs.SIPColdReferTransferConfigOutput),
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
        public bool Equals(Config4 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.SIPColdConferenceTransferConfigOutput?>.Default.Equals(SipColdConferenceTransfer, other.SipColdConferenceTransfer) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.SIPColdReferTransferConfigOutput?>.Default.Equals(SipColdReferTransfer, other.SipColdReferTransfer)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(Config4 obj1, Config4 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Config4>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(Config4 obj1, Config4 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Config4 o && Equals(o);
        }
    }
}
