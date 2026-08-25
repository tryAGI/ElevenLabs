#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace ElevenLabs.TextToDialogueMultiContextRealtime
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ServerEvent : global::System.IEquatable<ServerEvent>
    {
        /// <summary>
        /// Server chunk containing encoded audio for a specific context and optional alignment metadata.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.TextToDialogueMultiContextRealtime.TextToDialogueWebsocketAudioChunkMulti? TextToDialogueWebsocketAudioChunkMulti { get; init; }
#else
        public global::ElevenLabs.TextToDialogueMultiContextRealtime.TextToDialogueWebsocketAudioChunkMulti? TextToDialogueWebsocketAudioChunkMulti { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TextToDialogueWebsocketAudioChunkMulti))]
#endif
        public bool IsTextToDialogueWebsocketAudioChunkMulti => TextToDialogueWebsocketAudioChunkMulti != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickTextToDialogueWebsocketAudioChunkMulti(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.TextToDialogueMultiContextRealtime.TextToDialogueWebsocketAudioChunkMulti? value)
        {
            value = TextToDialogueWebsocketAudioChunkMulti;
            return IsTextToDialogueWebsocketAudioChunkMulti;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::ElevenLabs.TextToDialogueMultiContextRealtime.TextToDialogueWebsocketAudioChunkMulti PickTextToDialogueWebsocketAudioChunkMulti() => IsTextToDialogueWebsocketAudioChunkMulti
            ? TextToDialogueWebsocketAudioChunkMulti!
            : throw new global::System.InvalidOperationException($"Expected union variant 'TextToDialogueWebsocketAudioChunkMulti' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.TextToDialogueMultiContextRealtime.TextToDialogueWebsocketFinalAudioForTurnMulti? TextToDialogueWebsocketFinalAudioForTurnMulti { get; init; }
#else
        public global::ElevenLabs.TextToDialogueMultiContextRealtime.TextToDialogueWebsocketFinalAudioForTurnMulti? TextToDialogueWebsocketFinalAudioForTurnMulti { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TextToDialogueWebsocketFinalAudioForTurnMulti))]
#endif
        public bool IsTextToDialogueWebsocketFinalAudioForTurnMulti => TextToDialogueWebsocketFinalAudioForTurnMulti != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickTextToDialogueWebsocketFinalAudioForTurnMulti(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.TextToDialogueMultiContextRealtime.TextToDialogueWebsocketFinalAudioForTurnMulti? value)
        {
            value = TextToDialogueWebsocketFinalAudioForTurnMulti;
            return IsTextToDialogueWebsocketFinalAudioForTurnMulti;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::ElevenLabs.TextToDialogueMultiContextRealtime.TextToDialogueWebsocketFinalAudioForTurnMulti PickTextToDialogueWebsocketFinalAudioForTurnMulti() => IsTextToDialogueWebsocketFinalAudioForTurnMulti
            ? TextToDialogueWebsocketFinalAudioForTurnMulti!
            : throw new global::System.InvalidOperationException($"Expected union variant 'TextToDialogueWebsocketFinalAudioForTurnMulti' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.TextToDialogueMultiContextRealtime.TextToDialogueWebsocketFinalMulti? TextToDialogueWebsocketFinalMulti { get; init; }
#else
        public global::ElevenLabs.TextToDialogueMultiContextRealtime.TextToDialogueWebsocketFinalMulti? TextToDialogueWebsocketFinalMulti { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TextToDialogueWebsocketFinalMulti))]
#endif
        public bool IsTextToDialogueWebsocketFinalMulti => TextToDialogueWebsocketFinalMulti != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickTextToDialogueWebsocketFinalMulti(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.TextToDialogueMultiContextRealtime.TextToDialogueWebsocketFinalMulti? value)
        {
            value = TextToDialogueWebsocketFinalMulti;
            return IsTextToDialogueWebsocketFinalMulti;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::ElevenLabs.TextToDialogueMultiContextRealtime.TextToDialogueWebsocketFinalMulti PickTextToDialogueWebsocketFinalMulti() => IsTextToDialogueWebsocketFinalMulti
            ? TextToDialogueWebsocketFinalMulti!
            : throw new global::System.InvalidOperationException($"Expected union variant 'TextToDialogueWebsocketFinalMulti' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.TextToDialogueMultiContextRealtime.TextToDialogueWebsocketError? TextToDialogueWebsocketError { get; init; }
#else
        public global::ElevenLabs.TextToDialogueMultiContextRealtime.TextToDialogueWebsocketError? TextToDialogueWebsocketError { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TextToDialogueWebsocketError))]
