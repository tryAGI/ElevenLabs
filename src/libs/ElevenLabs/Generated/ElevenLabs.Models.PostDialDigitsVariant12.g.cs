#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct PostDialDigitsVariant12 : global::System.IEquatable<PostDialDigitsVariant12>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::ElevenLabs.WorkflowPhoneNumberNodeModelInputPostDialDigitsVariant1DiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.PostDialDigitsStatic? Static { get; init; }
#else
        public global::ElevenLabs.PostDialDigitsStatic? Static { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Static))]
#endif
        public bool IsStatic => Static != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickStatic(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.PostDialDigitsStatic? value)
        {
            value = Static;
            return IsStatic;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.PostDialDigitsDynamicVariable? Dynamic { get; init; }
#else
        public global::ElevenLabs.PostDialDigitsDynamicVariable? Dynamic { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Dynamic))]
#endif
        public bool IsDynamic => Dynamic != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickDynamic(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.PostDialDigitsDynamicVariable? value)
        {
            value = Dynamic;
            return IsDynamic;
        }
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PostDialDigitsVariant12(global::ElevenLabs.PostDialDigitsStatic value) => new PostDialDigitsVariant12((global::ElevenLabs.PostDialDigitsStatic?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.PostDialDigitsStatic?(PostDialDigitsVariant12 @this) => @this.Static;

        /// <summary>
        /// 
        /// </summary>
        public PostDialDigitsVariant12(global::ElevenLabs.PostDialDigitsStatic? value)
        {
            Static = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PostDialDigitsVariant12(global::ElevenLabs.PostDialDigitsDynamicVariable value) => new PostDialDigitsVariant12((global::ElevenLabs.PostDialDigitsDynamicVariable?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.PostDialDigitsDynamicVariable?(PostDialDigitsVariant12 @this) => @this.Dynamic;

        /// <summary>
        /// 
        /// </summary>
        public PostDialDigitsVariant12(global::ElevenLabs.PostDialDigitsDynamicVariable? value)
        {
            Dynamic = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public PostDialDigitsVariant12(
            global::ElevenLabs.WorkflowPhoneNumberNodeModelInputPostDialDigitsVariant1DiscriminatorType? type,
            global::ElevenLabs.PostDialDigitsStatic? @static,
            global::ElevenLabs.PostDialDigitsDynamicVariable? dynamic
            )
        {
            Type = type;

            Static = @static;
            Dynamic = dynamic;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Dynamic as object ??
            Static as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Static?.ToString() ??
            Dynamic?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsStatic && !IsDynamic || !IsStatic && IsDynamic;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::ElevenLabs.PostDialDigitsStatic, TResult>? @static = null,
            global::System.Func<global::ElevenLabs.PostDialDigitsDynamicVariable, TResult>? dynamic = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsStatic && @static != null)
            {
                return @static(Static!);
            }
            else if (IsDynamic && dynamic != null)
            {
                return dynamic(Dynamic!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::ElevenLabs.PostDialDigitsStatic>? @static = null,

            global::System.Action<global::ElevenLabs.PostDialDigitsDynamicVariable>? dynamic = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsStatic)
            {
                @static?.Invoke(Static!);
            }
            else if (IsDynamic)
            {
                dynamic?.Invoke(Dynamic!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::ElevenLabs.PostDialDigitsStatic>? @static = null,
            global::System.Action<global::ElevenLabs.PostDialDigitsDynamicVariable>? dynamic = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsStatic)
            {
                @static?.Invoke(Static!);
            }
            else if (IsDynamic)
            {
                dynamic?.Invoke(Dynamic!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Static,
                typeof(global::ElevenLabs.PostDialDigitsStatic),
                Dynamic,
                typeof(global::ElevenLabs.PostDialDigitsDynamicVariable),
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
        public bool Equals(PostDialDigitsVariant12 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.PostDialDigitsStatic?>.Default.Equals(Static, other.Static) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.PostDialDigitsDynamicVariable?>.Default.Equals(Dynamic, other.Dynamic) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(PostDialDigitsVariant12 obj1, PostDialDigitsVariant12 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<PostDialDigitsVariant12>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(PostDialDigitsVariant12 obj1, PostDialDigitsVariant12 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is PostDialDigitsVariant12 o && Equals(o);
        }
    }
}
