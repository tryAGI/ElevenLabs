#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct UpdateDocumentV1ConvaiKnowledgeBaseDocumentationIdPatchResponse : global::System.IEquatable<UpdateDocumentV1ConvaiKnowledgeBaseDocumentationIdPatchResponse>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::ElevenLabs.UpdateDocumentV1ConvaiKnowledgeBaseDocumentationIdPatchResponseDiscriminatorType? Type { get; }

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
        public static implicit operator UpdateDocumentV1ConvaiKnowledgeBaseDocumentationIdPatchResponse(global::ElevenLabs.GetKnowledgeBaseURLResponseModel value) => new UpdateDocumentV1ConvaiKnowledgeBaseDocumentationIdPatchResponse((global::ElevenLabs.GetKnowledgeBaseURLResponseModel?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.GetKnowledgeBaseURLResponseModel?(UpdateDocumentV1ConvaiKnowledgeBaseDocumentationIdPatchResponse @this) => @this.Url;

        /// <summary>
        /// 
        /// </summary>
        public UpdateDocumentV1ConvaiKnowledgeBaseDocumentationIdPatchResponse(global::ElevenLabs.GetKnowledgeBaseURLResponseModel? value)
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
        public static implicit operator UpdateDocumentV1ConvaiKnowledgeBaseDocumentationIdPatchResponse(global::ElevenLabs.GetKnowledgeBaseFileResponseModel value) => new UpdateDocumentV1ConvaiKnowledgeBaseDocumentationIdPatchResponse((global::ElevenLabs.GetKnowledgeBaseFileResponseModel?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.GetKnowledgeBaseFileResponseModel?(UpdateDocumentV1ConvaiKnowledgeBaseDocumentationIdPatchResponse @this) => @this.File;

        /// <summary>
        /// 
        /// </summary>
        public UpdateDocumentV1ConvaiKnowledgeBaseDocumentationIdPatchResponse(global::ElevenLabs.GetKnowledgeBaseFileResponseModel? value)
        {
            File = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.GetKnowledgeBaseTextResponseModel? Text { get; init; }
#else
        public global::ElevenLabs.GetKnowledgeBaseTextResponseModel? Text { get; }
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
        public static implicit operator UpdateDocumentV1ConvaiKnowledgeBaseDocumentationIdPatchResponse(global::ElevenLabs.GetKnowledgeBaseTextResponseModel value) => new UpdateDocumentV1ConvaiKnowledgeBaseDocumentationIdPatchResponse((global::ElevenLabs.GetKnowledgeBaseTextResponseModel?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.GetKnowledgeBaseTextResponseModel?(UpdateDocumentV1ConvaiKnowledgeBaseDocumentationIdPatchResponse @this) => @this.Text;

        /// <summary>
        /// 
        /// </summary>
        public UpdateDocumentV1ConvaiKnowledgeBaseDocumentationIdPatchResponse(global::ElevenLabs.GetKnowledgeBaseTextResponseModel? value)
        {
            Text = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public UpdateDocumentV1ConvaiKnowledgeBaseDocumentationIdPatchResponse(
            global::ElevenLabs.UpdateDocumentV1ConvaiKnowledgeBaseDocumentationIdPatchResponseDiscriminatorType? type,
            global::ElevenLabs.GetKnowledgeBaseURLResponseModel? url,
            global::ElevenLabs.GetKnowledgeBaseFileResponseModel? file,
            global::ElevenLabs.GetKnowledgeBaseTextResponseModel? text
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
            global::System.Func<global::ElevenLabs.GetKnowledgeBaseURLResponseModel?, TResult>? url = null,
            global::System.Func<global::ElevenLabs.GetKnowledgeBaseFileResponseModel?, TResult>? file = null,
            global::System.Func<global::ElevenLabs.GetKnowledgeBaseTextResponseModel?, TResult>? text = null,
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
            global::System.Action<global::ElevenLabs.GetKnowledgeBaseURLResponseModel?>? url = null,
            global::System.Action<global::ElevenLabs.GetKnowledgeBaseFileResponseModel?>? file = null,
            global::System.Action<global::ElevenLabs.GetKnowledgeBaseTextResponseModel?>? text = null,
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
                typeof(global::ElevenLabs.GetKnowledgeBaseURLResponseModel),
                File,
                typeof(global::ElevenLabs.GetKnowledgeBaseFileResponseModel),
                Text,
                typeof(global::ElevenLabs.GetKnowledgeBaseTextResponseModel),
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
        public bool Equals(UpdateDocumentV1ConvaiKnowledgeBaseDocumentationIdPatchResponse other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.GetKnowledgeBaseURLResponseModel?>.Default.Equals(Url, other.Url) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.GetKnowledgeBaseFileResponseModel?>.Default.Equals(File, other.File) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.GetKnowledgeBaseTextResponseModel?>.Default.Equals(Text, other.Text) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(UpdateDocumentV1ConvaiKnowledgeBaseDocumentationIdPatchResponse obj1, UpdateDocumentV1ConvaiKnowledgeBaseDocumentationIdPatchResponse obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<UpdateDocumentV1ConvaiKnowledgeBaseDocumentationIdPatchResponse>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(UpdateDocumentV1ConvaiKnowledgeBaseDocumentationIdPatchResponse obj1, UpdateDocumentV1ConvaiKnowledgeBaseDocumentationIdPatchResponse obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is UpdateDocumentV1ConvaiKnowledgeBaseDocumentationIdPatchResponse o && Equals(o);
        }
    }
}
