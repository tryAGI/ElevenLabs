#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// The type of tool
    /// </summary>
    public readonly partial struct ToolConfig : global::System.IEquatable<ToolConfig>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::ElevenLabs.ToolRequestModelToolConfigDiscriminatorType? Type { get; }

        /// <summary>
        /// A webhook tool is a tool that calls an external webhook from our server
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.WebhookToolConfigInput? Webhook { get; init; }
#else
        public global::ElevenLabs.WebhookToolConfigInput? Webhook { get; }
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
        public static implicit operator ToolConfig(global::ElevenLabs.WebhookToolConfigInput value) => new ToolConfig((global::ElevenLabs.WebhookToolConfigInput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.WebhookToolConfigInput?(ToolConfig @this) => @this.Webhook;

        /// <summary>
        /// 
        /// </summary>
        public ToolConfig(global::ElevenLabs.WebhookToolConfigInput? value)
        {
            Webhook = value;
        }

        /// <summary>
        /// A client tool is one that sends an event to the user's client to trigger something client side
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.ClientToolConfigInput? Client { get; init; }
#else
        public global::ElevenLabs.ClientToolConfigInput? Client { get; }
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
        public static implicit operator ToolConfig(global::ElevenLabs.ClientToolConfigInput value) => new ToolConfig((global::ElevenLabs.ClientToolConfigInput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.ClientToolConfigInput?(ToolConfig @this) => @this.Client;

        /// <summary>
        /// 
        /// </summary>
        public ToolConfig(global::ElevenLabs.ClientToolConfigInput? value)
        {
            Client = value;
        }

        /// <summary>
        /// A system tool is a tool that is used to call a system method in the server
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.SystemToolConfigInput? System { get; init; }
#else
        public global::ElevenLabs.SystemToolConfigInput? System { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(System))]
#endif
        public bool IsSystem => System != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolConfig(global::ElevenLabs.SystemToolConfigInput value) => new ToolConfig((global::ElevenLabs.SystemToolConfigInput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.SystemToolConfigInput?(ToolConfig @this) => @this.System;

        /// <summary>
        /// 
        /// </summary>
        public ToolConfig(global::ElevenLabs.SystemToolConfigInput? value)
        {
            System = value;
        }

        /// <summary>
        /// An MCP tool configuration that can be used to call MCP servers
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.MCPToolConfigInput? Mcp { get; init; }
#else
        public global::ElevenLabs.MCPToolConfigInput? Mcp { get; }
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
        public static implicit operator ToolConfig(global::ElevenLabs.MCPToolConfigInput value) => new ToolConfig((global::ElevenLabs.MCPToolConfigInput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.MCPToolConfigInput?(ToolConfig @this) => @this.Mcp;

        /// <summary>
        /// 
        /// </summary>
        public ToolConfig(global::ElevenLabs.MCPToolConfigInput? value)
        {
            Mcp = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ToolConfig(
            global::ElevenLabs.ToolRequestModelToolConfigDiscriminatorType? type,
            global::ElevenLabs.WebhookToolConfigInput? webhook,
            global::ElevenLabs.ClientToolConfigInput? client,
            global::ElevenLabs.SystemToolConfigInput? system,
            global::ElevenLabs.MCPToolConfigInput? mcp
            )
        {
            Type = type;

            Webhook = webhook;
            Client = client;
            System = system;
            Mcp = mcp;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Mcp as object ??
            System as object ??
            Client as object ??
            Webhook as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Webhook?.ToString() ??
            Client?.ToString() ??
            System?.ToString() ??
            Mcp?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsWebhook && !IsClient && !IsSystem && !IsMcp || !IsWebhook && IsClient && !IsSystem && !IsMcp || !IsWebhook && !IsClient && IsSystem && !IsMcp || !IsWebhook && !IsClient && !IsSystem && IsMcp;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::ElevenLabs.WebhookToolConfigInput?, TResult>? webhook = null,
            global::System.Func<global::ElevenLabs.ClientToolConfigInput?, TResult>? client = null,
            global::System.Func<global::ElevenLabs.SystemToolConfigInput?, TResult>? system = null,
            global::System.Func<global::ElevenLabs.MCPToolConfigInput?, TResult>? mcp = null,
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
            else if (IsSystem && system != null)
            {
                return system(System!);
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
            global::System.Action<global::ElevenLabs.WebhookToolConfigInput?>? webhook = null,
            global::System.Action<global::ElevenLabs.ClientToolConfigInput?>? client = null,
            global::System.Action<global::ElevenLabs.SystemToolConfigInput?>? system = null,
            global::System.Action<global::ElevenLabs.MCPToolConfigInput?>? mcp = null,
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
            else if (IsSystem)
            {
                system?.Invoke(System!);
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
                typeof(global::ElevenLabs.WebhookToolConfigInput),
                Client,
                typeof(global::ElevenLabs.ClientToolConfigInput),
                System,
                typeof(global::ElevenLabs.SystemToolConfigInput),
                Mcp,
                typeof(global::ElevenLabs.MCPToolConfigInput),
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
        public bool Equals(ToolConfig other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.WebhookToolConfigInput?>.Default.Equals(Webhook, other.Webhook) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.ClientToolConfigInput?>.Default.Equals(Client, other.Client) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.SystemToolConfigInput?>.Default.Equals(System, other.System) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.MCPToolConfigInput?>.Default.Equals(Mcp, other.Mcp) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ToolConfig obj1, ToolConfig obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ToolConfig>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ToolConfig obj1, ToolConfig obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ToolConfig o && Equals(o);
        }
    }
}
