#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// One value bound to a template input port, in the form its `content_schema`<br/>
    /// calls for. A `string` port takes the text itself; `number`, `integer` and<br/>
    /// `boolean` ports take a JSON value of that type. Anything stored elsewhere is<br/>
    /// a reference discriminated on `type`: a prior `generation`, an uploaded<br/>
    /// `asset`, a `voice`, or media passed `inline_base64`. An `array` port takes a<br/>
    /// JSON array with one value per element, admissible for the schema's `items`.<br/>
    /// `object` ports cannot be bound through this API yet.<br/>
    /// No constraints beyond the wire shape live here: what a port accepts (an<br/>
    /// `enum`, a length) is stated by its `content_schema`, and the run path<br/>
    /// validates against that same schema.
    /// </summary>
    public readonly partial struct TemplateRunInput : global::System.IEquatable<TemplateRunInput>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public string? TemplateRunInputVariant1 { get; init; }
#else
        public string? TemplateRunInputVariant1 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TemplateRunInputVariant1))]
#endif
        public bool IsTemplateRunInputVariant1 => TemplateRunInputVariant1 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickTemplateRunInputVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out string? value)
        {
            value = TemplateRunInputVariant1;
            return IsTemplateRunInputVariant1;
        }

        /// <summary>
        ///
        /// </summary>
        public string PickTemplateRunInputVariant1() => IsTemplateRunInputVariant1
            ? TemplateRunInputVariant1!
            : throw new global::System.InvalidOperationException($"Expected union variant 'TemplateRunInputVariant1' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public bool? TemplateRunInputVariant2 { get; init; }
#else
        public bool? TemplateRunInputVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TemplateRunInputVariant2))]
#endif
        public bool IsTemplateRunInputVariant2 => TemplateRunInputVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickTemplateRunInputVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out bool? value)
        {
            value = TemplateRunInputVariant2;
            return IsTemplateRunInputVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public bool PickTemplateRunInputVariant2() => IsTemplateRunInputVariant2
            ? TemplateRunInputVariant2!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'TemplateRunInputVariant2' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public int? TemplateRunInputVariant3 { get; init; }
#else
        public int? TemplateRunInputVariant3 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TemplateRunInputVariant3))]
#endif
        public bool IsTemplateRunInputVariant3 => TemplateRunInputVariant3 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickTemplateRunInputVariant3(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out int? value)
        {
            value = TemplateRunInputVariant3;
            return IsTemplateRunInputVariant3;
        }

        /// <summary>
        ///
        /// </summary>
        public int PickTemplateRunInputVariant3() => IsTemplateRunInputVariant3
            ? TemplateRunInputVariant3!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'TemplateRunInputVariant3' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public double? TemplateRunInputVariant4 { get; init; }
#else
        public double? TemplateRunInputVariant4 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TemplateRunInputVariant4))]
#endif
        public bool IsTemplateRunInputVariant4 => TemplateRunInputVariant4 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickTemplateRunInputVariant4(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out double? value)
        {
            value = TemplateRunInputVariant4;
            return IsTemplateRunInputVariant4;
        }

        /// <summary>
        ///
        /// </summary>
        public double PickTemplateRunInputVariant4() => IsTemplateRunInputVariant4
            ? TemplateRunInputVariant4!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'TemplateRunInputVariant4' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.TemplateInputReference? Reference { get; init; }
#else
        public global::ElevenLabs.TemplateInputReference? Reference { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Reference))]
#endif
        public bool IsReference => Reference != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickReference(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.TemplateInputReference? value)
        {
            value = Reference;
            return IsReference;
        }

        /// <summary>
        ///
        /// </summary>
        public global::ElevenLabs.TemplateInputReference PickReference() => IsReference
            ? Reference!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Reference' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<global::ElevenLabs.TemplateRunInput>? TemplateRunInputVariant6 { get; init; }
#else
        public global::System.Collections.Generic.IList<global::ElevenLabs.TemplateRunInput>? TemplateRunInputVariant6 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TemplateRunInputVariant6))]
