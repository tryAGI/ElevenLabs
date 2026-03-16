#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// The type of tool
    /// </summary>
    public readonly partial struct ToolsItem4 : global::System.IEquatable<ToolsItem4>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::ElevenLabs.PromptAgentAPIModelOutputToolDiscriminatorType? Type { get; }

        /// <summary>
        /// A webhook tool is a tool that calls an external webhook from our server<br/>
        /// Example: {"response_timeout_secs":20,"type":"webhook"}
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
        /// A client tool is one that sends an event to the user's client to trigger something client side<br/>
        /// Example: {"expects_response":false,"type":"client"}
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
        /// An MCP tool configuration that can be used to call MCP servers
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
#if NET6_0_OR_GREATER
        public global::ElevenLabs.ApiIntegrationWebhookToolConfigOutput? ApiIntegrationWebhook { get; init; }
#else
        public global::ElevenLabs.ApiIntegrationWebhookToolConfigOutput? ApiIntegrationWebhook { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ApiIntegrationWebhook))]
#endif
        public bool IsApiIntegrationWebhook => ApiIntegrationWebhook != null;

        /// <summary>
        /// SMB tool configuration that wraps SMB tool parameters.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.SMBToolConfig? Smb { get; init; }
#else
        public global::ElevenLabs.SMBToolConfig? Smb { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Smb))]
