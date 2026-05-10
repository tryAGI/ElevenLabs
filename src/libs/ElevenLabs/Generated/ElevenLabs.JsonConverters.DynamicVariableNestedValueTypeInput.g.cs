#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace ElevenLabs.JsonConverters
{
    /// <inheritdoc />
    public class DynamicVariableNestedValueTypeInputJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::ElevenLabs.DynamicVariableNestedValueTypeInput>
    {
        /// <inheritdoc />
        public override global::ElevenLabs.DynamicVariableNestedValueTypeInput Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            using var __jsonDocument = global::System.Text.Json.JsonDocument.ParseValue(ref reader);
            var __rawJson = __jsonDocument.RootElement.GetRawText();
            var __jsonProps = new global::System.Collections.Generic.HashSet<string>();
            if (__jsonDocument.RootElement.ValueKind == global::System.Text.Json.JsonValueKind.Object)
            {
                foreach (var __jsonProp in __jsonDocument.RootElement.EnumerateObject())
                {
                    __jsonProps.Add(__jsonProp.Name);
                }
            }

            var __score0 = 0;
            {
                var __ti = typeInfoResolver.GetTypeInfo(typeof(string), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {
                    foreach (var __prop in __ti.Properties)
                    {
                        if (__jsonProps.Contains(__prop.Name)) __score0++;
                    }
                }
            }
            var __score1 = 0;
            {
                var __ti = typeInfoResolver.GetTypeInfo(typeof(int), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {
                    foreach (var __prop in __ti.Properties)
                    {
                        if (__jsonProps.Contains(__prop.Name)) __score1++;
                    }
                }
            }
            var __score2 = 0;
            {
                var __ti = typeInfoResolver.GetTypeInfo(typeof(double), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {
                    foreach (var __prop in __ti.Properties)
                    {
                        if (__jsonProps.Contains(__prop.Name)) __score2++;
                    }
                }
            }
            var __score3 = 0;
            {
                var __ti = typeInfoResolver.GetTypeInfo(typeof(bool), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {
                    foreach (var __prop in __ti.Properties)
                    {
                        if (__jsonProps.Contains(__prop.Name)) __score3++;
                    }
                }
            }
            var __score4 = 0;
            {
                var __ti = typeInfoResolver.GetTypeInfo(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.DynamicVariableNestedValueTypeInput>), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {
                    foreach (var __prop in __ti.Properties)
                    {
                        if (__jsonProps.Contains(__prop.Name)) __score4++;
                    }
                }
            }
            var __score5 = 0;
            {
                var __ti = typeInfoResolver.GetTypeInfo(typeof(object), options);
                if (__ti != null && __ti.Kind == global::System.Text.Json.Serialization.Metadata.JsonTypeInfoKind.Object)
                {
                    foreach (var __prop in __ti.Properties)
                    {
                        if (__jsonProps.Contains(__prop.Name)) __score5++;
                    }
                }
            }
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }
            if (__score2 > __bestScore) { __bestScore = __score2; __bestIndex = 2; }
            if (__score3 > __bestScore) { __bestScore = __score3; __bestIndex = 3; }
            if (__score4 > __bestScore) { __bestScore = __score4; __bestIndex = 4; }
            if (__score5 > __bestScore) { __bestScore = __score5; __bestIndex = 5; }

            string? dynamicVariableNestedValueTypeInputVariant1 = default;
            int? dynamicVariableNestedValueTypeInputVariant2 = default;
            double? dynamicVariableNestedValueTypeInputVariant3 = default;
            bool? dynamicVariableNestedValueTypeInputVariant4 = default;
            global::System.Collections.Generic.IList<global::ElevenLabs.DynamicVariableNestedValueTypeInput>? dynamicVariableNestedValueTypeInputVariant5 = default;
            object? dynamicVariableNestedValueTypeInputVariant6 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(string), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<string> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(string).Name}");
                        dynamicVariableNestedValueTypeInputVariant1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }

                else if (__bestIndex == 1)
                {
                    try
                    {

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(int), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<int> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(int).Name}");
                        dynamicVariableNestedValueTypeInputVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }

                else if (__bestIndex == 2)
                {
                    try
                    {

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(double), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<double> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(double).Name}");
                        dynamicVariableNestedValueTypeInputVariant3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }

                else if (__bestIndex == 3)
                {
                    try
                    {

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(bool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<bool> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(bool).Name}");
                        dynamicVariableNestedValueTypeInputVariant4 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }

                else if (__bestIndex == 4)
                {
                    try
                    {

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.DynamicVariableNestedValueTypeInput>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.Collections.Generic.IList<global::ElevenLabs.DynamicVariableNestedValueTypeInput>> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::System.Collections.Generic.IList<global::ElevenLabs.DynamicVariableNestedValueTypeInput>).Name}");
                        dynamicVariableNestedValueTypeInputVariant5 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }

                else if (__bestIndex == 5)
                {
                    try
                    {

                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(object), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<object> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(object).Name}");
                        dynamicVariableNestedValueTypeInputVariant6 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (dynamicVariableNestedValueTypeInputVariant1 == null && dynamicVariableNestedValueTypeInputVariant2 == null && dynamicVariableNestedValueTypeInputVariant3 == null && dynamicVariableNestedValueTypeInputVariant4 == null && dynamicVariableNestedValueTypeInputVariant5 == null && dynamicVariableNestedValueTypeInputVariant6 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(string), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<string> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(string).Name}");
                    dynamicVariableNestedValueTypeInputVariant1 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (dynamicVariableNestedValueTypeInputVariant1 == null && dynamicVariableNestedValueTypeInputVariant2 == null && dynamicVariableNestedValueTypeInputVariant3 == null && dynamicVariableNestedValueTypeInputVariant4 == null && dynamicVariableNestedValueTypeInputVariant5 == null && dynamicVariableNestedValueTypeInputVariant6 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(int), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<int> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(int).Name}");
                    dynamicVariableNestedValueTypeInputVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (dynamicVariableNestedValueTypeInputVariant1 == null && dynamicVariableNestedValueTypeInputVariant2 == null && dynamicVariableNestedValueTypeInputVariant3 == null && dynamicVariableNestedValueTypeInputVariant4 == null && dynamicVariableNestedValueTypeInputVariant5 == null && dynamicVariableNestedValueTypeInputVariant6 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(double), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<double> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(double).Name}");
                    dynamicVariableNestedValueTypeInputVariant3 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (dynamicVariableNestedValueTypeInputVariant1 == null && dynamicVariableNestedValueTypeInputVariant2 == null && dynamicVariableNestedValueTypeInputVariant3 == null && dynamicVariableNestedValueTypeInputVariant4 == null && dynamicVariableNestedValueTypeInputVariant5 == null && dynamicVariableNestedValueTypeInputVariant6 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(bool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<bool> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(bool).Name}");
                    dynamicVariableNestedValueTypeInputVariant4 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (dynamicVariableNestedValueTypeInputVariant1 == null && dynamicVariableNestedValueTypeInputVariant2 == null && dynamicVariableNestedValueTypeInputVariant3 == null && dynamicVariableNestedValueTypeInputVariant4 == null && dynamicVariableNestedValueTypeInputVariant5 == null && dynamicVariableNestedValueTypeInputVariant6 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.DynamicVariableNestedValueTypeInput>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.Collections.Generic.IList<global::ElevenLabs.DynamicVariableNestedValueTypeInput>> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::System.Collections.Generic.IList<global::ElevenLabs.DynamicVariableNestedValueTypeInput>).Name}");
                    dynamicVariableNestedValueTypeInputVariant5 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            if (dynamicVariableNestedValueTypeInputVariant1 == null && dynamicVariableNestedValueTypeInputVariant2 == null && dynamicVariableNestedValueTypeInputVariant3 == null && dynamicVariableNestedValueTypeInputVariant4 == null && dynamicVariableNestedValueTypeInputVariant5 == null && dynamicVariableNestedValueTypeInputVariant6 == null)
            {
                try
                {

                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(object), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<object> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(object).Name}");
                    dynamicVariableNestedValueTypeInputVariant6 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::ElevenLabs.DynamicVariableNestedValueTypeInput(
                dynamicVariableNestedValueTypeInputVariant1,

                dynamicVariableNestedValueTypeInputVariant2,

                dynamicVariableNestedValueTypeInputVariant3,

                dynamicVariableNestedValueTypeInputVariant4,

                dynamicVariableNestedValueTypeInputVariant5,

                dynamicVariableNestedValueTypeInputVariant6
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::ElevenLabs.DynamicVariableNestedValueTypeInput value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsDynamicVariableNestedValueTypeInputVariant1)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(string), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<string?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(string).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.DynamicVariableNestedValueTypeInputVariant1!, typeInfo);
            }
            else if (value.IsDynamicVariableNestedValueTypeInputVariant2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(int), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<int> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(int).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.DynamicVariableNestedValueTypeInputVariant2!.Value, typeInfo);
            }
            else if (value.IsDynamicVariableNestedValueTypeInputVariant3)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(double), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<double> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(double).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.DynamicVariableNestedValueTypeInputVariant3!.Value, typeInfo);
            }
            else if (value.IsDynamicVariableNestedValueTypeInputVariant4)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(bool), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<bool> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(bool).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.DynamicVariableNestedValueTypeInputVariant4!.Value, typeInfo);
            }
            else if (value.IsDynamicVariableNestedValueTypeInputVariant5)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::System.Collections.Generic.IList<global::ElevenLabs.DynamicVariableNestedValueTypeInput>), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::System.Collections.Generic.IList<global::ElevenLabs.DynamicVariableNestedValueTypeInput>?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::System.Collections.Generic.IList<global::ElevenLabs.DynamicVariableNestedValueTypeInput>).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.DynamicVariableNestedValueTypeInputVariant5!, typeInfo);
            }
            else if (value.IsDynamicVariableNestedValueTypeInputVariant6)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(object), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<object?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(object).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.DynamicVariableNestedValueTypeInputVariant6!, typeInfo);
            }
        }
    }
}