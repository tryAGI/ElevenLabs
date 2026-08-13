#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct PostKnowledgeBaseBulkDeleteRouteResponse2 : global::System.IEquatable<PostKnowledgeBaseBulkDeleteRouteResponse2>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::ElevenLabs.PostKnowledgeBaseBulkDeleteRouteResponseDiscriminatorStatus? Status { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.KnowledgeBaseBulkDeleteSuccessfulResponseModel? Success { get; init; }
#else
        public global::ElevenLabs.KnowledgeBaseBulkDeleteSuccessfulResponseModel? Success { get; }
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
        public bool TryPickSuccess(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.KnowledgeBaseBulkDeleteSuccessfulResponseModel? value)
        {
            value = Success;
            return IsSuccess;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::ElevenLabs.KnowledgeBaseBulkDeleteSuccessfulResponseModel PickSuccess() => IsSuccess
            ? Success!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Success' but the value was {ToString()}.");

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
        public bool TryPickFailure(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.BatchFailureResponseModel? value)
        {
            value = Failure;
            return IsFailure;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::ElevenLabs.BatchFailureResponseModel PickFailure() => IsFailure
            ? Failure!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Failure' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PostKnowledgeBaseBulkDeleteRouteResponse2(global::ElevenLabs.KnowledgeBaseBulkDeleteSuccessfulResponseModel value) => new PostKnowledgeBaseBulkDeleteRouteResponse2((global::ElevenLabs.KnowledgeBaseBulkDeleteSuccessfulResponseModel?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.KnowledgeBaseBulkDeleteSuccessfulResponseModel?(PostKnowledgeBaseBulkDeleteRouteResponse2 @this) => @this.Success;

        /// <summary>
        /// 
        /// </summary>
        public PostKnowledgeBaseBulkDeleteRouteResponse2(global::ElevenLabs.KnowledgeBaseBulkDeleteSuccessfulResponseModel? value)
        {
            Success = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static PostKnowledgeBaseBulkDeleteRouteResponse2 FromSuccess(global::ElevenLabs.KnowledgeBaseBulkDeleteSuccessfulResponseModel? value) => new PostKnowledgeBaseBulkDeleteRouteResponse2(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PostKnowledgeBaseBulkDeleteRouteResponse2(global::ElevenLabs.BatchFailureResponseModel value) => new PostKnowledgeBaseBulkDeleteRouteResponse2((global::ElevenLabs.BatchFailureResponseModel?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.BatchFailureResponseModel?(PostKnowledgeBaseBulkDeleteRouteResponse2 @this) => @this.Failure;

        /// <summary>
        /// 
        /// </summary>
        public PostKnowledgeBaseBulkDeleteRouteResponse2(global::ElevenLabs.BatchFailureResponseModel? value)
        {
            Failure = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static PostKnowledgeBaseBulkDeleteRouteResponse2 FromFailure(global::ElevenLabs.BatchFailureResponseModel? value) => new PostKnowledgeBaseBulkDeleteRouteResponse2(value);

        /// <summary>
        /// 
        /// </summary>
        public PostKnowledgeBaseBulkDeleteRouteResponse2(
            global::ElevenLabs.PostKnowledgeBaseBulkDeleteRouteResponseDiscriminatorStatus? status,
            global::ElevenLabs.KnowledgeBaseBulkDeleteSuccessfulResponseModel? success,
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
            global::System.Func<global::ElevenLabs.KnowledgeBaseBulkDeleteSuccessfulResponseModel, TResult>? success = null,
            global::System.Func<global::ElevenLabs.BatchFailureResponseModel, TResult>? failure = null,
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
            global::System.Action<global::ElevenLabs.KnowledgeBaseBulkDeleteSuccessfulResponseModel>? success = null,

            global::System.Action<global::ElevenLabs.BatchFailureResponseModel>? failure = null,
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
        public void Switch(
            global::System.Action<global::ElevenLabs.KnowledgeBaseBulkDeleteSuccessfulResponseModel>? success = null,
            global::System.Action<global::ElevenLabs.BatchFailureResponseModel>? failure = null,
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
                typeof(global::ElevenLabs.KnowledgeBaseBulkDeleteSuccessfulResponseModel),
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
        public bool Equals(PostKnowledgeBaseBulkDeleteRouteResponse2 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.KnowledgeBaseBulkDeleteSuccessfulResponseModel?>.Default.Equals(Success, other.Success) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.BatchFailureResponseModel?>.Default.Equals(Failure, other.Failure) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(PostKnowledgeBaseBulkDeleteRouteResponse2 obj1, PostKnowledgeBaseBulkDeleteRouteResponse2 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<PostKnowledgeBaseBulkDeleteRouteResponse2>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(PostKnowledgeBaseBulkDeleteRouteResponse2 obj1, PostKnowledgeBaseBulkDeleteRouteResponse2 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is PostKnowledgeBaseBulkDeleteRouteResponse2 o && Equals(o);
        }
    }
}
