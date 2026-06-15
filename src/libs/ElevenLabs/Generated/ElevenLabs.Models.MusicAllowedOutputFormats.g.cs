#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct MusicAllowedOutputFormats : global::System.IEquatable<MusicAllowedOutputFormats>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.AllowedOutputFormats? AllowedOutputFormats { get; init; }
#else
        public global::ElevenLabs.AllowedOutputFormats? AllowedOutputFormats { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AllowedOutputFormats))]
#endif
        public bool IsAllowedOutputFormats => AllowedOutputFormats != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickAllowedOutputFormats(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.AllowedOutputFormats? value)
        {
            value = AllowedOutputFormats;
            return IsAllowedOutputFormats;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::ElevenLabs.AllowedOutputFormats PickAllowedOutputFormats() => IsAllowedOutputFormats
            ? AllowedOutputFormats!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'AllowedOutputFormats' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.MusicOnlyOutputFormats? Only { get; init; }
#else
        public global::ElevenLabs.MusicOnlyOutputFormats? Only { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Only))]
#endif
        public bool IsOnly => Only != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickOnly(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.MusicOnlyOutputFormats? value)
        {
            value = Only;
            return IsOnly;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::ElevenLabs.MusicOnlyOutputFormats PickOnly() => IsOnly
            ? Only!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Only' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MusicAllowedOutputFormats(global::ElevenLabs.AllowedOutputFormats value) => new MusicAllowedOutputFormats((global::ElevenLabs.AllowedOutputFormats?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.AllowedOutputFormats?(MusicAllowedOutputFormats @this) => @this.AllowedOutputFormats;

        /// <summary>
        /// 
        /// </summary>
        public MusicAllowedOutputFormats(global::ElevenLabs.AllowedOutputFormats? value)
        {
            AllowedOutputFormats = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static MusicAllowedOutputFormats FromAllowedOutputFormats(global::ElevenLabs.AllowedOutputFormats? value) => new MusicAllowedOutputFormats(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MusicAllowedOutputFormats(global::ElevenLabs.MusicOnlyOutputFormats value) => new MusicAllowedOutputFormats((global::ElevenLabs.MusicOnlyOutputFormats?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.MusicOnlyOutputFormats?(MusicAllowedOutputFormats @this) => @this.Only;

        /// <summary>
        /// 
        /// </summary>
        public MusicAllowedOutputFormats(global::ElevenLabs.MusicOnlyOutputFormats? value)
        {
            Only = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static MusicAllowedOutputFormats FromOnly(global::ElevenLabs.MusicOnlyOutputFormats? value) => new MusicAllowedOutputFormats(value);

        /// <summary>
        /// 
        /// </summary>
        public MusicAllowedOutputFormats(
            global::ElevenLabs.AllowedOutputFormats? allowedOutputFormats,
            global::ElevenLabs.MusicOnlyOutputFormats? only
            )
        {
            AllowedOutputFormats = allowedOutputFormats;
            Only = only;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Only as object ??
            AllowedOutputFormats as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            AllowedOutputFormats?.ToValueString() ??
            Only?.ToValueString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsAllowedOutputFormats || IsOnly;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::ElevenLabs.AllowedOutputFormats?, TResult>? allowedOutputFormats = null,
            global::System.Func<global::ElevenLabs.MusicOnlyOutputFormats?, TResult>? only = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAllowedOutputFormats && allowedOutputFormats != null)
            {
                return allowedOutputFormats(AllowedOutputFormats!);
            }
            else if (IsOnly && only != null)
            {
                return only(Only!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::ElevenLabs.AllowedOutputFormats?>? allowedOutputFormats = null,

            global::System.Action<global::ElevenLabs.MusicOnlyOutputFormats?>? only = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAllowedOutputFormats)
            {
                allowedOutputFormats?.Invoke(AllowedOutputFormats!);
            }
            else if (IsOnly)
            {
                only?.Invoke(Only!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::ElevenLabs.AllowedOutputFormats?>? allowedOutputFormats = null,
            global::System.Action<global::ElevenLabs.MusicOnlyOutputFormats?>? only = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAllowedOutputFormats)
            {
                allowedOutputFormats?.Invoke(AllowedOutputFormats!);
            }
            else if (IsOnly)
            {
                only?.Invoke(Only!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                AllowedOutputFormats,
                typeof(global::ElevenLabs.AllowedOutputFormats),
                Only,
                typeof(global::ElevenLabs.MusicOnlyOutputFormats),
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
        public bool Equals(MusicAllowedOutputFormats other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.AllowedOutputFormats?>.Default.Equals(AllowedOutputFormats, other.AllowedOutputFormats) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.MusicOnlyOutputFormats?>.Default.Equals(Only, other.Only) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(MusicAllowedOutputFormats obj1, MusicAllowedOutputFormats obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<MusicAllowedOutputFormats>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(MusicAllowedOutputFormats obj1, MusicAllowedOutputFormats obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is MusicAllowedOutputFormats o && Equals(o);
        }
    }
}
