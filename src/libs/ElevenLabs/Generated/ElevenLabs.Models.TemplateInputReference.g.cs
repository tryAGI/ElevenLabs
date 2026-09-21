#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct TemplateInputReference : global::System.IEquatable<TemplateInputReference>
    {
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TemplateInputReferenceDiscriminatorType? Type { get; }

        /// <summary>
        /// The output of a prior generation on this API.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.GenerationReference? Generation { get; init; }
#else
        public global::ElevenLabs.GenerationReference? Generation { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Generation))]
#endif
        public bool IsGeneration => Generation != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickGeneration(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.GenerationReference? value)
        {
            value = Generation;
            return IsGeneration;
        }

        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.GenerationReference PickGeneration() => IsGeneration
            ? Generation!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Generation' but the value was {ToString()}.");

        /// <summary>
        /// An asset uploaded via the assets API.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.StaticAssetReference? Asset { get; init; }
#else
        public global::ElevenLabs.StaticAssetReference? Asset { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Asset))]
#endif
        public bool IsAsset => Asset != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAsset(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.StaticAssetReference? value)
        {
            value = Asset;
            return IsAsset;
        }

        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.StaticAssetReference PickAsset() => IsAsset
            ? Asset!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Asset' but the value was {ToString()}.");

        /// <summary>
        /// A voice this workspace can use.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.VoiceReference? Voice { get; init; }
#else
        public global::ElevenLabs.VoiceReference? Voice { get; }
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
            out global::ElevenLabs.VoiceReference? value)
        {
            value = Voice;
            return IsVoice;
        }

        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VoiceReference PickVoice() => IsVoice
            ? Voice!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Voice' but the value was {ToString()}.");

        /// <summary>
        /// Media passed inline as base64. Stored as an ephemeral asset with no<br/>
        /// guaranteed retention. To keep an input and reuse it, upload via<br/>
        /// ``POST /v1/assets`` and pass an ``asset`` reference instead.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.InlineBase64Reference? InlineBase64 { get; init; }
#else
        public global::ElevenLabs.InlineBase64Reference? InlineBase64 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InlineBase64))]
