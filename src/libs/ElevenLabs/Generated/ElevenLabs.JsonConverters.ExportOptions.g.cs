#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace ElevenLabs.JsonConverters
{
    /// <inheritdoc />
    public class ExportOptionsJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ElevenLabs.ExportOptions>
    {
        /// <inheritdoc />
        public override global::ElevenLabs.ExportOptions Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 


            var readerCopy = reader;
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.ExportOptionsDiscriminator>(ref readerCopy, options);

            global::ElevenLabs.SegmentedJsonExportOptions? segmentedJson = default;
            if (discriminator?.Format == global::ElevenLabs.ExportOptionsDiscriminatorFormat.SegmentedJson)
            {
                segmentedJson = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.SegmentedJsonExportOptions>(ref reader, options);
            }
            global::ElevenLabs.DocxExportOptions? docx = default;
            if (discriminator?.Format == global::ElevenLabs.ExportOptionsDiscriminatorFormat.Docx)
            {
                docx = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.DocxExportOptions>(ref reader, options);
            }
            global::ElevenLabs.PdfExportOptions? pdf = default;
            if (discriminator?.Format == global::ElevenLabs.ExportOptionsDiscriminatorFormat.Pdf)
            {
                pdf = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.PdfExportOptions>(ref reader, options);
            }
            global::ElevenLabs.TxtExportOptions? txt = default;
            if (discriminator?.Format == global::ElevenLabs.ExportOptionsDiscriminatorFormat.Txt)
            {
                txt = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.TxtExportOptions>(ref reader, options);
            }
            global::ElevenLabs.HtmlExportOptions? html = default;
            if (discriminator?.Format == global::ElevenLabs.ExportOptionsDiscriminatorFormat.Html)
            {
                html = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.HtmlExportOptions>(ref reader, options);
            }
            global::ElevenLabs.SrtExportOptions? srt = default;
            if (discriminator?.Format == global::ElevenLabs.ExportOptionsDiscriminatorFormat.Srt)
            {
                srt = global::System.Text.Json.JsonSerializer.Deserialize<global::ElevenLabs.SrtExportOptions>(ref reader, options);
            }

            var __value = new global::ElevenLabs.ExportOptions(
                discriminator?.Format,
                segmentedJson,

                docx,

                pdf,

                txt,

                html,

                srt
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::ElevenLabs.ExportOptions value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options)); 

            if (value.IsSegmentedJson)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SegmentedJson, typeof(global::ElevenLabs.SegmentedJsonExportOptions), options);
            }
            else if (value.IsDocx)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Docx, typeof(global::ElevenLabs.DocxExportOptions), options);
            }
            else if (value.IsPdf)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Pdf, typeof(global::ElevenLabs.PdfExportOptions), options);
            }
            else if (value.IsTxt)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Txt, typeof(global::ElevenLabs.TxtExportOptions), options);
            }
            else if (value.IsHtml)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Html, typeof(global::ElevenLabs.HtmlExportOptions), options);
            }
            else if (value.IsSrt)
            {
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Srt, typeof(global::ElevenLabs.SrtExportOptions), options);
            }
        }
    }
}