#endif
        public bool IsTextToDialogueWebsocketError => TextToDialogueWebsocketError != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickTextToDialogueWebsocketError(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.TextToDialogueMultiContextRealtime.TextToDialogueWebsocketError? value)
        {
            value = TextToDialogueWebsocketError;
            return IsTextToDialogueWebsocketError;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::ElevenLabs.TextToDialogueMultiContextRealtime.TextToDialogueWebsocketError PickTextToDialogueWebsocketError() => IsTextToDialogueWebsocketError
            ? TextToDialogueWebsocketError!
            : throw new global::System.InvalidOperationException($"Expected union variant 'TextToDialogueWebsocketError' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ServerEvent(global::ElevenLabs.TextToDialogueMultiContextRealtime.TextToDialogueWebsocketAudioChunkMulti value) => new ServerEvent((global::ElevenLabs.TextToDialogueMultiContextRealtime.TextToDialogueWebsocketAudioChunkMulti?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.TextToDialogueMultiContextRealtime.TextToDialogueWebsocketAudioChunkMulti?(ServerEvent @this) => @this.TextToDialogueWebsocketAudioChunkMulti;

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(global::ElevenLabs.TextToDialogueMultiContextRealtime.TextToDialogueWebsocketAudioChunkMulti? value)
        {
            TextToDialogueWebsocketAudioChunkMulti = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ServerEvent FromTextToDialogueWebsocketAudioChunkMulti(global::ElevenLabs.TextToDialogueMultiContextRealtime.TextToDialogueWebsocketAudioChunkMulti? value) => new ServerEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ServerEvent(global::ElevenLabs.TextToDialogueMultiContextRealtime.TextToDialogueWebsocketFinalAudioForTurnMulti value) => new ServerEvent((global::ElevenLabs.TextToDialogueMultiContextRealtime.TextToDialogueWebsocketFinalAudioForTurnMulti?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.TextToDialogueMultiContextRealtime.TextToDialogueWebsocketFinalAudioForTurnMulti?(ServerEvent @this) => @this.TextToDialogueWebsocketFinalAudioForTurnMulti;

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(global::ElevenLabs.TextToDialogueMultiContextRealtime.TextToDialogueWebsocketFinalAudioForTurnMulti? value)
        {
            TextToDialogueWebsocketFinalAudioForTurnMulti = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ServerEvent FromTextToDialogueWebsocketFinalAudioForTurnMulti(global::ElevenLabs.TextToDialogueMultiContextRealtime.TextToDialogueWebsocketFinalAudioForTurnMulti? value) => new ServerEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ServerEvent(global::ElevenLabs.TextToDialogueMultiContextRealtime.TextToDialogueWebsocketFinalMulti value) => new ServerEvent((global::ElevenLabs.TextToDialogueMultiContextRealtime.TextToDialogueWebsocketFinalMulti?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.TextToDialogueMultiContextRealtime.TextToDialogueWebsocketFinalMulti?(ServerEvent @this) => @this.TextToDialogueWebsocketFinalMulti;

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(global::ElevenLabs.TextToDialogueMultiContextRealtime.TextToDialogueWebsocketFinalMulti? value)
        {
            TextToDialogueWebsocketFinalMulti = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ServerEvent FromTextToDialogueWebsocketFinalMulti(global::ElevenLabs.TextToDialogueMultiContextRealtime.TextToDialogueWebsocketFinalMulti? value) => new ServerEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ServerEvent(global::ElevenLabs.TextToDialogueMultiContextRealtime.TextToDialogueWebsocketError value) => new ServerEvent((global::ElevenLabs.TextToDialogueMultiContextRealtime.TextToDialogueWebsocketError?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.TextToDialogueMultiContextRealtime.TextToDialogueWebsocketError?(ServerEvent @this) => @this.TextToDialogueWebsocketError;

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(global::ElevenLabs.TextToDialogueMultiContextRealtime.TextToDialogueWebsocketError? value)
        {
            TextToDialogueWebsocketError = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ServerEvent FromTextToDialogueWebsocketError(global::ElevenLabs.TextToDialogueMultiContextRealtime.TextToDialogueWebsocketError? value) => new ServerEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(
            global::ElevenLabs.TextToDialogueMultiContextRealtime.TextToDialogueWebsocketAudioChunkMulti? textToDialogueWebsocketAudioChunkMulti,
            global::ElevenLabs.TextToDialogueMultiContextRealtime.TextToDialogueWebsocketFinalAudioForTurnMulti? textToDialogueWebsocketFinalAudioForTurnMulti,
            global::ElevenLabs.TextToDialogueMultiContextRealtime.TextToDialogueWebsocketFinalMulti? textToDialogueWebsocketFinalMulti,
            global::ElevenLabs.TextToDialogueMultiContextRealtime.TextToDialogueWebsocketError? textToDialogueWebsocketError
            )
        {
            TextToDialogueWebsocketAudioChunkMulti = textToDialogueWebsocketAudioChunkMulti;
            TextToDialogueWebsocketFinalAudioForTurnMulti = textToDialogueWebsocketFinalAudioForTurnMulti;
            TextToDialogueWebsocketFinalMulti = textToDialogueWebsocketFinalMulti;
            TextToDialogueWebsocketError = textToDialogueWebsocketError;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            TextToDialogueWebsocketError as object ??
            TextToDialogueWebsocketFinalMulti as object ??
            TextToDialogueWebsocketFinalAudioForTurnMulti as object ??
            TextToDialogueWebsocketAudioChunkMulti as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            TextToDialogueWebsocketAudioChunkMulti?.ToString() ??
            TextToDialogueWebsocketFinalAudioForTurnMulti?.ToString() ??
            TextToDialogueWebsocketFinalMulti?.ToString() ??
            TextToDialogueWebsocketError?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsTextToDialogueWebsocketAudioChunkMulti && !IsTextToDialogueWebsocketFinalAudioForTurnMulti && !IsTextToDialogueWebsocketFinalMulti && !IsTextToDialogueWebsocketError || !IsTextToDialogueWebsocketAudioChunkMulti && IsTextToDialogueWebsocketFinalAudioForTurnMulti && !IsTextToDialogueWebsocketFinalMulti && !IsTextToDialogueWebsocketError || !IsTextToDialogueWebsocketAudioChunkMulti && !IsTextToDialogueWebsocketFinalAudioForTurnMulti && IsTextToDialogueWebsocketFinalMulti && !IsTextToDialogueWebsocketError || !IsTextToDialogueWebsocketAudioChunkMulti && !IsTextToDialogueWebsocketFinalAudioForTurnMulti && !IsTextToDialogueWebsocketFinalMulti && IsTextToDialogueWebsocketError;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::ElevenLabs.TextToDialogueMultiContextRealtime.TextToDialogueWebsocketAudioChunkMulti, TResult>? textToDialogueWebsocketAudioChunkMulti = null,
            global::System.Func<global::ElevenLabs.TextToDialogueMultiContextRealtime.TextToDialogueWebsocketFinalAudioForTurnMulti, TResult>? textToDialogueWebsocketFinalAudioForTurnMulti = null,
            global::System.Func<global::ElevenLabs.TextToDialogueMultiContextRealtime.TextToDialogueWebsocketFinalMulti, TResult>? textToDialogueWebsocketFinalMulti = null,
            global::System.Func<global::ElevenLabs.TextToDialogueMultiContextRealtime.TextToDialogueWebsocketError, TResult>? textToDialogueWebsocketError = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTextToDialogueWebsocketAudioChunkMulti && textToDialogueWebsocketAudioChunkMulti != null)
            {
                return textToDialogueWebsocketAudioChunkMulti(TextToDialogueWebsocketAudioChunkMulti!);
            }
            else if (IsTextToDialogueWebsocketFinalAudioForTurnMulti && textToDialogueWebsocketFinalAudioForTurnMulti != null)
            {
                return textToDialogueWebsocketFinalAudioForTurnMulti(TextToDialogueWebsocketFinalAudioForTurnMulti!);
            }
            else if (IsTextToDialogueWebsocketFinalMulti && textToDialogueWebsocketFinalMulti != null)
            {
                return textToDialogueWebsocketFinalMulti(TextToDialogueWebsocketFinalMulti!);
            }
            else if (IsTextToDialogueWebsocketError && textToDialogueWebsocketError != null)
            {
                return textToDialogueWebsocketError(TextToDialogueWebsocketError!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::ElevenLabs.TextToDialogueMultiContextRealtime.TextToDialogueWebsocketAudioChunkMulti>? textToDialogueWebsocketAudioChunkMulti = null,

            global::System.Action<global::ElevenLabs.TextToDialogueMultiContextRealtime.TextToDialogueWebsocketFinalAudioForTurnMulti>? textToDialogueWebsocketFinalAudioForTurnMulti = null,

            global::System.Action<global::ElevenLabs.TextToDialogueMultiContextRealtime.TextToDialogueWebsocketFinalMulti>? textToDialogueWebsocketFinalMulti = null,

            global::System.Action<global::ElevenLabs.TextToDialogueMultiContextRealtime.TextToDialogueWebsocketError>? textToDialogueWebsocketError = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTextToDialogueWebsocketAudioChunkMulti)
            {
                textToDialogueWebsocketAudioChunkMulti?.Invoke(TextToDialogueWebsocketAudioChunkMulti!);
            }
            else if (IsTextToDialogueWebsocketFinalAudioForTurnMulti)
            {
                textToDialogueWebsocketFinalAudioForTurnMulti?.Invoke(TextToDialogueWebsocketFinalAudioForTurnMulti!);
            }
            else if (IsTextToDialogueWebsocketFinalMulti)
            {
                textToDialogueWebsocketFinalMulti?.Invoke(TextToDialogueWebsocketFinalMulti!);
            }
            else if (IsTextToDialogueWebsocketError)
            {
                textToDialogueWebsocketError?.Invoke(TextToDialogueWebsocketError!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::ElevenLabs.TextToDialogueMultiContextRealtime.TextToDialogueWebsocketAudioChunkMulti>? textToDialogueWebsocketAudioChunkMulti = null,
            global::System.Action<global::ElevenLabs.TextToDialogueMultiContextRealtime.TextToDialogueWebsocketFinalAudioForTurnMulti>? textToDialogueWebsocketFinalAudioForTurnMulti = null,
            global::System.Action<global::ElevenLabs.TextToDialogueMultiContextRealtime.TextToDialogueWebsocketFinalMulti>? textToDialogueWebsocketFinalMulti = null,
            global::System.Action<global::ElevenLabs.TextToDialogueMultiContextRealtime.TextToDialogueWebsocketError>? textToDialogueWebsocketError = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTextToDialogueWebsocketAudioChunkMulti)
            {
                textToDialogueWebsocketAudioChunkMulti?.Invoke(TextToDialogueWebsocketAudioChunkMulti!);
            }
            else if (IsTextToDialogueWebsocketFinalAudioForTurnMulti)
            {
                textToDialogueWebsocketFinalAudioForTurnMulti?.Invoke(TextToDialogueWebsocketFinalAudioForTurnMulti!);
            }
            else if (IsTextToDialogueWebsocketFinalMulti)
            {
                textToDialogueWebsocketFinalMulti?.Invoke(TextToDialogueWebsocketFinalMulti!);
            }
            else if (IsTextToDialogueWebsocketError)
            {
                textToDialogueWebsocketError?.Invoke(TextToDialogueWebsocketError!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                TextToDialogueWebsocketAudioChunkMulti,
                typeof(global::ElevenLabs.TextToDialogueMultiContextRealtime.TextToDialogueWebsocketAudioChunkMulti),
                TextToDialogueWebsocketFinalAudioForTurnMulti,
                typeof(global::ElevenLabs.TextToDialogueMultiContextRealtime.TextToDialogueWebsocketFinalAudioForTurnMulti),
                TextToDialogueWebsocketFinalMulti,
                typeof(global::ElevenLabs.TextToDialogueMultiContextRealtime.TextToDialogueWebsocketFinalMulti),
                TextToDialogueWebsocketError,
                typeof(global::ElevenLabs.TextToDialogueMultiContextRealtime.TextToDialogueWebsocketError),
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
        public bool Equals(ServerEvent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.TextToDialogueMultiContextRealtime.TextToDialogueWebsocketAudioChunkMulti?>.Default.Equals(TextToDialogueWebsocketAudioChunkMulti, other.TextToDialogueWebsocketAudioChunkMulti) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.TextToDialogueMultiContextRealtime.TextToDialogueWebsocketFinalAudioForTurnMulti?>.Default.Equals(TextToDialogueWebsocketFinalAudioForTurnMulti, other.TextToDialogueWebsocketFinalAudioForTurnMulti) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.TextToDialogueMultiContextRealtime.TextToDialogueWebsocketFinalMulti?>.Default.Equals(TextToDialogueWebsocketFinalMulti, other.TextToDialogueWebsocketFinalMulti) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.TextToDialogueMultiContextRealtime.TextToDialogueWebsocketError?>.Default.Equals(TextToDialogueWebsocketError, other.TextToDialogueWebsocketError) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ServerEvent obj1, ServerEvent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ServerEvent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ServerEvent obj1, ServerEvent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ServerEvent o && Equals(o);
        }
    }
}
