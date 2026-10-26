#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct CustomSipHeadersItem3 : global::System.IEquatable<CustomSipHeadersItem3>
    {
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowPhoneNumberNodeModelOutputCustomSipHeaderDiscriminatorType? Type { get; }

        /// <summary>
        /// Custom SIP header for phone transfers with a static (validated) value.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.CustomSIPHeader? Static { get; init; }
#else
        public global::ElevenLabs.CustomSIPHeader? Static { get; }
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
            out global::ElevenLabs.CustomSIPHeader? value)
        {
            value = Static;
            return IsStatic;
        }

        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CustomSIPHeader PickStatic() => Static is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Static' but the value was {ToString()}.");

        /// <summary>
        /// Custom SIP header for phone transfers with a dynamic variable reference.<br/>
        /// The value is a variable name that will be resolved at runtime.<br/>
        /// Value is not validated here since it will be substituted with actual value later.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.CustomSIPHeaderWithDynamicVariable? Dynamic { get; init; }
#else
        public global::ElevenLabs.CustomSIPHeaderWithDynamicVariable? Dynamic { get; }
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
            out global::ElevenLabs.CustomSIPHeaderWithDynamicVariable? value)
        {
            value = Dynamic;
            return IsDynamic;
        }

        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.CustomSIPHeaderWithDynamicVariable PickDynamic() => Dynamic is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Dynamic' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator CustomSipHeadersItem3(global::ElevenLabs.CustomSIPHeader value) => new CustomSipHeadersItem3((global::ElevenLabs.CustomSIPHeader?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::ElevenLabs.CustomSIPHeader?(CustomSipHeadersItem3 @this) => @this.Static;

        /// <summary>
        ///
        /// </summary>
        public CustomSipHeadersItem3(global::ElevenLabs.CustomSIPHeader? value)
        {
            Static = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CustomSipHeadersItem3 FromStatic(global::ElevenLabs.CustomSIPHeader? value) => new CustomSipHeadersItem3(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator CustomSipHeadersItem3(global::ElevenLabs.CustomSIPHeaderWithDynamicVariable value) => new CustomSipHeadersItem3((global::ElevenLabs.CustomSIPHeaderWithDynamicVariable?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::ElevenLabs.CustomSIPHeaderWithDynamicVariable?(CustomSipHeadersItem3 @this) => @this.Dynamic;

        /// <summary>
        ///
        /// </summary>
        public CustomSipHeadersItem3(global::ElevenLabs.CustomSIPHeaderWithDynamicVariable? value)
        {
            Dynamic = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static CustomSipHeadersItem3 FromDynamic(global::ElevenLabs.CustomSIPHeaderWithDynamicVariable? value) => new CustomSipHeadersItem3(value);

        /// <summary>
        ///
        /// </summary>
        public CustomSipHeadersItem3(
            global::ElevenLabs.WorkflowPhoneNumberNodeModelOutputCustomSipHeaderDiscriminatorType? type,
            global::ElevenLabs.CustomSIPHeader? @static,
            global::ElevenLabs.CustomSIPHeaderWithDynamicVariable? dynamic
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
            global::System.Func<global::ElevenLabs.CustomSIPHeader, TResult>? @static = null,
            global::System.Func<global::ElevenLabs.CustomSIPHeaderWithDynamicVariable, TResult>? dynamic = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Static is { } __value0 && @static != null)
            {
                return @static(__value0);
            }
            else if (Dynamic is { } __value1 && dynamic != null)
            {
                return dynamic(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::ElevenLabs.CustomSIPHeader>? @static = null,

            global::System.Action<global::ElevenLabs.CustomSIPHeaderWithDynamicVariable>? dynamic = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Static is { } __value0)
            {
                @static?.Invoke(__value0);
            }
            else if (Dynamic is { } __value1)
            {
                dynamic?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::ElevenLabs.CustomSIPHeader>? @static = null,
            global::System.Action<global::ElevenLabs.CustomSIPHeaderWithDynamicVariable>? dynamic = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Static is { } __value0)
            {
                @static?.Invoke(__value0);
            }
            else if (Dynamic is { } __value1)
            {
                dynamic?.Invoke(__value1);
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
                typeof(global::ElevenLabs.CustomSIPHeader),
                Dynamic,
                typeof(global::ElevenLabs.CustomSIPHeaderWithDynamicVariable),
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
        public bool Equals(CustomSipHeadersItem3 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.CustomSIPHeader?>.Default.Equals(Static, other.Static) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.CustomSIPHeaderWithDynamicVariable?>.Default.Equals(Dynamic, other.Dynamic)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(CustomSipHeadersItem3 obj1, CustomSipHeadersItem3 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<CustomSipHeadersItem3>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(CustomSipHeadersItem3 obj1, CustomSipHeadersItem3 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is CustomSipHeadersItem3 o && Equals(o);
        }
    }
}
