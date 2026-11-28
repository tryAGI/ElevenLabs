#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Message to be said by this node.
    /// </summary>
    public readonly partial struct Message : global::System.IEquatable<Message>
    {
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.WorkflowSayNodeModelInputMessageDiscriminatorType? Type { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.SayNodeLiteralMessageInput? Literal { get; init; }
#else
        public global::ElevenLabs.SayNodeLiteralMessageInput? Literal { get; }
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
            out global::ElevenLabs.SayNodeLiteralMessageInput? value)
        {
            value = Literal;
            return IsLiteral;
        }

        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SayNodeLiteralMessageInput PickLiteral() => Literal is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Literal' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.SayNodePromptMessageInput? Prompt { get; init; }
#else
        public global::ElevenLabs.SayNodePromptMessageInput? Prompt { get; }
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
            out global::ElevenLabs.SayNodePromptMessageInput? value)
        {
            value = Prompt;
            return IsPrompt;
        }

        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SayNodePromptMessageInput PickPrompt() => Prompt is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Prompt' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator Message(global::ElevenLabs.SayNodeLiteralMessageInput value) => new Message((global::ElevenLabs.SayNodeLiteralMessageInput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::ElevenLabs.SayNodeLiteralMessageInput?(Message @this) => @this.Literal;

        /// <summary>
        ///
        /// </summary>
        public Message(global::ElevenLabs.SayNodeLiteralMessageInput? value)
        {
            Literal = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Message FromLiteral(global::ElevenLabs.SayNodeLiteralMessageInput? value) => new Message(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Message(global::ElevenLabs.SayNodePromptMessageInput value) => new Message((global::ElevenLabs.SayNodePromptMessageInput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::ElevenLabs.SayNodePromptMessageInput?(Message @this) => @this.Prompt;

        /// <summary>
        ///
        /// </summary>
        public Message(global::ElevenLabs.SayNodePromptMessageInput? value)
        {
            Prompt = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Message FromPrompt(global::ElevenLabs.SayNodePromptMessageInput? value) => new Message(value);

        /// <summary>
        ///
        /// </summary>
        public Message(
            global::ElevenLabs.WorkflowSayNodeModelInputMessageDiscriminatorType? type,
            global::ElevenLabs.SayNodeLiteralMessageInput? literal,
            global::ElevenLabs.SayNodePromptMessageInput? prompt
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
            global::System.Func<global::ElevenLabs.SayNodeLiteralMessageInput, TResult>? literal = null,
            global::System.Func<global::ElevenLabs.SayNodePromptMessageInput, TResult>? prompt = null,
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
            global::System.Action<global::ElevenLabs.SayNodeLiteralMessageInput>? literal = null,

            global::System.Action<global::ElevenLabs.SayNodePromptMessageInput>? prompt = null,
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
            global::System.Action<global::ElevenLabs.SayNodeLiteralMessageInput>? literal = null,
            global::System.Action<global::ElevenLabs.SayNodePromptMessageInput>? prompt = null,
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
                typeof(global::ElevenLabs.SayNodeLiteralMessageInput),
                Prompt,
                typeof(global::ElevenLabs.SayNodePromptMessageInput),
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
        public bool Equals(Message other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.SayNodeLiteralMessageInput?>.Default.Equals(Literal, other.Literal) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.SayNodePromptMessageInput?>.Default.Equals(Prompt, other.Prompt)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(Message obj1, Message obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Message>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(Message obj1, Message obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Message o && Equals(o);
        }
    }
}
