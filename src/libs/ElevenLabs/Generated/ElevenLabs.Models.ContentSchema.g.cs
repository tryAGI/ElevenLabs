#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct ContentSchema : global::System.IEquatable<ContentSchema>
    {
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ContentSchemaDiscriminatorType? Type { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.StringSchema? String { get; init; }
#else
        public global::ElevenLabs.StringSchema? String { get; }
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
            out global::ElevenLabs.StringSchema? value)
        {
            value = String;
            return IsString;
        }

        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.StringSchema PickString() => IsString
            ? String!
            : throw new global::System.InvalidOperationException($"Expected union variant 'String' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.NumberSchema? Number { get; init; }
#else
        public global::ElevenLabs.NumberSchema? Number { get; }
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
            out global::ElevenLabs.NumberSchema? value)
        {
            value = Number;
            return IsNumber;
        }

        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.NumberSchema PickNumber() => IsNumber
            ? Number!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Number' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.IntegerSchema? Integer { get; init; }
#else
        public global::ElevenLabs.IntegerSchema? Integer { get; }
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
            out global::ElevenLabs.IntegerSchema? value)
        {
            value = Integer;
            return IsInteger;
        }

        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.IntegerSchema PickInteger() => IsInteger
            ? Integer!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Integer' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.BooleanSchema? Boolean { get; init; }
#else
        public global::ElevenLabs.BooleanSchema? Boolean { get; }
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
            out global::ElevenLabs.BooleanSchema? value)
        {
            value = Boolean;
            return IsBoolean;
        }

        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.BooleanSchema PickBoolean() => IsBoolean
            ? Boolean!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Boolean' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.ImageSchema? Image { get; init; }
#else
        public global::ElevenLabs.ImageSchema? Image { get; }
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
            out global::ElevenLabs.ImageSchema? value)
        {
            value = Image;
            return IsImage;
        }

        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ImageSchema PickImage() => IsImage
            ? Image!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Image' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.VideoSchema? Video { get; init; }
#else
        public global::ElevenLabs.VideoSchema? Video { get; }
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
            out global::ElevenLabs.VideoSchema? value)
        {
            value = Video;
            return IsVideo;
        }

        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VideoSchema PickVideo() => IsVideo
            ? Video!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Video' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.AudioSchema? Audio { get; init; }
#else
        public global::ElevenLabs.AudioSchema? Audio { get; }
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
            out global::ElevenLabs.AudioSchema? value)
        {
            value = Audio;
            return IsAudio;
        }

        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.AudioSchema PickAudio() => IsAudio
            ? Audio!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Audio' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.VoiceSchema? Voice { get; init; }
#else
        public global::ElevenLabs.VoiceSchema? Voice { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Voice))]
#endif
        public bool IsVoice => Voice != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickVoice(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.VoiceSchema? value)
        {
            value = Voice;
            return IsVoice;
        }

        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.VoiceSchema PickVoice() => IsVoice
            ? Voice!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Voice' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.ObjectSchema? ObjectValue { get; init; }
#else
        public global::ElevenLabs.ObjectSchema? ObjectValue { get; }
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
            out global::ElevenLabs.ObjectSchema? value)
        {
            value = ObjectValue;
            return IsObjectValue;
        }

        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ObjectSchema PickObjectValue() => IsObjectValue
            ? ObjectValue!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ObjectValue' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.ArraySchema? Array { get; init; }
