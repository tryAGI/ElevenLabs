#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct PhoneCallVariant1 : global::System.IEquatable<PhoneCallVariant1>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::ElevenLabs.ConversationHistoryMetadataCommonModelPhoneCallVariant1DiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.ConversationHistoryTwilioPhoneCallModel? Twilio { get; init; }
#else
        public global::ElevenLabs.ConversationHistoryTwilioPhoneCallModel? Twilio { get; }
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
            out global::ElevenLabs.ConversationHistoryTwilioPhoneCallModel? value)
        {
            value = Twilio;
            return IsTwilio;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::ElevenLabs.ConversationHistoryTwilioPhoneCallModel PickTwilio() => IsTwilio
            ? Twilio!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Twilio' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.ConversationHistoryExotelPhoneCallModel? Exotel { get; init; }
#else
        public global::ElevenLabs.ConversationHistoryExotelPhoneCallModel? Exotel { get; }
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
            out global::ElevenLabs.ConversationHistoryExotelPhoneCallModel? value)
        {
            value = Exotel;
            return IsExotel;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::ElevenLabs.ConversationHistoryExotelPhoneCallModel PickExotel() => IsExotel
            ? Exotel!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Exotel' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.ConversationHistorySIPTrunkingPhoneCallModel? SipTrunking { get; init; }
#else
        public global::ElevenLabs.ConversationHistorySIPTrunkingPhoneCallModel? SipTrunking { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SipTrunking))]
