#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ASTNodeOutput : global::System.IEquatable<ASTNodeOutput>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::ElevenLabs.ASTNodeOutputDiscriminatorType? Type { get; }

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
        /// 
        /// </summary>
        public bool TryPickStringLiteral(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.ASTStringNodeOutput? value)
        {
            value = StringLiteral;
            return IsStringLiteral;
        }

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
        /// 
        /// </summary>
        public bool TryPickNumberLiteral(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.ASTNumberNodeOutput? value)
        {
            value = NumberLiteral;
            return IsNumberLiteral;
        }

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
        /// 
        /// </summary>
        public bool TryPickBooleanLiteral(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.ASTBooleanNodeOutput? value)
        {
            value = BooleanLiteral;
            return IsBooleanLiteral;
        }

        /// <summary>
        /// Null literal.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::ElevenLabs.ASTNullNodeOutput? NullLiteral { get; init; }
#else
        public global::ElevenLabs.ASTNullNodeOutput? NullLiteral { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(NullLiteral))]
#endif
        public bool IsNullLiteral => NullLiteral != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickNullLiteral(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.ASTNullNodeOutput? value)
        {
            value = NullLiteral;
            return IsNullLiteral;
        }

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
        /// 
        /// </summary>
        public bool TryPickLlm(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.ASTLLMNodeOutput? value)
        {
            value = Llm;
            return IsLlm;
        }

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
        /// 
        /// </summary>
        public bool TryPickDynamicVariable(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.ASTDynamicVariableNodeOutput? value)
        {
            value = DynamicVariable;
            return IsDynamicVariable;
        }

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
        /// 
        /// </summary>
        public bool TryPickOrOperator(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.ASTOrOperatorNodeOutput? value)
        {
            value = OrOperator;
            return IsOrOperator;
        }

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
        /// 
        /// </summary>
        public bool TryPickAndOperator(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.ASTAndOperatorNodeOutput? value)
        {
            value = AndOperator;
            return IsAndOperator;
        }

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
        /// 
        /// </summary>
        public bool TryPickEqOperator(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.ASTEqualsOperatorNodeOutput? value)
        {
            value = EqOperator;
            return IsEqOperator;
        }

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
        /// 
        /// </summary>
        public bool TryPickNeqOperator(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.ASTNotEqualsOperatorNodeOutput? value)
        {
            value = NeqOperator;
            return IsNeqOperator;
        }

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
        /// 
        /// </summary>
        public bool TryPickGtOperator(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.ASTGreaterThanOperatorNodeOutput? value)
        {
            value = GtOperator;
            return IsGtOperator;
        }

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
        /// 
        /// </summary>
        public bool TryPickLtOperator(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.ASTLessThanOperatorNodeOutput? value)
        {
            value = LtOperator;
            return IsLtOperator;
        }

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
        /// 
        /// </summary>
        public bool TryPickGteOperator(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.ASTGreaterThanOrEqualsOperatorNodeOutput? value)
        {
            value = GteOperator;
            return IsGteOperator;
        }

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
        /// 
        /// </summary>
        public bool TryPickLteOperator(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.ASTLessThanOrEqualsOperatorNodeOutput? value)
        {
            value = LteOperator;
            return IsLteOperator;
        }

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
        /// 
        /// </summary>
        public bool TryPickAddOperator(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.ASTAdditionOperatorNodeOutput? value)
        {
            value = AddOperator;
            return IsAddOperator;
        }

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
        /// 
        /// </summary>
        public bool TryPickSubOperator(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.ASTSubtractionOperatorNodeOutput? value)
        {
            value = SubOperator;
            return IsSubOperator;
        }

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
        /// 
        /// </summary>
        public bool TryPickMulOperator(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.ASTMultiplicationOperatorNodeOutput? value)
        {
            value = MulOperator;
            return IsMulOperator;
        }

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
        /// 
        /// </summary>
        public bool TryPickDivOperator(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.ASTDivisionOperatorNodeOutput? value)
        {
            value = DivOperator;
            return IsDivOperator;
        }

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
        public bool TryPickConditionalOperator(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::ElevenLabs.ASTConditionalOperatorNodeOutput? value)
        {
            value = ConditionalOperator;
            return IsConditionalOperator;
        }
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ASTNodeOutput(global::ElevenLabs.ASTStringNodeOutput value) => new ASTNodeOutput((global::ElevenLabs.ASTStringNodeOutput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.ASTStringNodeOutput?(ASTNodeOutput @this) => @this.StringLiteral;

        /// <summary>
        /// 
        /// </summary>
        public ASTNodeOutput(global::ElevenLabs.ASTStringNodeOutput? value)
        {
            StringLiteral = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ASTNodeOutput(global::ElevenLabs.ASTNumberNodeOutput value) => new ASTNodeOutput((global::ElevenLabs.ASTNumberNodeOutput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.ASTNumberNodeOutput?(ASTNodeOutput @this) => @this.NumberLiteral;

        /// <summary>
        /// 
        /// </summary>
        public ASTNodeOutput(global::ElevenLabs.ASTNumberNodeOutput? value)
        {
            NumberLiteral = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ASTNodeOutput(global::ElevenLabs.ASTBooleanNodeOutput value) => new ASTNodeOutput((global::ElevenLabs.ASTBooleanNodeOutput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.ASTBooleanNodeOutput?(ASTNodeOutput @this) => @this.BooleanLiteral;

        /// <summary>
        /// 
        /// </summary>
        public ASTNodeOutput(global::ElevenLabs.ASTBooleanNodeOutput? value)
        {
            BooleanLiteral = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ASTNodeOutput(global::ElevenLabs.ASTNullNodeOutput value) => new ASTNodeOutput((global::ElevenLabs.ASTNullNodeOutput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.ASTNullNodeOutput?(ASTNodeOutput @this) => @this.NullLiteral;

        /// <summary>
        /// 
        /// </summary>
        public ASTNodeOutput(global::ElevenLabs.ASTNullNodeOutput? value)
        {
            NullLiteral = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ASTNodeOutput(global::ElevenLabs.ASTLLMNodeOutput value) => new ASTNodeOutput((global::ElevenLabs.ASTLLMNodeOutput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.ASTLLMNodeOutput?(ASTNodeOutput @this) => @this.Llm;

        /// <summary>
        /// 
        /// </summary>
        public ASTNodeOutput(global::ElevenLabs.ASTLLMNodeOutput? value)
        {
            Llm = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ASTNodeOutput(global::ElevenLabs.ASTDynamicVariableNodeOutput value) => new ASTNodeOutput((global::ElevenLabs.ASTDynamicVariableNodeOutput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.ASTDynamicVariableNodeOutput?(ASTNodeOutput @this) => @this.DynamicVariable;

        /// <summary>
        /// 
        /// </summary>
        public ASTNodeOutput(global::ElevenLabs.ASTDynamicVariableNodeOutput? value)
        {
            DynamicVariable = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ASTNodeOutput(global::ElevenLabs.ASTOrOperatorNodeOutput value) => new ASTNodeOutput((global::ElevenLabs.ASTOrOperatorNodeOutput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.ASTOrOperatorNodeOutput?(ASTNodeOutput @this) => @this.OrOperator;

        /// <summary>
        /// 
        /// </summary>
        public ASTNodeOutput(global::ElevenLabs.ASTOrOperatorNodeOutput? value)
        {
            OrOperator = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ASTNodeOutput(global::ElevenLabs.ASTAndOperatorNodeOutput value) => new ASTNodeOutput((global::ElevenLabs.ASTAndOperatorNodeOutput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.ASTAndOperatorNodeOutput?(ASTNodeOutput @this) => @this.AndOperator;

        /// <summary>
        /// 
        /// </summary>
        public ASTNodeOutput(global::ElevenLabs.ASTAndOperatorNodeOutput? value)
        {
            AndOperator = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ASTNodeOutput(global::ElevenLabs.ASTEqualsOperatorNodeOutput value) => new ASTNodeOutput((global::ElevenLabs.ASTEqualsOperatorNodeOutput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.ASTEqualsOperatorNodeOutput?(ASTNodeOutput @this) => @this.EqOperator;

        /// <summary>
        /// 
        /// </summary>
        public ASTNodeOutput(global::ElevenLabs.ASTEqualsOperatorNodeOutput? value)
        {
            EqOperator = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ASTNodeOutput(global::ElevenLabs.ASTNotEqualsOperatorNodeOutput value) => new ASTNodeOutput((global::ElevenLabs.ASTNotEqualsOperatorNodeOutput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.ASTNotEqualsOperatorNodeOutput?(ASTNodeOutput @this) => @this.NeqOperator;

        /// <summary>
        /// 
        /// </summary>
        public ASTNodeOutput(global::ElevenLabs.ASTNotEqualsOperatorNodeOutput? value)
        {
            NeqOperator = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ASTNodeOutput(global::ElevenLabs.ASTGreaterThanOperatorNodeOutput value) => new ASTNodeOutput((global::ElevenLabs.ASTGreaterThanOperatorNodeOutput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.ASTGreaterThanOperatorNodeOutput?(ASTNodeOutput @this) => @this.GtOperator;

        /// <summary>
        /// 
        /// </summary>
        public ASTNodeOutput(global::ElevenLabs.ASTGreaterThanOperatorNodeOutput? value)
        {
            GtOperator = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ASTNodeOutput(global::ElevenLabs.ASTLessThanOperatorNodeOutput value) => new ASTNodeOutput((global::ElevenLabs.ASTLessThanOperatorNodeOutput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.ASTLessThanOperatorNodeOutput?(ASTNodeOutput @this) => @this.LtOperator;

        /// <summary>
        /// 
        /// </summary>
        public ASTNodeOutput(global::ElevenLabs.ASTLessThanOperatorNodeOutput? value)
        {
            LtOperator = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ASTNodeOutput(global::ElevenLabs.ASTGreaterThanOrEqualsOperatorNodeOutput value) => new ASTNodeOutput((global::ElevenLabs.ASTGreaterThanOrEqualsOperatorNodeOutput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.ASTGreaterThanOrEqualsOperatorNodeOutput?(ASTNodeOutput @this) => @this.GteOperator;

        /// <summary>
        /// 
        /// </summary>
        public ASTNodeOutput(global::ElevenLabs.ASTGreaterThanOrEqualsOperatorNodeOutput? value)
        {
            GteOperator = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ASTNodeOutput(global::ElevenLabs.ASTLessThanOrEqualsOperatorNodeOutput value) => new ASTNodeOutput((global::ElevenLabs.ASTLessThanOrEqualsOperatorNodeOutput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.ASTLessThanOrEqualsOperatorNodeOutput?(ASTNodeOutput @this) => @this.LteOperator;

        /// <summary>
        /// 
        /// </summary>
        public ASTNodeOutput(global::ElevenLabs.ASTLessThanOrEqualsOperatorNodeOutput? value)
        {
            LteOperator = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ASTNodeOutput(global::ElevenLabs.ASTAdditionOperatorNodeOutput value) => new ASTNodeOutput((global::ElevenLabs.ASTAdditionOperatorNodeOutput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.ASTAdditionOperatorNodeOutput?(ASTNodeOutput @this) => @this.AddOperator;

        /// <summary>
        /// 
        /// </summary>
        public ASTNodeOutput(global::ElevenLabs.ASTAdditionOperatorNodeOutput? value)
        {
            AddOperator = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ASTNodeOutput(global::ElevenLabs.ASTSubtractionOperatorNodeOutput value) => new ASTNodeOutput((global::ElevenLabs.ASTSubtractionOperatorNodeOutput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.ASTSubtractionOperatorNodeOutput?(ASTNodeOutput @this) => @this.SubOperator;

        /// <summary>
        /// 
        /// </summary>
        public ASTNodeOutput(global::ElevenLabs.ASTSubtractionOperatorNodeOutput? value)
        {
            SubOperator = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ASTNodeOutput(global::ElevenLabs.ASTMultiplicationOperatorNodeOutput value) => new ASTNodeOutput((global::ElevenLabs.ASTMultiplicationOperatorNodeOutput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.ASTMultiplicationOperatorNodeOutput?(ASTNodeOutput @this) => @this.MulOperator;

        /// <summary>
        /// 
        /// </summary>
        public ASTNodeOutput(global::ElevenLabs.ASTMultiplicationOperatorNodeOutput? value)
        {
            MulOperator = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ASTNodeOutput(global::ElevenLabs.ASTDivisionOperatorNodeOutput value) => new ASTNodeOutput((global::ElevenLabs.ASTDivisionOperatorNodeOutput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.ASTDivisionOperatorNodeOutput?(ASTNodeOutput @this) => @this.DivOperator;

        /// <summary>
        /// 
        /// </summary>
        public ASTNodeOutput(global::ElevenLabs.ASTDivisionOperatorNodeOutput? value)
        {
            DivOperator = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ASTNodeOutput(global::ElevenLabs.ASTConditionalOperatorNodeOutput value) => new ASTNodeOutput((global::ElevenLabs.ASTConditionalOperatorNodeOutput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::ElevenLabs.ASTConditionalOperatorNodeOutput?(ASTNodeOutput @this) => @this.ConditionalOperator;

        /// <summary>
        /// 
        /// </summary>
        public ASTNodeOutput(global::ElevenLabs.ASTConditionalOperatorNodeOutput? value)
        {
            ConditionalOperator = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ASTNodeOutput(
            global::ElevenLabs.ASTNodeOutputDiscriminatorType? type,
            global::ElevenLabs.ASTStringNodeOutput? stringLiteral,
            global::ElevenLabs.ASTNumberNodeOutput? numberLiteral,
            global::ElevenLabs.ASTBooleanNodeOutput? booleanLiteral,
            global::ElevenLabs.ASTNullNodeOutput? nullLiteral,
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
            NullLiteral = nullLiteral;
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
            NullLiteral as object ??
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
            NullLiteral?.ToString() ??
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
            return IsStringLiteral && !IsNumberLiteral && !IsBooleanLiteral && !IsNullLiteral && !IsLlm && !IsDynamicVariable && !IsOrOperator && !IsAndOperator && !IsEqOperator && !IsNeqOperator && !IsGtOperator && !IsLtOperator && !IsGteOperator && !IsLteOperator && !IsAddOperator && !IsSubOperator && !IsMulOperator && !IsDivOperator && !IsConditionalOperator || !IsStringLiteral && IsNumberLiteral && !IsBooleanLiteral && !IsNullLiteral && !IsLlm && !IsDynamicVariable && !IsOrOperator && !IsAndOperator && !IsEqOperator && !IsNeqOperator && !IsGtOperator && !IsLtOperator && !IsGteOperator && !IsLteOperator && !IsAddOperator && !IsSubOperator && !IsMulOperator && !IsDivOperator && !IsConditionalOperator || !IsStringLiteral && !IsNumberLiteral && IsBooleanLiteral && !IsNullLiteral && !IsLlm && !IsDynamicVariable && !IsOrOperator && !IsAndOperator && !IsEqOperator && !IsNeqOperator && !IsGtOperator && !IsLtOperator && !IsGteOperator && !IsLteOperator && !IsAddOperator && !IsSubOperator && !IsMulOperator && !IsDivOperator && !IsConditionalOperator || !IsStringLiteral && !IsNumberLiteral && !IsBooleanLiteral && IsNullLiteral && !IsLlm && !IsDynamicVariable && !IsOrOperator && !IsAndOperator && !IsEqOperator && !IsNeqOperator && !IsGtOperator && !IsLtOperator && !IsGteOperator && !IsLteOperator && !IsAddOperator && !IsSubOperator && !IsMulOperator && !IsDivOperator && !IsConditionalOperator || !IsStringLiteral && !IsNumberLiteral && !IsBooleanLiteral && !IsNullLiteral && IsLlm && !IsDynamicVariable && !IsOrOperator && !IsAndOperator && !IsEqOperator && !IsNeqOperator && !IsGtOperator && !IsLtOperator && !IsGteOperator && !IsLteOperator && !IsAddOperator && !IsSubOperator && !IsMulOperator && !IsDivOperator && !IsConditionalOperator || !IsStringLiteral && !IsNumberLiteral && !IsBooleanLiteral && !IsNullLiteral && !IsLlm && IsDynamicVariable && !IsOrOperator && !IsAndOperator && !IsEqOperator && !IsNeqOperator && !IsGtOperator && !IsLtOperator && !IsGteOperator && !IsLteOperator && !IsAddOperator && !IsSubOperator && !IsMulOperator && !IsDivOperator && !IsConditionalOperator || !IsStringLiteral && !IsNumberLiteral && !IsBooleanLiteral && !IsNullLiteral && !IsLlm && !IsDynamicVariable && IsOrOperator && !IsAndOperator && !IsEqOperator && !IsNeqOperator && !IsGtOperator && !IsLtOperator && !IsGteOperator && !IsLteOperator && !IsAddOperator && !IsSubOperator && !IsMulOperator && !IsDivOperator && !IsConditionalOperator || !IsStringLiteral && !IsNumberLiteral && !IsBooleanLiteral && !IsNullLiteral && !IsLlm && !IsDynamicVariable && !IsOrOperator && IsAndOperator && !IsEqOperator && !IsNeqOperator && !IsGtOperator && !IsLtOperator && !IsGteOperator && !IsLteOperator && !IsAddOperator && !IsSubOperator && !IsMulOperator && !IsDivOperator && !IsConditionalOperator || !IsStringLiteral && !IsNumberLiteral && !IsBooleanLiteral && !IsNullLiteral && !IsLlm && !IsDynamicVariable && !IsOrOperator && !IsAndOperator && IsEqOperator && !IsNeqOperator && !IsGtOperator && !IsLtOperator && !IsGteOperator && !IsLteOperator && !IsAddOperator && !IsSubOperator && !IsMulOperator && !IsDivOperator && !IsConditionalOperator || !IsStringLiteral && !IsNumberLiteral && !IsBooleanLiteral && !IsNullLiteral && !IsLlm && !IsDynamicVariable && !IsOrOperator && !IsAndOperator && !IsEqOperator && IsNeqOperator && !IsGtOperator && !IsLtOperator && !IsGteOperator && !IsLteOperator && !IsAddOperator && !IsSubOperator && !IsMulOperator && !IsDivOperator && !IsConditionalOperator || !IsStringLiteral && !IsNumberLiteral && !IsBooleanLiteral && !IsNullLiteral && !IsLlm && !IsDynamicVariable && !IsOrOperator && !IsAndOperator && !IsEqOperator && !IsNeqOperator && IsGtOperator && !IsLtOperator && !IsGteOperator && !IsLteOperator && !IsAddOperator && !IsSubOperator && !IsMulOperator && !IsDivOperator && !IsConditionalOperator || !IsStringLiteral && !IsNumberLiteral && !IsBooleanLiteral && !IsNullLiteral && !IsLlm && !IsDynamicVariable && !IsOrOperator && !IsAndOperator && !IsEqOperator && !IsNeqOperator && !IsGtOperator && IsLtOperator && !IsGteOperator && !IsLteOperator && !IsAddOperator && !IsSubOperator && !IsMulOperator && !IsDivOperator && !IsConditionalOperator || !IsStringLiteral && !IsNumberLiteral && !IsBooleanLiteral && !IsNullLiteral && !IsLlm && !IsDynamicVariable && !IsOrOperator && !IsAndOperator && !IsEqOperator && !IsNeqOperator && !IsGtOperator && !IsLtOperator && IsGteOperator && !IsLteOperator && !IsAddOperator && !IsSubOperator && !IsMulOperator && !IsDivOperator && !IsConditionalOperator || !IsStringLiteral && !IsNumberLiteral && !IsBooleanLiteral && !IsNullLiteral && !IsLlm && !IsDynamicVariable && !IsOrOperator && !IsAndOperator && !IsEqOperator && !IsNeqOperator && !IsGtOperator && !IsLtOperator && !IsGteOperator && IsLteOperator && !IsAddOperator && !IsSubOperator && !IsMulOperator && !IsDivOperator && !IsConditionalOperator || !IsStringLiteral && !IsNumberLiteral && !IsBooleanLiteral && !IsNullLiteral && !IsLlm && !IsDynamicVariable && !IsOrOperator && !IsAndOperator && !IsEqOperator && !IsNeqOperator && !IsGtOperator && !IsLtOperator && !IsGteOperator && !IsLteOperator && IsAddOperator && !IsSubOperator && !IsMulOperator && !IsDivOperator && !IsConditionalOperator || !IsStringLiteral && !IsNumberLiteral && !IsBooleanLiteral && !IsNullLiteral && !IsLlm && !IsDynamicVariable && !IsOrOperator && !IsAndOperator && !IsEqOperator && !IsNeqOperator && !IsGtOperator && !IsLtOperator && !IsGteOperator && !IsLteOperator && !IsAddOperator && IsSubOperator && !IsMulOperator && !IsDivOperator && !IsConditionalOperator || !IsStringLiteral && !IsNumberLiteral && !IsBooleanLiteral && !IsNullLiteral && !IsLlm && !IsDynamicVariable && !IsOrOperator && !IsAndOperator && !IsEqOperator && !IsNeqOperator && !IsGtOperator && !IsLtOperator && !IsGteOperator && !IsLteOperator && !IsAddOperator && !IsSubOperator && IsMulOperator && !IsDivOperator && !IsConditionalOperator || !IsStringLiteral && !IsNumberLiteral && !IsBooleanLiteral && !IsNullLiteral && !IsLlm && !IsDynamicVariable && !IsOrOperator && !IsAndOperator && !IsEqOperator && !IsNeqOperator && !IsGtOperator && !IsLtOperator && !IsGteOperator && !IsLteOperator && !IsAddOperator && !IsSubOperator && !IsMulOperator && IsDivOperator && !IsConditionalOperator || !IsStringLiteral && !IsNumberLiteral && !IsBooleanLiteral && !IsNullLiteral && !IsLlm && !IsDynamicVariable && !IsOrOperator && !IsAndOperator && !IsEqOperator && !IsNeqOperator && !IsGtOperator && !IsLtOperator && !IsGteOperator && !IsLteOperator && !IsAddOperator && !IsSubOperator && !IsMulOperator && !IsDivOperator && IsConditionalOperator;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::ElevenLabs.ASTStringNodeOutput, TResult>? stringLiteral = null,
            global::System.Func<global::ElevenLabs.ASTNumberNodeOutput, TResult>? numberLiteral = null,
            global::System.Func<global::ElevenLabs.ASTBooleanNodeOutput, TResult>? booleanLiteral = null,
            global::System.Func<global::ElevenLabs.ASTNullNodeOutput, TResult>? nullLiteral = null,
            global::System.Func<global::ElevenLabs.ASTLLMNodeOutput, TResult>? llm = null,
            global::System.Func<global::ElevenLabs.ASTDynamicVariableNodeOutput, TResult>? dynamicVariable = null,
            global::System.Func<global::ElevenLabs.ASTOrOperatorNodeOutput, TResult>? orOperator = null,
            global::System.Func<global::ElevenLabs.ASTAndOperatorNodeOutput, TResult>? andOperator = null,
            global::System.Func<global::ElevenLabs.ASTEqualsOperatorNodeOutput, TResult>? eqOperator = null,
            global::System.Func<global::ElevenLabs.ASTNotEqualsOperatorNodeOutput, TResult>? neqOperator = null,
            global::System.Func<global::ElevenLabs.ASTGreaterThanOperatorNodeOutput, TResult>? gtOperator = null,
            global::System.Func<global::ElevenLabs.ASTLessThanOperatorNodeOutput, TResult>? ltOperator = null,
            global::System.Func<global::ElevenLabs.ASTGreaterThanOrEqualsOperatorNodeOutput, TResult>? gteOperator = null,
            global::System.Func<global::ElevenLabs.ASTLessThanOrEqualsOperatorNodeOutput, TResult>? lteOperator = null,
            global::System.Func<global::ElevenLabs.ASTAdditionOperatorNodeOutput, TResult>? addOperator = null,
            global::System.Func<global::ElevenLabs.ASTSubtractionOperatorNodeOutput, TResult>? subOperator = null,
            global::System.Func<global::ElevenLabs.ASTMultiplicationOperatorNodeOutput, TResult>? mulOperator = null,
            global::System.Func<global::ElevenLabs.ASTDivisionOperatorNodeOutput, TResult>? divOperator = null,
            global::System.Func<global::ElevenLabs.ASTConditionalOperatorNodeOutput, TResult>? conditionalOperator = null,
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
            else if (IsNullLiteral && nullLiteral != null)
            {
                return nullLiteral(NullLiteral!);
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
            global::System.Action<global::ElevenLabs.ASTStringNodeOutput>? stringLiteral = null,

            global::System.Action<global::ElevenLabs.ASTNumberNodeOutput>? numberLiteral = null,

            global::System.Action<global::ElevenLabs.ASTBooleanNodeOutput>? booleanLiteral = null,

            global::System.Action<global::ElevenLabs.ASTNullNodeOutput>? nullLiteral = null,

            global::System.Action<global::ElevenLabs.ASTLLMNodeOutput>? llm = null,

            global::System.Action<global::ElevenLabs.ASTDynamicVariableNodeOutput>? dynamicVariable = null,

            global::System.Action<global::ElevenLabs.ASTOrOperatorNodeOutput>? orOperator = null,

            global::System.Action<global::ElevenLabs.ASTAndOperatorNodeOutput>? andOperator = null,

            global::System.Action<global::ElevenLabs.ASTEqualsOperatorNodeOutput>? eqOperator = null,

            global::System.Action<global::ElevenLabs.ASTNotEqualsOperatorNodeOutput>? neqOperator = null,

            global::System.Action<global::ElevenLabs.ASTGreaterThanOperatorNodeOutput>? gtOperator = null,

            global::System.Action<global::ElevenLabs.ASTLessThanOperatorNodeOutput>? ltOperator = null,

            global::System.Action<global::ElevenLabs.ASTGreaterThanOrEqualsOperatorNodeOutput>? gteOperator = null,

            global::System.Action<global::ElevenLabs.ASTLessThanOrEqualsOperatorNodeOutput>? lteOperator = null,

            global::System.Action<global::ElevenLabs.ASTAdditionOperatorNodeOutput>? addOperator = null,

            global::System.Action<global::ElevenLabs.ASTSubtractionOperatorNodeOutput>? subOperator = null,

            global::System.Action<global::ElevenLabs.ASTMultiplicationOperatorNodeOutput>? mulOperator = null,

            global::System.Action<global::ElevenLabs.ASTDivisionOperatorNodeOutput>? divOperator = null,

            global::System.Action<global::ElevenLabs.ASTConditionalOperatorNodeOutput>? conditionalOperator = null,
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
            else if (IsNullLiteral)
            {
                nullLiteral?.Invoke(NullLiteral!);
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
        public void Switch(
            global::System.Action<global::ElevenLabs.ASTStringNodeOutput>? stringLiteral = null,
            global::System.Action<global::ElevenLabs.ASTNumberNodeOutput>? numberLiteral = null,
            global::System.Action<global::ElevenLabs.ASTBooleanNodeOutput>? booleanLiteral = null,
            global::System.Action<global::ElevenLabs.ASTNullNodeOutput>? nullLiteral = null,
            global::System.Action<global::ElevenLabs.ASTLLMNodeOutput>? llm = null,
            global::System.Action<global::ElevenLabs.ASTDynamicVariableNodeOutput>? dynamicVariable = null,
            global::System.Action<global::ElevenLabs.ASTOrOperatorNodeOutput>? orOperator = null,
            global::System.Action<global::ElevenLabs.ASTAndOperatorNodeOutput>? andOperator = null,
            global::System.Action<global::ElevenLabs.ASTEqualsOperatorNodeOutput>? eqOperator = null,
            global::System.Action<global::ElevenLabs.ASTNotEqualsOperatorNodeOutput>? neqOperator = null,
            global::System.Action<global::ElevenLabs.ASTGreaterThanOperatorNodeOutput>? gtOperator = null,
            global::System.Action<global::ElevenLabs.ASTLessThanOperatorNodeOutput>? ltOperator = null,
            global::System.Action<global::ElevenLabs.ASTGreaterThanOrEqualsOperatorNodeOutput>? gteOperator = null,
            global::System.Action<global::ElevenLabs.ASTLessThanOrEqualsOperatorNodeOutput>? lteOperator = null,
            global::System.Action<global::ElevenLabs.ASTAdditionOperatorNodeOutput>? addOperator = null,
            global::System.Action<global::ElevenLabs.ASTSubtractionOperatorNodeOutput>? subOperator = null,
            global::System.Action<global::ElevenLabs.ASTMultiplicationOperatorNodeOutput>? mulOperator = null,
            global::System.Action<global::ElevenLabs.ASTDivisionOperatorNodeOutput>? divOperator = null,
            global::System.Action<global::ElevenLabs.ASTConditionalOperatorNodeOutput>? conditionalOperator = null,
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
            else if (IsNullLiteral)
            {
                nullLiteral?.Invoke(NullLiteral!);
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
                NullLiteral,
                typeof(global::ElevenLabs.ASTNullNodeOutput),
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
        public bool Equals(ASTNodeOutput other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.ASTStringNodeOutput?>.Default.Equals(StringLiteral, other.StringLiteral) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.ASTNumberNodeOutput?>.Default.Equals(NumberLiteral, other.NumberLiteral) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.ASTBooleanNodeOutput?>.Default.Equals(BooleanLiteral, other.BooleanLiteral) &&
                global::System.Collections.Generic.EqualityComparer<global::ElevenLabs.ASTNullNodeOutput?>.Default.Equals(NullLiteral, other.NullLiteral) &&
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
        public static bool operator ==(ASTNodeOutput obj1, ASTNodeOutput obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ASTNodeOutput>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ASTNodeOutput obj1, ASTNodeOutput obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ASTNodeOutput o && Equals(o);
        }
    }
}
