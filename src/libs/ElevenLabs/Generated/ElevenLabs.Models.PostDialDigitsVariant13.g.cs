#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct PostDialDigitsVariant13 : global::System.IEquatable<PostDialDigitsVariant13>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::ElevenLabs.WorkflowPhoneNumberNodeModelOutputPostDialDigitsVariant1DiscriminatorType? Type { get; }

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
        public static implicit operator PostDialDigitsVariant13(global::ElevenLabs.PostDialDigitsStatic value) => new PostDialDigitsVariant13((global::ElevenLabs.PostDialDigitsStatic?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.PostDialDigitsStatic?(PostDialDigitsVariant13 @this) => @this.Static;

        /// <summary>
        /// 
        /// </summary>
        public PostDialDigitsVariant13(global::ElevenLabs.PostDialDigitsStatic? value)
        {
            Static = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PostDialDigitsVariant13(global::ElevenLabs.PostDialDigitsDynamicVariable value) => new PostDialDigitsVariant13((global::ElevenLabs.PostDialDigitsDynamicVariable?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.PostDialDigitsDynamicVariable?(PostDialDigitsVariant13 @this) => @this.Dynamic;

        /// <summary>
        /// 
        /// </summary>
        public PostDialDigitsVariant13(global::ElevenLabs.PostDialDigitsDynamicVariable? value)
        {
            Dynamic = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public PostDialDigitsVariant13(
            global::ElevenLabs.WorkflowPhoneNumberNodeModelOutputPostDialDigitsVariant1DiscriminatorType? type,
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
            global::System.Func<global::ElevenLabs.PostDialDigitsStatic?, TResult>? @static = null,
            global::System.Func<global::ElevenLabs.PostDialDigitsDynamicVariable?, TResult>? dynamic = null,
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
            global::System.Action<global::ElevenLabs.PostDialDigitsStatic?>? @static = null,
            global::System.Action<global::ElevenLabs.PostDialDigitsDynamicVariable?>? dynamic = null,
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
        public bool Equals(PostDialDigitsVariant13 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.PostDialDigitsStatic?>.Default.Equals(Static, other.Static) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.PostDialDigitsDynamicVariable?>.Default.Equals(Dynamic, other.Dynamic) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(PostDialDigitsVariant13 obj1, PostDialDigitsVariant13 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<PostDialDigitsVariant13>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(PostDialDigitsVariant13 obj1, PostDialDigitsVariant13 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is PostDialDigitsVariant13 o && Equals(o);
        }
    }
}
