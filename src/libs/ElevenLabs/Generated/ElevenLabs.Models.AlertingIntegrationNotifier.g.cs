#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct AlertingIntegrationNotifier : global::System.IEquatable<AlertingIntegrationNotifier>
    {
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AlertingIntegrationNotifierDiscriminatorIntegrationType? IntegrationType { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.AlertingPagerDutyNotifier? Pagerduty { get; init; }
#else
        public global::ElevenLabs.AlertingPagerDutyNotifier? Pagerduty { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Pagerduty))]
#endif
        public bool IsPagerduty => Pagerduty != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickPagerduty(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.AlertingPagerDutyNotifier? value)
        {
            value = Pagerduty;
            return IsPagerduty;
        }

        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AlertingPagerDutyNotifier PickPagerduty() => IsPagerduty
            ? Pagerduty!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Pagerduty' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.AlertingSlackNotifier? Slack { get; init; }
#else
        public global::ElevenLabs.AlertingSlackNotifier? Slack { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Slack))]
#endif
        public bool IsSlack => Slack != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSlack(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.AlertingSlackNotifier? value)
        {
            value = Slack;
            return IsSlack;
        }

        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AlertingSlackNotifier PickSlack() => IsSlack
            ? Slack!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Slack' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator AlertingIntegrationNotifier(global::ElevenLabs.AlertingPagerDutyNotifier value) => new AlertingIntegrationNotifier((global::ElevenLabs.AlertingPagerDutyNotifier?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::ElevenLabs.AlertingPagerDutyNotifier?(AlertingIntegrationNotifier @this) => @this.Pagerduty;

        /// <summary>
        ///
        /// </summary>
        public AlertingIntegrationNotifier(global::ElevenLabs.AlertingPagerDutyNotifier? value)
        {
            Pagerduty = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AlertingIntegrationNotifier FromPagerduty(global::ElevenLabs.AlertingPagerDutyNotifier? value) => new AlertingIntegrationNotifier(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AlertingIntegrationNotifier(global::ElevenLabs.AlertingSlackNotifier value) => new AlertingIntegrationNotifier((global::ElevenLabs.AlertingSlackNotifier?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::ElevenLabs.AlertingSlackNotifier?(AlertingIntegrationNotifier @this) => @this.Slack;

        /// <summary>
        ///
        /// </summary>
        public AlertingIntegrationNotifier(global::ElevenLabs.AlertingSlackNotifier? value)
        {
            Slack = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AlertingIntegrationNotifier FromSlack(global::ElevenLabs.AlertingSlackNotifier? value) => new AlertingIntegrationNotifier(value);

        /// <summary>
        ///
        /// </summary>
        public AlertingIntegrationNotifier(
            global::ElevenLabs.AlertingIntegrationNotifierDiscriminatorIntegrationType? integrationType,
            global::ElevenLabs.AlertingPagerDutyNotifier? pagerduty,
            global::ElevenLabs.AlertingSlackNotifier? slack
            )
        {
            IntegrationType = integrationType;

            Pagerduty = pagerduty;
            Slack = slack;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Slack as object ??
            Pagerduty as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Pagerduty?.ToString() ??
            Slack?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsPagerduty && !IsSlack || !IsPagerduty && IsSlack;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::ElevenLabs.AlertingPagerDutyNotifier, TResult>? pagerduty = null,
            global::System.Func<global::ElevenLabs.AlertingSlackNotifier, TResult>? slack = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPagerduty && pagerduty != null)
            {
                return pagerduty(Pagerduty!);
            }
            else if (IsSlack && slack != null)
            {
                return slack(Slack!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::ElevenLabs.AlertingPagerDutyNotifier>? pagerduty = null,

            global::System.Action<global::ElevenLabs.AlertingSlackNotifier>? slack = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPagerduty)
            {
                pagerduty?.Invoke(Pagerduty!);
            }
            else if (IsSlack)
            {
                slack?.Invoke(Slack!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::ElevenLabs.AlertingPagerDutyNotifier>? pagerduty = null,
            global::System.Action<global::ElevenLabs.AlertingSlackNotifier>? slack = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsPagerduty)
            {
                pagerduty?.Invoke(Pagerduty!);
            }
            else if (IsSlack)
            {
                slack?.Invoke(Slack!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Pagerduty,
                typeof(global::ElevenLabs.AlertingPagerDutyNotifier),
                Slack,
                typeof(global::ElevenLabs.AlertingSlackNotifier),
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
        public bool Equals(AlertingIntegrationNotifier other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.AlertingPagerDutyNotifier?>.Default.Equals(Pagerduty, other.Pagerduty) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.AlertingSlackNotifier?>.Default.Equals(Slack, other.Slack)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(AlertingIntegrationNotifier obj1, AlertingIntegrationNotifier obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AlertingIntegrationNotifier>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(AlertingIntegrationNotifier obj1, AlertingIntegrationNotifier obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AlertingIntegrationNotifier o && Equals(o);
        }
    }
}
