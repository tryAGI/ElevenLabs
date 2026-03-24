#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// Expression selected if the condition is false.
    /// </summary>
    public readonly partial struct FalseExpression2 : global::System.IEquatable<FalseExpression2>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::ElevenLabs.ASTConditionalOperatorNodeOutputFalseExpressionDiscriminatorType? Type { get; }

        /// <summary>
        /// String literal.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.ASTStringNodeOutput? StringLiteral { get; init; }
#else
        public global::ElevenLabs.ASTStringNodeOutput? StringLiteral { get; }
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
        public global::ElevenLabs.ASTNumberNodeOutput? NumberLiteral { get; init; }
#else
        public global::ElevenLabs.ASTNumberNodeOutput? NumberLiteral { get; }
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
        public global::ElevenLabs.ASTBooleanNodeOutput? BooleanLiteral { get; init; }
#else
        public global::ElevenLabs.ASTBooleanNodeOutput? BooleanLiteral { get; }
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
        public global::ElevenLabs.ASTLLMNodeOutput? Llm { get; init; }
#else
        public global::ElevenLabs.ASTLLMNodeOutput? Llm { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Llm))]
#endif
        public bool IsLlm => Llm != null;

        /// <summary>
        /// Reference to a dynamic variable.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.ASTDynamicVariableNodeOutput? DynamicVariable { get; init; }
#else
        public global::ElevenLabs.ASTDynamicVariableNodeOutput? DynamicVariable { get; }
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
        public global::ElevenLabs.ASTOrOperatorNodeOutput? OrOperator { get; init; }
#else
        public global::ElevenLabs.ASTOrOperatorNodeOutput? OrOperator { get; }
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
        public global::ElevenLabs.ASTAndOperatorNodeOutput? AndOperator { get; init; }
#else
        public global::ElevenLabs.ASTAndOperatorNodeOutput? AndOperator { get; }
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
        public global::ElevenLabs.ASTEqualsOperatorNodeOutput? EqOperator { get; init; }
#else
        public global::ElevenLabs.ASTEqualsOperatorNodeOutput? EqOperator { get; }
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
        public global::ElevenLabs.ASTNotEqualsOperatorNodeOutput? NeqOperator { get; init; }
#else
        public global::ElevenLabs.ASTNotEqualsOperatorNodeOutput? NeqOperator { get; }
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
        public global::ElevenLabs.ASTGreaterThanOperatorNodeOutput? GtOperator { get; init; }
#else
        public global::ElevenLabs.ASTGreaterThanOperatorNodeOutput? GtOperator { get; }
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
        public global::ElevenLabs.ASTLessThanOperatorNodeOutput? LtOperator { get; init; }
#else
        public global::ElevenLabs.ASTLessThanOperatorNodeOutput? LtOperator { get; }
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
        public global::ElevenLabs.ASTGreaterThanOrEqualsOperatorNodeOutput? GteOperator { get; init; }
#else
        public global::ElevenLabs.ASTGreaterThanOrEqualsOperatorNodeOutput? GteOperator { get; }
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
        public global::ElevenLabs.ASTLessThanOrEqualsOperatorNodeOutput? LteOperator { get; init; }
#else
        public global::ElevenLabs.ASTLessThanOrEqualsOperatorNodeOutput? LteOperator { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(LteOperator))]
#endif
        public bool IsLteOperator => LteOperator != null;

        /// <summary>
        /// Adds the left and right values.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.ASTAdditionOperatorNodeOutput? AddOperator { get; init; }
#else
        public global::ElevenLabs.ASTAdditionOperatorNodeOutput? AddOperator { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AddOperator))]
#endif
        public bool IsAddOperator => AddOperator != null;

        /// <summary>
        /// Subtracts the right value from the left.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.ASTSubtractionOperatorNodeOutput? SubOperator { get; init; }
#else
        public global::ElevenLabs.ASTSubtractionOperatorNodeOutput? SubOperator { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SubOperator))]
#endif
        public bool IsSubOperator => SubOperator != null;

        /// <summary>
        /// Multiplies the left value times the right.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.ASTMultiplicationOperatorNodeOutput? MulOperator { get; init; }
#else
        public global::ElevenLabs.ASTMultiplicationOperatorNodeOutput? MulOperator { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MulOperator))]
