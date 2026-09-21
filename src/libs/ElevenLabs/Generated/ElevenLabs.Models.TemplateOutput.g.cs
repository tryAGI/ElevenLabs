#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// One output of a template run, discriminated on `type`: the `type` of the<br/>
    /// port's `content_schema`. Check `status` for where it is in its lifecycle.
    /// </summary>
    public readonly partial struct TemplateOutput : global::System.IEquatable<TemplateOutput>
    {
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TemplateOutputDiscriminatorType? Type { get; }

        /// <summary>
        /// An `image` output, downloaded from `content_url` once completed.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.TemplateImageOutput? Image { get; init; }
#else
        public global::ElevenLabs.TemplateImageOutput? Image { get; }
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
        public bool TryPickImage(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.TemplateImageOutput? value)
        {
            value = Image;
            return IsImage;
        }

        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TemplateImageOutput PickImage() => IsImage
            ? Image!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Image' but the value was {ToString()}.");

        /// <summary>
        /// A `video` output, downloaded from `content_url` once completed.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.TemplateVideoOutput? Video { get; init; }
#else
        public global::ElevenLabs.TemplateVideoOutput? Video { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Video))]
#endif
        public bool IsVideo => Video != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickVideo(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.TemplateVideoOutput? value)
        {
            value = Video;
            return IsVideo;
        }

        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TemplateVideoOutput PickVideo() => IsVideo
            ? Video!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Video' but the value was {ToString()}.");

        /// <summary>
        /// An `audio` output, downloaded from `content_url` once completed.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.TemplateAudioOutput? Audio { get; init; }
#else
        public global::ElevenLabs.TemplateAudioOutput? Audio { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Audio))]
#endif
        public bool IsAudio => Audio != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAudio(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.TemplateAudioOutput? value)
        {
            value = Audio;
            return IsAudio;
        }

        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TemplateAudioOutput PickAudio() => IsAudio
            ? Audio!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Audio' but the value was {ToString()}.");

        /// <summary>
        /// A `string` output, delivered as `content` once completed.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.TemplateStringOutput? String { get; init; }
#else
        public global::ElevenLabs.TemplateStringOutput? String { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(String))]
#endif
        public bool IsString => String != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickString(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.TemplateStringOutput? value)
        {
            value = String;
            return IsString;
        }

        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TemplateStringOutput PickString() => IsString
            ? String!
            : throw new global::System.InvalidOperationException($"Expected union variant 'String' but the value was {ToString()}.");

        /// <summary>
        /// An `integer` output, delivered as `content` once completed.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.TemplateIntegerOutput? Integer { get; init; }
#else
        public global::ElevenLabs.TemplateIntegerOutput? Integer { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Integer))]
#endif
        public bool IsInteger => Integer != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickInteger(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.TemplateIntegerOutput? value)
        {
            value = Integer;
            return IsInteger;
        }

        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TemplateIntegerOutput PickInteger() => IsInteger
            ? Integer!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Integer' but the value was {ToString()}.");

        /// <summary>
        /// A `number` output, delivered as `content` once completed.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.TemplateNumberOutput? Number { get; init; }
#else
        public global::ElevenLabs.TemplateNumberOutput? Number { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Number))]
#endif
        public bool IsNumber => Number != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickNumber(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.TemplateNumberOutput? value)
        {
            value = Number;
            return IsNumber;
        }

        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TemplateNumberOutput PickNumber() => IsNumber
            ? Number!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Number' but the value was {ToString()}.");

        /// <summary>
        /// A `boolean` output, delivered as `content` once completed.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.TemplateBooleanOutput? Boolean { get; init; }
#else
        public global::ElevenLabs.TemplateBooleanOutput? Boolean { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Boolean))]
#endif
        public bool IsBoolean => Boolean != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBoolean(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.TemplateBooleanOutput? value)
        {
            value = Boolean;
            return IsBoolean;
        }

        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TemplateBooleanOutput PickBoolean() => IsBoolean
            ? Boolean!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Boolean' but the value was {ToString()}.");

        /// <summary>
        /// An `array` output, delivered as `content` once completed: one output per<br/>
        /// element, each an output in its own right with its own `status`. A list can<br/>
        /// be arbitrarily long, so `content` is its first page; when `has_more` is<br/>
        /// true, `next_cursor` leads to the rest.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.TemplateArrayOutput? Array { get; init; }
#else
        public global::ElevenLabs.TemplateArrayOutput? Array { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Array))]
#endif
        public bool IsArray => Array != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickArray(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.TemplateArrayOutput? value)
        {
            value = Array;
            return IsArray;
        }

        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TemplateArrayOutput PickArray() => IsArray
            ? Array!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Array' but the value was {ToString()}.");

        /// <summary>
        /// An `object` output, delivered as `content` once completed: one output per<br/>
        /// field of the schema's `properties`, each an output in its own right with<br/>
        /// its own `status`. There are no dynamic fields.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.TemplateObjectOutput? ObjectValue { get; init; }
