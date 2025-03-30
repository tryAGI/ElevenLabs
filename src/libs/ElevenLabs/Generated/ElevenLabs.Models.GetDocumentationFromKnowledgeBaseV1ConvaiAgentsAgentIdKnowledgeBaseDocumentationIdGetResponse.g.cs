#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct GetDocumentationFromKnowledgeBaseV1ConvaiAgentsAgentIdKnowledgeBaseDocumentationIdGetResponse : global::System.IEquatable<GetDocumentationFromKnowledgeBaseV1ConvaiAgentsAgentIdKnowledgeBaseDocumentationIdGetResponse>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::ElevenLabs.GetDocumentationFromKnowledgeBaseV1ConvaiAgentsAgentIdKnowledgeBaseDocumentationIdGetResponseDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.GetKnowledgeBaseURLResponseModel? Url { get; init; }
#else
        public global::ElevenLabs.GetKnowledgeBaseURLResponseModel? Url { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Url))]
#endif
        public bool IsUrl => Url != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GetDocumentationFromKnowledgeBaseV1ConvaiAgentsAgentIdKnowledgeBaseDocumentationIdGetResponse(global::ElevenLabs.GetKnowledgeBaseURLResponseModel value) => new GetDocumentationFromKnowledgeBaseV1ConvaiAgentsAgentIdKnowledgeBaseDocumentationIdGetResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.GetKnowledgeBaseURLResponseModel?(GetDocumentationFromKnowledgeBaseV1ConvaiAgentsAgentIdKnowledgeBaseDocumentationIdGetResponse @this) => @this.Url;

        /// <summary>
        /// 
        /// </summary>
        public GetDocumentationFromKnowledgeBaseV1ConvaiAgentsAgentIdKnowledgeBaseDocumentationIdGetResponse(global::ElevenLabs.GetKnowledgeBaseURLResponseModel? value)
        {
            Url = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.GetKnowledgeBaseFileResponseModel? File { get; init; }
#else
        public global::ElevenLabs.GetKnowledgeBaseFileResponseModel? File { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(File))]
#endif
        public bool IsFile => File != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GetDocumentationFromKnowledgeBaseV1ConvaiAgentsAgentIdKnowledgeBaseDocumentationIdGetResponse(global::ElevenLabs.GetKnowledgeBaseFileResponseModel value) => new GetDocumentationFromKnowledgeBaseV1ConvaiAgentsAgentIdKnowledgeBaseDocumentationIdGetResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.GetKnowledgeBaseFileResponseModel?(GetDocumentationFromKnowledgeBaseV1ConvaiAgentsAgentIdKnowledgeBaseDocumentationIdGetResponse @this) => @this.File;

        /// <summary>
        /// 
        /// </summary>
        public GetDocumentationFromKnowledgeBaseV1ConvaiAgentsAgentIdKnowledgeBaseDocumentationIdGetResponse(global::ElevenLabs.GetKnowledgeBaseFileResponseModel? value)
        {
            File = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public GetDocumentationFromKnowledgeBaseV1ConvaiAgentsAgentIdKnowledgeBaseDocumentationIdGetResponse(
            global::ElevenLabs.GetDocumentationFromKnowledgeBaseV1ConvaiAgentsAgentIdKnowledgeBaseDocumentationIdGetResponseDiscriminatorType? type,
            global::ElevenLabs.GetKnowledgeBaseURLResponseModel? url,
            global::ElevenLabs.GetKnowledgeBaseFileResponseModel? file
            )
        {
            Type = type;

            Url = url;
            File = file;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            File as object ??
            Url as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Url?.ToString() ??
            File?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsUrl && !IsFile || !IsUrl && IsFile;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::ElevenLabs.GetKnowledgeBaseURLResponseModel?, TResult>? url = null,
            global::System.Func<global::ElevenLabs.GetKnowledgeBaseFileResponseModel?, TResult>? file = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsUrl && url != null)
            {
                return url(Url!);
            }
            else if (IsFile && file != null)
            {
                return file(File!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::ElevenLabs.GetKnowledgeBaseURLResponseModel?>? url = null,
            global::System.Action<global::ElevenLabs.GetKnowledgeBaseFileResponseModel?>? file = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsUrl)
            {
                url?.Invoke(Url!);
            }
            else if (IsFile)
            {
                file?.Invoke(File!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Url,
                typeof(global::ElevenLabs.GetKnowledgeBaseURLResponseModel),
                File,
                typeof(global::ElevenLabs.GetKnowledgeBaseFileResponseModel),
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
        public bool Equals(GetDocumentationFromKnowledgeBaseV1ConvaiAgentsAgentIdKnowledgeBaseDocumentationIdGetResponse other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.GetKnowledgeBaseURLResponseModel?>.Default.Equals(Url, other.Url) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.GetKnowledgeBaseFileResponseModel?>.Default.Equals(File, other.File) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(GetDocumentationFromKnowledgeBaseV1ConvaiAgentsAgentIdKnowledgeBaseDocumentationIdGetResponse obj1, GetDocumentationFromKnowledgeBaseV1ConvaiAgentsAgentIdKnowledgeBaseDocumentationIdGetResponse obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<GetDocumentationFromKnowledgeBaseV1ConvaiAgentsAgentIdKnowledgeBaseDocumentationIdGetResponse>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(GetDocumentationFromKnowledgeBaseV1ConvaiAgentsAgentIdKnowledgeBaseDocumentationIdGetResponse obj1, GetDocumentationFromKnowledgeBaseV1ConvaiAgentsAgentIdKnowledgeBaseDocumentationIdGetResponse obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is GetDocumentationFromKnowledgeBaseV1ConvaiAgentsAgentIdKnowledgeBaseDocumentationIdGetResponse o && Equals(o);
        }
    }
}
