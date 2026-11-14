#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace ElevenLabs
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct Config : global::System.IEquatable<Config>
    {
        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ExotelTransferInputConfigDiscriminatorType? Type { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.ExotelColdBlindTransferConfigInput? ExotelColdBlindTransfer { get; init; }
#else
        public global::ElevenLabs.ExotelColdBlindTransferConfigInput? ExotelColdBlindTransfer { get; }
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
            out global::ElevenLabs.ExotelColdBlindTransferConfigInput? value)
        {
            value = ExotelColdBlindTransfer;
            return IsExotelColdBlindTransfer;
        }

        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ExotelColdBlindTransferConfigInput PickExotelColdBlindTransfer() => ExotelColdBlindTransfer is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ExotelColdBlindTransfer' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.ExotelWarmTransferConfigInput? ExotelWarmTransfer { get; init; }
#else
        public global::ElevenLabs.ExotelWarmTransferConfigInput? ExotelWarmTransfer { get; }
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
            out global::ElevenLabs.ExotelWarmTransferConfigInput? value)
        {
            value = ExotelWarmTransfer;
            return IsExotelWarmTransfer;
        }

        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.ExotelWarmTransferConfigInput PickExotelWarmTransfer() => ExotelWarmTransfer is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ExotelWarmTransfer' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator Config(global::ElevenLabs.ExotelColdBlindTransferConfigInput value) => new Config((global::ElevenLabs.ExotelColdBlindTransferConfigInput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::ElevenLabs.ExotelColdBlindTransferConfigInput?(Config @this) => @this.ExotelColdBlindTransfer;

        /// <summary>
        ///
        /// </summary>
        public Config(global::ElevenLabs.ExotelColdBlindTransferConfigInput? value)
        {
            ExotelColdBlindTransfer = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Config FromExotelColdBlindTransfer(global::ElevenLabs.ExotelColdBlindTransferConfigInput? value) => new Config(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Config(global::ElevenLabs.ExotelWarmTransferConfigInput value) => new Config((global::ElevenLabs.ExotelWarmTransferConfigInput?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::ElevenLabs.ExotelWarmTransferConfigInput?(Config @this) => @this.ExotelWarmTransfer;

        /// <summary>
        ///
        /// </summary>
        public Config(global::ElevenLabs.ExotelWarmTransferConfigInput? value)
        {
            ExotelWarmTransfer = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Config FromExotelWarmTransfer(global::ElevenLabs.ExotelWarmTransferConfigInput? value) => new Config(value);

        /// <summary>
        ///
        /// </summary>
        public Config(
            global::ElevenLabs.ExotelTransferInputConfigDiscriminatorType? type,
            global::ElevenLabs.ExotelColdBlindTransferConfigInput? exotelColdBlindTransfer,
            global::ElevenLabs.ExotelWarmTransferConfigInput? exotelWarmTransfer
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
            global::System.Func<global::ElevenLabs.ExotelColdBlindTransferConfigInput, TResult>? exotelColdBlindTransfer = null,
            global::System.Func<global::ElevenLabs.ExotelWarmTransferConfigInput, TResult>? exotelWarmTransfer = null,
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
            global::System.Action<global::ElevenLabs.ExotelColdBlindTransferConfigInput>? exotelColdBlindTransfer = null,

            global::System.Action<global::ElevenLabs.ExotelWarmTransferConfigInput>? exotelWarmTransfer = null,
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
            global::System.Action<global::ElevenLabs.ExotelColdBlindTransferConfigInput>? exotelColdBlindTransfer = null,
            global::System.Action<global::ElevenLabs.ExotelWarmTransferConfigInput>? exotelWarmTransfer = null,
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
                typeof(global::ElevenLabs.ExotelColdBlindTransferConfigInput),
                ExotelWarmTransfer,
                typeof(global::ElevenLabs.ExotelWarmTransferConfigInput),
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
        public bool Equals(Config other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.ExotelColdBlindTransferConfigInput?>.Default.Equals(ExotelColdBlindTransfer, other.ExotelColdBlindTransfer) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.ExotelWarmTransferConfigInput?>.Default.Equals(ExotelWarmTransfer, other.ExotelWarmTransfer)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(Config obj1, Config obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Config>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(Config obj1, Config obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Config o && Equals(o);
        }
    }
}
