#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct TransferDestination8 : global::System.IEquatable<TransferDestination8>
    {
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SIPColdReferTransferConfigInputTransferDestinationDiscriminatorType? Type { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.PhoneDestinationInput? Phone { get; init; }
#else
        public global::ElevenLabs.PhoneDestinationInput? Phone { get; }
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
        public bool TryPickPhone(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.PhoneDestinationInput? value)
        {
            value = Phone;
            return IsPhone;
        }

        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PhoneDestinationInput PickPhone() => Phone is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Phone' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.SipUriDestinationInput? SipUri { get; init; }
#else
        public global::ElevenLabs.SipUriDestinationInput? SipUri { get; }
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
        public bool TryPickSipUri(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.SipUriDestinationInput? value)
        {
            value = SipUri;
            return IsSipUri;
        }

        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SipUriDestinationInput PickSipUri() => SipUri is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'SipUri' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.PhoneDynamicVariableDestinationInput? PhoneDynamicVariable { get; init; }
#else
        public global::ElevenLabs.PhoneDynamicVariableDestinationInput? PhoneDynamicVariable { get; }
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
        public bool TryPickPhoneDynamicVariable(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.PhoneDynamicVariableDestinationInput? value)
        {
            value = PhoneDynamicVariable;
            return IsPhoneDynamicVariable;
        }

        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PhoneDynamicVariableDestinationInput PickPhoneDynamicVariable() => PhoneDynamicVariable is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'PhoneDynamicVariable' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.SipUriDynamicVariableDestinationInput? SipUriDynamicVariable { get; init; }
#else
        public global::ElevenLabs.SipUriDynamicVariableDestinationInput? SipUriDynamicVariable { get; }
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
        public bool TryPickSipUriDynamicVariable(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.SipUriDynamicVariableDestinationInput? value)
        {
            value = SipUriDynamicVariable;
            return IsSipUriDynamicVariable;
        }

        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SipUriDynamicVariableDestinationInput PickSipUriDynamicVariable() => SipUriDynamicVariable is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'SipUriDynamicVariable' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator TransferDestination8(global::ElevenLabs.PhoneDestinationInput value) => new TransferDestination8((global::ElevenLabs.PhoneDestinationInput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::ElevenLabs.PhoneDestinationInput?(TransferDestination8 @this) => @this.Phone;

        /// <summary>
        ///
        /// </summary>
        public TransferDestination8(global::ElevenLabs.PhoneDestinationInput? value)
        {
            Phone = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static TransferDestination8 FromPhone(global::ElevenLabs.PhoneDestinationInput? value) => new TransferDestination8(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator TransferDestination8(global::ElevenLabs.SipUriDestinationInput value) => new TransferDestination8((global::ElevenLabs.SipUriDestinationInput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::ElevenLabs.SipUriDestinationInput?(TransferDestination8 @this) => @this.SipUri;

        /// <summary>
        ///
        /// </summary>
        public TransferDestination8(global::ElevenLabs.SipUriDestinationInput? value)
        {
            SipUri = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static TransferDestination8 FromSipUri(global::ElevenLabs.SipUriDestinationInput? value) => new TransferDestination8(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator TransferDestination8(global::ElevenLabs.PhoneDynamicVariableDestinationInput value) => new TransferDestination8((global::ElevenLabs.PhoneDynamicVariableDestinationInput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::ElevenLabs.PhoneDynamicVariableDestinationInput?(TransferDestination8 @this) => @this.PhoneDynamicVariable;

        /// <summary>
        ///
        /// </summary>
        public TransferDestination8(global::ElevenLabs.PhoneDynamicVariableDestinationInput? value)
        {
            PhoneDynamicVariable = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static TransferDestination8 FromPhoneDynamicVariable(global::ElevenLabs.PhoneDynamicVariableDestinationInput? value) => new TransferDestination8(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator TransferDestination8(global::ElevenLabs.SipUriDynamicVariableDestinationInput value) => new TransferDestination8((global::ElevenLabs.SipUriDynamicVariableDestinationInput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::ElevenLabs.SipUriDynamicVariableDestinationInput?(TransferDestination8 @this) => @this.SipUriDynamicVariable;

        /// <summary>
        ///
        /// </summary>
        public TransferDestination8(global::ElevenLabs.SipUriDynamicVariableDestinationInput? value)
        {
            SipUriDynamicVariable = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static TransferDestination8 FromSipUriDynamicVariable(global::ElevenLabs.SipUriDynamicVariableDestinationInput? value) => new TransferDestination8(value);

        /// <summary>
        ///
        /// </summary>
        public TransferDestination8(
            global::ElevenLabs.SIPColdReferTransferConfigInputTransferDestinationDiscriminatorType? type,
            global::ElevenLabs.PhoneDestinationInput? phone,
            global::ElevenLabs.SipUriDestinationInput? sipUri,
            global::ElevenLabs.PhoneDynamicVariableDestinationInput? phoneDynamicVariable,
            global::ElevenLabs.SipUriDynamicVariableDestinationInput? sipUriDynamicVariable
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
            global::System.Func<global::ElevenLabs.PhoneDestinationInput, TResult>? phone = null,
            global::System.Func<global::ElevenLabs.SipUriDestinationInput, TResult>? sipUri = null,
            global::System.Func<global::ElevenLabs.PhoneDynamicVariableDestinationInput, TResult>? phoneDynamicVariable = null,
            global::System.Func<global::ElevenLabs.SipUriDynamicVariableDestinationInput, TResult>? sipUriDynamicVariable = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Phone is { } __value0 && phone != null)
            {
                return phone(__value0);
            }
            else if (SipUri is { } __value1 && sipUri != null)
            {
                return sipUri(__value1);
            }
            else if (PhoneDynamicVariable is { } __value2 && phoneDynamicVariable != null)
            {
                return phoneDynamicVariable(__value2);
            }
            else if (SipUriDynamicVariable is { } __value3 && sipUriDynamicVariable != null)
            {
                return sipUriDynamicVariable(__value3);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::ElevenLabs.PhoneDestinationInput>? phone = null,

            global::System.Action<global::ElevenLabs.SipUriDestinationInput>? sipUri = null,

            global::System.Action<global::ElevenLabs.PhoneDynamicVariableDestinationInput>? phoneDynamicVariable = null,

            global::System.Action<global::ElevenLabs.SipUriDynamicVariableDestinationInput>? sipUriDynamicVariable = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Phone is { } __value0)
            {
                phone?.Invoke(__value0);
            }
            else if (SipUri is { } __value1)
            {
                sipUri?.Invoke(__value1);
            }
            else if (PhoneDynamicVariable is { } __value2)
            {
                phoneDynamicVariable?.Invoke(__value2);
            }
            else if (SipUriDynamicVariable is { } __value3)
            {
                sipUriDynamicVariable?.Invoke(__value3);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::ElevenLabs.PhoneDestinationInput>? phone = null,
            global::System.Action<global::ElevenLabs.SipUriDestinationInput>? sipUri = null,
            global::System.Action<global::ElevenLabs.PhoneDynamicVariableDestinationInput>? phoneDynamicVariable = null,
            global::System.Action<global::ElevenLabs.SipUriDynamicVariableDestinationInput>? sipUriDynamicVariable = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Phone is { } __value0)
            {
                phone?.Invoke(__value0);
            }
            else if (SipUri is { } __value1)
            {
                sipUri?.Invoke(__value1);
            }
            else if (PhoneDynamicVariable is { } __value2)
            {
                phoneDynamicVariable?.Invoke(__value2);
            }
            else if (SipUriDynamicVariable is { } __value3)
            {
                sipUriDynamicVariable?.Invoke(__value3);
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
                typeof(global::ElevenLabs.PhoneDestinationInput),
                SipUri,
                typeof(global::ElevenLabs.SipUriDestinationInput),
                PhoneDynamicVariable,
                typeof(global::ElevenLabs.PhoneDynamicVariableDestinationInput),
                SipUriDynamicVariable,
                typeof(global::ElevenLabs.SipUriDynamicVariableDestinationInput),
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
        public bool Equals(TransferDestination8 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.PhoneDestinationInput?>.Default.Equals(Phone, other.Phone) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.SipUriDestinationInput?>.Default.Equals(SipUri, other.SipUri) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.PhoneDynamicVariableDestinationInput?>.Default.Equals(PhoneDynamicVariable, other.PhoneDynamicVariable) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.SipUriDynamicVariableDestinationInput?>.Default.Equals(SipUriDynamicVariable, other.SipUriDynamicVariable)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(TransferDestination8 obj1, TransferDestination8 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<TransferDestination8>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(TransferDestination8 obj1, TransferDestination8 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is TransferDestination8 o && Equals(o);
        }
    }
}
