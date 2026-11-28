#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Message to be said by this node.
    /// </summary>
    public readonly partial struct Message2 : global::System.IEquatable<Message2>
    {
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowSayNodeModelOutputMessageDiscriminatorType? Type { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.SayNodeLiteralMessageOutput? Literal { get; init; }
#else
        public global::ElevenLabs.SayNodeLiteralMessageOutput? Literal { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Literal))]
#endif
        public bool IsLiteral => Literal != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickLiteral(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.SayNodeLiteralMessageOutput? value)
        {
            value = Literal;
            return IsLiteral;
        }

        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SayNodeLiteralMessageOutput PickLiteral() => Literal is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Literal' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.SayNodePromptMessageOutput? Prompt { get; init; }
#else
        public global::ElevenLabs.SayNodePromptMessageOutput? Prompt { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Prompt))]
#endif
        public bool IsPrompt => Prompt != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickPrompt(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.SayNodePromptMessageOutput? value)
        {
            value = Prompt;
            return IsPrompt;
        }

        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SayNodePromptMessageOutput PickPrompt() => Prompt is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Prompt' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator Message2(global::ElevenLabs.SayNodeLiteralMessageOutput value) => new Message2((global::ElevenLabs.SayNodeLiteralMessageOutput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::ElevenLabs.SayNodeLiteralMessageOutput?(Message2 @this) => @this.Literal;

        /// <summary>
        ///
        /// </summary>
        public Message2(global::ElevenLabs.SayNodeLiteralMessageOutput? value)
        {
            Literal = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Message2 FromLiteral(global::ElevenLabs.SayNodeLiteralMessageOutput? value) => new Message2(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Message2(global::ElevenLabs.SayNodePromptMessageOutput value) => new Message2((global::ElevenLabs.SayNodePromptMessageOutput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::ElevenLabs.SayNodePromptMessageOutput?(Message2 @this) => @this.Prompt;

        /// <summary>
        ///
        /// </summary>
        public Message2(global::ElevenLabs.SayNodePromptMessageOutput? value)
        {
            Prompt = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Message2 FromPrompt(global::ElevenLabs.SayNodePromptMessageOutput? value) => new Message2(value);

        /// <summary>
        ///
        /// </summary>
        public Message2(
            global::ElevenLabs.WorkflowSayNodeModelOutputMessageDiscriminatorType? type,
            global::ElevenLabs.SayNodeLiteralMessageOutput? literal,
            global::ElevenLabs.SayNodePromptMessageOutput? prompt
            )
        {
            Type = type;

            Literal = literal;
            Prompt = prompt;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Prompt as object ??
            Literal as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Literal?.ToString() ??
            Prompt?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsLiteral && !IsPrompt || !IsLiteral && IsPrompt;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::ElevenLabs.SayNodeLiteralMessageOutput, TResult>? literal = null,
            global::System.Func<global::ElevenLabs.SayNodePromptMessageOutput, TResult>? prompt = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Literal is { } __value0 && literal != null)
            {
                return literal(__value0);
            }
            else if (Prompt is { } __value1 && prompt != null)
            {
                return prompt(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::ElevenLabs.SayNodeLiteralMessageOutput>? literal = null,

            global::System.Action<global::ElevenLabs.SayNodePromptMessageOutput>? prompt = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Literal is { } __value0)
            {
                literal?.Invoke(__value0);
            }
            else if (Prompt is { } __value1)
            {
                prompt?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::ElevenLabs.SayNodeLiteralMessageOutput>? literal = null,
            global::System.Action<global::ElevenLabs.SayNodePromptMessageOutput>? prompt = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Literal is { } __value0)
            {
                literal?.Invoke(__value0);
            }
            else if (Prompt is { } __value1)
            {
                prompt?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Literal,
                typeof(global::ElevenLabs.SayNodeLiteralMessageOutput),
                Prompt,
                typeof(global::ElevenLabs.SayNodePromptMessageOutput),
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
        public bool Equals(Message2 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.SayNodeLiteralMessageOutput?>.Default.Equals(Literal, other.Literal) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.SayNodePromptMessageOutput?>.Default.Equals(Prompt, other.Prompt)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(Message2 obj1, Message2 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Message2>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(Message2 obj1, Message2 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Message2 o && Equals(o);
        }
    }
}
