#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct Document : global::System.IEquatable<Document>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::ElevenLabs.KnowledgeBaseContentSearchResultDocumentDiscriminatorType? Type { get; }

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
        public bool TryPickUrl(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.GetKnowledgeBaseSummaryURLResponseModel? value)
        {
            value = Url;
            return IsUrl;
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
        public bool TryPickFile(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.GetKnowledgeBaseSummaryFileResponseModel? value)
        {
            value = File;
            return IsFile;
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
        public bool TryPickText(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.GetKnowledgeBaseSummaryTextResponseModel? value)
        {
            value = Text;
            return IsText;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.GetKnowledgeBaseSummaryFolderResponseModel? Folder { get; init; }
#else
        public global::ElevenLabs.GetKnowledgeBaseSummaryFolderResponseModel? Folder { get; }
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
        public bool TryPickFolder(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.GetKnowledgeBaseSummaryFolderResponseModel? value)
        {
            value = Folder;
            return IsFolder;
        }
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Document(global::ElevenLabs.GetKnowledgeBaseSummaryURLResponseModel value) => new Document((global::ElevenLabs.GetKnowledgeBaseSummaryURLResponseModel?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.GetKnowledgeBaseSummaryURLResponseModel?(Document @this) => @this.Url;

        /// <summary>
        /// 
        /// </summary>
        public Document(global::ElevenLabs.GetKnowledgeBaseSummaryURLResponseModel? value)
        {
            Url = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static Document FromUrl(global::ElevenLabs.GetKnowledgeBaseSummaryURLResponseModel? value) => new Document(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Document(global::ElevenLabs.GetKnowledgeBaseSummaryFileResponseModel value) => new Document((global::ElevenLabs.GetKnowledgeBaseSummaryFileResponseModel?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.GetKnowledgeBaseSummaryFileResponseModel?(Document @this) => @this.File;

        /// <summary>
        /// 
        /// </summary>
        public Document(global::ElevenLabs.GetKnowledgeBaseSummaryFileResponseModel? value)
        {
            File = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static Document FromFile(global::ElevenLabs.GetKnowledgeBaseSummaryFileResponseModel? value) => new Document(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Document(global::ElevenLabs.GetKnowledgeBaseSummaryTextResponseModel value) => new Document((global::ElevenLabs.GetKnowledgeBaseSummaryTextResponseModel?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.GetKnowledgeBaseSummaryTextResponseModel?(Document @this) => @this.Text;

        /// <summary>
        /// 
        /// </summary>
        public Document(global::ElevenLabs.GetKnowledgeBaseSummaryTextResponseModel? value)
        {
            Text = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static Document FromText(global::ElevenLabs.GetKnowledgeBaseSummaryTextResponseModel? value) => new Document(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Document(global::ElevenLabs.GetKnowledgeBaseSummaryFolderResponseModel value) => new Document((global::ElevenLabs.GetKnowledgeBaseSummaryFolderResponseModel?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.GetKnowledgeBaseSummaryFolderResponseModel?(Document @this) => @this.Folder;

        /// <summary>
        /// 
        /// </summary>
        public Document(global::ElevenLabs.GetKnowledgeBaseSummaryFolderResponseModel? value)
        {
            Folder = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static Document FromFolder(global::ElevenLabs.GetKnowledgeBaseSummaryFolderResponseModel? value) => new Document(value);

        /// <summary>
        /// 
        /// </summary>
        public Document(
            global::ElevenLabs.KnowledgeBaseContentSearchResultDocumentDiscriminatorType? type,
            global::ElevenLabs.GetKnowledgeBaseSummaryURLResponseModel? url,
            global::ElevenLabs.GetKnowledgeBaseSummaryFileResponseModel? file,
            global::ElevenLabs.GetKnowledgeBaseSummaryTextResponseModel? text,
            global::ElevenLabs.GetKnowledgeBaseSummaryFolderResponseModel? folder
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
            global::System.Func<global::ElevenLabs.GetKnowledgeBaseSummaryURLResponseModel, TResult>? url = null,
            global::System.Func<global::ElevenLabs.GetKnowledgeBaseSummaryFileResponseModel, TResult>? file = null,
            global::System.Func<global::ElevenLabs.GetKnowledgeBaseSummaryTextResponseModel, TResult>? text = null,
            global::System.Func<global::ElevenLabs.GetKnowledgeBaseSummaryFolderResponseModel, TResult>? folder = null,
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
            global::System.Action<global::ElevenLabs.GetKnowledgeBaseSummaryURLResponseModel>? url = null,

            global::System.Action<global::ElevenLabs.GetKnowledgeBaseSummaryFileResponseModel>? file = null,

            global::System.Action<global::ElevenLabs.GetKnowledgeBaseSummaryTextResponseModel>? text = null,

            global::System.Action<global::ElevenLabs.GetKnowledgeBaseSummaryFolderResponseModel>? folder = null,
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
        public void Switch(
            global::System.Action<global::ElevenLabs.GetKnowledgeBaseSummaryURLResponseModel>? url = null,
            global::System.Action<global::ElevenLabs.GetKnowledgeBaseSummaryFileResponseModel>? file = null,
            global::System.Action<global::ElevenLabs.GetKnowledgeBaseSummaryTextResponseModel>? text = null,
            global::System.Action<global::ElevenLabs.GetKnowledgeBaseSummaryFolderResponseModel>? folder = null,
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
                typeof(global::ElevenLabs.GetKnowledgeBaseSummaryURLResponseModel),
                File,
                typeof(global::ElevenLabs.GetKnowledgeBaseSummaryFileResponseModel),
                Text,
                typeof(global::ElevenLabs.GetKnowledgeBaseSummaryTextResponseModel),
                Folder,
                typeof(global::ElevenLabs.GetKnowledgeBaseSummaryFolderResponseModel),
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
        public bool Equals(Document other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.GetKnowledgeBaseSummaryURLResponseModel?>.Default.Equals(Url, other.Url) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.GetKnowledgeBaseSummaryFileResponseModel?>.Default.Equals(File, other.File) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.GetKnowledgeBaseSummaryTextResponseModel?>.Default.Equals(Text, other.Text) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.GetKnowledgeBaseSummaryFolderResponseModel?>.Default.Equals(Folder, other.Folder) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Document obj1, Document obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Document>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Document obj1, Document obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Document o && Equals(o);
        }
    }
}
