#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct NotifiersItem : global::System.IEquatable<NotifiersItem>
    {
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AlertingSettingsNotifierDiscriminatorType? Type { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.AlertingWebhookNotifier? Webhook { get; init; }
#else
        public global::ElevenLabs.AlertingWebhookNotifier? Webhook { get; }
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
            out global::ElevenLabs.AlertingWebhookNotifier? value)
        {
            value = Webhook;
            return IsWebhook;
        }

        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AlertingWebhookNotifier PickWebhook() => IsWebhook
            ? Webhook!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Webhook' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.AlertingIntegrationNotifier? Integration { get; init; }
#else
        public global::ElevenLabs.AlertingIntegrationNotifier? Integration { get; }
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
            out global::ElevenLabs.AlertingIntegrationNotifier? value)
        {
            value = Integration;
            return IsIntegration;
        }

        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AlertingIntegrationNotifier PickIntegration() => IsIntegration
            ? Integration!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Integration' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator NotifiersItem(global::ElevenLabs.AlertingWebhookNotifier value) => new NotifiersItem((global::ElevenLabs.AlertingWebhookNotifier?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::ElevenLabs.AlertingWebhookNotifier?(NotifiersItem @this) => @this.Webhook;

        /// <summary>
        ///
        /// </summary>
        public NotifiersItem(global::ElevenLabs.AlertingWebhookNotifier? value)
        {
            Webhook = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static NotifiersItem FromWebhook(global::ElevenLabs.AlertingWebhookNotifier? value) => new NotifiersItem(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator NotifiersItem(global::ElevenLabs.AlertingIntegrationNotifier value) => new NotifiersItem((global::ElevenLabs.AlertingIntegrationNotifier?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::ElevenLabs.AlertingIntegrationNotifier?(NotifiersItem @this) => @this.Integration;

        /// <summary>
        ///
        /// </summary>
        public NotifiersItem(global::ElevenLabs.AlertingIntegrationNotifier? value)
        {
            Integration = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static NotifiersItem FromIntegration(global::ElevenLabs.AlertingIntegrationNotifier? value) => new NotifiersItem(value);

        /// <summary>
        ///
        /// </summary>
        public NotifiersItem(
            global::ElevenLabs.AlertingSettingsNotifierDiscriminatorType? type,
            global::ElevenLabs.AlertingWebhookNotifier? webhook,
            global::ElevenLabs.AlertingIntegrationNotifier? integration
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
            global::System.Func<global::ElevenLabs.AlertingWebhookNotifier, TResult>? webhook = null,
            global::System.Func<global::ElevenLabs.AlertingIntegrationNotifier, TResult>? integration = null,
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
            global::System.Action<global::ElevenLabs.AlertingWebhookNotifier>? webhook = null,

            global::System.Action<global::ElevenLabs.AlertingIntegrationNotifier>? integration = null,
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
            global::System.Action<global::ElevenLabs.AlertingWebhookNotifier>? webhook = null,
            global::System.Action<global::ElevenLabs.AlertingIntegrationNotifier>? integration = null,
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
                typeof(global::ElevenLabs.AlertingWebhookNotifier),
                Integration,
                typeof(global::ElevenLabs.AlertingIntegrationNotifier),
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
        public bool Equals(NotifiersItem other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.AlertingWebhookNotifier?>.Default.Equals(Webhook, other.Webhook) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.AlertingIntegrationNotifier?>.Default.Equals(Integration, other.Integration)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(NotifiersItem obj1, NotifiersItem obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<NotifiersItem>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(NotifiersItem obj1, NotifiersItem obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is NotifiersItem o && Equals(o);
        }
    }
}
