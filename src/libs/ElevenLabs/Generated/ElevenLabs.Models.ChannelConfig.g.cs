#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct ChannelConfig : global::System.IEquatable<ChannelConfig>
    {
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CampaignResponseChannelConfigDiscriminatorChannel? Channel { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.PhoneChannelConfigOutput? Phone { get; init; }
#else
        public global::ElevenLabs.PhoneChannelConfigOutput? Phone { get; }
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
            out global::ElevenLabs.PhoneChannelConfigOutput? value)
        {
            value = Phone;
            return IsPhone;
        }

        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PhoneChannelConfigOutput PickPhone() => Phone is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Phone' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.WhatsAppChannelConfig? Whatsapp { get; init; }
#else
        public global::ElevenLabs.WhatsAppChannelConfig? Whatsapp { get; }
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
            out global::ElevenLabs.WhatsAppChannelConfig? value)
        {
            value = Whatsapp;
            return IsWhatsapp;
        }

        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WhatsAppChannelConfig PickWhatsapp() => Whatsapp is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Whatsapp' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator ChannelConfig(global::ElevenLabs.PhoneChannelConfigOutput value) => new ChannelConfig((global::ElevenLabs.PhoneChannelConfigOutput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::ElevenLabs.PhoneChannelConfigOutput?(ChannelConfig @this) => @this.Phone;

        /// <summary>
        ///
        /// </summary>
        public ChannelConfig(global::ElevenLabs.PhoneChannelConfigOutput? value)
        {
            Phone = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ChannelConfig FromPhone(global::ElevenLabs.PhoneChannelConfigOutput? value) => new ChannelConfig(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ChannelConfig(global::ElevenLabs.WhatsAppChannelConfig value) => new ChannelConfig((global::ElevenLabs.WhatsAppChannelConfig?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::ElevenLabs.WhatsAppChannelConfig?(ChannelConfig @this) => @this.Whatsapp;

        /// <summary>
        ///
        /// </summary>
        public ChannelConfig(global::ElevenLabs.WhatsAppChannelConfig? value)
        {
            Whatsapp = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ChannelConfig FromWhatsapp(global::ElevenLabs.WhatsAppChannelConfig? value) => new ChannelConfig(value);

        /// <summary>
        ///
        /// </summary>
        public ChannelConfig(
            global::ElevenLabs.CampaignResponseChannelConfigDiscriminatorChannel? channel,
            global::ElevenLabs.PhoneChannelConfigOutput? phone,
            global::ElevenLabs.WhatsAppChannelConfig? whatsapp
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
            global::System.Func<global::ElevenLabs.PhoneChannelConfigOutput, TResult>? phone = null,
            global::System.Func<global::ElevenLabs.WhatsAppChannelConfig, TResult>? whatsapp = null,
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
            global::System.Action<global::ElevenLabs.PhoneChannelConfigOutput>? phone = null,

            global::System.Action<global::ElevenLabs.WhatsAppChannelConfig>? whatsapp = null,
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
            global::System.Action<global::ElevenLabs.PhoneChannelConfigOutput>? phone = null,
            global::System.Action<global::ElevenLabs.WhatsAppChannelConfig>? whatsapp = null,
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
                typeof(global::ElevenLabs.PhoneChannelConfigOutput),
                Whatsapp,
                typeof(global::ElevenLabs.WhatsAppChannelConfig),
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
        public bool Equals(ChannelConfig other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.PhoneChannelConfigOutput?>.Default.Equals(Phone, other.Phone) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.WhatsAppChannelConfig?>.Default.Equals(Whatsapp, other.Whatsapp)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(ChannelConfig obj1, ChannelConfig obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ChannelConfig>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ChannelConfig obj1, ChannelConfig obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ChannelConfig o && Equals(o);
        }
    }
}