#endif
        public bool IsInlineBase64 => InlineBase64 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickInlineBase64(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.InlineBase64Reference? value)
        {
            value = InlineBase64;
            return IsInlineBase64;
        }

        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.InlineBase64Reference PickInlineBase64() => IsInlineBase64
            ? InlineBase64!
            : throw new global::System.InvalidOperationException($"Expected union variant 'InlineBase64' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator TemplateInputReference(global::ElevenLabs.GenerationReference value) => new TemplateInputReference((global::ElevenLabs.GenerationReference?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::ElevenLabs.GenerationReference?(TemplateInputReference @this) => @this.Generation;

        /// <summary>
        ///
        /// </summary>
        public TemplateInputReference(global::ElevenLabs.GenerationReference? value)
        {
            Generation = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static TemplateInputReference FromGeneration(global::ElevenLabs.GenerationReference? value) => new TemplateInputReference(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator TemplateInputReference(global::ElevenLabs.StaticAssetReference value) => new TemplateInputReference((global::ElevenLabs.StaticAssetReference?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::ElevenLabs.StaticAssetReference?(TemplateInputReference @this) => @this.Asset;

        /// <summary>
        ///
        /// </summary>
        public TemplateInputReference(global::ElevenLabs.StaticAssetReference? value)
        {
            Asset = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static TemplateInputReference FromAsset(global::ElevenLabs.StaticAssetReference? value) => new TemplateInputReference(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator TemplateInputReference(global::ElevenLabs.VoiceReference value) => new TemplateInputReference((global::ElevenLabs.VoiceReference?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::ElevenLabs.VoiceReference?(TemplateInputReference @this) => @this.Voice;

        /// <summary>
        ///
        /// </summary>
        public TemplateInputReference(global::ElevenLabs.VoiceReference? value)
        {
            Voice = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static TemplateInputReference FromVoice(global::ElevenLabs.VoiceReference? value) => new TemplateInputReference(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator TemplateInputReference(global::ElevenLabs.InlineBase64Reference value) => new TemplateInputReference((global::ElevenLabs.InlineBase64Reference?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::ElevenLabs.InlineBase64Reference?(TemplateInputReference @this) => @this.InlineBase64;

        /// <summary>
        ///
        /// </summary>
        public TemplateInputReference(global::ElevenLabs.InlineBase64Reference? value)
        {
            InlineBase64 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static TemplateInputReference FromInlineBase64(global::ElevenLabs.InlineBase64Reference? value) => new TemplateInputReference(value);

        /// <summary>
        ///
        /// </summary>
        public TemplateInputReference(
            global::ElevenLabs.TemplateInputReferenceDiscriminatorType? type,
            global::ElevenLabs.GenerationReference? generation,
            global::ElevenLabs.StaticAssetReference? asset,
            global::ElevenLabs.VoiceReference? voice,
            global::ElevenLabs.InlineBase64Reference? inlineBase64
            )
        {
            Type = type;

            Generation = generation;
            Asset = asset;
            Voice = voice;
            InlineBase64 = inlineBase64;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            InlineBase64 as object ??
            Voice as object ??
            Asset as object ??
            Generation as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Generation?.ToString() ??
            Asset?.ToString() ??
            Voice?.ToString() ??
            InlineBase64?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsGeneration && !IsAsset && !IsVoice && !IsInlineBase64 || !IsGeneration && IsAsset && !IsVoice && !IsInlineBase64 || !IsGeneration && !IsAsset && IsVoice && !IsInlineBase64 || !IsGeneration && !IsAsset && !IsVoice && IsInlineBase64;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::ElevenLabs.GenerationReference, TResult>? generation = null,
            global::System.Func<global::ElevenLabs.StaticAssetReference, TResult>? asset = null,
            global::System.Func<global::ElevenLabs.VoiceReference, TResult>? voice = null,
            global::System.Func<global::ElevenLabs.InlineBase64Reference, TResult>? inlineBase64 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsGeneration && generation != null)
            {
                return generation(Generation!);
            }
            else if (IsAsset && asset != null)
            {
                return asset(Asset!);
            }
            else if (IsVoice && voice != null)
            {
                return voice(Voice!);
            }
            else if (IsInlineBase64 && inlineBase64 != null)
            {
                return inlineBase64(InlineBase64!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::ElevenLabs.GenerationReference>? generation = null,

            global::System.Action<global::ElevenLabs.StaticAssetReference>? asset = null,

            global::System.Action<global::ElevenLabs.VoiceReference>? voice = null,

            global::System.Action<global::ElevenLabs.InlineBase64Reference>? inlineBase64 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsGeneration)
            {
                generation?.Invoke(Generation!);
            }
            else if (IsAsset)
            {
                asset?.Invoke(Asset!);
            }
            else if (IsVoice)
            {
                voice?.Invoke(Voice!);
            }
            else if (IsInlineBase64)
            {
                inlineBase64?.Invoke(InlineBase64!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::ElevenLabs.GenerationReference>? generation = null,
            global::System.Action<global::ElevenLabs.StaticAssetReference>? asset = null,
            global::System.Action<global::ElevenLabs.VoiceReference>? voice = null,
            global::System.Action<global::ElevenLabs.InlineBase64Reference>? inlineBase64 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsGeneration)
            {
                generation?.Invoke(Generation!);
            }
            else if (IsAsset)
            {
                asset?.Invoke(Asset!);
            }
            else if (IsVoice)
            {
                voice?.Invoke(Voice!);
            }
            else if (IsInlineBase64)
            {
                inlineBase64?.Invoke(InlineBase64!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Generation,
                typeof(global::ElevenLabs.GenerationReference),
                Asset,
                typeof(global::ElevenLabs.StaticAssetReference),
                Voice,
                typeof(global::ElevenLabs.VoiceReference),
                InlineBase64,
                typeof(global::ElevenLabs.InlineBase64Reference),
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
        public bool Equals(TemplateInputReference other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.GenerationReference?>.Default.Equals(Generation, other.Generation) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.StaticAssetReference?>.Default.Equals(Asset, other.Asset) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.VoiceReference?>.Default.Equals(Voice, other.Voice) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.InlineBase64Reference?>.Default.Equals(InlineBase64, other.InlineBase64)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(TemplateInputReference obj1, TemplateInputReference obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<TemplateInputReference>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(TemplateInputReference obj1, TemplateInputReference obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is TemplateInputReference o && Equals(o);
        }
    }
}
