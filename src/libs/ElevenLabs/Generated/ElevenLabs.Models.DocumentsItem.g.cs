#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct DocumentsItem : global::System.IEquatable<DocumentsItem>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::ElevenLabs.GetKnowledgeBaseListResponseModelDocumentDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.GetKnowledgeBaseSummaryURLResponseModel? Url { get; init; }
#else
        public global::ElevenLabs.GetKnowledgeBaseSummaryURLResponseModel? Url { get; }
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
        public static implicit operator DocumentsItem(global::ElevenLabs.GetKnowledgeBaseSummaryURLResponseModel value) => new DocumentsItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.GetKnowledgeBaseSummaryURLResponseModel?(DocumentsItem @this) => @this.Url;

        /// <summary>
        /// 
        /// </summary>
        public DocumentsItem(global::ElevenLabs.GetKnowledgeBaseSummaryURLResponseModel? value)
        {
            Url = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.GetKnowledgeBaseSummaryFileResponseModel? File { get; init; }
#else
        public global::ElevenLabs.GetKnowledgeBaseSummaryFileResponseModel? File { get; }
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
        public static implicit operator DocumentsItem(global::ElevenLabs.GetKnowledgeBaseSummaryFileResponseModel value) => new DocumentsItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.GetKnowledgeBaseSummaryFileResponseModel?(DocumentsItem @this) => @this.File;

        /// <summary>
        /// 
        /// </summary>
        public DocumentsItem(global::ElevenLabs.GetKnowledgeBaseSummaryFileResponseModel? value)
        {
            File = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public DocumentsItem(
            global::ElevenLabs.GetKnowledgeBaseListResponseModelDocumentDiscriminatorType? type,
            global::ElevenLabs.GetKnowledgeBaseSummaryURLResponseModel? url,
            global::ElevenLabs.GetKnowledgeBaseSummaryFileResponseModel? file
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
        public bool Validate()
        {
            return IsUrl && !IsFile || !IsUrl && IsFile;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::ElevenLabs.GetKnowledgeBaseSummaryURLResponseModel?, TResult>? url = null,
            global::System.Func<global::ElevenLabs.GetKnowledgeBaseSummaryFileResponseModel?, TResult>? file = null,
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
            global::System.Action<global::ElevenLabs.GetKnowledgeBaseSummaryURLResponseModel?>? url = null,
            global::System.Action<global::ElevenLabs.GetKnowledgeBaseSummaryFileResponseModel?>? file = null,
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
                typeof(global::ElevenLabs.GetKnowledgeBaseSummaryURLResponseModel),
                File,
                typeof(global::ElevenLabs.GetKnowledgeBaseSummaryFileResponseModel),
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
        public bool Equals(DocumentsItem other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.GetKnowledgeBaseSummaryURLResponseModel?>.Default.Equals(Url, other.Url) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.GetKnowledgeBaseSummaryFileResponseModel?>.Default.Equals(File, other.File) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(DocumentsItem obj1, DocumentsItem obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<DocumentsItem>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(DocumentsItem obj1, DocumentsItem obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is DocumentsItem o && Equals(o);
        }
    }
}