#else
        public global::ElevenLabs.TemplateObjectOutput? ObjectValue { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ObjectValue))]
#endif
        public bool IsObjectValue => ObjectValue != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickObjectValue(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.TemplateObjectOutput? value)
        {
            value = ObjectValue;
            return IsObjectValue;
        }

        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TemplateObjectOutput PickObjectValue() => IsObjectValue
            ? ObjectValue!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ObjectValue' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator TemplateOutput(global::ElevenLabs.TemplateImageOutput value) => new TemplateOutput((global::ElevenLabs.TemplateImageOutput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::ElevenLabs.TemplateImageOutput?(TemplateOutput @this) => @this.Image;

        /// <summary>
        ///
        /// </summary>
        public TemplateOutput(global::ElevenLabs.TemplateImageOutput? value)
        {
            Image = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static TemplateOutput FromImage(global::ElevenLabs.TemplateImageOutput? value) => new TemplateOutput(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator TemplateOutput(global::ElevenLabs.TemplateVideoOutput value) => new TemplateOutput((global::ElevenLabs.TemplateVideoOutput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::ElevenLabs.TemplateVideoOutput?(TemplateOutput @this) => @this.Video;

        /// <summary>
        ///
        /// </summary>
        public TemplateOutput(global::ElevenLabs.TemplateVideoOutput? value)
        {
            Video = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static TemplateOutput FromVideo(global::ElevenLabs.TemplateVideoOutput? value) => new TemplateOutput(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator TemplateOutput(global::ElevenLabs.TemplateAudioOutput value) => new TemplateOutput((global::ElevenLabs.TemplateAudioOutput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::ElevenLabs.TemplateAudioOutput?(TemplateOutput @this) => @this.Audio;

        /// <summary>
        ///
        /// </summary>
        public TemplateOutput(global::ElevenLabs.TemplateAudioOutput? value)
        {
            Audio = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static TemplateOutput FromAudio(global::ElevenLabs.TemplateAudioOutput? value) => new TemplateOutput(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator TemplateOutput(global::ElevenLabs.TemplateStringOutput value) => new TemplateOutput((global::ElevenLabs.TemplateStringOutput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::ElevenLabs.TemplateStringOutput?(TemplateOutput @this) => @this.String;

        /// <summary>
        ///
        /// </summary>
        public TemplateOutput(global::ElevenLabs.TemplateStringOutput? value)
        {
            String = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static TemplateOutput FromString(global::ElevenLabs.TemplateStringOutput? value) => new TemplateOutput(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator TemplateOutput(global::ElevenLabs.TemplateIntegerOutput value) => new TemplateOutput((global::ElevenLabs.TemplateIntegerOutput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::ElevenLabs.TemplateIntegerOutput?(TemplateOutput @this) => @this.Integer;

        /// <summary>
        ///
        /// </summary>
        public TemplateOutput(global::ElevenLabs.TemplateIntegerOutput? value)
        {
            Integer = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static TemplateOutput FromInteger(global::ElevenLabs.TemplateIntegerOutput? value) => new TemplateOutput(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator TemplateOutput(global::ElevenLabs.TemplateNumberOutput value) => new TemplateOutput((global::ElevenLabs.TemplateNumberOutput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::ElevenLabs.TemplateNumberOutput?(TemplateOutput @this) => @this.Number;

        /// <summary>
        ///
        /// </summary>
        public TemplateOutput(global::ElevenLabs.TemplateNumberOutput? value)
        {
            Number = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static TemplateOutput FromNumber(global::ElevenLabs.TemplateNumberOutput? value) => new TemplateOutput(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator TemplateOutput(global::ElevenLabs.TemplateBooleanOutput value) => new TemplateOutput((global::ElevenLabs.TemplateBooleanOutput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::ElevenLabs.TemplateBooleanOutput?(TemplateOutput @this) => @this.Boolean;

        /// <summary>
        ///
        /// </summary>
        public TemplateOutput(global::ElevenLabs.TemplateBooleanOutput? value)
        {
            Boolean = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static TemplateOutput FromBoolean(global::ElevenLabs.TemplateBooleanOutput? value) => new TemplateOutput(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator TemplateOutput(global::ElevenLabs.TemplateArrayOutput value) => new TemplateOutput((global::ElevenLabs.TemplateArrayOutput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::ElevenLabs.TemplateArrayOutput?(TemplateOutput @this) => @this.Array;

        /// <summary>
        ///
        /// </summary>
        public TemplateOutput(global::ElevenLabs.TemplateArrayOutput? value)
        {
            Array = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static TemplateOutput FromArray(global::ElevenLabs.TemplateArrayOutput? value) => new TemplateOutput(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator TemplateOutput(global::ElevenLabs.TemplateObjectOutput value) => new TemplateOutput((global::ElevenLabs.TemplateObjectOutput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::ElevenLabs.TemplateObjectOutput?(TemplateOutput @this) => @this.ObjectValue;

        /// <summary>
        ///
        /// </summary>
        public TemplateOutput(global::ElevenLabs.TemplateObjectOutput? value)
        {
            ObjectValue = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static TemplateOutput FromObjectValue(global::ElevenLabs.TemplateObjectOutput? value) => new TemplateOutput(value);

        /// <summary>
        ///
        /// </summary>
        public TemplateOutput(
            global::ElevenLabs.TemplateOutputDiscriminatorType? type,
            global::ElevenLabs.TemplateImageOutput? image,
            global::ElevenLabs.TemplateVideoOutput? video,
            global::ElevenLabs.TemplateAudioOutput? audio,
            global::ElevenLabs.TemplateStringOutput? @string,
            global::ElevenLabs.TemplateIntegerOutput? integer,
            global::ElevenLabs.TemplateNumberOutput? number,
            global::ElevenLabs.TemplateBooleanOutput? boolean,
            global::ElevenLabs.TemplateArrayOutput? array,
            global::ElevenLabs.TemplateObjectOutput? objectValue
            )
        {
            Type = type;

            Image = image;
            Video = video;
            Audio = audio;
            String = @string;
            Integer = integer;
            Number = number;
            Boolean = boolean;
            Array = array;
            ObjectValue = objectValue;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            ObjectValue as object ??
            Array as object ??
            Boolean as object ??
            Number as object ??
            Integer as object ??
            String as object ??
            Audio as object ??
            Video as object ??
            Image as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Image?.ToString() ??
            Video?.ToString() ??
            Audio?.ToString() ??
            String?.ToString() ??
            Integer?.ToString() ??
            Number?.ToString() ??
            Boolean?.ToString() ??
            Array?.ToString() ??
            ObjectValue?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsImage && !IsVideo && !IsAudio && !IsString && !IsInteger && !IsNumber && !IsBoolean && !IsArray && !IsObjectValue || !IsImage && IsVideo && !IsAudio && !IsString && !IsInteger && !IsNumber && !IsBoolean && !IsArray && !IsObjectValue || !IsImage && !IsVideo && IsAudio && !IsString && !IsInteger && !IsNumber && !IsBoolean && !IsArray && !IsObjectValue || !IsImage && !IsVideo && !IsAudio && IsString && !IsInteger && !IsNumber && !IsBoolean && !IsArray && !IsObjectValue || !IsImage && !IsVideo && !IsAudio && !IsString && IsInteger && !IsNumber && !IsBoolean && !IsArray && !IsObjectValue || !IsImage && !IsVideo && !IsAudio && !IsString && !IsInteger && IsNumber && !IsBoolean && !IsArray && !IsObjectValue || !IsImage && !IsVideo && !IsAudio && !IsString && !IsInteger && !IsNumber && IsBoolean && !IsArray && !IsObjectValue || !IsImage && !IsVideo && !IsAudio && !IsString && !IsInteger && !IsNumber && !IsBoolean && IsArray && !IsObjectValue || !IsImage && !IsVideo && !IsAudio && !IsString && !IsInteger && !IsNumber && !IsBoolean && !IsArray && IsObjectValue;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::ElevenLabs.TemplateImageOutput, TResult>? image = null,
            global::System.Func<global::ElevenLabs.TemplateVideoOutput, TResult>? video = null,
            global::System.Func<global::ElevenLabs.TemplateAudioOutput, TResult>? audio = null,
            global::System.Func<global::ElevenLabs.TemplateStringOutput, TResult>? @string = null,
            global::System.Func<global::ElevenLabs.TemplateIntegerOutput, TResult>? integer = null,
            global::System.Func<global::ElevenLabs.TemplateNumberOutput, TResult>? number = null,
            global::System.Func<global::ElevenLabs.TemplateBooleanOutput, TResult>? boolean = null,
            global::System.Func<global::ElevenLabs.TemplateArrayOutput, TResult>? array = null,
            global::System.Func<global::ElevenLabs.TemplateObjectOutput, TResult>? objectValue = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsImage && image != null)
            {
                return image(Image!);
            }
            else if (IsVideo && video != null)
            {
                return video(Video!);
            }
            else if (IsAudio && audio != null)
            {
                return audio(Audio!);
            }
            else if (IsString && @string != null)
            {
                return @string(String!);
            }
            else if (IsInteger && integer != null)
            {
                return integer(Integer!);
            }
            else if (IsNumber && number != null)
            {
                return number(Number!);
            }
            else if (IsBoolean && boolean != null)
            {
                return boolean(Boolean!);
            }
            else if (IsArray && array != null)
            {
                return array(Array!);
            }
            else if (IsObjectValue && objectValue != null)
            {
                return objectValue(ObjectValue!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::ElevenLabs.TemplateImageOutput>? image = null,

            global::System.Action<global::ElevenLabs.TemplateVideoOutput>? video = null,

            global::System.Action<global::ElevenLabs.TemplateAudioOutput>? audio = null,

            global::System.Action<global::ElevenLabs.TemplateStringOutput>? @string = null,

            global::System.Action<global::ElevenLabs.TemplateIntegerOutput>? integer = null,

            global::System.Action<global::ElevenLabs.TemplateNumberOutput>? number = null,

            global::System.Action<global::ElevenLabs.TemplateBooleanOutput>? boolean = null,

            global::System.Action<global::ElevenLabs.TemplateArrayOutput>? array = null,

            global::System.Action<global::ElevenLabs.TemplateObjectOutput>? objectValue = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsImage)
            {
                image?.Invoke(Image!);
            }
            else if (IsVideo)
            {
                video?.Invoke(Video!);
            }
            else if (IsAudio)
            {
                audio?.Invoke(Audio!);
            }
            else if (IsString)
            {
                @string?.Invoke(String!);
            }
            else if (IsInteger)
            {
                integer?.Invoke(Integer!);
            }
            else if (IsNumber)
            {
                number?.Invoke(Number!);
            }
            else if (IsBoolean)
            {
                boolean?.Invoke(Boolean!);
            }
            else if (IsArray)
            {
                array?.Invoke(Array!);
            }
            else if (IsObjectValue)
            {
                objectValue?.Invoke(ObjectValue!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::ElevenLabs.TemplateImageOutput>? image = null,
            global::System.Action<global::ElevenLabs.TemplateVideoOutput>? video = null,
            global::System.Action<global::ElevenLabs.TemplateAudioOutput>? audio = null,
            global::System.Action<global::ElevenLabs.TemplateStringOutput>? @string = null,
            global::System.Action<global::ElevenLabs.TemplateIntegerOutput>? integer = null,
            global::System.Action<global::ElevenLabs.TemplateNumberOutput>? number = null,
            global::System.Action<global::ElevenLabs.TemplateBooleanOutput>? boolean = null,
            global::System.Action<global::ElevenLabs.TemplateArrayOutput>? array = null,
            global::System.Action<global::ElevenLabs.TemplateObjectOutput>? objectValue = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsImage)
            {
                image?.Invoke(Image!);
            }
            else if (IsVideo)
            {
                video?.Invoke(Video!);
            }
            else if (IsAudio)
            {
                audio?.Invoke(Audio!);
            }
            else if (IsString)
            {
                @string?.Invoke(String!);
            }
            else if (IsInteger)
            {
                integer?.Invoke(Integer!);
            }
            else if (IsNumber)
            {
                number?.Invoke(Number!);
            }
            else if (IsBoolean)
            {
                boolean?.Invoke(Boolean!);
            }
            else if (IsArray)
            {
                array?.Invoke(Array!);
            }
            else if (IsObjectValue)
            {
                objectValue?.Invoke(ObjectValue!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Image,
                typeof(global::ElevenLabs.TemplateImageOutput),
                Video,
                typeof(global::ElevenLabs.TemplateVideoOutput),
                Audio,
                typeof(global::ElevenLabs.TemplateAudioOutput),
                String,
                typeof(global::ElevenLabs.TemplateStringOutput),
                Integer,
                typeof(global::ElevenLabs.TemplateIntegerOutput),
                Number,
                typeof(global::ElevenLabs.TemplateNumberOutput),
                Boolean,
                typeof(global::ElevenLabs.TemplateBooleanOutput),
                Array,
                typeof(global::ElevenLabs.TemplateArrayOutput),
                ObjectValue,
                typeof(global::ElevenLabs.TemplateObjectOutput),
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
        public bool Equals(TemplateOutput other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.TemplateImageOutput?>.Default.Equals(Image, other.Image) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.TemplateVideoOutput?>.Default.Equals(Video, other.Video) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.TemplateAudioOutput?>.Default.Equals(Audio, other.Audio) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.TemplateStringOutput?>.Default.Equals(String, other.String) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.TemplateIntegerOutput?>.Default.Equals(Integer, other.Integer) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.TemplateNumberOutput?>.Default.Equals(Number, other.Number) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.TemplateBooleanOutput?>.Default.Equals(Boolean, other.Boolean) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.TemplateArrayOutput?>.Default.Equals(Array, other.Array) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.TemplateObjectOutput?>.Default.Equals(ObjectValue, other.ObjectValue)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(TemplateOutput obj1, TemplateOutput obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<TemplateOutput>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(TemplateOutput obj1, TemplateOutput obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is TemplateOutput o && Equals(o);
        }
    }
}
