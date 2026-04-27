#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct CreatedNodesVariant1Item : global::System.IEquatable<CreatedNodesVariant1Item>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::ElevenLabs.MutationResultCreatedNodesVariant1ItemDiscriminatorType? Type { get; }

        /// <summary>
        /// A generation node response that runs a model.<br/>
        /// Example: {"active_generation_id":"gen_abc123","id":"J3Pbu5gP6NNKBscdCdwB","label":"Generate Image","model_id":"gemini-2.5-flash-image","model_parameters":{"aspect_ratio":"16:9","images":[{"template_node_id":"K8Qnx2mR4PPLCteeDfxC"}]},"position":{"x":300,"y":150},"prompt":"A sunset over mountains","template_id":"tmpl_abc123","type":"generation"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.GenerationNode? Generation { get; init; }
#else
        public global::ElevenLabs.GenerationNode? Generation { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Generation))]
#endif
        public bool IsGeneration => Generation != null;

        /// <summary>
        /// A static asset node response (image, video, text, or audio).<br/>
        /// Example: {"asset":{"content_asset_id":"asset_xyz789"},"id":"S1Abc2defGHI3jkl","label":"Static Image","modality":"image","position":{"x":100,"y":150},"template_id":"tmpl_abc123","type":"static_asset"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.StaticAssetNode? StaticAsset { get; init; }
#else
        public global::ElevenLabs.StaticAssetNode? StaticAsset { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StaticAsset))]
#endif
        public bool IsStaticAsset => StaticAsset != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreatedNodesVariant1Item(global::ElevenLabs.GenerationNode value) => new CreatedNodesVariant1Item((global::ElevenLabs.GenerationNode?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.GenerationNode?(CreatedNodesVariant1Item @this) => @this.Generation;

        /// <summary>
        /// 
        /// </summary>
        public CreatedNodesVariant1Item(global::ElevenLabs.GenerationNode? value)
        {
            Generation = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator CreatedNodesVariant1Item(global::ElevenLabs.StaticAssetNode value) => new CreatedNodesVariant1Item((global::ElevenLabs.StaticAssetNode?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.StaticAssetNode?(CreatedNodesVariant1Item @this) => @this.StaticAsset;

        /// <summary>
        /// 
        /// </summary>
        public CreatedNodesVariant1Item(global::ElevenLabs.StaticAssetNode? value)
        {
            StaticAsset = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public CreatedNodesVariant1Item(
            global::ElevenLabs.MutationResultCreatedNodesVariant1ItemDiscriminatorType? type,
            global::ElevenLabs.GenerationNode? generation,
            global::ElevenLabs.StaticAssetNode? staticAsset
            )
        {
            Type = type;

            Generation = generation;
            StaticAsset = staticAsset;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            StaticAsset as object ??
            Generation as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Generation?.ToString() ??
            StaticAsset?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsGeneration && !IsStaticAsset || !IsGeneration && IsStaticAsset;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::ElevenLabs.GenerationNode?, TResult>? generation = null,
            global::System.Func<global::ElevenLabs.StaticAssetNode?, TResult>? staticAsset = null,
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
            else if (IsStaticAsset && staticAsset != null)
            {
                return staticAsset(StaticAsset!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::ElevenLabs.GenerationNode?>? generation = null,
            global::System.Action<global::ElevenLabs.StaticAssetNode?>? staticAsset = null,
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
            else if (IsStaticAsset)
            {
                staticAsset?.Invoke(StaticAsset!);
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
                typeof(global::ElevenLabs.GenerationNode),
                StaticAsset,
                typeof(global::ElevenLabs.StaticAssetNode),
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
        public bool Equals(CreatedNodesVariant1Item other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.GenerationNode?>.Default.Equals(Generation, other.Generation) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.StaticAssetNode?>.Default.Equals(StaticAsset, other.StaticAsset) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(CreatedNodesVariant1Item obj1, CreatedNodesVariant1Item obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CreatedNodesVariant1Item>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(CreatedNodesVariant1Item obj1, CreatedNodesVariant1Item obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CreatedNodesVariant1Item o && Equals(o);
        }
    }
}
