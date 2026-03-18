#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct RefreshUrlDocumentRouteResponse : global::System.IEquatable<RefreshUrlDocumentRouteResponse>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::ElevenLabs.RefreshUrlDocumentRouteResponseDiscriminatorType? Type { get; }

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
#if NET6_0_OR_GREATER
        public global::ElevenLabs.GetKnowledgeBaseFolderResponseModel? Folder { get; init; }
#else
        public global::ElevenLabs.GetKnowledgeBaseFolderResponseModel? Folder { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Folder))]
#endif
        public bool IsFolder => Folder != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RefreshUrlDocumentRouteResponse(global::ElevenLabs.GetKnowledgeBaseURLResponseModel value) => new RefreshUrlDocumentRouteResponse((global::ElevenLabs.GetKnowledgeBaseURLResponseModel?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.GetKnowledgeBaseURLResponseModel?(RefreshUrlDocumentRouteResponse @this) => @this.Url;

        /// <summary>
        /// 
        /// </summary>
        public RefreshUrlDocumentRouteResponse(global::ElevenLabs.GetKnowledgeBaseURLResponseModel? value)
        {
            Url = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RefreshUrlDocumentRouteResponse(global::ElevenLabs.GetKnowledgeBaseFileResponseModel value) => new RefreshUrlDocumentRouteResponse((global::ElevenLabs.GetKnowledgeBaseFileResponseModel?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.GetKnowledgeBaseFileResponseModel?(RefreshUrlDocumentRouteResponse @this) => @this.File;

        /// <summary>
        /// 
        /// </summary>
        public RefreshUrlDocumentRouteResponse(global::ElevenLabs.GetKnowledgeBaseFileResponseModel? value)
        {
            File = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RefreshUrlDocumentRouteResponse(global::ElevenLabs.GetKnowledgeBaseTextResponseModel value) => new RefreshUrlDocumentRouteResponse((global::ElevenLabs.GetKnowledgeBaseTextResponseModel?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.GetKnowledgeBaseTextResponseModel?(RefreshUrlDocumentRouteResponse @this) => @this.Text;

        /// <summary>
        /// 
        /// </summary>
        public RefreshUrlDocumentRouteResponse(global::ElevenLabs.GetKnowledgeBaseTextResponseModel? value)
        {
            Text = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator RefreshUrlDocumentRouteResponse(global::ElevenLabs.GetKnowledgeBaseFolderResponseModel value) => new RefreshUrlDocumentRouteResponse((global::ElevenLabs.GetKnowledgeBaseFolderResponseModel?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.GetKnowledgeBaseFolderResponseModel?(RefreshUrlDocumentRouteResponse @this) => @this.Folder;

        /// <summary>
        /// 
        /// </summary>
        public RefreshUrlDocumentRouteResponse(global::ElevenLabs.GetKnowledgeBaseFolderResponseModel? value)
        {
            Folder = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public RefreshUrlDocumentRouteResponse(
            global::ElevenLabs.RefreshUrlDocumentRouteResponseDiscriminatorType? type,
            global::ElevenLabs.GetKnowledgeBaseURLResponseModel? url,
            global::ElevenLabs.GetKnowledgeBaseFileResponseModel? file,
            global::ElevenLabs.GetKnowledgeBaseTextResponseModel? text,
            global::ElevenLabs.GetKnowledgeBaseFolderResponseModel? folder
            )
        {
            Type = type;

            Url = url;
            File = file;
            Text = text;
            Folder = folder;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Folder as object ??
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
            Text?.ToString() ??
            Folder?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsUrl && !IsFile && !IsText && !IsFolder || !IsUrl && IsFile && !IsText && !IsFolder || !IsUrl && !IsFile && IsText && !IsFolder || !IsUrl && !IsFile && !IsText && IsFolder;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::ElevenLabs.GetKnowledgeBaseURLResponseModel?, TResult>? url = null,
            global::System.Func<global::ElevenLabs.GetKnowledgeBaseFileResponseModel?, TResult>? file = null,
            global::System.Func<global::ElevenLabs.GetKnowledgeBaseTextResponseModel?, TResult>? text = null,
            global::System.Func<global::ElevenLabs.GetKnowledgeBaseFolderResponseModel?, TResult>? folder = null,
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
            else if (IsFolder && folder != null)
            {
                return folder(Folder!);
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
            global::System.Action<global::ElevenLabs.GetKnowledgeBaseFolderResponseModel?>? folder = null,
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
            else if (IsFolder)
            {
                folder?.Invoke(Folder!);
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
                Folder,
                typeof(global::ElevenLabs.GetKnowledgeBaseFolderResponseModel),
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
        public bool Equals(RefreshUrlDocumentRouteResponse other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.GetKnowledgeBaseURLResponseModel?>.Default.Equals(Url, other.Url) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.GetKnowledgeBaseFileResponseModel?>.Default.Equals(File, other.File) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.GetKnowledgeBaseTextResponseModel?>.Default.Equals(Text, other.Text) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.GetKnowledgeBaseFolderResponseModel?>.Default.Equals(Folder, other.Folder) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(RefreshUrlDocumentRouteResponse obj1, RefreshUrlDocumentRouteResponse obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<RefreshUrlDocumentRouteResponse>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(RefreshUrlDocumentRouteResponse obj1, RefreshUrlDocumentRouteResponse obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is RefreshUrlDocumentRouteResponse o && Equals(o);
        }
    }
}
