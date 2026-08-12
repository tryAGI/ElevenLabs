#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct TextToSpeechGenerationRequest : global::System.IEquatable<TextToSpeechGenerationRequest>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::ElevenLabs.TextToSpeechGenerationRequestDiscriminatorModelId? ModelId { get; }

        /// <summary>
        /// Request body for the ElevenLabs Flash v2.5 TTS model.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.ElevenFlashV25Request? ElevenFlashV25 { get; init; }
#else
        public global::ElevenLabs.ElevenFlashV25Request? ElevenFlashV25 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ElevenFlashV25))]
#endif
        public bool IsElevenFlashV25 => ElevenFlashV25 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickElevenFlashV25(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.ElevenFlashV25Request? value)
        {
            value = ElevenFlashV25;
            return IsElevenFlashV25;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::ElevenLabs.ElevenFlashV25Request PickElevenFlashV25() => IsElevenFlashV25
            ? ElevenFlashV25!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ElevenFlashV25' but the value was {ToString()}.");

        /// <summary>
        /// Request body for the ElevenLabs Multilingual v2 TTS model.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.ElevenMultilingualV2Request? ElevenMultilingualV2 { get; init; }
#else
        public global::ElevenLabs.ElevenMultilingualV2Request? ElevenMultilingualV2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ElevenMultilingualV2))]
#endif
        public bool IsElevenMultilingualV2 => ElevenMultilingualV2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickElevenMultilingualV2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.ElevenMultilingualV2Request? value)
        {
            value = ElevenMultilingualV2;
            return IsElevenMultilingualV2;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::ElevenLabs.ElevenMultilingualV2Request PickElevenMultilingualV2() => IsElevenMultilingualV2
            ? ElevenMultilingualV2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ElevenMultilingualV2' but the value was {ToString()}.");

        /// <summary>
        /// Request body for the Eleven v3 TTS model.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.ElevenV3Request? ElevenV3 { get; init; }
#else
        public global::ElevenLabs.ElevenV3Request? ElevenV3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ElevenV3))]
