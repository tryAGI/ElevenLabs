#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct WebhookTarget : global::System.IEquatable<WebhookTarget>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::ElevenLabs.WebhookTargetDiscriminatorType? Type { get; }

        /// <summary>
        /// Deliver the result to all of the workspace's configured flows webhooks.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.WebhookTargetAll? All { get; init; }
#else
        public global::ElevenLabs.WebhookTargetAll? All { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(All))]
#endif
        public bool IsAll => All != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickAll(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.WebhookTargetAll? value)
        {
            value = All;
            return IsAll;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::ElevenLabs.WebhookTargetAll PickAll() => IsAll
            ? All!
            : throw new global::System.InvalidOperationException($"Expected union variant 'All' but the value was {ToString()}.");

        /// <summary>
        /// Deliver the result to specific configured flows webhooks.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.WebhookTargetIds? Ids { get; init; }
#else
        public global::ElevenLabs.WebhookTargetIds? Ids { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Ids))]
#endif
        public bool IsIds => Ids != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickIds(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.WebhookTargetIds? value)
        {
            value = Ids;
            return IsIds;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::ElevenLabs.WebhookTargetIds PickIds() => IsIds
            ? Ids!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Ids' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator WebhookTarget(global::ElevenLabs.WebhookTargetAll value) => new WebhookTarget((global::ElevenLabs.WebhookTargetAll?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.WebhookTargetAll?(WebhookTarget @this) => @this.All;

        /// <summary>
        /// 
        /// </summary>
        public WebhookTarget(global::ElevenLabs.WebhookTargetAll? value)
        {
            All = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static WebhookTarget FromAll(global::ElevenLabs.WebhookTargetAll? value) => new WebhookTarget(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator WebhookTarget(global::ElevenLabs.WebhookTargetIds value) => new WebhookTarget((global::ElevenLabs.WebhookTargetIds?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.WebhookTargetIds?(WebhookTarget @this) => @this.Ids;

        /// <summary>
        /// 
        /// </summary>
        public WebhookTarget(global::ElevenLabs.WebhookTargetIds? value)
        {
            Ids = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static WebhookTarget FromIds(global::ElevenLabs.WebhookTargetIds? value) => new WebhookTarget(value);

        /// <summary>
        /// 
        /// </summary>
        public WebhookTarget(
            global::ElevenLabs.WebhookTargetDiscriminatorType? type,
            global::ElevenLabs.WebhookTargetAll? all,
            global::ElevenLabs.WebhookTargetIds? ids
            )
        {
            Type = type;

            All = all;
            Ids = ids;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Ids as object ??
            All as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            All?.ToString() ??
            Ids?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsAll && !IsIds || !IsAll && IsIds;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::ElevenLabs.WebhookTargetAll, TResult>? all = null,
            global::System.Func<global::ElevenLabs.WebhookTargetIds, TResult>? ids = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAll && all != null)
            {
                return all(All!);
            }
            else if (IsIds && ids != null)
            {
                return ids(Ids!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::ElevenLabs.WebhookTargetAll>? all = null,

            global::System.Action<global::ElevenLabs.WebhookTargetIds>? ids = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAll)
            {
                all?.Invoke(All!);
            }
            else if (IsIds)
            {
                ids?.Invoke(Ids!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::ElevenLabs.WebhookTargetAll>? all = null,
            global::System.Action<global::ElevenLabs.WebhookTargetIds>? ids = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAll)
            {
                all?.Invoke(All!);
            }
            else if (IsIds)
            {
                ids?.Invoke(Ids!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                All,
                typeof(global::ElevenLabs.WebhookTargetAll),
                Ids,
                typeof(global::ElevenLabs.WebhookTargetIds),
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
        public bool Equals(WebhookTarget other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.WebhookTargetAll?>.Default.Equals(All, other.All) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.WebhookTargetIds?>.Default.Equals(Ids, other.Ids) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(WebhookTarget obj1, WebhookTarget obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<WebhookTarget>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(WebhookTarget obj1, WebhookTarget obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is WebhookTarget o && Equals(o);
        }
    }
}
