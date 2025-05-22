#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// The type of tool
    /// </summary>
    public readonly partial struct ToolsItem3 : global::System.IEquatable<ToolsItem3>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::ElevenLabs.PromptAgentOutputToolDiscriminatorType? Type { get; }

        /// <summary>
        /// A webhook tool is a tool that calls an external webhook from our server
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.WebhookToolConfigOutput? Webhook { get; init; }
#else
        public global::ElevenLabs.WebhookToolConfigOutput? Webhook { get; }
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
        public static implicit operator ToolsItem3(global::ElevenLabs.WebhookToolConfigOutput value) => new ToolsItem3((global::ElevenLabs.WebhookToolConfigOutput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.WebhookToolConfigOutput?(ToolsItem3 @this) => @this.Webhook;

        /// <summary>
        /// 
        /// </summary>
        public ToolsItem3(global::ElevenLabs.WebhookToolConfigOutput? value)
        {
            Webhook = value;
        }

        /// <summary>
        /// A client tool is one that sends an event to the user's client to trigger something client side
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.ClientToolConfigOutput? Client { get; init; }
#else
        public global::ElevenLabs.ClientToolConfigOutput? Client { get; }
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
        public static implicit operator ToolsItem3(global::ElevenLabs.ClientToolConfigOutput value) => new ToolsItem3((global::ElevenLabs.ClientToolConfigOutput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.ClientToolConfigOutput?(ToolsItem3 @this) => @this.Client;

        /// <summary>
        /// 
        /// </summary>
        public ToolsItem3(global::ElevenLabs.ClientToolConfigOutput? value)
        {
            Client = value;
        }

        /// <summary>
        /// A system tool is a tool that is used to call a system method in the server
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.SystemToolConfigOutput? System { get; init; }
#else
        public global::ElevenLabs.SystemToolConfigOutput? System { get; }
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
        public static implicit operator ToolsItem3(global::ElevenLabs.SystemToolConfigOutput value) => new ToolsItem3((global::ElevenLabs.SystemToolConfigOutput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.SystemToolConfigOutput?(ToolsItem3 @this) => @this.System;

        /// <summary>
        /// 
        /// </summary>
        public ToolsItem3(global::ElevenLabs.SystemToolConfigOutput? value)
        {
            System = value;
        }

        /// <summary>
        /// A MCP tool is a tool that is used to call a MCP server
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.MCPToolConfigOutput? Mcp { get; init; }
#else
        public global::ElevenLabs.MCPToolConfigOutput? Mcp { get; }
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
        public static implicit operator ToolsItem3(global::ElevenLabs.MCPToolConfigOutput value) => new ToolsItem3((global::ElevenLabs.MCPToolConfigOutput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.MCPToolConfigOutput?(ToolsItem3 @this) => @this.Mcp;

        /// <summary>
        /// 
        /// </summary>
        public ToolsItem3(global::ElevenLabs.MCPToolConfigOutput? value)
        {
            Mcp = value;
        }

        /// <summary>
        /// A Native MCP tool is a tool that is used to call a Native MCP server
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.NativeMCPToolConfigOutput? NativeMcp { get; init; }
#else
        public global::ElevenLabs.NativeMCPToolConfigOutput? NativeMcp { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(NativeMcp))]
#endif
        public bool IsNativeMcp => NativeMcp != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolsItem3(global::ElevenLabs.NativeMCPToolConfigOutput value) => new ToolsItem3((global::ElevenLabs.NativeMCPToolConfigOutput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.NativeMCPToolConfigOutput?(ToolsItem3 @this) => @this.NativeMcp;

        /// <summary>
        /// 
        /// </summary>
        public ToolsItem3(global::ElevenLabs.NativeMCPToolConfigOutput? value)
        {
            NativeMcp = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ToolsItem3(
            global::ElevenLabs.PromptAgentOutputToolDiscriminatorType? type,
            global::ElevenLabs.WebhookToolConfigOutput? webhook,
            global::ElevenLabs.ClientToolConfigOutput? client,
            global::ElevenLabs.SystemToolConfigOutput? system,
            global::ElevenLabs.MCPToolConfigOutput? mcp,
            global::ElevenLabs.NativeMCPToolConfigOutput? nativeMcp
            )
        {
            Type = type;

            Webhook = webhook;
            Client = client;
            System = system;
            Mcp = mcp;
            NativeMcp = nativeMcp;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            NativeMcp as object ??
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
            Mcp?.ToString() ??
            NativeMcp?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsWebhook && !IsClient && !IsSystem && !IsMcp && !IsNativeMcp || !IsWebhook && IsClient && !IsSystem && !IsMcp && !IsNativeMcp || !IsWebhook && !IsClient && IsSystem && !IsMcp && !IsNativeMcp || !IsWebhook && !IsClient && !IsSystem && IsMcp && !IsNativeMcp || !IsWebhook && !IsClient && !IsSystem && !IsMcp && IsNativeMcp;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::ElevenLabs.WebhookToolConfigOutput?, TResult>? webhook = null,
            global::System.Func<global::ElevenLabs.ClientToolConfigOutput?, TResult>? client = null,
            global::System.Func<global::ElevenLabs.SystemToolConfigOutput?, TResult>? system = null,
            global::System.Func<global::ElevenLabs.MCPToolConfigOutput?, TResult>? mcp = null,
            global::System.Func<global::ElevenLabs.NativeMCPToolConfigOutput?, TResult>? nativeMcp = null,
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
            else if (IsNativeMcp && nativeMcp != null)
            {
                return nativeMcp(NativeMcp!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::ElevenLabs.WebhookToolConfigOutput?>? webhook = null,
            global::System.Action<global::ElevenLabs.ClientToolConfigOutput?>? client = null,
            global::System.Action<global::ElevenLabs.SystemToolConfigOutput?>? system = null,
            global::System.Action<global::ElevenLabs.MCPToolConfigOutput?>? mcp = null,
            global::System.Action<global::ElevenLabs.NativeMCPToolConfigOutput?>? nativeMcp = null,
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
            else if (IsNativeMcp)
            {
                nativeMcp?.Invoke(NativeMcp!);
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
                typeof(global::ElevenLabs.WebhookToolConfigOutput),
                Client,
                typeof(global::ElevenLabs.ClientToolConfigOutput),
                System,
                typeof(global::ElevenLabs.SystemToolConfigOutput),
                Mcp,
                typeof(global::ElevenLabs.MCPToolConfigOutput),
                NativeMcp,
                typeof(global::ElevenLabs.NativeMCPToolConfigOutput),
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
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.WebhookToolConfigOutput?>.Default.Equals(Webhook, other.Webhook) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.ClientToolConfigOutput?>.Default.Equals(Client, other.Client) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.SystemToolConfigOutput?>.Default.Equals(System, other.System) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.MCPToolConfigOutput?>.Default.Equals(Mcp, other.Mcp) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.NativeMCPToolConfigOutput?>.Default.Equals(NativeMcp, other.NativeMcp) 
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
