#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// The type of tool
    /// </summary>
    public readonly partial struct ToolsItem5 : global::System.IEquatable<ToolsItem5>
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
        /// 
        /// </summary>
        public bool TryPickWebhook(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.WebhookToolConfigOutput? value)
        {
            value = Webhook;
            return IsWebhook;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::ElevenLabs.WebhookToolConfigOutput PickWebhook() => IsWebhook
            ? Webhook!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Webhook' but the value was {ToString()}.");

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
        /// 
        /// </summary>
        public bool TryPickClient(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.ClientToolConfigOutput? value)
        {
            value = Client;
            return IsClient;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::ElevenLabs.ClientToolConfigOutput PickClient() => IsClient
            ? Client!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Client' but the value was {ToString()}.");

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
        public bool TryPickSystem(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.SystemToolConfigOutput? value)
        {
            value = System;
            return IsSystem;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::ElevenLabs.SystemToolConfigOutput PickSystem() => IsSystem
            ? System!
            : throw new global::System.InvalidOperationException($"Expected union variant 'System' but the value was {ToString()}.");

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
        public bool TryPickMcp(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.MCPToolConfigOutput? value)
        {
            value = Mcp;
            return IsMcp;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::ElevenLabs.MCPToolConfigOutput PickMcp() => IsMcp
            ? Mcp!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Mcp' but the value was {ToString()}.");

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
        /// 
        /// </summary>
        public bool TryPickApiIntegrationWebhook(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.ApiIntegrationWebhookToolConfigOutput? value)
        {
            value = ApiIntegrationWebhook;
            return IsApiIntegrationWebhook;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::ElevenLabs.ApiIntegrationWebhookToolConfigOutput PickApiIntegrationWebhook() => IsApiIntegrationWebhook
            ? ApiIntegrationWebhook!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ApiIntegrationWebhook' but the value was {ToString()}.");

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
        public bool TryPickSmb(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.SMBToolConfig? value)
        {
            value = Smb;
            return IsSmb;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::ElevenLabs.SMBToolConfig PickSmb() => IsSmb
            ? Smb!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Smb' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolsItem5(global::ElevenLabs.WebhookToolConfigOutput value) => new ToolsItem5((global::ElevenLabs.WebhookToolConfigOutput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.WebhookToolConfigOutput?(ToolsItem5 @this) => @this.Webhook;

        /// <summary>
        /// 
        /// </summary>
        public ToolsItem5(global::ElevenLabs.WebhookToolConfigOutput? value)
        {
            Webhook = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ToolsItem5 FromWebhook(global::ElevenLabs.WebhookToolConfigOutput? value) => new ToolsItem5(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolsItem5(global::ElevenLabs.ClientToolConfigOutput value) => new ToolsItem5((global::ElevenLabs.ClientToolConfigOutput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.ClientToolConfigOutput?(ToolsItem5 @this) => @this.Client;

        /// <summary>
        /// 
        /// </summary>
        public ToolsItem5(global::ElevenLabs.ClientToolConfigOutput? value)
        {
            Client = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ToolsItem5 FromClient(global::ElevenLabs.ClientToolConfigOutput? value) => new ToolsItem5(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolsItem5(global::ElevenLabs.SystemToolConfigOutput value) => new ToolsItem5((global::ElevenLabs.SystemToolConfigOutput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.SystemToolConfigOutput?(ToolsItem5 @this) => @this.System;

        /// <summary>
        /// 
        /// </summary>
        public ToolsItem5(global::ElevenLabs.SystemToolConfigOutput? value)
        {
            System = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ToolsItem5 FromSystem(global::ElevenLabs.SystemToolConfigOutput? value) => new ToolsItem5(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolsItem5(global::ElevenLabs.MCPToolConfigOutput value) => new ToolsItem5((global::ElevenLabs.MCPToolConfigOutput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.MCPToolConfigOutput?(ToolsItem5 @this) => @this.Mcp;

        /// <summary>
        /// 
        /// </summary>
        public ToolsItem5(global::ElevenLabs.MCPToolConfigOutput? value)
        {
            Mcp = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ToolsItem5 FromMcp(global::ElevenLabs.MCPToolConfigOutput? value) => new ToolsItem5(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolsItem5(global::ElevenLabs.ApiIntegrationWebhookToolConfigOutput value) => new ToolsItem5((global::ElevenLabs.ApiIntegrationWebhookToolConfigOutput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.ApiIntegrationWebhookToolConfigOutput?(ToolsItem5 @this) => @this.ApiIntegrationWebhook;

        /// <summary>
        /// 
        /// </summary>
        public ToolsItem5(global::ElevenLabs.ApiIntegrationWebhookToolConfigOutput? value)
        {
            ApiIntegrationWebhook = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ToolsItem5 FromApiIntegrationWebhook(global::ElevenLabs.ApiIntegrationWebhookToolConfigOutput? value) => new ToolsItem5(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolsItem5(global::ElevenLabs.SMBToolConfig value) => new ToolsItem5((global::ElevenLabs.SMBToolConfig?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.SMBToolConfig?(ToolsItem5 @this) => @this.Smb;

        /// <summary>
        /// 
        /// </summary>
        public ToolsItem5(global::ElevenLabs.SMBToolConfig? value)
        {
            Smb = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ToolsItem5 FromSmb(global::ElevenLabs.SMBToolConfig? value) => new ToolsItem5(value);

        /// <summary>
        /// 
        /// </summary>
        public ToolsItem5(
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
            global::System.Func<global::ElevenLabs.WebhookToolConfigOutput, TResult>? webhook = null,
            global::System.Func<global::ElevenLabs.ClientToolConfigOutput, TResult>? client = null,
            global::System.Func<global::ElevenLabs.SystemToolConfigOutput, TResult>? system = null,
            global::System.Func<global::ElevenLabs.MCPToolConfigOutput, TResult>? mcp = null,
            global::System.Func<global::ElevenLabs.ApiIntegrationWebhookToolConfigOutput, TResult>? apiIntegrationWebhook = null,
            global::System.Func<global::ElevenLabs.SMBToolConfig, TResult>? smb = null,
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
            global::System.Action<global::ElevenLabs.WebhookToolConfigOutput>? webhook = null,

            global::System.Action<global::ElevenLabs.ClientToolConfigOutput>? client = null,

            global::System.Action<global::ElevenLabs.SystemToolConfigOutput>? system = null,

            global::System.Action<global::ElevenLabs.MCPToolConfigOutput>? mcp = null,

            global::System.Action<global::ElevenLabs.ApiIntegrationWebhookToolConfigOutput>? apiIntegrationWebhook = null,

            global::System.Action<global::ElevenLabs.SMBToolConfig>? smb = null,
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
        public void Switch(
            global::System.Action<global::ElevenLabs.WebhookToolConfigOutput>? webhook = null,
            global::System.Action<global::ElevenLabs.ClientToolConfigOutput>? client = null,
            global::System.Action<global::ElevenLabs.SystemToolConfigOutput>? system = null,
            global::System.Action<global::ElevenLabs.MCPToolConfigOutput>? mcp = null,
            global::System.Action<global::ElevenLabs.ApiIntegrationWebhookToolConfigOutput>? apiIntegrationWebhook = null,
            global::System.Action<global::ElevenLabs.SMBToolConfig>? smb = null,
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
        public bool Equals(ToolsItem5 other)
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
        public static bool operator ==(ToolsItem5 obj1, ToolsItem5 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ToolsItem5>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ToolsItem5 obj1, ToolsItem5 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ToolsItem5 o && Equals(o);
        }
    }
}
