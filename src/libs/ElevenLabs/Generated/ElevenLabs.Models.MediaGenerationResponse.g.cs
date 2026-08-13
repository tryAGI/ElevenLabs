#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct MediaGenerationResponse : global::System.IEquatable<MediaGenerationResponse>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::ElevenLabs.MediaGenerationResponseDiscriminatorStatus? Status { get; }

        /// <summary>
        /// A media generation that has not finished yet.<br/>
        /// Example: {"id":"JWr5N6X9ZTqf8jD2LmQb","status":"generating"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.MediaGenerationInProgressResponse? Generating { get; init; }
#else
        public global::ElevenLabs.MediaGenerationInProgressResponse? Generating { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Generating))]
#endif
        public bool IsGenerating => Generating != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickGenerating(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.MediaGenerationInProgressResponse? value)
        {
            value = Generating;
            return IsGenerating;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::ElevenLabs.MediaGenerationInProgressResponse PickGenerating() => IsGenerating
            ? Generating!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Generating' but the value was {ToString()}.");

        /// <summary>
        /// A completed media generation and its output.<br/>
        /// Example: {"content_mime_type":"video/mp4","content_url":"https://storage.googleapis.com/generations/JWr5N6X9ZTqf8jD2LmQb","id":"JWr5N6X9ZTqf8jD2LmQb","status":"completed"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.MediaGenerationCompletedResponse? Completed { get; init; }
#else
        public global::ElevenLabs.MediaGenerationCompletedResponse? Completed { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Completed))]
#endif
        public bool IsCompleted => Completed != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickCompleted(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.MediaGenerationCompletedResponse? value)
        {
            value = Completed;
            return IsCompleted;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::ElevenLabs.MediaGenerationCompletedResponse PickCompleted() => IsCompleted
            ? Completed!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Completed' but the value was {ToString()}.");

        /// <summary>
        /// A failed media generation and why it failed.<br/>
        /// Example: {"error_message":"Timed out while processing. You were not charged for this generation.","failure_reason":"timeout","id":"JWr5N6X9ZTqf8jD2LmQb","status":"failed"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.MediaGenerationFailedResponse? Failed { get; init; }
#else
        public global::ElevenLabs.MediaGenerationFailedResponse? Failed { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Failed))]
#endif
        public bool IsFailed => Failed != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickFailed(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.MediaGenerationFailedResponse? value)
        {
            value = Failed;
            return IsFailed;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::ElevenLabs.MediaGenerationFailedResponse PickFailed() => IsFailed
            ? Failed!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Failed' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MediaGenerationResponse(global::ElevenLabs.MediaGenerationInProgressResponse value) => new MediaGenerationResponse((global::ElevenLabs.MediaGenerationInProgressResponse?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.MediaGenerationInProgressResponse?(MediaGenerationResponse @this) => @this.Generating;

        /// <summary>
        /// 
        /// </summary>
        public MediaGenerationResponse(global::ElevenLabs.MediaGenerationInProgressResponse? value)
        {
            Generating = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static MediaGenerationResponse FromGenerating(global::ElevenLabs.MediaGenerationInProgressResponse? value) => new MediaGenerationResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MediaGenerationResponse(global::ElevenLabs.MediaGenerationCompletedResponse value) => new MediaGenerationResponse((global::ElevenLabs.MediaGenerationCompletedResponse?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.MediaGenerationCompletedResponse?(MediaGenerationResponse @this) => @this.Completed;

        /// <summary>
        /// 
        /// </summary>
        public MediaGenerationResponse(global::ElevenLabs.MediaGenerationCompletedResponse? value)
        {
            Completed = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static MediaGenerationResponse FromCompleted(global::ElevenLabs.MediaGenerationCompletedResponse? value) => new MediaGenerationResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MediaGenerationResponse(global::ElevenLabs.MediaGenerationFailedResponse value) => new MediaGenerationResponse((global::ElevenLabs.MediaGenerationFailedResponse?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.MediaGenerationFailedResponse?(MediaGenerationResponse @this) => @this.Failed;

        /// <summary>
        /// 
        /// </summary>
        public MediaGenerationResponse(global::ElevenLabs.MediaGenerationFailedResponse? value)
        {
            Failed = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static MediaGenerationResponse FromFailed(global::ElevenLabs.MediaGenerationFailedResponse? value) => new MediaGenerationResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public MediaGenerationResponse(
            global::ElevenLabs.MediaGenerationResponseDiscriminatorStatus? status,
            global::ElevenLabs.MediaGenerationInProgressResponse? generating,
            global::ElevenLabs.MediaGenerationCompletedResponse? completed,
            global::ElevenLabs.MediaGenerationFailedResponse? failed
            )
        {
            Status = status;

            Generating = generating;
            Completed = completed;
            Failed = failed;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Failed as object ??
            Completed as object ??
            Generating as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Generating?.ToString() ??
            Completed?.ToString() ??
            Failed?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsGenerating && !IsCompleted && !IsFailed || !IsGenerating && IsCompleted && !IsFailed || !IsGenerating && !IsCompleted && IsFailed;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::ElevenLabs.MediaGenerationInProgressResponse, TResult>? generating = null,
            global::System.Func<global::ElevenLabs.MediaGenerationCompletedResponse, TResult>? completed = null,
            global::System.Func<global::ElevenLabs.MediaGenerationFailedResponse, TResult>? failed = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsGenerating && generating != null)
            {
                return generating(Generating!);
            }
            else if (IsCompleted && completed != null)
            {
                return completed(Completed!);
            }
            else if (IsFailed && failed != null)
            {
                return failed(Failed!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::ElevenLabs.MediaGenerationInProgressResponse>? generating = null,

            global::System.Action<global::ElevenLabs.MediaGenerationCompletedResponse>? completed = null,

            global::System.Action<global::ElevenLabs.MediaGenerationFailedResponse>? failed = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsGenerating)
            {
                generating?.Invoke(Generating!);
            }
            else if (IsCompleted)
            {
                completed?.Invoke(Completed!);
            }
            else if (IsFailed)
            {
                failed?.Invoke(Failed!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::ElevenLabs.MediaGenerationInProgressResponse>? generating = null,
            global::System.Action<global::ElevenLabs.MediaGenerationCompletedResponse>? completed = null,
            global::System.Action<global::ElevenLabs.MediaGenerationFailedResponse>? failed = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsGenerating)
            {
                generating?.Invoke(Generating!);
            }
            else if (IsCompleted)
            {
                completed?.Invoke(Completed!);
            }
            else if (IsFailed)
            {
                failed?.Invoke(Failed!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Generating,
                typeof(global::ElevenLabs.MediaGenerationInProgressResponse),
                Completed,
                typeof(global::ElevenLabs.MediaGenerationCompletedResponse),
                Failed,
                typeof(global::ElevenLabs.MediaGenerationFailedResponse),
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
        public bool Equals(MediaGenerationResponse other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.MediaGenerationInProgressResponse?>.Default.Equals(Generating, other.Generating) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.MediaGenerationCompletedResponse?>.Default.Equals(Completed, other.Completed) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.MediaGenerationFailedResponse?>.Default.Equals(Failed, other.Failed) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(MediaGenerationResponse obj1, MediaGenerationResponse obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<MediaGenerationResponse>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(MediaGenerationResponse obj1, MediaGenerationResponse obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is MediaGenerationResponse o && Equals(o);
        }
    }
}
