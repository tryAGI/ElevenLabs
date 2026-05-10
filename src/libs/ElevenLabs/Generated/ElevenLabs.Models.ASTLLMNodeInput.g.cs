#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ASTLLMNodeInput : global::System.IEquatable<ASTLLMNodeInput>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.ASTLLMNodeInputASTLLMNode? ASTLLMNode1 { get; init; }
#else
        public global::ElevenLabs.ASTLLMNodeInputASTLLMNode? ASTLLMNode1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ASTLLMNode1))]
#endif
        public bool IsASTLLMNode1 => ASTLLMNode1 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickASTLLMNode1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.ASTLLMNodeInputASTLLMNode? value)
        {
            value = ASTLLMNode1;
            return IsASTLLMNode1;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.ASTLLMNodeInputASTLLMNode2? ASTLLMNode2 { get; init; }
#else
        public global::ElevenLabs.ASTLLMNodeInputASTLLMNode2? ASTLLMNode2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ASTLLMNode2))]
#endif
        public bool IsASTLLMNode2 => ASTLLMNode2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickASTLLMNode2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.ASTLLMNodeInputASTLLMNode2? value)
        {
            value = ASTLLMNode2;
            return IsASTLLMNode2;
        }
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ASTLLMNodeInput(global::ElevenLabs.ASTLLMNodeInputASTLLMNode value) => new ASTLLMNodeInput((global::ElevenLabs.ASTLLMNodeInputASTLLMNode?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.ASTLLMNodeInputASTLLMNode?(ASTLLMNodeInput @this) => @this.ASTLLMNode1;

        /// <summary>
        /// 
        /// </summary>
        public ASTLLMNodeInput(global::ElevenLabs.ASTLLMNodeInputASTLLMNode? value)
        {
            ASTLLMNode1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ASTLLMNodeInput FromASTLLMNode1(global::ElevenLabs.ASTLLMNodeInputASTLLMNode? value) => new ASTLLMNodeInput(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ASTLLMNodeInput(global::ElevenLabs.ASTLLMNodeInputASTLLMNode2 value) => new ASTLLMNodeInput((global::ElevenLabs.ASTLLMNodeInputASTLLMNode2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.ASTLLMNodeInputASTLLMNode2?(ASTLLMNodeInput @this) => @this.ASTLLMNode2;

        /// <summary>
        /// 
        /// </summary>
        public ASTLLMNodeInput(global::ElevenLabs.ASTLLMNodeInputASTLLMNode2? value)
        {
            ASTLLMNode2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ASTLLMNodeInput FromASTLLMNode2(global::ElevenLabs.ASTLLMNodeInputASTLLMNode2? value) => new ASTLLMNodeInput(value);

        /// <summary>
        /// 
        /// </summary>
        public ASTLLMNodeInput(
            global::ElevenLabs.ASTLLMNodeInputASTLLMNode? aSTLLMNode1,
            global::ElevenLabs.ASTLLMNodeInputASTLLMNode2? aSTLLMNode2
            )
        {
            ASTLLMNode1 = aSTLLMNode1;
            ASTLLMNode2 = aSTLLMNode2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ASTLLMNode2 as object ??
            ASTLLMNode1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ASTLLMNode1?.ToString() ??
            ASTLLMNode2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsASTLLMNode1 && !IsASTLLMNode2 || !IsASTLLMNode1 && IsASTLLMNode2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::ElevenLabs.ASTLLMNodeInputASTLLMNode, TResult>? aSTLLMNode1 = null,
            global::System.Func<global::ElevenLabs.ASTLLMNodeInputASTLLMNode2, TResult>? aSTLLMNode2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsASTLLMNode1 && aSTLLMNode1 != null)
            {
                return aSTLLMNode1(ASTLLMNode1!);
            }
            else if (IsASTLLMNode2 && aSTLLMNode2 != null)
            {
                return aSTLLMNode2(ASTLLMNode2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::ElevenLabs.ASTLLMNodeInputASTLLMNode>? aSTLLMNode1 = null,

            global::System.Action<global::ElevenLabs.ASTLLMNodeInputASTLLMNode2>? aSTLLMNode2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsASTLLMNode1)
            {
                aSTLLMNode1?.Invoke(ASTLLMNode1!);
            }
            else if (IsASTLLMNode2)
            {
                aSTLLMNode2?.Invoke(ASTLLMNode2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::ElevenLabs.ASTLLMNodeInputASTLLMNode>? aSTLLMNode1 = null,
            global::System.Action<global::ElevenLabs.ASTLLMNodeInputASTLLMNode2>? aSTLLMNode2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsASTLLMNode1)
            {
                aSTLLMNode1?.Invoke(ASTLLMNode1!);
            }
            else if (IsASTLLMNode2)
            {
                aSTLLMNode2?.Invoke(ASTLLMNode2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ASTLLMNode1,
                typeof(global::ElevenLabs.ASTLLMNodeInputASTLLMNode),
                ASTLLMNode2,
                typeof(global::ElevenLabs.ASTLLMNodeInputASTLLMNode2),
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
        public bool Equals(ASTLLMNodeInput other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.ASTLLMNodeInputASTLLMNode?>.Default.Equals(ASTLLMNode1, other.ASTLLMNode1) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.ASTLLMNodeInputASTLLMNode2?>.Default.Equals(ASTLLMNode2, other.ASTLLMNode2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ASTLLMNodeInput obj1, ASTLLMNodeInput obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ASTLLMNodeInput>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ASTLLMNodeInput obj1, ASTLLMNodeInput obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ASTLLMNodeInput o && Equals(o);
        }
    }
}
