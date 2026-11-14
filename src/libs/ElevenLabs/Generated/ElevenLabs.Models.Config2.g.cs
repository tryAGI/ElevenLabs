#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct Config2 : global::System.IEquatable<Config2>
    {
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ExotelTransferOutputConfigDiscriminatorType? Type { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.ExotelColdBlindTransferConfigOutput? ExotelColdBlindTransfer { get; init; }
#else
        public global::ElevenLabs.ExotelColdBlindTransferConfigOutput? ExotelColdBlindTransfer { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ExotelColdBlindTransfer))]
#endif
        public bool IsExotelColdBlindTransfer => ExotelColdBlindTransfer != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickExotelColdBlindTransfer(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.ExotelColdBlindTransferConfigOutput? value)
        {
            value = ExotelColdBlindTransfer;
            return IsExotelColdBlindTransfer;
        }

        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ExotelColdBlindTransferConfigOutput PickExotelColdBlindTransfer() => ExotelColdBlindTransfer is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ExotelColdBlindTransfer' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.ExotelWarmTransferConfigOutput? ExotelWarmTransfer { get; init; }
#else
        public global::ElevenLabs.ExotelWarmTransferConfigOutput? ExotelWarmTransfer { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ExotelWarmTransfer))]
#endif
        public bool IsExotelWarmTransfer => ExotelWarmTransfer != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickExotelWarmTransfer(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.ExotelWarmTransferConfigOutput? value)
        {
            value = ExotelWarmTransfer;
            return IsExotelWarmTransfer;
        }

        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ExotelWarmTransferConfigOutput PickExotelWarmTransfer() => ExotelWarmTransfer is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ExotelWarmTransfer' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator Config2(global::ElevenLabs.ExotelColdBlindTransferConfigOutput value) => new Config2((global::ElevenLabs.ExotelColdBlindTransferConfigOutput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::ElevenLabs.ExotelColdBlindTransferConfigOutput?(Config2 @this) => @this.ExotelColdBlindTransfer;

        /// <summary>
        ///
        /// </summary>
        public Config2(global::ElevenLabs.ExotelColdBlindTransferConfigOutput? value)
        {
            ExotelColdBlindTransfer = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Config2 FromExotelColdBlindTransfer(global::ElevenLabs.ExotelColdBlindTransferConfigOutput? value) => new Config2(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Config2(global::ElevenLabs.ExotelWarmTransferConfigOutput value) => new Config2((global::ElevenLabs.ExotelWarmTransferConfigOutput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::ElevenLabs.ExotelWarmTransferConfigOutput?(Config2 @this) => @this.ExotelWarmTransfer;

        /// <summary>
        ///
        /// </summary>
        public Config2(global::ElevenLabs.ExotelWarmTransferConfigOutput? value)
        {
            ExotelWarmTransfer = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Config2 FromExotelWarmTransfer(global::ElevenLabs.ExotelWarmTransferConfigOutput? value) => new Config2(value);

        /// <summary>
        ///
        /// </summary>
        public Config2(
            global::ElevenLabs.ExotelTransferOutputConfigDiscriminatorType? type,
            global::ElevenLabs.ExotelColdBlindTransferConfigOutput? exotelColdBlindTransfer,
            global::ElevenLabs.ExotelWarmTransferConfigOutput? exotelWarmTransfer
            )
        {
            Type = type;

            ExotelColdBlindTransfer = exotelColdBlindTransfer;
            ExotelWarmTransfer = exotelWarmTransfer;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            ExotelWarmTransfer as object ??
            ExotelColdBlindTransfer as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            ExotelColdBlindTransfer?.ToString() ??
            ExotelWarmTransfer?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsExotelColdBlindTransfer && !IsExotelWarmTransfer || !IsExotelColdBlindTransfer && IsExotelWarmTransfer;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::ElevenLabs.ExotelColdBlindTransferConfigOutput, TResult>? exotelColdBlindTransfer = null,
            global::System.Func<global::ElevenLabs.ExotelWarmTransferConfigOutput, TResult>? exotelWarmTransfer = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (ExotelColdBlindTransfer is { } __value0 && exotelColdBlindTransfer != null)
            {
                return exotelColdBlindTransfer(__value0);
            }
            else if (ExotelWarmTransfer is { } __value1 && exotelWarmTransfer != null)
            {
                return exotelWarmTransfer(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::ElevenLabs.ExotelColdBlindTransferConfigOutput>? exotelColdBlindTransfer = null,

            global::System.Action<global::ElevenLabs.ExotelWarmTransferConfigOutput>? exotelWarmTransfer = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (ExotelColdBlindTransfer is { } __value0)
            {
                exotelColdBlindTransfer?.Invoke(__value0);
            }
            else if (ExotelWarmTransfer is { } __value1)
            {
                exotelWarmTransfer?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::ElevenLabs.ExotelColdBlindTransferConfigOutput>? exotelColdBlindTransfer = null,
            global::System.Action<global::ElevenLabs.ExotelWarmTransferConfigOutput>? exotelWarmTransfer = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (ExotelColdBlindTransfer is { } __value0)
            {
                exotelColdBlindTransfer?.Invoke(__value0);
            }
            else if (ExotelWarmTransfer is { } __value1)
            {
                exotelWarmTransfer?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ExotelColdBlindTransfer,
                typeof(global::ElevenLabs.ExotelColdBlindTransferConfigOutput),
                ExotelWarmTransfer,
                typeof(global::ElevenLabs.ExotelWarmTransferConfigOutput),
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
        public bool Equals(Config2 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.ExotelColdBlindTransferConfigOutput?>.Default.Equals(ExotelColdBlindTransfer, other.ExotelColdBlindTransfer) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.ExotelWarmTransferConfigOutput?>.Default.Equals(ExotelWarmTransfer, other.ExotelWarmTransfer)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(Config2 obj1, Config2 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Config2>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(Config2 obj1, Config2 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Config2 o && Equals(o);
        }
    }
}
