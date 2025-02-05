#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ToolConfig2 : global::System.IEquatable<ToolConfig2>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::ElevenLabs.ToolResponseModelToolConfigDiscriminatorType? Type { get; }

        /// <summary>
        /// A webhook tool is a tool that calls an external webhook from our server
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.WebhookToolConfig? Webhook { get; init; }
#else
        public global::ElevenLabs.WebhookToolConfig? Webhook { get; }
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
        public static implicit operator ToolConfig2(global::ElevenLabs.WebhookToolConfig value) => new ToolConfig2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.WebhookToolConfig?(ToolConfig2 @this) => @this.Webhook;

        /// <summary>
        /// 
        /// </summary>
        public ToolConfig2(global::ElevenLabs.WebhookToolConfig? value)
        {
            Webhook = value;
        }

        /// <summary>
        /// A client tool is one that sends an event to the user's client to trigger something client side
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.ClientToolConfig? Client { get; init; }
#else
        public global::ElevenLabs.ClientToolConfig? Client { get; }
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
        public static implicit operator ToolConfig2(global::ElevenLabs.ClientToolConfig value) => new ToolConfig2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.ClientToolConfig?(ToolConfig2 @this) => @this.Client;

        /// <summary>
        /// 
        /// </summary>
        public ToolConfig2(global::ElevenLabs.ClientToolConfig? value)
        {
            Client = value;
        }

        /// <summary>
        /// A system tool is a tool that is used to call a system method in the server
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.SystemToolConfig? System { get; init; }
#else
        public global::ElevenLabs.SystemToolConfig? System { get; }
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
        public static implicit operator ToolConfig2(global::ElevenLabs.SystemToolConfig value) => new ToolConfig2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.SystemToolConfig?(ToolConfig2 @this) => @this.System;

        /// <summary>
        /// 
        /// </summary>
        public ToolConfig2(global::ElevenLabs.SystemToolConfig? value)
        {
            System = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ToolConfig2(
            global::ElevenLabs.ToolResponseModelToolConfigDiscriminatorType? type,
            global::ElevenLabs.WebhookToolConfig? webhook,
            global::ElevenLabs.ClientToolConfig? client,
            global::ElevenLabs.SystemToolConfig? system
            )
        {
            Type = type;

            Webhook = webhook;
            Client = client;
            System = system;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            System as object ??
            Client as object ??
            Webhook as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsWebhook && !IsClient && !IsSystem || !IsWebhook && IsClient && !IsSystem || !IsWebhook && !IsClient && IsSystem;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::ElevenLabs.WebhookToolConfig?, TResult>? webhook = null,
            global::System.Func<global::ElevenLabs.ClientToolConfig?, TResult>? client = null,
            global::System.Func<global::ElevenLabs.SystemToolConfig?, TResult>? system = null,
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

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::ElevenLabs.WebhookToolConfig?>? webhook = null,
            global::System.Action<global::ElevenLabs.ClientToolConfig?>? client = null,
            global::System.Action<global::ElevenLabs.SystemToolConfig?>? system = null,
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
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Webhook,
                typeof(global::ElevenLabs.WebhookToolConfig),
                Client,
                typeof(global::ElevenLabs.ClientToolConfig),
                System,
                typeof(global::ElevenLabs.SystemToolConfig),
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
        public bool Equals(ToolConfig2 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.WebhookToolConfig?>.Default.Equals(Webhook, other.Webhook) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.ClientToolConfig?>.Default.Equals(Client, other.Client) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.SystemToolConfig?>.Default.Equals(System, other.System) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ToolConfig2 obj1, ToolConfig2 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ToolConfig2>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ToolConfig2 obj1, ToolConfig2 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ToolConfig2 o && Equals(o);
        }
    }
}
