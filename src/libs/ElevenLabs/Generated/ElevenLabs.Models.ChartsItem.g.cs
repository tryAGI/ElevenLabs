#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ChartsItem : global::System.IEquatable<ChartsItem>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::ElevenLabs.GetConvAIDashboardSettingsResponseModelChartDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.DashboardCallSuccessChartModel? CallSuccess { get; init; }
#else
        public global::ElevenLabs.DashboardCallSuccessChartModel? CallSuccess { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CallSuccess))]
#endif
        public bool IsCallSuccess => CallSuccess != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChartsItem(global::ElevenLabs.DashboardCallSuccessChartModel value) => new ChartsItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.DashboardCallSuccessChartModel?(ChartsItem @this) => @this.CallSuccess;

        /// <summary>
        /// 
        /// </summary>
        public ChartsItem(global::ElevenLabs.DashboardCallSuccessChartModel? value)
        {
            CallSuccess = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.DashboardCriteriaChartModel? Criteria { get; init; }
#else
        public global::ElevenLabs.DashboardCriteriaChartModel? Criteria { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Criteria))]
#endif
        public bool IsCriteria => Criteria != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChartsItem(global::ElevenLabs.DashboardCriteriaChartModel value) => new ChartsItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.DashboardCriteriaChartModel?(ChartsItem @this) => @this.Criteria;

        /// <summary>
        /// 
        /// </summary>
        public ChartsItem(global::ElevenLabs.DashboardCriteriaChartModel? value)
        {
            Criteria = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ChartsItem(
            global::ElevenLabs.GetConvAIDashboardSettingsResponseModelChartDiscriminatorType? type,
            global::ElevenLabs.DashboardCallSuccessChartModel? callSuccess,
            global::ElevenLabs.DashboardCriteriaChartModel? criteria
            )
        {
            Type = type;

            CallSuccess = callSuccess;
            Criteria = criteria;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Criteria as object ??
            CallSuccess as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            CallSuccess?.ToString() ??
            Criteria?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsCallSuccess && !IsCriteria || !IsCallSuccess && IsCriteria;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::ElevenLabs.DashboardCallSuccessChartModel?, TResult>? callSuccess = null,
            global::System.Func<global::ElevenLabs.DashboardCriteriaChartModel?, TResult>? criteria = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCallSuccess && callSuccess != null)
            {
                return callSuccess(CallSuccess!);
            }
            else if (IsCriteria && criteria != null)
            {
                return criteria(Criteria!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::ElevenLabs.DashboardCallSuccessChartModel?>? callSuccess = null,
            global::System.Action<global::ElevenLabs.DashboardCriteriaChartModel?>? criteria = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCallSuccess)
            {
                callSuccess?.Invoke(CallSuccess!);
            }
            else if (IsCriteria)
            {
                criteria?.Invoke(Criteria!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                CallSuccess,
                typeof(global::ElevenLabs.DashboardCallSuccessChartModel),
                Criteria,
                typeof(global::ElevenLabs.DashboardCriteriaChartModel),
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
        public bool Equals(ChartsItem other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.DashboardCallSuccessChartModel?>.Default.Equals(CallSuccess, other.CallSuccess) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.DashboardCriteriaChartModel?>.Default.Equals(Criteria, other.Criteria) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ChartsItem obj1, ChartsItem obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ChartsItem>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ChartsItem obj1, ChartsItem obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ChartsItem o && Equals(o);
        }
    }
}
