#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct MusicOutputFormat : global::System.IEquatable<MusicOutputFormat>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.MusicAllowedOutputFormats? AllowedFormats { get; init; }
#else
        public global::ElevenLabs.MusicAllowedOutputFormats? AllowedFormats { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AllowedFormats))]
#endif
        public bool IsAllowedFormats => AllowedFormats != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickAllowedFormats(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.MusicAllowedOutputFormats? value)
        {
            value = AllowedFormats;
            return IsAllowedFormats;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::ElevenLabs.MusicAllowedOutputFormats PickAllowedFormats() => IsAllowedFormats
            ? AllowedFormats!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'AllowedFormats' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public string? MusicOutputFormatVariant2 { get; init; }
#else
        public string? MusicOutputFormatVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MusicOutputFormatVariant2))]
#endif
        public bool IsMusicOutputFormatVariant2 => MusicOutputFormatVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickMusicOutputFormatVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out string? value)
        {
            value = MusicOutputFormatVariant2;
            return IsMusicOutputFormatVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public string PickMusicOutputFormatVariant2() => IsMusicOutputFormatVariant2
            ? MusicOutputFormatVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'MusicOutputFormatVariant2' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MusicOutputFormat(global::ElevenLabs.MusicAllowedOutputFormats value) => new MusicOutputFormat((global::ElevenLabs.MusicAllowedOutputFormats?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.MusicAllowedOutputFormats?(MusicOutputFormat @this) => @this.AllowedFormats;

        /// <summary>
        /// 
        /// </summary>
        public MusicOutputFormat(global::ElevenLabs.MusicAllowedOutputFormats? value)
        {
            AllowedFormats = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static MusicOutputFormat FromAllowedFormats(global::ElevenLabs.MusicAllowedOutputFormats? value) => new MusicOutputFormat(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MusicOutputFormat(string value) => new MusicOutputFormat((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(MusicOutputFormat @this) => @this.MusicOutputFormatVariant2;

        /// <summary>
        /// 
        /// </summary>
        public MusicOutputFormat(string? value)
        {
            MusicOutputFormatVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static MusicOutputFormat FromMusicOutputFormatVariant2(string? value) => new MusicOutputFormat(value);

        /// <summary>
        /// 
        /// </summary>
        public MusicOutputFormat(
            global::ElevenLabs.MusicAllowedOutputFormats? allowedFormats,
            string? musicOutputFormatVariant2
            )
        {
            AllowedFormats = allowedFormats;
            MusicOutputFormatVariant2 = musicOutputFormatVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            MusicOutputFormatVariant2 as object ??
            AllowedFormats as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            AllowedFormats?.ToString() ??
            MusicOutputFormatVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsAllowedFormats || IsMusicOutputFormatVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::ElevenLabs.MusicAllowedOutputFormats?, TResult>? allowedFormats = null,
            global::System.Func<string, TResult>? musicOutputFormatVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAllowedFormats && allowedFormats != null)
            {
                return allowedFormats(AllowedFormats!);
            }
            else if (IsMusicOutputFormatVariant2 && musicOutputFormatVariant2 != null)
            {
                return musicOutputFormatVariant2(MusicOutputFormatVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::ElevenLabs.MusicAllowedOutputFormats?>? allowedFormats = null,

            global::System.Action<string>? musicOutputFormatVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAllowedFormats)
            {
                allowedFormats?.Invoke(AllowedFormats!);
            }
            else if (IsMusicOutputFormatVariant2)
            {
                musicOutputFormatVariant2?.Invoke(MusicOutputFormatVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::ElevenLabs.MusicAllowedOutputFormats?>? allowedFormats = null,
            global::System.Action<string>? musicOutputFormatVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAllowedFormats)
            {
                allowedFormats?.Invoke(AllowedFormats!);
            }
            else if (IsMusicOutputFormatVariant2)
            {
                musicOutputFormatVariant2?.Invoke(MusicOutputFormatVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                AllowedFormats,
                typeof(global::ElevenLabs.MusicAllowedOutputFormats),
                MusicOutputFormatVariant2,
                typeof(string),
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
        public bool Equals(MusicOutputFormat other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.MusicAllowedOutputFormats?>.Default.Equals(AllowedFormats, other.AllowedFormats) &&
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(MusicOutputFormatVariant2, other.MusicOutputFormatVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(MusicOutputFormat obj1, MusicOutputFormat obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<MusicOutputFormat>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(MusicOutputFormat obj1, MusicOutputFormat obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is MusicOutputFormat o && Equals(o);
        }
    }
}
