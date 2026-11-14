#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct TransferDestination13 : global::System.IEquatable<TransferDestination13>
    {
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TwilioWarmConferenceTransferConfigOutputTransferDestinationDiscriminatorType? Type { get; }

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
        public static implicit operator TransferDestination13(global::ElevenLabs.PhoneDestinationOutput value) => new TransferDestination13((global::ElevenLabs.PhoneDestinationOutput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::ElevenLabs.PhoneDestinationOutput?(TransferDestination13 @this) => @this.Phone;

        /// <summary>
        ///
        /// </summary>
        public TransferDestination13(global::ElevenLabs.PhoneDestinationOutput? value)
        {
            Phone = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static TransferDestination13 FromPhone(global::ElevenLabs.PhoneDestinationOutput? value) => new TransferDestination13(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator TransferDestination13(global::ElevenLabs.PhoneDynamicVariableDestinationOutput value) => new TransferDestination13((global::ElevenLabs.PhoneDynamicVariableDestinationOutput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::ElevenLabs.PhoneDynamicVariableDestinationOutput?(TransferDestination13 @this) => @this.PhoneDynamicVariable;

        /// <summary>
        ///
        /// </summary>
        public TransferDestination13(global::ElevenLabs.PhoneDynamicVariableDestinationOutput? value)
        {
            PhoneDynamicVariable = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static TransferDestination13 FromPhoneDynamicVariable(global::ElevenLabs.PhoneDynamicVariableDestinationOutput? value) => new TransferDestination13(value);

        /// <summary>
        ///
        /// </summary>
        public TransferDestination13(
            global::ElevenLabs.TwilioWarmConferenceTransferConfigOutputTransferDestinationDiscriminatorType? type,
            global::ElevenLabs.PhoneDestinationOutput? phone,
            global::ElevenLabs.PhoneDynamicVariableDestinationOutput? phoneDynamicVariable
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
            global::System.Func<global::ElevenLabs.PhoneDestinationOutput, TResult>? phone = null,
            global::System.Func<global::ElevenLabs.PhoneDynamicVariableDestinationOutput, TResult>? phoneDynamicVariable = null,
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
            global::System.Action<global::ElevenLabs.PhoneDestinationOutput>? phone = null,

            global::System.Action<global::ElevenLabs.PhoneDynamicVariableDestinationOutput>? phoneDynamicVariable = null,
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
            global::System.Action<global::ElevenLabs.PhoneDestinationOutput>? phone = null,
            global::System.Action<global::ElevenLabs.PhoneDynamicVariableDestinationOutput>? phoneDynamicVariable = null,
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
                typeof(global::ElevenLabs.PhoneDestinationOutput),
                PhoneDynamicVariable,
                typeof(global::ElevenLabs.PhoneDynamicVariableDestinationOutput),
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
        public bool Equals(TransferDestination13 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.PhoneDestinationOutput?>.Default.Equals(Phone, other.Phone) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.PhoneDynamicVariableDestinationOutput?>.Default.Equals(PhoneDynamicVariable, other.PhoneDynamicVariable)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(TransferDestination13 obj1, TransferDestination13 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<TransferDestination13>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(TransferDestination13 obj1, TransferDestination13 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is TransferDestination13 o && Equals(o);
        }
    }
}
