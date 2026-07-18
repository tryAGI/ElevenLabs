#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct OrderItemRequestOutput : global::System.IEquatable<OrderItemRequestOutput>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::ElevenLabs.OrderItemRequestOutputDiscriminatorKind? Kind { get; }

        /// <summary>
        /// Example: {"captions_sdh":false,"destination_languages":["hi","fr-FR","de"],"include_captions":true,"include_source_captions":false,"instructions":"Voices don\u0027t need to match the originals, prioritize native-sounding voices","kind":"dub","media_id":"prodmedia_01jgatk6h0fwxrtbjade61yqhx","source_language":"en"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.DubOrderItemRequest? Dub { get; init; }
#else
        public global::ElevenLabs.DubOrderItemRequest? Dub { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Dub))]
#endif
        public bool IsDub => Dub != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickDub(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.DubOrderItemRequest? value)
        {
            value = Dub;
            return IsDub;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::ElevenLabs.DubOrderItemRequest PickDub() => IsDub
            ? Dub!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Dub' but the value was {ToString()}.");

        /// <summary>
        /// Example: {"cue_options":{"max_chars_per_line":42,"max_duration_ms":7000,"max_lines_per_cue":2,"min_duration_ms":1000},"destination_languages":["hi","fr-FR","de"],"instructions":"Keep reading speed moderate; preserve humor in idioms.","kind":"subtitles","media_ids":["prodmedia_01jgatk6h0fwxrtbjade61yqhx","prodmedia_01jgb2zd68f8f9tfvbb968wb8z"],"sdh":false,"source_language":"en"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.SubtitleOrderItemRequest? Subtitles { get; init; }
#else
        public global::ElevenLabs.SubtitleOrderItemRequest? Subtitles { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Subtitles))]
#endif
        public bool IsSubtitles => Subtitles != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickSubtitles(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.SubtitleOrderItemRequest? value)
        {
            value = Subtitles;
            return IsSubtitles;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::ElevenLabs.SubtitleOrderItemRequest PickSubtitles() => IsSubtitles
            ? Subtitles!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Subtitles' but the value was {ToString()}.");

        /// <summary>
        /// Example: {"instructions":"Use speaker labels where possible.","kind":"transcription","media_ids":["prodmedia_01jgatk6h0fwxrtbjade61yqhx","prodmedia_01jgb2zd68f8f9tfvbb968wb8z"],"source_language":"en","verbatim":false}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.TranscriptionOrderItemRequest? Transcription { get; init; }
#else
        public global::ElevenLabs.TranscriptionOrderItemRequest? Transcription { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Transcription))]
