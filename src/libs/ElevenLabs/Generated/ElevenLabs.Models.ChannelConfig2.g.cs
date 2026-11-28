#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct ChannelConfig2 : global::System.IEquatable<ChannelConfig2>
    {
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SubmitCampaignRequestChannelConfigDiscriminatorChannel? Channel { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.PhoneChannelConfigInput? Phone { get; init; }
#else
        public global::ElevenLabs.PhoneChannelConfigInput? Phone { get; }
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
            out global::ElevenLabs.PhoneChannelConfigInput? value)
        {
            value = Phone;
            return IsPhone;
        }

        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PhoneChannelConfigInput PickPhone() => Phone is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Phone' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.SubmitWhatsAppChannelConfig? Whatsapp { get; init; }
#else
        public global::ElevenLabs.SubmitWhatsAppChannelConfig? Whatsapp { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Whatsapp))]
#endif
        public bool IsWhatsapp => Whatsapp != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickWhatsapp(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.SubmitWhatsAppChannelConfig? value)
        {
            value = Whatsapp;
            return IsWhatsapp;
        }

        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SubmitWhatsAppChannelConfig PickWhatsapp() => Whatsapp is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Whatsapp' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator ChannelConfig2(global::ElevenLabs.PhoneChannelConfigInput value) => new ChannelConfig2((global::ElevenLabs.PhoneChannelConfigInput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::ElevenLabs.PhoneChannelConfigInput?(ChannelConfig2 @this) => @this.Phone;

        /// <summary>
        ///
        /// </summary>
        public ChannelConfig2(global::ElevenLabs.PhoneChannelConfigInput? value)
        {
            Phone = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ChannelConfig2 FromPhone(global::ElevenLabs.PhoneChannelConfigInput? value) => new ChannelConfig2(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ChannelConfig2(global::ElevenLabs.SubmitWhatsAppChannelConfig value) => new ChannelConfig2((global::ElevenLabs.SubmitWhatsAppChannelConfig?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::ElevenLabs.SubmitWhatsAppChannelConfig?(ChannelConfig2 @this) => @this.Whatsapp;

        /// <summary>
        ///
        /// </summary>
        public ChannelConfig2(global::ElevenLabs.SubmitWhatsAppChannelConfig? value)
        {
            Whatsapp = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ChannelConfig2 FromWhatsapp(global::ElevenLabs.SubmitWhatsAppChannelConfig? value) => new ChannelConfig2(value);

        /// <summary>
        ///
        /// </summary>
        public ChannelConfig2(
            global::ElevenLabs.SubmitCampaignRequestChannelConfigDiscriminatorChannel? channel,
            global::ElevenLabs.PhoneChannelConfigInput? phone,
            global::ElevenLabs.SubmitWhatsAppChannelConfig? whatsapp
            )
        {
            Channel = channel;

            Phone = phone;
            Whatsapp = whatsapp;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Whatsapp as object ??
            Phone as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Phone?.ToString() ??
            Whatsapp?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsPhone && !IsWhatsapp || !IsPhone && IsWhatsapp;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::ElevenLabs.PhoneChannelConfigInput, TResult>? phone = null,
            global::System.Func<global::ElevenLabs.SubmitWhatsAppChannelConfig, TResult>? whatsapp = null,
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
            else if (Whatsapp is { } __value1 && whatsapp != null)
            {
                return whatsapp(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::ElevenLabs.PhoneChannelConfigInput>? phone = null,

            global::System.Action<global::ElevenLabs.SubmitWhatsAppChannelConfig>? whatsapp = null,
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
            else if (Whatsapp is { } __value1)
            {
                whatsapp?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::ElevenLabs.PhoneChannelConfigInput>? phone = null,
            global::System.Action<global::ElevenLabs.SubmitWhatsAppChannelConfig>? whatsapp = null,
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
            else if (Whatsapp is { } __value1)
            {
                whatsapp?.Invoke(__value1);
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
                typeof(global::ElevenLabs.PhoneChannelConfigInput),
                Whatsapp,
                typeof(global::ElevenLabs.SubmitWhatsAppChannelConfig),
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
        public bool Equals(ChannelConfig2 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.PhoneChannelConfigInput?>.Default.Equals(Phone, other.Phone) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.SubmitWhatsAppChannelConfig?>.Default.Equals(Whatsapp, other.Whatsapp)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(ChannelConfig2 obj1, ChannelConfig2 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ChannelConfig2>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ChannelConfig2 obj1, ChannelConfig2 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ChannelConfig2 o && Equals(o);
        }
    }
}
