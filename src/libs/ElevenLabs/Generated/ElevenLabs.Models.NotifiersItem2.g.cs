#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct NotifiersItem2 : global::System.IEquatable<NotifiersItem2>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::ElevenLabs.AlertingSettingsResponseNotifierDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.AlertingWebhookNotifierResponse? Webhook { get; init; }
#else
        public global::ElevenLabs.AlertingWebhookNotifierResponse? Webhook { get; }
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
            out global::ElevenLabs.AlertingWebhookNotifierResponse? value)
        {
            value = Webhook;
            return IsWebhook;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::ElevenLabs.AlertingWebhookNotifierResponse PickWebhook() => IsWebhook
            ? Webhook!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Webhook' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.AlertingIntegrationNotifierResponse? Integration { get; init; }
#else
        public global::ElevenLabs.AlertingIntegrationNotifierResponse? Integration { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Integration))]
#endif
        public bool IsIntegration => Integration != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickIntegration(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.AlertingIntegrationNotifierResponse? value)
        {
            value = Integration;
            return IsIntegration;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::ElevenLabs.AlertingIntegrationNotifierResponse PickIntegration() => IsIntegration
            ? Integration!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Integration' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator NotifiersItem2(global::ElevenLabs.AlertingWebhookNotifierResponse value) => new NotifiersItem2((global::ElevenLabs.AlertingWebhookNotifierResponse?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.AlertingWebhookNotifierResponse?(NotifiersItem2 @this) => @this.Webhook;

        /// <summary>
        /// 
        /// </summary>
        public NotifiersItem2(global::ElevenLabs.AlertingWebhookNotifierResponse? value)
        {
            Webhook = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static NotifiersItem2 FromWebhook(global::ElevenLabs.AlertingWebhookNotifierResponse? value) => new NotifiersItem2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator NotifiersItem2(global::ElevenLabs.AlertingIntegrationNotifierResponse value) => new NotifiersItem2((global::ElevenLabs.AlertingIntegrationNotifierResponse?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.AlertingIntegrationNotifierResponse?(NotifiersItem2 @this) => @this.Integration;

        /// <summary>
        /// 
        /// </summary>
        public NotifiersItem2(global::ElevenLabs.AlertingIntegrationNotifierResponse? value)
        {
            Integration = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static NotifiersItem2 FromIntegration(global::ElevenLabs.AlertingIntegrationNotifierResponse? value) => new NotifiersItem2(value);

        /// <summary>
        /// 
        /// </summary>
        public NotifiersItem2(
            global::ElevenLabs.AlertingSettingsResponseNotifierDiscriminatorType? type,
            global::ElevenLabs.AlertingWebhookNotifierResponse? webhook,
            global::ElevenLabs.AlertingIntegrationNotifierResponse? integration
            )
        {
            Type = type;

            Webhook = webhook;
            Integration = integration;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Integration as object ??
            Webhook as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Webhook?.ToString() ??
            Integration?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsWebhook && !IsIntegration || !IsWebhook && IsIntegration;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::ElevenLabs.AlertingWebhookNotifierResponse, TResult>? webhook = null,
            global::System.Func<global::ElevenLabs.AlertingIntegrationNotifierResponse, TResult>? integration = null,
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
            else if (IsIntegration && integration != null)
            {
                return integration(Integration!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::ElevenLabs.AlertingWebhookNotifierResponse>? webhook = null,

            global::System.Action<global::ElevenLabs.AlertingIntegrationNotifierResponse>? integration = null,
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
            else if (IsIntegration)
            {
                integration?.Invoke(Integration!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::ElevenLabs.AlertingWebhookNotifierResponse>? webhook = null,
            global::System.Action<global::ElevenLabs.AlertingIntegrationNotifierResponse>? integration = null,
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
            else if (IsIntegration)
            {
                integration?.Invoke(Integration!);
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
                typeof(global::ElevenLabs.AlertingWebhookNotifierResponse),
                Integration,
                typeof(global::ElevenLabs.AlertingIntegrationNotifierResponse),
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
        public bool Equals(NotifiersItem2 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.AlertingWebhookNotifierResponse?>.Default.Equals(Webhook, other.Webhook) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.AlertingIntegrationNotifierResponse?>.Default.Equals(Integration, other.Integration) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(NotifiersItem2 obj1, NotifiersItem2 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<NotifiersItem2>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(NotifiersItem2 obj1, NotifiersItem2 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is NotifiersItem2 o && Equals(o);
        }
    }
}