#endif
        public bool IsSipTrunking => SipTrunking != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickSipTrunking(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.ConversationHistorySIPTrunkingPhoneCallModel? value)
        {
            value = SipTrunking;
            return IsSipTrunking;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::ElevenLabs.ConversationHistorySIPTrunkingPhoneCallModel PickSipTrunking() => IsSipTrunking
            ? SipTrunking!
            : throw new global::System.InvalidOperationException($"Expected union variant 'SipTrunking' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PhoneCallVariant1(global::ElevenLabs.ConversationHistoryTwilioPhoneCallModel value) => new PhoneCallVariant1((global::ElevenLabs.ConversationHistoryTwilioPhoneCallModel?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.ConversationHistoryTwilioPhoneCallModel?(PhoneCallVariant1 @this) => @this.Twilio;

        /// <summary>
        /// 
        /// </summary>
        public PhoneCallVariant1(global::ElevenLabs.ConversationHistoryTwilioPhoneCallModel? value)
        {
            Twilio = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static PhoneCallVariant1 FromTwilio(global::ElevenLabs.ConversationHistoryTwilioPhoneCallModel? value) => new PhoneCallVariant1(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PhoneCallVariant1(global::ElevenLabs.ConversationHistoryExotelPhoneCallModel value) => new PhoneCallVariant1((global::ElevenLabs.ConversationHistoryExotelPhoneCallModel?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.ConversationHistoryExotelPhoneCallModel?(PhoneCallVariant1 @this) => @this.Exotel;

        /// <summary>
        /// 
        /// </summary>
        public PhoneCallVariant1(global::ElevenLabs.ConversationHistoryExotelPhoneCallModel? value)
        {
            Exotel = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static PhoneCallVariant1 FromExotel(global::ElevenLabs.ConversationHistoryExotelPhoneCallModel? value) => new PhoneCallVariant1(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PhoneCallVariant1(global::ElevenLabs.ConversationHistorySIPTrunkingPhoneCallModel value) => new PhoneCallVariant1((global::ElevenLabs.ConversationHistorySIPTrunkingPhoneCallModel?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.ConversationHistorySIPTrunkingPhoneCallModel?(PhoneCallVariant1 @this) => @this.SipTrunking;

        /// <summary>
        /// 
        /// </summary>
        public PhoneCallVariant1(global::ElevenLabs.ConversationHistorySIPTrunkingPhoneCallModel? value)
        {
            SipTrunking = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static PhoneCallVariant1 FromSipTrunking(global::ElevenLabs.ConversationHistorySIPTrunkingPhoneCallModel? value) => new PhoneCallVariant1(value);

        /// <summary>
        /// 
        /// </summary>
        public PhoneCallVariant1(
            global::ElevenLabs.ConversationHistoryMetadataCommonModelPhoneCallVariant1DiscriminatorType? type,
            global::ElevenLabs.ConversationHistoryTwilioPhoneCallModel? twilio,
            global::ElevenLabs.ConversationHistoryExotelPhoneCallModel? exotel,
            global::ElevenLabs.ConversationHistorySIPTrunkingPhoneCallModel? sipTrunking
            )
        {
            Type = type;

            Twilio = twilio;
            Exotel = exotel;
            SipTrunking = sipTrunking;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            SipTrunking as object ??
            Exotel as object ??
            Twilio as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Twilio?.ToString() ??
            Exotel?.ToString() ??
            SipTrunking?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsTwilio && !IsExotel && !IsSipTrunking || !IsTwilio && IsExotel && !IsSipTrunking || !IsTwilio && !IsExotel && IsSipTrunking;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::ElevenLabs.ConversationHistoryTwilioPhoneCallModel, TResult>? twilio = null,
            global::System.Func<global::ElevenLabs.ConversationHistoryExotelPhoneCallModel, TResult>? exotel = null,
            global::System.Func<global::ElevenLabs.ConversationHistorySIPTrunkingPhoneCallModel, TResult>? sipTrunking = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTwilio && twilio != null)
            {
                return twilio(Twilio!);
            }
            else if (IsExotel && exotel != null)
            {
                return exotel(Exotel!);
            }
            else if (IsSipTrunking && sipTrunking != null)
            {
                return sipTrunking(SipTrunking!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::ElevenLabs.ConversationHistoryTwilioPhoneCallModel>? twilio = null,

            global::System.Action<global::ElevenLabs.ConversationHistoryExotelPhoneCallModel>? exotel = null,

            global::System.Action<global::ElevenLabs.ConversationHistorySIPTrunkingPhoneCallModel>? sipTrunking = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTwilio)
            {
                twilio?.Invoke(Twilio!);
            }
            else if (IsExotel)
            {
                exotel?.Invoke(Exotel!);
            }
            else if (IsSipTrunking)
            {
                sipTrunking?.Invoke(SipTrunking!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::ElevenLabs.ConversationHistoryTwilioPhoneCallModel>? twilio = null,
            global::System.Action<global::ElevenLabs.ConversationHistoryExotelPhoneCallModel>? exotel = null,
            global::System.Action<global::ElevenLabs.ConversationHistorySIPTrunkingPhoneCallModel>? sipTrunking = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTwilio)
            {
                twilio?.Invoke(Twilio!);
            }
            else if (IsExotel)
            {
                exotel?.Invoke(Exotel!);
            }
            else if (IsSipTrunking)
            {
                sipTrunking?.Invoke(SipTrunking!);
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
                typeof(global::ElevenLabs.ConversationHistoryTwilioPhoneCallModel),
                Exotel,
                typeof(global::ElevenLabs.ConversationHistoryExotelPhoneCallModel),
                SipTrunking,
                typeof(global::ElevenLabs.ConversationHistorySIPTrunkingPhoneCallModel),
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
        public bool Equals(PhoneCallVariant1 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.ConversationHistoryTwilioPhoneCallModel?>.Default.Equals(Twilio, other.Twilio) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.ConversationHistoryExotelPhoneCallModel?>.Default.Equals(Exotel, other.Exotel) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.ConversationHistorySIPTrunkingPhoneCallModel?>.Default.Equals(SipTrunking, other.SipTrunking) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(PhoneCallVariant1 obj1, PhoneCallVariant1 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<PhoneCallVariant1>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(PhoneCallVariant1 obj1, PhoneCallVariant1 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is PhoneCallVariant1 o && Equals(o);
        }
    }
}
