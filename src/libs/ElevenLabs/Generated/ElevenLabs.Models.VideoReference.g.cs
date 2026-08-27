#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct VideoReference : global::System.IEquatable<VideoReference>
    {
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VideoReferenceDiscriminatorType? Type { get; }

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
        /// A video passed inline as base64. The video is stored as an ephemeral<br/>
        /// asset with no guaranteed retention: it may be deleted at any time after<br/>
        /// the generation completes. To keep an input and reuse it across<br/>
        /// generations, upload it via the assets API (`POST /v1/assets`) and pass<br/>
        /// an `asset` reference instead.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.InlineVideoReference? InlineBase64 { get; init; }
#else
        public global::ElevenLabs.InlineVideoReference? InlineBase64 { get; }
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
            out global::ElevenLabs.InlineVideoReference? value)
        {
            value = InlineBase64;
            return IsInlineBase64;
        }

        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.InlineVideoReference PickInlineBase64() => IsInlineBase64
            ? InlineBase64!
            : throw new global::System.InvalidOperationException($"Expected union variant 'InlineBase64' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator VideoReference(global::ElevenLabs.GenerationReference value) => new VideoReference((global::ElevenLabs.GenerationReference?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::ElevenLabs.GenerationReference?(VideoReference @this) => @this.Generation;

        /// <summary>
        ///
        /// </summary>
        public VideoReference(global::ElevenLabs.GenerationReference? value)
        {
            Generation = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static VideoReference FromGeneration(global::ElevenLabs.GenerationReference? value) => new VideoReference(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator VideoReference(global::ElevenLabs.StaticAssetReference value) => new VideoReference((global::ElevenLabs.StaticAssetReference?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::ElevenLabs.StaticAssetReference?(VideoReference @this) => @this.Asset;

        /// <summary>
        ///
        /// </summary>
        public VideoReference(global::ElevenLabs.StaticAssetReference? value)
        {
            Asset = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static VideoReference FromAsset(global::ElevenLabs.StaticAssetReference? value) => new VideoReference(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator VideoReference(global::ElevenLabs.InlineVideoReference value) => new VideoReference((global::ElevenLabs.InlineVideoReference?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::ElevenLabs.InlineVideoReference?(VideoReference @this) => @this.InlineBase64;

        /// <summary>
        ///
        /// </summary>
        public VideoReference(global::ElevenLabs.InlineVideoReference? value)
        {
            InlineBase64 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static VideoReference FromInlineBase64(global::ElevenLabs.InlineVideoReference? value) => new VideoReference(value);

        /// <summary>
        ///
        /// </summary>
        public VideoReference(
            global::ElevenLabs.VideoReferenceDiscriminatorType? type,
            global::ElevenLabs.GenerationReference? generation,
            global::ElevenLabs.StaticAssetReference? asset,
            global::ElevenLabs.InlineVideoReference? inlineBase64
            )
        {
            Type = type;

            Generation = generation;
            Asset = asset;
            InlineBase64 = inlineBase64;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            InlineBase64 as object ??
            Asset as object ??
            Generation as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Generation?.ToString() ??
            Asset?.ToString() ??
            InlineBase64?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsGeneration && !IsAsset && !IsInlineBase64 || !IsGeneration && IsAsset && !IsInlineBase64 || !IsGeneration && !IsAsset && IsInlineBase64;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::ElevenLabs.GenerationReference, TResult>? generation = null,
            global::System.Func<global::ElevenLabs.StaticAssetReference, TResult>? asset = null,
            global::System.Func<global::ElevenLabs.InlineVideoReference, TResult>? inlineBase64 = null,
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

            global::System.Action<global::ElevenLabs.InlineVideoReference>? inlineBase64 = null,
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
            global::System.Action<global::ElevenLabs.InlineVideoReference>? inlineBase64 = null,
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
                InlineBase64,
                typeof(global::ElevenLabs.InlineVideoReference),
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
        public bool Equals(VideoReference other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.GenerationReference?>.Default.Equals(Generation, other.Generation) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.StaticAssetReference?>.Default.Equals(Asset, other.Asset) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.InlineVideoReference?>.Default.Equals(InlineBase64, other.InlineBase64)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(VideoReference obj1, VideoReference obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<VideoReference>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(VideoReference obj1, VideoReference obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is VideoReference o && Equals(o);
        }
    }
}
