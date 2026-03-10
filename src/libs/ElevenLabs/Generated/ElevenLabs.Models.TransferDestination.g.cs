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
        public global::ElevenLabs.WorkflowPhoneNumberNodeModelInputTransferDestinationDiscriminatorType? Type { get; }

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
#if NET6_0_OR_GREATER
        public global::ElevenLabs.PhoneNumberDynamicVariableTransferDestination? PhoneDynamicVariable { get; init; }
#else
        public global::ElevenLabs.PhoneNumberDynamicVariableTransferDestination? PhoneDynamicVariable { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PhoneDynamicVariable))]
#endif
        public bool IsPhoneDynamicVariable => PhoneDynamicVariable != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.SIPUriDynamicVariableTransferDestination? SipUriDynamicVariable { get; init; }
#else
        public global::ElevenLabs.SIPUriDynamicVariableTransferDestination? SipUriDynamicVariable { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SipUriDynamicVariable))]
#endif
        public bool IsSipUriDynamicVariable => SipUriDynamicVariable != null;
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
        public static implicit operator TransferDestination(global::ElevenLabs.PhoneNumberDynamicVariableTransferDestination value) => new TransferDestination((global::ElevenLabs.PhoneNumberDynamicVariableTransferDestination?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.PhoneNumberDynamicVariableTransferDestination?(TransferDestination @this) => @this.PhoneDynamicVariable;

        /// <summary>
        /// 
        /// </summary>
        public TransferDestination(global::ElevenLabs.PhoneNumberDynamicVariableTransferDestination? value)
        {
            PhoneDynamicVariable = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TransferDestination(global::ElevenLabs.SIPUriDynamicVariableTransferDestination value) => new TransferDestination((global::ElevenLabs.SIPUriDynamicVariableTransferDestination?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.SIPUriDynamicVariableTransferDestination?(TransferDestination @this) => @this.SipUriDynamicVariable;

        /// <summary>
        /// 
        /// </summary>
        public TransferDestination(global::ElevenLabs.SIPUriDynamicVariableTransferDestination? value)
        {
            SipUriDynamicVariable = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public TransferDestination(
            global::ElevenLabs.WorkflowPhoneNumberNodeModelInputTransferDestinationDiscriminatorType? type,
            global::ElevenLabs.PhoneNumberTransferDestination? phone,
            global::ElevenLabs.SIPUriTransferDestination? sipUri,
            global::ElevenLabs.PhoneNumberDynamicVariableTransferDestination? phoneDynamicVariable,
            global::ElevenLabs.SIPUriDynamicVariableTransferDestination? sipUriDynamicVariable
            )
        {
            Type = type;

            Phone = phone;
            SipUri = sipUri;
            PhoneDynamicVariable = phoneDynamicVariable;
            SipUriDynamicVariable = sipUriDynamicVariable;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            SipUriDynamicVariable as object ??
            PhoneDynamicVariable as object ??
            SipUri as object ??
            Phone as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Phone?.ToString() ??
            SipUri?.ToString() ??
            PhoneDynamicVariable?.ToString() ??
            SipUriDynamicVariable?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsPhone && !IsSipUri && !IsPhoneDynamicVariable && !IsSipUriDynamicVariable || !IsPhone && IsSipUri && !IsPhoneDynamicVariable && !IsSipUriDynamicVariable || !IsPhone && !IsSipUri && IsPhoneDynamicVariable && !IsSipUriDynamicVariable || !IsPhone && !IsSipUri && !IsPhoneDynamicVariable && IsSipUriDynamicVariable;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::ElevenLabs.PhoneNumberTransferDestination?, TResult>? phone = null,
            global::System.Func<global::ElevenLabs.SIPUriTransferDestination?, TResult>? sipUri = null,
            global::System.Func<global::ElevenLabs.PhoneNumberDynamicVariableTransferDestination?, TResult>? phoneDynamicVariable = null,
            global::System.Func<global::ElevenLabs.SIPUriDynamicVariableTransferDestination?, TResult>? sipUriDynamicVariable = null,
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
            else if (IsPhoneDynamicVariable && phoneDynamicVariable != null)
            {
                return phoneDynamicVariable(PhoneDynamicVariable!);
            }
            else if (IsSipUriDynamicVariable && sipUriDynamicVariable != null)
            {
                return sipUriDynamicVariable(SipUriDynamicVariable!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::ElevenLabs.PhoneNumberTransferDestination?>? phone = null,
            global::System.Action<global::ElevenLabs.SIPUriTransferDestination?>? sipUri = null,
            global::System.Action<global::ElevenLabs.PhoneNumberDynamicVariableTransferDestination?>? phoneDynamicVariable = null,
            global::System.Action<global::ElevenLabs.SIPUriDynamicVariableTransferDestination?>? sipUriDynamicVariable = null,
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
            else if (IsPhoneDynamicVariable)
            {
                phoneDynamicVariable?.Invoke(PhoneDynamicVariable!);
            }
            else if (IsSipUriDynamicVariable)
            {
                sipUriDynamicVariable?.Invoke(SipUriDynamicVariable!);
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
                PhoneDynamicVariable,
                typeof(global::ElevenLabs.PhoneNumberDynamicVariableTransferDestination),
                SipUriDynamicVariable,
                typeof(global::ElevenLabs.SIPUriDynamicVariableTransferDestination),
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
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.SIPUriTransferDestination?>.Default.Equals(SipUri, other.SipUri) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.PhoneNumberDynamicVariableTransferDestination?>.Default.Equals(PhoneDynamicVariable, other.PhoneDynamicVariable) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.SIPUriDynamicVariableTransferDestination?>.Default.Equals(SipUriDynamicVariable, other.SipUriDynamicVariable) 
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
