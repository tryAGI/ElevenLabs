#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ListPhoneNumbersV1ConvaiPhoneNumbersGetResponseItem : global::System.IEquatable<ListPhoneNumbersV1ConvaiPhoneNumbersGetResponseItem>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::ElevenLabs.ListPhoneNumbersV1ConvaiPhoneNumbersGetResponseItemDiscriminatorProvider? Provider { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.GetPhoneNumberTwilioResponseModel? Twilio { get; init; }
#else
        public global::ElevenLabs.GetPhoneNumberTwilioResponseModel? Twilio { get; }
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
        public static implicit operator ListPhoneNumbersV1ConvaiPhoneNumbersGetResponseItem(global::ElevenLabs.GetPhoneNumberTwilioResponseModel value) => new ListPhoneNumbersV1ConvaiPhoneNumbersGetResponseItem((global::ElevenLabs.GetPhoneNumberTwilioResponseModel?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.GetPhoneNumberTwilioResponseModel?(ListPhoneNumbersV1ConvaiPhoneNumbersGetResponseItem @this) => @this.Twilio;

        /// <summary>
        /// 
        /// </summary>
        public ListPhoneNumbersV1ConvaiPhoneNumbersGetResponseItem(global::ElevenLabs.GetPhoneNumberTwilioResponseModel? value)
        {
            Twilio = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.GetPhoneNumberSIPTrunkResponseModel? SipTrunk { get; init; }
#else
        public global::ElevenLabs.GetPhoneNumberSIPTrunkResponseModel? SipTrunk { get; }
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
        public static implicit operator ListPhoneNumbersV1ConvaiPhoneNumbersGetResponseItem(global::ElevenLabs.GetPhoneNumberSIPTrunkResponseModel value) => new ListPhoneNumbersV1ConvaiPhoneNumbersGetResponseItem((global::ElevenLabs.GetPhoneNumberSIPTrunkResponseModel?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.GetPhoneNumberSIPTrunkResponseModel?(ListPhoneNumbersV1ConvaiPhoneNumbersGetResponseItem @this) => @this.SipTrunk;

        /// <summary>
        /// 
        /// </summary>
        public ListPhoneNumbersV1ConvaiPhoneNumbersGetResponseItem(global::ElevenLabs.GetPhoneNumberSIPTrunkResponseModel? value)
        {
            SipTrunk = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ListPhoneNumbersV1ConvaiPhoneNumbersGetResponseItem(
            global::ElevenLabs.ListPhoneNumbersV1ConvaiPhoneNumbersGetResponseItemDiscriminatorProvider? provider,
            global::ElevenLabs.GetPhoneNumberTwilioResponseModel? twilio,
            global::ElevenLabs.GetPhoneNumberSIPTrunkResponseModel? sipTrunk
            )
        {
            Provider = provider;

            Twilio = twilio;
            SipTrunk = sipTrunk;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            SipTrunk as object ??
            Twilio as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Twilio?.ToString() ??
            SipTrunk?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsTwilio && !IsSipTrunk || !IsTwilio && IsSipTrunk;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::ElevenLabs.GetPhoneNumberTwilioResponseModel?, TResult>? twilio = null,
            global::System.Func<global::ElevenLabs.GetPhoneNumberSIPTrunkResponseModel?, TResult>? sipTrunk = null,
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
            else if (IsSipTrunk && sipTrunk != null)
            {
                return sipTrunk(SipTrunk!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::ElevenLabs.GetPhoneNumberTwilioResponseModel?>? twilio = null,
            global::System.Action<global::ElevenLabs.GetPhoneNumberSIPTrunkResponseModel?>? sipTrunk = null,
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
            else if (IsSipTrunk)
            {
                sipTrunk?.Invoke(SipTrunk!);
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
                typeof(global::ElevenLabs.GetPhoneNumberTwilioResponseModel),
                SipTrunk,
                typeof(global::ElevenLabs.GetPhoneNumberSIPTrunkResponseModel),
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
        public bool Equals(ListPhoneNumbersV1ConvaiPhoneNumbersGetResponseItem other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.GetPhoneNumberTwilioResponseModel?>.Default.Equals(Twilio, other.Twilio) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.GetPhoneNumberSIPTrunkResponseModel?>.Default.Equals(SipTrunk, other.SipTrunk) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ListPhoneNumbersV1ConvaiPhoneNumbersGetResponseItem obj1, ListPhoneNumbersV1ConvaiPhoneNumbersGetResponseItem obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ListPhoneNumbersV1ConvaiPhoneNumbersGetResponseItem>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ListPhoneNumbersV1ConvaiPhoneNumbersGetResponseItem obj1, ListPhoneNumbersV1ConvaiPhoneNumbersGetResponseItem obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ListPhoneNumbersV1ConvaiPhoneNumbersGetResponseItem o && Equals(o);
        }
    }
}
