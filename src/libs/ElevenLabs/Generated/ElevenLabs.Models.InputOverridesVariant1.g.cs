#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct InputOverridesVariant1 : global::System.IEquatable<InputOverridesVariant1>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::ElevenLabs.MCPToolConfigInputInputOverridesDiscriminatorSource? Source { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.ConstantSchemaOverride? Constant { get; init; }
#else
        public global::ElevenLabs.ConstantSchemaOverride? Constant { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Constant))]
#endif
        public bool IsConstant => Constant != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickConstant(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.ConstantSchemaOverride? value)
        {
            value = Constant;
            return IsConstant;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::ElevenLabs.ConstantSchemaOverride PickConstant() => IsConstant
            ? Constant!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Constant' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.DynamicVariableSchemaOverride? DynamicVariable { get; init; }
#else
        public global::ElevenLabs.DynamicVariableSchemaOverride? DynamicVariable { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DynamicVariable))]
#endif
        public bool IsDynamicVariable => DynamicVariable != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickDynamicVariable(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.DynamicVariableSchemaOverride? value)
        {
            value = DynamicVariable;
            return IsDynamicVariable;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::ElevenLabs.DynamicVariableSchemaOverride PickDynamicVariable() => IsDynamicVariable
            ? DynamicVariable!
            : throw new global::System.InvalidOperationException($"Expected union variant 'DynamicVariable' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.LLMSchemaOverride? Llm { get; init; }
#else
        public global::ElevenLabs.LLMSchemaOverride? Llm { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Llm))]
#endif
        public bool IsLlm => Llm != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickLlm(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.LLMSchemaOverride? value)
        {
            value = Llm;
            return IsLlm;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::ElevenLabs.LLMSchemaOverride PickLlm() => IsLlm
            ? Llm!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Llm' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InputOverridesVariant1(global::ElevenLabs.ConstantSchemaOverride value) => new InputOverridesVariant1((global::ElevenLabs.ConstantSchemaOverride?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.ConstantSchemaOverride?(InputOverridesVariant1 @this) => @this.Constant;

        /// <summary>
        /// 
        /// </summary>
        public InputOverridesVariant1(global::ElevenLabs.ConstantSchemaOverride? value)
        {
            Constant = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static InputOverridesVariant1 FromConstant(global::ElevenLabs.ConstantSchemaOverride? value) => new InputOverridesVariant1(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InputOverridesVariant1(global::ElevenLabs.DynamicVariableSchemaOverride value) => new InputOverridesVariant1((global::ElevenLabs.DynamicVariableSchemaOverride?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.DynamicVariableSchemaOverride?(InputOverridesVariant1 @this) => @this.DynamicVariable;

        /// <summary>
        /// 
        /// </summary>
        public InputOverridesVariant1(global::ElevenLabs.DynamicVariableSchemaOverride? value)
        {
            DynamicVariable = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static InputOverridesVariant1 FromDynamicVariable(global::ElevenLabs.DynamicVariableSchemaOverride? value) => new InputOverridesVariant1(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InputOverridesVariant1(global::ElevenLabs.LLMSchemaOverride value) => new InputOverridesVariant1((global::ElevenLabs.LLMSchemaOverride?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.LLMSchemaOverride?(InputOverridesVariant1 @this) => @this.Llm;

        /// <summary>
        /// 
        /// </summary>
        public InputOverridesVariant1(global::ElevenLabs.LLMSchemaOverride? value)
        {
            Llm = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static InputOverridesVariant1 FromLlm(global::ElevenLabs.LLMSchemaOverride? value) => new InputOverridesVariant1(value);

        /// <summary>
        /// 
        /// </summary>
        public InputOverridesVariant1(
            global::ElevenLabs.MCPToolConfigInputInputOverridesDiscriminatorSource? source,
            global::ElevenLabs.ConstantSchemaOverride? constant,
            global::ElevenLabs.DynamicVariableSchemaOverride? dynamicVariable,
            global::ElevenLabs.LLMSchemaOverride? llm
            )
        {
            Source = source;

            Constant = constant;
            DynamicVariable = dynamicVariable;
            Llm = llm;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Llm as object ??
            DynamicVariable as object ??
            Constant as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Constant?.ToString() ??
            DynamicVariable?.ToString() ??
            Llm?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsConstant && !IsDynamicVariable && !IsLlm || !IsConstant && IsDynamicVariable && !IsLlm || !IsConstant && !IsDynamicVariable && IsLlm;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::ElevenLabs.ConstantSchemaOverride, TResult>? constant = null,
            global::System.Func<global::ElevenLabs.DynamicVariableSchemaOverride, TResult>? dynamicVariable = null,
            global::System.Func<global::ElevenLabs.LLMSchemaOverride, TResult>? llm = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsConstant && constant != null)
            {
                return constant(Constant!);
            }
            else if (IsDynamicVariable && dynamicVariable != null)
            {
                return dynamicVariable(DynamicVariable!);
            }
            else if (IsLlm && llm != null)
            {
                return llm(Llm!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::ElevenLabs.ConstantSchemaOverride>? constant = null,

            global::System.Action<global::ElevenLabs.DynamicVariableSchemaOverride>? dynamicVariable = null,

            global::System.Action<global::ElevenLabs.LLMSchemaOverride>? llm = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsConstant)
            {
                constant?.Invoke(Constant!);
            }
            else if (IsDynamicVariable)
            {
                dynamicVariable?.Invoke(DynamicVariable!);
            }
            else if (IsLlm)
            {
                llm?.Invoke(Llm!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::ElevenLabs.ConstantSchemaOverride>? constant = null,
            global::System.Action<global::ElevenLabs.DynamicVariableSchemaOverride>? dynamicVariable = null,
            global::System.Action<global::ElevenLabs.LLMSchemaOverride>? llm = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsConstant)
            {
                constant?.Invoke(Constant!);
            }
            else if (IsDynamicVariable)
            {
                dynamicVariable?.Invoke(DynamicVariable!);
            }
            else if (IsLlm)
            {
                llm?.Invoke(Llm!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Constant,
                typeof(global::ElevenLabs.ConstantSchemaOverride),
                DynamicVariable,
                typeof(global::ElevenLabs.DynamicVariableSchemaOverride),
                Llm,
                typeof(global::ElevenLabs.LLMSchemaOverride),
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
        public bool Equals(InputOverridesVariant1 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.ConstantSchemaOverride?>.Default.Equals(Constant, other.Constant) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.DynamicVariableSchemaOverride?>.Default.Equals(DynamicVariable, other.DynamicVariable) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.LLMSchemaOverride?>.Default.Equals(Llm, other.Llm) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(InputOverridesVariant1 obj1, InputOverridesVariant1 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<InputOverridesVariant1>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(InputOverridesVariant1 obj1, InputOverridesVariant1 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is InputOverridesVariant1 o && Equals(o);
        }
    }
}
