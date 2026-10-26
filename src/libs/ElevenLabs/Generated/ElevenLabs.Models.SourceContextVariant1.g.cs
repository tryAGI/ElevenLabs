#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct SourceContextVariant1 : global::System.IEquatable<SourceContextVariant1>
    {
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ProjectExternalAudioResponseModelSourceContextVariant1DiscriminatorSourceType? SourceType { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.SongSourceContext? Song { get; init; }
#else
        public global::ElevenLabs.SongSourceContext? Song { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Song))]
#endif
        public bool IsSong => Song != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSong(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.SongSourceContext? value)
        {
            value = Song;
            return IsSong;
        }

        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SongSourceContext PickSong() => Song is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Song' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.MusicExploreSongSourceContext? MusicExploreSong { get; init; }
#else
        public global::ElevenLabs.MusicExploreSongSourceContext? MusicExploreSong { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MusicExploreSong))]
#endif
        public bool IsMusicExploreSong => MusicExploreSong != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickMusicExploreSong(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.MusicExploreSongSourceContext? value)
        {
            value = MusicExploreSong;
            return IsMusicExploreSong;
        }

        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.MusicExploreSongSourceContext PickMusicExploreSong() => MusicExploreSong is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'MusicExploreSong' but the value was {ToString()}.");

        /// <summary>
        /// Context for sound effect clips.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.SfxSourceContext? Sfx { get; init; }
#else
        public global::ElevenLabs.SfxSourceContext? Sfx { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Sfx))]
#endif
        public bool IsSfx => Sfx != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSfx(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.SfxSourceContext? value)
        {
            value = Sfx;
            return IsSfx;
        }

        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.SfxSourceContext PickSfx() => Sfx is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Sfx' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator SourceContextVariant1(global::ElevenLabs.SongSourceContext value) => new SourceContextVariant1((global::ElevenLabs.SongSourceContext?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::ElevenLabs.SongSourceContext?(SourceContextVariant1 @this) => @this.Song;

        /// <summary>
        ///
        /// </summary>
        public SourceContextVariant1(global::ElevenLabs.SongSourceContext? value)
        {
            Song = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static SourceContextVariant1 FromSong(global::ElevenLabs.SongSourceContext? value) => new SourceContextVariant1(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator SourceContextVariant1(global::ElevenLabs.MusicExploreSongSourceContext value) => new SourceContextVariant1((global::ElevenLabs.MusicExploreSongSourceContext?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::ElevenLabs.MusicExploreSongSourceContext?(SourceContextVariant1 @this) => @this.MusicExploreSong;

        /// <summary>
        ///
        /// </summary>
        public SourceContextVariant1(global::ElevenLabs.MusicExploreSongSourceContext? value)
        {
            MusicExploreSong = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static SourceContextVariant1 FromMusicExploreSong(global::ElevenLabs.MusicExploreSongSourceContext? value) => new SourceContextVariant1(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator SourceContextVariant1(global::ElevenLabs.SfxSourceContext value) => new SourceContextVariant1((global::ElevenLabs.SfxSourceContext?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::ElevenLabs.SfxSourceContext?(SourceContextVariant1 @this) => @this.Sfx;

        /// <summary>
        ///
        /// </summary>
        public SourceContextVariant1(global::ElevenLabs.SfxSourceContext? value)
        {
            Sfx = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static SourceContextVariant1 FromSfx(global::ElevenLabs.SfxSourceContext? value) => new SourceContextVariant1(value);

        /// <summary>
        ///
        /// </summary>
        public SourceContextVariant1(
            global::ElevenLabs.ProjectExternalAudioResponseModelSourceContextVariant1DiscriminatorSourceType? sourceType,
            global::ElevenLabs.SongSourceContext? song,
            global::ElevenLabs.MusicExploreSongSourceContext? musicExploreSong,
            global::ElevenLabs.SfxSourceContext? sfx
            )
        {
            SourceType = sourceType;

            Song = song;
            MusicExploreSong = musicExploreSong;
            Sfx = sfx;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Sfx as object ??
            MusicExploreSong as object ??
            Song as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Song?.ToString() ??
            MusicExploreSong?.ToString() ??
            Sfx?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsSong && !IsMusicExploreSong && !IsSfx || !IsSong && IsMusicExploreSong && !IsSfx || !IsSong && !IsMusicExploreSong && IsSfx;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::ElevenLabs.SongSourceContext, TResult>? song = null,
            global::System.Func<global::ElevenLabs.MusicExploreSongSourceContext, TResult>? musicExploreSong = null,
            global::System.Func<global::ElevenLabs.SfxSourceContext, TResult>? sfx = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Song is { } __value0 && song != null)
            {
                return song(__value0);
            }
            else if (MusicExploreSong is { } __value1 && musicExploreSong != null)
            {
                return musicExploreSong(__value1);
            }
            else if (Sfx is { } __value2 && sfx != null)
            {
                return sfx(__value2);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::ElevenLabs.SongSourceContext>? song = null,

            global::System.Action<global::ElevenLabs.MusicExploreSongSourceContext>? musicExploreSong = null,

            global::System.Action<global::ElevenLabs.SfxSourceContext>? sfx = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Song is { } __value0)
            {
                song?.Invoke(__value0);
            }
            else if (MusicExploreSong is { } __value1)
            {
                musicExploreSong?.Invoke(__value1);
            }
            else if (Sfx is { } __value2)
            {
                sfx?.Invoke(__value2);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::ElevenLabs.SongSourceContext>? song = null,
            global::System.Action<global::ElevenLabs.MusicExploreSongSourceContext>? musicExploreSong = null,
            global::System.Action<global::ElevenLabs.SfxSourceContext>? sfx = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Song is { } __value0)
            {
                song?.Invoke(__value0);
            }
            else if (MusicExploreSong is { } __value1)
            {
                musicExploreSong?.Invoke(__value1);
            }
            else if (Sfx is { } __value2)
            {
                sfx?.Invoke(__value2);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Song,
                typeof(global::ElevenLabs.SongSourceContext),
                MusicExploreSong,
                typeof(global::ElevenLabs.MusicExploreSongSourceContext),
                Sfx,
                typeof(global::ElevenLabs.SfxSourceContext),
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
        public bool Equals(SourceContextVariant1 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.SongSourceContext?>.Default.Equals(Song, other.Song) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.MusicExploreSongSourceContext?>.Default.Equals(MusicExploreSong, other.MusicExploreSong) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.SfxSourceContext?>.Default.Equals(Sfx, other.Sfx)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(SourceContextVariant1 obj1, SourceContextVariant1 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<SourceContextVariant1>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(SourceContextVariant1 obj1, SourceContextVariant1 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is SourceContextVariant1 o && Equals(o);
        }
    }
}