#endif
        public bool IsMulOperator => MulOperator != null;

        /// <summary>
        /// Divides the left value by the right.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.ASTDivisionOperatorNodeOutput? DivOperator { get; init; }
#else
        public global::ElevenLabs.ASTDivisionOperatorNodeOutput? DivOperator { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DivOperator))]
#endif
        public bool IsDivOperator => DivOperator != null;

        /// <summary>
        /// Selects one of two expressions based on whether the given condition evaluates to true.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.ASTConditionalOperatorNodeOutput? ConditionalOperator { get; init; }
#else
        public global::ElevenLabs.ASTConditionalOperatorNodeOutput? ConditionalOperator { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ConditionalOperator))]
#endif
        public bool IsConditionalOperator => ConditionalOperator != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator FalseExpression2(global::ElevenLabs.ASTStringNodeOutput value) => new FalseExpression2((global::ElevenLabs.ASTStringNodeOutput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.ASTStringNodeOutput?(FalseExpression2 @this) => @this.StringLiteral;

        /// <summary>
        /// 
        /// </summary>
        public FalseExpression2(global::ElevenLabs.ASTStringNodeOutput? value)
        {
            StringLiteral = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator FalseExpression2(global::ElevenLabs.ASTNumberNodeOutput value) => new FalseExpression2((global::ElevenLabs.ASTNumberNodeOutput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.ASTNumberNodeOutput?(FalseExpression2 @this) => @this.NumberLiteral;

        /// <summary>
        /// 
        /// </summary>
        public FalseExpression2(global::ElevenLabs.ASTNumberNodeOutput? value)
        {
            NumberLiteral = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator FalseExpression2(global::ElevenLabs.ASTBooleanNodeOutput value) => new FalseExpression2((global::ElevenLabs.ASTBooleanNodeOutput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.ASTBooleanNodeOutput?(FalseExpression2 @this) => @this.BooleanLiteral;

        /// <summary>
        /// 
        /// </summary>
        public FalseExpression2(global::ElevenLabs.ASTBooleanNodeOutput? value)
        {
            BooleanLiteral = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator FalseExpression2(global::ElevenLabs.ASTLLMNodeOutput value) => new FalseExpression2((global::ElevenLabs.ASTLLMNodeOutput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.ASTLLMNodeOutput?(FalseExpression2 @this) => @this.Llm;

        /// <summary>
        /// 
        /// </summary>
        public FalseExpression2(global::ElevenLabs.ASTLLMNodeOutput? value)
        {
            Llm = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator FalseExpression2(global::ElevenLabs.ASTDynamicVariableNodeOutput value) => new FalseExpression2((global::ElevenLabs.ASTDynamicVariableNodeOutput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.ASTDynamicVariableNodeOutput?(FalseExpression2 @this) => @this.DynamicVariable;

        /// <summary>
        /// 
        /// </summary>
        public FalseExpression2(global::ElevenLabs.ASTDynamicVariableNodeOutput? value)
        {
            DynamicVariable = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator FalseExpression2(global::ElevenLabs.ASTOrOperatorNodeOutput value) => new FalseExpression2((global::ElevenLabs.ASTOrOperatorNodeOutput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.ASTOrOperatorNodeOutput?(FalseExpression2 @this) => @this.OrOperator;

        /// <summary>
        /// 
        /// </summary>
        public FalseExpression2(global::ElevenLabs.ASTOrOperatorNodeOutput? value)
        {
            OrOperator = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator FalseExpression2(global::ElevenLabs.ASTAndOperatorNodeOutput value) => new FalseExpression2((global::ElevenLabs.ASTAndOperatorNodeOutput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.ASTAndOperatorNodeOutput?(FalseExpression2 @this) => @this.AndOperator;

        /// <summary>
        /// 
        /// </summary>
        public FalseExpression2(global::ElevenLabs.ASTAndOperatorNodeOutput? value)
        {
            AndOperator = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator FalseExpression2(global::ElevenLabs.ASTEqualsOperatorNodeOutput value) => new FalseExpression2((global::ElevenLabs.ASTEqualsOperatorNodeOutput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.ASTEqualsOperatorNodeOutput?(FalseExpression2 @this) => @this.EqOperator;

        /// <summary>
        /// 
        /// </summary>
        public FalseExpression2(global::ElevenLabs.ASTEqualsOperatorNodeOutput? value)
        {
            EqOperator = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator FalseExpression2(global::ElevenLabs.ASTNotEqualsOperatorNodeOutput value) => new FalseExpression2((global::ElevenLabs.ASTNotEqualsOperatorNodeOutput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.ASTNotEqualsOperatorNodeOutput?(FalseExpression2 @this) => @this.NeqOperator;

        /// <summary>
        /// 
        /// </summary>
        public FalseExpression2(global::ElevenLabs.ASTNotEqualsOperatorNodeOutput? value)
        {
            NeqOperator = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator FalseExpression2(global::ElevenLabs.ASTGreaterThanOperatorNodeOutput value) => new FalseExpression2((global::ElevenLabs.ASTGreaterThanOperatorNodeOutput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.ASTGreaterThanOperatorNodeOutput?(FalseExpression2 @this) => @this.GtOperator;

        /// <summary>
        /// 
        /// </summary>
        public FalseExpression2(global::ElevenLabs.ASTGreaterThanOperatorNodeOutput? value)
        {
            GtOperator = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator FalseExpression2(global::ElevenLabs.ASTLessThanOperatorNodeOutput value) => new FalseExpression2((global::ElevenLabs.ASTLessThanOperatorNodeOutput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.ASTLessThanOperatorNodeOutput?(FalseExpression2 @this) => @this.LtOperator;

        /// <summary>
        /// 
        /// </summary>
        public FalseExpression2(global::ElevenLabs.ASTLessThanOperatorNodeOutput? value)
        {
            LtOperator = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator FalseExpression2(global::ElevenLabs.ASTGreaterThanOrEqualsOperatorNodeOutput value) => new FalseExpression2((global::ElevenLabs.ASTGreaterThanOrEqualsOperatorNodeOutput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.ASTGreaterThanOrEqualsOperatorNodeOutput?(FalseExpression2 @this) => @this.GteOperator;

        /// <summary>
        /// 
        /// </summary>
        public FalseExpression2(global::ElevenLabs.ASTGreaterThanOrEqualsOperatorNodeOutput? value)
        {
            GteOperator = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator FalseExpression2(global::ElevenLabs.ASTLessThanOrEqualsOperatorNodeOutput value) => new FalseExpression2((global::ElevenLabs.ASTLessThanOrEqualsOperatorNodeOutput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.ASTLessThanOrEqualsOperatorNodeOutput?(FalseExpression2 @this) => @this.LteOperator;

        /// <summary>
        /// 
        /// </summary>
        public FalseExpression2(global::ElevenLabs.ASTLessThanOrEqualsOperatorNodeOutput? value)
        {
            LteOperator = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator FalseExpression2(global::ElevenLabs.ASTAdditionOperatorNodeOutput value) => new FalseExpression2((global::ElevenLabs.ASTAdditionOperatorNodeOutput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.ASTAdditionOperatorNodeOutput?(FalseExpression2 @this) => @this.AddOperator;

        /// <summary>
        /// 
        /// </summary>
        public FalseExpression2(global::ElevenLabs.ASTAdditionOperatorNodeOutput? value)
        {
            AddOperator = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator FalseExpression2(global::ElevenLabs.ASTSubtractionOperatorNodeOutput value) => new FalseExpression2((global::ElevenLabs.ASTSubtractionOperatorNodeOutput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.ASTSubtractionOperatorNodeOutput?(FalseExpression2 @this) => @this.SubOperator;

        /// <summary>
        /// 
        /// </summary>
        public FalseExpression2(global::ElevenLabs.ASTSubtractionOperatorNodeOutput? value)
        {
            SubOperator = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator FalseExpression2(global::ElevenLabs.ASTMultiplicationOperatorNodeOutput value) => new FalseExpression2((global::ElevenLabs.ASTMultiplicationOperatorNodeOutput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.ASTMultiplicationOperatorNodeOutput?(FalseExpression2 @this) => @this.MulOperator;

        /// <summary>
        /// 
        /// </summary>
        public FalseExpression2(global::ElevenLabs.ASTMultiplicationOperatorNodeOutput? value)
        {
            MulOperator = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator FalseExpression2(global::ElevenLabs.ASTDivisionOperatorNodeOutput value) => new FalseExpression2((global::ElevenLabs.ASTDivisionOperatorNodeOutput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.ASTDivisionOperatorNodeOutput?(FalseExpression2 @this) => @this.DivOperator;

        /// <summary>
        /// 
        /// </summary>
        public FalseExpression2(global::ElevenLabs.ASTDivisionOperatorNodeOutput? value)
        {
            DivOperator = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator FalseExpression2(global::ElevenLabs.ASTConditionalOperatorNodeOutput value) => new FalseExpression2((global::ElevenLabs.ASTConditionalOperatorNodeOutput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.ASTConditionalOperatorNodeOutput?(FalseExpression2 @this) => @this.ConditionalOperator;

        /// <summary>
        /// 
        /// </summary>
        public FalseExpression2(global::ElevenLabs.ASTConditionalOperatorNodeOutput? value)
        {
            ConditionalOperator = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public FalseExpression2(
            global::ElevenLabs.ASTConditionalOperatorNodeOutputFalseExpressionDiscriminatorType? type,
            global::ElevenLabs.ASTStringNodeOutput? stringLiteral,
            global::ElevenLabs.ASTNumberNodeOutput? numberLiteral,
            global::ElevenLabs.ASTBooleanNodeOutput? booleanLiteral,
            global::ElevenLabs.ASTLLMNodeOutput? llm,
            global::ElevenLabs.ASTDynamicVariableNodeOutput? dynamicVariable,
            global::ElevenLabs.ASTOrOperatorNodeOutput? orOperator,
            global::ElevenLabs.ASTAndOperatorNodeOutput? andOperator,
            global::ElevenLabs.ASTEqualsOperatorNodeOutput? eqOperator,
            global::ElevenLabs.ASTNotEqualsOperatorNodeOutput? neqOperator,
            global::ElevenLabs.ASTGreaterThanOperatorNodeOutput? gtOperator,
            global::ElevenLabs.ASTLessThanOperatorNodeOutput? ltOperator,
            global::ElevenLabs.ASTGreaterThanOrEqualsOperatorNodeOutput? gteOperator,
            global::ElevenLabs.ASTLessThanOrEqualsOperatorNodeOutput? lteOperator,
            global::ElevenLabs.ASTAdditionOperatorNodeOutput? addOperator,
            global::ElevenLabs.ASTSubtractionOperatorNodeOutput? subOperator,
            global::ElevenLabs.ASTMultiplicationOperatorNodeOutput? mulOperator,
            global::ElevenLabs.ASTDivisionOperatorNodeOutput? divOperator,
            global::ElevenLabs.ASTConditionalOperatorNodeOutput? conditionalOperator
            )
        {
            Type = type;

            StringLiteral = stringLiteral;
            NumberLiteral = numberLiteral;
            BooleanLiteral = booleanLiteral;
            Llm = llm;
            DynamicVariable = dynamicVariable;
            OrOperator = orOperator;
            AndOperator = andOperator;
            EqOperator = eqOperator;
            NeqOperator = neqOperator;
            GtOperator = gtOperator;
            LtOperator = ltOperator;
            GteOperator = gteOperator;
            LteOperator = lteOperator;
            AddOperator = addOperator;
            SubOperator = subOperator;
            MulOperator = mulOperator;
            DivOperator = divOperator;
            ConditionalOperator = conditionalOperator;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ConditionalOperator as object ??
            DivOperator as object ??
            MulOperator as object ??
            SubOperator as object ??
            AddOperator as object ??
            LteOperator as object ??
            GteOperator as object ??
            LtOperator as object ??
            GtOperator as object ??
            NeqOperator as object ??
            EqOperator as object ??
            AndOperator as object ??
            OrOperator as object ??
            DynamicVariable as object ??
            Llm as object ??
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
            Llm?.ToString() ??
            DynamicVariable?.ToString() ??
            OrOperator?.ToString() ??
            AndOperator?.ToString() ??
            EqOperator?.ToString() ??
            NeqOperator?.ToString() ??
            GtOperator?.ToString() ??
            LtOperator?.ToString() ??
            GteOperator?.ToString() ??
            LteOperator?.ToString() ??
            AddOperator?.ToString() ??
            SubOperator?.ToString() ??
            MulOperator?.ToString() ??
            DivOperator?.ToString() ??
            ConditionalOperator?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsStringLiteral && !IsNumberLiteral && !IsBooleanLiteral && !IsLlm && !IsDynamicVariable && !IsOrOperator && !IsAndOperator && !IsEqOperator && !IsNeqOperator && !IsGtOperator && !IsLtOperator && !IsGteOperator && !IsLteOperator && !IsAddOperator && !IsSubOperator && !IsMulOperator && !IsDivOperator && !IsConditionalOperator || !IsStringLiteral && IsNumberLiteral && !IsBooleanLiteral && !IsLlm && !IsDynamicVariable && !IsOrOperator && !IsAndOperator && !IsEqOperator && !IsNeqOperator && !IsGtOperator && !IsLtOperator && !IsGteOperator && !IsLteOperator && !IsAddOperator && !IsSubOperator && !IsMulOperator && !IsDivOperator && !IsConditionalOperator || !IsStringLiteral && !IsNumberLiteral && IsBooleanLiteral && !IsLlm && !IsDynamicVariable && !IsOrOperator && !IsAndOperator && !IsEqOperator && !IsNeqOperator && !IsGtOperator && !IsLtOperator && !IsGteOperator && !IsLteOperator && !IsAddOperator && !IsSubOperator && !IsMulOperator && !IsDivOperator && !IsConditionalOperator || !IsStringLiteral && !IsNumberLiteral && !IsBooleanLiteral && IsLlm && !IsDynamicVariable && !IsOrOperator && !IsAndOperator && !IsEqOperator && !IsNeqOperator && !IsGtOperator && !IsLtOperator && !IsGteOperator && !IsLteOperator && !IsAddOperator && !IsSubOperator && !IsMulOperator && !IsDivOperator && !IsConditionalOperator || !IsStringLiteral && !IsNumberLiteral && !IsBooleanLiteral && !IsLlm && IsDynamicVariable && !IsOrOperator && !IsAndOperator && !IsEqOperator && !IsNeqOperator && !IsGtOperator && !IsLtOperator && !IsGteOperator && !IsLteOperator && !IsAddOperator && !IsSubOperator && !IsMulOperator && !IsDivOperator && !IsConditionalOperator || !IsStringLiteral && !IsNumberLiteral && !IsBooleanLiteral && !IsLlm && !IsDynamicVariable && IsOrOperator && !IsAndOperator && !IsEqOperator && !IsNeqOperator && !IsGtOperator && !IsLtOperator && !IsGteOperator && !IsLteOperator && !IsAddOperator && !IsSubOperator && !IsMulOperator && !IsDivOperator && !IsConditionalOperator || !IsStringLiteral && !IsNumberLiteral && !IsBooleanLiteral && !IsLlm && !IsDynamicVariable && !IsOrOperator && IsAndOperator && !IsEqOperator && !IsNeqOperator && !IsGtOperator && !IsLtOperator && !IsGteOperator && !IsLteOperator && !IsAddOperator && !IsSubOperator && !IsMulOperator && !IsDivOperator && !IsConditionalOperator || !IsStringLiteral && !IsNumberLiteral && !IsBooleanLiteral && !IsLlm && !IsDynamicVariable && !IsOrOperator && !IsAndOperator && IsEqOperator && !IsNeqOperator && !IsGtOperator && !IsLtOperator && !IsGteOperator && !IsLteOperator && !IsAddOperator && !IsSubOperator && !IsMulOperator && !IsDivOperator && !IsConditionalOperator || !IsStringLiteral && !IsNumberLiteral && !IsBooleanLiteral && !IsLlm && !IsDynamicVariable && !IsOrOperator && !IsAndOperator && !IsEqOperator && IsNeqOperator && !IsGtOperator && !IsLtOperator && !IsGteOperator && !IsLteOperator && !IsAddOperator && !IsSubOperator && !IsMulOperator && !IsDivOperator && !IsConditionalOperator || !IsStringLiteral && !IsNumberLiteral && !IsBooleanLiteral && !IsLlm && !IsDynamicVariable && !IsOrOperator && !IsAndOperator && !IsEqOperator && !IsNeqOperator && IsGtOperator && !IsLtOperator && !IsGteOperator && !IsLteOperator && !IsAddOperator && !IsSubOperator && !IsMulOperator && !IsDivOperator && !IsConditionalOperator || !IsStringLiteral && !IsNumberLiteral && !IsBooleanLiteral && !IsLlm && !IsDynamicVariable && !IsOrOperator && !IsAndOperator && !IsEqOperator && !IsNeqOperator && !IsGtOperator && IsLtOperator && !IsGteOperator && !IsLteOperator && !IsAddOperator && !IsSubOperator && !IsMulOperator && !IsDivOperator && !IsConditionalOperator || !IsStringLiteral && !IsNumberLiteral && !IsBooleanLiteral && !IsLlm && !IsDynamicVariable && !IsOrOperator && !IsAndOperator && !IsEqOperator && !IsNeqOperator && !IsGtOperator && !IsLtOperator && IsGteOperator && !IsLteOperator && !IsAddOperator && !IsSubOperator && !IsMulOperator && !IsDivOperator && !IsConditionalOperator || !IsStringLiteral && !IsNumberLiteral && !IsBooleanLiteral && !IsLlm && !IsDynamicVariable && !IsOrOperator && !IsAndOperator && !IsEqOperator && !IsNeqOperator && !IsGtOperator && !IsLtOperator && !IsGteOperator && IsLteOperator && !IsAddOperator && !IsSubOperator && !IsMulOperator && !IsDivOperator && !IsConditionalOperator || !IsStringLiteral && !IsNumberLiteral && !IsBooleanLiteral && !IsLlm && !IsDynamicVariable && !IsOrOperator && !IsAndOperator && !IsEqOperator && !IsNeqOperator && !IsGtOperator && !IsLtOperator && !IsGteOperator && !IsLteOperator && IsAddOperator && !IsSubOperator && !IsMulOperator && !IsDivOperator && !IsConditionalOperator || !IsStringLiteral && !IsNumberLiteral && !IsBooleanLiteral && !IsLlm && !IsDynamicVariable && !IsOrOperator && !IsAndOperator && !IsEqOperator && !IsNeqOperator && !IsGtOperator && !IsLtOperator && !IsGteOperator && !IsLteOperator && !IsAddOperator && IsSubOperator && !IsMulOperator && !IsDivOperator && !IsConditionalOperator || !IsStringLiteral && !IsNumberLiteral && !IsBooleanLiteral && !IsLlm && !IsDynamicVariable && !IsOrOperator && !IsAndOperator && !IsEqOperator && !IsNeqOperator && !IsGtOperator && !IsLtOperator && !IsGteOperator && !IsLteOperator && !IsAddOperator && !IsSubOperator && IsMulOperator && !IsDivOperator && !IsConditionalOperator || !IsStringLiteral && !IsNumberLiteral && !IsBooleanLiteral && !IsLlm && !IsDynamicVariable && !IsOrOperator && !IsAndOperator && !IsEqOperator && !IsNeqOperator && !IsGtOperator && !IsLtOperator && !IsGteOperator && !IsLteOperator && !IsAddOperator && !IsSubOperator && !IsMulOperator && IsDivOperator && !IsConditionalOperator || !IsStringLiteral && !IsNumberLiteral && !IsBooleanLiteral && !IsLlm && !IsDynamicVariable && !IsOrOperator && !IsAndOperator && !IsEqOperator && !IsNeqOperator && !IsGtOperator && !IsLtOperator && !IsGteOperator && !IsLteOperator && !IsAddOperator && !IsSubOperator && !IsMulOperator && !IsDivOperator && IsConditionalOperator;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::ElevenLabs.ASTStringNodeOutput?, TResult>? stringLiteral = null,
            global::System.Func<global::ElevenLabs.ASTNumberNodeOutput?, TResult>? numberLiteral = null,
            global::System.Func<global::ElevenLabs.ASTBooleanNodeOutput?, TResult>? booleanLiteral = null,
            global::System.Func<global::ElevenLabs.ASTLLMNodeOutput?, TResult>? llm = null,
            global::System.Func<global::ElevenLabs.ASTDynamicVariableNodeOutput?, TResult>? dynamicVariable = null,
            global::System.Func<global::ElevenLabs.ASTOrOperatorNodeOutput?, TResult>? orOperator = null,
            global::System.Func<global::ElevenLabs.ASTAndOperatorNodeOutput?, TResult>? andOperator = null,
            global::System.Func<global::ElevenLabs.ASTEqualsOperatorNodeOutput?, TResult>? eqOperator = null,
            global::System.Func<global::ElevenLabs.ASTNotEqualsOperatorNodeOutput?, TResult>? neqOperator = null,
            global::System.Func<global::ElevenLabs.ASTGreaterThanOperatorNodeOutput?, TResult>? gtOperator = null,
            global::System.Func<global::ElevenLabs.ASTLessThanOperatorNodeOutput?, TResult>? ltOperator = null,
            global::System.Func<global::ElevenLabs.ASTGreaterThanOrEqualsOperatorNodeOutput?, TResult>? gteOperator = null,
            global::System.Func<global::ElevenLabs.ASTLessThanOrEqualsOperatorNodeOutput?, TResult>? lteOperator = null,
            global::System.Func<global::ElevenLabs.ASTAdditionOperatorNodeOutput?, TResult>? addOperator = null,
            global::System.Func<global::ElevenLabs.ASTSubtractionOperatorNodeOutput?, TResult>? subOperator = null,
            global::System.Func<global::ElevenLabs.ASTMultiplicationOperatorNodeOutput?, TResult>? mulOperator = null,
            global::System.Func<global::ElevenLabs.ASTDivisionOperatorNodeOutput?, TResult>? divOperator = null,
            global::System.Func<global::ElevenLabs.ASTConditionalOperatorNodeOutput?, TResult>? conditionalOperator = null,
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
            else if (IsLlm && llm != null)
            {
                return llm(Llm!);
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
            else if (IsAddOperator && addOperator != null)
            {
                return addOperator(AddOperator!);
            }
            else if (IsSubOperator && subOperator != null)
            {
                return subOperator(SubOperator!);
            }
            else if (IsMulOperator && mulOperator != null)
            {
                return mulOperator(MulOperator!);
            }
            else if (IsDivOperator && divOperator != null)
            {
                return divOperator(DivOperator!);
            }
            else if (IsConditionalOperator && conditionalOperator != null)
            {
                return conditionalOperator(ConditionalOperator!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::ElevenLabs.ASTStringNodeOutput?>? stringLiteral = null,
            global::System.Action<global::ElevenLabs.ASTNumberNodeOutput?>? numberLiteral = null,
            global::System.Action<global::ElevenLabs.ASTBooleanNodeOutput?>? booleanLiteral = null,
            global::System.Action<global::ElevenLabs.ASTLLMNodeOutput?>? llm = null,
            global::System.Action<global::ElevenLabs.ASTDynamicVariableNodeOutput?>? dynamicVariable = null,
            global::System.Action<global::ElevenLabs.ASTOrOperatorNodeOutput?>? orOperator = null,
            global::System.Action<global::ElevenLabs.ASTAndOperatorNodeOutput?>? andOperator = null,
            global::System.Action<global::ElevenLabs.ASTEqualsOperatorNodeOutput?>? eqOperator = null,
            global::System.Action<global::ElevenLabs.ASTNotEqualsOperatorNodeOutput?>? neqOperator = null,
            global::System.Action<global::ElevenLabs.ASTGreaterThanOperatorNodeOutput?>? gtOperator = null,
            global::System.Action<global::ElevenLabs.ASTLessThanOperatorNodeOutput?>? ltOperator = null,
            global::System.Action<global::ElevenLabs.ASTGreaterThanOrEqualsOperatorNodeOutput?>? gteOperator = null,
            global::System.Action<global::ElevenLabs.ASTLessThanOrEqualsOperatorNodeOutput?>? lteOperator = null,
            global::System.Action<global::ElevenLabs.ASTAdditionOperatorNodeOutput?>? addOperator = null,
            global::System.Action<global::ElevenLabs.ASTSubtractionOperatorNodeOutput?>? subOperator = null,
            global::System.Action<global::ElevenLabs.ASTMultiplicationOperatorNodeOutput?>? mulOperator = null,
            global::System.Action<global::ElevenLabs.ASTDivisionOperatorNodeOutput?>? divOperator = null,
            global::System.Action<global::ElevenLabs.ASTConditionalOperatorNodeOutput?>? conditionalOperator = null,
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
            else if (IsLlm)
            {
                llm?.Invoke(Llm!);
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
            else if (IsAddOperator)
            {
                addOperator?.Invoke(AddOperator!);
            }
            else if (IsSubOperator)
            {
                subOperator?.Invoke(SubOperator!);
            }
            else if (IsMulOperator)
            {
                mulOperator?.Invoke(MulOperator!);
            }
            else if (IsDivOperator)
            {
                divOperator?.Invoke(DivOperator!);
            }
            else if (IsConditionalOperator)
            {
                conditionalOperator?.Invoke(ConditionalOperator!);
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
                typeof(global::ElevenLabs.ASTStringNodeOutput),
                NumberLiteral,
                typeof(global::ElevenLabs.ASTNumberNodeOutput),
                BooleanLiteral,
                typeof(global::ElevenLabs.ASTBooleanNodeOutput),
                Llm,
                typeof(global::ElevenLabs.ASTLLMNodeOutput),
                DynamicVariable,
                typeof(global::ElevenLabs.ASTDynamicVariableNodeOutput),
                OrOperator,
                typeof(global::ElevenLabs.ASTOrOperatorNodeOutput),
                AndOperator,
                typeof(global::ElevenLabs.ASTAndOperatorNodeOutput),
                EqOperator,
                typeof(global::ElevenLabs.ASTEqualsOperatorNodeOutput),
                NeqOperator,
                typeof(global::ElevenLabs.ASTNotEqualsOperatorNodeOutput),
                GtOperator,
                typeof(global::ElevenLabs.ASTGreaterThanOperatorNodeOutput),
                LtOperator,
                typeof(global::ElevenLabs.ASTLessThanOperatorNodeOutput),
                GteOperator,
                typeof(global::ElevenLabs.ASTGreaterThanOrEqualsOperatorNodeOutput),
                LteOperator,
                typeof(global::ElevenLabs.ASTLessThanOrEqualsOperatorNodeOutput),
                AddOperator,
                typeof(global::ElevenLabs.ASTAdditionOperatorNodeOutput),
                SubOperator,
                typeof(global::ElevenLabs.ASTSubtractionOperatorNodeOutput),
                MulOperator,
                typeof(global::ElevenLabs.ASTMultiplicationOperatorNodeOutput),
                DivOperator,
                typeof(global::ElevenLabs.ASTDivisionOperatorNodeOutput),
                ConditionalOperator,
                typeof(global::ElevenLabs.ASTConditionalOperatorNodeOutput),
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
        public bool Equals(FalseExpression2 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.ASTStringNodeOutput?>.Default.Equals(StringLiteral, other.StringLiteral) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.ASTNumberNodeOutput?>.Default.Equals(NumberLiteral, other.NumberLiteral) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.ASTBooleanNodeOutput?>.Default.Equals(BooleanLiteral, other.BooleanLiteral) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.ASTLLMNodeOutput?>.Default.Equals(Llm, other.Llm) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.ASTDynamicVariableNodeOutput?>.Default.Equals(DynamicVariable, other.DynamicVariable) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.ASTOrOperatorNodeOutput?>.Default.Equals(OrOperator, other.OrOperator) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.ASTAndOperatorNodeOutput?>.Default.Equals(AndOperator, other.AndOperator) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.ASTEqualsOperatorNodeOutput?>.Default.Equals(EqOperator, other.EqOperator) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.ASTNotEqualsOperatorNodeOutput?>.Default.Equals(NeqOperator, other.NeqOperator) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.ASTGreaterThanOperatorNodeOutput?>.Default.Equals(GtOperator, other.GtOperator) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.ASTLessThanOperatorNodeOutput?>.Default.Equals(LtOperator, other.LtOperator) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.ASTGreaterThanOrEqualsOperatorNodeOutput?>.Default.Equals(GteOperator, other.GteOperator) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.ASTLessThanOrEqualsOperatorNodeOutput?>.Default.Equals(LteOperator, other.LteOperator) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.ASTAdditionOperatorNodeOutput?>.Default.Equals(AddOperator, other.AddOperator) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.ASTSubtractionOperatorNodeOutput?>.Default.Equals(SubOperator, other.SubOperator) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.ASTMultiplicationOperatorNodeOutput?>.Default.Equals(MulOperator, other.MulOperator) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.ASTDivisionOperatorNodeOutput?>.Default.Equals(DivOperator, other.DivOperator) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.ASTConditionalOperatorNodeOutput?>.Default.Equals(ConditionalOperator, other.ConditionalOperator) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(FalseExpression2 obj1, FalseExpression2 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<FalseExpression2>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(FalseExpression2 obj1, FalseExpression2 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is FalseExpression2 o && Equals(o);
        }
    }
}