#endif
        public bool IsTranscription => Transcription != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickTranscription(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.TranscriptionOrderItemRequest? value)
        {
            value = Transcription;
            return IsTranscription;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::ElevenLabs.TranscriptionOrderItemRequest PickTranscription() => IsTranscription
            ? Transcription!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Transcription' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OrderItemRequestOutput(global::ElevenLabs.DubOrderItemRequest value) => new OrderItemRequestOutput((global::ElevenLabs.DubOrderItemRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.DubOrderItemRequest?(OrderItemRequestOutput @this) => @this.Dub;

        /// <summary>
        /// 
        /// </summary>
        public OrderItemRequestOutput(global::ElevenLabs.DubOrderItemRequest? value)
        {
            Dub = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static OrderItemRequestOutput FromDub(global::ElevenLabs.DubOrderItemRequest? value) => new OrderItemRequestOutput(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OrderItemRequestOutput(global::ElevenLabs.SubtitleOrderItemRequest value) => new OrderItemRequestOutput((global::ElevenLabs.SubtitleOrderItemRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.SubtitleOrderItemRequest?(OrderItemRequestOutput @this) => @this.Subtitles;

        /// <summary>
        /// 
        /// </summary>
        public OrderItemRequestOutput(global::ElevenLabs.SubtitleOrderItemRequest? value)
        {
            Subtitles = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static OrderItemRequestOutput FromSubtitles(global::ElevenLabs.SubtitleOrderItemRequest? value) => new OrderItemRequestOutput(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OrderItemRequestOutput(global::ElevenLabs.TranscriptionOrderItemRequest value) => new OrderItemRequestOutput((global::ElevenLabs.TranscriptionOrderItemRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.TranscriptionOrderItemRequest?(OrderItemRequestOutput @this) => @this.Transcription;

        /// <summary>
        /// 
        /// </summary>
        public OrderItemRequestOutput(global::ElevenLabs.TranscriptionOrderItemRequest? value)
        {
            Transcription = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static OrderItemRequestOutput FromTranscription(global::ElevenLabs.TranscriptionOrderItemRequest? value) => new OrderItemRequestOutput(value);

        /// <summary>
        /// 
        /// </summary>
        public OrderItemRequestOutput(
            global::ElevenLabs.OrderItemRequestOutputDiscriminatorKind? kind,
            global::ElevenLabs.DubOrderItemRequest? dub,
            global::ElevenLabs.SubtitleOrderItemRequest? subtitles,
            global::ElevenLabs.TranscriptionOrderItemRequest? transcription
            )
        {
            Kind = kind;

            Dub = dub;
            Subtitles = subtitles;
            Transcription = transcription;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Transcription as object ??
            Subtitles as object ??
            Dub as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Dub?.ToString() ??
            Subtitles?.ToString() ??
            Transcription?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsDub && !IsSubtitles && !IsTranscription || !IsDub && IsSubtitles && !IsTranscription || !IsDub && !IsSubtitles && IsTranscription;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::ElevenLabs.DubOrderItemRequest, TResult>? dub = null,
            global::System.Func<global::ElevenLabs.SubtitleOrderItemRequest, TResult>? subtitles = null,
            global::System.Func<global::ElevenLabs.TranscriptionOrderItemRequest, TResult>? transcription = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsDub && dub != null)
            {
                return dub(Dub!);
            }
            else if (IsSubtitles && subtitles != null)
            {
                return subtitles(Subtitles!);
            }
            else if (IsTranscription && transcription != null)
            {
                return transcription(Transcription!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::ElevenLabs.DubOrderItemRequest>? dub = null,

            global::System.Action<global::ElevenLabs.SubtitleOrderItemRequest>? subtitles = null,

            global::System.Action<global::ElevenLabs.TranscriptionOrderItemRequest>? transcription = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsDub)
            {
                dub?.Invoke(Dub!);
            }
            else if (IsSubtitles)
            {
                subtitles?.Invoke(Subtitles!);
            }
            else if (IsTranscription)
            {
                transcription?.Invoke(Transcription!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::ElevenLabs.DubOrderItemRequest>? dub = null,
            global::System.Action<global::ElevenLabs.SubtitleOrderItemRequest>? subtitles = null,
            global::System.Action<global::ElevenLabs.TranscriptionOrderItemRequest>? transcription = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsDub)
            {
                dub?.Invoke(Dub!);
            }
            else if (IsSubtitles)
            {
                subtitles?.Invoke(Subtitles!);
            }
            else if (IsTranscription)
            {
                transcription?.Invoke(Transcription!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Dub,
                typeof(global::ElevenLabs.DubOrderItemRequest),
                Subtitles,
                typeof(global::ElevenLabs.SubtitleOrderItemRequest),
                Transcription,
                typeof(global::ElevenLabs.TranscriptionOrderItemRequest),
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
        public bool Equals(OrderItemRequestOutput other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.DubOrderItemRequest?>.Default.Equals(Dub, other.Dub) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.SubtitleOrderItemRequest?>.Default.Equals(Subtitles, other.Subtitles) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.TranscriptionOrderItemRequest?>.Default.Equals(Transcription, other.Transcription) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(OrderItemRequestOutput obj1, OrderItemRequestOutput obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<OrderItemRequestOutput>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(OrderItemRequestOutput obj1, OrderItemRequestOutput obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is OrderItemRequestOutput o && Equals(o);
        }
    }
}
