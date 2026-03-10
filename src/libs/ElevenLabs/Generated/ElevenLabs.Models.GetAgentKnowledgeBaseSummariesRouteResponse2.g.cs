#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct GetAgentKnowledgeBaseSummariesRouteResponse2 : global::System.IEquatable<GetAgentKnowledgeBaseSummariesRouteResponse2>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::ElevenLabs.GetAgentKnowledgeBaseSummariesRouteResponseDiscriminatorStatus? Status { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.KnowledgeBaseSummaryBatchSuccessfulResponseModel? Success { get; init; }
#else
        public global::ElevenLabs.KnowledgeBaseSummaryBatchSuccessfulResponseModel? Success { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Success))]
#endif
        public bool IsSuccess => Success != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.BatchFailureResponseModel? Failure { get; init; }
#else
        public global::ElevenLabs.BatchFailureResponseModel? Failure { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Failure))]
#endif
        public bool IsFailure => Failure != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GetAgentKnowledgeBaseSummariesRouteResponse2(global::ElevenLabs.KnowledgeBaseSummaryBatchSuccessfulResponseModel value) => new GetAgentKnowledgeBaseSummariesRouteResponse2((global::ElevenLabs.KnowledgeBaseSummaryBatchSuccessfulResponseModel?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.KnowledgeBaseSummaryBatchSuccessfulResponseModel?(GetAgentKnowledgeBaseSummariesRouteResponse2 @this) => @this.Success;

        /// <summary>
        /// 
        /// </summary>
        public GetAgentKnowledgeBaseSummariesRouteResponse2(global::ElevenLabs.KnowledgeBaseSummaryBatchSuccessfulResponseModel? value)
        {
            Success = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GetAgentKnowledgeBaseSummariesRouteResponse2(global::ElevenLabs.BatchFailureResponseModel value) => new GetAgentKnowledgeBaseSummariesRouteResponse2((global::ElevenLabs.BatchFailureResponseModel?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.BatchFailureResponseModel?(GetAgentKnowledgeBaseSummariesRouteResponse2 @this) => @this.Failure;

        /// <summary>
        /// 
        /// </summary>
        public GetAgentKnowledgeBaseSummariesRouteResponse2(global::ElevenLabs.BatchFailureResponseModel? value)
        {
            Failure = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public GetAgentKnowledgeBaseSummariesRouteResponse2(
            global::ElevenLabs.GetAgentKnowledgeBaseSummariesRouteResponseDiscriminatorStatus? status,
            global::ElevenLabs.KnowledgeBaseSummaryBatchSuccessfulResponseModel? success,
            global::ElevenLabs.BatchFailureResponseModel? failure
            )
        {
            Status = status;

            Success = success;
            Failure = failure;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Failure as object ??
            Success as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Success?.ToString() ??
            Failure?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsSuccess && !IsFailure || !IsSuccess && IsFailure;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::ElevenLabs.KnowledgeBaseSummaryBatchSuccessfulResponseModel?, TResult>? success = null,
            global::System.Func<global::ElevenLabs.BatchFailureResponseModel?, TResult>? failure = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSuccess && success != null)
            {
                return success(Success!);
            }
            else if (IsFailure && failure != null)
            {
                return failure(Failure!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::ElevenLabs.KnowledgeBaseSummaryBatchSuccessfulResponseModel?>? success = null,
            global::System.Action<global::ElevenLabs.BatchFailureResponseModel?>? failure = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSuccess)
            {
                success?.Invoke(Success!);
            }
            else if (IsFailure)
            {
                failure?.Invoke(Failure!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Success,
                typeof(global::ElevenLabs.KnowledgeBaseSummaryBatchSuccessfulResponseModel),
                Failure,
                typeof(global::ElevenLabs.BatchFailureResponseModel),
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
        public bool Equals(GetAgentKnowledgeBaseSummariesRouteResponse2 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.KnowledgeBaseSummaryBatchSuccessfulResponseModel?>.Default.Equals(Success, other.Success) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.BatchFailureResponseModel?>.Default.Equals(Failure, other.Failure) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(GetAgentKnowledgeBaseSummariesRouteResponse2 obj1, GetAgentKnowledgeBaseSummariesRouteResponse2 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<GetAgentKnowledgeBaseSummariesRouteResponse2>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(GetAgentKnowledgeBaseSummariesRouteResponse2 obj1, GetAgentKnowledgeBaseSummariesRouteResponse2 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is GetAgentKnowledgeBaseSummariesRouteResponse2 o && Equals(o);
        }
    }
}
