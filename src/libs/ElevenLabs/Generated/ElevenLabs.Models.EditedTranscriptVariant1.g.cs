#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct EditedTranscriptVariant1 : global::System.IEquatable<EditedTranscriptVariant1>
    {
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SpeechToTextChunkResponseModelEditedTranscriptVariant1DiscriminatorKind? Kind { get; }

        /// <summary>
        /// A transcript produced by the optional transcript edit (text only, untimed).
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.EditedTranscript? Transcript { get; init; }
#else
        public global::ElevenLabs.EditedTranscript? Transcript { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Transcript))]
#endif
        public bool IsTranscript => Transcript != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickTranscript(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.EditedTranscript? value)
        {
            value = Transcript;
            return IsTranscript;
        }

        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.EditedTranscript PickTranscript() => IsTranscript
            ? Transcript!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Transcript' but the value was {ToString()}.");

        /// <summary>
        /// An error returned in place of an edited transcript when the edit could not be produced.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.TranscriptEditError? Error { get; init; }
#else
        public global::ElevenLabs.TranscriptEditError? Error { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Error))]
#endif
        public bool IsError => Error != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickError(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.TranscriptEditError? value)
        {
            value = Error;
            return IsError;
        }

        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TranscriptEditError PickError() => IsError
            ? Error!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Error' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator EditedTranscriptVariant1(global::ElevenLabs.EditedTranscript value) => new EditedTranscriptVariant1((global::ElevenLabs.EditedTranscript?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::ElevenLabs.EditedTranscript?(EditedTranscriptVariant1 @this) => @this.Transcript;

        /// <summary>
        ///
        /// </summary>
        public EditedTranscriptVariant1(global::ElevenLabs.EditedTranscript? value)
        {
            Transcript = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static EditedTranscriptVariant1 FromTranscript(global::ElevenLabs.EditedTranscript? value) => new EditedTranscriptVariant1(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator EditedTranscriptVariant1(global::ElevenLabs.TranscriptEditError value) => new EditedTranscriptVariant1((global::ElevenLabs.TranscriptEditError?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::ElevenLabs.TranscriptEditError?(EditedTranscriptVariant1 @this) => @this.Error;

        /// <summary>
        ///
        /// </summary>
        public EditedTranscriptVariant1(global::ElevenLabs.TranscriptEditError? value)
        {
            Error = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static EditedTranscriptVariant1 FromError(global::ElevenLabs.TranscriptEditError? value) => new EditedTranscriptVariant1(value);

        /// <summary>
        ///
        /// </summary>
        public EditedTranscriptVariant1(
            global::ElevenLabs.SpeechToTextChunkResponseModelEditedTranscriptVariant1DiscriminatorKind? kind,
            global::ElevenLabs.EditedTranscript? transcript,
            global::ElevenLabs.TranscriptEditError? error
            )
        {
            Kind = kind;

            Transcript = transcript;
            Error = error;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Error as object ??
            Transcript as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Transcript?.ToString() ??
            Error?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsTranscript && !IsError || !IsTranscript && IsError;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::ElevenLabs.EditedTranscript, TResult>? transcript = null,
            global::System.Func<global::ElevenLabs.TranscriptEditError, TResult>? error = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTranscript && transcript != null)
            {
                return transcript(Transcript!);
            }
            else if (IsError && error != null)
            {
                return error(Error!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::ElevenLabs.EditedTranscript>? transcript = null,

            global::System.Action<global::ElevenLabs.TranscriptEditError>? error = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTranscript)
            {
                transcript?.Invoke(Transcript!);
            }
            else if (IsError)
            {
                error?.Invoke(Error!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::ElevenLabs.EditedTranscript>? transcript = null,
            global::System.Action<global::ElevenLabs.TranscriptEditError>? error = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTranscript)
            {
                transcript?.Invoke(Transcript!);
            }
            else if (IsError)
            {
                error?.Invoke(Error!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Transcript,
                typeof(global::ElevenLabs.EditedTranscript),
                Error,
                typeof(global::ElevenLabs.TranscriptEditError),
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
        public bool Equals(EditedTranscriptVariant1 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.EditedTranscript?>.Default.Equals(Transcript, other.Transcript) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.TranscriptEditError?>.Default.Equals(Error, other.Error)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(EditedTranscriptVariant1 obj1, EditedTranscriptVariant1 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<EditedTranscriptVariant1>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(EditedTranscriptVariant1 obj1, EditedTranscriptVariant1 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is EditedTranscriptVariant1 o && Equals(o);
        }
    }
}
