#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Configuration for backup LLM cascading. Can be disabled, use system defaults, or specify custom order.
    /// </summary>
    public readonly partial struct BackupLlmConfig2 : global::System.IEquatable<BackupLlmConfig2>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::ElevenLabs.PromptAgentAPIModelOutputBackupLlmConfigDiscriminatorPreference? Preference { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.BackupLLMDefault? Default { get; init; }
#else
        public global::ElevenLabs.BackupLLMDefault? Default { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Default))]
#endif
        public bool IsDefault => Default != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.BackupLLMDisabled? Disabled { get; init; }
#else
        public global::ElevenLabs.BackupLLMDisabled? Disabled { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Disabled))]
#endif
        public bool IsDisabled => Disabled != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.BackupLLMOverride? Override { get; init; }
#else
        public global::ElevenLabs.BackupLLMOverride? Override { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Override))]
#endif
        public bool IsOverride => Override != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BackupLlmConfig2(global::ElevenLabs.BackupLLMDefault value) => new BackupLlmConfig2((global::ElevenLabs.BackupLLMDefault?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.BackupLLMDefault?(BackupLlmConfig2 @this) => @this.Default;

        /// <summary>
        /// 
        /// </summary>
        public BackupLlmConfig2(global::ElevenLabs.BackupLLMDefault? value)
        {
            Default = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BackupLlmConfig2(global::ElevenLabs.BackupLLMDisabled value) => new BackupLlmConfig2((global::ElevenLabs.BackupLLMDisabled?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.BackupLLMDisabled?(BackupLlmConfig2 @this) => @this.Disabled;

        /// <summary>
        /// 
        /// </summary>
        public BackupLlmConfig2(global::ElevenLabs.BackupLLMDisabled? value)
        {
            Disabled = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BackupLlmConfig2(global::ElevenLabs.BackupLLMOverride value) => new BackupLlmConfig2((global::ElevenLabs.BackupLLMOverride?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.BackupLLMOverride?(BackupLlmConfig2 @this) => @this.Override;

        /// <summary>
        /// 
        /// </summary>
        public BackupLlmConfig2(global::ElevenLabs.BackupLLMOverride? value)
        {
            Override = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public BackupLlmConfig2(
            global::ElevenLabs.PromptAgentAPIModelOutputBackupLlmConfigDiscriminatorPreference? preference,
            global::ElevenLabs.BackupLLMDefault? @default,
            global::ElevenLabs.BackupLLMDisabled? disabled,
            global::ElevenLabs.BackupLLMOverride? @override
            )
        {
            Preference = preference;

            Default = @default;
            Disabled = disabled;
            Override = @override;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Override as object ??
            Disabled as object ??
            Default as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Default?.ToString() ??
            Disabled?.ToString() ??
            Override?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsDefault && !IsDisabled && !IsOverride || !IsDefault && IsDisabled && !IsOverride || !IsDefault && !IsDisabled && IsOverride;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::ElevenLabs.BackupLLMDefault?, TResult>? @default = null,
            global::System.Func<global::ElevenLabs.BackupLLMDisabled?, TResult>? disabled = null,
            global::System.Func<global::ElevenLabs.BackupLLMOverride?, TResult>? @override = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsDefault && @default != null)
            {
                return @default(Default!);
            }
            else if (IsDisabled && disabled != null)
            {
                return disabled(Disabled!);
            }
            else if (IsOverride && @override != null)
            {
                return @override(Override!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::ElevenLabs.BackupLLMDefault?>? @default = null,
            global::System.Action<global::ElevenLabs.BackupLLMDisabled?>? disabled = null,
            global::System.Action<global::ElevenLabs.BackupLLMOverride?>? @override = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsDefault)
            {
                @default?.Invoke(Default!);
            }
            else if (IsDisabled)
            {
                disabled?.Invoke(Disabled!);
            }
            else if (IsOverride)
            {
                @override?.Invoke(Override!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Default,
                typeof(global::ElevenLabs.BackupLLMDefault),
                Disabled,
                typeof(global::ElevenLabs.BackupLLMDisabled),
                Override,
                typeof(global::ElevenLabs.BackupLLMOverride),
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
        public bool Equals(BackupLlmConfig2 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.BackupLLMDefault?>.Default.Equals(Default, other.Default) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.BackupLLMDisabled?>.Default.Equals(Disabled, other.Disabled) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.BackupLLMOverride?>.Default.Equals(Override, other.Override) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(BackupLlmConfig2 obj1, BackupLlmConfig2 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BackupLlmConfig2>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(BackupLlmConfig2 obj1, BackupLlmConfig2 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BackupLlmConfig2 o && Equals(o);
        }
    }
}
