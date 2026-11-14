#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct Source2 : global::System.IEquatable<Source2>
    {
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.FileContentPartSourceDiscriminatorType? Type { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.Base64FileSource? Base64 { get; init; }
#else
        public global::ElevenLabs.Base64FileSource? Base64 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Base64))]
#endif
        public bool IsBase64 => Base64 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBase64(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.Base64FileSource? value)
        {
            value = Base64;
            return IsBase64;
        }

        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.Base64FileSource PickBase64() => Base64 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Base64' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.FileIdSource? FileId { get; init; }
#else
        public global::ElevenLabs.FileIdSource? FileId { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FileId))]
#endif
        public bool IsFileId => FileId != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickFileId(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.FileIdSource? value)
        {
            value = FileId;
            return IsFileId;
        }

        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.FileIdSource PickFileId() => FileId is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'FileId' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator Source2(global::ElevenLabs.Base64FileSource value) => new Source2((global::ElevenLabs.Base64FileSource?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::ElevenLabs.Base64FileSource?(Source2 @this) => @this.Base64;

        /// <summary>
        ///
        /// </summary>
        public Source2(global::ElevenLabs.Base64FileSource? value)
        {
            Base64 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Source2 FromBase64(global::ElevenLabs.Base64FileSource? value) => new Source2(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Source2(global::ElevenLabs.FileIdSource value) => new Source2((global::ElevenLabs.FileIdSource?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::ElevenLabs.FileIdSource?(Source2 @this) => @this.FileId;

        /// <summary>
        ///
        /// </summary>
        public Source2(global::ElevenLabs.FileIdSource? value)
        {
            FileId = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Source2 FromFileId(global::ElevenLabs.FileIdSource? value) => new Source2(value);

        /// <summary>
        ///
        /// </summary>
        public Source2(
            global::ElevenLabs.FileContentPartSourceDiscriminatorType? type,
            global::ElevenLabs.Base64FileSource? base64,
            global::ElevenLabs.FileIdSource? fileId
            )
        {
            Type = type;

            Base64 = base64;
            FileId = fileId;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            FileId as object ??
            Base64 as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Base64?.ToString() ??
            FileId?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsBase64 && !IsFileId || !IsBase64 && IsFileId;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::ElevenLabs.Base64FileSource, TResult>? base64 = null,
            global::System.Func<global::ElevenLabs.FileIdSource, TResult>? fileId = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Base64 is { } __value0 && base64 != null)
            {
                return base64(__value0);
            }
            else if (FileId is { } __value1 && fileId != null)
            {
                return fileId(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::ElevenLabs.Base64FileSource>? base64 = null,

            global::System.Action<global::ElevenLabs.FileIdSource>? fileId = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Base64 is { } __value0)
            {
                base64?.Invoke(__value0);
            }
            else if (FileId is { } __value1)
            {
                fileId?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::ElevenLabs.Base64FileSource>? base64 = null,
            global::System.Action<global::ElevenLabs.FileIdSource>? fileId = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Base64 is { } __value0)
            {
                base64?.Invoke(__value0);
            }
            else if (FileId is { } __value1)
            {
                fileId?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Base64,
                typeof(global::ElevenLabs.Base64FileSource),
                FileId,
                typeof(global::ElevenLabs.FileIdSource),
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
        public bool Equals(Source2 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.Base64FileSource?>.Default.Equals(Base64, other.Base64) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.FileIdSource?>.Default.Equals(FileId, other.FileId)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(Source2 obj1, Source2 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Source2>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(Source2 obj1, Source2 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Source2 o && Equals(o);
        }
    }
}
