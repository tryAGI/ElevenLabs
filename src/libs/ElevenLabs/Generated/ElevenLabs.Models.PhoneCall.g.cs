#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct PhoneCall : global::System.IEquatable<PhoneCall>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::ElevenLabs.ConversationHistoryMetadataCommonModelPhoneCallDiscriminatorType? Type { get; }

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
        public static implicit operator PhoneCall(global::ElevenLabs.ConversationHistoryTwilioPhoneCallModel value) => new PhoneCall((global::ElevenLabs.ConversationHistoryTwilioPhoneCallModel?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.ConversationHistoryTwilioPhoneCallModel?(PhoneCall @this) => @this.Twilio;

        /// <summary>
        /// 
        /// </summary>
        public PhoneCall(global::ElevenLabs.ConversationHistoryTwilioPhoneCallModel? value)
        {
            Twilio = value;
        }

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
        public static implicit operator PhoneCall(global::ElevenLabs.ConversationHistorySIPTrunkingPhoneCallModel value) => new PhoneCall((global::ElevenLabs.ConversationHistorySIPTrunkingPhoneCallModel?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.ConversationHistorySIPTrunkingPhoneCallModel?(PhoneCall @this) => @this.SipTrunking;

        /// <summary>
        /// 
        /// </summary>
        public PhoneCall(global::ElevenLabs.ConversationHistorySIPTrunkingPhoneCallModel? value)
        {
            SipTrunking = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public PhoneCall(
            global::ElevenLabs.ConversationHistoryMetadataCommonModelPhoneCallDiscriminatorType? type,
            global::ElevenLabs.ConversationHistoryTwilioPhoneCallModel? twilio,
            global::ElevenLabs.ConversationHistorySIPTrunkingPhoneCallModel? sipTrunking
            )
        {
            Type = type;

            Twilio = twilio;
            SipTrunking = sipTrunking;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            SipTrunking as object ??
            Twilio as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Twilio?.ToString() ??
            SipTrunking?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsTwilio && !IsSipTrunking || !IsTwilio && IsSipTrunking;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::ElevenLabs.ConversationHistoryTwilioPhoneCallModel?, TResult>? twilio = null,
            global::System.Func<global::ElevenLabs.ConversationHistorySIPTrunkingPhoneCallModel?, TResult>? sipTrunking = null,
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
            global::System.Action<global::ElevenLabs.ConversationHistoryTwilioPhoneCallModel?>? twilio = null,
            global::System.Action<global::ElevenLabs.ConversationHistorySIPTrunkingPhoneCallModel?>? sipTrunking = null,
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
        public bool Equals(PhoneCall other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.ConversationHistoryTwilioPhoneCallModel?>.Default.Equals(Twilio, other.Twilio) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.ConversationHistorySIPTrunkingPhoneCallModel?>.Default.Equals(SipTrunking, other.SipTrunking) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(PhoneCall obj1, PhoneCall obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<PhoneCall>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(PhoneCall obj1, PhoneCall obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is PhoneCall o && Equals(o);
        }
    }
}
