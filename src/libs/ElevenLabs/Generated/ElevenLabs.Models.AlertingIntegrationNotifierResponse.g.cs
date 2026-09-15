#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct AlertingIntegrationNotifierResponse : global::System.IEquatable<AlertingIntegrationNotifierResponse>
    {
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AlertingIntegrationNotifierResponseDiscriminatorIntegrationType? IntegrationType { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.AlertingPagerDutyNotifierResponse? Pagerduty { get; init; }
#else
        public global::ElevenLabs.AlertingPagerDutyNotifierResponse? Pagerduty { get; }
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
            out global::ElevenLabs.AlertingPagerDutyNotifierResponse? value)
        {
            value = Pagerduty;
            return IsPagerduty;
        }

        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AlertingPagerDutyNotifierResponse PickPagerduty() => IsPagerduty
            ? Pagerduty!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Pagerduty' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.AlertingSlackNotifierResponse? Slack { get; init; }
#else
        public global::ElevenLabs.AlertingSlackNotifierResponse? Slack { get; }
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
            out global::ElevenLabs.AlertingSlackNotifierResponse? value)
        {
            value = Slack;
            return IsSlack;
        }

        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AlertingSlackNotifierResponse PickSlack() => IsSlack
            ? Slack!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Slack' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator AlertingIntegrationNotifierResponse(global::ElevenLabs.AlertingPagerDutyNotifierResponse value) => new AlertingIntegrationNotifierResponse((global::ElevenLabs.AlertingPagerDutyNotifierResponse?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::ElevenLabs.AlertingPagerDutyNotifierResponse?(AlertingIntegrationNotifierResponse @this) => @this.Pagerduty;

        /// <summary>
        ///
        /// </summary>
        public AlertingIntegrationNotifierResponse(global::ElevenLabs.AlertingPagerDutyNotifierResponse? value)
        {
            Pagerduty = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AlertingIntegrationNotifierResponse FromPagerduty(global::ElevenLabs.AlertingPagerDutyNotifierResponse? value) => new AlertingIntegrationNotifierResponse(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AlertingIntegrationNotifierResponse(global::ElevenLabs.AlertingSlackNotifierResponse value) => new AlertingIntegrationNotifierResponse((global::ElevenLabs.AlertingSlackNotifierResponse?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::ElevenLabs.AlertingSlackNotifierResponse?(AlertingIntegrationNotifierResponse @this) => @this.Slack;

        /// <summary>
        ///
        /// </summary>
        public AlertingIntegrationNotifierResponse(global::ElevenLabs.AlertingSlackNotifierResponse? value)
        {
            Slack = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AlertingIntegrationNotifierResponse FromSlack(global::ElevenLabs.AlertingSlackNotifierResponse? value) => new AlertingIntegrationNotifierResponse(value);

        /// <summary>
        ///
        /// </summary>
        public AlertingIntegrationNotifierResponse(
            global::ElevenLabs.AlertingIntegrationNotifierResponseDiscriminatorIntegrationType? integrationType,
            global::ElevenLabs.AlertingPagerDutyNotifierResponse? pagerduty,
            global::ElevenLabs.AlertingSlackNotifierResponse? slack
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
            global::System.Func<global::ElevenLabs.AlertingPagerDutyNotifierResponse, TResult>? pagerduty = null,
            global::System.Func<global::ElevenLabs.AlertingSlackNotifierResponse, TResult>? slack = null,
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
            global::System.Action<global::ElevenLabs.AlertingPagerDutyNotifierResponse>? pagerduty = null,

            global::System.Action<global::ElevenLabs.AlertingSlackNotifierResponse>? slack = null,
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
            global::System.Action<global::ElevenLabs.AlertingPagerDutyNotifierResponse>? pagerduty = null,
            global::System.Action<global::ElevenLabs.AlertingSlackNotifierResponse>? slack = null,
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
                typeof(global::ElevenLabs.AlertingPagerDutyNotifierResponse),
                Slack,
                typeof(global::ElevenLabs.AlertingSlackNotifierResponse),
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
        public bool Equals(AlertingIntegrationNotifierResponse other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.AlertingPagerDutyNotifierResponse?>.Default.Equals(Pagerduty, other.Pagerduty) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.AlertingSlackNotifierResponse?>.Default.Equals(Slack, other.Slack)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(AlertingIntegrationNotifierResponse obj1, AlertingIntegrationNotifierResponse obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AlertingIntegrationNotifierResponse>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(AlertingIntegrationNotifierResponse obj1, AlertingIntegrationNotifierResponse obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AlertingIntegrationNotifierResponse o && Equals(o);
        }
    }
}
