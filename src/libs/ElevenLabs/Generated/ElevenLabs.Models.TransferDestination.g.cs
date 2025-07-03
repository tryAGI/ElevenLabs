#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct TransferDestination : global::System.IEquatable<TransferDestination>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::ElevenLabs.PhoneNumberTransferTransferDestinationDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.PhoneNumberTransferDestination? Phone { get; init; }
#else
        public global::ElevenLabs.PhoneNumberTransferDestination? Phone { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Phone))]
#endif
        public bool IsPhone => Phone != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TransferDestination(global::ElevenLabs.PhoneNumberTransferDestination value) => new TransferDestination((global::ElevenLabs.PhoneNumberTransferDestination?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.PhoneNumberTransferDestination?(TransferDestination @this) => @this.Phone;

        /// <summary>
        /// 
        /// </summary>
        public TransferDestination(global::ElevenLabs.PhoneNumberTransferDestination? value)
        {
            Phone = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.SIPUriTransferDestination? SipUri { get; init; }
#else
        public global::ElevenLabs.SIPUriTransferDestination? SipUri { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SipUri))]
#endif
        public bool IsSipUri => SipUri != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TransferDestination(global::ElevenLabs.SIPUriTransferDestination value) => new TransferDestination((global::ElevenLabs.SIPUriTransferDestination?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.SIPUriTransferDestination?(TransferDestination @this) => @this.SipUri;

        /// <summary>
        /// 
        /// </summary>
        public TransferDestination(global::ElevenLabs.SIPUriTransferDestination? value)
        {
            SipUri = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public TransferDestination(
            global::ElevenLabs.PhoneNumberTransferTransferDestinationDiscriminatorType? type,
            global::ElevenLabs.PhoneNumberTransferDestination? phone,
            global::ElevenLabs.SIPUriTransferDestination? sipUri
            )
        {
            Type = type;

            Phone = phone;
            SipUri = sipUri;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            SipUri as object ??
            Phone as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Phone?.ToString() ??
            SipUri?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsPhone && !IsSipUri || !IsPhone && IsSipUri;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::ElevenLabs.PhoneNumberTransferDestination?, TResult>? phone = null,
            global::System.Func<global::ElevenLabs.SIPUriTransferDestination?, TResult>? sipUri = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPhone && phone != null)
            {
                return phone(Phone!);
            }
            else if (IsSipUri && sipUri != null)
            {
                return sipUri(SipUri!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::ElevenLabs.PhoneNumberTransferDestination?>? phone = null,
            global::System.Action<global::ElevenLabs.SIPUriTransferDestination?>? sipUri = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPhone)
            {
                phone?.Invoke(Phone!);
            }
            else if (IsSipUri)
            {
                sipUri?.Invoke(SipUri!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Phone,
                typeof(global::ElevenLabs.PhoneNumberTransferDestination),
                SipUri,
                typeof(global::ElevenLabs.SIPUriTransferDestination),
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
        public bool Equals(TransferDestination other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.PhoneNumberTransferDestination?>.Default.Equals(Phone, other.Phone) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.SIPUriTransferDestination?>.Default.Equals(SipUri, other.SipUri) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(TransferDestination obj1, TransferDestination obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<TransferDestination>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(TransferDestination obj1, TransferDestination obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is TransferDestination o && Equals(o);
        }
    }
}
