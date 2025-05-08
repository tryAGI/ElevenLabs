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
        public static implicit operator DocumentsItem(global::ElevenLabs.GetKnowledgeBaseSummaryURLResponseModel value) => new DocumentsItem((global::ElevenLabs.GetKnowledgeBaseSummaryURLResponseModel?)value);

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
        public static implicit operator DocumentsItem(global::ElevenLabs.GetKnowledgeBaseSummaryFileResponseModel value) => new DocumentsItem((global::ElevenLabs.GetKnowledgeBaseSummaryFileResponseModel?)value);

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
#if NET6_0_OR_GREATER
        public global::ElevenLabs.GetKnowledgeBaseSummaryTextResponseModel? Text { get; init; }
#else
        public global::ElevenLabs.GetKnowledgeBaseSummaryTextResponseModel? Text { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Text))]
#endif
        public bool IsText => Text != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator DocumentsItem(global::ElevenLabs.GetKnowledgeBaseSummaryTextResponseModel value) => new DocumentsItem((global::ElevenLabs.GetKnowledgeBaseSummaryTextResponseModel?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.GetKnowledgeBaseSummaryTextResponseModel?(DocumentsItem @this) => @this.Text;

        /// <summary>
        /// 
        /// </summary>
        public DocumentsItem(global::ElevenLabs.GetKnowledgeBaseSummaryTextResponseModel? value)
        {
            Text = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public DocumentsItem(
            global::ElevenLabs.GetKnowledgeBaseListResponseModelDocumentDiscriminatorType? type,
            global::ElevenLabs.GetKnowledgeBaseSummaryURLResponseModel? url,
            global::ElevenLabs.GetKnowledgeBaseSummaryFileResponseModel? file,
            global::ElevenLabs.GetKnowledgeBaseSummaryTextResponseModel? text
            )
        {
            Type = type;

            Url = url;
            File = file;
            Text = text;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Text as object ??
            File as object ??
            Url as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Url?.ToString() ??
            File?.ToString() ??
            Text?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsUrl && !IsFile && !IsText || !IsUrl && IsFile && !IsText || !IsUrl && !IsFile && IsText;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::ElevenLabs.GetKnowledgeBaseSummaryURLResponseModel?, TResult>? url = null,
            global::System.Func<global::ElevenLabs.GetKnowledgeBaseSummaryFileResponseModel?, TResult>? file = null,
            global::System.Func<global::ElevenLabs.GetKnowledgeBaseSummaryTextResponseModel?, TResult>? text = null,
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
            else if (IsText && text != null)
            {
                return text(Text!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::ElevenLabs.GetKnowledgeBaseSummaryURLResponseModel?>? url = null,
            global::System.Action<global::ElevenLabs.GetKnowledgeBaseSummaryFileResponseModel?>? file = null,
            global::System.Action<global::ElevenLabs.GetKnowledgeBaseSummaryTextResponseModel?>? text = null,
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
            else if (IsText)
            {
                text?.Invoke(Text!);
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
                Text,
                typeof(global::ElevenLabs.GetKnowledgeBaseSummaryTextResponseModel),
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
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.GetKnowledgeBaseSummaryFileResponseModel?>.Default.Equals(File, other.File) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.GetKnowledgeBaseSummaryTextResponseModel?>.Default.Equals(Text, other.Text) 
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
