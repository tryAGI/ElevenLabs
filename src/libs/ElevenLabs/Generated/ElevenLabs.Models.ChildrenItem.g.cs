#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ChildrenItem : global::System.IEquatable<ChildrenItem>
    {
        /// <summary>
        /// String literal.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.ASTStringNodeInput? StringLiteral { get; init; }
#else
        public global::ElevenLabs.ASTStringNodeInput? StringLiteral { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StringLiteral))]
#endif
        public bool IsStringLiteral => StringLiteral != null;

        /// <summary>
        /// Number literal.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.ASTNumberNodeInput? NumberLiteral { get; init; }
#else
        public global::ElevenLabs.ASTNumberNodeInput? NumberLiteral { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(NumberLiteral))]
#endif
        public bool IsNumberLiteral => NumberLiteral != null;

        /// <summary>
        /// Boolean literal.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.ASTBooleanNodeInput? BooleanLiteral { get; init; }
#else
        public global::ElevenLabs.ASTBooleanNodeInput? BooleanLiteral { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BooleanLiteral))]
#endif
        public bool IsBooleanLiteral => BooleanLiteral != null;

        /// <summary>
        /// Value extracted by an LLM according to the given schema.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.ASTLLMNodeInput? ASTLMNodeInput { get; init; }
#else
        public global::ElevenLabs.ASTLLMNodeInput? ASTLMNodeInput { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ASTLMNodeInput))]
#endif
        public bool IsASTLMNodeInput => ASTLMNodeInput != null;

        /// <summary>
        /// Reference to a dynamic variable.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.ASTDynamicVariableNodeInput? DynamicVariable { get; init; }
#else
        public global::ElevenLabs.ASTDynamicVariableNodeInput? DynamicVariable { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DynamicVariable))]
#endif
        public bool IsDynamicVariable => DynamicVariable != null;

        /// <summary>
        /// Evaluates to true if any child is true.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.ASTOrOperatorNodeInput? OrOperator { get; init; }
#else
        public global::ElevenLabs.ASTOrOperatorNodeInput? OrOperator { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OrOperator))]
#endif
        public bool IsOrOperator => OrOperator != null;

        /// <summary>
        /// Evaluates to true if all children are true.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.ASTAndOperatorNodeInput? AndOperator { get; init; }
#else
        public global::ElevenLabs.ASTAndOperatorNodeInput? AndOperator { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AndOperator))]
#endif
        public bool IsAndOperator => AndOperator != null;

        /// <summary>
        /// Evaluates to true if the left value equals the right.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.ASTEqualsOperatorNodeInput? EqOperator { get; init; }
#else
        public global::ElevenLabs.ASTEqualsOperatorNodeInput? EqOperator { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(EqOperator))]
#endif
        public bool IsEqOperator => EqOperator != null;

        /// <summary>
        /// Evaluates to true if the left value does not equal the right.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.ASTNotEqualsOperatorNodeInput? NeqOperator { get; init; }
#else
        public global::ElevenLabs.ASTNotEqualsOperatorNodeInput? NeqOperator { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(NeqOperator))]
#endif
        public bool IsNeqOperator => NeqOperator != null;

        /// <summary>
        /// Evaluates to true if the left value is greater than the right.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.ASTGreaterThanOperatorNodeInput? GtOperator { get; init; }
#else
        public global::ElevenLabs.ASTGreaterThanOperatorNodeInput? GtOperator { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GtOperator))]
#endif
        public bool IsGtOperator => GtOperator != null;

        /// <summary>
        /// Evaluates to true if the left value is less than the right.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.ASTLessThanOperatorNodeInput? LtOperator { get; init; }
#else
        public global::ElevenLabs.ASTLessThanOperatorNodeInput? LtOperator { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(LtOperator))]
#endif
        public bool IsLtOperator => LtOperator != null;

        /// <summary>
        /// Evaluates to true if the left value is greater than or equal to the right.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.ASTGreaterThanOrEqualsOperatorNodeInput? GteOperator { get; init; }
#else
        public global::ElevenLabs.ASTGreaterThanOrEqualsOperatorNodeInput? GteOperator { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GteOperator))]
#endif
        public bool IsGteOperator => GteOperator != null;

        /// <summary>
        /// Evaluates to true if the left value is less than or equal to the right.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.ASTLessThanOrEqualsOperatorNodeInput? LteOperator { get; init; }
