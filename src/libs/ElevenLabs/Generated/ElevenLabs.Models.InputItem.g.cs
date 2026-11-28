#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct InputItem : global::System.IEquatable<InputItem>
    {
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SendConversationMessageRequestInputItemDiscriminatorType? Type { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.UserMessageInputItem? UserMessage { get; init; }
#else
        public global::ElevenLabs.UserMessageInputItem? UserMessage { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UserMessage))]
#endif
        public bool IsUserMessage => UserMessage != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickUserMessage(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.UserMessageInputItem? value)
        {
            value = UserMessage;
            return IsUserMessage;
        }

        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UserMessageInputItem PickUserMessage() => UserMessage is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'UserMessage' but the value was {ToString()}.");

        /// <summary>
        /// A `client_tool_result` whose `type` is required, so that it can share `input` with other items.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.ClientToolResultItem? ClientToolResult { get; init; }
#else
        public global::ElevenLabs.ClientToolResultItem? ClientToolResult { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ClientToolResult))]
#endif
        public bool IsClientToolResult => ClientToolResult != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickClientToolResult(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.ClientToolResultItem? value)
        {
            value = ClientToolResult;
            return IsClientToolResult;
        }

        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ClientToolResultItem PickClientToolResult() => ClientToolResult is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ClientToolResult' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.ContextualUpdateInputItem? ContextualUpdate { get; init; }
#else
        public global::ElevenLabs.ContextualUpdateInputItem? ContextualUpdate { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ContextualUpdate))]
#endif
        public bool IsContextualUpdate => ContextualUpdate != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickContextualUpdate(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.ContextualUpdateInputItem? value)
        {
            value = ContextualUpdate;
            return IsContextualUpdate;
        }

        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ContextualUpdateInputItem PickContextualUpdate() => ContextualUpdate is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ContextualUpdate' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator InputItem(global::ElevenLabs.UserMessageInputItem value) => new InputItem((global::ElevenLabs.UserMessageInputItem?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::ElevenLabs.UserMessageInputItem?(InputItem @this) => @this.UserMessage;

        /// <summary>
        ///
        /// </summary>
        public InputItem(global::ElevenLabs.UserMessageInputItem? value)
        {
            UserMessage = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static InputItem FromUserMessage(global::ElevenLabs.UserMessageInputItem? value) => new InputItem(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator InputItem(global::ElevenLabs.ClientToolResultItem value) => new InputItem((global::ElevenLabs.ClientToolResultItem?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::ElevenLabs.ClientToolResultItem?(InputItem @this) => @this.ClientToolResult;

        /// <summary>
        ///
        /// </summary>
        public InputItem(global::ElevenLabs.ClientToolResultItem? value)
        {
            ClientToolResult = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static InputItem FromClientToolResult(global::ElevenLabs.ClientToolResultItem? value) => new InputItem(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator InputItem(global::ElevenLabs.ContextualUpdateInputItem value) => new InputItem((global::ElevenLabs.ContextualUpdateInputItem?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::ElevenLabs.ContextualUpdateInputItem?(InputItem @this) => @this.ContextualUpdate;

        /// <summary>
        ///
        /// </summary>
        public InputItem(global::ElevenLabs.ContextualUpdateInputItem? value)
        {
            ContextualUpdate = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static InputItem FromContextualUpdate(global::ElevenLabs.ContextualUpdateInputItem? value) => new InputItem(value);

        /// <summary>
        ///
        /// </summary>
        public InputItem(
            global::ElevenLabs.SendConversationMessageRequestInputItemDiscriminatorType? type,
            global::ElevenLabs.UserMessageInputItem? userMessage,
            global::ElevenLabs.ClientToolResultItem? clientToolResult,
            global::ElevenLabs.ContextualUpdateInputItem? contextualUpdate
            )
        {
            Type = type;

            UserMessage = userMessage;
            ClientToolResult = clientToolResult;
            ContextualUpdate = contextualUpdate;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            ContextualUpdate as object ??
            ClientToolResult as object ??
            UserMessage as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            UserMessage?.ToString() ??
            ClientToolResult?.ToString() ??
            ContextualUpdate?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsUserMessage && !IsClientToolResult && !IsContextualUpdate || !IsUserMessage && IsClientToolResult && !IsContextualUpdate || !IsUserMessage && !IsClientToolResult && IsContextualUpdate;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::ElevenLabs.UserMessageInputItem, TResult>? userMessage = null,
            global::System.Func<global::ElevenLabs.ClientToolResultItem, TResult>? clientToolResult = null,
            global::System.Func<global::ElevenLabs.ContextualUpdateInputItem, TResult>? contextualUpdate = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (UserMessage is { } __value0 && userMessage != null)
            {
                return userMessage(__value0);
            }
            else if (ClientToolResult is { } __value1 && clientToolResult != null)
            {
                return clientToolResult(__value1);
            }
            else if (ContextualUpdate is { } __value2 && contextualUpdate != null)
            {
                return contextualUpdate(__value2);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::ElevenLabs.UserMessageInputItem>? userMessage = null,

            global::System.Action<global::ElevenLabs.ClientToolResultItem>? clientToolResult = null,

            global::System.Action<global::ElevenLabs.ContextualUpdateInputItem>? contextualUpdate = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (UserMessage is { } __value0)
            {
                userMessage?.Invoke(__value0);
            }
            else if (ClientToolResult is { } __value1)
            {
                clientToolResult?.Invoke(__value1);
            }
            else if (ContextualUpdate is { } __value2)
            {
                contextualUpdate?.Invoke(__value2);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::ElevenLabs.UserMessageInputItem>? userMessage = null,
            global::System.Action<global::ElevenLabs.ClientToolResultItem>? clientToolResult = null,
            global::System.Action<global::ElevenLabs.ContextualUpdateInputItem>? contextualUpdate = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (UserMessage is { } __value0)
            {
                userMessage?.Invoke(__value0);
            }
            else if (ClientToolResult is { } __value1)
            {
                clientToolResult?.Invoke(__value1);
            }
            else if (ContextualUpdate is { } __value2)
            {
                contextualUpdate?.Invoke(__value2);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                UserMessage,
                typeof(global::ElevenLabs.UserMessageInputItem),
                ClientToolResult,
                typeof(global::ElevenLabs.ClientToolResultItem),
                ContextualUpdate,
                typeof(global::ElevenLabs.ContextualUpdateInputItem),
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
        public bool Equals(InputItem other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.UserMessageInputItem?>.Default.Equals(UserMessage, other.UserMessage) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.ClientToolResultItem?>.Default.Equals(ClientToolResult, other.ClientToolResult) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.ContextualUpdateInputItem?>.Default.Equals(ContextualUpdate, other.ContextualUpdate)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(InputItem obj1, InputItem obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<InputItem>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(InputItem obj1, InputItem obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is InputItem o && Equals(o);
        }
    }
}
