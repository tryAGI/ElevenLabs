#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct ProviderConfigsItem4 : global::System.IEquatable<ProviderConfigsItem4>
    {
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowPhoneNumberNodeModelOutputProviderConfigDiscriminatorType? Type { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.TwilioTransferOutput? Twilio { get; init; }
#else
        public global::ElevenLabs.TwilioTransferOutput? Twilio { get; }
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
            out global::ElevenLabs.TwilioTransferOutput? value)
        {
            value = Twilio;
            return IsTwilio;
        }

        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TwilioTransferOutput PickTwilio() => Twilio is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Twilio' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.SIPTransferOutput? SipTrunk { get; init; }
#else
        public global::ElevenLabs.SIPTransferOutput? SipTrunk { get; }
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
            out global::ElevenLabs.SIPTransferOutput? value)
        {
            value = SipTrunk;
            return IsSipTrunk;
        }

        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SIPTransferOutput PickSipTrunk() => SipTrunk is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'SipTrunk' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.ExotelTransferOutput? Exotel { get; init; }
#else
        public global::ElevenLabs.ExotelTransferOutput? Exotel { get; }
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
            out global::ElevenLabs.ExotelTransferOutput? value)
        {
            value = Exotel;
            return IsExotel;
        }

        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ExotelTransferOutput PickExotel() => Exotel is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Exotel' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator ProviderConfigsItem4(global::ElevenLabs.TwilioTransferOutput value) => new ProviderConfigsItem4((global::ElevenLabs.TwilioTransferOutput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::ElevenLabs.TwilioTransferOutput?(ProviderConfigsItem4 @this) => @this.Twilio;

        /// <summary>
        ///
        /// </summary>
        public ProviderConfigsItem4(global::ElevenLabs.TwilioTransferOutput? value)
        {
            Twilio = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ProviderConfigsItem4 FromTwilio(global::ElevenLabs.TwilioTransferOutput? value) => new ProviderConfigsItem4(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ProviderConfigsItem4(global::ElevenLabs.SIPTransferOutput value) => new ProviderConfigsItem4((global::ElevenLabs.SIPTransferOutput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::ElevenLabs.SIPTransferOutput?(ProviderConfigsItem4 @this) => @this.SipTrunk;

        /// <summary>
        ///
        /// </summary>
        public ProviderConfigsItem4(global::ElevenLabs.SIPTransferOutput? value)
        {
            SipTrunk = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ProviderConfigsItem4 FromSipTrunk(global::ElevenLabs.SIPTransferOutput? value) => new ProviderConfigsItem4(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ProviderConfigsItem4(global::ElevenLabs.ExotelTransferOutput value) => new ProviderConfigsItem4((global::ElevenLabs.ExotelTransferOutput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::ElevenLabs.ExotelTransferOutput?(ProviderConfigsItem4 @this) => @this.Exotel;

        /// <summary>
        ///
        /// </summary>
        public ProviderConfigsItem4(global::ElevenLabs.ExotelTransferOutput? value)
        {
            Exotel = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ProviderConfigsItem4 FromExotel(global::ElevenLabs.ExotelTransferOutput? value) => new ProviderConfigsItem4(value);

        /// <summary>
        ///
        /// </summary>
        public ProviderConfigsItem4(
            global::ElevenLabs.WorkflowPhoneNumberNodeModelOutputProviderConfigDiscriminatorType? type,
            global::ElevenLabs.TwilioTransferOutput? twilio,
            global::ElevenLabs.SIPTransferOutput? sipTrunk,
            global::ElevenLabs.ExotelTransferOutput? exotel
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
            global::System.Func<global::ElevenLabs.TwilioTransferOutput, TResult>? twilio = null,
            global::System.Func<global::ElevenLabs.SIPTransferOutput, TResult>? sipTrunk = null,
            global::System.Func<global::ElevenLabs.ExotelTransferOutput, TResult>? exotel = null,
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
            global::System.Action<global::ElevenLabs.TwilioTransferOutput>? twilio = null,

            global::System.Action<global::ElevenLabs.SIPTransferOutput>? sipTrunk = null,

            global::System.Action<global::ElevenLabs.ExotelTransferOutput>? exotel = null,
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
            global::System.Action<global::ElevenLabs.TwilioTransferOutput>? twilio = null,
            global::System.Action<global::ElevenLabs.SIPTransferOutput>? sipTrunk = null,
            global::System.Action<global::ElevenLabs.ExotelTransferOutput>? exotel = null,
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
                typeof(global::ElevenLabs.TwilioTransferOutput),
                SipTrunk,
                typeof(global::ElevenLabs.SIPTransferOutput),
                Exotel,
                typeof(global::ElevenLabs.ExotelTransferOutput),
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
        public bool Equals(ProviderConfigsItem4 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.TwilioTransferOutput?>.Default.Equals(Twilio, other.Twilio) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.SIPTransferOutput?>.Default.Equals(SipTrunk, other.SipTrunk) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.ExotelTransferOutput?>.Default.Equals(Exotel, other.Exotel)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(ProviderConfigsItem4 obj1, ProviderConfigsItem4 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ProviderConfigsItem4>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ProviderConfigsItem4 obj1, ProviderConfigsItem4 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ProviderConfigsItem4 o && Equals(o);
        }
    }
}
