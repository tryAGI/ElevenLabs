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
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.ExportOptionsDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.ExportOptionsDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.ExportOptionsDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::ElevenLabs.SegmentedJsonExportOptions? segmentedJson = default;
            if (discriminator?.Format == global::ElevenLabs.ExportOptionsDiscriminatorFormat.SegmentedJson)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.SegmentedJsonExportOptions), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.SegmentedJsonExportOptions> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.SegmentedJsonExportOptions)}");
                segmentedJson = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.DocxExportOptions? docx = default;
            if (discriminator?.Format == global::ElevenLabs.ExportOptionsDiscriminatorFormat.Docx)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.DocxExportOptions), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.DocxExportOptions> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.DocxExportOptions)}");
                docx = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.PdfExportOptions? pdf = default;
            if (discriminator?.Format == global::ElevenLabs.ExportOptionsDiscriminatorFormat.Pdf)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.PdfExportOptions), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.PdfExportOptions> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.PdfExportOptions)}");
                pdf = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.TxtExportOptions? txt = default;
            if (discriminator?.Format == global::ElevenLabs.ExportOptionsDiscriminatorFormat.Txt)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.TxtExportOptions), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.TxtExportOptions> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.TxtExportOptions)}");
                txt = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.HtmlExportOptions? html = default;
            if (discriminator?.Format == global::ElevenLabs.ExportOptionsDiscriminatorFormat.Html)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.HtmlExportOptions), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.HtmlExportOptions> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.HtmlExportOptions)}");
                html = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::ElevenLabs.SrtExportOptions? srt = default;
            if (discriminator?.Format == global::ElevenLabs.ExportOptionsDiscriminatorFormat.Srt)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.SrtExportOptions), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.SrtExportOptions> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::ElevenLabs.SrtExportOptions)}");
                srt = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var result = new global::ElevenLabs.ExportOptions(
                discriminator?.Format,
                segmentedJson,
                docx,
                pdf,
                txt,
                html,
                srt
                );

            return result;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::ElevenLabs.ExportOptions value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsSegmentedJson)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.SegmentedJsonExportOptions), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.SegmentedJsonExportOptions?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.SegmentedJsonExportOptions).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.SegmentedJson, typeInfo);
            }
            else if (value.IsDocx)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.DocxExportOptions), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.DocxExportOptions?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.DocxExportOptions).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Docx, typeInfo);
            }
            else if (value.IsPdf)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.PdfExportOptions), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.PdfExportOptions?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.PdfExportOptions).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Pdf, typeInfo);
            }
            else if (value.IsTxt)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.TxtExportOptions), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.TxtExportOptions?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.TxtExportOptions).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Txt, typeInfo);
            }
            else if (value.IsHtml)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.HtmlExportOptions), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.HtmlExportOptions?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.HtmlExportOptions).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Html, typeInfo);
            }
            else if (value.IsSrt)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::ElevenLabs.SrtExportOptions), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::ElevenLabs.SrtExportOptions?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::ElevenLabs.SrtExportOptions).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Srt, typeInfo);
            }
        }
    }
}