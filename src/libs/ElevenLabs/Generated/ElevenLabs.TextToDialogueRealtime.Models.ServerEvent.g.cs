#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace ElevenLabs.TextToDialogueRealtime
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ServerEvent : global::System.IEquatable<ServerEvent>
    {
        /// <summary>
        /// Server chunk containing encoded audio and optional alignment metadata.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.TextToDialogueRealtime.TextToDialogueWebsocketAudioChunk? TextToDialogueWebsocketAudioChunk { get; init; }
#else
        public global::ElevenLabs.TextToDialogueRealtime.TextToDialogueWebsocketAudioChunk? TextToDialogueWebsocketAudioChunk { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TextToDialogueWebsocketAudioChunk))]
#endif
        public bool IsTextToDialogueWebsocketAudioChunk => TextToDialogueWebsocketAudioChunk != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickTextToDialogueWebsocketAudioChunk(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.TextToDialogueRealtime.TextToDialogueWebsocketAudioChunk? value)
        {
            value = TextToDialogueWebsocketAudioChunk;
            return IsTextToDialogueWebsocketAudioChunk;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::ElevenLabs.TextToDialogueRealtime.TextToDialogueWebsocketAudioChunk PickTextToDialogueWebsocketAudioChunk() => IsTextToDialogueWebsocketAudioChunk
            ? TextToDialogueWebsocketAudioChunk!
            : throw new global::System.InvalidOperationException($"Expected union variant 'TextToDialogueWebsocketAudioChunk' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.TextToDialogueRealtime.TextToDialogueWebsocketFinalAudioForTurn? TextToDialogueWebsocketFinalAudioForTurn { get; init; }
#else
        public global::ElevenLabs.TextToDialogueRealtime.TextToDialogueWebsocketFinalAudioForTurn? TextToDialogueWebsocketFinalAudioForTurn { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TextToDialogueWebsocketFinalAudioForTurn))]
#endif
        public bool IsTextToDialogueWebsocketFinalAudioForTurn => TextToDialogueWebsocketFinalAudioForTurn != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickTextToDialogueWebsocketFinalAudioForTurn(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.TextToDialogueRealtime.TextToDialogueWebsocketFinalAudioForTurn? value)
        {
            value = TextToDialogueWebsocketFinalAudioForTurn;
            return IsTextToDialogueWebsocketFinalAudioForTurn;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::ElevenLabs.TextToDialogueRealtime.TextToDialogueWebsocketFinalAudioForTurn PickTextToDialogueWebsocketFinalAudioForTurn() => IsTextToDialogueWebsocketFinalAudioForTurn
            ? TextToDialogueWebsocketFinalAudioForTurn!
            : throw new global::System.InvalidOperationException($"Expected union variant 'TextToDialogueWebsocketFinalAudioForTurn' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.TextToDialogueRealtime.TextToDialogueWebsocketFinal? TextToDialogueWebsocketFinal { get; init; }
#else
        public global::ElevenLabs.TextToDialogueRealtime.TextToDialogueWebsocketFinal? TextToDialogueWebsocketFinal { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TextToDialogueWebsocketFinal))]
