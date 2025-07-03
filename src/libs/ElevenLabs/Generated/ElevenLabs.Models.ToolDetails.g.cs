#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ToolDetails : global::System.IEquatable<ToolDetails>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::ElevenLabs.ConversationHistoryTranscriptToolCallCommonModelToolDetailsDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.ConversationHistoryTranscriptToolCallWebhookDetails? Webhook { get; init; }
#else
        public global::ElevenLabs.ConversationHistoryTranscriptToolCallWebhookDetails? Webhook { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Webhook))]
#endif
        public bool IsWebhook => Webhook != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolDetails(global::ElevenLabs.ConversationHistoryTranscriptToolCallWebhookDetails value) => new ToolDetails((global::ElevenLabs.ConversationHistoryTranscriptToolCallWebhookDetails?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.ConversationHistoryTranscriptToolCallWebhookDetails?(ToolDetails @this) => @this.Webhook;

        /// <summary>
        /// 
        /// </summary>
        public ToolDetails(global::ElevenLabs.ConversationHistoryTranscriptToolCallWebhookDetails? value)
        {
            Webhook = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.ConversationHistoryTranscriptToolCallClientDetails? Client { get; init; }
#else
        public global::ElevenLabs.ConversationHistoryTranscriptToolCallClientDetails? Client { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Client))]
#endif
        public bool IsClient => Client != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolDetails(global::ElevenLabs.ConversationHistoryTranscriptToolCallClientDetails value) => new ToolDetails((global::ElevenLabs.ConversationHistoryTranscriptToolCallClientDetails?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.ConversationHistoryTranscriptToolCallClientDetails?(ToolDetails @this) => @this.Client;

        /// <summary>
        /// 
        /// </summary>
        public ToolDetails(global::ElevenLabs.ConversationHistoryTranscriptToolCallClientDetails? value)
        {
            Client = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.ConversationHistoryTranscriptToolCallMCPDetails? Mcp { get; init; }
#else
        public global::ElevenLabs.ConversationHistoryTranscriptToolCallMCPDetails? Mcp { get; }
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
        public static implicit operator ToolDetails(global::ElevenLabs.ConversationHistoryTranscriptToolCallMCPDetails value) => new ToolDetails((global::ElevenLabs.ConversationHistoryTranscriptToolCallMCPDetails?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.ConversationHistoryTranscriptToolCallMCPDetails?(ToolDetails @this) => @this.Mcp;

        /// <summary>
        /// 
        /// </summary>
        public ToolDetails(global::ElevenLabs.ConversationHistoryTranscriptToolCallMCPDetails? value)
        {
            Mcp = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ToolDetails(
            global::ElevenLabs.ConversationHistoryTranscriptToolCallCommonModelToolDetailsDiscriminatorType? type,
            global::ElevenLabs.ConversationHistoryTranscriptToolCallWebhookDetails? webhook,
            global::ElevenLabs.ConversationHistoryTranscriptToolCallClientDetails? client,
            global::ElevenLabs.ConversationHistoryTranscriptToolCallMCPDetails? mcp
            )
        {
            Type = type;

            Webhook = webhook;
            Client = client;
            Mcp = mcp;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Mcp as object ??
            Client as object ??
            Webhook as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Webhook?.ToString() ??
            Client?.ToString() ??
            Mcp?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsWebhook && !IsClient && !IsMcp || !IsWebhook && IsClient && !IsMcp || !IsWebhook && !IsClient && IsMcp;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::ElevenLabs.ConversationHistoryTranscriptToolCallWebhookDetails?, TResult>? webhook = null,
            global::System.Func<global::ElevenLabs.ConversationHistoryTranscriptToolCallClientDetails?, TResult>? client = null,
            global::System.Func<global::ElevenLabs.ConversationHistoryTranscriptToolCallMCPDetails?, TResult>? mcp = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsWebhook && webhook != null)
            {
                return webhook(Webhook!);
            }
            else if (IsClient && client != null)
            {
                return client(Client!);
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
            global::System.Action<global::ElevenLabs.ConversationHistoryTranscriptToolCallWebhookDetails?>? webhook = null,
            global::System.Action<global::ElevenLabs.ConversationHistoryTranscriptToolCallClientDetails?>? client = null,
            global::System.Action<global::ElevenLabs.ConversationHistoryTranscriptToolCallMCPDetails?>? mcp = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsWebhook)
            {
                webhook?.Invoke(Webhook!);
            }
            else if (IsClient)
            {
                client?.Invoke(Client!);
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
                Webhook,
                typeof(global::ElevenLabs.ConversationHistoryTranscriptToolCallWebhookDetails),
                Client,
                typeof(global::ElevenLabs.ConversationHistoryTranscriptToolCallClientDetails),
                Mcp,
                typeof(global::ElevenLabs.ConversationHistoryTranscriptToolCallMCPDetails),
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
        public bool Equals(ToolDetails other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.ConversationHistoryTranscriptToolCallWebhookDetails?>.Default.Equals(Webhook, other.Webhook) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.ConversationHistoryTranscriptToolCallClientDetails?>.Default.Equals(Client, other.Client) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.ConversationHistoryTranscriptToolCallMCPDetails?>.Default.Equals(Mcp, other.Mcp) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ToolDetails obj1, ToolDetails obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ToolDetails>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ToolDetails obj1, ToolDetails obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ToolDetails o && Equals(o);
        }
    }
}