#endif
        public bool IsElevenV3 => ElevenV3 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickElevenV3(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.ElevenV3Request? value)
        {
            value = ElevenV3;
            return IsElevenV3;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::ElevenLabs.ElevenV3Request PickElevenV3() => IsElevenV3
            ? ElevenV3!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ElevenV3' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TextToSpeechGenerationRequest(global::ElevenLabs.ElevenFlashV25Request value) => new TextToSpeechGenerationRequest((global::ElevenLabs.ElevenFlashV25Request?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.ElevenFlashV25Request?(TextToSpeechGenerationRequest @this) => @this.ElevenFlashV25;

        /// <summary>
        /// 
        /// </summary>
        public TextToSpeechGenerationRequest(global::ElevenLabs.ElevenFlashV25Request? value)
        {
            ElevenFlashV25 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static TextToSpeechGenerationRequest FromElevenFlashV25(global::ElevenLabs.ElevenFlashV25Request? value) => new TextToSpeechGenerationRequest(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TextToSpeechGenerationRequest(global::ElevenLabs.ElevenMultilingualV2Request value) => new TextToSpeechGenerationRequest((global::ElevenLabs.ElevenMultilingualV2Request?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.ElevenMultilingualV2Request?(TextToSpeechGenerationRequest @this) => @this.ElevenMultilingualV2;

        /// <summary>
        /// 
        /// </summary>
        public TextToSpeechGenerationRequest(global::ElevenLabs.ElevenMultilingualV2Request? value)
        {
            ElevenMultilingualV2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static TextToSpeechGenerationRequest FromElevenMultilingualV2(global::ElevenLabs.ElevenMultilingualV2Request? value) => new TextToSpeechGenerationRequest(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TextToSpeechGenerationRequest(global::ElevenLabs.ElevenV3Request value) => new TextToSpeechGenerationRequest((global::ElevenLabs.ElevenV3Request?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.ElevenV3Request?(TextToSpeechGenerationRequest @this) => @this.ElevenV3;

        /// <summary>
        /// 
        /// </summary>
        public TextToSpeechGenerationRequest(global::ElevenLabs.ElevenV3Request? value)
        {
            ElevenV3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static TextToSpeechGenerationRequest FromElevenV3(global::ElevenLabs.ElevenV3Request? value) => new TextToSpeechGenerationRequest(value);

        /// <summary>
        /// 
        /// </summary>
        public TextToSpeechGenerationRequest(
            global::ElevenLabs.TextToSpeechGenerationRequestDiscriminatorModelId? modelId,
            global::ElevenLabs.ElevenFlashV25Request? elevenFlashV25,
            global::ElevenLabs.ElevenMultilingualV2Request? elevenMultilingualV2,
            global::ElevenLabs.ElevenV3Request? elevenV3
            )
        {
            ModelId = modelId;

            ElevenFlashV25 = elevenFlashV25;
            ElevenMultilingualV2 = elevenMultilingualV2;
            ElevenV3 = elevenV3;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ElevenV3 as object ??
            ElevenMultilingualV2 as object ??
            ElevenFlashV25 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ElevenFlashV25?.ToString() ??
            ElevenMultilingualV2?.ToString() ??
            ElevenV3?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsElevenFlashV25 && !IsElevenMultilingualV2 && !IsElevenV3 || !IsElevenFlashV25 && IsElevenMultilingualV2 && !IsElevenV3 || !IsElevenFlashV25 && !IsElevenMultilingualV2 && IsElevenV3;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::ElevenLabs.ElevenFlashV25Request, TResult>? elevenFlashV25 = null,
            global::System.Func<global::ElevenLabs.ElevenMultilingualV2Request, TResult>? elevenMultilingualV2 = null,
            global::System.Func<global::ElevenLabs.ElevenV3Request, TResult>? elevenV3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsElevenFlashV25 && elevenFlashV25 != null)
            {
                return elevenFlashV25(ElevenFlashV25!);
            }
            else if (IsElevenMultilingualV2 && elevenMultilingualV2 != null)
            {
                return elevenMultilingualV2(ElevenMultilingualV2!);
            }
            else if (IsElevenV3 && elevenV3 != null)
            {
                return elevenV3(ElevenV3!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::ElevenLabs.ElevenFlashV25Request>? elevenFlashV25 = null,

            global::System.Action<global::ElevenLabs.ElevenMultilingualV2Request>? elevenMultilingualV2 = null,

            global::System.Action<global::ElevenLabs.ElevenV3Request>? elevenV3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsElevenFlashV25)
            {
                elevenFlashV25?.Invoke(ElevenFlashV25!);
            }
            else if (IsElevenMultilingualV2)
            {
                elevenMultilingualV2?.Invoke(ElevenMultilingualV2!);
            }
            else if (IsElevenV3)
            {
                elevenV3?.Invoke(ElevenV3!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::ElevenLabs.ElevenFlashV25Request>? elevenFlashV25 = null,
            global::System.Action<global::ElevenLabs.ElevenMultilingualV2Request>? elevenMultilingualV2 = null,
            global::System.Action<global::ElevenLabs.ElevenV3Request>? elevenV3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsElevenFlashV25)
            {
                elevenFlashV25?.Invoke(ElevenFlashV25!);
            }
            else if (IsElevenMultilingualV2)
            {
                elevenMultilingualV2?.Invoke(ElevenMultilingualV2!);
            }
            else if (IsElevenV3)
            {
                elevenV3?.Invoke(ElevenV3!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ElevenFlashV25,
                typeof(global::ElevenLabs.ElevenFlashV25Request),
                ElevenMultilingualV2,
                typeof(global::ElevenLabs.ElevenMultilingualV2Request),
                ElevenV3,
                typeof(global::ElevenLabs.ElevenV3Request),
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
        public bool Equals(TextToSpeechGenerationRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.ElevenFlashV25Request?>.Default.Equals(ElevenFlashV25, other.ElevenFlashV25) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.ElevenMultilingualV2Request?>.Default.Equals(ElevenMultilingualV2, other.ElevenMultilingualV2) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.ElevenV3Request?>.Default.Equals(ElevenV3, other.ElevenV3) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(TextToSpeechGenerationRequest obj1, TextToSpeechGenerationRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<TextToSpeechGenerationRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(TextToSpeechGenerationRequest obj1, TextToSpeechGenerationRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is TextToSpeechGenerationRequest o && Equals(o);
        }
    }
}