#endif
        public bool IsTextToDialogueWebsocketFinal => TextToDialogueWebsocketFinal != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickTextToDialogueWebsocketFinal(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.TextToDialogueRealtime.TextToDialogueWebsocketFinal? value)
        {
            value = TextToDialogueWebsocketFinal;
            return IsTextToDialogueWebsocketFinal;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::ElevenLabs.TextToDialogueRealtime.TextToDialogueWebsocketFinal PickTextToDialogueWebsocketFinal() => IsTextToDialogueWebsocketFinal
            ? TextToDialogueWebsocketFinal!
            : throw new global::System.InvalidOperationException($"Expected union variant 'TextToDialogueWebsocketFinal' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.TextToDialogueRealtime.TextToDialogueWebsocketError? TextToDialogueWebsocketError { get; init; }
#else
        public global::ElevenLabs.TextToDialogueRealtime.TextToDialogueWebsocketError? TextToDialogueWebsocketError { get; }
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
            out global::ElevenLabs.TextToDialogueRealtime.TextToDialogueWebsocketError? value)
        {
            value = TextToDialogueWebsocketError;
            return IsTextToDialogueWebsocketError;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::ElevenLabs.TextToDialogueRealtime.TextToDialogueWebsocketError PickTextToDialogueWebsocketError() => IsTextToDialogueWebsocketError
            ? TextToDialogueWebsocketError!
            : throw new global::System.InvalidOperationException($"Expected union variant 'TextToDialogueWebsocketError' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ServerEvent(global::ElevenLabs.TextToDialogueRealtime.TextToDialogueWebsocketAudioChunk value) => new ServerEvent((global::ElevenLabs.TextToDialogueRealtime.TextToDialogueWebsocketAudioChunk?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.TextToDialogueRealtime.TextToDialogueWebsocketAudioChunk?(ServerEvent @this) => @this.TextToDialogueWebsocketAudioChunk;

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(global::ElevenLabs.TextToDialogueRealtime.TextToDialogueWebsocketAudioChunk? value)
        {
            TextToDialogueWebsocketAudioChunk = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ServerEvent FromTextToDialogueWebsocketAudioChunk(global::ElevenLabs.TextToDialogueRealtime.TextToDialogueWebsocketAudioChunk? value) => new ServerEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ServerEvent(global::ElevenLabs.TextToDialogueRealtime.TextToDialogueWebsocketFinalAudioForTurn value) => new ServerEvent((global::ElevenLabs.TextToDialogueRealtime.TextToDialogueWebsocketFinalAudioForTurn?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.TextToDialogueRealtime.TextToDialogueWebsocketFinalAudioForTurn?(ServerEvent @this) => @this.TextToDialogueWebsocketFinalAudioForTurn;

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(global::ElevenLabs.TextToDialogueRealtime.TextToDialogueWebsocketFinalAudioForTurn? value)
        {
            TextToDialogueWebsocketFinalAudioForTurn = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ServerEvent FromTextToDialogueWebsocketFinalAudioForTurn(global::ElevenLabs.TextToDialogueRealtime.TextToDialogueWebsocketFinalAudioForTurn? value) => new ServerEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ServerEvent(global::ElevenLabs.TextToDialogueRealtime.TextToDialogueWebsocketFinal value) => new ServerEvent((global::ElevenLabs.TextToDialogueRealtime.TextToDialogueWebsocketFinal?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.TextToDialogueRealtime.TextToDialogueWebsocketFinal?(ServerEvent @this) => @this.TextToDialogueWebsocketFinal;

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(global::ElevenLabs.TextToDialogueRealtime.TextToDialogueWebsocketFinal? value)
        {
            TextToDialogueWebsocketFinal = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ServerEvent FromTextToDialogueWebsocketFinal(global::ElevenLabs.TextToDialogueRealtime.TextToDialogueWebsocketFinal? value) => new ServerEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ServerEvent(global::ElevenLabs.TextToDialogueRealtime.TextToDialogueWebsocketError value) => new ServerEvent((global::ElevenLabs.TextToDialogueRealtime.TextToDialogueWebsocketError?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.TextToDialogueRealtime.TextToDialogueWebsocketError?(ServerEvent @this) => @this.TextToDialogueWebsocketError;

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(global::ElevenLabs.TextToDialogueRealtime.TextToDialogueWebsocketError? value)
        {
            TextToDialogueWebsocketError = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ServerEvent FromTextToDialogueWebsocketError(global::ElevenLabs.TextToDialogueRealtime.TextToDialogueWebsocketError? value) => new ServerEvent(value);

        /// <summary>
        /// 
        /// </summary>
        public ServerEvent(
            global::ElevenLabs.TextToDialogueRealtime.TextToDialogueWebsocketAudioChunk? textToDialogueWebsocketAudioChunk,
            global::ElevenLabs.TextToDialogueRealtime.TextToDialogueWebsocketFinalAudioForTurn? textToDialogueWebsocketFinalAudioForTurn,
            global::ElevenLabs.TextToDialogueRealtime.TextToDialogueWebsocketFinal? textToDialogueWebsocketFinal,
            global::ElevenLabs.TextToDialogueRealtime.TextToDialogueWebsocketError? textToDialogueWebsocketError
            )
        {
            TextToDialogueWebsocketAudioChunk = textToDialogueWebsocketAudioChunk;
            TextToDialogueWebsocketFinalAudioForTurn = textToDialogueWebsocketFinalAudioForTurn;
            TextToDialogueWebsocketFinal = textToDialogueWebsocketFinal;
            TextToDialogueWebsocketError = textToDialogueWebsocketError;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            TextToDialogueWebsocketError as object ??
            TextToDialogueWebsocketFinal as object ??
            TextToDialogueWebsocketFinalAudioForTurn as object ??
            TextToDialogueWebsocketAudioChunk as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            TextToDialogueWebsocketAudioChunk?.ToString() ??
            TextToDialogueWebsocketFinalAudioForTurn?.ToString() ??
            TextToDialogueWebsocketFinal?.ToString() ??
            TextToDialogueWebsocketError?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsTextToDialogueWebsocketAudioChunk && !IsTextToDialogueWebsocketFinalAudioForTurn && !IsTextToDialogueWebsocketFinal && !IsTextToDialogueWebsocketError || !IsTextToDialogueWebsocketAudioChunk && IsTextToDialogueWebsocketFinalAudioForTurn && !IsTextToDialogueWebsocketFinal && !IsTextToDialogueWebsocketError || !IsTextToDialogueWebsocketAudioChunk && !IsTextToDialogueWebsocketFinalAudioForTurn && IsTextToDialogueWebsocketFinal && !IsTextToDialogueWebsocketError || !IsTextToDialogueWebsocketAudioChunk && !IsTextToDialogueWebsocketFinalAudioForTurn && !IsTextToDialogueWebsocketFinal && IsTextToDialogueWebsocketError;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::ElevenLabs.TextToDialogueRealtime.TextToDialogueWebsocketAudioChunk, TResult>? textToDialogueWebsocketAudioChunk = null,
            global::System.Func<global::ElevenLabs.TextToDialogueRealtime.TextToDialogueWebsocketFinalAudioForTurn, TResult>? textToDialogueWebsocketFinalAudioForTurn = null,
            global::System.Func<global::ElevenLabs.TextToDialogueRealtime.TextToDialogueWebsocketFinal, TResult>? textToDialogueWebsocketFinal = null,
            global::System.Func<global::ElevenLabs.TextToDialogueRealtime.TextToDialogueWebsocketError, TResult>? textToDialogueWebsocketError = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTextToDialogueWebsocketAudioChunk && textToDialogueWebsocketAudioChunk != null)
            {
                return textToDialogueWebsocketAudioChunk(TextToDialogueWebsocketAudioChunk!);
            }
            else if (IsTextToDialogueWebsocketFinalAudioForTurn && textToDialogueWebsocketFinalAudioForTurn != null)
            {
                return textToDialogueWebsocketFinalAudioForTurn(TextToDialogueWebsocketFinalAudioForTurn!);
            }
            else if (IsTextToDialogueWebsocketFinal && textToDialogueWebsocketFinal != null)
            {
                return textToDialogueWebsocketFinal(TextToDialogueWebsocketFinal!);
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
            global::System.Action<global::ElevenLabs.TextToDialogueRealtime.TextToDialogueWebsocketAudioChunk>? textToDialogueWebsocketAudioChunk = null,

            global::System.Action<global::ElevenLabs.TextToDialogueRealtime.TextToDialogueWebsocketFinalAudioForTurn>? textToDialogueWebsocketFinalAudioForTurn = null,

            global::System.Action<global::ElevenLabs.TextToDialogueRealtime.TextToDialogueWebsocketFinal>? textToDialogueWebsocketFinal = null,

            global::System.Action<global::ElevenLabs.TextToDialogueRealtime.TextToDialogueWebsocketError>? textToDialogueWebsocketError = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTextToDialogueWebsocketAudioChunk)
            {
                textToDialogueWebsocketAudioChunk?.Invoke(TextToDialogueWebsocketAudioChunk!);
            }
            else if (IsTextToDialogueWebsocketFinalAudioForTurn)
            {
                textToDialogueWebsocketFinalAudioForTurn?.Invoke(TextToDialogueWebsocketFinalAudioForTurn!);
            }
            else if (IsTextToDialogueWebsocketFinal)
            {
                textToDialogueWebsocketFinal?.Invoke(TextToDialogueWebsocketFinal!);
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
            global::System.Action<global::ElevenLabs.TextToDialogueRealtime.TextToDialogueWebsocketAudioChunk>? textToDialogueWebsocketAudioChunk = null,
            global::System.Action<global::ElevenLabs.TextToDialogueRealtime.TextToDialogueWebsocketFinalAudioForTurn>? textToDialogueWebsocketFinalAudioForTurn = null,
            global::System.Action<global::ElevenLabs.TextToDialogueRealtime.TextToDialogueWebsocketFinal>? textToDialogueWebsocketFinal = null,
            global::System.Action<global::ElevenLabs.TextToDialogueRealtime.TextToDialogueWebsocketError>? textToDialogueWebsocketError = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTextToDialogueWebsocketAudioChunk)
            {
                textToDialogueWebsocketAudioChunk?.Invoke(TextToDialogueWebsocketAudioChunk!);
            }
            else if (IsTextToDialogueWebsocketFinalAudioForTurn)
            {
                textToDialogueWebsocketFinalAudioForTurn?.Invoke(TextToDialogueWebsocketFinalAudioForTurn!);
            }
            else if (IsTextToDialogueWebsocketFinal)
            {
                textToDialogueWebsocketFinal?.Invoke(TextToDialogueWebsocketFinal!);
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
                TextToDialogueWebsocketAudioChunk,
                typeof(global::ElevenLabs.TextToDialogueRealtime.TextToDialogueWebsocketAudioChunk),
                TextToDialogueWebsocketFinalAudioForTurn,
                typeof(global::ElevenLabs.TextToDialogueRealtime.TextToDialogueWebsocketFinalAudioForTurn),
                TextToDialogueWebsocketFinal,
                typeof(global::ElevenLabs.TextToDialogueRealtime.TextToDialogueWebsocketFinal),
                TextToDialogueWebsocketError,
                typeof(global::ElevenLabs.TextToDialogueRealtime.TextToDialogueWebsocketError),
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
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.TextToDialogueRealtime.TextToDialogueWebsocketAudioChunk?>.Default.Equals(TextToDialogueWebsocketAudioChunk, other.TextToDialogueWebsocketAudioChunk) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.TextToDialogueRealtime.TextToDialogueWebsocketFinalAudioForTurn?>.Default.Equals(TextToDialogueWebsocketFinalAudioForTurn, other.TextToDialogueWebsocketFinalAudioForTurn) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.TextToDialogueRealtime.TextToDialogueWebsocketFinal?>.Default.Equals(TextToDialogueWebsocketFinal, other.TextToDialogueWebsocketFinal) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.TextToDialogueRealtime.TextToDialogueWebsocketError?>.Default.Equals(TextToDialogueWebsocketError, other.TextToDialogueWebsocketError) 
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
