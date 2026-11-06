#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct PlatformMetadataVariant1 : global::System.IEquatable<PlatformMetadataVariant1>
    {
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AsyncConversationMetadataPlatformMetadataVariant1DiscriminatorConversationInitiationSource? ConversationInitiationSource { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.PlainPlatformMetadata? PlainIntegration { get; init; }
#else
        public global::ElevenLabs.PlainPlatformMetadata? PlainIntegration { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(PlainIntegration))]
#endif
        public bool IsPlainIntegration => PlainIntegration != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickPlainIntegration(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.PlainPlatformMetadata? value)
        {
            value = PlainIntegration;
            return IsPlainIntegration;
        }

        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.PlainPlatformMetadata PickPlainIntegration() => PlainIntegration is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'PlainIntegration' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.ZendeskPlatformMetadata? ZendeskIntegration { get; init; }
#else
        public global::ElevenLabs.ZendeskPlatformMetadata? ZendeskIntegration { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ZendeskIntegration))]
#endif
        public bool IsZendeskIntegration => ZendeskIntegration != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickZendeskIntegration(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.ZendeskPlatformMetadata? value)
        {
            value = ZendeskIntegration;
            return IsZendeskIntegration;
        }

        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ZendeskPlatformMetadata PickZendeskIntegration() => ZendeskIntegration is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ZendeskIntegration' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator PlatformMetadataVariant1(global::ElevenLabs.PlainPlatformMetadata value) => new PlatformMetadataVariant1((global::ElevenLabs.PlainPlatformMetadata?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::ElevenLabs.PlainPlatformMetadata?(PlatformMetadataVariant1 @this) => @this.PlainIntegration;

        /// <summary>
        ///
        /// </summary>
        public PlatformMetadataVariant1(global::ElevenLabs.PlainPlatformMetadata? value)
        {
            PlainIntegration = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static PlatformMetadataVariant1 FromPlainIntegration(global::ElevenLabs.PlainPlatformMetadata? value) => new PlatformMetadataVariant1(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator PlatformMetadataVariant1(global::ElevenLabs.ZendeskPlatformMetadata value) => new PlatformMetadataVariant1((global::ElevenLabs.ZendeskPlatformMetadata?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::ElevenLabs.ZendeskPlatformMetadata?(PlatformMetadataVariant1 @this) => @this.ZendeskIntegration;

        /// <summary>
        ///
        /// </summary>
        public PlatformMetadataVariant1(global::ElevenLabs.ZendeskPlatformMetadata? value)
        {
            ZendeskIntegration = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static PlatformMetadataVariant1 FromZendeskIntegration(global::ElevenLabs.ZendeskPlatformMetadata? value) => new PlatformMetadataVariant1(value);

        /// <summary>
        ///
        /// </summary>
        public PlatformMetadataVariant1(
            global::ElevenLabs.AsyncConversationMetadataPlatformMetadataVariant1DiscriminatorConversationInitiationSource? conversationInitiationSource,
            global::ElevenLabs.PlainPlatformMetadata? plainIntegration,
            global::ElevenLabs.ZendeskPlatformMetadata? zendeskIntegration
            )
        {
            ConversationInitiationSource = conversationInitiationSource;

            PlainIntegration = plainIntegration;
            ZendeskIntegration = zendeskIntegration;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            ZendeskIntegration as object ??
            PlainIntegration as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            PlainIntegration?.ToString() ??
            ZendeskIntegration?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsPlainIntegration && !IsZendeskIntegration || !IsPlainIntegration && IsZendeskIntegration;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::ElevenLabs.PlainPlatformMetadata, TResult>? plainIntegration = null,
            global::System.Func<global::ElevenLabs.ZendeskPlatformMetadata, TResult>? zendeskIntegration = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (PlainIntegration is { } __value0 && plainIntegration != null)
            {
                return plainIntegration(__value0);
            }
            else if (ZendeskIntegration is { } __value1 && zendeskIntegration != null)
            {
                return zendeskIntegration(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::ElevenLabs.PlainPlatformMetadata>? plainIntegration = null,

            global::System.Action<global::ElevenLabs.ZendeskPlatformMetadata>? zendeskIntegration = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (PlainIntegration is { } __value0)
            {
                plainIntegration?.Invoke(__value0);
            }
            else if (ZendeskIntegration is { } __value1)
            {
                zendeskIntegration?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::ElevenLabs.PlainPlatformMetadata>? plainIntegration = null,
            global::System.Action<global::ElevenLabs.ZendeskPlatformMetadata>? zendeskIntegration = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (PlainIntegration is { } __value0)
            {
                plainIntegration?.Invoke(__value0);
            }
            else if (ZendeskIntegration is { } __value1)
            {
                zendeskIntegration?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                PlainIntegration,
                typeof(global::ElevenLabs.PlainPlatformMetadata),
                ZendeskIntegration,
                typeof(global::ElevenLabs.ZendeskPlatformMetadata),
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
        public bool Equals(PlatformMetadataVariant1 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.PlainPlatformMetadata?>.Default.Equals(PlainIntegration, other.PlainIntegration) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.ZendeskPlatformMetadata?>.Default.Equals(ZendeskIntegration, other.ZendeskIntegration)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(PlatformMetadataVariant1 obj1, PlatformMetadataVariant1 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<PlatformMetadataVariant1>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(PlatformMetadataVariant1 obj1, PlatformMetadataVariant1 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is PlatformMetadataVariant1 o && Equals(o);
        }
    }
}
