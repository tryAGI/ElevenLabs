#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct TransferDestination9 : global::System.IEquatable<TransferDestination9>
    {
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SIPColdReferTransferConfigOutputTransferDestinationDiscriminatorType? Type { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.PhoneDestinationOutput? Phone { get; init; }
#else
        public global::ElevenLabs.PhoneDestinationOutput? Phone { get; }
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
            out global::ElevenLabs.PhoneDestinationOutput? value)
        {
            value = Phone;
            return IsPhone;
        }

        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PhoneDestinationOutput PickPhone() => Phone is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Phone' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.SipUriDestinationOutput? SipUri { get; init; }
#else
        public global::ElevenLabs.SipUriDestinationOutput? SipUri { get; }
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
            out global::ElevenLabs.SipUriDestinationOutput? value)
        {
            value = SipUri;
            return IsSipUri;
        }

        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SipUriDestinationOutput PickSipUri() => SipUri is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'SipUri' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.PhoneDynamicVariableDestinationOutput? PhoneDynamicVariable { get; init; }
#else
        public global::ElevenLabs.PhoneDynamicVariableDestinationOutput? PhoneDynamicVariable { get; }
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
            out global::ElevenLabs.PhoneDynamicVariableDestinationOutput? value)
        {
            value = PhoneDynamicVariable;
            return IsPhoneDynamicVariable;
        }

        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PhoneDynamicVariableDestinationOutput PickPhoneDynamicVariable() => PhoneDynamicVariable is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'PhoneDynamicVariable' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.SipUriDynamicVariableDestinationOutput? SipUriDynamicVariable { get; init; }
#else
        public global::ElevenLabs.SipUriDynamicVariableDestinationOutput? SipUriDynamicVariable { get; }
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
            out global::ElevenLabs.SipUriDynamicVariableDestinationOutput? value)
        {
            value = SipUriDynamicVariable;
            return IsSipUriDynamicVariable;
        }

        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SipUriDynamicVariableDestinationOutput PickSipUriDynamicVariable() => SipUriDynamicVariable is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'SipUriDynamicVariable' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator TransferDestination9(global::ElevenLabs.PhoneDestinationOutput value) => new TransferDestination9((global::ElevenLabs.PhoneDestinationOutput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::ElevenLabs.PhoneDestinationOutput?(TransferDestination9 @this) => @this.Phone;

        /// <summary>
        ///
        /// </summary>
        public TransferDestination9(global::ElevenLabs.PhoneDestinationOutput? value)
        {
            Phone = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static TransferDestination9 FromPhone(global::ElevenLabs.PhoneDestinationOutput? value) => new TransferDestination9(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator TransferDestination9(global::ElevenLabs.SipUriDestinationOutput value) => new TransferDestination9((global::ElevenLabs.SipUriDestinationOutput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::ElevenLabs.SipUriDestinationOutput?(TransferDestination9 @this) => @this.SipUri;

        /// <summary>
        ///
        /// </summary>
        public TransferDestination9(global::ElevenLabs.SipUriDestinationOutput? value)
        {
            SipUri = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static TransferDestination9 FromSipUri(global::ElevenLabs.SipUriDestinationOutput? value) => new TransferDestination9(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator TransferDestination9(global::ElevenLabs.PhoneDynamicVariableDestinationOutput value) => new TransferDestination9((global::ElevenLabs.PhoneDynamicVariableDestinationOutput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::ElevenLabs.PhoneDynamicVariableDestinationOutput?(TransferDestination9 @this) => @this.PhoneDynamicVariable;

        /// <summary>
        ///
        /// </summary>
        public TransferDestination9(global::ElevenLabs.PhoneDynamicVariableDestinationOutput? value)
        {
            PhoneDynamicVariable = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static TransferDestination9 FromPhoneDynamicVariable(global::ElevenLabs.PhoneDynamicVariableDestinationOutput? value) => new TransferDestination9(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator TransferDestination9(global::ElevenLabs.SipUriDynamicVariableDestinationOutput value) => new TransferDestination9((global::ElevenLabs.SipUriDynamicVariableDestinationOutput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::ElevenLabs.SipUriDynamicVariableDestinationOutput?(TransferDestination9 @this) => @this.SipUriDynamicVariable;

        /// <summary>
        ///
        /// </summary>
        public TransferDestination9(global::ElevenLabs.SipUriDynamicVariableDestinationOutput? value)
        {
            SipUriDynamicVariable = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static TransferDestination9 FromSipUriDynamicVariable(global::ElevenLabs.SipUriDynamicVariableDestinationOutput? value) => new TransferDestination9(value);

        /// <summary>
        ///
        /// </summary>
        public TransferDestination9(
            global::ElevenLabs.SIPColdReferTransferConfigOutputTransferDestinationDiscriminatorType? type,
            global::ElevenLabs.PhoneDestinationOutput? phone,
            global::ElevenLabs.SipUriDestinationOutput? sipUri,
            global::ElevenLabs.PhoneDynamicVariableDestinationOutput? phoneDynamicVariable,
            global::ElevenLabs.SipUriDynamicVariableDestinationOutput? sipUriDynamicVariable
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
            global::System.Func<global::ElevenLabs.PhoneDestinationOutput, TResult>? phone = null,
            global::System.Func<global::ElevenLabs.SipUriDestinationOutput, TResult>? sipUri = null,
            global::System.Func<global::ElevenLabs.PhoneDynamicVariableDestinationOutput, TResult>? phoneDynamicVariable = null,
            global::System.Func<global::ElevenLabs.SipUriDynamicVariableDestinationOutput, TResult>? sipUriDynamicVariable = null,
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
            global::System.Action<global::ElevenLabs.PhoneDestinationOutput>? phone = null,

            global::System.Action<global::ElevenLabs.SipUriDestinationOutput>? sipUri = null,

            global::System.Action<global::ElevenLabs.PhoneDynamicVariableDestinationOutput>? phoneDynamicVariable = null,

            global::System.Action<global::ElevenLabs.SipUriDynamicVariableDestinationOutput>? sipUriDynamicVariable = null,
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
            global::System.Action<global::ElevenLabs.PhoneDestinationOutput>? phone = null,
            global::System.Action<global::ElevenLabs.SipUriDestinationOutput>? sipUri = null,
            global::System.Action<global::ElevenLabs.PhoneDynamicVariableDestinationOutput>? phoneDynamicVariable = null,
            global::System.Action<global::ElevenLabs.SipUriDynamicVariableDestinationOutput>? sipUriDynamicVariable = null,
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
                typeof(global::ElevenLabs.PhoneDestinationOutput),
                SipUri,
                typeof(global::ElevenLabs.SipUriDestinationOutput),
                PhoneDynamicVariable,
                typeof(global::ElevenLabs.PhoneDynamicVariableDestinationOutput),
                SipUriDynamicVariable,
                typeof(global::ElevenLabs.SipUriDynamicVariableDestinationOutput),
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
        public bool Equals(TransferDestination9 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.PhoneDestinationOutput?>.Default.Equals(Phone, other.Phone) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.SipUriDestinationOutput?>.Default.Equals(SipUri, other.SipUri) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.PhoneDynamicVariableDestinationOutput?>.Default.Equals(PhoneDynamicVariable, other.PhoneDynamicVariable) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.SipUriDynamicVariableDestinationOutput?>.Default.Equals(SipUriDynamicVariable, other.SipUriDynamicVariable)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(TransferDestination9 obj1, TransferDestination9 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<TransferDestination9>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(TransferDestination9 obj1, TransferDestination9 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is TransferDestination9 o && Equals(o);
        }
    }
}
