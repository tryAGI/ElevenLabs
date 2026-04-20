#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ToolCallDetailsVariant1 : global::System.IEquatable<ToolCallDetailsVariant1>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::ElevenLabs.ToolExecutionResponseModelToolCallDetailsVariant1DiscriminatorType? Type { get; }

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
#if NET6_0_OR_GREATER
        public global::ElevenLabs.ConversationHistoryTranscriptToolCallApiIntegrationWebhookDetailsOutput? ApiIntegrationWebhook { get; init; }
#else
        public global::ElevenLabs.ConversationHistoryTranscriptToolCallApiIntegrationWebhookDetailsOutput? ApiIntegrationWebhook { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ApiIntegrationWebhook))]
#endif
        public bool IsApiIntegrationWebhook => ApiIntegrationWebhook != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolCallDetailsVariant1(global::ElevenLabs.ConversationHistoryTranscriptToolCallWebhookDetails value) => new ToolCallDetailsVariant1((global::ElevenLabs.ConversationHistoryTranscriptToolCallWebhookDetails?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.ConversationHistoryTranscriptToolCallWebhookDetails?(ToolCallDetailsVariant1 @this) => @this.Webhook;

        /// <summary>
        /// 
        /// </summary>
        public ToolCallDetailsVariant1(global::ElevenLabs.ConversationHistoryTranscriptToolCallWebhookDetails? value)
        {
            Webhook = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolCallDetailsVariant1(global::ElevenLabs.ConversationHistoryTranscriptToolCallClientDetails value) => new ToolCallDetailsVariant1((global::ElevenLabs.ConversationHistoryTranscriptToolCallClientDetails?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.ConversationHistoryTranscriptToolCallClientDetails?(ToolCallDetailsVariant1 @this) => @this.Client;

        /// <summary>
        /// 
        /// </summary>
        public ToolCallDetailsVariant1(global::ElevenLabs.ConversationHistoryTranscriptToolCallClientDetails? value)
        {
            Client = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolCallDetailsVariant1(global::ElevenLabs.ConversationHistoryTranscriptToolCallMCPDetails value) => new ToolCallDetailsVariant1((global::ElevenLabs.ConversationHistoryTranscriptToolCallMCPDetails?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.ConversationHistoryTranscriptToolCallMCPDetails?(ToolCallDetailsVariant1 @this) => @this.Mcp;

        /// <summary>
        /// 
        /// </summary>
        public ToolCallDetailsVariant1(global::ElevenLabs.ConversationHistoryTranscriptToolCallMCPDetails? value)
        {
            Mcp = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolCallDetailsVariant1(global::ElevenLabs.ConversationHistoryTranscriptToolCallApiIntegrationWebhookDetailsOutput value) => new ToolCallDetailsVariant1((global::ElevenLabs.ConversationHistoryTranscriptToolCallApiIntegrationWebhookDetailsOutput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.ConversationHistoryTranscriptToolCallApiIntegrationWebhookDetailsOutput?(ToolCallDetailsVariant1 @this) => @this.ApiIntegrationWebhook;

        /// <summary>
        /// 
        /// </summary>
        public ToolCallDetailsVariant1(global::ElevenLabs.ConversationHistoryTranscriptToolCallApiIntegrationWebhookDetailsOutput? value)
        {
            ApiIntegrationWebhook = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ToolCallDetailsVariant1(
            global::ElevenLabs.ToolExecutionResponseModelToolCallDetailsVariant1DiscriminatorType? type,
            global::ElevenLabs.ConversationHistoryTranscriptToolCallWebhookDetails? webhook,
            global::ElevenLabs.ConversationHistoryTranscriptToolCallClientDetails? client,
            global::ElevenLabs.ConversationHistoryTranscriptToolCallMCPDetails? mcp,
            global::ElevenLabs.ConversationHistoryTranscriptToolCallApiIntegrationWebhookDetailsOutput? apiIntegrationWebhook
            )
        {
            Type = type;

            Webhook = webhook;
            Client = client;
            Mcp = mcp;
            ApiIntegrationWebhook = apiIntegrationWebhook;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ApiIntegrationWebhook as object ??
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
            Mcp?.ToString() ??
            ApiIntegrationWebhook?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsWebhook && !IsClient && !IsMcp && !IsApiIntegrationWebhook || !IsWebhook && IsClient && !IsMcp && !IsApiIntegrationWebhook || !IsWebhook && !IsClient && IsMcp && !IsApiIntegrationWebhook || !IsWebhook && !IsClient && !IsMcp && IsApiIntegrationWebhook;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::ElevenLabs.ConversationHistoryTranscriptToolCallWebhookDetails?, TResult>? webhook = null,
            global::System.Func<global::ElevenLabs.ConversationHistoryTranscriptToolCallClientDetails?, TResult>? client = null,
            global::System.Func<global::ElevenLabs.ConversationHistoryTranscriptToolCallMCPDetails?, TResult>? mcp = null,
            global::System.Func<global::ElevenLabs.ConversationHistoryTranscriptToolCallApiIntegrationWebhookDetailsOutput?, TResult>? apiIntegrationWebhook = null,
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
            else if (IsApiIntegrationWebhook && apiIntegrationWebhook != null)
            {
                return apiIntegrationWebhook(ApiIntegrationWebhook!);
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
            global::System.Action<global::ElevenLabs.ConversationHistoryTranscriptToolCallApiIntegrationWebhookDetailsOutput?>? apiIntegrationWebhook = null,
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
            else if (IsApiIntegrationWebhook)
            {
                apiIntegrationWebhook?.Invoke(ApiIntegrationWebhook!);
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
                ApiIntegrationWebhook,
                typeof(global::ElevenLabs.ConversationHistoryTranscriptToolCallApiIntegrationWebhookDetailsOutput),
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
        public bool Equals(ToolCallDetailsVariant1 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.ConversationHistoryTranscriptToolCallWebhookDetails?>.Default.Equals(Webhook, other.Webhook) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.ConversationHistoryTranscriptToolCallClientDetails?>.Default.Equals(Client, other.Client) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.ConversationHistoryTranscriptToolCallMCPDetails?>.Default.Equals(Mcp, other.Mcp) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.ConversationHistoryTranscriptToolCallApiIntegrationWebhookDetailsOutput?>.Default.Equals(ApiIntegrationWebhook, other.ApiIntegrationWebhook) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ToolCallDetailsVariant1 obj1, ToolCallDetailsVariant1 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ToolCallDetailsVariant1>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ToolCallDetailsVariant1 obj1, ToolCallDetailsVariant1 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ToolCallDetailsVariant1 o && Equals(o);
        }
    }
}