#endif
        public bool IsTemplateRunInputVariant6 => TemplateRunInputVariant6 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickTemplateRunInputVariant6(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::System.Collections.Generic.IList<global::ElevenLabs.TemplateRunInput>? value)
        {
            value = TemplateRunInputVariant6;
            return IsTemplateRunInputVariant6;
        }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::ElevenLabs.TemplateRunInput> PickTemplateRunInputVariant6() => IsTemplateRunInputVariant6
            ? TemplateRunInputVariant6!
            : throw new global::System.InvalidOperationException($"Expected union variant 'TemplateRunInputVariant6' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator TemplateRunInput(string value) => new TemplateRunInput((string?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator string?(TemplateRunInput @this) => @this.TemplateRunInputVariant1;

        /// <summary>
        ///
        /// </summary>
        public TemplateRunInput(string? value)
        {
            TemplateRunInputVariant1 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static TemplateRunInput FromTemplateRunInputVariant1(string? value) => new TemplateRunInput(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator TemplateRunInput(bool value) => new TemplateRunInput((bool?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator bool?(TemplateRunInput @this) => @this.TemplateRunInputVariant2;

        /// <summary>
        ///
        /// </summary>
        public TemplateRunInput(bool? value)
        {
            TemplateRunInputVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static TemplateRunInput FromTemplateRunInputVariant2(bool? value) => new TemplateRunInput(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator TemplateRunInput(int value) => new TemplateRunInput((int?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator int?(TemplateRunInput @this) => @this.TemplateRunInputVariant3;

        /// <summary>
        ///
        /// </summary>
        public TemplateRunInput(int? value)
        {
            TemplateRunInputVariant3 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static TemplateRunInput FromTemplateRunInputVariant3(int? value) => new TemplateRunInput(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator TemplateRunInput(double value) => new TemplateRunInput((double?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator double?(TemplateRunInput @this) => @this.TemplateRunInputVariant4;

        /// <summary>
        ///
        /// </summary>
        public TemplateRunInput(double? value)
        {
            TemplateRunInputVariant4 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static TemplateRunInput FromTemplateRunInputVariant4(double? value) => new TemplateRunInput(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator TemplateRunInput(global::ElevenLabs.TemplateInputReference value) => new TemplateRunInput((global::ElevenLabs.TemplateInputReference?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::ElevenLabs.TemplateInputReference?(TemplateRunInput @this) => @this.Reference;

        /// <summary>
        ///
        /// </summary>
        public TemplateRunInput(global::ElevenLabs.TemplateInputReference? value)
        {
            Reference = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static TemplateRunInput FromReference(global::ElevenLabs.TemplateInputReference? value) => new TemplateRunInput(value);

        /// <summary>
        ///
        /// </summary>
        public TemplateRunInput(
            string? templateRunInputVariant1,
            bool? templateRunInputVariant2,
            int? templateRunInputVariant3,
            double? templateRunInputVariant4,
            global::ElevenLabs.TemplateInputReference? reference,
            global::System.Collections.Generic.IList<global::ElevenLabs.TemplateRunInput>? templateRunInputVariant6
            )
        {
            TemplateRunInputVariant1 = templateRunInputVariant1;
            TemplateRunInputVariant2 = templateRunInputVariant2;
            TemplateRunInputVariant3 = templateRunInputVariant3;
            TemplateRunInputVariant4 = templateRunInputVariant4;
            Reference = reference;
            TemplateRunInputVariant6 = templateRunInputVariant6;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            TemplateRunInputVariant6 as object ??
            Reference as object ??
            TemplateRunInputVariant4 as object ??
            TemplateRunInputVariant3 as object ??
            TemplateRunInputVariant2 as object ??
            TemplateRunInputVariant1 as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            TemplateRunInputVariant1?.ToString() ??
            TemplateRunInputVariant2?.ToString().ToLowerInvariant() ??
            TemplateRunInputVariant3?.ToString() ??
            TemplateRunInputVariant4?.ToString() ??
            Reference?.ToString() ??
            TemplateRunInputVariant6?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsTemplateRunInputVariant1 || IsTemplateRunInputVariant2 || IsTemplateRunInputVariant3 || IsTemplateRunInputVariant4 || IsReference || IsTemplateRunInputVariant6;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string, TResult>? templateRunInputVariant1 = null,
            global::System.Func<bool?, TResult>? templateRunInputVariant2 = null,
            global::System.Func<int?, TResult>? templateRunInputVariant3 = null,
            global::System.Func<double?, TResult>? templateRunInputVariant4 = null,
            global::System.Func<global::ElevenLabs.TemplateInputReference?, TResult>? reference = null,
            global::System.Func<global::System.Collections.Generic.IList<global::ElevenLabs.TemplateRunInput>, TResult>? templateRunInputVariant6 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTemplateRunInputVariant1 && templateRunInputVariant1 != null)
            {
                return templateRunInputVariant1(TemplateRunInputVariant1!);
            }
            else if (IsTemplateRunInputVariant2 && templateRunInputVariant2 != null)
            {
                return templateRunInputVariant2(TemplateRunInputVariant2!);
            }
            else if (IsTemplateRunInputVariant3 && templateRunInputVariant3 != null)
            {
                return templateRunInputVariant3(TemplateRunInputVariant3!);
            }
            else if (IsTemplateRunInputVariant4 && templateRunInputVariant4 != null)
            {
                return templateRunInputVariant4(TemplateRunInputVariant4!);
            }
            else if (IsReference && reference != null)
            {
                return reference(Reference!);
            }
            else if (IsTemplateRunInputVariant6 && templateRunInputVariant6 != null)
            {
                return templateRunInputVariant6(TemplateRunInputVariant6!);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<string>? templateRunInputVariant1 = null,

            global::System.Action<bool?>? templateRunInputVariant2 = null,

            global::System.Action<int?>? templateRunInputVariant3 = null,

            global::System.Action<double?>? templateRunInputVariant4 = null,

            global::System.Action<global::ElevenLabs.TemplateInputReference?>? reference = null,

            global::System.Action<global::System.Collections.Generic.IList<global::ElevenLabs.TemplateRunInput>>? templateRunInputVariant6 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTemplateRunInputVariant1)
            {
                templateRunInputVariant1?.Invoke(TemplateRunInputVariant1!);
            }
            else if (IsTemplateRunInputVariant2)
            {
                templateRunInputVariant2?.Invoke(TemplateRunInputVariant2!);
            }
            else if (IsTemplateRunInputVariant3)
            {
                templateRunInputVariant3?.Invoke(TemplateRunInputVariant3!);
            }
            else if (IsTemplateRunInputVariant4)
            {
                templateRunInputVariant4?.Invoke(TemplateRunInputVariant4!);
            }
            else if (IsReference)
            {
                reference?.Invoke(Reference!);
            }
            else if (IsTemplateRunInputVariant6)
            {
                templateRunInputVariant6?.Invoke(TemplateRunInputVariant6!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<string>? templateRunInputVariant1 = null,
            global::System.Action<bool?>? templateRunInputVariant2 = null,
            global::System.Action<int?>? templateRunInputVariant3 = null,
            global::System.Action<double?>? templateRunInputVariant4 = null,
            global::System.Action<global::ElevenLabs.TemplateInputReference?>? reference = null,
            global::System.Action<global::System.Collections.Generic.IList<global::ElevenLabs.TemplateRunInput>>? templateRunInputVariant6 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTemplateRunInputVariant1)
            {
                templateRunInputVariant1?.Invoke(TemplateRunInputVariant1!);
            }
            else if (IsTemplateRunInputVariant2)
            {
                templateRunInputVariant2?.Invoke(TemplateRunInputVariant2!);
            }
            else if (IsTemplateRunInputVariant3)
            {
                templateRunInputVariant3?.Invoke(TemplateRunInputVariant3!);
            }
            else if (IsTemplateRunInputVariant4)
            {
                templateRunInputVariant4?.Invoke(TemplateRunInputVariant4!);
            }
            else if (IsReference)
            {
                reference?.Invoke(Reference!);
            }
            else if (IsTemplateRunInputVariant6)
            {
                templateRunInputVariant6?.Invoke(TemplateRunInputVariant6!);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                TemplateRunInputVariant1,
                typeof(string),
                TemplateRunInputVariant2,
                typeof(bool),
                TemplateRunInputVariant3,
                typeof(int),
                TemplateRunInputVariant4,
                typeof(double),
                Reference,
                typeof(global::ElevenLabs.TemplateInputReference),
                TemplateRunInputVariant6,
                typeof(global::System.Collections.Generic.IList<global::ElevenLabs.TemplateRunInput>),
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
        public bool Equals(TemplateRunInput other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(TemplateRunInputVariant1, other.TemplateRunInputVariant1) &&
                global::System.Collections.Generic.EqualityComparer<bool?>.Default.Equals(TemplateRunInputVariant2, other.TemplateRunInputVariant2) &&
                global::System.Collections.Generic.EqualityComparer<int?>.Default.Equals(TemplateRunInputVariant3, other.TemplateRunInputVariant3) &&
                global::System.Collections.Generic.EqualityComparer<double?>.Default.Equals(TemplateRunInputVariant4, other.TemplateRunInputVariant4) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.TemplateInputReference?>.Default.Equals(Reference, other.Reference) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<global::ElevenLabs.TemplateRunInput>?>.Default.Equals(TemplateRunInputVariant6, other.TemplateRunInputVariant6)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(TemplateRunInput obj1, TemplateRunInput obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<TemplateRunInput>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(TemplateRunInput obj1, TemplateRunInput obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is TemplateRunInput o && Equals(o);
        }
    }
}
