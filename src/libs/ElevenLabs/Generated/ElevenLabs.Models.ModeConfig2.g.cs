#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct ModeConfig2 : global::System.IEquatable<ModeConfig2>
    {
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WhatsAppChannelConfigModeConfigDiscriminatorMode? Mode { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.WhatsAppVoiceConfig? Voice { get; init; }
#else
        public global::ElevenLabs.WhatsAppVoiceConfig? Voice { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Voice))]
#endif
        public bool IsVoice => Voice != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickVoice(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.WhatsAppVoiceConfig? value)
        {
            value = Voice;
            return IsVoice;
        }

        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WhatsAppVoiceConfig PickVoice() => Voice is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Voice' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.WhatsAppMessageConfig? Message { get; init; }
#else
        public global::ElevenLabs.WhatsAppMessageConfig? Message { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Message))]
#endif
        public bool IsMessage => Message != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickMessage(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.WhatsAppMessageConfig? value)
        {
            value = Message;
            return IsMessage;
        }

        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WhatsAppMessageConfig PickMessage() => Message is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Message' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator ModeConfig2(global::ElevenLabs.WhatsAppVoiceConfig value) => new ModeConfig2((global::ElevenLabs.WhatsAppVoiceConfig?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::ElevenLabs.WhatsAppVoiceConfig?(ModeConfig2 @this) => @this.Voice;

        /// <summary>
        ///
        /// </summary>
        public ModeConfig2(global::ElevenLabs.WhatsAppVoiceConfig? value)
        {
            Voice = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ModeConfig2 FromVoice(global::ElevenLabs.WhatsAppVoiceConfig? value) => new ModeConfig2(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ModeConfig2(global::ElevenLabs.WhatsAppMessageConfig value) => new ModeConfig2((global::ElevenLabs.WhatsAppMessageConfig?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::ElevenLabs.WhatsAppMessageConfig?(ModeConfig2 @this) => @this.Message;

        /// <summary>
        ///
        /// </summary>
        public ModeConfig2(global::ElevenLabs.WhatsAppMessageConfig? value)
        {
            Message = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ModeConfig2 FromMessage(global::ElevenLabs.WhatsAppMessageConfig? value) => new ModeConfig2(value);

        /// <summary>
        ///
        /// </summary>
        public ModeConfig2(
            global::ElevenLabs.WhatsAppChannelConfigModeConfigDiscriminatorMode? mode,
            global::ElevenLabs.WhatsAppVoiceConfig? voice,
            global::ElevenLabs.WhatsAppMessageConfig? message
            )
        {
            Mode = mode;

            Voice = voice;
            Message = message;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Message as object ??
            Voice as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Voice?.ToString() ??
            Message?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsVoice && !IsMessage || !IsVoice && IsMessage;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::ElevenLabs.WhatsAppVoiceConfig, TResult>? voice = null,
            global::System.Func<global::ElevenLabs.WhatsAppMessageConfig, TResult>? message = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Voice is { } __value0 && voice != null)
            {
                return voice(__value0);
            }
            else if (Message is { } __value1 && message != null)
            {
                return message(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::ElevenLabs.WhatsAppVoiceConfig>? voice = null,

            global::System.Action<global::ElevenLabs.WhatsAppMessageConfig>? message = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Voice is { } __value0)
            {
                voice?.Invoke(__value0);
            }
            else if (Message is { } __value1)
            {
                message?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::ElevenLabs.WhatsAppVoiceConfig>? voice = null,
            global::System.Action<global::ElevenLabs.WhatsAppMessageConfig>? message = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Voice is { } __value0)
            {
                voice?.Invoke(__value0);
            }
            else if (Message is { } __value1)
            {
                message?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Voice,
                typeof(global::ElevenLabs.WhatsAppVoiceConfig),
                Message,
                typeof(global::ElevenLabs.WhatsAppMessageConfig),
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
        public bool Equals(ModeConfig2 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.WhatsAppVoiceConfig?>.Default.Equals(Voice, other.Voice) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.WhatsAppMessageConfig?>.Default.Equals(Message, other.Message)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(ModeConfig2 obj1, ModeConfig2 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ModeConfig2>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ModeConfig2 obj1, ModeConfig2 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ModeConfig2 o && Equals(o);
        }
    }
}
