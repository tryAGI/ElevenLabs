#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct PromptPartsItem : global::System.IEquatable<PromptPartsItem>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::ElevenLabs.GeminiLLMParametersPromptPartDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.TextPromptPart? Text { get; init; }
#else
        public global::ElevenLabs.TextPromptPart? Text { get; }
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
        public global::ElevenLabs.ImageReferencePromptPart? ImageReference { get; init; }
#else
        public global::ElevenLabs.ImageReferencePromptPart? ImageReference { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ImageReference))]
#endif
        public bool IsImageReference => ImageReference != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.TextReferencePromptPart? TextReference { get; init; }
#else
        public global::ElevenLabs.TextReferencePromptPart? TextReference { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TextReference))]
#endif
        public bool IsTextReference => TextReference != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PromptPartsItem(global::ElevenLabs.TextPromptPart value) => new PromptPartsItem((global::ElevenLabs.TextPromptPart?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.TextPromptPart?(PromptPartsItem @this) => @this.Text;

        /// <summary>
        /// 
        /// </summary>
        public PromptPartsItem(global::ElevenLabs.TextPromptPart? value)
        {
            Text = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PromptPartsItem(global::ElevenLabs.ImageReferencePromptPart value) => new PromptPartsItem((global::ElevenLabs.ImageReferencePromptPart?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.ImageReferencePromptPart?(PromptPartsItem @this) => @this.ImageReference;

        /// <summary>
        /// 
        /// </summary>
        public PromptPartsItem(global::ElevenLabs.ImageReferencePromptPart? value)
        {
            ImageReference = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator PromptPartsItem(global::ElevenLabs.TextReferencePromptPart value) => new PromptPartsItem((global::ElevenLabs.TextReferencePromptPart?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.TextReferencePromptPart?(PromptPartsItem @this) => @this.TextReference;

        /// <summary>
        /// 
        /// </summary>
        public PromptPartsItem(global::ElevenLabs.TextReferencePromptPart? value)
        {
            TextReference = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public PromptPartsItem(
            global::ElevenLabs.GeminiLLMParametersPromptPartDiscriminatorType? type,
            global::ElevenLabs.TextPromptPart? text,
            global::ElevenLabs.ImageReferencePromptPart? imageReference,
            global::ElevenLabs.TextReferencePromptPart? textReference
            )
        {
            Type = type;

            Text = text;
            ImageReference = imageReference;
            TextReference = textReference;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            TextReference as object ??
            ImageReference as object ??
            Text as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Text?.ToString() ??
            ImageReference?.ToString() ??
            TextReference?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsText && !IsImageReference && !IsTextReference || !IsText && IsImageReference && !IsTextReference || !IsText && !IsImageReference && IsTextReference;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::ElevenLabs.TextPromptPart?, TResult>? text = null,
            global::System.Func<global::ElevenLabs.ImageReferencePromptPart?, TResult>? imageReference = null,
            global::System.Func<global::ElevenLabs.TextReferencePromptPart?, TResult>? textReference = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsText && text != null)
            {
                return text(Text!);
            }
            else if (IsImageReference && imageReference != null)
            {
                return imageReference(ImageReference!);
            }
            else if (IsTextReference && textReference != null)
            {
                return textReference(TextReference!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::ElevenLabs.TextPromptPart?>? text = null,
            global::System.Action<global::ElevenLabs.ImageReferencePromptPart?>? imageReference = null,
            global::System.Action<global::ElevenLabs.TextReferencePromptPart?>? textReference = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsText)
            {
                text?.Invoke(Text!);
            }
            else if (IsImageReference)
            {
                imageReference?.Invoke(ImageReference!);
            }
            else if (IsTextReference)
            {
                textReference?.Invoke(TextReference!);
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
                typeof(global::ElevenLabs.TextPromptPart),
                ImageReference,
                typeof(global::ElevenLabs.ImageReferencePromptPart),
                TextReference,
                typeof(global::ElevenLabs.TextReferencePromptPart),
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
        public bool Equals(PromptPartsItem other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.TextPromptPart?>.Default.Equals(Text, other.Text) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.ImageReferencePromptPart?>.Default.Equals(ImageReference, other.ImageReference) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.TextReferencePromptPart?>.Default.Equals(TextReference, other.TextReference) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(PromptPartsItem obj1, PromptPartsItem obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<PromptPartsItem>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(PromptPartsItem obj1, PromptPartsItem obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is PromptPartsItem o && Equals(o);
        }
    }
}
