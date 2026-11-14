#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct TransferDestination3 : global::System.IEquatable<TransferDestination3>
    {
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ExotelWarmTransferConfigInputTransferDestinationDiscriminatorType? Type { get; }

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
        public static implicit operator TransferDestination3(global::ElevenLabs.PhoneDestinationInput value) => new TransferDestination3((global::ElevenLabs.PhoneDestinationInput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::ElevenLabs.PhoneDestinationInput?(TransferDestination3 @this) => @this.Phone;

        /// <summary>
        ///
        /// </summary>
        public TransferDestination3(global::ElevenLabs.PhoneDestinationInput? value)
        {
            Phone = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static TransferDestination3 FromPhone(global::ElevenLabs.PhoneDestinationInput? value) => new TransferDestination3(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator TransferDestination3(global::ElevenLabs.PhoneDynamicVariableDestinationInput value) => new TransferDestination3((global::ElevenLabs.PhoneDynamicVariableDestinationInput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::ElevenLabs.PhoneDynamicVariableDestinationInput?(TransferDestination3 @this) => @this.PhoneDynamicVariable;

        /// <summary>
        ///
        /// </summary>
        public TransferDestination3(global::ElevenLabs.PhoneDynamicVariableDestinationInput? value)
        {
            PhoneDynamicVariable = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static TransferDestination3 FromPhoneDynamicVariable(global::ElevenLabs.PhoneDynamicVariableDestinationInput? value) => new TransferDestination3(value);

        /// <summary>
        ///
        /// </summary>
        public TransferDestination3(
            global::ElevenLabs.ExotelWarmTransferConfigInputTransferDestinationDiscriminatorType? type,
            global::ElevenLabs.PhoneDestinationInput? phone,
            global::ElevenLabs.PhoneDynamicVariableDestinationInput? phoneDynamicVariable
            )
        {
            Type = type;

            Phone = phone;
            PhoneDynamicVariable = phoneDynamicVariable;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            PhoneDynamicVariable as object ??
            Phone as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Phone?.ToString() ??
            PhoneDynamicVariable?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsPhone && !IsPhoneDynamicVariable || !IsPhone && IsPhoneDynamicVariable;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::ElevenLabs.PhoneDestinationInput, TResult>? phone = null,
            global::System.Func<global::ElevenLabs.PhoneDynamicVariableDestinationInput, TResult>? phoneDynamicVariable = null,
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
            else if (PhoneDynamicVariable is { } __value1 && phoneDynamicVariable != null)
            {
                return phoneDynamicVariable(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::ElevenLabs.PhoneDestinationInput>? phone = null,

            global::System.Action<global::ElevenLabs.PhoneDynamicVariableDestinationInput>? phoneDynamicVariable = null,
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
            else if (PhoneDynamicVariable is { } __value1)
            {
                phoneDynamicVariable?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::ElevenLabs.PhoneDestinationInput>? phone = null,
            global::System.Action<global::ElevenLabs.PhoneDynamicVariableDestinationInput>? phoneDynamicVariable = null,
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
            else if (PhoneDynamicVariable is { } __value1)
            {
                phoneDynamicVariable?.Invoke(__value1);
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
                PhoneDynamicVariable,
                typeof(global::ElevenLabs.PhoneDynamicVariableDestinationInput),
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
        public bool Equals(TransferDestination3 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.PhoneDestinationInput?>.Default.Equals(Phone, other.Phone) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.PhoneDynamicVariableDestinationInput?>.Default.Equals(PhoneDynamicVariable, other.PhoneDynamicVariable)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(TransferDestination3 obj1, TransferDestination3 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<TransferDestination3>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(TransferDestination3 obj1, TransferDestination3 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is TransferDestination3 o && Equals(o);
        }
    }
}
