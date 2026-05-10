#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct UpdateDocumentRouteResponse : global::System.IEquatable<UpdateDocumentRouteResponse>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::ElevenLabs.UpdateDocumentRouteResponseDiscriminatorType? Type { get; }

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
        public bool TryPickUrl(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.GetKnowledgeBaseURLResponseModel? value)
        {
            value = Url;
            return IsUrl;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::ElevenLabs.GetKnowledgeBaseURLResponseModel PickUrl() => IsUrl
            ? Url!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Url' but the value was {ToString()}.");

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
        public bool TryPickFile(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.GetKnowledgeBaseFileResponseModel? value)
        {
            value = File;
            return IsFile;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::ElevenLabs.GetKnowledgeBaseFileResponseModel PickFile() => IsFile
            ? File!
            : throw new global::System.InvalidOperationException($"Expected union variant 'File' but the value was {ToString()}.");

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
        public bool TryPickText(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.GetKnowledgeBaseTextResponseModel? value)
        {
            value = Text;
            return IsText;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::ElevenLabs.GetKnowledgeBaseTextResponseModel PickText() => IsText
            ? Text!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Text' but the value was {ToString()}.");

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
        public bool TryPickFolder(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.GetKnowledgeBaseFolderResponseModel? value)
        {
            value = Folder;
            return IsFolder;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::ElevenLabs.GetKnowledgeBaseFolderResponseModel PickFolder() => IsFolder
            ? Folder!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Folder' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator UpdateDocumentRouteResponse(global::ElevenLabs.GetKnowledgeBaseURLResponseModel value) => new UpdateDocumentRouteResponse((global::ElevenLabs.GetKnowledgeBaseURLResponseModel?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.GetKnowledgeBaseURLResponseModel?(UpdateDocumentRouteResponse @this) => @this.Url;

        /// <summary>
        /// 
        /// </summary>
        public UpdateDocumentRouteResponse(global::ElevenLabs.GetKnowledgeBaseURLResponseModel? value)
        {
            Url = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static UpdateDocumentRouteResponse FromUrl(global::ElevenLabs.GetKnowledgeBaseURLResponseModel? value) => new UpdateDocumentRouteResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator UpdateDocumentRouteResponse(global::ElevenLabs.GetKnowledgeBaseFileResponseModel value) => new UpdateDocumentRouteResponse((global::ElevenLabs.GetKnowledgeBaseFileResponseModel?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.GetKnowledgeBaseFileResponseModel?(UpdateDocumentRouteResponse @this) => @this.File;

        /// <summary>
        /// 
        /// </summary>
        public UpdateDocumentRouteResponse(global::ElevenLabs.GetKnowledgeBaseFileResponseModel? value)
        {
            File = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static UpdateDocumentRouteResponse FromFile(global::ElevenLabs.GetKnowledgeBaseFileResponseModel? value) => new UpdateDocumentRouteResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator UpdateDocumentRouteResponse(global::ElevenLabs.GetKnowledgeBaseTextResponseModel value) => new UpdateDocumentRouteResponse((global::ElevenLabs.GetKnowledgeBaseTextResponseModel?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.GetKnowledgeBaseTextResponseModel?(UpdateDocumentRouteResponse @this) => @this.Text;

        /// <summary>
        /// 
        /// </summary>
        public UpdateDocumentRouteResponse(global::ElevenLabs.GetKnowledgeBaseTextResponseModel? value)
        {
            Text = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static UpdateDocumentRouteResponse FromText(global::ElevenLabs.GetKnowledgeBaseTextResponseModel? value) => new UpdateDocumentRouteResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator UpdateDocumentRouteResponse(global::ElevenLabs.GetKnowledgeBaseFolderResponseModel value) => new UpdateDocumentRouteResponse((global::ElevenLabs.GetKnowledgeBaseFolderResponseModel?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.GetKnowledgeBaseFolderResponseModel?(UpdateDocumentRouteResponse @this) => @this.Folder;

        /// <summary>
        /// 
        /// </summary>
        public UpdateDocumentRouteResponse(global::ElevenLabs.GetKnowledgeBaseFolderResponseModel? value)
        {
            Folder = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static UpdateDocumentRouteResponse FromFolder(global::ElevenLabs.GetKnowledgeBaseFolderResponseModel? value) => new UpdateDocumentRouteResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public UpdateDocumentRouteResponse(
            global::ElevenLabs.UpdateDocumentRouteResponseDiscriminatorType? type,
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
            global::System.Func<global::ElevenLabs.GetKnowledgeBaseURLResponseModel, TResult>? url = null,
            global::System.Func<global::ElevenLabs.GetKnowledgeBaseFileResponseModel, TResult>? file = null,
            global::System.Func<global::ElevenLabs.GetKnowledgeBaseTextResponseModel, TResult>? text = null,
            global::System.Func<global::ElevenLabs.GetKnowledgeBaseFolderResponseModel, TResult>? folder = null,
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
            global::System.Action<global::ElevenLabs.GetKnowledgeBaseURLResponseModel>? url = null,

            global::System.Action<global::ElevenLabs.GetKnowledgeBaseFileResponseModel>? file = null,

            global::System.Action<global::ElevenLabs.GetKnowledgeBaseTextResponseModel>? text = null,

            global::System.Action<global::ElevenLabs.GetKnowledgeBaseFolderResponseModel>? folder = null,
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
            global::System.Action<global::ElevenLabs.GetKnowledgeBaseURLResponseModel>? url = null,
            global::System.Action<global::ElevenLabs.GetKnowledgeBaseFileResponseModel>? file = null,
            global::System.Action<global::ElevenLabs.GetKnowledgeBaseTextResponseModel>? text = null,
            global::System.Action<global::ElevenLabs.GetKnowledgeBaseFolderResponseModel>? folder = null,
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
        public bool Equals(UpdateDocumentRouteResponse other)
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
        public static bool operator ==(UpdateDocumentRouteResponse obj1, UpdateDocumentRouteResponse obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<UpdateDocumentRouteResponse>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(UpdateDocumentRouteResponse obj1, UpdateDocumentRouteResponse obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is UpdateDocumentRouteResponse o && Equals(o);
        }
    }
}
