#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct ProviderConfigsItem3 : global::System.IEquatable<ProviderConfigsItem3>
    {
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowPhoneNumberNodeModelInputProviderConfigDiscriminatorType? Type { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.TwilioTransferInput? Twilio { get; init; }
#else
        public global::ElevenLabs.TwilioTransferInput? Twilio { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Twilio))]
#endif
        public bool IsTwilio => Twilio != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickTwilio(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.TwilioTransferInput? value)
        {
            value = Twilio;
            return IsTwilio;
        }

        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TwilioTransferInput PickTwilio() => Twilio is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Twilio' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.SIPTransferInput? SipTrunk { get; init; }
#else
        public global::ElevenLabs.SIPTransferInput? SipTrunk { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SipTrunk))]
#endif
        public bool IsSipTrunk => SipTrunk != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSipTrunk(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.SIPTransferInput? value)
        {
            value = SipTrunk;
            return IsSipTrunk;
        }

        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SIPTransferInput PickSipTrunk() => SipTrunk is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'SipTrunk' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.ExotelTransferInput? Exotel { get; init; }
#else
        public global::ElevenLabs.ExotelTransferInput? Exotel { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Exotel))]
#endif
        public bool IsExotel => Exotel != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickExotel(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.ExotelTransferInput? value)
        {
            value = Exotel;
            return IsExotel;
        }

        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ExotelTransferInput PickExotel() => Exotel is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Exotel' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator ProviderConfigsItem3(global::ElevenLabs.TwilioTransferInput value) => new ProviderConfigsItem3((global::ElevenLabs.TwilioTransferInput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::ElevenLabs.TwilioTransferInput?(ProviderConfigsItem3 @this) => @this.Twilio;

        /// <summary>
        ///
        /// </summary>
        public ProviderConfigsItem3(global::ElevenLabs.TwilioTransferInput? value)
        {
            Twilio = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ProviderConfigsItem3 FromTwilio(global::ElevenLabs.TwilioTransferInput? value) => new ProviderConfigsItem3(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ProviderConfigsItem3(global::ElevenLabs.SIPTransferInput value) => new ProviderConfigsItem3((global::ElevenLabs.SIPTransferInput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::ElevenLabs.SIPTransferInput?(ProviderConfigsItem3 @this) => @this.SipTrunk;

        /// <summary>
        ///
        /// </summary>
        public ProviderConfigsItem3(global::ElevenLabs.SIPTransferInput? value)
        {
            SipTrunk = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ProviderConfigsItem3 FromSipTrunk(global::ElevenLabs.SIPTransferInput? value) => new ProviderConfigsItem3(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ProviderConfigsItem3(global::ElevenLabs.ExotelTransferInput value) => new ProviderConfigsItem3((global::ElevenLabs.ExotelTransferInput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::ElevenLabs.ExotelTransferInput?(ProviderConfigsItem3 @this) => @this.Exotel;

        /// <summary>
        ///
        /// </summary>
        public ProviderConfigsItem3(global::ElevenLabs.ExotelTransferInput? value)
        {
            Exotel = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ProviderConfigsItem3 FromExotel(global::ElevenLabs.ExotelTransferInput? value) => new ProviderConfigsItem3(value);

        /// <summary>
        ///
        /// </summary>
        public ProviderConfigsItem3(
            global::ElevenLabs.WorkflowPhoneNumberNodeModelInputProviderConfigDiscriminatorType? type,
            global::ElevenLabs.TwilioTransferInput? twilio,
            global::ElevenLabs.SIPTransferInput? sipTrunk,
            global::ElevenLabs.ExotelTransferInput? exotel
            )
        {
            Type = type;

            Twilio = twilio;
            SipTrunk = sipTrunk;
            Exotel = exotel;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Exotel as object ??
            SipTrunk as object ??
            Twilio as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Twilio?.ToString() ??
            SipTrunk?.ToString() ??
            Exotel?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsTwilio && !IsSipTrunk && !IsExotel || !IsTwilio && IsSipTrunk && !IsExotel || !IsTwilio && !IsSipTrunk && IsExotel;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::ElevenLabs.TwilioTransferInput, TResult>? twilio = null,
            global::System.Func<global::ElevenLabs.SIPTransferInput, TResult>? sipTrunk = null,
            global::System.Func<global::ElevenLabs.ExotelTransferInput, TResult>? exotel = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Twilio is { } __value0 && twilio != null)
            {
                return twilio(__value0);
            }
            else if (SipTrunk is { } __value1 && sipTrunk != null)
            {
                return sipTrunk(__value1);
            }
            else if (Exotel is { } __value2 && exotel != null)
            {
                return exotel(__value2);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::ElevenLabs.TwilioTransferInput>? twilio = null,

            global::System.Action<global::ElevenLabs.SIPTransferInput>? sipTrunk = null,

            global::System.Action<global::ElevenLabs.ExotelTransferInput>? exotel = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Twilio is { } __value0)
            {
                twilio?.Invoke(__value0);
            }
            else if (SipTrunk is { } __value1)
            {
                sipTrunk?.Invoke(__value1);
            }
            else if (Exotel is { } __value2)
            {
                exotel?.Invoke(__value2);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::ElevenLabs.TwilioTransferInput>? twilio = null,
            global::System.Action<global::ElevenLabs.SIPTransferInput>? sipTrunk = null,
            global::System.Action<global::ElevenLabs.ExotelTransferInput>? exotel = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Twilio is { } __value0)
            {
                twilio?.Invoke(__value0);
            }
            else if (SipTrunk is { } __value1)
            {
                sipTrunk?.Invoke(__value1);
            }
            else if (Exotel is { } __value2)
            {
                exotel?.Invoke(__value2);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Twilio,
                typeof(global::ElevenLabs.TwilioTransferInput),
                SipTrunk,
                typeof(global::ElevenLabs.SIPTransferInput),
                Exotel,
                typeof(global::ElevenLabs.ExotelTransferInput),
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
        public bool Equals(ProviderConfigsItem3 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.TwilioTransferInput?>.Default.Equals(Twilio, other.Twilio) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.SIPTransferInput?>.Default.Equals(SipTrunk, other.SipTrunk) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.ExotelTransferInput?>.Default.Equals(Exotel, other.Exotel)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(ProviderConfigsItem3 obj1, ProviderConfigsItem3 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ProviderConfigsItem3>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ProviderConfigsItem3 obj1, ProviderConfigsItem3 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ProviderConfigsItem3 o && Equals(o);
        }
    }
}