#else
        public global::ElevenLabs.ASTLessThanOrEqualsOperatorNodeInput? LteOperator { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(LteOperator))]
#endif
        public bool IsLteOperator => LteOperator != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChildrenItem(global::ElevenLabs.ASTStringNodeInput value) => new ChildrenItem((global::ElevenLabs.ASTStringNodeInput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.ASTStringNodeInput?(ChildrenItem @this) => @this.StringLiteral;

        /// <summary>
        /// 
        /// </summary>
        public ChildrenItem(global::ElevenLabs.ASTStringNodeInput? value)
        {
            StringLiteral = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChildrenItem(global::ElevenLabs.ASTNumberNodeInput value) => new ChildrenItem((global::ElevenLabs.ASTNumberNodeInput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.ASTNumberNodeInput?(ChildrenItem @this) => @this.NumberLiteral;

        /// <summary>
        /// 
        /// </summary>
        public ChildrenItem(global::ElevenLabs.ASTNumberNodeInput? value)
        {
            NumberLiteral = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChildrenItem(global::ElevenLabs.ASTBooleanNodeInput value) => new ChildrenItem((global::ElevenLabs.ASTBooleanNodeInput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.ASTBooleanNodeInput?(ChildrenItem @this) => @this.BooleanLiteral;

        /// <summary>
        /// 
        /// </summary>
        public ChildrenItem(global::ElevenLabs.ASTBooleanNodeInput? value)
        {
            BooleanLiteral = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChildrenItem(global::ElevenLabs.ASTLLMNodeInput value) => new ChildrenItem((global::ElevenLabs.ASTLLMNodeInput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.ASTLLMNodeInput?(ChildrenItem @this) => @this.ASTLMNodeInput;

        /// <summary>
        /// 
        /// </summary>
        public ChildrenItem(global::ElevenLabs.ASTLLMNodeInput? value)
        {
            ASTLMNodeInput = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChildrenItem(global::ElevenLabs.ASTDynamicVariableNodeInput value) => new ChildrenItem((global::ElevenLabs.ASTDynamicVariableNodeInput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.ASTDynamicVariableNodeInput?(ChildrenItem @this) => @this.DynamicVariable;

        /// <summary>
        /// 
        /// </summary>
        public ChildrenItem(global::ElevenLabs.ASTDynamicVariableNodeInput? value)
        {
            DynamicVariable = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChildrenItem(global::ElevenLabs.ASTOrOperatorNodeInput value) => new ChildrenItem((global::ElevenLabs.ASTOrOperatorNodeInput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.ASTOrOperatorNodeInput?(ChildrenItem @this) => @this.OrOperator;

        /// <summary>
        /// 
        /// </summary>
        public ChildrenItem(global::ElevenLabs.ASTOrOperatorNodeInput? value)
        {
            OrOperator = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChildrenItem(global::ElevenLabs.ASTAndOperatorNodeInput value) => new ChildrenItem((global::ElevenLabs.ASTAndOperatorNodeInput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.ASTAndOperatorNodeInput?(ChildrenItem @this) => @this.AndOperator;

        /// <summary>
        /// 
        /// </summary>
        public ChildrenItem(global::ElevenLabs.ASTAndOperatorNodeInput? value)
        {
            AndOperator = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChildrenItem(global::ElevenLabs.ASTEqualsOperatorNodeInput value) => new ChildrenItem((global::ElevenLabs.ASTEqualsOperatorNodeInput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.ASTEqualsOperatorNodeInput?(ChildrenItem @this) => @this.EqOperator;

        /// <summary>
        /// 
        /// </summary>
        public ChildrenItem(global::ElevenLabs.ASTEqualsOperatorNodeInput? value)
        {
            EqOperator = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChildrenItem(global::ElevenLabs.ASTNotEqualsOperatorNodeInput value) => new ChildrenItem((global::ElevenLabs.ASTNotEqualsOperatorNodeInput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.ASTNotEqualsOperatorNodeInput?(ChildrenItem @this) => @this.NeqOperator;

        /// <summary>
        /// 
        /// </summary>
        public ChildrenItem(global::ElevenLabs.ASTNotEqualsOperatorNodeInput? value)
        {
            NeqOperator = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChildrenItem(global::ElevenLabs.ASTGreaterThanOperatorNodeInput value) => new ChildrenItem((global::ElevenLabs.ASTGreaterThanOperatorNodeInput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.ASTGreaterThanOperatorNodeInput?(ChildrenItem @this) => @this.GtOperator;

        /// <summary>
        /// 
        /// </summary>
        public ChildrenItem(global::ElevenLabs.ASTGreaterThanOperatorNodeInput? value)
        {
            GtOperator = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChildrenItem(global::ElevenLabs.ASTLessThanOperatorNodeInput value) => new ChildrenItem((global::ElevenLabs.ASTLessThanOperatorNodeInput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.ASTLessThanOperatorNodeInput?(ChildrenItem @this) => @this.LtOperator;

        /// <summary>
        /// 
        /// </summary>
        public ChildrenItem(global::ElevenLabs.ASTLessThanOperatorNodeInput? value)
        {
            LtOperator = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChildrenItem(global::ElevenLabs.ASTGreaterThanOrEqualsOperatorNodeInput value) => new ChildrenItem((global::ElevenLabs.ASTGreaterThanOrEqualsOperatorNodeInput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.ASTGreaterThanOrEqualsOperatorNodeInput?(ChildrenItem @this) => @this.GteOperator;

        /// <summary>
        /// 
        /// </summary>
        public ChildrenItem(global::ElevenLabs.ASTGreaterThanOrEqualsOperatorNodeInput? value)
        {
            GteOperator = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChildrenItem(global::ElevenLabs.ASTLessThanOrEqualsOperatorNodeInput value) => new ChildrenItem((global::ElevenLabs.ASTLessThanOrEqualsOperatorNodeInput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.ASTLessThanOrEqualsOperatorNodeInput?(ChildrenItem @this) => @this.LteOperator;

        /// <summary>
        /// 
        /// </summary>
        public ChildrenItem(global::ElevenLabs.ASTLessThanOrEqualsOperatorNodeInput? value)
        {
            LteOperator = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ChildrenItem(
            global::ElevenLabs.ASTStringNodeInput? stringLiteral,
            global::ElevenLabs.ASTNumberNodeInput? numberLiteral,
            global::ElevenLabs.ASTBooleanNodeInput? booleanLiteral,
            global::ElevenLabs.ASTLLMNodeInput? aSTLMNodeInput,
            global::ElevenLabs.ASTDynamicVariableNodeInput? dynamicVariable,
            global::ElevenLabs.ASTOrOperatorNodeInput? orOperator,
            global::ElevenLabs.ASTAndOperatorNodeInput? andOperator,
            global::ElevenLabs.ASTEqualsOperatorNodeInput? eqOperator,
            global::ElevenLabs.ASTNotEqualsOperatorNodeInput? neqOperator,
            global::ElevenLabs.ASTGreaterThanOperatorNodeInput? gtOperator,
            global::ElevenLabs.ASTLessThanOperatorNodeInput? ltOperator,
            global::ElevenLabs.ASTGreaterThanOrEqualsOperatorNodeInput? gteOperator,
            global::ElevenLabs.ASTLessThanOrEqualsOperatorNodeInput? lteOperator
            )
        {
            StringLiteral = stringLiteral;
            NumberLiteral = numberLiteral;
            BooleanLiteral = booleanLiteral;
            ASTLMNodeInput = aSTLMNodeInput;
            DynamicVariable = dynamicVariable;
            OrOperator = orOperator;
            AndOperator = andOperator;
            EqOperator = eqOperator;
            NeqOperator = neqOperator;
            GtOperator = gtOperator;
            LtOperator = ltOperator;
            GteOperator = gteOperator;
            LteOperator = lteOperator;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            LteOperator as object ??
            GteOperator as object ??
            LtOperator as object ??
            GtOperator as object ??
            NeqOperator as object ??
            EqOperator as object ??
            AndOperator as object ??
            OrOperator as object ??
            DynamicVariable as object ??
            ASTLMNodeInput as object ??
            BooleanLiteral as object ??
            NumberLiteral as object ??
            StringLiteral as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            StringLiteral?.ToString() ??
            NumberLiteral?.ToString() ??
            BooleanLiteral?.ToString() ??
            ASTLMNodeInput?.ToString() ??
            DynamicVariable?.ToString() ??
            OrOperator?.ToString() ??
            AndOperator?.ToString() ??
            EqOperator?.ToString() ??
            NeqOperator?.ToString() ??
            GtOperator?.ToString() ??
            LtOperator?.ToString() ??
            GteOperator?.ToString() ??
            LteOperator?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsStringLiteral && !IsNumberLiteral && !IsBooleanLiteral && !IsASTLMNodeInput && !IsDynamicVariable && !IsOrOperator && !IsAndOperator && !IsEqOperator && !IsNeqOperator && !IsGtOperator && !IsLtOperator && !IsGteOperator && !IsLteOperator || !IsStringLiteral && IsNumberLiteral && !IsBooleanLiteral && !IsASTLMNodeInput && !IsDynamicVariable && !IsOrOperator && !IsAndOperator && !IsEqOperator && !IsNeqOperator && !IsGtOperator && !IsLtOperator && !IsGteOperator && !IsLteOperator || !IsStringLiteral && !IsNumberLiteral && IsBooleanLiteral && !IsASTLMNodeInput && !IsDynamicVariable && !IsOrOperator && !IsAndOperator && !IsEqOperator && !IsNeqOperator && !IsGtOperator && !IsLtOperator && !IsGteOperator && !IsLteOperator || !IsStringLiteral && !IsNumberLiteral && !IsBooleanLiteral && IsASTLMNodeInput && !IsDynamicVariable && !IsOrOperator && !IsAndOperator && !IsEqOperator && !IsNeqOperator && !IsGtOperator && !IsLtOperator && !IsGteOperator && !IsLteOperator || !IsStringLiteral && !IsNumberLiteral && !IsBooleanLiteral && !IsASTLMNodeInput && IsDynamicVariable && !IsOrOperator && !IsAndOperator && !IsEqOperator && !IsNeqOperator && !IsGtOperator && !IsLtOperator && !IsGteOperator && !IsLteOperator || !IsStringLiteral && !IsNumberLiteral && !IsBooleanLiteral && !IsASTLMNodeInput && !IsDynamicVariable && IsOrOperator && !IsAndOperator && !IsEqOperator && !IsNeqOperator && !IsGtOperator && !IsLtOperator && !IsGteOperator && !IsLteOperator || !IsStringLiteral && !IsNumberLiteral && !IsBooleanLiteral && !IsASTLMNodeInput && !IsDynamicVariable && !IsOrOperator && IsAndOperator && !IsEqOperator && !IsNeqOperator && !IsGtOperator && !IsLtOperator && !IsGteOperator && !IsLteOperator || !IsStringLiteral && !IsNumberLiteral && !IsBooleanLiteral && !IsASTLMNodeInput && !IsDynamicVariable && !IsOrOperator && !IsAndOperator && IsEqOperator && !IsNeqOperator && !IsGtOperator && !IsLtOperator && !IsGteOperator && !IsLteOperator || !IsStringLiteral && !IsNumberLiteral && !IsBooleanLiteral && !IsASTLMNodeInput && !IsDynamicVariable && !IsOrOperator && !IsAndOperator && !IsEqOperator && IsNeqOperator && !IsGtOperator && !IsLtOperator && !IsGteOperator && !IsLteOperator || !IsStringLiteral && !IsNumberLiteral && !IsBooleanLiteral && !IsASTLMNodeInput && !IsDynamicVariable && !IsOrOperator && !IsAndOperator && !IsEqOperator && !IsNeqOperator && IsGtOperator && !IsLtOperator && !IsGteOperator && !IsLteOperator || !IsStringLiteral && !IsNumberLiteral && !IsBooleanLiteral && !IsASTLMNodeInput && !IsDynamicVariable && !IsOrOperator && !IsAndOperator && !IsEqOperator && !IsNeqOperator && !IsGtOperator && IsLtOperator && !IsGteOperator && !IsLteOperator || !IsStringLiteral && !IsNumberLiteral && !IsBooleanLiteral && !IsASTLMNodeInput && !IsDynamicVariable && !IsOrOperator && !IsAndOperator && !IsEqOperator && !IsNeqOperator && !IsGtOperator && !IsLtOperator && IsGteOperator && !IsLteOperator || !IsStringLiteral && !IsNumberLiteral && !IsBooleanLiteral && !IsASTLMNodeInput && !IsDynamicVariable && !IsOrOperator && !IsAndOperator && !IsEqOperator && !IsNeqOperator && !IsGtOperator && !IsLtOperator && !IsGteOperator && IsLteOperator;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::ElevenLabs.ASTStringNodeInput?, TResult>? stringLiteral = null,
            global::System.Func<global::ElevenLabs.ASTNumberNodeInput?, TResult>? numberLiteral = null,
            global::System.Func<global::ElevenLabs.ASTBooleanNodeInput?, TResult>? booleanLiteral = null,
            global::System.Func<global::ElevenLabs.ASTLLMNodeInput?, TResult>? aSTLMNodeInput = null,
            global::System.Func<global::ElevenLabs.ASTDynamicVariableNodeInput?, TResult>? dynamicVariable = null,
            global::System.Func<global::ElevenLabs.ASTOrOperatorNodeInput?, TResult>? orOperator = null,
            global::System.Func<global::ElevenLabs.ASTAndOperatorNodeInput?, TResult>? andOperator = null,
            global::System.Func<global::ElevenLabs.ASTEqualsOperatorNodeInput?, TResult>? eqOperator = null,
            global::System.Func<global::ElevenLabs.ASTNotEqualsOperatorNodeInput?, TResult>? neqOperator = null,
            global::System.Func<global::ElevenLabs.ASTGreaterThanOperatorNodeInput?, TResult>? gtOperator = null,
            global::System.Func<global::ElevenLabs.ASTLessThanOperatorNodeInput?, TResult>? ltOperator = null,
            global::System.Func<global::ElevenLabs.ASTGreaterThanOrEqualsOperatorNodeInput?, TResult>? gteOperator = null,
            global::System.Func<global::ElevenLabs.ASTLessThanOrEqualsOperatorNodeInput?, TResult>? lteOperator = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsStringLiteral && stringLiteral != null)
            {
                return stringLiteral(StringLiteral!);
            }
            else if (IsNumberLiteral && numberLiteral != null)
            {
                return numberLiteral(NumberLiteral!);
            }
            else if (IsBooleanLiteral && booleanLiteral != null)
            {
                return booleanLiteral(BooleanLiteral!);
            }
            else if (IsASTLMNodeInput && aSTLMNodeInput != null)
            {
                return aSTLMNodeInput(ASTLMNodeInput!);
            }
            else if (IsDynamicVariable && dynamicVariable != null)
            {
                return dynamicVariable(DynamicVariable!);
            }
            else if (IsOrOperator && orOperator != null)
            {
                return orOperator(OrOperator!);
            }
            else if (IsAndOperator && andOperator != null)
            {
                return andOperator(AndOperator!);
            }
            else if (IsEqOperator && eqOperator != null)
            {
                return eqOperator(EqOperator!);
            }
            else if (IsNeqOperator && neqOperator != null)
            {
                return neqOperator(NeqOperator!);
            }
            else if (IsGtOperator && gtOperator != null)
            {
                return gtOperator(GtOperator!);
            }
            else if (IsLtOperator && ltOperator != null)
            {
                return ltOperator(LtOperator!);
            }
            else if (IsGteOperator && gteOperator != null)
            {
                return gteOperator(GteOperator!);
            }
            else if (IsLteOperator && lteOperator != null)
            {
                return lteOperator(LteOperator!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::ElevenLabs.ASTStringNodeInput?>? stringLiteral = null,
            global::System.Action<global::ElevenLabs.ASTNumberNodeInput?>? numberLiteral = null,
            global::System.Action<global::ElevenLabs.ASTBooleanNodeInput?>? booleanLiteral = null,
            global::System.Action<global::ElevenLabs.ASTLLMNodeInput?>? aSTLMNodeInput = null,
            global::System.Action<global::ElevenLabs.ASTDynamicVariableNodeInput?>? dynamicVariable = null,
            global::System.Action<global::ElevenLabs.ASTOrOperatorNodeInput?>? orOperator = null,
            global::System.Action<global::ElevenLabs.ASTAndOperatorNodeInput?>? andOperator = null,
            global::System.Action<global::ElevenLabs.ASTEqualsOperatorNodeInput?>? eqOperator = null,
            global::System.Action<global::ElevenLabs.ASTNotEqualsOperatorNodeInput?>? neqOperator = null,
            global::System.Action<global::ElevenLabs.ASTGreaterThanOperatorNodeInput?>? gtOperator = null,
            global::System.Action<global::ElevenLabs.ASTLessThanOperatorNodeInput?>? ltOperator = null,
            global::System.Action<global::ElevenLabs.ASTGreaterThanOrEqualsOperatorNodeInput?>? gteOperator = null,
            global::System.Action<global::ElevenLabs.ASTLessThanOrEqualsOperatorNodeInput?>? lteOperator = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsStringLiteral)
            {
                stringLiteral?.Invoke(StringLiteral!);
            }
            else if (IsNumberLiteral)
            {
                numberLiteral?.Invoke(NumberLiteral!);
            }
            else if (IsBooleanLiteral)
            {
                booleanLiteral?.Invoke(BooleanLiteral!);
            }
            else if (IsASTLMNodeInput)
            {
                aSTLMNodeInput?.Invoke(ASTLMNodeInput!);
            }
            else if (IsDynamicVariable)
            {
                dynamicVariable?.Invoke(DynamicVariable!);
            }
            else if (IsOrOperator)
            {
                orOperator?.Invoke(OrOperator!);
            }
            else if (IsAndOperator)
            {
                andOperator?.Invoke(AndOperator!);
            }
            else if (IsEqOperator)
            {
                eqOperator?.Invoke(EqOperator!);
            }
            else if (IsNeqOperator)
            {
                neqOperator?.Invoke(NeqOperator!);
            }
            else if (IsGtOperator)
            {
                gtOperator?.Invoke(GtOperator!);
            }
            else if (IsLtOperator)
            {
                ltOperator?.Invoke(LtOperator!);
            }
            else if (IsGteOperator)
            {
                gteOperator?.Invoke(GteOperator!);
            }
            else if (IsLteOperator)
            {
                lteOperator?.Invoke(LteOperator!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                StringLiteral,
                typeof(global::ElevenLabs.ASTStringNodeInput),
                NumberLiteral,
                typeof(global::ElevenLabs.ASTNumberNodeInput),
                BooleanLiteral,
                typeof(global::ElevenLabs.ASTBooleanNodeInput),
                ASTLMNodeInput,
                typeof(global::ElevenLabs.ASTLLMNodeInput),
                DynamicVariable,
                typeof(global::ElevenLabs.ASTDynamicVariableNodeInput),
                OrOperator,
                typeof(global::ElevenLabs.ASTOrOperatorNodeInput),
                AndOperator,
                typeof(global::ElevenLabs.ASTAndOperatorNodeInput),
                EqOperator,
                typeof(global::ElevenLabs.ASTEqualsOperatorNodeInput),
                NeqOperator,
                typeof(global::ElevenLabs.ASTNotEqualsOperatorNodeInput),
                GtOperator,
                typeof(global::ElevenLabs.ASTGreaterThanOperatorNodeInput),
                LtOperator,
                typeof(global::ElevenLabs.ASTLessThanOperatorNodeInput),
                GteOperator,
                typeof(global::ElevenLabs.ASTGreaterThanOrEqualsOperatorNodeInput),
                LteOperator,
                typeof(global::ElevenLabs.ASTLessThanOrEqualsOperatorNodeInput),
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
        public bool Equals(ChildrenItem other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.ASTStringNodeInput?>.Default.Equals(StringLiteral, other.StringLiteral) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.ASTNumberNodeInput?>.Default.Equals(NumberLiteral, other.NumberLiteral) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.ASTBooleanNodeInput?>.Default.Equals(BooleanLiteral, other.BooleanLiteral) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.ASTLLMNodeInput?>.Default.Equals(ASTLMNodeInput, other.ASTLMNodeInput) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.ASTDynamicVariableNodeInput?>.Default.Equals(DynamicVariable, other.DynamicVariable) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.ASTOrOperatorNodeInput?>.Default.Equals(OrOperator, other.OrOperator) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.ASTAndOperatorNodeInput?>.Default.Equals(AndOperator, other.AndOperator) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.ASTEqualsOperatorNodeInput?>.Default.Equals(EqOperator, other.EqOperator) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.ASTNotEqualsOperatorNodeInput?>.Default.Equals(NeqOperator, other.NeqOperator) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.ASTGreaterThanOperatorNodeInput?>.Default.Equals(GtOperator, other.GtOperator) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.ASTLessThanOperatorNodeInput?>.Default.Equals(LtOperator, other.LtOperator) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.ASTGreaterThanOrEqualsOperatorNodeInput?>.Default.Equals(GteOperator, other.GteOperator) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.ASTLessThanOrEqualsOperatorNodeInput?>.Default.Equals(LteOperator, other.LteOperator) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ChildrenItem obj1, ChildrenItem obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ChildrenItem>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ChildrenItem obj1, ChildrenItem obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ChildrenItem o && Equals(o);
        }
    }
}
