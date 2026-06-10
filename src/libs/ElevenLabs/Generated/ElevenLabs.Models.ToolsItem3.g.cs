#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ToolsItem3 : global::System.IEquatable<ToolsItem3>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::ElevenLabs.OpenAISessionConfigToolDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.OpenAIFunctionTool? Function { get; init; }
#else
        public global::ElevenLabs.OpenAIFunctionTool? Function { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Function))]
#endif
        public bool IsFunction => Function != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickFunction(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.OpenAIFunctionTool? value)
        {
            value = Function;
            return IsFunction;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::ElevenLabs.OpenAIFunctionTool PickFunction() => IsFunction
            ? Function!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Function' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.OpenAIMCPTool? Mcp { get; init; }
#else
        public global::ElevenLabs.OpenAIMCPTool? Mcp { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Mcp))]
#endif
        public bool IsMcp => Mcp != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickMcp(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.OpenAIMCPTool? value)
        {
            value = Mcp;
            return IsMcp;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::ElevenLabs.OpenAIMCPTool PickMcp() => IsMcp
            ? Mcp!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Mcp' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolsItem3(global::ElevenLabs.OpenAIFunctionTool value) => new ToolsItem3((global::ElevenLabs.OpenAIFunctionTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.OpenAIFunctionTool?(ToolsItem3 @this) => @this.Function;

        /// <summary>
        /// 
        /// </summary>
        public ToolsItem3(global::ElevenLabs.OpenAIFunctionTool? value)
        {
            Function = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ToolsItem3 FromFunction(global::ElevenLabs.OpenAIFunctionTool? value) => new ToolsItem3(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolsItem3(global::ElevenLabs.OpenAIMCPTool value) => new ToolsItem3((global::ElevenLabs.OpenAIMCPTool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.OpenAIMCPTool?(ToolsItem3 @this) => @this.Mcp;

        /// <summary>
        /// 
        /// </summary>
        public ToolsItem3(global::ElevenLabs.OpenAIMCPTool? value)
        {
            Mcp = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ToolsItem3 FromMcp(global::ElevenLabs.OpenAIMCPTool? value) => new ToolsItem3(value);

        /// <summary>
        /// 
        /// </summary>
        public ToolsItem3(
            global::ElevenLabs.OpenAISessionConfigToolDiscriminatorType? type,
            global::ElevenLabs.OpenAIFunctionTool? function,
            global::ElevenLabs.OpenAIMCPTool? mcp
            )
        {
            Type = type;

            Function = function;
            Mcp = mcp;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Mcp as object ??
            Function as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Function?.ToString() ??
            Mcp?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsFunction && !IsMcp || !IsFunction && IsMcp;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::ElevenLabs.OpenAIFunctionTool, TResult>? function = null,
            global::System.Func<global::ElevenLabs.OpenAIMCPTool, TResult>? mcp = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsFunction && function != null)
            {
                return function(Function!);
            }
            else if (IsMcp && mcp != null)
            {
                return mcp(Mcp!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::ElevenLabs.OpenAIFunctionTool>? function = null,

            global::System.Action<global::ElevenLabs.OpenAIMCPTool>? mcp = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsFunction)
            {
                function?.Invoke(Function!);
            }
            else if (IsMcp)
            {
                mcp?.Invoke(Mcp!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::ElevenLabs.OpenAIFunctionTool>? function = null,
            global::System.Action<global::ElevenLabs.OpenAIMCPTool>? mcp = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsFunction)
            {
                function?.Invoke(Function!);
            }
            else if (IsMcp)
            {
                mcp?.Invoke(Mcp!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Function,
                typeof(global::ElevenLabs.OpenAIFunctionTool),
                Mcp,
                typeof(global::ElevenLabs.OpenAIMCPTool),
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
        public bool Equals(ToolsItem3 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.OpenAIFunctionTool?>.Default.Equals(Function, other.Function) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.OpenAIMCPTool?>.Default.Equals(Mcp, other.Mcp) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ToolsItem3 obj1, ToolsItem3 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ToolsItem3>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ToolsItem3 obj1, ToolsItem3 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ToolsItem3 o && Equals(o);
        }
    }
}
