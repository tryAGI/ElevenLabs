#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ParametersItem : global::System.IEquatable<ParametersItem>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::ElevenLabs.WhatsAppTemplateHeaderComponentParamsParameterDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.WhatsAppTemplateTextParam? Text { get; init; }
#else
        public global::ElevenLabs.WhatsAppTemplateTextParam? Text { get; }
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
        public global::ElevenLabs.WhatsAppTemplateImageParam? Image { get; init; }
#else
        public global::ElevenLabs.WhatsAppTemplateImageParam? Image { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Image))]
#endif
        public bool IsImage => Image != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.WhatsAppTemplateDocumentParam? Document { get; init; }
#else
        public global::ElevenLabs.WhatsAppTemplateDocumentParam? Document { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Document))]
#endif
        public bool IsDocument => Document != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.WhatsAppTemplateLocationParam? Location { get; init; }
#else
        public global::ElevenLabs.WhatsAppTemplateLocationParam? Location { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Location))]
#endif
        public bool IsLocation => Location != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ParametersItem(global::ElevenLabs.WhatsAppTemplateTextParam value) => new ParametersItem((global::ElevenLabs.WhatsAppTemplateTextParam?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.WhatsAppTemplateTextParam?(ParametersItem @this) => @this.Text;

        /// <summary>
        /// 
        /// </summary>
        public ParametersItem(global::ElevenLabs.WhatsAppTemplateTextParam? value)
        {
            Text = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ParametersItem(global::ElevenLabs.WhatsAppTemplateImageParam value) => new ParametersItem((global::ElevenLabs.WhatsAppTemplateImageParam?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.WhatsAppTemplateImageParam?(ParametersItem @this) => @this.Image;

        /// <summary>
        /// 
        /// </summary>
        public ParametersItem(global::ElevenLabs.WhatsAppTemplateImageParam? value)
        {
            Image = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ParametersItem(global::ElevenLabs.WhatsAppTemplateDocumentParam value) => new ParametersItem((global::ElevenLabs.WhatsAppTemplateDocumentParam?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.WhatsAppTemplateDocumentParam?(ParametersItem @this) => @this.Document;

        /// <summary>
        /// 
        /// </summary>
        public ParametersItem(global::ElevenLabs.WhatsAppTemplateDocumentParam? value)
        {
            Document = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ParametersItem(global::ElevenLabs.WhatsAppTemplateLocationParam value) => new ParametersItem((global::ElevenLabs.WhatsAppTemplateLocationParam?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.WhatsAppTemplateLocationParam?(ParametersItem @this) => @this.Location;

        /// <summary>
        /// 
        /// </summary>
        public ParametersItem(global::ElevenLabs.WhatsAppTemplateLocationParam? value)
        {
            Location = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ParametersItem(
            global::ElevenLabs.WhatsAppTemplateHeaderComponentParamsParameterDiscriminatorType? type,
            global::ElevenLabs.WhatsAppTemplateTextParam? text,
            global::ElevenLabs.WhatsAppTemplateImageParam? image,
            global::ElevenLabs.WhatsAppTemplateDocumentParam? document,
            global::ElevenLabs.WhatsAppTemplateLocationParam? location
            )
        {
            Type = type;

            Text = text;
            Image = image;
            Document = document;
            Location = location;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Location as object ??
            Document as object ??
            Image as object ??
            Text as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Text?.ToString() ??
            Image?.ToString() ??
            Document?.ToString() ??
            Location?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsText && !IsImage && !IsDocument && !IsLocation || !IsText && IsImage && !IsDocument && !IsLocation || !IsText && !IsImage && IsDocument && !IsLocation || !IsText && !IsImage && !IsDocument && IsLocation;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::ElevenLabs.WhatsAppTemplateTextParam?, TResult>? text = null,
            global::System.Func<global::ElevenLabs.WhatsAppTemplateImageParam?, TResult>? image = null,
            global::System.Func<global::ElevenLabs.WhatsAppTemplateDocumentParam?, TResult>? document = null,
            global::System.Func<global::ElevenLabs.WhatsAppTemplateLocationParam?, TResult>? location = null,
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
            else if (IsImage && image != null)
            {
                return image(Image!);
            }
            else if (IsDocument && document != null)
            {
                return document(Document!);
            }
            else if (IsLocation && location != null)
            {
                return location(Location!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::ElevenLabs.WhatsAppTemplateTextParam?>? text = null,
            global::System.Action<global::ElevenLabs.WhatsAppTemplateImageParam?>? image = null,
            global::System.Action<global::ElevenLabs.WhatsAppTemplateDocumentParam?>? document = null,
            global::System.Action<global::ElevenLabs.WhatsAppTemplateLocationParam?>? location = null,
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
            else if (IsImage)
            {
                image?.Invoke(Image!);
            }
            else if (IsDocument)
            {
                document?.Invoke(Document!);
            }
            else if (IsLocation)
            {
                location?.Invoke(Location!);
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
                typeof(global::ElevenLabs.WhatsAppTemplateTextParam),
                Image,
                typeof(global::ElevenLabs.WhatsAppTemplateImageParam),
                Document,
                typeof(global::ElevenLabs.WhatsAppTemplateDocumentParam),
                Location,
                typeof(global::ElevenLabs.WhatsAppTemplateLocationParam),
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
        public bool Equals(ParametersItem other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.WhatsAppTemplateTextParam?>.Default.Equals(Text, other.Text) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.WhatsAppTemplateImageParam?>.Default.Equals(Image, other.Image) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.WhatsAppTemplateDocumentParam?>.Default.Equals(Document, other.Document) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.WhatsAppTemplateLocationParam?>.Default.Equals(Location, other.Location) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ParametersItem obj1, ParametersItem obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ParametersItem>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ParametersItem obj1, ParametersItem obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ParametersItem o && Equals(o);
        }
    }
}
