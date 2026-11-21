#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct ContentItem : global::System.IEquatable<ContentItem>
    {
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.UserMessageInputItemContentItemDiscriminatorType? Type { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.TextContentPart? Text { get; init; }
#else
        public global::ElevenLabs.TextContentPart? Text { get; }
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
            out global::ElevenLabs.TextContentPart? value)
        {
            value = Text;
            return IsText;
        }

        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TextContentPart PickText() => Text is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Text' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.FileContentPart? File { get; init; }
#else
        public global::ElevenLabs.FileContentPart? File { get; }
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
            out global::ElevenLabs.FileContentPart? value)
        {
            value = File;
            return IsFile;
        }

        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.FileContentPart PickFile() => File is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'File' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator ContentItem(global::ElevenLabs.TextContentPart value) => new ContentItem((global::ElevenLabs.TextContentPart?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::ElevenLabs.TextContentPart?(ContentItem @this) => @this.Text;

        /// <summary>
        ///
        /// </summary>
        public ContentItem(global::ElevenLabs.TextContentPart? value)
        {
            Text = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ContentItem FromText(global::ElevenLabs.TextContentPart? value) => new ContentItem(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ContentItem(global::ElevenLabs.FileContentPart value) => new ContentItem((global::ElevenLabs.FileContentPart?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::ElevenLabs.FileContentPart?(ContentItem @this) => @this.File;

        /// <summary>
        ///
        /// </summary>
        public ContentItem(global::ElevenLabs.FileContentPart? value)
        {
            File = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ContentItem FromFile(global::ElevenLabs.FileContentPart? value) => new ContentItem(value);

        /// <summary>
        ///
        /// </summary>
        public ContentItem(
            global::ElevenLabs.UserMessageInputItemContentItemDiscriminatorType? type,
            global::ElevenLabs.TextContentPart? text,
            global::ElevenLabs.FileContentPart? file
            )
        {
            Type = type;

            Text = text;
            File = file;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            File as object ??
            Text as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Text?.ToString() ??
            File?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsText && !IsFile || !IsText && IsFile;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::ElevenLabs.TextContentPart, TResult>? text = null,
            global::System.Func<global::ElevenLabs.FileContentPart, TResult>? file = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Text is { } __value0 && text != null)
            {
                return text(__value0);
            }
            else if (File is { } __value1 && file != null)
            {
                return file(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::ElevenLabs.TextContentPart>? text = null,

            global::System.Action<global::ElevenLabs.FileContentPart>? file = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Text is { } __value0)
            {
                text?.Invoke(__value0);
            }
            else if (File is { } __value1)
            {
                file?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::ElevenLabs.TextContentPart>? text = null,
            global::System.Action<global::ElevenLabs.FileContentPart>? file = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Text is { } __value0)
            {
                text?.Invoke(__value0);
            }
            else if (File is { } __value1)
            {
                file?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Text,
                typeof(global::ElevenLabs.TextContentPart),
                File,
                typeof(global::ElevenLabs.FileContentPart),
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
        public bool Equals(ContentItem other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.TextContentPart?>.Default.Equals(Text, other.Text) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.FileContentPart?>.Default.Equals(File, other.File)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(ContentItem obj1, ContentItem obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ContentItem>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ContentItem obj1, ContentItem obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ContentItem o && Equals(o);
        }
    }
}
