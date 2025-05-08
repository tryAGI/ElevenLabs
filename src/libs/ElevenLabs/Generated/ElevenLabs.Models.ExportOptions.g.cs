#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ExportOptions : global::System.IEquatable<ExportOptions>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::ElevenLabs.ExportOptionsDiscriminatorFormat? Format { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.SegmentedJsonExportOptions? SegmentedJson { get; init; }
#else
        public global::ElevenLabs.SegmentedJsonExportOptions? SegmentedJson { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SegmentedJson))]
#endif
        public bool IsSegmentedJson => SegmentedJson != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ExportOptions(global::ElevenLabs.SegmentedJsonExportOptions value) => new ExportOptions((global::ElevenLabs.SegmentedJsonExportOptions?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.SegmentedJsonExportOptions?(ExportOptions @this) => @this.SegmentedJson;

        /// <summary>
        /// 
        /// </summary>
        public ExportOptions(global::ElevenLabs.SegmentedJsonExportOptions? value)
        {
            SegmentedJson = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.DocxExportOptions? Docx { get; init; }
#else
        public global::ElevenLabs.DocxExportOptions? Docx { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Docx))]
#endif
        public bool IsDocx => Docx != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ExportOptions(global::ElevenLabs.DocxExportOptions value) => new ExportOptions((global::ElevenLabs.DocxExportOptions?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.DocxExportOptions?(ExportOptions @this) => @this.Docx;

        /// <summary>
        /// 
        /// </summary>
        public ExportOptions(global::ElevenLabs.DocxExportOptions? value)
        {
            Docx = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.PdfExportOptions? Pdf { get; init; }
#else
        public global::ElevenLabs.PdfExportOptions? Pdf { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Pdf))]
#endif
        public bool IsPdf => Pdf != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ExportOptions(global::ElevenLabs.PdfExportOptions value) => new ExportOptions((global::ElevenLabs.PdfExportOptions?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.PdfExportOptions?(ExportOptions @this) => @this.Pdf;

        /// <summary>
        /// 
        /// </summary>
        public ExportOptions(global::ElevenLabs.PdfExportOptions? value)
        {
            Pdf = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.TxtExportOptions? Txt { get; init; }
#else
        public global::ElevenLabs.TxtExportOptions? Txt { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Txt))]
#endif
        public bool IsTxt => Txt != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ExportOptions(global::ElevenLabs.TxtExportOptions value) => new ExportOptions((global::ElevenLabs.TxtExportOptions?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.TxtExportOptions?(ExportOptions @this) => @this.Txt;

        /// <summary>
        /// 
        /// </summary>
        public ExportOptions(global::ElevenLabs.TxtExportOptions? value)
        {
            Txt = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.HtmlExportOptions? Html { get; init; }
#else
        public global::ElevenLabs.HtmlExportOptions? Html { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Html))]
#endif
        public bool IsHtml => Html != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ExportOptions(global::ElevenLabs.HtmlExportOptions value) => new ExportOptions((global::ElevenLabs.HtmlExportOptions?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.HtmlExportOptions?(ExportOptions @this) => @this.Html;

        /// <summary>
        /// 
        /// </summary>
        public ExportOptions(global::ElevenLabs.HtmlExportOptions? value)
        {
            Html = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.SrtExportOptions? Srt { get; init; }
#else
        public global::ElevenLabs.SrtExportOptions? Srt { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Srt))]
#endif
        public bool IsSrt => Srt != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ExportOptions(global::ElevenLabs.SrtExportOptions value) => new ExportOptions((global::ElevenLabs.SrtExportOptions?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.SrtExportOptions?(ExportOptions @this) => @this.Srt;

        /// <summary>
        /// 
        /// </summary>
        public ExportOptions(global::ElevenLabs.SrtExportOptions? value)
        {
            Srt = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ExportOptions(
            global::ElevenLabs.ExportOptionsDiscriminatorFormat? format,
            global::ElevenLabs.SegmentedJsonExportOptions? segmentedJson,
            global::ElevenLabs.DocxExportOptions? docx,
            global::ElevenLabs.PdfExportOptions? pdf,
            global::ElevenLabs.TxtExportOptions? txt,
            global::ElevenLabs.HtmlExportOptions? html,
            global::ElevenLabs.SrtExportOptions? srt
            )
        {
            Format = format;

            SegmentedJson = segmentedJson;
            Docx = docx;
            Pdf = pdf;
            Txt = txt;
            Html = html;
            Srt = srt;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Srt as object ??
            Html as object ??
            Txt as object ??
            Pdf as object ??
            Docx as object ??
            SegmentedJson as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            SegmentedJson?.ToString() ??
            Docx?.ToString() ??
            Pdf?.ToString() ??
            Txt?.ToString() ??
            Html?.ToString() ??
            Srt?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsSegmentedJson && !IsDocx && !IsPdf && !IsTxt && !IsHtml && !IsSrt || !IsSegmentedJson && IsDocx && !IsPdf && !IsTxt && !IsHtml && !IsSrt || !IsSegmentedJson && !IsDocx && IsPdf && !IsTxt && !IsHtml && !IsSrt || !IsSegmentedJson && !IsDocx && !IsPdf && IsTxt && !IsHtml && !IsSrt || !IsSegmentedJson && !IsDocx && !IsPdf && !IsTxt && IsHtml && !IsSrt || !IsSegmentedJson && !IsDocx && !IsPdf && !IsTxt && !IsHtml && IsSrt;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::ElevenLabs.SegmentedJsonExportOptions?, TResult>? segmentedJson = null,
            global::System.Func<global::ElevenLabs.DocxExportOptions?, TResult>? docx = null,
            global::System.Func<global::ElevenLabs.PdfExportOptions?, TResult>? pdf = null,
            global::System.Func<global::ElevenLabs.TxtExportOptions?, TResult>? txt = null,
            global::System.Func<global::ElevenLabs.HtmlExportOptions?, TResult>? html = null,
            global::System.Func<global::ElevenLabs.SrtExportOptions?, TResult>? srt = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSegmentedJson && segmentedJson != null)
            {
                return segmentedJson(SegmentedJson!);
            }
            else if (IsDocx && docx != null)
            {
                return docx(Docx!);
            }
            else if (IsPdf && pdf != null)
            {
                return pdf(Pdf!);
            }
            else if (IsTxt && txt != null)
            {
                return txt(Txt!);
            }
            else if (IsHtml && html != null)
            {
                return html(Html!);
            }
            else if (IsSrt && srt != null)
            {
                return srt(Srt!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::ElevenLabs.SegmentedJsonExportOptions?>? segmentedJson = null,
            global::System.Action<global::ElevenLabs.DocxExportOptions?>? docx = null,
            global::System.Action<global::ElevenLabs.PdfExportOptions?>? pdf = null,
            global::System.Action<global::ElevenLabs.TxtExportOptions?>? txt = null,
            global::System.Action<global::ElevenLabs.HtmlExportOptions?>? html = null,
            global::System.Action<global::ElevenLabs.SrtExportOptions?>? srt = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsSegmentedJson)
            {
                segmentedJson?.Invoke(SegmentedJson!);
            }
            else if (IsDocx)
            {
                docx?.Invoke(Docx!);
            }
            else if (IsPdf)
            {
                pdf?.Invoke(Pdf!);
            }
            else if (IsTxt)
            {
                txt?.Invoke(Txt!);
            }
            else if (IsHtml)
            {
                html?.Invoke(Html!);
            }
            else if (IsSrt)
            {
                srt?.Invoke(Srt!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                SegmentedJson,
                typeof(global::ElevenLabs.SegmentedJsonExportOptions),
                Docx,
                typeof(global::ElevenLabs.DocxExportOptions),
                Pdf,
                typeof(global::ElevenLabs.PdfExportOptions),
                Txt,
                typeof(global::ElevenLabs.TxtExportOptions),
                Html,
                typeof(global::ElevenLabs.HtmlExportOptions),
                Srt,
                typeof(global::ElevenLabs.SrtExportOptions),
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
        public bool Equals(ExportOptions other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.SegmentedJsonExportOptions?>.Default.Equals(SegmentedJson, other.SegmentedJson) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.DocxExportOptions?>.Default.Equals(Docx, other.Docx) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.PdfExportOptions?>.Default.Equals(Pdf, other.Pdf) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.TxtExportOptions?>.Default.Equals(Txt, other.Txt) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.HtmlExportOptions?>.Default.Equals(Html, other.Html) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.SrtExportOptions?>.Default.Equals(Srt, other.Srt) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ExportOptions obj1, ExportOptions obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ExportOptions>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ExportOptions obj1, ExportOptions obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ExportOptions o && Equals(o);
        }
    }
}