#else
        public global::ElevenLabs.ArraySchema? Array { get; }
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
            out global::ElevenLabs.ArraySchema? value)
        {
            value = Array;
            return IsArray;
        }

        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ArraySchema PickArray() => IsArray
            ? Array!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Array' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator ContentSchema(global::ElevenLabs.StringSchema value) => new ContentSchema((global::ElevenLabs.StringSchema?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::ElevenLabs.StringSchema?(ContentSchema @this) => @this.String;

        /// <summary>
        ///
        /// </summary>
        public ContentSchema(global::ElevenLabs.StringSchema? value)
        {
            String = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ContentSchema FromString(global::ElevenLabs.StringSchema? value) => new ContentSchema(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ContentSchema(global::ElevenLabs.NumberSchema value) => new ContentSchema((global::ElevenLabs.NumberSchema?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::ElevenLabs.NumberSchema?(ContentSchema @this) => @this.Number;

        /// <summary>
        ///
        /// </summary>
        public ContentSchema(global::ElevenLabs.NumberSchema? value)
        {
            Number = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ContentSchema FromNumber(global::ElevenLabs.NumberSchema? value) => new ContentSchema(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ContentSchema(global::ElevenLabs.IntegerSchema value) => new ContentSchema((global::ElevenLabs.IntegerSchema?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::ElevenLabs.IntegerSchema?(ContentSchema @this) => @this.Integer;

        /// <summary>
        ///
        /// </summary>
        public ContentSchema(global::ElevenLabs.IntegerSchema? value)
        {
            Integer = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ContentSchema FromInteger(global::ElevenLabs.IntegerSchema? value) => new ContentSchema(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ContentSchema(global::ElevenLabs.BooleanSchema value) => new ContentSchema((global::ElevenLabs.BooleanSchema?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::ElevenLabs.BooleanSchema?(ContentSchema @this) => @this.Boolean;

        /// <summary>
        ///
        /// </summary>
        public ContentSchema(global::ElevenLabs.BooleanSchema? value)
        {
            Boolean = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ContentSchema FromBoolean(global::ElevenLabs.BooleanSchema? value) => new ContentSchema(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ContentSchema(global::ElevenLabs.ImageSchema value) => new ContentSchema((global::ElevenLabs.ImageSchema?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::ElevenLabs.ImageSchema?(ContentSchema @this) => @this.Image;

        /// <summary>
        ///
        /// </summary>
        public ContentSchema(global::ElevenLabs.ImageSchema? value)
        {
            Image = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ContentSchema FromImage(global::ElevenLabs.ImageSchema? value) => new ContentSchema(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ContentSchema(global::ElevenLabs.VideoSchema value) => new ContentSchema((global::ElevenLabs.VideoSchema?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::ElevenLabs.VideoSchema?(ContentSchema @this) => @this.Video;

        /// <summary>
        ///
        /// </summary>
        public ContentSchema(global::ElevenLabs.VideoSchema? value)
        {
            Video = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ContentSchema FromVideo(global::ElevenLabs.VideoSchema? value) => new ContentSchema(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ContentSchema(global::ElevenLabs.AudioSchema value) => new ContentSchema((global::ElevenLabs.AudioSchema?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::ElevenLabs.AudioSchema?(ContentSchema @this) => @this.Audio;

        /// <summary>
        ///
        /// </summary>
        public ContentSchema(global::ElevenLabs.AudioSchema? value)
        {
            Audio = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ContentSchema FromAudio(global::ElevenLabs.AudioSchema? value) => new ContentSchema(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ContentSchema(global::ElevenLabs.VoiceSchema value) => new ContentSchema((global::ElevenLabs.VoiceSchema?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::ElevenLabs.VoiceSchema?(ContentSchema @this) => @this.Voice;

        /// <summary>
        ///
        /// </summary>
        public ContentSchema(global::ElevenLabs.VoiceSchema? value)
        {
            Voice = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ContentSchema FromVoice(global::ElevenLabs.VoiceSchema? value) => new ContentSchema(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ContentSchema(global::ElevenLabs.ObjectSchema value) => new ContentSchema((global::ElevenLabs.ObjectSchema?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::ElevenLabs.ObjectSchema?(ContentSchema @this) => @this.ObjectValue;

        /// <summary>
        ///
        /// </summary>
        public ContentSchema(global::ElevenLabs.ObjectSchema? value)
        {
            ObjectValue = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ContentSchema FromObjectValue(global::ElevenLabs.ObjectSchema? value) => new ContentSchema(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ContentSchema(global::ElevenLabs.ArraySchema value) => new ContentSchema((global::ElevenLabs.ArraySchema?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::ElevenLabs.ArraySchema?(ContentSchema @this) => @this.Array;

        /// <summary>
        ///
        /// </summary>
        public ContentSchema(global::ElevenLabs.ArraySchema? value)
        {
            Array = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ContentSchema FromArray(global::ElevenLabs.ArraySchema? value) => new ContentSchema(value);

        /// <summary>
        ///
        /// </summary>
        public ContentSchema(
            global::ElevenLabs.ContentSchemaDiscriminatorType? type,
            global::ElevenLabs.StringSchema? @string,
            global::ElevenLabs.NumberSchema? number,
            global::ElevenLabs.IntegerSchema? integer,
            global::ElevenLabs.BooleanSchema? boolean,
            global::ElevenLabs.ImageSchema? image,
            global::ElevenLabs.VideoSchema? video,
            global::ElevenLabs.AudioSchema? audio,
            global::ElevenLabs.VoiceSchema? voice,
            global::ElevenLabs.ObjectSchema? objectValue,
            global::ElevenLabs.ArraySchema? array
            )
        {
            Type = type;

            String = @string;
            Number = number;
            Integer = integer;
            Boolean = boolean;
            Image = image;
            Video = video;
            Audio = audio;
            Voice = voice;
            ObjectValue = objectValue;
            Array = array;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Array as object ??
            ObjectValue as object ??
            Voice as object ??
            Audio as object ??
            Video as object ??
            Image as object ??
            Boolean as object ??
            Integer as object ??
            Number as object ??
            String as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            String?.ToString() ??
            Number?.ToString() ??
            Integer?.ToString() ??
            Boolean?.ToString() ??
            Image?.ToString() ??
            Video?.ToString() ??
            Audio?.ToString() ??
            Voice?.ToString() ??
            ObjectValue?.ToString() ??
            Array?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsString && !IsNumber && !IsInteger && !IsBoolean && !IsImage && !IsVideo && !IsAudio && !IsVoice && !IsObjectValue && !IsArray || !IsString && IsNumber && !IsInteger && !IsBoolean && !IsImage && !IsVideo && !IsAudio && !IsVoice && !IsObjectValue && !IsArray || !IsString && !IsNumber && IsInteger && !IsBoolean && !IsImage && !IsVideo && !IsAudio && !IsVoice && !IsObjectValue && !IsArray || !IsString && !IsNumber && !IsInteger && IsBoolean && !IsImage && !IsVideo && !IsAudio && !IsVoice && !IsObjectValue && !IsArray || !IsString && !IsNumber && !IsInteger && !IsBoolean && IsImage && !IsVideo && !IsAudio && !IsVoice && !IsObjectValue && !IsArray || !IsString && !IsNumber && !IsInteger && !IsBoolean && !IsImage && IsVideo && !IsAudio && !IsVoice && !IsObjectValue && !IsArray || !IsString && !IsNumber && !IsInteger && !IsBoolean && !IsImage && !IsVideo && IsAudio && !IsVoice && !IsObjectValue && !IsArray || !IsString && !IsNumber && !IsInteger && !IsBoolean && !IsImage && !IsVideo && !IsAudio && IsVoice && !IsObjectValue && !IsArray || !IsString && !IsNumber && !IsInteger && !IsBoolean && !IsImage && !IsVideo && !IsAudio && !IsVoice && IsObjectValue && !IsArray || !IsString && !IsNumber && !IsInteger && !IsBoolean && !IsImage && !IsVideo && !IsAudio && !IsVoice && !IsObjectValue && IsArray;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::ElevenLabs.StringSchema, TResult>? @string = null,
            global::System.Func<global::ElevenLabs.NumberSchema, TResult>? number = null,
            global::System.Func<global::ElevenLabs.IntegerSchema, TResult>? integer = null,
            global::System.Func<global::ElevenLabs.BooleanSchema, TResult>? boolean = null,
            global::System.Func<global::ElevenLabs.ImageSchema, TResult>? image = null,
            global::System.Func<global::ElevenLabs.VideoSchema, TResult>? video = null,
            global::System.Func<global::ElevenLabs.AudioSchema, TResult>? audio = null,
            global::System.Func<global::ElevenLabs.VoiceSchema, TResult>? voice = null,
            global::System.Func<global::ElevenLabs.ObjectSchema, TResult>? objectValue = null,
            global::System.Func<global::ElevenLabs.ArraySchema, TResult>? array = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsString && @string != null)
            {
                return @string(String!);
            }
            else if (IsNumber && number != null)
            {
                return number(Number!);
            }
            else if (IsInteger && integer != null)
            {
                return integer(Integer!);
            }
            else if (IsBoolean && boolean != null)
            {
                return boolean(Boolean!);
            }
            else if (IsImage && image != null)
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
            else if (IsVoice && voice != null)
            {
                return voice(Voice!);
            }
            else if (IsObjectValue && objectValue != null)
            {
                return objectValue(ObjectValue!);
            }
            else if (IsArray && array != null)
            {
                return array(Array!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::ElevenLabs.StringSchema>? @string = null,

            global::System.Action<global::ElevenLabs.NumberSchema>? number = null,

            global::System.Action<global::ElevenLabs.IntegerSchema>? integer = null,

            global::System.Action<global::ElevenLabs.BooleanSchema>? boolean = null,

            global::System.Action<global::ElevenLabs.ImageSchema>? image = null,

            global::System.Action<global::ElevenLabs.VideoSchema>? video = null,

            global::System.Action<global::ElevenLabs.AudioSchema>? audio = null,

            global::System.Action<global::ElevenLabs.VoiceSchema>? voice = null,

            global::System.Action<global::ElevenLabs.ObjectSchema>? objectValue = null,

            global::System.Action<global::ElevenLabs.ArraySchema>? array = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsString)
            {
                @string?.Invoke(String!);
            }
            else if (IsNumber)
            {
                number?.Invoke(Number!);
            }
            else if (IsInteger)
            {
                integer?.Invoke(Integer!);
            }
            else if (IsBoolean)
            {
                boolean?.Invoke(Boolean!);
            }
            else if (IsImage)
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
            else if (IsVoice)
            {
                voice?.Invoke(Voice!);
            }
            else if (IsObjectValue)
            {
                objectValue?.Invoke(ObjectValue!);
            }
            else if (IsArray)
            {
                array?.Invoke(Array!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::ElevenLabs.StringSchema>? @string = null,
            global::System.Action<global::ElevenLabs.NumberSchema>? number = null,
            global::System.Action<global::ElevenLabs.IntegerSchema>? integer = null,
            global::System.Action<global::ElevenLabs.BooleanSchema>? boolean = null,
            global::System.Action<global::ElevenLabs.ImageSchema>? image = null,
            global::System.Action<global::ElevenLabs.VideoSchema>? video = null,
            global::System.Action<global::ElevenLabs.AudioSchema>? audio = null,
            global::System.Action<global::ElevenLabs.VoiceSchema>? voice = null,
            global::System.Action<global::ElevenLabs.ObjectSchema>? objectValue = null,
            global::System.Action<global::ElevenLabs.ArraySchema>? array = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsString)
            {
                @string?.Invoke(String!);
            }
            else if (IsNumber)
            {
                number?.Invoke(Number!);
            }
            else if (IsInteger)
            {
                integer?.Invoke(Integer!);
            }
            else if (IsBoolean)
            {
                boolean?.Invoke(Boolean!);
            }
            else if (IsImage)
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
            else if (IsVoice)
            {
                voice?.Invoke(Voice!);
            }
            else if (IsObjectValue)
            {
                objectValue?.Invoke(ObjectValue!);
            }
            else if (IsArray)
            {
                array?.Invoke(Array!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                String,
                typeof(global::ElevenLabs.StringSchema),
                Number,
                typeof(global::ElevenLabs.NumberSchema),
                Integer,
                typeof(global::ElevenLabs.IntegerSchema),
                Boolean,
                typeof(global::ElevenLabs.BooleanSchema),
                Image,
                typeof(global::ElevenLabs.ImageSchema),
                Video,
                typeof(global::ElevenLabs.VideoSchema),
                Audio,
                typeof(global::ElevenLabs.AudioSchema),
                Voice,
                typeof(global::ElevenLabs.VoiceSchema),
                ObjectValue,
                typeof(global::ElevenLabs.ObjectSchema),
                Array,
                typeof(global::ElevenLabs.ArraySchema),
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
        public bool Equals(ContentSchema other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.StringSchema?>.Default.Equals(String, other.String) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.NumberSchema?>.Default.Equals(Number, other.Number) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.IntegerSchema?>.Default.Equals(Integer, other.Integer) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.BooleanSchema?>.Default.Equals(Boolean, other.Boolean) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.ImageSchema?>.Default.Equals(Image, other.Image) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.VideoSchema?>.Default.Equals(Video, other.Video) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.AudioSchema?>.Default.Equals(Audio, other.Audio) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.VoiceSchema?>.Default.Equals(Voice, other.Voice) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.ObjectSchema?>.Default.Equals(ObjectValue, other.ObjectValue) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.ArraySchema?>.Default.Equals(Array, other.Array)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(ContentSchema obj1, ContentSchema obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ContentSchema>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ContentSchema obj1, ContentSchema obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ContentSchema o && Equals(o);
        }
    }
}
