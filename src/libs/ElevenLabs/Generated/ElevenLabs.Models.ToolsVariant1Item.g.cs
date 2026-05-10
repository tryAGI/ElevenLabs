#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// The type of tool
    /// </summary>
    public readonly partial struct ToolsVariant1Item : global::System.IEquatable<ToolsVariant1Item>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::ElevenLabs.PromptAgentAPIModelWorkflowOverrideInputToolsVariant1ItemDiscriminatorType? Type { get; }

        /// <summary>
        /// A webhook tool is a tool that calls an external webhook from our server<br/>
        /// Example: {"response_timeout_secs":20,"type":"webhook"}
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
        public bool TryPickWebhook(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.WebhookToolConfigInput? value)
        {
            value = Webhook;
            return IsWebhook;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::ElevenLabs.WebhookToolConfigInput PickWebhook() => IsWebhook
            ? Webhook!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Webhook' but the value was {ToString()}.");

        /// <summary>
        /// A client tool is one that sends an event to the user's client to trigger something client side<br/>
        /// Example: {"expects_response":false,"type":"client"}
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
        public bool TryPickClient(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.ClientToolConfigInput? value)
        {
            value = Client;
            return IsClient;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::ElevenLabs.ClientToolConfigInput PickClient() => IsClient
            ? Client!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Client' but the value was {ToString()}.");

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
        public bool TryPickSystem(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.SystemToolConfigInput? value)
        {
            value = System;
            return IsSystem;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::ElevenLabs.SystemToolConfigInput PickSystem() => IsSystem
            ? System!
            : throw new global::System.InvalidOperationException($"Expected union variant 'System' but the value was {ToString()}.");

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
        public bool TryPickMcp(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.MCPToolConfigInput? value)
        {
            value = Mcp;
            return IsMcp;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::ElevenLabs.MCPToolConfigInput PickMcp() => IsMcp
            ? Mcp!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Mcp' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.ApiIntegrationWebhookToolConfigInput? ApiIntegrationWebhook { get; init; }
#else
        public global::ElevenLabs.ApiIntegrationWebhookToolConfigInput? ApiIntegrationWebhook { get; }
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
            out global::ElevenLabs.ApiIntegrationWebhookToolConfigInput? value)
        {
            value = ApiIntegrationWebhook;
            return IsApiIntegrationWebhook;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::ElevenLabs.ApiIntegrationWebhookToolConfigInput PickApiIntegrationWebhook() => IsApiIntegrationWebhook
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
        public static implicit operator ToolsVariant1Item(global::ElevenLabs.WebhookToolConfigInput value) => new ToolsVariant1Item((global::ElevenLabs.WebhookToolConfigInput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.WebhookToolConfigInput?(ToolsVariant1Item @this) => @this.Webhook;

        /// <summary>
        /// 
        /// </summary>
        public ToolsVariant1Item(global::ElevenLabs.WebhookToolConfigInput? value)
        {
            Webhook = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ToolsVariant1Item FromWebhook(global::ElevenLabs.WebhookToolConfigInput? value) => new ToolsVariant1Item(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolsVariant1Item(global::ElevenLabs.ClientToolConfigInput value) => new ToolsVariant1Item((global::ElevenLabs.ClientToolConfigInput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.ClientToolConfigInput?(ToolsVariant1Item @this) => @this.Client;

        /// <summary>
        /// 
        /// </summary>
        public ToolsVariant1Item(global::ElevenLabs.ClientToolConfigInput? value)
        {
            Client = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ToolsVariant1Item FromClient(global::ElevenLabs.ClientToolConfigInput? value) => new ToolsVariant1Item(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolsVariant1Item(global::ElevenLabs.SystemToolConfigInput value) => new ToolsVariant1Item((global::ElevenLabs.SystemToolConfigInput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.SystemToolConfigInput?(ToolsVariant1Item @this) => @this.System;

        /// <summary>
        /// 
        /// </summary>
        public ToolsVariant1Item(global::ElevenLabs.SystemToolConfigInput? value)
        {
            System = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ToolsVariant1Item FromSystem(global::ElevenLabs.SystemToolConfigInput? value) => new ToolsVariant1Item(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolsVariant1Item(global::ElevenLabs.MCPToolConfigInput value) => new ToolsVariant1Item((global::ElevenLabs.MCPToolConfigInput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.MCPToolConfigInput?(ToolsVariant1Item @this) => @this.Mcp;

        /// <summary>
        /// 
        /// </summary>
        public ToolsVariant1Item(global::ElevenLabs.MCPToolConfigInput? value)
        {
            Mcp = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ToolsVariant1Item FromMcp(global::ElevenLabs.MCPToolConfigInput? value) => new ToolsVariant1Item(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolsVariant1Item(global::ElevenLabs.ApiIntegrationWebhookToolConfigInput value) => new ToolsVariant1Item((global::ElevenLabs.ApiIntegrationWebhookToolConfigInput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.ApiIntegrationWebhookToolConfigInput?(ToolsVariant1Item @this) => @this.ApiIntegrationWebhook;

        /// <summary>
        /// 
        /// </summary>
        public ToolsVariant1Item(global::ElevenLabs.ApiIntegrationWebhookToolConfigInput? value)
        {
            ApiIntegrationWebhook = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ToolsVariant1Item FromApiIntegrationWebhook(global::ElevenLabs.ApiIntegrationWebhookToolConfigInput? value) => new ToolsVariant1Item(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolsVariant1Item(global::ElevenLabs.SMBToolConfig value) => new ToolsVariant1Item((global::ElevenLabs.SMBToolConfig?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.SMBToolConfig?(ToolsVariant1Item @this) => @this.Smb;

        /// <summary>
        /// 
        /// </summary>
        public ToolsVariant1Item(global::ElevenLabs.SMBToolConfig? value)
        {
            Smb = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ToolsVariant1Item FromSmb(global::ElevenLabs.SMBToolConfig? value) => new ToolsVariant1Item(value);

        /// <summary>
        /// 
        /// </summary>
        public ToolsVariant1Item(
            global::ElevenLabs.PromptAgentAPIModelWorkflowOverrideInputToolsVariant1ItemDiscriminatorType? type,
            global::ElevenLabs.WebhookToolConfigInput? webhook,
            global::ElevenLabs.ClientToolConfigInput? client,
            global::ElevenLabs.SystemToolConfigInput? system,
            global::ElevenLabs.MCPToolConfigInput? mcp,
            global::ElevenLabs.ApiIntegrationWebhookToolConfigInput? apiIntegrationWebhook,
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
            global::System.Func<global::ElevenLabs.WebhookToolConfigInput, TResult>? webhook = null,
            global::System.Func<global::ElevenLabs.ClientToolConfigInput, TResult>? client = null,
            global::System.Func<global::ElevenLabs.SystemToolConfigInput, TResult>? system = null,
            global::System.Func<global::ElevenLabs.MCPToolConfigInput, TResult>? mcp = null,
            global::System.Func<global::ElevenLabs.ApiIntegrationWebhookToolConfigInput, TResult>? apiIntegrationWebhook = null,
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
            global::System.Action<global::ElevenLabs.WebhookToolConfigInput>? webhook = null,

            global::System.Action<global::ElevenLabs.ClientToolConfigInput>? client = null,

            global::System.Action<global::ElevenLabs.SystemToolConfigInput>? system = null,

            global::System.Action<global::ElevenLabs.MCPToolConfigInput>? mcp = null,

            global::System.Action<global::ElevenLabs.ApiIntegrationWebhookToolConfigInput>? apiIntegrationWebhook = null,

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
            global::System.Action<global::ElevenLabs.WebhookToolConfigInput>? webhook = null,
            global::System.Action<global::ElevenLabs.ClientToolConfigInput>? client = null,
            global::System.Action<global::ElevenLabs.SystemToolConfigInput>? system = null,
            global::System.Action<global::ElevenLabs.MCPToolConfigInput>? mcp = null,
            global::System.Action<global::ElevenLabs.ApiIntegrationWebhookToolConfigInput>? apiIntegrationWebhook = null,
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
                typeof(global::ElevenLabs.WebhookToolConfigInput),
                Client,
                typeof(global::ElevenLabs.ClientToolConfigInput),
                System,
                typeof(global::ElevenLabs.SystemToolConfigInput),
                Mcp,
                typeof(global::ElevenLabs.MCPToolConfigInput),
                ApiIntegrationWebhook,
                typeof(global::ElevenLabs.ApiIntegrationWebhookToolConfigInput),
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
        public bool Equals(ToolsVariant1Item other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.WebhookToolConfigInput?>.Default.Equals(Webhook, other.Webhook) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.ClientToolConfigInput?>.Default.Equals(Client, other.Client) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.SystemToolConfigInput?>.Default.Equals(System, other.System) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.MCPToolConfigInput?>.Default.Equals(Mcp, other.Mcp) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.ApiIntegrationWebhookToolConfigInput?>.Default.Equals(ApiIntegrationWebhook, other.ApiIntegrationWebhook) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.SMBToolConfig?>.Default.Equals(Smb, other.Smb) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ToolsVariant1Item obj1, ToolsVariant1Item obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ToolsVariant1Item>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ToolsVariant1Item obj1, ToolsVariant1Item obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ToolsVariant1Item o && Equals(o);
        }
    }
}