#endif
        public bool IsSmb => Smb != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolsItem4(global::ElevenLabs.WebhookToolConfigOutput value) => new ToolsItem4((global::ElevenLabs.WebhookToolConfigOutput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.WebhookToolConfigOutput?(ToolsItem4 @this) => @this.Webhook;

        /// <summary>
        /// 
        /// </summary>
        public ToolsItem4(global::ElevenLabs.WebhookToolConfigOutput? value)
        {
            Webhook = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolsItem4(global::ElevenLabs.ClientToolConfigOutput value) => new ToolsItem4((global::ElevenLabs.ClientToolConfigOutput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.ClientToolConfigOutput?(ToolsItem4 @this) => @this.Client;

        /// <summary>
        /// 
        /// </summary>
        public ToolsItem4(global::ElevenLabs.ClientToolConfigOutput? value)
        {
            Client = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolsItem4(global::ElevenLabs.SystemToolConfigOutput value) => new ToolsItem4((global::ElevenLabs.SystemToolConfigOutput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.SystemToolConfigOutput?(ToolsItem4 @this) => @this.System;

        /// <summary>
        /// 
        /// </summary>
        public ToolsItem4(global::ElevenLabs.SystemToolConfigOutput? value)
        {
            System = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolsItem4(global::ElevenLabs.MCPToolConfigOutput value) => new ToolsItem4((global::ElevenLabs.MCPToolConfigOutput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.MCPToolConfigOutput?(ToolsItem4 @this) => @this.Mcp;

        /// <summary>
        /// 
        /// </summary>
        public ToolsItem4(global::ElevenLabs.MCPToolConfigOutput? value)
        {
            Mcp = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolsItem4(global::ElevenLabs.ApiIntegrationWebhookToolConfigOutput value) => new ToolsItem4((global::ElevenLabs.ApiIntegrationWebhookToolConfigOutput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.ApiIntegrationWebhookToolConfigOutput?(ToolsItem4 @this) => @this.ApiIntegrationWebhook;

        /// <summary>
        /// 
        /// </summary>
        public ToolsItem4(global::ElevenLabs.ApiIntegrationWebhookToolConfigOutput? value)
        {
            ApiIntegrationWebhook = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolsItem4(global::ElevenLabs.SMBToolConfig value) => new ToolsItem4((global::ElevenLabs.SMBToolConfig?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.SMBToolConfig?(ToolsItem4 @this) => @this.Smb;

        /// <summary>
        /// 
        /// </summary>
        public ToolsItem4(global::ElevenLabs.SMBToolConfig? value)
        {
            Smb = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ToolsItem4(
            global::ElevenLabs.PromptAgentAPIModelOutputToolDiscriminatorType? type,
            global::ElevenLabs.WebhookToolConfigOutput? webhook,
            global::ElevenLabs.ClientToolConfigOutput? client,
            global::ElevenLabs.SystemToolConfigOutput? system,
            global::ElevenLabs.MCPToolConfigOutput? mcp,
            global::ElevenLabs.ApiIntegrationWebhookToolConfigOutput? apiIntegrationWebhook,
            global::ElevenLabs.SMBToolConfig? smb
            )
        {
            Type = type;

            Webhook = webhook;
            Client = client;
            System = system;
            Mcp = mcp;
            ApiIntegrationWebhook = apiIntegrationWebhook;
            Smb = smb;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Smb as object ??
            ApiIntegrationWebhook as object ??
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
            ApiIntegrationWebhook?.ToString() ??
            Smb?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsWebhook && !IsClient && !IsSystem && !IsMcp && !IsApiIntegrationWebhook && !IsSmb || !IsWebhook && IsClient && !IsSystem && !IsMcp && !IsApiIntegrationWebhook && !IsSmb || !IsWebhook && !IsClient && IsSystem && !IsMcp && !IsApiIntegrationWebhook && !IsSmb || !IsWebhook && !IsClient && !IsSystem && IsMcp && !IsApiIntegrationWebhook && !IsSmb || !IsWebhook && !IsClient && !IsSystem && !IsMcp && IsApiIntegrationWebhook && !IsSmb || !IsWebhook && !IsClient && !IsSystem && !IsMcp && !IsApiIntegrationWebhook && IsSmb;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::ElevenLabs.WebhookToolConfigOutput?, TResult>? webhook = null,
            global::System.Func<global::ElevenLabs.ClientToolConfigOutput?, TResult>? client = null,
            global::System.Func<global::ElevenLabs.SystemToolConfigOutput?, TResult>? system = null,
            global::System.Func<global::ElevenLabs.MCPToolConfigOutput?, TResult>? mcp = null,
            global::System.Func<global::ElevenLabs.ApiIntegrationWebhookToolConfigOutput?, TResult>? apiIntegrationWebhook = null,
            global::System.Func<global::ElevenLabs.SMBToolConfig?, TResult>? smb = null,
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
            else if (IsApiIntegrationWebhook && apiIntegrationWebhook != null)
            {
                return apiIntegrationWebhook(ApiIntegrationWebhook!);
            }
            else if (IsSmb && smb != null)
            {
                return smb(Smb!);
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
            global::System.Action<global::ElevenLabs.ApiIntegrationWebhookToolConfigOutput?>? apiIntegrationWebhook = null,
            global::System.Action<global::ElevenLabs.SMBToolConfig?>? smb = null,
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
            else if (IsApiIntegrationWebhook)
            {
                apiIntegrationWebhook?.Invoke(ApiIntegrationWebhook!);
            }
            else if (IsSmb)
            {
                smb?.Invoke(Smb!);
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
                ApiIntegrationWebhook,
                typeof(global::ElevenLabs.ApiIntegrationWebhookToolConfigOutput),
                Smb,
                typeof(global::ElevenLabs.SMBToolConfig),
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
        public bool Equals(ToolsItem4 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.WebhookToolConfigOutput?>.Default.Equals(Webhook, other.Webhook) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.ClientToolConfigOutput?>.Default.Equals(Client, other.Client) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.SystemToolConfigOutput?>.Default.Equals(System, other.System) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.MCPToolConfigOutput?>.Default.Equals(Mcp, other.Mcp) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.ApiIntegrationWebhookToolConfigOutput?>.Default.Equals(ApiIntegrationWebhook, other.ApiIntegrationWebhook) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.SMBToolConfig?>.Default.Equals(Smb, other.Smb) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ToolsItem4 obj1, ToolsItem4 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ToolsItem4>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ToolsItem4 obj1, ToolsItem4 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ToolsItem4 o && Equals(o);
        }
    }
}
